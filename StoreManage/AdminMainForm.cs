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
        private AdminEmployeePage adminEmployeePage;
        private AdminProviderPage adminProviderPage;
        private AdminOrderPage adminOrderPage;

        private Timer fadeTimer; // Declare Timer globally - Dùng cho chuyển trang
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
        public void refreshSubcategory()
        {
            adminSubcategoryPage = new AdminSubcategoryPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminSubcategoryPage);
        }
        private void btnSubcategory_Click(object sender, EventArgs e)
        {
            refreshSubcategory();
        }
        public void refreshProduct()
        {
            adminProductPage = new AdminProductPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminProductPage);
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            refreshProduct();
        }
        public void refreshSize()
        {
            adminSizePage = new AdminSizePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminSizePage);
        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            refreshSize();
        }
        public void refreshColor()
        {
            adminColorPage = new AdminColorPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminColorPage);
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            refreshColor();
        }
        public void refreshEmployee()
        {
            adminEmployeePage = new AdminEmployeePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminEmployeePage);
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            refreshEmployee();
        }
        public void refreshProvider()
        {
            adminProviderPage = new AdminProviderPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminProviderPage);
        }
        private void btnProvider_Click(object sender, EventArgs e)
        {
            refreshProvider();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            adminOrderPage = new AdminOrderPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(adminOrderPage);
        }
        private void NavigateToLoginForm()
        {
            // Initialize the Timer for fade-out
            fadeTimer = new Timer();
            fadeTimer.Interval = 10; // Faster updates for smoother fade
            fadeTimer.Tick += FadeToLogin;
            fadeTimer.Start();
        }

        private void FadeToLogin(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05; // Faster fade with larger decrement
            }
            else
            {
                fadeTimer.Stop();
                fadeTimer.Dispose();

                // Hide the current form before opening the LoginForm
                this.Hide(); // Hide to prevent gaps or visual issues during transition

                // Open the LoginForm after fading out
                AdminLoginForm loginForm = new AdminLoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Location = this.Location; // Preserve the form's position
                loginForm.ShowDialog(); // Show LoginForm modally

                // Properly close the current form after showing the LoginForm
                this.Close(); // Close the current form
                this.Dispose(); // Dispose of the form to free resources

                // Ensure the old form is removed from memory and taskbar
                Application.DoEvents(); // Force UI to update and remove the old form from taskbar
            }
        }
        private void lbLogOut_Click(object sender, EventArgs e)
        {
            NavigateToLoginForm();
        }
    }
}
