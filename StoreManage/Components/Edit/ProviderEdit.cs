using StoreManage.Components.Add;
using StoreManage.Controllers;
using StoreManage.DTOs.Providerr;
using StoreManage.DTOs.Subcategory;
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
    public partial class ProviderEdit : UserControl
    {
        private int ProviderId;
        private readonly ProviderController providerController;
        public ProviderEdit(int providerId)
        {
            InitializeComponent();
            ProviderId = providerId;
            providerController = new ProviderController(new ApiService());
            LoadProvider(providerId);
        }
        public async void LoadProvider(int providerId)
        {
            try
            {
                var response = await providerController.GetByIdAsync(providerId);
                if (response != null)
                {
                    txtName.Text = response.ProviderCompanyName;
                    txtEmail.Text = response.ProviderEmail;
                    txtPhone.Text = response.ProviderPhone;
                }
                else MessageBox.Show("Wrong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Email = txtEmail.Text;
            string Phone = txtPhone.Text;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Please enter company name, email and phone number.");
                return;
            }

            var updateProvider = new ProviderUpdateDto
            {
                ProviderCompanyName = txtName.Text,
                ProviderEmail = txtEmail.Text,  
                ProviderPhone = txtPhone.Text,
            };

            try
            {
                // Execute the PUT request asynchronously
                var response = await providerController.UpdateAsync(ProviderId, updateProvider);

                if (response != null)
                {
                    MessageBox.Show("Updated provider successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshProvider();
                    this.Parent.Controls.Remove(this);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
