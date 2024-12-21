using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.DTOs.Order;
using StoreManage.DTOs.OrderDetail;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class CartPage : UserControl
    {
        private readonly OrderController orderController;
        List<OrderDetailCreateDto> orderDetailList;
        public FlowLayoutPanel CartFlowLayout
        {
            get { return flowLayout; }
            set { flowLayout = value; }
        }
        public CartPage()
        {
            InitializeComponent();
            orderController = new OrderController(new ApiService());
            orderDetailList = new List<OrderDetailCreateDto>();
        }
        public void UpdateCartTotals() /* Cart Page */
        {
            decimal totalMoney = 0;
            decimal transportFee = 30000;  // Static transport fee (VND)
            decimal discount = 0;      // 20% discount

            // Calculate the total money based on the items in the cart
            foreach (Control control in flowLayout.Controls)
            {
                if (control is CartItem cartItem)
                {
                    // For each CartItem, calculate the price and quantity
                    decimal price = decimal.Parse(cartItem.ItemPrice.Replace(" VND", "").Replace(",", "").Replace("Cost: ",""));
                    decimal quantity = cartItem.NumericValue;
                    totalMoney += price * quantity;

                    discount += cartItem.ItemDiscoundPrice *quantity;
                }
            }

            // If the cart is empty, set the totals to zero or default values
            if (totalMoney == 0)
            {
                lbTotalMoney.Text = "0 VND";
                lbDiscount.Text = "0%";
                lbTransportFee.Text = $"0 VND";
                lbTotalOrder.Text = $"0 VND"; // Final total with only transport fee
            }
            else
            {
                // Apply discount and add transport fee
                //decimal totalAfterDiscount = totalMoney * (1 - discount);
                decimal finalTotal = totalMoney - discount + transportFee;

                // Update the labels on MainPage
                lbTotalMoney.Text = $"{totalMoney:N0} VND"; // Total before discount
                lbDiscount.Text = $"{discount:N0} VND";     // Discount percentage
                lbTransportFee.Text = $"{transportFee:N0} VND"; // Transport fee
                lbTotalOrder.Text = $"{finalTotal:N0} VND"; // Final total after discount and transport fee
            }
        }
        public void RemoveCartItem(CartItem cartItem) /* Cart Page */
        {
            // Remove the item from the cart
            flowLayout.Controls.Remove(cartItem);

            // Update the cart totals after removing the item
            UpdateCartTotals();
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            if (flowLayout.Controls.Count == 0)
            {
                MessageBox.Show("Hãy thêm sản phẩm vào giỏ hàng");
                return;
            }

            DialogResult resulT = MessageBox.Show("Bạn có chắc chắn muốn mua hàng?", "Xác nhận", MessageBoxButtons.YesNo);

            if (resulT == DialogResult.No)
            {
                return;
            }

            var mainform = this.FindForm() as MainForm;
            var employeeId = mainform.employeeId;

            List<OrderDetailCreateDto> orderDetailList = new List<OrderDetailCreateDto>();

            foreach (Control control in flowLayout.Controls)
            {
                if (control is CartItem cartItem)
                {
                    int productId = cartItem.ProductId;
                    int colorId = cartItem.SelectedColorId;
                    int sizeId = cartItem.SelectedSizeId;
                    int quantity = cartItem.Quantity;

                    OrderDetailCreateDto orderDetail = new OrderDetailCreateDto()
                    {
                        ProductId = productId,
                        ColorId = colorId,
                        SizeId = sizeId,
                        Quantity = quantity
                    };

                    orderDetailList.Add(orderDetail);
                }
            }

            OrderCreateDto orderCreateDto = new OrderCreateDto()
            {
                EmployeeId = employeeId,
                OrderDetails = orderDetailList
            };

            try
            {
                var response = await orderController.CreateAsync(orderCreateDto);

                if (response != null)
                {
                    MessageBox.Show("Order added successfully!");
                    ExportOrderToWord(response, lbTotalMoney.Text, lbDiscount.Text, lbTransportFee.Text);
                    flowLayout.Controls.Clear();
                    var _mainForm = this.FindForm() as MainForm;
                    _mainForm.cartInterface.UpdateCartTotals();
                    // Export to Word
                }
                else
                {
                    MessageBox.Show("Error creating order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                Console.WriteLine(ex.StackTrace); // Log stack trace for debugging
            }
        }

        private void ExportOrderToWord(OrderCreateDto order, string totalMoney, string discount, string transportFee)
        {
            try
            {
                // Initialize Word application
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var wordDoc = wordApp.Documents.Add();

                // Add shop name and order date
                var headerParagraph = wordDoc.Content.Paragraphs.Add();
                headerParagraph.Range.Text = $"Yody Clothing Shop #{order.OrderId}\nOrder Details";
                headerParagraph.Range.Font.Bold = 1;
                headerParagraph.Range.Font.Size = 16;
                headerParagraph.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerParagraph.Range.InsertParagraphAfter();

                var dateParagraph = wordDoc.Content.Paragraphs.Add();
                dateParagraph.Range.Text = $"Order Date: {DateTime.Now:dd-MM-yyyy HH:mm:ss}";
                dateParagraph.Format.SpaceAfter = 10;
                dateParagraph.Range.InsertParagraphAfter();

                // Add table for order details
                var paragraph = wordDoc.Content.Paragraphs.Add();
                var table = wordDoc.Tables.Add(paragraph.Range, order.OrderDetails.Count + 1, 5);
                table.Borders.Enable = 1;

                // Set header row
                table.Cell(1, 1).Range.Text = "Product Name";
                table.Cell(1, 2).Range.Text = "Color";
                table.Cell(1, 3).Range.Text = "Size";
                table.Cell(1, 4).Range.Text = "Quantity";
                table.Cell(1, 5).Range.Text = "Price (VND)";
                table.Rows[1].Range.Font.Bold = 1;

                // Populate table rows with order details
                int rowIndex = 2; // Start from the second row as the first row is the header
                foreach (var detail in order.OrderDetails)
                {
                    var cartItem = CartFlowLayout.Controls.OfType<CartItem>().FirstOrDefault(ci =>
                        ci.ProductId == detail.ProductId &&
                        ci.SelectedColorId == detail.ColorId &&
                        ci.SelectedSizeId == detail.SizeId);

                    if (cartItem != null)
                    {
                        table.Cell(rowIndex, 1).Range.Text = cartItem.ProductNameTitle;
                        table.Cell(rowIndex, 2).Range.Text = cartItem.SelectedColorName;
                        table.Cell(rowIndex, 3).Range.Text = cartItem.SelectedSize;
                        table.Cell(rowIndex, 4).Range.Text = cartItem.Quantity.ToString();
                        table.Cell(rowIndex, 5).Range.Text = cartItem.ItemPrice;
                        rowIndex++;
                    }
                }

                // Add totals in a neat layout
                var totalsParagraph = wordDoc.Content.Paragraphs.Add();
                totalsParagraph.Range.Text = $"\nSummary:";
                totalsParagraph.Range.Font.Bold = 1;
                totalsParagraph.Format.SpaceAfter = 10;
                totalsParagraph.Range.InsertParagraphAfter();

                var totalsTable = wordDoc.Tables.Add(totalsParagraph.Range, 4, 2); // 4 rows to include Total Bill
                totalsTable.Borders.Enable = 0;
                totalsTable.Columns[1].Width = 150; // Adjust column width for readability

                // Add summary rows
                totalsTable.Cell(1, 1).Range.Text = "Total Money:"; // Change Discount to Total Money
                totalsTable.Cell(1, 2).Range.Text = totalMoney;     // Set totalMoney in place of Discount

                totalsTable.Cell(2, 1).Range.Text = "Discount:";     // Change Transport Fee to Discount
                totalsTable.Cell(2, 2).Range.Text = discount;        // Set discount in place of Transport Fee

                totalsTable.Cell(3, 1).Range.Text = "Transport Fee:"; // Change Total Money to Transport Fee
                totalsTable.Cell(3, 2).Range.Text = transportFee;    // Set transportFee in place of Total Money

                // Add Total Bill row
                totalsTable.Cell(4, 1).Range.Text = "Total Bill:";
                totalsTable.Cell(4, 2).Range.Text = lbTotalOrder.Text;

                // Footer for shop details
                var footerParagraph = wordDoc.Content.Paragraphs.Add();
                footerParagraph.Range.Text = "\nThank you for shopping with us!";
                footerParagraph.Range.Font.Italic = 1;
                footerParagraph.Format.SpaceAfter = 10;
                footerParagraph.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                footerParagraph.Range.InsertParagraphAfter();

                // Determine the save path for Word file
                string appBasePath = AppDomain.CurrentDomain.BaseDirectory;
                string wordSavePath = Path.Combine(appBasePath, @"Resources\OrderDetails.docx");

                // Ensure the directory exists
                string saveDirectory = Path.GetDirectoryName(wordSavePath);
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                // Save the Word document
                wordDoc.SaveAs2(wordSavePath);

                // Save the document as PDF
                string pdfSavePath = Path.Combine(appBasePath, @"Resources\OrderDetails.pdf");
                wordDoc.ExportAsFixedFormat(pdfSavePath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

                // Close the Word application
                wordDoc.Close();
                wordApp.Quit();

                // Notify user about the export completion
                MessageBox.Show($"Order details exported to Word and PDF successfully at:\nWord: {wordSavePath}\nPDF: {pdfSavePath}");

                // Optionally, open the saved PDF file
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfSavePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting to Word and PDF: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
