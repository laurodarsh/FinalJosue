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
    public partial class UserProfileDetailsForm : Form
    {
        public UserProfileDetailsForm()
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
