using Guna.UI2.HtmlRenderer.Adapters;
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

namespace StoreManage.Components
{
    public partial class OrderDetail : UserControl
    {
        private readonly OrderController orderController;
        private int OrderId;
        public OrderDetail(int orderId)
        {
            InitializeComponent();
            orderController = new OrderController(new ApiService());
            LoadData(orderId);
            OrderId = orderId;
        }

        private async void LoadData(int orderId)
        {
            try
            {
                var response = await orderController.GetByIdAsync(orderId);
                if (response != null)
                {
                    LoadOrderDetails(response.OrderDetails); // Load order details
                }
                else
                {
                    Console.WriteLine("Error loading data");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }


        private void LoadOrderDetails(ICollection<OrderDetailDto> orders)
        {
            flowLayoutPanel.Controls.Clear(); // Clear previous controls

            // Create a header panel
            var headerPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(893 - 40, 50),  // Adjusted to fit width of 893
                BorderRadius = 10,
                ShadowDecoration = { Enabled = true, Shadow = new Padding(5) },
                BackColor = Color.FromArgb(0, 122, 204), // Header background color
                Margin = new Padding(5),
                Dock = DockStyle.Top
            };

            // Adjust header labels with consistent column widths
            int columnWidth = (893 - 40) / 5;  // Distribute width evenly for 5 columns

            var productNameHeaderLabel = new Label
            {
                Text = "Quantity",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(columnWidth, 50),  // Adjust width to fit 3 columns
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10) // Add padding at the bottom
            };

            var productPriceHeaderLabel = new Label
            {
                Text = "Color",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(columnWidth, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10)
            };

            var sizeHeaderLabel = new Label
            {
                Text = "Size",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(columnWidth, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10)
            };

            var colorHeaderLabel = new Label
            {
                Text = "Price",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(columnWidth, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10)
            };

            var quantityHeaderLabel = new Label
            {
                Text = "Product Name",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(columnWidth, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10)
            };

            // Add headers to the header panel
            headerPanel.Controls.Add(productNameHeaderLabel);
            headerPanel.Controls.Add(productPriceHeaderLabel);
            headerPanel.Controls.Add(sizeHeaderLabel);
            headerPanel.Controls.Add(colorHeaderLabel);
            headerPanel.Controls.Add(quantityHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the orders to create the data rows
            int rowIndex = 0; // Initialize row index
            foreach (var orderDetail in orders)
            {
                // Create a container panel for each row with shadow effect and rounded corners
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(893 - 40, 60),  // Adjusted to fit width of 893
                    BorderRadius = 10,
                    ShadowDecoration = { Enabled = true, Shadow = new Padding(2) },
                    BackColor = (rowIndex % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5),
                    Dock = DockStyle.Top
                };

                // Label for Product Name
                var productNameLabel = new Label
                {
                    Text = orderDetail.ProductName,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(columnWidth, 60),  // Adjust width for the product name
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5),
                    MaximumSize = new Size(columnWidth, 50), // Maximum size to prevent overflow
                    AutoEllipsis = true // Use ellipsis for overflow text
                };

                // Label for Product Price
                var productPriceLabel = new Label
                {
                    Text = FormatCurrency( orderDetail.ProductPrice),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(columnWidth, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };

                // Label for Size
                var sizeLabel = new Label
                {
                    Text = orderDetail.Size,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(columnWidth, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };

                // Label for Color
                var colorLabel = new Label
                {
                    Text = orderDetail.Color,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(columnWidth, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };

                // Label for Quantity
                var quantityLabel = new Label
                {
                    Text = orderDetail.Quantity.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(columnWidth, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5),
                    AutoEllipsis = true
                };
                // Add controls to the row panel
                rowPanel.Controls.Add(quantityLabel);
                rowPanel.Controls.Add(colorLabel);
                rowPanel.Controls.Add(sizeLabel);
                rowPanel.Controls.Add(productPriceLabel);
                rowPanel.Controls.Add(productNameLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);

                rowIndex++; // Increment row index
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            var response = await orderController.GetByIdAsync(OrderId);
            if (response != null)
            {
                ExportOrderToWordAndPdf(response);
            }
            else
            {
                MessageBox.Show("Unable to fetch order details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportOrderToWordAndPdf(OrderDto order)
        {
            string appBasePath = AppDomain.CurrentDomain.BaseDirectory;
            string wordSavePath = Path.Combine(appBasePath, @"Resources\OrderAdminDetails.docx");
            string pdfSavePath = Path.Combine(appBasePath, @"Resources\OrderAdminDetails.pdf");

            try
            {
                // Ensure the Resources folder exists
                string resourcesPath = Path.Combine(appBasePath, "Resources");
                if (!Directory.Exists(resourcesPath))
                {
                    Directory.CreateDirectory(resourcesPath);
                }

                // Initialize Word application
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var document = wordApp.Documents.Add();

                // Add a title
                var titleParagraph = document.Content.Paragraphs.Add();
                titleParagraph.Range.Text = "Order Details";
                titleParagraph.Range.Font.Bold = 1;
                titleParagraph.Range.Font.Size = 16;
                titleParagraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                titleParagraph.Range.InsertParagraphAfter();

                // Add Order Information
                var infoParagraph = document.Content.Paragraphs.Add();
                infoParagraph.Range.Text = $"Order ID: {order.OrderId}\n" +
                                           $"Employee Name: {order.EmployeeName}\n" +
                                           $"Export Date: {order.OrderExportDateTime:yyyy-MM-dd HH:mm:ss}\n" +
                                           $"Notice: {order.OrderNotice}\n" +
                                           $"Total Amount: {order.TotalAmount}\n" +
                                           $"Total: {FormatCurrency(order.Total)}\n" +
                                           $"Confirmed: {order.Confirmed}";
                infoParagraph.Range.Font.Size = 12;
                infoParagraph.Range.InsertParagraphAfter();

                // Add a table for order details
                var tableParagraph = document.Content.Paragraphs.Add();
                var range = tableParagraph.Range;
                var table = document.Tables.Add(range, order.OrderDetails.Count + 1, 6);
                table.Borders.Enable = 1;

                // Add headers to the table
                table.Cell(1, 1).Range.Text = "Product Name";
                table.Cell(1, 2).Range.Text = "Product Price";
                table.Cell(1, 3).Range.Text = "Price After Discount";
                table.Cell(1, 4).Range.Text = "Size";
                table.Cell(1, 5).Range.Text = "Color";
                table.Cell(1, 6).Range.Text = "Quantity";

                // Add rows for each order detail
                int rowIndex = 2; // Start from the second row
                foreach (var detail in order.OrderDetails)
                {
                    table.Cell(rowIndex, 1).Range.Text = detail.ProductName;
                    table.Cell(rowIndex, 2).Range.Text = FormatCurrency(detail.ProductPrice);
                    table.Cell(rowIndex, 3).Range.Text = FormatCurrency(detail.PriceAfterDiscount);
                    table.Cell(rowIndex, 4).Range.Text = detail.Size;
                    table.Cell(rowIndex, 5).Range.Text = detail.Color;
                    table.Cell(rowIndex, 6).Range.Text = detail.Quantity.ToString();
                    rowIndex++;
                }

                // Save the document in Word format
                document.SaveAs2(wordSavePath);

                // Export the document to PDF
                document.ExportAsFixedFormat(pdfSavePath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

                // Close the document and Word application
                document.Close();
                wordApp.Quit();

                // Open the PDF file after export
                if (File.Exists(pdfSavePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = pdfSavePath,
                        UseShellExecute = true // Required for opening files on modern systems
                    });
                }
                else
                {
                    MessageBox.Show("PDF file was not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to format currency in VNĐ
        private string FormatCurrency(decimal amount)
        {
            return $"{amount:N0} VNĐ"; // N0 formats the number with thousand separators and no decimals
        }



    }
}
