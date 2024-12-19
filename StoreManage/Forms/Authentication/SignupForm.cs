using StoreManage.Controllers;
using StoreManage.DTOs.Account;
using StoreManage.DTOs.Customer;
using StoreManage.DTOs.Employee;
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
    public partial class SignupForm : Form
    {
        private readonly AuthController _authController;
        private Timer fadeTimer; // Declare Timer globally - Dùng cho chuyển trang 
        public SignupForm()
        {
            InitializeComponent();
            _authController = new AuthController(new ApiService());
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validating())
            {
                try
                {
                    btnSubmit.Enabled = false;
                    var employee = new EmployeeRegisterDto
                    {
                        EmployeeInfo = new EmployeeCreateDto
                        {
                            PersonalInfo = new EmployeePersonalInfo
                            {
                                Address = txtAddress.Text,
                                DateOfBirth = dtpBirthday.Value.ToString("yyyy-MM-dd"),
                                FirstName = txtFirstName.Text,
                                LastName = txtLastName.Text,
                                Male = rBMale.Checked ? true : false,
                                PhoneNumber = txtPhoneNumber.Text,
                            },
                            ContractUpTo = Int32.Parse(txtContractUpTo.Text),
                            ParentPhoneNumber = txtParentPhoneNumber.Text,
                            Salary = decimal.Parse(txtSalary.Text),
                            StartDate = DateTime.Now.ToString("yyyy-MM-dd"),

                        },
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text
                    };

                   var result =  await _authController.SignupAsync(employee);

                    MessageBox.Show(result);
                    NavigateToLoginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Signup failed: {ex.Message}");
                }
                finally
                {
                    btnSubmit.Enabled = true;
                }
            }
        }

        private void lbLoginHere_Click(object sender, EventArgs e)
        {
            NavigateToLoginForm();
        }

        //Chuyển trang
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

        private bool validating()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)
                || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtAddress.Text) || !CbAcceptTerm.Checked 
                || string.IsNullOrEmpty(txtContractUpTo.Text) || string.IsNullOrEmpty(txtParentPhoneNumber.Text) || string.IsNullOrEmpty(txtSalary.Text))
            {
                lbError.Text = "Please fill in all required fields and accept the terms.";
                lbError.Visible = true;
                return false;
            }


            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lbError.Text = "Passwords do not match.";
                lbError.Visible = true;
                return false;
            }



            return true;
        }

    }
}
