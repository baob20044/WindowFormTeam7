using StoreManage.Controllers;
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

namespace StoreManage.Components.Add
{
    public partial class SubcategoryAdd : UserControl
    {
        private readonly SubcategoryController subcategoryController;
        public SubcategoryAdd()
        {
            InitializeComponent();
            subcategoryController = new SubcategoryController(new ApiService());

            // Populate the Guna2ComboBox with numbers 1 to 23
            for (int i = 1; i < 24; i++)
            {
                cBCategoryId.Items.Add(i.ToString()); // Add items as strings
            }

            // Configure the ComboBox to show a scroll bar when needed
            cBCategoryId.MaxDropDownItems = 5;      // Show 5 items before scrolling
            cBCategoryId.IntegralHeight = false;   // Ensure scroll bar appears
            cBCategoryId.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: Prevent typing
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string subcategoryName = txtName.Text;
            string description = txtDescription.Text;
            int categoryId = 0;
            if (cBCategoryId.SelectedItem != null)
            {
                categoryId = (int)cBCategoryId.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select category ID.");
                return;
            }

            if (string.IsNullOrEmpty(subcategoryName) || string.IsNullOrEmpty(description) || categoryId == 0)
            {
                MessageBox.Show("Please provide both the subcategory name description and categoryId.");
                return;
            }

            var subcategory = new SubcategoryCreateDto
            {
                SubcategoryName = subcategoryName,
                Description = description,
                CategoryId = categoryId
            };

            try
            {
                var response = await subcategoryController.CreateAsync(subcategory);
                if (response != null) {
                    MessageBox.Show("Subcategory added successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshSubcategory();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Adding error");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
