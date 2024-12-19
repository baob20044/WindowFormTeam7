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

            for (int i = 0; i < 24; i++) 
            { 
                cBCategoryId.Items.Add(i);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string subcategoryName = txtName.Text;
            string description = txtDescription.Text;
            int categoryId = 0;
            if (cBCategoryId.SelectedValue != null)
            {
                categoryId = (int)cBCategoryId.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a target customer.");
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
                //var response = await subcategoryController;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
