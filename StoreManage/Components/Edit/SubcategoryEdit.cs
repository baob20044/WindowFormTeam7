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

namespace StoreManage.Components.Edit
{
    public partial class SubcategoryEdit : UserControl
    {
        private int SubcategoryId;
        private readonly SubcategoryController subcategoryController;
        public SubcategoryEdit(int subcategoryId)
        {
            InitializeComponent();
            SubcategoryId = subcategoryId;
            subcategoryController = new SubcategoryController(new ApiService());
            LoadSubcategory(subcategoryId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        public async void LoadSubcategory(int subcategoryId)
        {
            try
            {
                var response = await subcategoryController.GetByIdAsync(subcategoryId);
                if (response != null)
                {
                    txtName.Text = response.SubcategoryName;
                    txtDescription.Text = response.Description;
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
            string newSubcategoryName = txtName.Text;
            string newDescription = txtDescription.Text;
            if (string.IsNullOrEmpty(newSubcategoryName) || string.IsNullOrEmpty(newDescription))
            {
                MessageBox.Show("Please enter a Subcategory name and description.");
                return;
            }

            var updateSubcategory = new SubcategoryUpdateDto
            {
                SubcategoryName = newSubcategoryName,
                Description = newDescription
            };

            try
            {
                // Execute the PUT request asynchronously
                var response = await subcategoryController.UpdateAsync(SubcategoryId, updateSubcategory);

                if (response != null)
                {
                    MessageBox.Show("Subcategory updated successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshSubcategory();
                    this.Parent.Controls.Remove(this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
