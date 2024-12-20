using StoreManage.Controllers;
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
    public partial class ProfileEdit : UserControl
    {
        private readonly EmployeeController _employeeController;
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
                //txtEmail.Text = result.
                txtAddress.Text = result.PersonalInfo.Address;
                dtpBirthday.Text = result.PersonalInfo.DateOfBirth;
                txtPhoneNumber.Text = result.PersonalInfo.PhoneNumber;
                if (result.PersonalInfo.Male)
                    rBMale.Checked = true;
                else rbFemale.Checked = true;

            }
            else
            {
                Console.WriteLine($"Load profile failed: {result}"); 
            }
        }

       
    }
}
