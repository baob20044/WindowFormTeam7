using StoreManage.Components;
using StoreManage.Components.Add;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Providerr;
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
    public partial class AdminProviderPage : UserControl
    {
        private readonly ProviderController providerController;
        List<ProviderDto> providers;
        public AdminProviderPage()
        {
            InitializeComponent();
            providerController = new ProviderController(new ApiService());
            PopulateComboBox();
        }

        private async void AdminProviderPage_Load(object sender, EventArgs e)
        {
            providers = await providerController.GetAllAsync();
            if (providers == null || providers.Count < 1)
            {
                MessageBox.Show("Not found Provider");
                return;
            }
            DisplayProviders(providers);
            ApplySortingAndFiltering();
        }
        private void DisplayProviders(List<ProviderDto> providers)
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

            var emailHeaderLabel = new Label
            {
                Text = "Email",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(250, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            var phoneHeaderLabel = new Label
            {
                Text = "Phone",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(240, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left
            };

            var companyHeaderLabel = new Label
            {
                Text = "Company Name",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(135, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            // Add the header labels to the header panel
            headerPanel.Controls.Add(emailHeaderLabel);
            headerPanel.Controls.Add(phoneHeaderLabel);
            headerPanel.Controls.Add(companyHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the providers to create the data rows
            for (int i = 0; i < providers.Count; i++)
            {
                var provider = providers[i];

                // Create a container panel for each row
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 50),
                    BorderRadius = 5,
                    ShadowDecoration = { Enabled = true },
                    BackColor = (i % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5)
                };

                // Label for Provider ID
                var idLabel = new Label
                {
                    Text = provider.ProviderId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(60, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Provider Email
                var emailLabel = new Label
                {
                    Text = provider.ProviderEmail,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(240, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 0, 0, 0) // Add some padding for better spacing
                };

                // Label for Provider Phone
                var phoneLabel = new Label
                {
                    Text = provider.ProviderPhone,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(190, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Provider Company Name
                var companyLabel = new Label
                {
                    Text = provider.ProviderCompanyName,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(150, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
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
                editIcon.Click += (s, e) => EditProvider(provider.ProviderId);

                // Delete Icon
                var deleteIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Delete,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                deleteIcon.Click += (s, e) => DeleteProvider(provider.ProviderId);

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);
                rowPanel.Controls.Add(emailLabel);
                rowPanel.Controls.Add(phoneLabel);
                rowPanel.Controls.Add(companyLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
            }
        }
        private void EditProvider(int categoryId)
        {
            var existingProviderEdit = this.Controls.OfType<ProviderEdit>().FirstOrDefault();

            if (existingProviderEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editProvider = new ProviderEdit(categoryId);

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(editProvider);
                editProvider.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                editProvider.Location = new Point(
                    (this.Width - editProvider.Width) / 2,
                    (this.Height - editProvider.Height) / 2
                );
                editProvider.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingProviderEdit.BringToFront();
            }
        }

        private void DeleteProvider(int categoryId)
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
            if (providers == null || providers.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredProviders = providers;

            // Filter based on cBNumber
            if (cBNumber.SelectedItem != null)
            {
                var selectedValue = cBNumber.SelectedItem.ToString();
                if (selectedValue != "All" && int.TryParse(selectedValue, out int maxItems))
                {
                    // Limit the number of items based on selection
                    filteredProviders = filteredProviders.Take(maxItems).ToList();
                }
            }

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredProviders = filteredProviders.OrderBy(s => s.ProviderId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredProviders = filteredProviders.OrderByDescending(s => s.ProviderId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplayProviders(filteredProviders);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the CategoryAdd UserControl already exists
            var existingProviderAdd = this.Controls.OfType<ProviderAdd>().FirstOrDefault();

            if (existingProviderAdd == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var addProvider = new ProviderAdd();

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(addProvider);
                addProvider.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                addProvider.Location = new Point(
                    (this.Width - addProvider.Width) / 2,
                    (this.Height - addProvider.Height) / 2
                );
                addProvider.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingProviderAdd.BringToFront();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayProviders(providers);
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
            var filteredProviders = providers.Where(provider =>
                provider.ProviderCompanyName.ToLower().Contains(searchText) || // Check if the name contains the search text
                provider.ProviderPhone.ToString().Contains(searchText) || // Check if the category ID contains the search text
                provider.ProviderEmail.ToLower().Contains(searchText) // Check if the target customer type contains the search text
            ).ToList();

            // Display the filtered categories in the flow layout
            DisplayProviders(filteredProviders);
        }

    }
}
