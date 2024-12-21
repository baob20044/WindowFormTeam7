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

namespace StoreManage.Components.Add
{
    public partial class ColorAdd : UserControl
    {
        private readonly ColorController colorController;
        public ColorAdd()
        {
            InitializeComponent();
            colorController = new ColorController(new ApiService());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string hexacode = txtHexacode.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(hexacode))
            {
                MessageBox.Show("Please provide both color name and hexacode.");
                return;
            }

            var createdcolor = new ColorCreateDto
            {
                Name = name,
                HexaCode = hexacode,
            };
            try
            {
                var response = colorController.CreateAsync(createdcolor);
                if (response != null)
                {
                    MessageBox.Show("Created color successfully");
                    var adminMainForm = this.FindForm() as AdminMainForm;
                    adminMainForm.refreshColor();
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    Console.WriteLine("Error adding color");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void txtHexacode_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Create a color display panel
                    var colorDisplayPanel = new Panel
                    {
                        Size = new Size(262, 176),
                        BackColor = ColorTranslator.FromHtml(txtHexacode.Text.Trim()), // Convert HexaCode to Color
                    };
                    colorDisplayPanel.BringToFront();
                    flowLayoutPanel.Controls.Clear();
                    flowLayoutPanel.Controls.Add(colorDisplayPanel);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid HexaCode. Please enter a valid color code.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
