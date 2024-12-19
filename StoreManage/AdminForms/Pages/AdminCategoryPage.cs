using Newtonsoft.Json;
using RestSharp;
using StoreManage.Components;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
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
    public partial class AdminCategoryPage : UserControl
    {
        private readonly CategoryController categoryController;
        List<CategoryDto> categories;
        public AdminCategoryPage()
        {
            InitializeComponent();
            categoryController = new CategoryController(new ApiService());
        }

        private async void AdminCategoryPage_Load(object sender, EventArgs e)
        {
            //categories = await FetchCategoriesAsync();
            categories = await categoryController.GetAllAsync();
            if (categories == null || categories.Count < 1)
            {
                MessageBox.Show("Not found Category");
                return;
            }    
            DisplayCategories(categories);
        }
        //private async Task<List<CategoryDto>> FetchCategoriesAsync()
        //{
        //    var client = new RestClient("http://localhost:5254");
        //    var request = new RestRequest("/api/categories", Method.Get);
        //    request.AddHeader("accept", "application/json");

        //    try
        //    {
        //        var response = await client.ExecuteAsync(request);

        //        if (response.IsSuccessful && response.Content != null)
        //        {
        //            var categories = JsonConvert.DeserializeObject<List<CategoryDto>>(response.Content);
        //            return categories ?? new List<CategoryDto>();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to fetch categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return new List<CategoryDto>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error fetching categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return new List<CategoryDto>();
        //    }
        //}
        private void DisplayCategories(List<CategoryDto> categories)
        {
            flowLayoutPanel.Controls.Clear(); // Clear previous controls

            // Create a header panel
            var headerPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(flowLayoutPanel.Width - 40, 40),
                BorderRadius = 5,
                ShadowDecoration = { Enabled = true },
                BackColor = Color.FromArgb(0, 122, 204), // Header background color
                Margin = new Padding(5)
            };

            // Header labels
            var idHeaderLabel = new Label
            {
                Text = "ID",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(50, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left
            };

            var nameHeaderLabel = new Label
            {
                Text = "Name",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(150, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            var customerTypeHeaderLabel = new Label
            {
                Text = "Customer",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(100, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left
            };

            // Add the header labels to the header panel
            headerPanel.Controls.Add(customerTypeHeaderLabel);
            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the categories to create the data rows
            for (int i = 0; i < categories.Count; i++)
            {
                var category = categories[i];

                // Create a container panel for each row
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 50),
                    BorderRadius = 5,
                    ShadowDecoration = { Enabled = true },
                    BackColor = (i % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5)
                };

                // Label for Category ID
                var idLabel = new Label
                {
                    Text = category.CategoryId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(50, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Category Name
                var nameLabel = new Label
                {
                    Text = category.Name,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(150, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 0, 0, 0) // Add some padding for better spacing
                };

                // Label for Target Customer
                var customerTypeLabel = new Label
                {
                    Text = GetCustomerType(category.TargetCustomerId),
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    AutoSize = false,
                    Size = new Size(100, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Edit Icon
                var editIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Edit1, 
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                editIcon.Click += (s, e) => EditCategory(category.CategoryId);

                // Delete Icon
                var deleteIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Delete, 
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                deleteIcon.Click += (s, e) => DeleteCategory(category.CategoryId);

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);
                rowPanel.Controls.Add(deleteIcon);
                rowPanel.Controls.Add(customerTypeLabel);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
            }
        }


        private string GetCustomerType(int targetCustomerId)
        {
            switch (targetCustomerId)
            {
                case 1:
                    return "Nam";
                case 2:
                    return "Nữ";
                case 3:
                    return "Trẻ em";
                default:
                    return "Unknown";
            }
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
            var filteredCategories = categories.Where(category =>
                category.Name.ToLower().Contains(searchText) || // Check if the name contains the search text
                category.CategoryId.ToString().Contains(searchText) || // Check if the category ID contains the search text
                GetCustomerType(category.TargetCustomerId).ToLower().Contains(searchText) // Check if the target customer type contains the search text
            ).ToList();

            // Display the filtered categories in the flow layout
            DisplayCategories(filteredCategories);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayCategories(categories);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the CategoryAdd UserControl already exists
            var existingCategoryAdd = this.Controls.OfType<CategoryAdd>().FirstOrDefault();

            if (existingCategoryAdd == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var addCategory = new CategoryAdd();

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(addCategory);
                addCategory.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                addCategory.Location = new Point(
                    (this.Width - addCategory.Width) / 2,
                    (this.Height - addCategory.Height) / 2
                );
                addCategory.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingCategoryAdd.BringToFront();
            }
        }



        private void EditCategory(int categoryId)
        {
            var existingCategoryEdit = this.Controls.OfType<CategoryEdit>().FirstOrDefault();

            if (existingCategoryEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editCategory = new CategoryEdit(categoryId);

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

        private void DeleteCategory(int categoryId)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to delete Category ID: {categoryId}?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show($"Category ID {categoryId} deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Implement your delete logic here
            }
        }
    }
}
