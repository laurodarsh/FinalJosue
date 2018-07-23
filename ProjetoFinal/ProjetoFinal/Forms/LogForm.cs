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
    public partial class LogAllForm : Form
    {
        public LogAllForm()
        {
            InitializeComponent();
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
