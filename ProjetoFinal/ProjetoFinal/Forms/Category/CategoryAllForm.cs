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
    public partial class CategoryAllForm : Form
    {
        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        User aux = new User();

        public CategoryAllForm(User user)
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
                string sql;
                sqlConnect.Open();
                if (aux.UserProfile.Id != 3)
                {
                    sql = "SELECT * FROM CATEGORY WHERE ACTIVE = @active";
                  
                }
                else
                {
                    sql = "SELECT * FROM CATEGORY";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                if (aux.UserProfile.Id != 3)
                {
                    cmd.Parameters.Add(new SqlParameter("@active", true));
                }
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

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
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
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
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Categoria inativa!");
                Log.SaveLog("Categoria Excluída", "Exclusão", DateTime.Now);
                ShowData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao excluir esta categoria!" + "\n\n" + Ex.Message);
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
            lblEdit.Visible = true;
        }

        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {
            pbxEdit.BackColor = Color.Transparent;
            lblEdit.Visible = false;
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory,aux);
            categoryDetails.Show();

            this.Close();
        }

        //Add
        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackColor = Color.Gainsboro;
            lblAdd.Visible = true;
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackColor = Color.Transparent;
            lblAdd.Visible = false;
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm cd = new CategoryDetailsForm(aux);
            cd.Show();
            this.Close();
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
            HomeForm hm = new HomeForm(aux);
            hm.Show();
            this.Close();
            
        }

        //Sarch
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search = new Search();
            dgvCategory.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }

        //Eraser
        private void pbxEraser_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
