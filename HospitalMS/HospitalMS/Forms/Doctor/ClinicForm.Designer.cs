
namespace HospitalMS
{
    partial class ClinicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.OneClinic_panel = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.picFromBackground = new System.Windows.Forms.PictureBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.FloorNumber_txt = new System.Windows.Forms.TextBox();
            this.FloorBackGround = new System.Windows.Forms.PictureBox();
            this.ClinicName_txt = new System.Windows.Forms.TextBox();
            this.IdBackGround = new System.Windows.Forms.PictureBox();
            this.AllClinics_Data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllClinics_Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.OneClinic_Radio = new System.Windows.Forms.RadioButton();
            this.lblClinic = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.OneClinic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFromBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllClinics_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.OneClinic_panel);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Location = new System.Drawing.Point(150, 100);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(412, 422);
            this.panelContainer.TabIndex = 0;
            // 
            // OneClinic_panel
            // 
            this.OneClinic_panel.Controls.Add(this.txtTo);
            this.OneClinic_panel.Controls.Add(this.pictureBox1);
            this.OneClinic_panel.Controls.Add(this.txtFrom);
            this.OneClinic_panel.Controls.Add(this.picFromBackground);
            this.OneClinic_panel.Controls.Add(this.lblWorkingHours);
            this.OneClinic_panel.Controls.Add(this.lblTo);
            this.OneClinic_panel.Controls.Add(this.lblFrom);
            this.OneClinic_panel.Controls.Add(this.FloorNumber_txt);
            this.OneClinic_panel.Controls.Add(this.FloorBackGround);
            this.OneClinic_panel.Controls.Add(this.ClinicName_txt);
            this.OneClinic_panel.Controls.Add(this.IdBackGround);
            this.OneClinic_panel.Controls.Add(this.AllClinics_Data);
            this.OneClinic_panel.Location = new System.Drawing.Point(28, 138);
            this.OneClinic_panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.OneClinic_panel.Name = "OneClinic_panel";
            this.OneClinic_panel.Size = new System.Drawing.Size(354, 268);
            this.OneClinic_panel.TabIndex = 12;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTo.Location = new System.Drawing.Point(204, 223);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '*';
            this.txtTo.Size = new System.Drawing.Size(111, 18);
            this.txtTo.TabIndex = 36;
            this.txtTo.Text = "08:00 PM";
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTo.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFrom.Location = new System.Drawing.Point(31, 223);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '*';
            this.txtFrom.Size = new System.Drawing.Size(114, 18);
            this.txtFrom.TabIndex = 34;
            this.txtFrom.Text = "12:00 PM";
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrom.UseSystemPasswordChar = true;
            // 
            // picFromBackground
            // 
            this.picFromBackground.BackColor = System.Drawing.Color.Transparent;
            this.picFromBackground.Image = ((System.Drawing.Image)(resources.GetObject("picFromBackground.Image")));
            this.picFromBackground.Location = new System.Drawing.Point(16, 215);
            this.picFromBackground.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picFromBackground.Name = "picFromBackground";
            this.picFromBackground.Size = new System.Drawing.Size(150, 33);
            this.picFromBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFromBackground.TabIndex = 33;
            this.picFromBackground.TabStop = false;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkingHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkingHours.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblWorkingHours.ForeColor = System.Drawing.Color.White;
            this.lblWorkingHours.Location = new System.Drawing.Point(93, 133);
            this.lblWorkingHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(190, 37);
            this.lblWorkingHours.TabIndex = 32;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTo.Location = new System.Drawing.Point(190, 183);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 29);
            this.lblTo.TabIndex = 31;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFrom.Location = new System.Drawing.Point(15, 183);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(62, 29);
            this.lblFrom.TabIndex = 30;
            this.lblFrom.Text = "From";
            // 
            // FloorNumber_txt
            // 
            this.FloorNumber_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.FloorNumber_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FloorNumber_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FloorNumber_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FloorNumber_txt.Location = new System.Drawing.Point(77, 82);
            this.FloorNumber_txt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FloorNumber_txt.Multiline = true;
            this.FloorNumber_txt.Name = "FloorNumber_txt";
            this.FloorNumber_txt.PasswordChar = '*';
            this.FloorNumber_txt.Size = new System.Drawing.Size(178, 18);
            this.FloorNumber_txt.TabIndex = 25;
            this.FloorNumber_txt.Text = "Floor Number";
            this.FloorNumber_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FloorNumber_txt.UseSystemPasswordChar = true;
            this.FloorNumber_txt.Enter += new System.EventHandler(this.FloorNumber_txt_Enter);
            this.FloorNumber_txt.Leave += new System.EventHandler(this.FloorNumber_txt_Leave);
            // 
            // FloorBackGround
            // 
            this.FloorBackGround.BackColor = System.Drawing.Color.Transparent;
            this.FloorBackGround.Image = ((System.Drawing.Image)(resources.GetObject("FloorBackGround.Image")));
            this.FloorBackGround.Location = new System.Drawing.Point(62, 73);
            this.FloorBackGround.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FloorBackGround.Name = "FloorBackGround";
            this.FloorBackGround.Size = new System.Drawing.Size(214, 33);
            this.FloorBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FloorBackGround.TabIndex = 24;
            this.FloorBackGround.TabStop = false;
            // 
            // ClinicName_txt
            // 
            this.ClinicName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.ClinicName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClinicName_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ClinicName_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClinicName_txt.Location = new System.Drawing.Point(77, 31);
            this.ClinicName_txt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ClinicName_txt.Multiline = true;
            this.ClinicName_txt.Name = "ClinicName_txt";
            this.ClinicName_txt.PasswordChar = '*';
            this.ClinicName_txt.Size = new System.Drawing.Size(178, 18);
            this.ClinicName_txt.TabIndex = 23;
            this.ClinicName_txt.Text = "Clinic Name";
            this.ClinicName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClinicName_txt.UseSystemPasswordChar = true;
            this.ClinicName_txt.Enter += new System.EventHandler(this.ClinicName_txt_Enter);
            this.ClinicName_txt.Leave += new System.EventHandler(this.ClinicName_txt_Leave);
            // 
            // IdBackGround
            // 
            this.IdBackGround.BackColor = System.Drawing.Color.Transparent;
            this.IdBackGround.Image = ((System.Drawing.Image)(resources.GetObject("IdBackGround.Image")));
            this.IdBackGround.Location = new System.Drawing.Point(62, 22);
            this.IdBackGround.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IdBackGround.Name = "IdBackGround";
            this.IdBackGround.Size = new System.Drawing.Size(214, 33);
            this.IdBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IdBackGround.TabIndex = 22;
            this.IdBackGround.TabStop = false;
            // 
            // AllClinics_Data
            // 
            this.AllClinics_Data.BackgroundColor = System.Drawing.Color.White;
            this.AllClinics_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClinics_Data.Location = new System.Drawing.Point(4, 11);
            this.AllClinics_Data.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AllClinics_Data.Name = "AllClinics_Data";
            this.AllClinics_Data.RowHeadersWidth = 51;
            this.AllClinics_Data.RowTemplate.Height = 29;
            this.AllClinics_Data.Size = new System.Drawing.Size(346, 255);
            this.AllClinics_Data.TabIndex = 37;
            this.AllClinics_Data.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllClinics_Radio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OneClinic_Radio);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // AllClinics_Radio
            // 
            this.AllClinics_Radio.AutoSize = true;
            this.AllClinics_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllClinics_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AllClinics_Radio.ForeColor = System.Drawing.Color.White;
            this.AllClinics_Radio.Location = new System.Drawing.Point(177, 57);
            this.AllClinics_Radio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AllClinics_Radio.Name = "AllClinics_Radio";
            this.AllClinics_Radio.Size = new System.Drawing.Size(178, 29);
            this.AllClinics_Radio.TabIndex = 8;
            this.AllClinics_Radio.Text = "Display All Clinics";
            this.AllClinics_Radio.UseVisualStyleBackColor = true;
            this.AllClinics_Radio.CheckedChanged += new System.EventHandler(this.AllClinics_Radio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select what do you want to show";
            // 
            // OneClinic_Radio
            // 
            this.OneClinic_Radio.AutoSize = true;
            this.OneClinic_Radio.Checked = true;
            this.OneClinic_Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OneClinic_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OneClinic_Radio.ForeColor = System.Drawing.Color.White;
            this.OneClinic_Radio.Location = new System.Drawing.Point(50, 57);
            this.OneClinic_Radio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.OneClinic_Radio.Name = "OneClinic_Radio";
            this.OneClinic_Radio.Size = new System.Drawing.Size(108, 29);
            this.OneClinic_Radio.TabIndex = 9;
            this.OneClinic_Radio.TabStop = true;
            this.OneClinic_Radio.Text = "My Clinic";
            this.OneClinic_Radio.UseVisualStyleBackColor = true;
            // 
            // lblClinic
            // 
            this.lblClinic.AutoSize = true;
            this.lblClinic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClinic.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClinic.ForeColor = System.Drawing.Color.Crimson;
            this.lblClinic.Location = new System.Drawing.Point(260, 20);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(256, 50);
            this.lblClinic.TabIndex = 17;
            this.lblClinic.Text = "Display Clinics";
            // 
            // ClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.lblClinic);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "ClinicForm";
            this.Text = "ClinicForm";
            this.Load += new System.EventHandler(this.ClinicForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.OneClinic_panel.ResumeLayout(false);
            this.OneClinic_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFromBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllClinics_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllClinics_Radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OneClinic_Radio;
        private System.Windows.Forms.Panel OneClinic_panel;
        private System.Windows.Forms.TextBox ClinicName_txt;
        private System.Windows.Forms.PictureBox IdBackGround;
        private System.Windows.Forms.TextBox FloorNumber_txt;
        private System.Windows.Forms.PictureBox FloorBackGround;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.PictureBox picFromBackground;
        private System.Windows.Forms.DataGridView AllClinics_Data;
        private System.Windows.Forms.Label lblClinic;
    }
}