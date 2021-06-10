
namespace HospitalMS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureConfirmPasswordIcon = new System.Windows.Forms.PictureBox();
            this.pictureConfirmPasswordBackground = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.picturePhoneIcon = new System.Windows.Forms.PictureBox();
            this.picturePhoneBackground = new System.Windows.Forms.PictureBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.groupSpecialization = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.comboClinics = new System.Windows.Forms.ComboBox();
            this.radioReceptionist = new System.Windows.Forms.RadioButton();
            this.radioDoctor = new System.Windows.Forms.RadioButton();
            this.dateEmploymentYear = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.dateBirthdate = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.lblEmploymentYear = new System.Windows.Forms.Label();
            this.pictureEmploymentIcon = new System.Windows.Forms.PictureBox();
            this.pictureEmploymentBackground = new System.Windows.Forms.PictureBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.pictureBirthdateIcon = new System.Windows.Forms.PictureBox();
            this.pictureBirthdateBackground = new System.Windows.Forms.PictureBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pictureLastnameIcon = new System.Windows.Forms.PictureBox();
            this.pictureLastnameBackground = new System.Windows.Forms.PictureBox();
            this.lblHere = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAlreadyRegistered = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picturePasswordIcon = new System.Windows.Forms.PictureBox();
            this.picturePasswordBackground = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pictureFirstnameIcon = new System.Windows.Forms.PictureBox();
            this.pictureFirstnameBackground = new System.Windows.Forms.PictureBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblOspital = new System.Windows.Forms.Label();
            this.lblManagementSystem = new System.Windows.Forms.Label();
            this.txtToBeFocused = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPasswordBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneBackground)).BeginInit();
            this.groupGender.SuspendLayout();
            this.groupSpecialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmploymentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmploymentBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdateIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdateBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastnameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastnameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstnameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstnameBackground)).BeginInit();
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
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.txtNationalID);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Controls.Add(this.txtConfirmPassword);
            this.panelContainer.Controls.Add(this.pictureConfirmPasswordIcon);
            this.panelContainer.Controls.Add(this.pictureConfirmPasswordBackground);
            this.panelContainer.Controls.Add(this.txtPhone);
            this.panelContainer.Controls.Add(this.picturePhoneIcon);
            this.panelContainer.Controls.Add(this.picturePhoneBackground);
            this.panelContainer.Controls.Add(this.groupGender);
            this.panelContainer.Controls.Add(this.groupSpecialization);
            this.panelContainer.Controls.Add(this.dateEmploymentYear);
            this.panelContainer.Controls.Add(this.dateBirthdate);
            this.panelContainer.Controls.Add(this.lblEmploymentYear);
            this.panelContainer.Controls.Add(this.pictureEmploymentIcon);
            this.panelContainer.Controls.Add(this.pictureEmploymentBackground);
            this.panelContainer.Controls.Add(this.lblBirthdate);
            this.panelContainer.Controls.Add(this.pictureBirthdateIcon);
            this.panelContainer.Controls.Add(this.pictureBirthdateBackground);
            this.panelContainer.Controls.Add(this.txtLastName);
            this.panelContainer.Controls.Add(this.pictureLastnameIcon);
            this.panelContainer.Controls.Add(this.pictureLastnameBackground);
            this.panelContainer.Controls.Add(this.lblHere);
            this.panelContainer.Controls.Add(this.lblLogin);
            this.panelContainer.Controls.Add(this.lblAlreadyRegistered);
            this.panelContainer.Controls.Add(this.btnRegister);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Controls.Add(this.picturePasswordIcon);
            this.panelContainer.Controls.Add(this.picturePasswordBackground);
            this.panelContainer.Controls.Add(this.txtFirstName);
            this.panelContainer.Controls.Add(this.pictureFirstnameIcon);
            this.panelContainer.Controls.Add(this.pictureFirstnameBackground);
            this.panelContainer.Controls.Add(this.lblH);
            this.panelContainer.Controls.Add(this.lblOspital);
            this.panelContainer.Controls.Add(this.lblManagementSystem);
            this.panelContainer.Controls.Add(this.txtToBeFocused);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(190, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(420, 538);
            this.panelContainer.TabIndex = 2;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNationalID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNationalID.Location = new System.Drawing.Point(260, 363);
            this.txtNationalID.MaxLength = 14;
            this.txtNationalID.Multiline = true;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(131, 24);
            this.txtNationalID.TabIndex = 8;
            this.txtNationalID.Text = "National ID";
            this.txtNationalID.Enter += new System.EventHandler(this.txtNationalID_Enter);
            this.txtNationalID.Leave += new System.EventHandler(this.txtNationalID_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.Location = new System.Drawing.Point(260, 420);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(131, 25);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // pictureConfirmPasswordIcon
            // 
            this.pictureConfirmPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureConfirmPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureConfirmPasswordIcon.Image")));
            this.pictureConfirmPasswordIcon.Location = new System.Drawing.Point(232, 416);
            this.pictureConfirmPasswordIcon.Name = "pictureConfirmPasswordIcon";
            this.pictureConfirmPasswordIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureConfirmPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureConfirmPasswordIcon.TabIndex = 32;
            this.pictureConfirmPasswordIcon.TabStop = false;
            // 
            // pictureConfirmPasswordBackground
            // 
            this.pictureConfirmPasswordBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureConfirmPasswordBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureConfirmPasswordBackground.Image")));
            this.pictureConfirmPasswordBackground.Location = new System.Drawing.Point(222, 408);
            this.pictureConfirmPasswordBackground.Name = "pictureConfirmPasswordBackground";
            this.pictureConfirmPasswordBackground.Size = new System.Drawing.Size(176, 45);
            this.pictureConfirmPasswordBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureConfirmPasswordBackground.TabIndex = 31;
            this.pictureConfirmPasswordBackground.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.Location = new System.Drawing.Point(66, 367);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(131, 24);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "Phone Number";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // picturePhoneIcon
            // 
            this.picturePhoneIcon.BackColor = System.Drawing.Color.Transparent;
            this.picturePhoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("picturePhoneIcon.Image")));
            this.picturePhoneIcon.Location = new System.Drawing.Point(38, 363);
            this.picturePhoneIcon.Name = "picturePhoneIcon";
            this.picturePhoneIcon.Size = new System.Drawing.Size(28, 28);
            this.picturePhoneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePhoneIcon.TabIndex = 29;
            this.picturePhoneIcon.TabStop = false;
            // 
            // picturePhoneBackground
            // 
            this.picturePhoneBackground.BackColor = System.Drawing.Color.Transparent;
            this.picturePhoneBackground.Image = ((System.Drawing.Image)(resources.GetObject("picturePhoneBackground.Image")));
            this.picturePhoneBackground.Location = new System.Drawing.Point(28, 355);
            this.picturePhoneBackground.Name = "picturePhoneBackground";
            this.picturePhoneBackground.Size = new System.Drawing.Size(176, 45);
            this.picturePhoneBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePhoneBackground.TabIndex = 28;
            this.picturePhoneBackground.TabStop = false;
            // 
            // groupGender
            // 
            this.groupGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupGender.Controls.Add(this.radioFemale);
            this.groupGender.Controls.Add(this.radioMale);
            this.groupGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupGender.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupGender.Location = new System.Drawing.Point(222, 230);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(176, 112);
            this.groupGender.TabIndex = 6;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFemale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioFemale.Location = new System.Drawing.Point(22, 65);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(70, 23);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = false;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.Color.Transparent;
            this.radioMale.Checked = true;
            this.radioMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioMale.Location = new System.Drawing.Point(22, 32);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(56, 23);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = false;
            // 
            // groupSpecialization
            // 
            this.groupSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupSpecialization.Controls.Add(this.lblX);
            this.groupSpecialization.Controls.Add(this.comboClinics);
            this.groupSpecialization.Controls.Add(this.radioReceptionist);
            this.groupSpecialization.Controls.Add(this.radioDoctor);
            this.groupSpecialization.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupSpecialization.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupSpecialization.Location = new System.Drawing.Point(28, 230);
            this.groupSpecialization.Name = "groupSpecialization";
            this.groupSpecialization.Size = new System.Drawing.Size(176, 112);
            this.groupSpecialization.TabIndex = 5;
            this.groupSpecialization.TabStop = false;
            this.groupSpecialization.Text = "Specialization";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Location = new System.Drawing.Point(147, 33);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 23);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // comboClinics
            // 
            this.comboClinics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.comboClinics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClinics.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboClinics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboClinics.FormattingEnabled = true;
            this.comboClinics.Location = new System.Drawing.Point(22, 64);
            this.comboClinics.Name = "comboClinics";
            this.comboClinics.Size = new System.Drawing.Size(149, 27);
            this.comboClinics.TabIndex = 4;
            this.comboClinics.Visible = false;
            // 
            // radioReceptionist
            // 
            this.radioReceptionist.AutoSize = true;
            this.radioReceptionist.BackColor = System.Drawing.Color.Transparent;
            this.radioReceptionist.Checked = true;
            this.radioReceptionist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioReceptionist.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioReceptionist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioReceptionist.Location = new System.Drawing.Point(22, 65);
            this.radioReceptionist.Name = "radioReceptionist";
            this.radioReceptionist.Size = new System.Drawing.Size(103, 23);
            this.radioReceptionist.TabIndex = 1;
            this.radioReceptionist.TabStop = true;
            this.radioReceptionist.Text = "Receptionist";
            this.radioReceptionist.UseVisualStyleBackColor = false;
            // 
            // radioDoctor
            // 
            this.radioDoctor.AutoSize = true;
            this.radioDoctor.BackColor = System.Drawing.Color.Transparent;
            this.radioDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDoctor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioDoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioDoctor.Location = new System.Drawing.Point(22, 32);
            this.radioDoctor.Name = "radioDoctor";
            this.radioDoctor.Size = new System.Drawing.Size(69, 23);
            this.radioDoctor.TabIndex = 0;
            this.radioDoctor.Text = "Doctor";
            this.radioDoctor.UseVisualStyleBackColor = false;
            this.radioDoctor.CheckedChanged += new System.EventHandler(this.radioDoctor_CheckedChanged);
            // 
            // dateEmploymentYear
            // 
            this.dateEmploymentYear.BorderColor = System.Drawing.Color.DarkOrange;
            this.dateEmploymentYear.BorderSize = 1;
            this.dateEmploymentYear.CustomFormat = "yyyy";
            this.dateEmploymentYear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateEmploymentYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEmploymentYear.Location = new System.Drawing.Point(222, 185);
            this.dateEmploymentYear.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateEmploymentYear.Name = "dateEmploymentYear";
            this.dateEmploymentYear.ShowUpDown = true;
            this.dateEmploymentYear.Size = new System.Drawing.Size(176, 35);
            this.dateEmploymentYear.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateEmploymentYear.TabIndex = 4;
            this.dateEmploymentYear.TextColor = System.Drawing.Color.White;
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateBirthdate.BorderSize = 0;
            this.dateBirthdate.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateBirthdate.Location = new System.Drawing.Point(28, 185);
            this.dateBirthdate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(176, 35);
            this.dateBirthdate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateBirthdate.TabIndex = 3;
            this.dateBirthdate.TextColor = System.Drawing.Color.White;
            // 
            // lblEmploymentYear
            // 
            this.lblEmploymentYear.AutoSize = true;
            this.lblEmploymentYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.lblEmploymentYear.Location = new System.Drawing.Point(260, 148);
            this.lblEmploymentYear.Name = "lblEmploymentYear";
            this.lblEmploymentYear.Size = new System.Drawing.Size(116, 19);
            this.lblEmploymentYear.TabIndex = 23;
            this.lblEmploymentYear.Text = "Employment Year";
            // 
            // pictureEmploymentIcon
            // 
            this.pictureEmploymentIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureEmploymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureEmploymentIcon.Image")));
            this.pictureEmploymentIcon.Location = new System.Drawing.Point(232, 143);
            this.pictureEmploymentIcon.Name = "pictureEmploymentIcon";
            this.pictureEmploymentIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureEmploymentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEmploymentIcon.TabIndex = 22;
            this.pictureEmploymentIcon.TabStop = false;
            // 
            // pictureEmploymentBackground
            // 
            this.pictureEmploymentBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureEmploymentBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureEmploymentBackground.Image")));
            this.pictureEmploymentBackground.Location = new System.Drawing.Point(222, 135);
            this.pictureEmploymentBackground.Name = "pictureEmploymentBackground";
            this.pictureEmploymentBackground.Size = new System.Drawing.Size(176, 45);
            this.pictureEmploymentBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEmploymentBackground.TabIndex = 21;
            this.pictureEmploymentBackground.TabStop = false;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.lblBirthdate.Location = new System.Drawing.Point(66, 148);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(69, 19);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // pictureBirthdateIcon
            // 
            this.pictureBirthdateIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBirthdateIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBirthdateIcon.Image")));
            this.pictureBirthdateIcon.Location = new System.Drawing.Point(38, 143);
            this.pictureBirthdateIcon.Name = "pictureBirthdateIcon";
            this.pictureBirthdateIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureBirthdateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBirthdateIcon.TabIndex = 19;
            this.pictureBirthdateIcon.TabStop = false;
            // 
            // pictureBirthdateBackground
            // 
            this.pictureBirthdateBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureBirthdateBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBirthdateBackground.Image")));
            this.pictureBirthdateBackground.Location = new System.Drawing.Point(28, 135);
            this.pictureBirthdateBackground.Name = "pictureBirthdateBackground";
            this.pictureBirthdateBackground.Size = new System.Drawing.Size(176, 45);
            this.pictureBirthdateBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBirthdateBackground.TabIndex = 18;
            this.pictureBirthdateBackground.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(260, 85);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 24);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // pictureLastnameIcon
            // 
            this.pictureLastnameIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureLastnameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureLastnameIcon.Image")));
            this.pictureLastnameIcon.Location = new System.Drawing.Point(232, 81);
            this.pictureLastnameIcon.Name = "pictureLastnameIcon";
            this.pictureLastnameIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureLastnameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLastnameIcon.TabIndex = 16;
            this.pictureLastnameIcon.TabStop = false;
            // 
            // pictureLastnameBackground
            // 
            this.pictureLastnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureLastnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureLastnameBackground.Image")));
            this.pictureLastnameBackground.Location = new System.Drawing.Point(222, 73);
            this.pictureLastnameBackground.Name = "pictureLastnameBackground";
            this.pictureLastnameBackground.Size = new System.Drawing.Size(176, 45);
            this.pictureLastnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLastnameBackground.TabIndex = 15;
            this.pictureLastnameBackground.TabStop = false;
            // 
            // lblHere
            // 
            this.lblHere.AutoSize = true;
            this.lblHere.BackColor = System.Drawing.Color.Transparent;
            this.lblHere.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblHere.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHere.Location = new System.Drawing.Point(278, 512);
            this.lblHere.Name = "lblHere";
            this.lblHere.Size = new System.Drawing.Size(39, 19);
            this.lblHere.TabIndex = 14;
            this.lblHere.Text = "Here";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLogin.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLogin.Location = new System.Drawing.Point(241, 512);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 19);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblAlreadyRegistered
            // 
            this.lblAlreadyRegistered.AutoSize = true;
            this.lblAlreadyRegistered.BackColor = System.Drawing.Color.Transparent;
            this.lblAlreadyRegistered.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblAlreadyRegistered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAlreadyRegistered.Location = new System.Drawing.Point(117, 512);
            this.lblAlreadyRegistered.Name = "lblAlreadyRegistered";
            this.lblAlreadyRegistered.Size = new System.Drawing.Size(139, 19);
            this.lblAlreadyRegistered.TabIndex = 12;
            this.lblAlreadyRegistered.Text = "Already Registered ?";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnRegister.Location = new System.Drawing.Point(124, 469);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(189, 44);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(66, 421);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 25);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // picturePasswordIcon
            // 
            this.picturePasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picturePasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("picturePasswordIcon.Image")));
            this.picturePasswordIcon.Location = new System.Drawing.Point(38, 417);
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
            this.picturePasswordBackground.Location = new System.Drawing.Point(28, 409);
            this.picturePasswordBackground.Name = "picturePasswordBackground";
            this.picturePasswordBackground.Size = new System.Drawing.Size(176, 45);
            this.picturePasswordBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePasswordBackground.TabIndex = 8;
            this.picturePasswordBackground.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(66, 85);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 24);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // pictureFirstnameIcon
            // 
            this.pictureFirstnameIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirstnameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureFirstnameIcon.Image")));
            this.pictureFirstnameIcon.Location = new System.Drawing.Point(38, 81);
            this.pictureFirstnameIcon.Name = "pictureFirstnameIcon";
            this.pictureFirstnameIcon.Size = new System.Drawing.Size(28, 28);
            this.pictureFirstnameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirstnameIcon.TabIndex = 6;
            this.pictureFirstnameIcon.TabStop = false;
            // 
            // pictureFirstnameBackground
            // 
            this.pictureFirstnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirstnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureFirstnameBackground.Image")));
            this.pictureFirstnameBackground.Location = new System.Drawing.Point(28, 73);
            this.pictureFirstnameBackground.Name = "pictureFirstnameBackground";
            this.pictureFirstnameBackground.Size = new System.Drawing.Size(176, 45);
            this.pictureFirstnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirstnameBackground.TabIndex = 5;
            this.pictureFirstnameBackground.TabStop = false;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(140, 11);
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
            this.lblOspital.Location = new System.Drawing.Point(174, 17);
            this.lblOspital.Name = "lblOspital";
            this.lblOspital.Size = new System.Drawing.Size(96, 27);
            this.lblOspital.TabIndex = 1;
            this.lblOspital.Text = "ospital";
            // 
            // lblManagementSystem
            // 
            this.lblManagementSystem.AutoSize = true;
            this.lblManagementSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblManagementSystem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblManagementSystem.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblManagementSystem.Location = new System.Drawing.Point(178, 40);
            this.lblManagementSystem.Name = "lblManagementSystem";
            this.lblManagementSystem.Size = new System.Drawing.Size(119, 16);
            this.lblManagementSystem.TabIndex = 2;
            this.lblManagementSystem.Text = "Management System";
            // 
            // txtToBeFocused
            // 
            this.txtToBeFocused.Location = new System.Drawing.Point(376, 146);
            this.txtToBeFocused.Name = "txtToBeFocused";
            this.txtToBeFocused.Size = new System.Drawing.Size(10, 26);
            this.txtToBeFocused.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pictureClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPasswordBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneBackground)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupSpecialization.ResumeLayout(false);
            this.groupSpecialization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmploymentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmploymentBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdateIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirthdateBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastnameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLastnameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasswordBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstnameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstnameBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblHere;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAlreadyRegistered;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picturePasswordIcon;
        private System.Windows.Forms.PictureBox picturePasswordBackground;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pictureFirstnameIcon;
        private System.Windows.Forms.PictureBox pictureFirstnameBackground;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblOspital;
        private System.Windows.Forms.Label lblManagementSystem;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox pictureLastnameIcon;
        private System.Windows.Forms.PictureBox pictureLastnameBackground;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.PictureBox pictureBirthdateIcon;
        private System.Windows.Forms.PictureBox pictureBirthdateBackground;
        private System.Windows.Forms.Label lblEmploymentYear;
        private System.Windows.Forms.PictureBox pictureEmploymentIcon;
        private System.Windows.Forms.PictureBox pictureEmploymentBackground;
        private Custom_Controls.CustomDatePicker dateEmploymentYear;
        private Custom_Controls.CustomDatePicker dateBirthdate;
        private System.Windows.Forms.GroupBox groupSpecialization;
        private System.Windows.Forms.RadioButton radioReceptionist;
        private System.Windows.Forms.RadioButton radioDoctor;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox picturePhoneIcon;
        private System.Windows.Forms.PictureBox picturePhoneBackground;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureConfirmPasswordIcon;
        private System.Windows.Forms.PictureBox pictureConfirmPasswordBackground;
        private System.Windows.Forms.TextBox txtToBeFocused;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboClinics;
        private System.Windows.Forms.Label lblX;
    }
}