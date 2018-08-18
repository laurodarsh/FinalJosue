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
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.lblOnline = new System.Windows.Forms.Label();
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
            this.lblCategory.Location = new System.Drawing.Point(117, 124);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 15);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Categoria";
            this.lblCategory.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(261, 124);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 15);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Produto";
            this.lblProduct.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(48, 249);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuário";
            this.lblUser.Visible = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(203, 249);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 15);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log";
            this.lblLog.Visible = false;
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.Location = new System.Drawing.Point(307, 249);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(98, 15);
            this.lblUserProfile.TabIndex = 11;
            this.lblUserProfile.Text = "Perfil de Usuário";
            this.lblUserProfile.Visible = false;
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::ProjetoFinal.Properties.Resources.log;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Location = new System.Drawing.Point(161, 173);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(106, 73);
            this.pbxLog.TabIndex = 6;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::ProjetoFinal.Properties.Resources.user_male2_512;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Location = new System.Drawing.Point(21, 173);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(106, 73);
            this.pbxUser.TabIndex = 5;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = global::ProjetoFinal.Properties.Resources.img_231353;
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Location = new System.Drawing.Point(232, 48);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(106, 73);
            this.pbxProduct.TabIndex = 4;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::ProjetoFinal.Properties.Resources.img_208889;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Location = new System.Drawing.Point(94, 48);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(106, 73);
            this.pbxCategory.TabIndex = 3;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = global::ProjetoFinal.Properties.Resources._17_512;
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserProfile.Location = new System.Drawing.Point(302, 173);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(106, 73);
            this.pbxUserProfile.TabIndex = 2;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
            this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.Location = new System.Drawing.Point(336, 293);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(83, 15);
            this.lblOnline.TabIndex = 12;
            this.lblOnline.Text = "Olá Usuário";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
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
    }
}