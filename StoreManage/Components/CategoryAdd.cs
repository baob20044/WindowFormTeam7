using RestSharp;
using StoreManage.DTOs.Category;
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
        public CategoryAdd()
        {
            InitializeComponent();

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
            var client = new RestClient("http://localhost:5254");
            var request = new RestRequest("/api/categories", Method.Post);
            request.AddJsonBody(category);  // Add the category data as JSON
            request.AddHeader("Content-Type", "application/json");  // Ensure Content-Type header is set
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJiYW9iMjAwNCIsImVtYWlsIjoiYmFvYjIwMDRAZ21haWwuY29tIiwianRpIjoiODY4MGFmNDktNjk5Mi00YzZhLThkMGQtOGQyZjc5NWFiYmIzIiwiZ2l2ZW5fbmFtZSI6ImJhb2IyMDA0IiwibmFtZWlkIjoiOTFmZDA3YmEtOGQwNC00YzUyLWI5MTQtNzEzMmE1NjQ5OTA3Iiwicm9sZSI6IkFkbWluIiwibmJmIjoxNzM0NTI1NDc1LCJleHAiOjE3MzQ1MjcyNzUsImlhdCI6MTczNDUyNTQ3NSwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MjU0IiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo1MjU0In0.JwByFfEyu2fmisxTcybbJj_E8b6T_1SGeSvf211bkog";  // Replace with actual token
            request.AddHeader("Authorization", $"Bearer {token}");
            try
            {
                // Execute the POST request asynchronously
                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Category added successfully!");
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    MessageBox.Show($"Error adding category: {response.Content}"); // Check the response content for error details
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

    }
}
