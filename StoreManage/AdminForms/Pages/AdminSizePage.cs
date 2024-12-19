using StoreManage.Components.Add;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Size;
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
    public partial class AdminSizePage : UserControl
    {
        private readonly SizeController sizeController;
        List<SizeDto> sizes;
        public AdminSizePage()
        {
            InitializeComponent();
            sizeController = new SizeController(new ApiService());
        }

        private async void AdminSizePage_Load(object sender, EventArgs e)
        {
            sizes = await sizeController.GetAllAsync();
            if (sizes == null || sizes.Count < 1)
            {
                MessageBox.Show("Not found Sizes");
                return;
            }

            DisplaySizes(sizes);
            ApplySortingAndFiltering();
        }
        private void DisplaySizes(List<SizeDto> sizes)
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
                Text = "Size Value",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(150, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the categories to create the data rows
            for (int i = 0; i < sizes.Count; i++)
            {
                var size = sizes[i];

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
                    Text = size.SizeId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(50, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Category Name
                var nameLabel = new Label
                {
                    Text = size.SizeValue,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(150, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 0, 0, 0) // Add some padding for better spacing
                };

                // Edit Icon
                var editIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Edit1,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                editIcon.Click += (s, e) => EditCategory(size.SizeId);

                // Delete Icon
                var deleteIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Delete,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                deleteIcon.Click += (s, e) => DeleteCategory(size.SizeId);

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the CategoryAdd UserControl already exists
            var existingSizeAdd = this.Controls.OfType<SizeAdd>().FirstOrDefault();

            if (existingSizeAdd == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var addSize = new SizeAdd();

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(addSize);
                addSize.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                addSize.Location = new Point(
                    (this.Width - addSize.Width) / 2,
                    (this.Height - addSize.Height) / 2
                );
                addSize.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingSizeAdd.BringToFront();
            }
        }
        private void EditCategory(int sizeId)
        {
            var existingSizeEdit = this.Controls.OfType<SizeEdit>().FirstOrDefault();

            if (existingSizeEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editSize = new SizeEdit(sizeId);

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(editSize);
                editSize.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                editSize.Location = new Point(
                    (this.Width - editSize.Width) / 2,
                    (this.Height - editSize.Height) / 2
                );
                editSize.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingSizeEdit.BringToFront();
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
        private void SortOrderChanged(object sender, EventArgs e)
        {
            ApplySortingAndFiltering();
        }

        private void ApplySortingAndFiltering()
        {
            // Check if subcategories is initialized
            if (sizes == null || sizes.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredSizes = sizes;

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredSizes = filteredSizes.OrderBy(s => s.SizeId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredSizes = filteredSizes.OrderByDescending(s => s.SizeId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplaySizes(filteredSizes);
        }
    }
}
