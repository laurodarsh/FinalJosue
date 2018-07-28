namespace ProjetoFinal.Forms
{
    partial class UserDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxConfPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProfile
            // 
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(198, 141);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(121, 21);
            this.cmbProfile.TabIndex = 44;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(91, 141);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(51, 17);
            this.lblProfile.TabIndex = 43;
            this.lblProfile.Text = "Perfil:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(198, 77);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(121, 20);
            this.tbxPassword.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(91, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 17);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Senha:";
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(198, 176);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 40;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.SystemColors.Control;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(311, 289);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(41, 15);
            this.lblSave.TabIndex = 39;
            this.lblSave.Text = "Salvar";
            this.lblSave.Visible = false;
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::ProjetoFinal.Properties.Resources.img_433078;
            this.pbxSave.Location = new System.Drawing.Point(304, 250);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(55, 40);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSave.TabIndex = 38;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            this.pbxSave.MouseEnter += new System.EventHandler(this.pbxSave_MouseEnter);
            this.pbxSave.MouseLeave += new System.EventHandler(this.pbxSave_MouseLeave);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.SystemColors.Control;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(371, 289);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(44, 15);
            this.lblDelete.TabIndex = 37;
            this.lblDelete.Text = "Excluir";
            this.lblDelete.Visible = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.SystemColors.Control;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(21, 289);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(38, 15);
            this.lblBack.TabIndex = 36;
            this.lblBack.Text = "Voltar";
            this.lblBack.Visible = false;
            // 
            // pbxDelete
            // 
            this.pbxDelete.Image = global::ProjetoFinal.Properties.Resources.img_275374;
            this.pbxDelete.Location = new System.Drawing.Point(365, 250);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(55, 40);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelete.TabIndex = 35;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            this.pbxDelete.MouseEnter += new System.EventHandler(this.pbxDelete_MouseEnter);
            this.pbxDelete.MouseLeave += new System.EventHandler(this.pbxDelete_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.Image = global::ProjetoFinal.Properties.Resources.circled_left_2;
            this.pbxBack.Location = new System.Drawing.Point(12, 250);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(55, 40);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 34;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(198, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 33;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(96, 173);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(49, 17);
            this.lblActive.TabIndex = 32;
            this.lblActive.Text = "Ativo:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(91, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Nome:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(198, 45);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(121, 20);
            this.tbxEmail.TabIndex = 46;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(91, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            // 
            // tbxConfPassword
            // 
            this.tbxConfPassword.Location = new System.Drawing.Point(198, 109);
            this.tbxConfPassword.Name = "tbxConfPassword";
            this.tbxConfPassword.Size = new System.Drawing.Size(121, 20);
            this.tbxConfPassword.TabIndex = 48;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(91, 109);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(102, 17);
            this.lblConfirmPassword.TabIndex = 47;
            this.lblConfirmPassword.Text = "Conf. Senha:";
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.tbxConfPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblName);
            this.Name = "UserDetailsForm";
            this.Text = "Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxConfPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}