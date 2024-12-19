using Newtonsoft.Json;
using RestSharp;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Product;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components.Edit
{
    public partial class CategoryEdit : UserControl
    {
        private int CategoryId;
        private readonly CategoryController categoryController;
        public CategoryEdit(int categoryId)
        {
            InitializeComponent();
            categoryController = new CategoryController(new ApiService());
            LoadCategory(categoryId);
            CategoryId = categoryId;
        }
        public async void LoadCategory(int categoryId)
        {
            try
            {
                var response = await categoryController.GetByIdAsync(categoryId);
                if (response != null)
                {
                    txtName.Text = response.Name;
                }
                else MessageBox.Show("Wrong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string newCategoryName = txtName.Text;

            if (string.IsNullOrEmpty(newCategoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            var updateCategory = new CategoryUpdateDto
            {
                Name = newCategoryName,
            };

            try
            {
                // Execute the PUT request asynchronously
                var response = await categoryController.UpdateAsync(CategoryId, updateCategory);

                if (response != null)
                {
                    MessageBox.Show("Category updated successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshCategory();
                    this.Parent.Controls.Remove(this);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
