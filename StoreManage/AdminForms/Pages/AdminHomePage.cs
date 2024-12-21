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

namespace StoreManage.AdminForms.Pages
{
    public partial class AdminHomePage : UserControl
    {
        private readonly OrderController orderController;

        public AdminHomePage()
        {
            InitializeComponent();

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
    }

}