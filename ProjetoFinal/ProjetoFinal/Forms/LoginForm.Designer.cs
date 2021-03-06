﻿namespace ProjetoFinal.Forms
{
    partial class LoginForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLostPassword = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(210, 80);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(103, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Nome:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(210, 113);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(121, 20);
            this.tbxPassword.TabIndex = 44;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(103, 113);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 17);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = "Senha:";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(106, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 39);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLostPassword
            // 
            this.btnLostPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLostPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLostPassword.Location = new System.Drawing.Point(234, 164);
            this.btnLostPassword.Name = "btnLostPassword";
            this.btnLostPassword.Size = new System.Drawing.Size(97, 39);
            this.btnLostPassword.TabIndex = 46;
            this.btnLostPassword.Text = "Perdi a senha";
            this.btnLostPassword.UseVisualStyleBackColor = true;
            this.btnLostPassword.Click += new System.EventHandler(this.btnLostPassword_Click);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(170, 114);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 39);
            this.btnSend.TabIndex = 47;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.SystemColors.Control;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(21, 289);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(38, 15);
            this.lblBack.TabIndex = 49;
            this.lblBack.Text = "Voltar";
            this.lblBack.Visible = false;
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = global::ProjetoFinal.Properties.Resources.circled_left_2;
            this.pbxBack.Location = new System.Drawing.Point(12, 250);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(55, 40);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 48;
            this.pbxBack.TabStop = false;
            this.pbxBack.Visible = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            this.pbxBack.MouseEnter += new System.EventHandler(this.pbxBack_MouseEnter);
            this.pbxBack.MouseLeave += new System.EventHandler(this.pbxBack_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLostPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLostPassword;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}