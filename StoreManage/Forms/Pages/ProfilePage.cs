using StoreManage.Components.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class ProfilePage : UserControl
    {
        public ProfileEdit profileEdit { get;private set; }
        public PasswordEdit passwordEdit { get;private set; }


        public ProfilePage()
        {
            InitializeComponent();
            refeshProfile();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            refeshProfile();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            refeshPassword();
        }

        public void refeshProfile()
        {
            profileEdit = new ProfileEdit();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(profileEdit);
        }

        public void refeshPassword()
        {
            passwordEdit = new PasswordEdit();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(passwordEdit);
        }
    }
}
