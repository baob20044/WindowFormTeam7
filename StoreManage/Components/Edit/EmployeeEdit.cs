using StoreManage.Controllers;
using StoreManage.DTOs.Employee;
using StoreManage.DTOs.PColor;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManage.Components.Edit
{
    public partial class EmployeeEdit : UserControl
    {
        private readonly EmployeeController employeeController;
        private int EmployeeId;
        public EmployeeEdit(int employeeId)
        {
            InitializeComponent();
            employeeController = new EmployeeController(new ApiService());
            LoadData(employeeId);
            EmployeeId = employeeId;
        }
        private async void LoadData(int employeeId)
        {
            try
            {
                var response = await employeeController.GetByIdAsync(employeeId);
                if (response != null)
                {
                    txtFirstName.Text = response.PersonalInfo.FirstName;
                    txtLastName.Text = response.PersonalInfo.LastName;
                    txtEmail.Text = response.Email;
                    txtAddress.Text = response.PersonalInfo?.Address;
                    txtPhoneNumber.Text = response.PersonalInfo?.PhoneNumber;
                    dtpBirthday.Text = response.PersonalInfo.DateOfBirth;
                    if (response.PersonalInfo.Male)
                        rBMale.Checked = true;
                    else rBFemale.Checked = true;
                }
                else
                {
                    Console.WriteLine("Error loading data");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string Birthday = dtpBirthday.Text;
            bool rbMale = rBMale.Checked;  // Assuming rbtnMale is the name of the male radio button
            bool rbFemale = rBFemale.Checked;  // Assuming rbtnFemale is the name of the female radio button

            // Validate that all fields are not empty
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(Birthday))
            {
                MessageBox.Show("Please provide all required fields.");
                return;
            }

            // Validate Email format
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Please provide a valid email address.");
                return;
            }

            // Validate Phone Number format (assuming 10 digits for simplicity)
            if (!IsValidPhoneNumber(PhoneNumber))
            {
                MessageBox.Show("Please provide a valid phone number.");
                return;
            }

            // Validate that one gender is selected
            if (!rbMale && !rbFemale)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Optional: If Birthday is not a valid date (in case the date picker is empty or invalid)
            DateTime birthDate;
            if (!DateTime.TryParse(Birthday, out birthDate))
            {
                MessageBox.Show("Please select a valid birthdate.");
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
                var updatedEmployee = await employeeController.UpdateAsync(EmployeeId, employeeUpdateDto);

                if (updatedEmployee != null)
                {
                    MessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshEmployee();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Error uploading color");
                }
            }
            catch { Console.WriteLine("Error"); }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Assuming a simple 10-digit phone number validation
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }
    }
}
