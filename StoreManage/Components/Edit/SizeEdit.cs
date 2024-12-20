using StoreManage.Controllers;
using StoreManage.DTOs.Size;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components.Edit
{
    public partial class SizeEdit : UserControl
    {
        SizeController sizeController;
        private int SizeId;
        public SizeEdit(int sizeId)
        {
            InitializeComponent();
            sizeController = new SizeController(new ApiService());
            SizeId = sizeId;
            LoadSize(sizeId);
        }
        private void SizeEdit_Load(object sender, EventArgs e)
        {

        }
        private async void LoadSize(int sizeId)
        {
            try
            {
                var response = await sizeController.GetByIdAsync(sizeId);
                if (response != null)
                {
                    txtName.Text = response.SizeValue;
                }
                else
                {
                    Console.WriteLine("Error loading size");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string sizeValue = txtName.Text;
            if (string.IsNullOrEmpty(sizeValue)) {
                MessageBox.Show("Please provide Size Value.");
                return;
            }

            var uploadedSize = new SizeUpdateDto
            {
                SizeValue = sizeValue
            };
            try
            {
                var response = await sizeController.UpdateAsync(SizeId, uploadedSize);
                if (response != null)
                {
                    MessageBox.Show("Uploaded size successfully!");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshSize();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Error uploading size");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error uploading size" + ex.Message);
            }
        }

    }
}
