
namespace HospitalMS
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.lblRooms = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.picNationalidBackround = new System.Windows.Forms.PictureBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.picLastnameBackground = new System.Windows.Forms.PictureBox();
            this.lblAssignToRoom = new System.Windows.Forms.Label();
            this.comboRooms = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.comboDoctors = new System.Windows.Forms.ComboBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picDescriptionBackround = new System.Windows.Forms.PictureBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.picFirstnameBackground = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNationalidBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastnameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescriptionBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstnameBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRooms.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRooms.ForeColor = System.Drawing.Color.Crimson;
            this.lblRooms.Location = new System.Drawing.Point(287, 20);
            this.lblRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(179, 40);
            this.lblRooms.TabIndex = 16;
            this.lblRooms.Text = "Appointment";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.txtNationalID);
            this.panelContainer.Controls.Add(this.picNationalidBackround);
            this.panelContainer.Controls.Add(this.txtLastname);
            this.panelContainer.Controls.Add(this.picLastnameBackground);
            this.panelContainer.Controls.Add(this.lblAssignToRoom);
            this.panelContainer.Controls.Add(this.comboRooms);
            this.panelContainer.Controls.Add(this.lblDoctor);
            this.panelContainer.Controls.Add(this.comboDoctors);
            this.panelContainer.Controls.Add(this.btnAddAppointment);
            this.panelContainer.Controls.Add(this.txtDescription);
            this.panelContainer.Controls.Add(this.picDescriptionBackround);
            this.panelContainer.Controls.Add(this.txtFirstname);
            this.panelContainer.Controls.Add(this.picFirstnameBackground);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 100);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(418, 430);
            this.panelContainer.TabIndex = 17;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNationalID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNationalID.Location = new System.Drawing.Point(126, 161);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNationalID.MaxLength = 14;
            this.txtNationalID.Multiline = true;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(182, 25);
            this.txtNationalID.TabIndex = 3;
            this.txtNationalID.Text = "National ID";
            this.txtNationalID.Enter += new System.EventHandler(this.txtNationalID_Enter);
            this.txtNationalID.Leave += new System.EventHandler(this.txtNationalID_Leave);
            this.txtNationalID.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalID_Validating);
            // 
            // picNationalidBackround
            // 
            this.picNationalidBackround.BackColor = System.Drawing.Color.Transparent;
            this.picNationalidBackround.Image = ((System.Drawing.Image)(resources.GetObject("picNationalidBackround.Image")));
            this.picNationalidBackround.Location = new System.Drawing.Point(99, 147);
            this.picNationalidBackround.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picNationalidBackround.Name = "picNationalidBackround";
            this.picNationalidBackround.Size = new System.Drawing.Size(230, 49);
            this.picNationalidBackround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNationalidBackround.TabIndex = 35;
            this.picNationalidBackround.TabStop = false;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtLastname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastname.Location = new System.Drawing.Point(126, 96);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(182, 25);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "Last Name";
            this.txtLastname.Enter += new System.EventHandler(this.txtLastname_Enter);
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // picLastnameBackground
            // 
            this.picLastnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picLastnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picLastnameBackground.Image")));
            this.picLastnameBackground.Location = new System.Drawing.Point(99, 82);
            this.picLastnameBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLastnameBackground.Name = "picLastnameBackground";
            this.picLastnameBackground.Size = new System.Drawing.Size(230, 49);
            this.picLastnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLastnameBackground.TabIndex = 33;
            this.picLastnameBackground.TabStop = false;
            // 
            // lblAssignToRoom
            // 
            this.lblAssignToRoom.AutoSize = true;
            this.lblAssignToRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.lblAssignToRoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAssignToRoom.Location = new System.Drawing.Point(256, 288);
            this.lblAssignToRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignToRoom.Name = "lblAssignToRoom";
            this.lblAssignToRoom.Size = new System.Drawing.Size(127, 23);
            this.lblAssignToRoom.TabIndex = 32;
            this.lblAssignToRoom.Text = "Assign to Room";
            // 
            // comboRooms
            // 
            this.comboRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboRooms.FormattingEnabled = true;
            this.comboRooms.Location = new System.Drawing.Point(230, 316);
            this.comboRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboRooms.Name = "comboRooms";
            this.comboRooms.Size = new System.Drawing.Size(179, 31);
            this.comboRooms.TabIndex = 6;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.lblDoctor.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDoctor.Location = new System.Drawing.Point(29, 288);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(141, 23);
            this.lblDoctor.TabIndex = 30;
            this.lblDoctor.Text = "Assign to Doctor";
            // 
            // comboDoctors
            // 
            this.comboDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDoctors.FormattingEnabled = true;
            this.comboDoctors.Location = new System.Drawing.Point(14, 316);
            this.comboDoctors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDoctors.Name = "comboDoctors";
            this.comboDoctors.Size = new System.Drawing.Size(179, 31);
            this.comboDoctors.TabIndex = 5;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(65, 375);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(310, 40);
            this.btnAddAppointment.TabIndex = 7;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.Location = new System.Drawing.Point(122, 229);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '*';
            this.txtDescription.Size = new System.Drawing.Size(182, 32);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "Description";
            this.txtDescription.UseSystemPasswordChar = true;
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // picDescriptionBackround
            // 
            this.picDescriptionBackround.BackColor = System.Drawing.Color.Transparent;
            this.picDescriptionBackround.Image = ((System.Drawing.Image)(resources.GetObject("picDescriptionBackround.Image")));
            this.picDescriptionBackround.Location = new System.Drawing.Point(100, 213);
            this.picDescriptionBackround.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDescriptionBackround.Name = "picDescriptionBackround";
            this.picDescriptionBackround.Size = new System.Drawing.Size(230, 66);
            this.picDescriptionBackround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDescriptionBackround.TabIndex = 18;
            this.picDescriptionBackround.TabStop = false;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFirstname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstname.Location = new System.Drawing.Point(126, 28);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(182, 25);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.Text = "First Name";
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // picFirstnameBackground
            // 
            this.picFirstnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picFirstnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picFirstnameBackground.Image")));
            this.picFirstnameBackground.Location = new System.Drawing.Point(99, 14);
            this.picFirstnameBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picFirstnameBackground.Name = "picFirstnameBackground";
            this.picFirstnameBackground.Size = new System.Drawing.Size(230, 49);
            this.picFirstnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirstnameBackground.TabIndex = 5;
            this.picFirstnameBackground.TabStop = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblRooms);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNationalidBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastnameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescriptionBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstnameBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblAssignToRoom;
        private System.Windows.Forms.ComboBox comboRooms;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox comboDoctors;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picDescriptionBackround;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.PictureBox picFirstnameBackground;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.PictureBox picLastnameBackground;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.PictureBox picNationalidBackround;
    }
}