using StoreManage.AdminForms.Pages;
using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.Forms.Pages;
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

namespace StoreManage
{
    public partial class MainForm : Form
    {
        public int employeeId = 0;
        private readonly EmployeeController _employeeController;
        private readonly AuthController _authController;
        public HomePage homeInterface { get; private set; }
        private CategoryPage categoryInterface;
        public CartPage cartInterface { get; private set; }
        private ProfilePage profileInterface;

        private Timer fadeTimer; // Declare Timer globally - Dùng cho chuyển trang
        private Timer _timer; // dùng cho refreshToken


        public MainForm()
        {
            InitializeComponent();
            cartInterface = new CartPage();
            homeInterface = new HomePage();
            _authController = new AuthController(new Services.ApiService());
            _employeeController = new EmployeeController(new Services.ApiService());
            getEmployeeId();

            _timer = new Timer();
            _timer.Interval = 25 * 60 * 1000;
            _timer.Tick += timer1_Tick;
            _timer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeInterface = new HomePage();
            flowLayoutPanel.Controls.Add(homeInterface);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            homeInterface = new HomePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(homeInterface);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            categoryInterface = new CategoryPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(categoryInterface);
        }
        public void ChangeToCart()
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(cartInterface);
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            ChangeToCart();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileInterface = new ProfilePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(profileInterface);
        }
        public void handleClickedShopItem(DetailItem detail)
        {
            flowLayoutPanel.Controls.Clear(); // Clear existing details
            flowLayoutPanel.Controls.Add(detail); // Add the new detail view
        }
        public void NavigateToLoginForm()
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
                LoginForm loginForm = new LoginForm();
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            TokenManager.RemoveToken();
            NavigateToLoginForm();
        }
        public async void getEmployeeId()
        {
            try
            {
                var result = await _employeeController.GetDetailsAsync();
                if (result != null)
                {
                    employeeId = result.EmployeeId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed : {ex.Message}");
            }

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (TokenManager.GetToken() != null)
                {
                    var token = await _authController.refreshTokenAsync();

                if (token != null)
                {
                    TokenManager.SaveToken(token.AccessToken);
                    Console.WriteLine("Refresh token succeeded.");
                }
                else
                {
                    Console.WriteLine("Refresh token failed.");
                    MessageBox.Show("Session expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TokenManager.RemoveToken();
                    NavigateToLoginForm();
                }
            }

        }
    }
}
