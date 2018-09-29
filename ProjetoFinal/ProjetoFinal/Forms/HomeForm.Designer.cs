namespace ProjetoFinal.Forms
{
    partial class HomeForm
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.pbxOnline = new System.Windows.Forms.PictureBox();
            this.pbxLogOff = new System.Windows.Forms.PictureBox();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.lblLogOff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(117, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 15);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Categoria";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(261, 100);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 15);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Produto";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(48, 225);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuário";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(203, 225);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 15);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.Location = new System.Drawing.Point(302, 225);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(98, 15);
            this.lblUserProfile.TabIndex = 11;
            this.lblUserProfile.Text = "Perfil de Usuário";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.Location = new System.Drawing.Point(332, 289);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(83, 15);
            this.lblOnline.TabIndex = 12;
            this.lblOnline.Text = "Olá Usuário";
            // 
            // pbxOnline
            // 
            this.pbxOnline.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxOnline.Image = global::ProjetoFinal.Properties.Resources.gender_neutral_user;
            this.pbxOnline.Location = new System.Drawing.Point(305, 284);
            this.pbxOnline.Name = "pbxOnline";
            this.pbxOnline.Size = new System.Drawing.Size(28, 24);
            this.pbxOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOnline.TabIndex = 46;
            this.pbxOnline.TabStop = false;
            // 
            // pbxLogOff
            // 
            this.pbxLogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogOff.Image = global::ProjetoFinal.Properties.Resources.Minio_Devices_and_Hardware_Bold_90_512;
            this.pbxLogOff.Location = new System.Drawing.Point(12, 254);
            this.pbxLogOff.Name = "pbxLogOff";
            this.pbxLogOff.Size = new System.Drawing.Size(55, 40);
            this.pbxLogOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogOff.TabIndex = 42;
            this.pbxLogOff.TabStop = false;
            this.pbxLogOff.Click += new System.EventHandler(this.pbxLogOff_Click);
            this.pbxLogOff.MouseEnter += new System.EventHandler(this.pbxLogOff_MouseEnter);
            this.pbxLogOff.MouseLeave += new System.EventHandler(this.pbxLogOff_MouseLeave);
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Image = global::ProjetoFinal.Properties.Resources.log;
            this.pbxLog.Location = new System.Drawing.Point(161, 149);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(106, 73);
            this.pbxLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLog.TabIndex = 6;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Image = global::ProjetoFinal.Properties.Resources.user_male2_512;
            this.pbxUser.Location = new System.Drawing.Point(21, 149);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(106, 73);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 5;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Image = global::ProjetoFinal.Properties.Resources.img_231353;
            this.pbxProduct.Location = new System.Drawing.Point(232, 24);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(106, 73);
            this.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProduct.TabIndex = 4;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Image = global::ProjetoFinal.Properties.Resources.img_208889;
            this.pbxCategory.Location = new System.Drawing.Point(94, 24);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(106, 73);
            this.pbxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCategory.TabIndex = 3;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserProfile.Image = global::ProjetoFinal.Properties.Resources.User_Man_Gear_Cog_Setting_Control_Avatar_Configure_512;
            this.pbxUserProfile.Location = new System.Drawing.Point(302, 149);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(106, 73);
            this.pbxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserProfile.TabIndex = 2;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
            this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
            // 
            // lblLogOff
            // 
            this.lblLogOff.AutoSize = true;
            this.lblLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOff.Location = new System.Drawing.Point(24, 293);
            this.lblLogOff.Name = "lblLogOff";
            this.lblLogOff.Size = new System.Drawing.Size(29, 15);
            this.lblLogOff.TabIndex = 47;
            this.lblLogOff.Text = "Sair";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lblLogOff);
            this.Controls.Add(this.pbxOnline);
            this.Controls.Add(this.pbxLogOff);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxUserProfile);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxLog;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.PictureBox pbxLogOff;
        private System.Windows.Forms.PictureBox pbxOnline;
        private System.Windows.Forms.Label lblLogOff;
    }
}