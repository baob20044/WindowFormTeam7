using StoreManage.Components.Add;
using StoreManage.Controllers;
using StoreManage.DTOs.PColor;
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
    public partial class ColorEdit : UserControl
    {
        private readonly ColorController colorController;
        private int ColorId;
        public ColorEdit(int colorId)
        {
            InitializeComponent();
            colorController = new ColorController(new ApiService());
            LoadData(colorId);
            ColorId = colorId;
        }
        private async void LoadData(int colorId)
        {
            try
            {
                var response = await colorController.GetByIdAsync(colorId);
                if (response != null) 
                {
                    txtName.Text = response.Name;
                    txtHexacode.Text = response.HexaCode;
                    try
                    {
                        var colorDisplayPanel = new Panel
                        {
                            Size = new Size(262, 176),
                            BackColor = ColorTranslator.FromHtml(txtHexacode.Text.Trim()), // Convert HexaCode to Color
                        };
                        colorDisplayPanel.BringToFront();
                        flowLayoutPanel.Controls.Clear();
                        flowLayoutPanel.Controls.Add(colorDisplayPanel);
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error loading data");
                }
            }catch
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
            string name = txtName.Text;
            string hexacode = txtHexacode.Text;
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(hexacode))
            {
                MessageBox.Show("Please provide both color name and hexacode.");
                return;
            }
            var uploadedColor = new ColorUpdateDto
            {
                Name = name,
                HexaCode = hexacode,
            };
            try
            {
                var response = await colorController.UpdateAsync(ColorId, uploadedColor);
                if(response != null)
                {
                    MessageBox.Show("Updated color successfully");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshColor();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Error uploading color");
                }
            }
            catch { Console.WriteLine("Error"); }
        }

        private void txtHexacode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                try
                {
                    var colorDisplayPanel = new Panel
                    {
                        Size = new Size(262, 176),
                        BackColor = ColorTranslator.FromHtml(txtHexacode.Text.Trim()), // Convert HexaCode to Color
                    };
                    colorDisplayPanel.BringToFront();
                    flowLayoutPanel.Controls.Clear();
                    flowLayoutPanel.Controls.Add(colorDisplayPanel);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
