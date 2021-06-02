
namespace HospitalMS
{
    partial class AppointmentForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm1));
            this.Second_Appointment_txt = new System.Windows.Forms.TextBox();
            this.pictureLastBackground = new System.Windows.Forms.PictureBox();
            this.First_Appointment_txt = new System.Windows.Forms.TextBox();
            this.pictureFirstBackground = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.AddReport_btn = new System.Windows.Forms.Button();
            this.Des_Appointment_txt = new System.Windows.Forms.TextBox();
            this.DesBackGround = new System.Windows.Forms.PictureBox();
            this.Id_Appointment_txt = new System.Windows.Forms.TextBox();
            this.IdBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstBackground)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // Second_Appointment_txt
            // 
            this.Second_Appointment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Second_Appointment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Second_Appointment_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Second_Appointment_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Second_Appointment_txt.Location = new System.Drawing.Point(100, 151);
            this.Second_Appointment_txt.Multiline = true;
            this.Second_Appointment_txt.Name = "Second_Appointment_txt";
            this.Second_Appointment_txt.PasswordChar = '*';
            this.Second_Appointment_txt.Size = new System.Drawing.Size(205, 25);
            this.Second_Appointment_txt.TabIndex = 10;
            this.Second_Appointment_txt.Text = "Last Name";
            this.Second_Appointment_txt.UseSystemPasswordChar = true;
            this.Second_Appointment_txt.Enter += new System.EventHandler(this.Second_Appointment_txt_Enter);
            this.Second_Appointment_txt.Leave += new System.EventHandler(this.Second_Appointment_txt_Leave);
            // 
            // pictureLastBackground
            // 
            this.pictureLastBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureLastBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureLastBackground.Image")));
            this.pictureLastBackground.Location = new System.Drawing.Point(83, 139);
            this.pictureLastBackground.Name = "pictureLastBackground";
            this.pictureLastBackground.Size = new System.Drawing.Size(243, 45);
            this.pictureLastBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLastBackground.TabIndex = 8;
            this.pictureLastBackground.TabStop = false;
            // 
            // First_Appointment_txt
            // 
            this.First_Appointment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.First_Appointment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.First_Appointment_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.First_Appointment_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.First_Appointment_txt.Location = new System.Drawing.Point(100, 81);
            this.First_Appointment_txt.Multiline = true;
            this.First_Appointment_txt.Name = "First_Appointment_txt";
            this.First_Appointment_txt.Size = new System.Drawing.Size(205, 24);
            this.First_Appointment_txt.TabIndex = 7;
            this.First_Appointment_txt.Text = "First Name";
            this.First_Appointment_txt.Enter += new System.EventHandler(this.First_Appointment_txt_Enter);
            this.First_Appointment_txt.Leave += new System.EventHandler(this.First_Appointment_txt_Leave);
            // 
            // pictureFirstBackground
            // 
            this.pictureFirstBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirstBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureFirstBackground.Image")));
            this.pictureFirstBackground.Location = new System.Drawing.Point(79, 72);
            this.pictureFirstBackground.Name = "pictureFirstBackground";
            this.pictureFirstBackground.Size = new System.Drawing.Size(243, 45);
            this.pictureFirstBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirstBackground.TabIndex = 5;
            this.pictureFirstBackground.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.AddReport_btn);
            this.panelContainer.Controls.Add(this.Des_Appointment_txt);
            this.panelContainer.Controls.Add(this.DesBackGround);
            this.panelContainer.Controls.Add(this.Id_Appointment_txt);
            this.panelContainer.Controls.Add(this.IdBackGround);
            this.panelContainer.Controls.Add(this.Second_Appointment_txt);
            this.panelContainer.Controls.Add(this.pictureLastBackground);
            this.panelContainer.Controls.Add(this.First_Appointment_txt);
            this.panelContainer.Controls.Add(this.pictureFirstBackground);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(188, 93);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(420, 476);
            this.panelContainer.TabIndex = 3;
            // 
            // AddReport_btn
            // 
            this.AddReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddReport_btn.FlatAppearance.BorderSize = 0;
            this.AddReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReport_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddReport_btn.ForeColor = System.Drawing.Color.White;
            this.AddReport_btn.Location = new System.Drawing.Point(71, 423);
            this.AddReport_btn.Name = "AddReport_btn";
            this.AddReport_btn.Size = new System.Drawing.Size(248, 35);
            this.AddReport_btn.TabIndex = 28;
            this.AddReport_btn.Text = "Add Appointment";
            this.AddReport_btn.UseVisualStyleBackColor = false;
            // 
            // Des_Appointment_txt
            // 
            this.Des_Appointment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Des_Appointment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Des_Appointment_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Des_Appointment_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Des_Appointment_txt.Location = new System.Drawing.Point(100, 290);
            this.Des_Appointment_txt.Multiline = true;
            this.Des_Appointment_txt.Name = "Des_Appointment_txt";
            this.Des_Appointment_txt.PasswordChar = '*';
            this.Des_Appointment_txt.Size = new System.Drawing.Size(205, 37);
            this.Des_Appointment_txt.TabIndex = 20;
            this.Des_Appointment_txt.Text = "Description";
            this.Des_Appointment_txt.UseSystemPasswordChar = true;
            this.Des_Appointment_txt.Enter += new System.EventHandler(this.Des_Appointment_txt_Enter);
            this.Des_Appointment_txt.Leave += new System.EventHandler(this.Des_Appointment_txt_Leave);
            // 
            // DesBackGround
            // 
            this.DesBackGround.BackColor = System.Drawing.Color.Transparent;
            this.DesBackGround.Image = ((System.Drawing.Image)(resources.GetObject("DesBackGround.Image")));
            this.DesBackGround.Location = new System.Drawing.Point(83, 278);
            this.DesBackGround.Name = "DesBackGround";
            this.DesBackGround.Size = new System.Drawing.Size(243, 67);
            this.DesBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DesBackGround.TabIndex = 18;
            this.DesBackGround.TabStop = false;
            // 
            // Id_Appointment_txt
            // 
            this.Id_Appointment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Id_Appointment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Appointment_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id_Appointment_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Id_Appointment_txt.Location = new System.Drawing.Point(100, 218);
            this.Id_Appointment_txt.Multiline = true;
            this.Id_Appointment_txt.Name = "Id_Appointment_txt";
            this.Id_Appointment_txt.PasswordChar = '*';
            this.Id_Appointment_txt.Size = new System.Drawing.Size(205, 25);
            this.Id_Appointment_txt.TabIndex = 17;
            this.Id_Appointment_txt.Text = "National Id";
            this.Id_Appointment_txt.UseSystemPasswordChar = true;
            this.Id_Appointment_txt.Enter += new System.EventHandler(this.Id_Appointment_txt_Enter);
            this.Id_Appointment_txt.Leave += new System.EventHandler(this.Id_Appointment_txt_Leave);
            // 
            // IdBackGround
            // 
            this.IdBackGround.BackColor = System.Drawing.Color.Transparent;
            this.IdBackGround.Image = ((System.Drawing.Image)(resources.GetObject("IdBackGround.Image")));
            this.IdBackGround.Location = new System.Drawing.Point(83, 206);
            this.IdBackGround.Name = "IdBackGround";
            this.IdBackGround.Size = new System.Drawing.Size(243, 45);
            this.IdBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IdBackGround.TabIndex = 15;
            this.IdBackGround.TabStop = false;
            // 
            // AppointmentForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm1";
            this.Text = "AppointmentForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstBackground)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Second_Appointment_txt;
        private System.Windows.Forms.PictureBox pictureLastBackground;
        private System.Windows.Forms.TextBox First_Appointment_txt;
        private System.Windows.Forms.PictureBox pictureFirstBackground;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox Des_Appointment_txt;
        private System.Windows.Forms.PictureBox DesBackGround;
        private System.Windows.Forms.TextBox Id_Appointment_txt;
        private System.Windows.Forms.PictureBox IdBackGround;
        private System.Windows.Forms.Button AddReport_btn;
    }
}