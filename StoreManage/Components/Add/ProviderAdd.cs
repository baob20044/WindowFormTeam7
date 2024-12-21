using StoreManage.Controllers;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Providerr;
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

namespace StoreManage.Components.Add
{
    public partial class ProviderAdd : UserControl
    {
        private readonly ProviderController providerController;
        public ProviderAdd()
        {
            InitializeComponent();
            providerController = new ProviderController(new ApiService());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please provide both company name, email and phone number.");
                return;
            }

            var createdprovider = new ProviderCreateDto
            {
                ProviderCompanyName = name,
                ProviderEmail = email,
                ProviderPhone = phone
            };
            try
            {
                var response = providerController.CreateAsync(createdprovider);
                if (response != null)
                {
                    MessageBox.Show("Created provider successfully");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshColor();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Error adding provider");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
