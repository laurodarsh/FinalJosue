using ProjetoFinal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Forms
{
    public partial class HomeForm : Form
    {
        User aux = new User();
        public HomeForm(User user)
        {
            InitializeComponent();

            if (user.UserProfile.Id != 3)
            {
                pbxLog.BackColor = Color.Gray;
                pbxLog.Enabled = false;
                pbxUser.BackColor = Color.Gray;
                pbxUser.Enabled = false;
                pbxUserProfile.BackColor = Color.Gray;
                pbxUserProfile.Enabled = false;
            }
            aux = user;
            lblOnline.Text = "olá " + user.Name;
        }
        //Category
        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm c = new CategoryAllForm(aux);
            c.Show();
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Gainsboro;
            lblCategory.Visible = true;

        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
            lblCategory.Visible = false;
        }
        
        //Product
        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm p = new ProductAllForm(aux);
            p.Show();
        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Gainsboro;
            lblProduct.Visible = true;
    }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
            lblProduct.Visible = false;
        }

        //User
        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm u = new UserAllForm();
            u.Show();
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Gainsboro;
            lblUser.Visible = true;
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
            lblUser.Visible = false;
        }

        //Log
        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogAllForm l = new LogAllForm();
            l.Show();
        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Gainsboro;
            lblLog.Visible = true;
        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
            lblLog.Visible = false;
        }

        //User Profile
        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm up = new UserProfileAllForm();
            up.Show();
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Gainsboro;
            lblUserProfile.Visible = true;
        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Transparent;
            lblUserProfile.Visible = false;
        }
    }
}
