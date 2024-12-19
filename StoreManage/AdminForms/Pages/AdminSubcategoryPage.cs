using StoreManage.Components;
using StoreManage.Components.Add;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
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
    public partial class AdminSubcategoryPage : UserControl
    {
        private readonly SubcategoryController subcategoryController;
        List<SubcategoryDto> subcategories;
        public AdminSubcategoryPage()
        {
            InitializeComponent();
            subcategoryController = new SubcategoryController(new ApiService());
            cBNumber.SelectedIndexChanged += cBNumber_SelectedIndexChanged;
            PopulateComboBox();
        }
        private async void AdminSubcategoryPage_Load(object sender, EventArgs e)
        {
            subcategories = await subcategoryController.GetAllAsync();
            if (subcategories == null || subcategories.Count < 1)
            {
                MessageBox.Show("Not found subcategory");
                return;
            }

            DisplaySubcategories(subcategories);
        }
        private void DisplaySubcategories(List<SubcategoryDto> subcategories)
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

            var categoryIdHeaderLabel = new Label
            {
                Text = "Category Id",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(150, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            headerPanel.Controls.Add(categoryIdHeaderLabel);
            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the categories to create the data rows
            for (int i = 0; i < subcategories.Count; i++)
            {
                var subcategory = subcategories[i];

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
                    Text = subcategory.SubcategoryId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(50, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Category Name
                var nameLabel = new Label
                {
                    Text = subcategory.SubcategoryName,
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
                    Text = subcategory.CategoryId.ToString(),
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
                editIcon.Click += (s, e) => EditCategory(subcategory.SubcategoryId);

                // Delete Icon
                var deleteIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Delete,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                deleteIcon.Click += (s, e) => DeleteCategory(subcategory.CategoryId);

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);
                rowPanel.Controls.Add(customerTypeLabel);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
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
            var filteredSubcategories = subcategories.Where(subcategory =>
                subcategory.SubcategoryName.ToLower().Contains(searchText) || // Check if the name contains the search text
                subcategory.CategoryId.ToString().Contains(searchText) || // Check if the category ID contains the search text
                subcategory.CategoryId.ToString().Contains(searchText) // Check if the target customer type contains the search text
            ).ToList();

            // Display the filtered categories in the flow layout
            DisplaySubcategories(filteredSubcategories);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplaySubcategories(subcategories);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the CategoryAdd UserControl already exists
            var existingSubcategoryAdd = this.Controls.OfType<SubcategoryAdd>().FirstOrDefault();

            if (existingSubcategoryAdd == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var addSubcategory = new SubcategoryAdd();

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(addSubcategory);
                addSubcategory.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                addSubcategory.Location = new Point(
                    (this.Width - addSubcategory.Width) / 2,
                    (this.Height - addSubcategory.Height) / 2
                );
                addSubcategory.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingSubcategoryAdd.BringToFront();
            }
        }
        private void EditCategory(int subcategoryId)
        {
            var existingCategoryEdit = this.Controls.OfType<SubcategoryEdit>().FirstOrDefault();

            if (existingCategoryEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editCategory = new SubcategoryEdit(subcategoryId);

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
            if (subcategories == null || subcategories.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredSubcategories = subcategories;

            // Filter based on cBNumber
            if (cBNumber.SelectedItem != null)
            {
                var selectedValue = cBNumber.SelectedItem.ToString();
                if (selectedValue != "All" && int.TryParse(selectedValue, out int maxItems))
                {
                    // Limit the number of items based on selection
                    filteredSubcategories = filteredSubcategories.Take(maxItems).ToList();
                }
            }

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredSubcategories = filteredSubcategories.OrderBy(s => s.SubcategoryId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredSubcategories = filteredSubcategories.OrderByDescending(s => s.SubcategoryId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplaySubcategories(filteredSubcategories);
        }
    }
}
