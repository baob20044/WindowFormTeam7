using StoreManage.Controllers;
using StoreManage.DTOs.Account;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage
{
    public partial class LoginForm : Form
    {
        private readonly AuthController _authController;
        private Timer fadeTimer; // Dùng cho chuyển trang
        public LoginForm()
        {
            InitializeComponent();
            _authController = new AuthController(new ApiService());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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
                // Gọi phương thức LoginAsync
                var accessToken = await _authController.LoginAsync(username, password);

                TokenManager.SaveToken(accessToken);
                TokenManager.SaveUsername(username);
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
            }
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
            NavigateToSignupForm();
        }
        private void lbForgotpass_Click(object sender, EventArgs e)
        {
            NavigateToForgotPass();
        }
        //Chuyển trang 
        private void NavigateToSignupForm()
        {
            // Initialize the Timer for fade-out
            fadeTimer = new Timer();
            fadeTimer.Interval = 10; // Faster updates for smoother fade
            fadeTimer.Tick += FadeToSignup;
            fadeTimer.Start();
        }
        private void NavigateToMainPage()
        {
            // Initialize the Timer for fade-out
            fadeTimer = new Timer();
            fadeTimer.Interval = 10; // Faster updates for smoother fade
            fadeTimer.Tick += FadeToMainPage;
            fadeTimer.Start();
        }
        private void NavigateToForgotPass()
        {
            // Initialize the Timer for fade-out
            fadeTimer = new Timer();
            fadeTimer.Interval = 10; // Faster updates for smoother fade
            fadeTimer.Tick += FadeToForgotPass;
            fadeTimer.Start();
        }
        private void FadeToSignup(object sender, EventArgs e)
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
                SignupForm signupForm = new SignupForm();
                signupForm.StartPosition = FormStartPosition.CenterScreen;
                signupForm.Location = this.Location;
                signupForm.ShowDialog();  // Show the new form

                // After showing the new form, dispose of the current form
                this.Close(); // Close the form
                this.Dispose(); // Dispose of the form's resources

                // Ensure the old form is completely removed from memory and taskbar
                Application.DoEvents(); // Allow UI to refresh and clear pending events
            }
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
                MainForm mainPage = new MainForm();
                mainPage.StartPosition = FormStartPosition.CenterScreen;
                mainPage.Location = this.Location;
                mainPage.ShowDialog();  // Show the new form

                // After showing the new form, dispose of the current form
                this.Close(); // Close the form
                this.Dispose(); // Dispose of the form's resources

                // Ensure the old form is completely removed from memory and taskbar
                Application.DoEvents(); // Allow UI to refresh and clear pending events
            }
        }
        private void FadeToForgotPass(object sender, EventArgs e)
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
                ForgotPasswordForm fpPage = new ForgotPasswordForm();
                fpPage.StartPosition = FormStartPosition.CenterScreen;
                fpPage.Location = this.Location;
                fpPage.ShowDialog();  // Show the new form

                // After showing the new form, dispose of the current form
                this.Close(); // Close the form
                this.Dispose(); // Dispose of the form's resources

                // Ensure the old form is completely removed from memory and taskbar
                Application.DoEvents(); // Allow UI to refresh and clear pending events
            }
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                txtPassword.IconRight = Image.FromFile(@"..\..\Resources\Images\Closed_Eye.png");
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.IconRight = Image.FromFile(@"..\..\Resources\Images\Eye.png");
            }
        }
    }
}
