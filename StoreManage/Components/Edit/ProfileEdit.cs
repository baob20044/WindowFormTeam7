using Microsoft.AspNetCore.Http;
using StoreManage.Controllers;
using StoreManage.DTOs.Employee;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace StoreManage.Components.Edit
{
    public partial class ProfileEdit : UserControl
    {
        private readonly EmployeeController _employeeController;
        private int employeeId = 0;
        private IFormFile _selectedFile;
        public string _avatar;
        
        public ProfileEdit()
        {
            InitializeComponent();
            _employeeController = new EmployeeController (new Services.ApiService());
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        private async void loadProfile()
        {
            var result = await _employeeController.GetDetailsAsync();
            if (result != null)
            {
                txtFirstName.Text = result.PersonalInfo.FirstName;
                txtLastName.Text = result.PersonalInfo.LastName;

                if (result.PersonalInfo.Male)
                    rBMale.Checked = true;
                else rbFemale.Checked = true;

                txtPhoneNumber.Text = result.PersonalInfo.PhoneNumber;
                txtAddress.Text = result.PersonalInfo.Address;
                dtpBirthday.Text = result.PersonalInfo.DateOfBirth;

                txtEmail.Text = result.Email;
                try
                {
                    LoadAvatarImageAsync(result.Avatar, avatarimg);
                    _avatar = result.Avatar;
                }
                catch {
                    avatarimg.Image = null;
                }
                employeeId = result.EmployeeId;

            }
            else
            {
                Console.WriteLine($"Load profile failed: {result}"); 
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    avatarimg.Image = Image.FromFile(filePath);

                    _selectedFile = new FormFile(
                    File.OpenRead(filePath),
                    0,
                    new FileInfo(filePath).Length,
                    null,
                    Path.GetFileName(filePath)
                    );
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtPhoneNumber.Text))

            {
                MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resulT = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin?", "Xác nhận", MessageBoxButtons.YesNo);

            if (resulT == DialogResult.No)
            {

                return;
            }

            var employeeUpdateDto = new EmployeeUpdateDto
            {
                PersonalInfo = new EmployeePersonalInfo
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    DateOfBirth = dtpBirthday.Value.ToString("yyyy-MM-dd"),
                    PhoneNumber = txtPhoneNumber.Text,
                    Male = rBMale.Checked ? true : false,
                },
                Email = txtEmail.Text
            };

            try
            {
                btnSave.Enabled = false;
                var updatedEmployee = await _employeeController.UpdateAsync(employeeId, employeeUpdateDto, _selectedFile);

                if (updatedEmployee != null)
                {
                    MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed : {ex.Message}");
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        public async void LoadAvatarImageAsync(string imageUrl, Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Download the image data
                    var imageBytes = await client.GetByteArrayAsync(imageUrl);

                    // Convert the byte array to an image and assign it to the PictureBox
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
    }
}
