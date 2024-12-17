using StoreManage.AdminForms.Pages;
using StoreManage.Forms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage
{
    public partial class MainForm : Form
    {
        private HomePage homeInterface; 
        private CategoryPage categoryInterface;
        private CartPage cartInterface;
        private ProfilePage profileInterface;
        public MainForm()
        {
            InitializeComponent();

            btnHome.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "Icon", "home.png"));
            btnCategory.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "Icon", "category-100.png"));
            btnCart.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "Icon", "cart-64.png"));
            btnProfile.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "Icon", "user-profile.png"));


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeInterface = new HomePage();
            flowLayoutPanel.Controls.Add(homeInterface);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            homeInterface = new HomePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(homeInterface);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            categoryInterface = new CategoryPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(categoryInterface);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cartInterface = new CartPage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(cartInterface);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileInterface = new ProfilePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(profileInterface);
        }
    }
}
