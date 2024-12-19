using RestSharp;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components
{
    public partial class CategoryAdd : UserControl
    {
        private readonly CategoryController categoryController;
        public CategoryAdd()
        {
            InitializeComponent();
            categoryController = new CategoryController(new ApiService());
            cBTargetCustomer.Items.Add(1);
            cBTargetCustomer.Items.Add(2);
            cBTargetCustomer.Items.Add(3);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtName.Text;

            // Ensure a valid selection from ComboBox
            int targetCustomerId = 0;
            if (cBTargetCustomer.SelectedItem != null)
            {
                targetCustomerId = (int)cBTargetCustomer.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a target customer.");
                return;
            }

            if (string.IsNullOrEmpty(categoryName) || targetCustomerId == 0)
            {
                MessageBox.Show("Please provide both the category name and target customer.");
                return;
            }

            // Create the category object to be sent in the request body
            var category = new CategoryCreateDto
            {
                Name = categoryName,
                TargetCustomerId = targetCustomerId
            };

            // Validate the category object using data annotations
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(category);
            if (!Validator.TryValidateObject(category, validationContext, validationResults, true))
            {
                string errorMessage = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show(errorMessage);
                return;
            }
            // Initialize RestSharp client and request
            try
            {
                // Execute the POST request asynchronously
                var response = await categoryController.CreateAsync(category);
                if (response != null)
                {
                    MessageBox.Show("Category added successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshCategory();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine($"Error adding category: {response} "); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
