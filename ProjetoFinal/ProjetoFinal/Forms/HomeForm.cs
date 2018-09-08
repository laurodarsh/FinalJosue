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
            lblCategory.Font = new Font(lblCategory.Font, FontStyle.Bold);

        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font(lblCategory.Font, FontStyle.Regular);
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
            lblProduct.Font = new Font(lblProduct.Font, FontStyle.Bold);
        }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font(lblProduct.Font, FontStyle.Regular);
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
            lblUser.Font = new Font(lblUser.Font, FontStyle.Bold);
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
            lblUser.Font = new Font(lblUser.Font, FontStyle.Regular);
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
            lblLog.Font = new Font(lblLog.Font, FontStyle.Bold);
        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
            lblLog.Font = new Font(lblLog.Font, FontStyle.Regular);
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
            lblUserProfile.Font = new Font(lblUserProfile.Font, FontStyle.Bold);
        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Transparent;
            lblUserProfile.Font = new Font(lblUserProfile.Font, FontStyle.Regular);
        }

        //LogOff
        private void pbxLogOff_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void pbxLogOff_MouseEnter(object sender, EventArgs e)
        {
            pbxLogOff.BackColor = Color.Gainsboro;
            lblLogOff.Font = new Font(lblLogOff.Font, FontStyle.Bold);
        }

        private void pbxLogOff_MouseLeave(object sender, EventArgs e)
        {
            pbxLogOff.BackColor = Color.Transparent;
            lblLogOff.Font = new Font(lblLogOff.Font, FontStyle.Regular);
        }
    }
}
