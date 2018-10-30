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
    public partial class UserAllForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        User aux = new User();
        public UserAllForm(User user)
        {
            InitializeComponent();
            aux = user;
            ShowData();
            ResizeDataGridView();
        }

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].ACTIVE, [USER].EMAIL, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE = USER_PROFILE.ID", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvUser.Columns["EMAIL"].HeaderText = "Email";
            dgvUser.Columns["ACTIVE"].DisplayIndex = 4;
            dgvUser.Columns["NAME1"].HeaderText = "Perfil";
            dgvUser.Columns["NAME1"].DisplayIndex = 3;

            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        //Delete
        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackColor = Color.Gainsboro;
            lblDelete.Font = new Font(lblDelete.Font, FontStyle.Bold);

        }

        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackColor = Color.Transparent;
            lblDelete.Font = new Font(lblDelete.Font, FontStyle.Regular);
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE USER SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário inativo!");
                Log.SaveLog("Usuário Excluído", "Exclusão", DateTime.Now);
                ShowData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao excluir este usuário!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
    }

        //Edit
        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {
            pbxEdit.BackColor = Color.Gainsboro;
            lblEdit.Font = new Font(lblEdit.Font, FontStyle.Bold);
        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {
            pbxEdit.BackColor = Color.Transparent;
            lblEdit.Font = new Font(lblEdit.Font, FontStyle.Regular);
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            UserDetailsForm UserDetails = new UserDetailsForm (idUser, aux);
            UserDetails.Show();

            this.Close();
        }

        //Add
        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackColor = Color.Gainsboro;
            lblAdd.Font = new Font(lblAdd.Font, FontStyle.Bold);
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackColor = Color.Transparent;
            lblAdd.Font = new Font(lblAdd.Font, FontStyle.Regular);
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm ud = new UserDetailsForm(aux);
            ud.Show();
            this.Close();
        }

        //Back
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

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm(aux);
            hm.Show();
            this.Close();
        }
        
        //Search

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string optionForm = "UserForm";
            string optionString = "name";

            Search search = new Search();
            dgvUser.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }

        //Eraser
        private void pbxEraser_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
