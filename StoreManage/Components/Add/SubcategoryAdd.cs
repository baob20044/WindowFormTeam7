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
        private readonly CategoryController categoryController;
        public SubcategoryAdd()
        {
            InitializeComponent();
            subcategoryController = new SubcategoryController(new ApiService());
            categoryController = new CategoryController(new ApiService());

            PopulateCategoryComboBox();

            // Configure the ComboBox to show a scroll bar when needed
            cBCategoryId.MaxDropDownItems = 5;      // Show 5 items before scrolling
            cBCategoryId.IntegralHeight = false;   // Ensure scroll bar appears
            cBCategoryId.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: Prevent typing
        }
        private async void PopulateCategoryComboBox()
        {
            // Fetch categories from your service or database
            var categories = await categoryController.GetAllAsync(); // Adjust this call to fetch the data

            if (categories == null || categories.Count == 0)
            {
                MessageBox.Show("No categories found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear any existing items in the ComboBox
            cBCategoryId.Items.Clear();

            // Populate the ComboBox
            cBCategoryId.DisplayMember = "Name";  // Display the Category Name
            cBCategoryId.ValueMember = "CategoryId";      // Use CategoryId as the value

            // Add the items to the ComboBox
            cBCategoryId.DataSource = categories;  // Bind the data source
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
                categoryId = (int)cBCategoryId.SelectedValue;
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
