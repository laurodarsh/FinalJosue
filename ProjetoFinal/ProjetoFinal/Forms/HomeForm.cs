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
        public HomeForm()
        {
            InitializeComponent();
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

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm c = new CategoryAllForm();
            c.Show();
            this.Hide();
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {

        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
            lblProduct.Visible = false;
    }
    }
}
