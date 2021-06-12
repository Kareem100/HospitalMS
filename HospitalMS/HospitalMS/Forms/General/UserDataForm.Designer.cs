
namespace HospitalMS.Forms
{
    partial class UserDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataForm));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.picFirstnameBackground = new System.Windows.Forms.PictureBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.picLastnameBackground = new System.Windows.Forms.PictureBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblMyData = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMyAge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupSpecialization = new System.Windows.Forms.GroupBox();
            this.comboClinics = new System.Windows.Forms.ComboBox();
            this.lblYearOfEmplyment = new System.Windows.Forms.Label();
            this.lblShiftStarts = new System.Windows.Forms.Label();
            this.lblShiftEnds = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPhones = new System.Windows.Forms.TextBox();
            this.dateShiftEnding = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.dateShiftStarting = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.dateEmploymentYear = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.dateBirthdate = new HospitalMS.Custom_Controls.CustomDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstnameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastnameBackground)).BeginInit();
            this.groupGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupSpecialization.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(46, 105);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 24);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // picFirstnameBackground
            // 
            this.picFirstnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picFirstnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picFirstnameBackground.Image")));
            this.picFirstnameBackground.Location = new System.Drawing.Point(30, 93);
            this.picFirstnameBackground.Name = "picFirstnameBackground";
            this.picFirstnameBackground.Size = new System.Drawing.Size(198, 45);
            this.picFirstnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirstnameBackground.TabIndex = 8;
            this.picFirstnameBackground.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(361, 105);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 24);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // picLastnameBackground
            // 
            this.picLastnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picLastnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picLastnameBackground.Image")));
            this.picLastnameBackground.Location = new System.Drawing.Point(345, 93);
            this.picLastnameBackground.Name = "picLastnameBackground";
            this.picLastnameBackground.Size = new System.Drawing.Size(198, 45);
            this.picLastnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLastnameBackground.TabIndex = 10;
            this.picLastnameBackground.TabStop = false;
            // 
            // groupGender
            // 
            this.groupGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupGender.Controls.Add(this.radioFemale);
            this.groupGender.Controls.Add(this.radioMale);
            this.groupGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupGender.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupGender.Location = new System.Drawing.Point(30, 160);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(198, 92);
            this.groupGender.TabIndex = 2;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioFemale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioFemale.Location = new System.Drawing.Point(22, 60);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(90, 29);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = false;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.Color.Transparent;
            this.radioMale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioMale.Location = new System.Drawing.Point(22, 27);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(72, 29);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = false;
            // 
            // lblMyData
            // 
            this.lblMyData.AutoSize = true;
            this.lblMyData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyData.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMyData.ForeColor = System.Drawing.Color.Crimson;
            this.lblMyData.Location = new System.Drawing.Point(223, 26);
            this.lblMyData.Name = "lblMyData";
            this.lblMyData.Size = new System.Drawing.Size(165, 50);
            this.lblMyData.TabIndex = 14;
            this.lblMyData.Text = "My Data";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(345, 160);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(106, 29);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(348, 225);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(68, 29);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age: ";
            // 
            // lblMyAge
            // 
            this.lblMyAge.AutoSize = true;
            this.lblMyAge.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMyAge.ForeColor = System.Drawing.Color.Crimson;
            this.lblMyAge.Location = new System.Drawing.Point(408, 225);
            this.lblMyAge.Name = "lblMyAge";
            this.lblMyAge.Size = new System.Drawing.Size(37, 29);
            this.lblMyAge.TabIndex = 18;
            this.lblMyAge.Text = "45";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupSpecialization
            // 
            this.groupSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupSpecialization.Controls.Add(this.comboClinics);
            this.groupSpecialization.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupSpecialization.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupSpecialization.Location = new System.Drawing.Point(30, 272);
            this.groupSpecialization.Name = "groupSpecialization";
            this.groupSpecialization.Size = new System.Drawing.Size(198, 92);
            this.groupSpecialization.TabIndex = 4;
            this.groupSpecialization.TabStop = false;
            this.groupSpecialization.Text = "Specialiszation";
            // 
            // comboClinics
            // 
            this.comboClinics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.comboClinics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClinics.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboClinics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboClinics.FormattingEnabled = true;
            this.comboClinics.Location = new System.Drawing.Point(16, 45);
            this.comboClinics.Name = "comboClinics";
            this.comboClinics.Size = new System.Drawing.Size(149, 31);
            this.comboClinics.TabIndex = 5;
            // 
            // lblYearOfEmplyment
            // 
            this.lblYearOfEmplyment.AutoSize = true;
            this.lblYearOfEmplyment.Location = new System.Drawing.Point(346, 272);
            this.lblYearOfEmplyment.Name = "lblYearOfEmplyment";
            this.lblYearOfEmplyment.Size = new System.Drawing.Size(209, 29);
            this.lblYearOfEmplyment.TabIndex = 24;
            this.lblYearOfEmplyment.Text = "Year of Employment";
            // 
            // lblShiftStarts
            // 
            this.lblShiftStarts.AutoSize = true;
            this.lblShiftStarts.Location = new System.Drawing.Point(348, 348);
            this.lblShiftStarts.Name = "lblShiftStarts";
            this.lblShiftStarts.Size = new System.Drawing.Size(203, 29);
            this.lblShiftStarts.TabIndex = 25;
            this.lblShiftStarts.Text = "Shitft Starts From";
            // 
            // lblShiftEnds
            // 
            this.lblShiftEnds.AutoSize = true;
            this.lblShiftEnds.Location = new System.Drawing.Point(348, 428);
            this.lblShiftEnds.Name = "lblShiftEnds";
            this.lblShiftEnds.Size = new System.Drawing.Size(156, 29);
            this.lblShiftEnds.TabIndex = 27;
            this.lblShiftEnds.Text = "Shitft Ends In";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(187, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update My Data";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPhones
            // 
            this.txtPhones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtPhones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPhones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhones.Location = new System.Drawing.Point(46, 401);
            this.txtPhones.Multiline = true;
            this.txtPhones.Name = "txtPhones";
            this.txtPhones.Size = new System.Drawing.Size(169, 73);
            this.txtPhones.TabIndex = 6;
            this.txtPhones.Text = "Phones";
            this.txtPhones.Enter += new System.EventHandler(this.txtPhones_Enter);
            this.txtPhones.Leave += new System.EventHandler(this.txtPhones_Leave);
            // 
            // dateShiftEnding
            // 
            this.dateShiftEnding.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateShiftEnding.BorderSize = 0;
            this.dateShiftEnding.CustomFormat = "hh:mm tt";
            this.dateShiftEnding.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateShiftEnding.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateShiftEnding.Location = new System.Drawing.Point(348, 453);
            this.dateShiftEnding.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateShiftEnding.Name = "dateShiftEnding";
            this.dateShiftEnding.ShowUpDown = true;
            this.dateShiftEnding.Size = new System.Drawing.Size(198, 35);
            this.dateShiftEnding.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateShiftEnding.TabIndex = 8;
            this.dateShiftEnding.TextColor = System.Drawing.Color.White;
            this.dateShiftEnding.Value = new System.DateTime(2021, 6, 3, 18, 0, 0, 0);
            // 
            // dateShiftStarting
            // 
            this.dateShiftStarting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateShiftStarting.BorderSize = 0;
            this.dateShiftStarting.CustomFormat = "hh:mm tt";
            this.dateShiftStarting.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateShiftStarting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateShiftStarting.Location = new System.Drawing.Point(348, 373);
            this.dateShiftStarting.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateShiftStarting.Name = "dateShiftStarting";
            this.dateShiftStarting.ShowUpDown = true;
            this.dateShiftStarting.Size = new System.Drawing.Size(198, 35);
            this.dateShiftStarting.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateShiftStarting.TabIndex = 7;
            this.dateShiftStarting.TextColor = System.Drawing.Color.White;
            this.dateShiftStarting.Value = new System.DateTime(2021, 6, 10, 10, 0, 0, 0);
            // 
            // dateEmploymentYear
            // 
            this.dateEmploymentYear.BorderColor = System.Drawing.Color.DarkOrange;
            this.dateEmploymentYear.BorderSize = 1;
            this.dateEmploymentYear.CustomFormat = "yyyy";
            this.dateEmploymentYear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateEmploymentYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEmploymentYear.Location = new System.Drawing.Point(345, 299);
            this.dateEmploymentYear.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateEmploymentYear.Name = "dateEmploymentYear";
            this.dateEmploymentYear.ShowUpDown = true;
            this.dateEmploymentYear.Size = new System.Drawing.Size(198, 35);
            this.dateEmploymentYear.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateEmploymentYear.TabIndex = 5;
            this.dateEmploymentYear.TextColor = System.Drawing.Color.White;
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateBirthdate.BorderSize = 0;
            this.dateBirthdate.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateBirthdate.Location = new System.Drawing.Point(345, 185);
            this.dateBirthdate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(198, 35);
            this.dateBirthdate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateBirthdate.TabIndex = 3;
            this.dateBirthdate.TextColor = System.Drawing.Color.White;
            this.dateBirthdate.ValueChanged += new System.EventHandler(this.dateBirthdate_ValueChanged);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.txtPhones);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateShiftEnding);
            this.Controls.Add(this.lblShiftEnds);
            this.Controls.Add(this.dateShiftStarting);
            this.Controls.Add(this.lblShiftStarts);
            this.Controls.Add(this.lblYearOfEmplyment);
            this.Controls.Add(this.groupSpecialization);
            this.Controls.Add(this.dateEmploymentYear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMyAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dateBirthdate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblMyData);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.picLastnameBackground);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.picFirstnameBackground);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDataForm_FormClosing);
            this.Load += new System.EventHandler(this.UserDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFirstnameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastnameBackground)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupSpecialization.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox picFirstnameBackground;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox picLastnameBackground;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblMyData;
        private System.Windows.Forms.Label lblBirthdate;
        private Custom_Controls.CustomDatePicker dateBirthdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMyAge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom_Controls.CustomDatePicker dateEmploymentYear;
        private System.Windows.Forms.GroupBox groupSpecialization;
        private System.Windows.Forms.Label lblYearOfEmplyment;
        private Custom_Controls.CustomDatePicker dateShiftStarting;
        private System.Windows.Forms.Label lblShiftStarts;
        private Custom_Controls.CustomDatePicker dateShiftEnding;
        private System.Windows.Forms.Label lblShiftEnds;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPhones;
        private System.Windows.Forms.ComboBox comboClinics;
    }
}