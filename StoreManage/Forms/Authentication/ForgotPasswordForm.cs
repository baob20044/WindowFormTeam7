using StoreManage.Controllers;
using StoreManage.DTOs.Account;
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
    public partial class ForgotPasswordForm : Form
    {
        private readonly AuthController _authController;
        private Timer fadeTimer; // Declare Timer globally - Dùng cho chuyển trang 

        public ForgotPasswordForm()
        {
            InitializeComponent();
            _authController = new AuthController(new ApiService());
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please fill in all required fields ");
                return;
            }

            var forgot = new ForgotPasswordDto
            {
                email = txtEmail.Text,
                username = txtUsername.Text,
            };
            try
            {
                btnSubmit.Enabled = false;

                var result = await _authController.ForgotAsync(forgot);
                if ( result != null)
                {
                    MessageBox.Show("Successfully!, please check your email");
                    NavigateToLoginForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                btnSubmit.Enabled = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigateToLoginForm();
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
    }
}
