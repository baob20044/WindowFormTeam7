using api.DTOs.Employee;
using StoreManage.Components;
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
    public partial class AdminEmployeePage : UserControl
    {
        private readonly EmployeeController employeeController;
        List<EmployeeDto> employees;
        public AdminEmployeePage()
        {
            InitializeComponent();
            employeeController = new EmployeeController(new ApiService());
            PopulateComboBox();
            ApplySortingAndFiltering();
        }

        private async void AdminEmployeePage_Load(object sender, EventArgs e)
        {
            employees = await employeeController.GetAllAsync();
            if (employees == null || employees.Count < 1)
            {
                MessageBox.Show("Not found employee");
                return;
            }

            DisplayEmployees(employees);
            ApplySortingAndFiltering();
        }
        private void DisplayEmployees(List<EmployeeDto> employees)
        {
            flowLayoutPanel.Controls.Clear(); // Clear previous controls

            // Create the header panel with the existing columns
            var headerPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(flowLayoutPanel.Width - 40, 40),
                BorderRadius = 5,
                ShadowDecoration = { Enabled = true },
                BackColor = Color.FromArgb(0, 122, 204), // Header background color
                Margin = new Padding(5)
            };

            // Header labels for columns
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
                Size = new Size(200, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            var emailHeaderLabel = new Label
            {
                Text = "Email",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(200, 40),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };

            headerPanel.Controls.Add(emailHeaderLabel);
            headerPanel.Controls.Add(nameHeaderLabel);
            headerPanel.Controls.Add(idHeaderLabel);

            // Add the header panel to the flow layout
            flowLayoutPanel.Controls.Add(headerPanel);

            // Loop through the employees to create the data rows
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = employees[i];

                // Create a container panel for each row
                var rowPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 50),
                    BorderRadius = 5,
                    ShadowDecoration = { Enabled = true },
                    BackColor = (i % 2 == 0) ? Color.LightGray : Color.White, // Alternate row colors
                    Margin = new Padding(5)
                };

                // Label for Employee ID
                var idLabel = new Label
                {
                    Text = employee.EmployeeId.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = false,
                    Size = new Size(100, 50),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };

                // Label for Employee Name
                var nameLabel = new Label
                {
                    Text = $"{employee.PersonalInfo.FirstName} {employee.PersonalInfo.LastName}",
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(200, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Padding = new Padding(10, 0, 0, 0) // Add some padding for better spacing
                };

                // Label for Employee Email
                var emailLabel = new Label
                {
                    Text = employee.Email,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(200, 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left
                };

                // Edit Icon (optional if you want to keep editing functionality)
                var editIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.Edit1,
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                 editIcon.Click += (s, e) => EditEmployee(employee.EmployeeId);

                // View Details Icon (Replace Delete with View Details)
                var viewDetailsIcon = new Guna.UI2.WinForms.Guna2ImageButton
                {
                    Image = Properties.Resources.ViewDetails, // Ensure you have a "ViewDetails" icon in your resources
                    Size = new Size(30, 30),
                    Dock = DockStyle.Right,
                    BackColor = Color.Transparent
                };
                viewDetailsIcon.Click += (s, e) => ViewEmployeeDetails(employee.EmployeeId); // Implement ViewEmployeeDetails method

                // Add controls to the row panel
                rowPanel.Controls.Add(editIcon);  // Optional if you need edit functionality
                rowPanel.Controls.Add(viewDetailsIcon);
                rowPanel.Controls.Add(emailLabel);
                rowPanel.Controls.Add(nameLabel);
                rowPanel.Controls.Add(idLabel);

                // Add the row panel to the flow layout
                flowLayoutPanel.Controls.Add(rowPanel);
            }
        }

        private void ViewEmployeeDetails(int employeeId)
        {
            var existingEmployeeEdit = this.Controls.OfType<EmployeeDetail>().FirstOrDefault();

            if (existingEmployeeEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editEmployee = new EmployeeDetail(employeeId);

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(editEmployee);
                editEmployee.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                editEmployee.Location = new Point(
                    (this.Width - editEmployee.Width) / 2,
                    (this.Height - editEmployee.Height) / 2
                );
                editEmployee.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingEmployeeEdit.BringToFront();
            }
        }
        private void EditEmployee(int employeeId)
        {
            var existingEmployeeEdit = this.Controls.OfType<EmployeeEdit>().FirstOrDefault();

            if (existingEmployeeEdit == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var editEmployee = new EmployeeEdit(employeeId);

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(editEmployee);
                editEmployee.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                editEmployee.Location = new Point(
                    (this.Width - editEmployee.Width) / 2,
                    (this.Height - editEmployee.Height) / 2
                );
                editEmployee.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingEmployeeEdit.BringToFront();
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
            var filteredEmployees = employees.Where(employee =>
                employee.EmployeeId.ToString().Contains(searchText) || // Check if the name contains the search text
                employee.PersonalInfo.LastName.ToLower().Contains(searchText) || // Check if the category ID contains the search text
                employee.Email.ToLower().Contains(searchText) // Check if the target customer type contains the search text
            ).ToList();

            // Display the filtered categories in the flow layout
            DisplayEmployees(filteredEmployees);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                DisplayEmployees(employees);
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
            if (employees == null || employees.Count == 0)
            {
                flowLayoutPanel.Controls.Clear();
                //MessageBox.Show("No subcategories available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with the full list of subcategories
            var filteredEmployees = employees;

            // Filter based on cBNumber
            if (cBNumber.SelectedItem != null)
            {
                var selectedValue = cBNumber.SelectedItem.ToString();
                if (selectedValue != "All" && int.TryParse(selectedValue, out int maxItems))
                {
                    // Limit the number of items based on selection
                    filteredEmployees = filteredEmployees.Take(maxItems).ToList();
                }
            }

            // Sort based on the selected radio button
            if (rBAsc.Checked)
            {
                filteredEmployees = filteredEmployees.OrderBy(s => s.EmployeeId).ToList();
            }
            else if (rBDesc.Checked)
            {
                filteredEmployees = filteredEmployees.OrderByDescending(s => s.EmployeeId).ToList();
            }

            // Display the filtered and sorted subcategories
            DisplayEmployees(filteredEmployees);
        }
    }
}
