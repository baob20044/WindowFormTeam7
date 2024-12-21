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

namespace StoreManage.Components.Edit
{
    public partial class PasswordEdit : UserControl
    {
        private readonly AuthController _authController;
        private Timer fadeTimer; // Declare Timer globally - Dùng cho chuyển trang
        private ProfileEdit _profileEdit;
        //private 
        public PasswordEdit(ProfileEdit profileEdit)
        {
            InitializeComponent();
            _authController = new AuthController(new Services.ApiService());
            _profileEdit = profileEdit;
            _profileEdit.LoadAvatarImageAsync(_profileEdit._avatar, pictureBox);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtConfirmPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm password don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resulT = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo);

            if (resulT == DialogResult.No)
            {
                return;
            }

            NewPasswordDto newPasswordDto = new NewPasswordDto
            {
                OldPassword = txtOldPassword.Text,
                NewPassword = newPassword,
                ConfirmNewPassword = confirmPassword,
                UserName = TokenManager.GetUsername(),

            };

            try
            {
                btnSubmit.Enabled = false;
                var result = await _authController.changePassWordAsync(newPasswordDto);

                if (result != null)
                {
                    MessageBox.Show("Successfully");
                    TokenManager.RemoveToken();
                    var mainForm = this.FindForm() as MainForm;
                    mainForm.NavigateToLoginForm();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtOldPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
                txtOldPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar 
                                                        = txtConfirmPassword.UseSystemPasswordChar = true;

        }


       
    }
}
