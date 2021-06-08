
namespace HospitalMS
{
    partial class AddReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReportForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.comboPatientNationalID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientReport_btn = new System.Windows.Forms.Button();
            this.Medecines_checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Duration_to = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.Duration_From = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.Conditional_Illness_txt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAddReport = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.comboPatientNationalID);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.PatientReport_btn);
            this.panelContainer.Controls.Add(this.Medecines_checkBoxList);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.Duration_to);
            this.panelContainer.Controls.Add(this.Duration_From);
            this.panelContainer.Controls.Add(this.Conditional_Illness_txt);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 100);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(395, 440);
            this.panelContainer.TabIndex = 5;
            // 
            // comboPatientNationalID
            // 
            this.comboPatientNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.comboPatientNationalID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPatientNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboPatientNationalID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboPatientNationalID.FormattingEnabled = true;
            this.comboPatientNationalID.Location = new System.Drawing.Point(103, 26);
            this.comboPatientNationalID.Name = "comboPatientNationalID";
            this.comboPatientNationalID.Size = new System.Drawing.Size(209, 27);
            this.comboPatientNationalID.TabIndex = 17;
            this.comboPatientNationalID.Text = "Patient NationalID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Medecines";
            // 
            // PatientReport_btn
            // 
            this.PatientReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PatientReport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientReport_btn.FlatAppearance.BorderSize = 0;
            this.PatientReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientReport_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.PatientReport_btn.ForeColor = System.Drawing.Color.White;
            this.PatientReport_btn.Location = new System.Drawing.Point(47, 393);
            this.PatientReport_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PatientReport_btn.Name = "PatientReport_btn";
            this.PatientReport_btn.Size = new System.Drawing.Size(301, 40);
            this.PatientReport_btn.TabIndex = 27;
            this.PatientReport_btn.Text = "Add Report";
            this.PatientReport_btn.UseVisualStyleBackColor = false;
            // 
            // Medecines_checkBoxList
            // 
            this.Medecines_checkBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Medecines_checkBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Medecines_checkBoxList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Medecines_checkBoxList.ForeColor = System.Drawing.Color.White;
            this.Medecines_checkBoxList.FormattingEnabled = true;
            this.Medecines_checkBoxList.Location = new System.Drawing.Point(47, 281);
            this.Medecines_checkBoxList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Medecines_checkBoxList.Name = "Medecines_checkBoxList";
            this.Medecines_checkBoxList.Size = new System.Drawing.Size(301, 84);
            this.Medecines_checkBoxList.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Duration Patient Spent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(201, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(16, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "From";
            // 
            // Duration_to
            // 
            this.Duration_to.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Duration_to.BorderSize = 0;
            this.Duration_to.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Duration_to.Location = new System.Drawing.Point(201, 189);
            this.Duration_to.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Duration_to.MinimumSize = new System.Drawing.Size(4, 35);
            this.Duration_to.Name = "Duration_to";
            this.Duration_to.Size = new System.Drawing.Size(177, 35);
            this.Duration_to.SkinColor = System.Drawing.Color.Tomato;
            this.Duration_to.TabIndex = 22;
            this.Duration_to.TextColor = System.Drawing.Color.White;
            // 
            // Duration_From
            // 
            this.Duration_From.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Duration_From.BorderSize = 0;
            this.Duration_From.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Duration_From.Location = new System.Drawing.Point(16, 189);
            this.Duration_From.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Duration_From.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.Duration_From.MinimumSize = new System.Drawing.Size(4, 35);
            this.Duration_From.Name = "Duration_From";
            this.Duration_From.Size = new System.Drawing.Size(177, 35);
            this.Duration_From.SkinColor = System.Drawing.Color.Tomato;
            this.Duration_From.TabIndex = 6;
            this.Duration_From.TextColor = System.Drawing.Color.White;
            // 
            // Conditional_Illness_txt
            // 
            this.Conditional_Illness_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Conditional_Illness_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Conditional_Illness_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Conditional_Illness_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Conditional_Illness_txt.Location = new System.Drawing.Point(116, 88);
            this.Conditional_Illness_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Conditional_Illness_txt.Multiline = true;
            this.Conditional_Illness_txt.Name = "Conditional_Illness_txt";
            this.Conditional_Illness_txt.PasswordChar = '*';
            this.Conditional_Illness_txt.Size = new System.Drawing.Size(186, 21);
            this.Conditional_Illness_txt.TabIndex = 17;
            this.Conditional_Illness_txt.Text = "Conditional Illness";
            this.Conditional_Illness_txt.UseSystemPasswordChar = true;
            this.Conditional_Illness_txt.Enter += new System.EventHandler(this.Conditional_Illness_txt_Enter);
            this.Conditional_Illness_txt.Leave += new System.EventHandler(this.Conditional_Illness_txt_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblAddReport
            // 
            this.lblAddReport.AutoSize = true;
            this.lblAddReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddReport.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddReport.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddReport.Location = new System.Drawing.Point(251, 20);
            this.lblAddReport.Name = "lblAddReport";
            this.lblAddReport.Size = new System.Drawing.Size(205, 40);
            this.lblAddReport.TabIndex = 16;
            this.lblAddReport.Text = "Adding Report";
            // 
            // AddReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.lblAddReport);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddReportForm";
            this.Text = "AddReportForm";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox Conditional_Illness_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Custom_Controls.CustomDatePicker Duration_to;
        private Custom_Controls.CustomDatePicker Duration_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Medecines_checkBoxList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PatientReport_btn;
        private System.Windows.Forms.Label lblAddReport;
        private System.Windows.Forms.ComboBox comboPatientNationalID;
    }
}