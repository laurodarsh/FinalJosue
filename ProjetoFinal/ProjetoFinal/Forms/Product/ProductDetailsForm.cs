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
    public partial class ProductDetailsForm : Form
    {
        string name = "";
        bool active = false;
        float price = 0;
        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        List<Category> categories = new List<Category>();

        public ProductDetailsForm()
        {
            InitializeComponent();
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();
        }

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()), Int32.Parse(reader["ID"].ToString()));
                    categories.Add(c);
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
            foreach (Category c in categories)
            {
                cmbCategory.Items.Add(c);
            }
        }

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            active = cbxActive.Checked;

        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            cbxActive.Checked = false;
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

                sqlConnect.Open();
                string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                cmd.Parameters.Add(new SqlParameter("@category", ((Category)cmbCategory.SelectedItem).Id));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto!" + ex.Message);
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
