using StoreManage.Controllers;
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

namespace StoreManage.Components
{
    public partial class EmployeeDetail : UserControl
    {
        private readonly EmployeeController employeeController;
        private int EmployeeId;
        public EmployeeDetail(int employeeId)
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
    }
}
