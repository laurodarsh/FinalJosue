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
    public partial class LoginForm : Form
    {
        User aux = new User();
        string name = "";
        string password = "";

        void GetData()
        {
            name = tbxName.Text;
            password = tbxPassword.Text;
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckLogin(string password, string name)
        {
            User user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    aux = user;
                    return true;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetData();
            if (CheckLogin(password, name))
            {
                HomeForm mainForm = new HomeForm(aux);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                CleanData();
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
