﻿using StoreManage.AdminForms.Pages;
using StoreManage.Components;
using StoreManage.Forms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StoreManage
{
    public partial class MainForm : Form
    {
        public HomePage homeInterface { get; private set; }
        private CategoryPage categoryInterface;
        public CartPage cartInterface { get; private set; }
        private ProfilePage profileInterface;
        public MainForm()
        {
            InitializeComponent();
            cartInterface = new CartPage();
            homeInterface = new HomePage();
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
        public void ChangeToCart()
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(cartInterface);
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            ChangeToCart();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileInterface = new ProfilePage();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(profileInterface);
        }
        public void handleClickedShopItem(DetailItem detail)
        {
            flowLayoutPanel.Controls.Clear(); // Clear existing details
            flowLayoutPanel.Controls.Add(detail); // Add the new detail view
        }
    }
}
