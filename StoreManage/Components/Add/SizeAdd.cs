using StoreManage.Controllers;
using StoreManage.DTOs.Size;
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
    public partial class SizeAdd : UserControl
    {
        SizeController sizeController;
        public SizeAdd()
        {
            InitializeComponent();
            sizeController = new SizeController(new ApiService());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var sizeValue = txtName.Text;

            if (string.IsNullOrEmpty(sizeValue))
            {
                MessageBox.Show("Please provide size value.");
                return;
            }

            var createdSize = new SizeCreateDto
            {
                SizeValue = sizeValue,
            };
            try
            {
                var response = await sizeController.CreateAsync(createdSize);
                if (response != null)
                {
                    MessageBox.Show("Created Size successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshSize();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Add size error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
