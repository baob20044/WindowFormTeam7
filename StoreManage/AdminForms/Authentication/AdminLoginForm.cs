using StoreManage.Controllers;
using StoreManage.Services;
using System;
using System.Windows.Forms;

namespace StoreManage
{
    public partial class AdminLoginForm : Form
    {
        private readonly AuthController _authController;
        private Timer fadeTimer; // Dùng cho chuyển trang
        public AdminLoginForm()
        {
            InitializeComponent();
            _authController = new AuthController(new ApiService());

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
          
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "O";

                // Gọi phương thức LoginAsync
                var accessToken = await _authController.LoginAsync(username, password);

                TokenManager.SaveToken(accessToken);
                MessageBox.Show("Login successful!");

                NavigateToMainPage();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi
                MessageBox.Show($"Login failed: {ex.Message}");
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";

            }
        }

        //Chuyển trang 
        private bool isNavigatingMainPage = false; // Prevent repeated navigation
        private void NavigateToMainPage()
        {
            if (isNavigatingMainPage) return; // Prevent multiple triggers
            isNavigatingMainPage = true; // Set flag to prevent subsequent triggers
            fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += FadeToMainPage;
            fadeTimer.Start();
        }
        private void FadeToMainPage(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1; // Faster fade with larger decrement
            }
            else
            {
                fadeTimer.Stop();
                fadeTimer.Dispose();

                // Hide the current form before opening the SignupForm
                this.Hide();

                // Open SignupForm
                AdminMainForm adminPage = new AdminMainForm();
                adminPage.StartPosition = FormStartPosition.CenterScreen;
                adminPage.Location = this.Location;
                adminPage.ShowDialog();  // Show the new form

                // After showing the new form, dispose of the current form
                this.Close(); // Close the form
                this.Dispose(); // Dispose of the form's resources

                // Ensure the old form is completely removed from memory and taskbar
                Application.DoEvents(); // Allow UI to refresh and clear pending events
            }
        }
        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
