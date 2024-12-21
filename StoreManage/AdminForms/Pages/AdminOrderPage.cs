using StoreManage.Components;
using StoreManage.Components.Add;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Order;
using StoreManage.DTOs.Subcategory;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.AdminForms.Pages
{
    public partial class AdminOrderPage : UserControl
    {
        private readonly OrderController orderController;
        List<OrderDto> orders;
        public AdminOrderPage()
        {
            InitializeComponent();
            orderController = new OrderController(new ApiService());
            PopulateComboBox();
            ApplySortingAndFiltering();
        }

        private async void AdminOrderPage_Load(object sender, EventArgs e)
        {
            orders = await orderController.GetAllAsync();
            if (orders == null || orders.Count < 1)
            {
                MessageBox.Show("Not found subcategory");
                return;
            }

            DisplayOrders(orders);
            ApplySortingAndFiltering();
        }
        private void DisplayOrders(List<OrderDto> orders)
        {
            flowLayoutPanel.Controls.Clear(); // Clear previous controls

            // Create a header panel
            var headerPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(flowLayoutPanel.Width - 40, 50),
                BorderRadius = 10,
                ShadowDecoration = { Enabled = true, Shadow = new Padding(5) },
                BackColor = Color.FromArgb(0, 122, 204), // Header background color
                Margin = new Padding(5),
                Dock = DockStyle.Top
            };

            // Header labels with better spacing
            var idHeaderLabel = new Label
            {
                Text = "ID",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(flowLayoutPanel.Width / 3 - 10 +30, 50), // 33% width
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Padding = new Padding(0, 0, 0, 10) // Add padding at the bottom
            };

            var nameHeaderLabel = new Label
            {
                Text = "Employee Name",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(flowLayoutPanel.Width / 3 * 2 - 10, 50), // 67% width
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left,
                Padding = new Padding(10, 0, 0, 10) // Add padding at the bottom
            };

            // Add headers to the header panel
            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);


            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the orders to create the data rows
            for (int i = 0; i < orders.Count; i++)
            {
                var order = orders[i];

                // Create a container panel for each row with shadow effect and rounded corners
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 60),
                    BorderRadius = 10,
                    ShadowDecoration = { Enabled = true, Shadow = new Padding(2) },
                    BackColor = (i % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5),
                    Dock = DockStyle.Top
                };

                // Label for Order ID
                var idLabel = new Label
                {
                    Text = order.OrderId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel.Width / 3 - 10 + 30, 50), // 33% width
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left,
                    Padding = new Padding(0, 5, 0, 5) // Add vertical padding for alignment
                };

                // Label for Employee Name
                var nameLabel = new Label
                {
                    Text = order.EmployeeName,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel.Width / 3 * 2 - 10, 50), // 67% width
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 5, 0, 5) // Add padding for better spacing
                };

                // View Detail Icon with a hover effect
                var viewDetailIcon = new Label
                {
                    Text = "Detail",  // Replace with actual icon
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Size = new Size(60, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                // Add hover effect for the icon
                viewDetailIcon.MouseEnter += (s, e) =>
                {
                    viewDetailIcon.BackColor = Color.FromArgb(0, 122, 204); // Change color on hover
                };
                viewDetailIcon.MouseLeave += (s, e) =>
                {
                    viewDetailIcon.BackColor = Color.Transparent; // Reset color when hover ends
                };

                // Add click event for view detail
                viewDetailIcon.Click += (s, e) => ViewOrderDetail(order.OrderId);

                // Add controls to the row panel
                rowPanel.Controls.Add(viewDetailIcon);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
            }
        }



        // Method to handle the "View Order Detail" action
        private void ViewOrderDetail(int orderId)
        {
            var existingCategoryEdit = this.Controls.OfType<OrderDetail>().FirstOrDefault();

            if (existingCategoryEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editCategory = new OrderDetail(orderId);

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(editCategory);
                editCategory.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                editCategory.Location = new Point(
                    (this.Width - editCategory.Width) / 2,
                    (this.Height - editCategory.Height) / 2
                );
                editCategory.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingCategoryEdit.BringToFront();
            }
        }
        private void PopulateComboBox()
        {
            // Add filter options
            cBNumber.Items.Add("All");
            for (int i = 10; i <= 100; i += 10)
            {
                cBNumber.Items.Add(i.ToString());
            }

            // Set default selection
            cBNumber.SelectedIndex = 0; // Default to "All"
        }

        private void cBNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySortingAndFiltering();
        }

        private void SortOrderChanged(object sender, EventArgs e)
        {
            ApplySortingAndFiltering();
        }

        private void ApplySortingAndFiltering()
        {
            // Check if subcategories is initialized
            if (orders == null || orders.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredOrders = orders;

            // Filter based on cBNumber
            if (cBNumber.SelectedItem != null)
            {
                var selectedValue = cBNumber.SelectedItem.ToString();
                if (selectedValue != "All" && int.TryParse(selectedValue, out int maxItems))
                {
                    // Limit the number of items based on selection
                    filteredOrders = filteredOrders.Take(maxItems).ToList();
                }
            }

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredOrders = filteredOrders.OrderBy(s => s.OrderId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredOrders = filteredOrders.OrderByDescending(s => s.OrderId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplayOrders(filteredOrders);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the "Enter" key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch(); // Call the search logic
            }
        }

        private void PerformSearch()
        {
            string searchText = txtSearch.Text.ToLower();

            // Filter the categories based on the search text
            var filteredOrders = orders.Where(order =>
                order.EmployeeName.ToLower().Contains(searchText) || // Check if the name contains the search text
                order.OrderId.ToString().Contains(searchText) // Check if the category ID contains the search text
            ).ToList();

            // Display the filtered categories in the flow layout
            DisplayOrders(filteredOrders);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayOrders(orders);
            }
        }
    }
}
