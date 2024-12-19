using StoreManage.AdminForms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage
{
    public partial class AdminMainForm : Form
    {
        private AdminHomePage adminHomePage;
        public AdminCategoryPage adminCategoryPage { get; private set; }
        private AdminSubcategoryPage adminSubcategoryPage;
        private AdminProductPage adminProductPage;
        private AdminSizePage adminSizePage;
        private AdminColorPage adminColorPage;
        private AdminCustomerPage adminCustomerPage;
        private AdminProviderPage adminProviderPage;
        private AdminOrderPage adminOrderPage;
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            adminHomePage = new AdminHomePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminHomePage);
        }
        public void refreshCategory()
        {
            adminCategoryPage = new AdminCategoryPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminCategoryPage);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {

            refreshCategory();
        }

        private void btnSubcategory_Click(object sender, EventArgs e)
        {
            adminSubcategoryPage = new AdminSubcategoryPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminSubcategoryPage);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            adminProductPage = new AdminProductPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminProductPage);
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            adminSizePage = new AdminSizePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminSizePage);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            adminColorPage = new AdminColorPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminColorPage);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            adminCustomerPage = new AdminCustomerPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminCustomerPage);
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            adminProviderPage = new AdminProviderPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminProviderPage);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            adminOrderPage = new AdminOrderPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminOrderPage);
        }
    }
}
