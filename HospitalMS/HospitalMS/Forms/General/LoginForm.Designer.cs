
namespace HospitalMS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblHere = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblNewStaff = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picturePasswordIcon = new System.Windows.Forms.PictureBox();
            this.picturePasswordBackground = new System.Windows.Forms.PictureBox();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.pictureFullnameIcon = new System.Windows.Forms.PictureBox();
            this.pictureNameBackground = new System.Windows.Forms.PictureBox();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblOspital = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.lblManagementSystem = new System.Windows.Forms.Label();
            this.txtToBeFocus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullnameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(6, 6);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(50, 45);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.lblHere);
            this.panelContainer.Controls.Add(this.lblRegister);
            this.panelContainer.Controls.Add(this.lblNewStaff);
            this.panelContainer.Controls.Add(this.btnLogin);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.picturePasswordIcon);
            this.panelContainer.Controls.Add(this.picturePasswordBackground);
            this.panelContainer.Controls.Add(this.txtNationalID);
            this.panelContainer.Controls.Add(this.pictureFullnameIcon);
            this.panelContainer.Controls.Add(this.pictureNameBackground);
            this.panelContainer.Controls.Add(this.lblGetStarted);
            this.panelContainer.Controls.Add(this.lblH);
            this.panelContainer.Controls.Add(this.lblOspital);
            this.panelContainer.Controls.Add(this.pictureAvatar);
            this.panelContainer.Controls.Add(this.lblManagementSystem);
            this.panelContainer.Controls.Add(this.txtToBeFocus);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(460, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(316, 504);
            this.panelContainer.TabIndex = 1;
            // 
            // lblHere
            // 
            this.lblHere.AutoSize = true;
            this.lblHere.BackColor = System.Drawing.Color.Transparent;
            this.lblHere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblHere.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHere.Location = new System.Drawing.Point(206, 430);
            this.lblHere.Name = "lblHere";
            this.lblHere.Size = new System.Drawing.Size(39, 19);
            this.lblHere.TabIndex = 14;
            this.lblHere.Text = "Here";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRegister.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRegister.Location = new System.Drawing.Point(150, 430);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(60, 19);
            this.lblRegister.TabIndex = 13;
            this.lblRegister.Text = "Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblNewStaff
            // 
            this.lblNewStaff.AutoSize = true;
            this.lblNewStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblNewStaff.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblNewStaff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNewStaff.Location = new System.Drawing.Point(68, 430);
            this.lblNewStaff.Name = "lblNewStaff";
            this.lblNewStaff.Size = new System.Drawing.Size(86, 19);
            this.lblNewStaff.TabIndex = 12;
            this.lblNewStaff.Text = "New Staff ?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnLogin.Location = new System.Drawing.Point(56, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(203, 52);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(72, 300);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 25);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // picturePasswordIcon
            // 
            this.picturePasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picturePasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordIcon.Image")));
            this.picturePasswordIcon.Location = new System.Drawing.Point(44, 296);
            this.picturePasswordIcon.Name = "picturePasswordIcon";
            this.picturePasswordIcon.Size = new System.Drawing.Size(28, 28);
            this.picturePasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswordIcon.TabIndex = 9;
            this.picturePasswordIcon.TabStop = false;
            // 
            // picturePasswordBackground
            // 
            this.picturePasswordBackground.BackColor = System.Drawing.Color.Transparent;
            this.picturePasswordBackground.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordBackground.Image")));
            this.picturePasswordBackground.Location = new System.Drawing.Point(34, 288);
            this.picturePasswordBackground.Name = "picturePasswordBackground";
            this.picturePasswordBackground.Size = new System.Drawing.Size(243, 45);
            this.picturePasswordBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswordBackground.TabIndex = 8;
            this.picturePasswordBackground.TabStop = false;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNationalID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNationalID.Location = new System.Drawing.Point(72, 232);
            this.txtNationalID.MaxLength = 14;
            this.txtNationalID.Multiline = true;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(198, 24);
            this.txtNationalID.TabIndex = 7;
            this.txtNationalID.Text = "National ID";
            this.txtNationalID.Enter += new System.EventHandler(this.txtNationalID_Enter);
            this.txtNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalID_KeyPress);
            this.txtNationalID.Leave += new System.EventHandler(this.txtNationalID_Leave);
            // 
            // pictureFullnameIcon
            // 
            this.pictureFullnameIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureFullnameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureFullnameIcon.Image")));
            this.pictureFullnameIcon.Location = new System.Drawing.Point(44, 228);
            this.pictureFullnameIcon.Name = "pictureFullnameIcon";
            this.pictureFullnameIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureFullnameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFullnameIcon.TabIndex = 6;
            this.pictureFullnameIcon.TabStop = false;
            // 
            // pictureNameBackground
            // 
            this.pictureNameBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureNameBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureNameBackground.Image")));
            this.pictureNameBackground.Location = new System.Drawing.Point(34, 220);
            this.pictureNameBackground.Name = "pictureNameBackground";
            this.pictureNameBackground.Size = new System.Drawing.Size(243, 45);
            this.pictureNameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNameBackground.TabIndex = 5;
            this.pictureNameBackground.TabStop = false;
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.BackColor = System.Drawing.Color.Transparent;
            this.lblGetStarted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGetStarted.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGetStarted.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGetStarted.Location = new System.Drawing.Point(75, 175);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(181, 18);
            this.lblGetStarted.TabIndex = 4;
            this.lblGetStarted.Text = "Get Started From Login Below !";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(85, 19);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(41, 36);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "H";
            // 
            // lblOspital
            // 
            this.lblOspital.AutoSize = true;
            this.lblOspital.BackColor = System.Drawing.Color.Transparent;
            this.lblOspital.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic);
            this.lblOspital.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOspital.Location = new System.Drawing.Point(119, 25);
            this.lblOspital.Name = "lblOspital";
            this.lblOspital.Size = new System.Drawing.Size(96, 27);
            this.lblOspital.TabIndex = 1;
            this.lblOspital.Text = "ospital";
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAvatar.Image")));
            this.pictureAvatar.Location = new System.Drawing.Point(118, 85);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(80, 80);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 3;
            this.pictureAvatar.TabStop = false;
            // 
            // lblManagementSystem
            // 
            this.lblManagementSystem.AutoSize = true;
            this.lblManagementSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblManagementSystem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblManagementSystem.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblManagementSystem.Location = new System.Drawing.Point(123, 48);
            this.lblManagementSystem.Name = "lblManagementSystem";
            this.lblManagementSystem.Size = new System.Drawing.Size(119, 16);
            this.lblManagementSystem.TabIndex = 2;
            this.lblManagementSystem.Text = "Management System";
            // 
            // txtToBeFocus
            // 
            this.txtToBeFocus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToBeFocus.Location = new System.Drawing.Point(139, 112);
            this.txtToBeFocus.Name = "txtToBeFocus";
            this.txtToBeFocus.Size = new System.Drawing.Size(27, 19);
            this.txtToBeFocus.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pictureClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFullnameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblOspital;
        private System.Windows.Forms.Label lblManagementSystem;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.PictureBox pictureNameBackground;
        private System.Windows.Forms.PictureBox pictureFullnameIcon;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picturePasswordIcon;
        private System.Windows.Forms.PictureBox picturePasswordBackground;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNewStaff;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblHere;
        private System.Windows.Forms.TextBox txtToBeFocus;
    }
}

