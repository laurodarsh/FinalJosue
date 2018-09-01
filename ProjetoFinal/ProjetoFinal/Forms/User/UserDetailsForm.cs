﻿using ProjetoFinal.Classes;
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

        public UserDetailsForm(int idUser)
        {
            InitializeComponent();

            lblId.Text = idUser.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM USER WHERE ID = " + idUser_Profile.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["EMAIL"].ToString();
                            user.Password = reader["PASSWORD"].ToString();
                        }
                    }

                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;

                }
                catch (Exception EX)
                {
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        void GetData()
        {
            name = tbxName.Text;
            active = cbxActive.Checked;
        }

        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
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
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE USER SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    Log.SaveLog("Usuário Excluído", "Exclusão", DateTime.Now);

                    MessageBox.Show("Usuário inativo!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
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
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash(password)));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@profile", ((UserProfile)cmbProfile.SelectedItem).Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog("Usuário Adicionado", "Adição", DateTime.Now);
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
