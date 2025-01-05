using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using StoreManage.DTOs.Order;
using StoreManage.DTOs.OrderDetail;
using StoreManage.Controllers;
using StoreManage.Services;
using Microsoft.Office.Interop.Word;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas;
using iText.Layout.Properties;
using System.IO;
namespace StoreManage.AdminForms.Pages
{
    public partial class AdminHomePage : UserControl
    {
        private readonly OrderController orderController;

        public AdminHomePage()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            // Initialize OrderController
            orderController = new OrderController(new ApiService());

            // Load chart data
            LoadProductChart();
            LoadTotalAmountChart();

        }

        private async void LoadProductChart()
        {
            try
            {
                // Fetch all orders
                var orders = await orderController.GetAllAsync();

                // Aggregate data: Calculate total quantity sold per product
                var productData = GetProductData(orders);

                // Configure the chart
                ConfigureChart(productData);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to aggregate the product data from orders
        private List<ProductChartData> GetProductData(List<OrderDto> orders)
        {
            return orders
                .SelectMany(order => order.OrderDetails)  // Flatten the list of order details
                .GroupBy(detail => detail.ProductName)    // Group by product name
                .Select(group => new ProductChartData
                {
                    ProductName = group.Key,
                    TotalQuantity = group.Sum(detail => detail.Quantity)
                })
                .OrderByDescending(data => data.TotalQuantity) // Optional: sort by total quantity sold
                .ToList();
        }

        // Method to configure the chart
        private void ConfigureChart(List<ProductChartData> productData)
        {
            // Clear previous chart data and settings
            chartProducts.Series.Clear();
            chartProducts.Titles.Clear();
            chartProducts.ChartAreas.Clear();

            // Add Chart Area
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = { Title = "Product Name", LabelAutoFitMaxFontSize = 10, IsLabelAutoFit = true }, // X-axis for product names
                AxisY = { Title = "Quantity Sold" }  // Y-axis for quantity sold
            };
            chartProducts.ChartAreas.Add(chartArea);

            // Add Chart Title
            chartProducts.Titles.Add("Number of Products Sold");

            // Add Series for each product
            foreach (var product in productData)
            {
                // Create a new series for each product
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = product.ProductName,  // Set the product name as the series name
                    ChartType = SeriesChartType.Column,  // Use column chart for vertical bars
                    XValueType = ChartValueType.String,  // X-axis will represent product names
                    YValueType = ChartValueType.Int32,  // Y-axis will represent quantity
                    IsValueShownAsLabel = true           // Show values on top of the columns
                };

                // Add data point to the series (each product will have one data point)
                series.Points.AddXY(product.ProductName, product.TotalQuantity);

                // Add the series to the chart
                chartProducts.Series.Add(series);
            }
        }
        private List<AmountChartData> GetTotalAmountData(List<OrderDto> orders)
        {
            return orders
                .GroupBy(order => order.OrderExportDateTime.Date)
                .Select(group => new AmountChartData
                {
                    Date = group.Key,
                    TotalAmount = group.Sum(order => order.TotalAmount)
                })
                .OrderBy(data => data.Date)
                .ToList();
        }
        private async void LoadTotalAmountChart(Func<List<OrderDto>, List<AmountChartData>> filterFunction = null)
        {
            try
            {
                var orders = await orderController.GetAllAsync();

                // Apply the selected filter (month, year, or all-time)
                var totalAmountData = filterFunction != null ? filterFunction(orders) : GetTotalAmountData(orders);

                ConfigureChartTotalAmount(totalAmountData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load total amount data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureChartTotalAmount(List<AmountChartData> totalAmountData)
        {
            chartTotalAmount.Series.Clear();
            chartTotalAmount.Titles.Clear();
            chartTotalAmount.ChartAreas.Clear();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = { Title = "Date", LabelAutoFitMaxFontSize = 10, IsLabelAutoFit = true },
                AxisY = { Title = "Total Amount" }
            };
            chartTotalAmount.ChartAreas.Add(chartArea);

            chartTotalAmount.Titles.Add("Total Amount per Date");

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "TotalAmount",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double,
                IsValueShownAsLabel = true
            };

            foreach (var data in totalAmountData)
            {
                series.Points.AddXY(data.Date, data.TotalAmount);
            }

            chartTotalAmount.Series.Add(series);
        }

        // Custom class to store product data for charting
        public class ProductChartData
        {
            public string ProductName { get; set; }
            public int TotalQuantity { get; set; }
        }
        public class AmountChartData
        {
            public DateTime Date { get; set; }
            public double TotalAmount { get; set; }
        }
        private double GetTotalIncome(List<OrderDto> orders)
        {
            return orders.Sum(order => (double)order.Total);  // Sum the 'Total' property of all orders
        }
        private void PrintTotalIncomeToWord(double totalIncome)
        {
            try
            {
                // Tạo một phiên bản của ứng dụng Word
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false; // Đặt là false để không hiển thị Word (tùy chọn)

                // Tạo một tài liệu mới
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

                // Thêm tiêu đề cho tài liệu
                Microsoft.Office.Interop.Word.Paragraph title = wordDoc.Paragraphs.Add();
                title.Range.Text = "Báo Cáo Thu Nhập Tổng";  // Tiêu đề báo cáo
                title.Range.Font.Size = 24;  // Đặt cỡ chữ cho tiêu đề
                title.Range.Font.Bold = 1;   // Làm đậm tiêu đề
                title.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;  // Canh giữa tiêu đề
                title.Range.InsertParagraphAfter();  // Đảm bảo có khoảng cách sau tiêu đề

                // Thêm phụ đề hoặc mô tả
                Microsoft.Office.Interop.Word.Paragraph subtitle = wordDoc.Paragraphs.Add();
                subtitle.Range.Text = "Báo cáo này tóm tắt tổng thu nhập của cửa hàng trong khoảng thời gian đã chọn.";
                subtitle.Range.Font.Size = 14;  // Cỡ chữ cho phụ đề
                subtitle.Range.Font.Italic = 1;  // Làm nghiêng phụ đề
                subtitle.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                subtitle.Range.InsertParagraphAfter();  // Đảm bảo có khoảng cách sau phụ đề

                // Thêm thông tin thu nhập tổng
                Microsoft.Office.Interop.Word.Paragraph totalIncomeParagraph = wordDoc.Paragraphs.Add();
                totalIncomeParagraph.Range.Text = $"Tổng Thu Nhập: {totalIncome:N0} VND";
                totalIncomeParagraph.Range.Font.Size = 16;  // Cỡ chữ cho thông tin thu nhập tổng
                totalIncomeParagraph.Range.Font.Bold = 1;   // Làm đậm văn bản thu nhập tổng
                totalIncomeParagraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                totalIncomeParagraph.Range.InsertParagraphAfter();  // Đảm bảo có khoảng cách sau đoạn văn này

                // Thêm chân trang với ngày hiện tại
                Microsoft.Office.Interop.Word.Paragraph footer = wordDoc.Paragraphs.Add();
                footer.Range.Text = $"Tạo vào ngày: {DateTime.Now:MMMM dd, yyyy}";
                footer.Range.Font.Size = 12;  // Cỡ chữ cho chân trang
                footer.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                footer.Range.InsertParagraphAfter();  // Đảm bảo có khoảng cách sau chân trang

                // Lưu tài liệu
                string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "BáoCaoThuNhapTổng.docx"); // Lưu trong thư mục của ứng dụng
                wordDoc.SaveAs2(filePath);
                wordDoc.Close();  // Đóng tài liệu

                // Đóng ứng dụng Word
                wordApp.Quit();

                // Mở tài liệu Word bằng ứng dụng mặc định (Word)
                System.Diagnostics.Process.Start(filePath);

                // Xác nhận việc tạo và mở tài liệu
                MessageBox.Show($"Tài liệu Word đã được tạo và mở thành công tại {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi chi tiết
                string errorMessage = $"Lỗi khi tạo tài liệu Word: {ex.Message}\n";
                errorMessage += ex.InnerException != null ? $"Ngoại lệ bên trong: {ex.InnerException.Message}" : "Không có ngoại lệ bên trong.";
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = await orderController.GetAllAsync();
                double totalIncome = GetTotalIncome(orders);
                PrintTotalIncomeToWord(totalIncome);  // Call to generate the Word document
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate total income: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}