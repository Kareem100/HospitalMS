
namespace HospitalMS
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.pictureOldPasswordBackground = new System.Windows.Forms.PictureBox();
            this.picturePasswordIcon = new System.Windows.Forms.PictureBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturePasswordBackground = new System.Windows.Forms.PictureBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOldPasswordBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOldPasswordBackground
            // 
            this.pictureOldPasswordBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureOldPasswordBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureOldPasswordBackground.Image")));
            this.pictureOldPasswordBackground.Location = new System.Drawing.Point(74, 91);
            this.pictureOldPasswordBackground.Name = "pictureOldPasswordBackground";
            this.pictureOldPasswordBackground.Size = new System.Drawing.Size(262, 48);
            this.pictureOldPasswordBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOldPasswordBackground.TabIndex = 8;
            this.pictureOldPasswordBackground.TabStop = false;
            // 
            // picturePasswordIcon
            // 
            this.picturePasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picturePasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordIcon.Image")));
            this.picturePasswordIcon.Location = new System.Drawing.Point(84, 99);
            this.picturePasswordIcon.Name = "picturePasswordIcon";
            this.picturePasswordIcon.Size = new System.Drawing.Size(28, 28);
            this.picturePasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswordIcon.TabIndex = 9;
            this.picturePasswordIcon.TabStop = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOldPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOldPassword.Location = new System.Drawing.Point(112, 103);
            this.txtOldPassword.Multiline = true;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(217, 25);
            this.txtOldPassword.TabIndex = 10;
            this.txtOldPassword.Text = "Old Password";
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.Enter += new System.EventHandler(this.txtOldPassword_Enter);
            this.txtOldPassword.Leave += new System.EventHandler(this.txtOldPassword_Leave);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Controls.Add(this.btnChangePassword);
            this.panelContainer.Controls.Add(this.txtNewPassword);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Controls.Add(this.picturePasswordBackground);
            this.panelContainer.Controls.Add(this.txtOldPassword);
            this.panelContainer.Controls.Add(this.picturePasswordIcon);
            this.panelContainer.Controls.Add(this.pictureOldPasswordBackground);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 99);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(395, 420);
            this.panelContainer.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(88, 346);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 34);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Tomato;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(49, 273);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(310, 40);
            this.btnChangePassword.TabIndex = 29;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNewPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.Location = new System.Drawing.Point(111, 190);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(218, 25);
            this.txtNewPassword.TabIndex = 14;
            this.txtNewPassword.Text = "New Password";
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Enter += new System.EventHandler(this.txtNewPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // picturePasswordBackground
            // 
            this.picturePasswordBackground.BackColor = System.Drawing.Color.Transparent;
            this.picturePasswordBackground.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordBackground.Image")));
            this.picturePasswordBackground.Location = new System.Drawing.Point(74, 178);
            this.picturePasswordBackground.Name = "picturePasswordBackground";
            this.picturePasswordBackground.Size = new System.Drawing.Size(262, 46);
            this.picturePasswordBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswordBackground.TabIndex = 12;
            this.picturePasswordBackground.TabStop = false;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChangePassword.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblChangePassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblChangePassword.Location = new System.Drawing.Point(205, 34);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(300, 50);
            this.lblChangePassword.TabIndex = 17;
            this.lblChangePassword.Text = "Change Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOldPasswordBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureOldPasswordBackground;
        private System.Windows.Forms.PictureBox picturePasswordIcon;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturePasswordBackground;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
    }
}