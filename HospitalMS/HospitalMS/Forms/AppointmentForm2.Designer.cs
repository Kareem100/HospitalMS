
namespace HospitalMS
{
    partial class AppointmentForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm2));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OneAppointment_Radio = new System.Windows.Forms.RadioButton();
            this.AllAppointments_Radio = new System.Windows.Forms.RadioButton();
            this.AllAppointments_Panel = new System.Windows.Forms.Panel();
            this.OneAppointment_Pannel = new System.Windows.Forms.Panel();
            this.PatientID_txt = new System.Windows.Forms.TextBox();
            this.IdBackGround = new System.Windows.Forms.PictureBox();
            this.PatientAppointment_btn = new System.Windows.Forms.Button();
            this.OneAppointment_Data = new System.Windows.Forms.DataGridView();
            this.AllAppointments_btn = new System.Windows.Forms.Button();
            this.AllAppointments_Data = new System.Windows.Forms.DataGridView();
            this.panelContainer.SuspendLayout();
            this.AllAppointments_Panel.SuspendLayout();
            this.OneAppointment_Pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneAppointment_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllAppointments_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.OneAppointment_Radio);
            this.panelContainer.Controls.Add(this.AllAppointments_Radio);
            this.panelContainer.Controls.Add(this.AllAppointments_Panel);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(518, 525);
            this.panelContainer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select what do you want to show";
            // 
            // OneAppointment_Radio
            // 
            this.OneAppointment_Radio.AutoSize = true;
            this.OneAppointment_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OneAppointment_Radio.ForeColor = System.Drawing.Color.White;
            this.OneAppointment_Radio.Location = new System.Drawing.Point(266, 113);
            this.OneAppointment_Radio.Name = "OneAppointment_Radio";
            this.OneAppointment_Radio.Size = new System.Drawing.Size(236, 28);
            this.OneAppointment_Radio.TabIndex = 6;
            this.OneAppointment_Radio.TabStop = true;
            this.OneAppointment_Radio.Text = "Display One Appointment";
            this.OneAppointment_Radio.UseVisualStyleBackColor = true;
            // 
            // AllAppointments_Radio
            // 
            this.AllAppointments_Radio.AutoSize = true;
            this.AllAppointments_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllAppointments_Radio.ForeColor = System.Drawing.Color.White;
            this.AllAppointments_Radio.Location = new System.Drawing.Point(23, 113);
            this.AllAppointments_Radio.Name = "AllAppointments_Radio";
            this.AllAppointments_Radio.Size = new System.Drawing.Size(233, 28);
            this.AllAppointments_Radio.TabIndex = 5;
            this.AllAppointments_Radio.TabStop = true;
            this.AllAppointments_Radio.Text = "Display All Appointments";
            this.AllAppointments_Radio.UseVisualStyleBackColor = true;
            // 
            // AllAppointments_Panel
            // 
            this.AllAppointments_Panel.Controls.Add(this.OneAppointment_Pannel);
            this.AllAppointments_Panel.Controls.Add(this.AllAppointments_btn);
            this.AllAppointments_Panel.Controls.Add(this.AllAppointments_Data);
            this.AllAppointments_Panel.Location = new System.Drawing.Point(0, 181);
            this.AllAppointments_Panel.Name = "AllAppointments_Panel";
            this.AllAppointments_Panel.Size = new System.Drawing.Size(518, 357);
            this.AllAppointments_Panel.TabIndex = 4;
            // 
            // OneAppointment_Pannel
            // 
            this.OneAppointment_Pannel.Controls.Add(this.PatientID_txt);
            this.OneAppointment_Pannel.Controls.Add(this.IdBackGround);
            this.OneAppointment_Pannel.Controls.Add(this.PatientAppointment_btn);
            this.OneAppointment_Pannel.Controls.Add(this.OneAppointment_Data);
            this.OneAppointment_Pannel.Location = new System.Drawing.Point(0, 0);
            this.OneAppointment_Pannel.Name = "OneAppointment_Pannel";
            this.OneAppointment_Pannel.Size = new System.Drawing.Size(518, 357);
            this.OneAppointment_Pannel.TabIndex = 2;
            // 
            // PatientID_txt
            // 
            this.PatientID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.PatientID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientID_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PatientID_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatientID_txt.Location = new System.Drawing.Point(147, 45);
            this.PatientID_txt.Multiline = true;
            this.PatientID_txt.Name = "PatientID_txt";
            this.PatientID_txt.PasswordChar = '*';
            this.PatientID_txt.Size = new System.Drawing.Size(205, 25);
            this.PatientID_txt.TabIndex = 19;
            this.PatientID_txt.Text = "Patient Id";
            this.PatientID_txt.UseSystemPasswordChar = true;
            this.PatientID_txt.Enter += new System.EventHandler(this.PatientID_txt_Enter);
            this.PatientID_txt.Leave += new System.EventHandler(this.PatientID_txt_Leave);
            this.PatientID_txt.MouseEnter += new System.EventHandler(this.PatientID_txt_MouseEnter);
            this.PatientID_txt.MouseLeave += new System.EventHandler(this.PatientID_txt_MouseLeave);
            // 
            // IdBackGround
            // 
            this.IdBackGround.BackColor = System.Drawing.Color.Transparent;
            this.IdBackGround.Image = ((System.Drawing.Image)(resources.GetObject("IdBackGround.Image")));
            this.IdBackGround.Location = new System.Drawing.Point(130, 33);
            this.IdBackGround.Name = "IdBackGround";
            this.IdBackGround.Size = new System.Drawing.Size(243, 45);
            this.IdBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IdBackGround.TabIndex = 18;
            this.IdBackGround.TabStop = false;
            // 
            // PatientAppointment_btn
            // 
            this.PatientAppointment_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PatientAppointment_btn.FlatAppearance.BorderSize = 0;
            this.PatientAppointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientAppointment_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientAppointment_btn.ForeColor = System.Drawing.Color.White;
            this.PatientAppointment_btn.Location = new System.Drawing.Point(118, 297);
            this.PatientAppointment_btn.Name = "PatientAppointment_btn";
            this.PatientAppointment_btn.Size = new System.Drawing.Size(287, 35);
            this.PatientAppointment_btn.TabIndex = 12;
            this.PatientAppointment_btn.Text = "Display Patient Appointment";
            this.PatientAppointment_btn.UseVisualStyleBackColor = false;
            // 
            // OneAppointment_Data
            // 
            this.OneAppointment_Data.BackgroundColor = System.Drawing.Color.White;
            this.OneAppointment_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OneAppointment_Data.Location = new System.Drawing.Point(67, 90);
            this.OneAppointment_Data.Name = "OneAppointment_Data";
            this.OneAppointment_Data.RowHeadersWidth = 51;
            this.OneAppointment_Data.RowTemplate.Height = 29;
            this.OneAppointment_Data.Size = new System.Drawing.Size(391, 188);
            this.OneAppointment_Data.TabIndex = 11;
            // 
            // AllAppointments_btn
            // 
            this.AllAppointments_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllAppointments_btn.FlatAppearance.BorderSize = 0;
            this.AllAppointments_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllAppointments_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllAppointments_btn.ForeColor = System.Drawing.Color.White;
            this.AllAppointments_btn.Location = new System.Drawing.Point(133, 297);
            this.AllAppointments_btn.Name = "AllAppointments_btn";
            this.AllAppointments_btn.Size = new System.Drawing.Size(207, 40);
            this.AllAppointments_btn.TabIndex = 1;
            this.AllAppointments_btn.Text = "Display All Appointments";
            this.AllAppointments_btn.UseVisualStyleBackColor = false;
            // 
            // AllAppointments_Data
            // 
            this.AllAppointments_Data.BackgroundColor = System.Drawing.Color.White;
            this.AllAppointments_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllAppointments_Data.Location = new System.Drawing.Point(56, 30);
            this.AllAppointments_Data.Name = "AllAppointments_Data";
            this.AllAppointments_Data.RowHeadersWidth = 51;
            this.AllAppointments_Data.RowTemplate.Height = 29;
            this.AllAppointments_Data.Size = new System.Drawing.Size(402, 242);
            this.AllAppointments_Data.TabIndex = 0;
            // 
            // AppointmentForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm2";
            this.Text = "AppointmentForm2";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.AllAppointments_Panel.ResumeLayout(false);
            this.OneAppointment_Pannel.ResumeLayout(false);
            this.OneAppointment_Pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneAppointment_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllAppointments_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OneAppointment_Radio;
        private System.Windows.Forms.RadioButton AllAppointments_Radio;
        private System.Windows.Forms.Panel AllAppointments_Panel;
        private System.Windows.Forms.Panel OneAppointment_Pannel;
        private System.Windows.Forms.Button PatientAppointment_btn;
        private System.Windows.Forms.DataGridView OneAppointment_Data;
        private System.Windows.Forms.Button AllAppointments_btn;
        private System.Windows.Forms.DataGridView AllAppointments_Data;
        private System.Windows.Forms.TextBox PatientID_txt;
        private System.Windows.Forms.PictureBox IdBackGround;
    }
}