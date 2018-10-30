using ProjetoFinal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

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


        #region Login

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
       
        #endregion

        #region LostPassword

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

        void UpdatePassword()
        {

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                User user = UserHelper.SelectByName(tbxName.Text);
                if (user.Email != null)
                {
                    EmailHelper.SendEmail(user.Email);

                    GetData();
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET PASSWORD = @password Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash("456")));

                    cmd.Parameters.Add(new SqlParameter("@id", user.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uma nova senha foi enviada para seu e-mail!");
                    Log.SaveLog("Usuário Editado", "Edição", DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Este usuário não existe!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        void HideComponents()
        {
            lblPassword.Visible = false;
            tbxPassword.Visible = false;
            btnLostPassword.Visible = false;
            btnSend.Visible = true;
            btnLogin.Visible = false;
            pbxBack.Visible = true;
            lblBack.Visible = true;
        }

        void ShowComponents()
        {
            lblPassword.Visible = true;
            tbxPassword.Visible = true;
            btnSend.Visible = false;
            btnLostPassword.Visible = true;
            btnLogin.Visible = true;
            pbxBack.Visible = false;
            lblBack.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowComponents();
        }

        private void btnLostPassword_Click(object sender, EventArgs e)
        {
            HideComponents();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Length > 0)
            {
                UpdatePassword();
                ShowComponents();
            }
            else
            {
                MessageBox.Show("Digite seu nome de Usuário!");
            }
        }

        #endregion

        #region Back

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ShowComponents();
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackColor = Color.Gainsboro;
            lblBack.Font = new Font(lblBack.Font, FontStyle.Bold);
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackColor = Color.Transparent;
            lblBack.Font = new Font(lblBack.Font, FontStyle.Regular);
        }
       
        #endregion
    }
}
