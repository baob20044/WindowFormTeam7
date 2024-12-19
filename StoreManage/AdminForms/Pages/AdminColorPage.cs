using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.PColor;
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
    public partial class AdminColorPage : UserControl
    {
        private readonly ColorController colorController;
        List<ColorDto> colors;
        public AdminColorPage()
        {
            InitializeComponent();
            colorController = new ColorController(new ApiService());
            cBNumber.SelectedIndexChanged += cBNumber_SelectedIndexChanged;
            PopulateComboBox();
        }

        private async void AdminColorPage_Load(object sender, EventArgs e)
        {
            colors = await colorController.GetAllAsync();
            if (colors == null || colors.Count < 1)
            {
                MessageBox.Show("Not found Color");
                return;
            }

            DisplayColors(colors);
        }
        private void DisplayColors(List<ColorDto> colors)
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
                Size = new Size(100, 40),
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
                Text = "HexaCode",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(140, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            var colorDisplayHeaderLabel = new Label
            {
                Text = "Color",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(100, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left
            };

            headerPanel.Controls.Add(colorDisplayHeaderLabel);
            headerPanel.Controls.Add(categoryIdHeaderLabel);
            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the colors to create the data rows
            for (int i = 0; i < colors.Count; i++)
            {
                var color = colors[i];

                // Create a container panel for each row
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 50),
                    BorderRadius = 5,
                    ShadowDecoration = { Enabled = true },
                    BackColor = (i % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5)
                };

                // Label for Color ID
                var idLabel = new Label
                {
                    Text = color.ColorId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(100, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Color Name
                var nameLabel = new Label
                {
                    Text = color.Name,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(100, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 0, 0, 0) // Add some padding for better spacing
                };

                // Label for HexaCode
                var hexaCodeLabel = new Label
                {
                    Text = color.HexaCode,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    AutoSize = false,
                    Size = new Size(190, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Panel to display the color
                var colorDisplayPanel = new Panel
                {
                    Size = new Size(100, 30),
                    BackColor = ColorTranslator.FromHtml(color.HexaCode), // Convert HexaCode to Color
                    Dock = DockStyle.Left,
                    Margin = new Padding(5)
                };

                // Edit Icon
                var editIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Edit1,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                editIcon.Click += (s, e) => EditCategory(color.ColorId);

                // Delete Icon
                var deleteIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Delete,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                deleteIcon.Click += (s, e) => DeleteCategory(color.ColorId);

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);
                rowPanel.Controls.Add(deleteIcon);
                rowPanel.Controls.Add(colorDisplayPanel);
                rowPanel.Controls.Add(hexaCodeLabel);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
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
            if (colors == null || colors.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredColors = colors;

            // Filter based on cBNumber
            if (cBNumber.SelectedItem != null)
            {
                var selectedValue = cBNumber.SelectedItem.ToString();
                if (selectedValue != "All" && int.TryParse(selectedValue, out int maxItems))
                {
                    // Limit the number of items based on selection
                    filteredColors = filteredColors.Take(maxItems).ToList();
                }
            }

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredColors = filteredColors.OrderBy(s => s.ColorId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredColors = filteredColors.OrderByDescending(s => s.ColorId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplayColors(filteredColors);
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

            // Ensure the colors list is not null
            if (colors == null || colors.Count == 0)
            {
                MessageBox.Show("No colors available to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filter the colors based on the search text
            var filteredColors = colors.Where(color =>
                color.ColorId.ToString().Contains(searchText) || // Check if ColorId contains the search text
                (!string.IsNullOrEmpty(color.Name) && color.Name.ToLower().Contains(searchText)) || // Check if Name contains the search text
                (!string.IsNullOrEmpty(color.HexaCode) && color.HexaCode.ToLower().Contains(searchText)) // Check if HexaCode contains the search text
            ).ToList();

            // Display the filtered colors in the flow layout
            DisplayColors(filteredColors);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayColors(colors);
            }
        }
    }
}
