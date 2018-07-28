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
    public partial class UserDetailsForm : Form
    {
        string name = "";
        string email = "";
        string password = "";
        string confPassword = "";
        bool active;
        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        List<UserProfile> profiles = new List<UserProfile>();

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile u = new UserProfile(reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()), Int32.Parse(reader["ID"].ToString()));
                    profiles.Add(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile u in profiles)
            {
                cmbProfile.Items.Add(u);
            }
        }

        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            confPassword = tbxConfPassword.Text;
            active = cbxActive.Checked;

        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfPassword.Text = "";
            cbxActive.Checked = false;
            cmbProfile.Text = "";
        }

        //Delete
        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackColor = Color.Gainsboro;
            lblDelete.Visible = true;
        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackColor = Color.Transparent;
            lblDelete.Visible = false;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            
        }

        //Save
        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {
            pbxSave.BackColor = Color.Gainsboro;
            lblSave.Visible = true;
        }

        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {
            pbxSave.BackColor = Color.Transparent;
            lblSave.Visible = false;
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                if (confPassword == password)
                {
                    sqlConnect.Open();
                    string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password, @email, @active, @profile)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@profile", ((UserProfile)cmbProfile.SelectedItem).Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    CleanData();
                }
                else
                {
                    MessageBox.Show("Senhas não coincidem!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usuário!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();

            }
        }

        //Back
        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackColor = Color.Gainsboro;
            lblBack.Visible = true;
        }

        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackColor = Color.Transparent;
            lblBack.Visible = false;
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
