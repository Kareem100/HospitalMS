
namespace HospitalMS
{
    partial class ReportForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm2));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.OneClinic_panel = new System.Windows.Forms.Panel();
            this.PatientID_txt = new System.Windows.Forms.TextBox();
            this.IdBackGround = new System.Windows.Forms.PictureBox();
            this.PatientReport_btn = new System.Windows.Forms.Button();
            this.OneReport_Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OneReport_Radio = new System.Windows.Forms.RadioButton();
            this.AllReport_Radio = new System.Windows.Forms.RadioButton();
            this.AllReport_Pannel = new System.Windows.Forms.Panel();
            this.AllReport_btn = new System.Windows.Forms.Button();
            this.AllReports_Data = new System.Windows.Forms.DataGridView();
            this.panelContainer.SuspendLayout();
            this.OneClinic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneReport_Data)).BeginInit();
            this.AllReport_Pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllReports_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.OneClinic_panel);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.OneReport_Radio);
            this.panelContainer.Controls.Add(this.AllReport_Radio);
            this.panelContainer.Controls.Add(this.AllReport_Pannel);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(172, 57);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(518, 522);
            this.panelContainer.TabIndex = 9;
            // 
            // OneClinic_panel
            // 
            this.OneClinic_panel.Controls.Add(this.PatientID_txt);
            this.OneClinic_panel.Controls.Add(this.IdBackGround);
            this.OneClinic_panel.Controls.Add(this.PatientReport_btn);
            this.OneClinic_panel.Controls.Add(this.OneReport_Data);
            this.OneClinic_panel.Location = new System.Drawing.Point(0, 161);
            this.OneClinic_panel.Name = "OneClinic_panel";
            this.OneClinic_panel.Size = new System.Drawing.Size(518, 357);
            this.OneClinic_panel.TabIndex = 8;
            // 
            // PatientID_txt
            // 
            this.PatientID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.PatientID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientID_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PatientID_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PatientID_txt.Location = new System.Drawing.Point(144, 41);
            this.PatientID_txt.Multiline = true;
            this.PatientID_txt.Name = "PatientID_txt";
            this.PatientID_txt.PasswordChar = '*';
            this.PatientID_txt.Size = new System.Drawing.Size(205, 25);
            this.PatientID_txt.TabIndex = 23;
            this.PatientID_txt.Text = "Patient ID";
            this.PatientID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientID_txt.UseSystemPasswordChar = true;
            this.PatientID_txt.Enter += new System.EventHandler(this.PatientID_txt_Enter);
            this.PatientID_txt.Leave += new System.EventHandler(this.PatientID_txt_Leave);
            // 
            // IdBackGround
            // 
            this.IdBackGround.BackColor = System.Drawing.Color.Transparent;
            this.IdBackGround.Location = new System.Drawing.Point(127, 29);
            this.IdBackGround.Name = "IdBackGround";
            this.IdBackGround.Size = new System.Drawing.Size(243, 45);
            this.IdBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IdBackGround.TabIndex = 22;
            this.IdBackGround.TabStop = false;
            // 
            // PatientReport_btn
            // 
            this.PatientReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PatientReport_btn.FlatAppearance.BorderSize = 0;
            this.PatientReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientReport_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientReport_btn.ForeColor = System.Drawing.Color.White;
            this.PatientReport_btn.Location = new System.Drawing.Point(130, 293);
            this.PatientReport_btn.Name = "PatientReport_btn";
            this.PatientReport_btn.Size = new System.Drawing.Size(248, 35);
            this.PatientReport_btn.TabIndex = 21;
            this.PatientReport_btn.Text = "Display Report";
            this.PatientReport_btn.UseVisualStyleBackColor = false;
            // 
            // OneReport_Data
            // 
            this.OneReport_Data.BackgroundColor = System.Drawing.Color.White;
            this.OneReport_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OneReport_Data.Location = new System.Drawing.Point(64, 86);
            this.OneReport_Data.Name = "OneReport_Data";
            this.OneReport_Data.RowHeadersWidth = 51;
            this.OneReport_Data.RowTemplate.Height = 29;
            this.OneReport_Data.Size = new System.Drawing.Size(391, 188);
            this.OneReport_Data.TabIndex = 20;
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
            // OneReport_Radio
            // 
            this.OneReport_Radio.AutoSize = true;
            this.OneReport_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OneReport_Radio.ForeColor = System.Drawing.Color.White;
            this.OneReport_Radio.Location = new System.Drawing.Point(260, 110);
            this.OneReport_Radio.Name = "OneReport_Radio";
            this.OneReport_Radio.Size = new System.Drawing.Size(190, 28);
            this.OneReport_Radio.TabIndex = 6;
            this.OneReport_Radio.TabStop = true;
            this.OneReport_Radio.Text = "Display One Report";
            this.OneReport_Radio.UseVisualStyleBackColor = true;
            // 
            // AllReport_Radio
            // 
            this.AllReport_Radio.AutoSize = true;
            this.AllReport_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllReport_Radio.ForeColor = System.Drawing.Color.White;
            this.AllReport_Radio.Location = new System.Drawing.Point(29, 110);
            this.AllReport_Radio.Name = "AllReport_Radio";
            this.AllReport_Radio.Size = new System.Drawing.Size(187, 28);
            this.AllReport_Radio.TabIndex = 5;
            this.AllReport_Radio.TabStop = true;
            this.AllReport_Radio.Text = "Display All Reports";
            this.AllReport_Radio.UseVisualStyleBackColor = true;
            // 
            // AllReport_Pannel
            // 
            this.AllReport_Pannel.Controls.Add(this.AllReport_btn);
            this.AllReport_Pannel.Controls.Add(this.AllReports_Data);
            this.AllReport_Pannel.Location = new System.Drawing.Point(0, 181);
            this.AllReport_Pannel.Name = "AllReport_Pannel";
            this.AllReport_Pannel.Size = new System.Drawing.Size(518, 341);
            this.AllReport_Pannel.TabIndex = 4;
            // 
            // AllReport_btn
            // 
            this.AllReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllReport_btn.FlatAppearance.BorderSize = 0;
            this.AllReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllReport_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllReport_btn.ForeColor = System.Drawing.Color.White;
            this.AllReport_btn.Location = new System.Drawing.Point(133, 297);
            this.AllReport_btn.Name = "AllReport_btn";
            this.AllReport_btn.Size = new System.Drawing.Size(207, 40);
            this.AllReport_btn.TabIndex = 1;
            this.AllReport_btn.Text = "Display All Reports";
            this.AllReport_btn.UseVisualStyleBackColor = false;
            // 
            // AllReports_Data
            // 
            this.AllReports_Data.BackgroundColor = System.Drawing.Color.White;
            this.AllReports_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllReports_Data.Location = new System.Drawing.Point(56, 30);
            this.AllReports_Data.Name = "AllReports_Data";
            this.AllReports_Data.RowHeadersWidth = 51;
            this.AllReports_Data.RowTemplate.Height = 29;
            this.AllReports_Data.Size = new System.Drawing.Size(402, 242);
            this.AllReports_Data.TabIndex = 0;
            // 
            // ReportForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm2";
            this.Text = "ReportForm3";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.OneClinic_panel.ResumeLayout(false);
            this.OneClinic_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneReport_Data)).EndInit();
            this.AllReport_Pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllReports_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel OneClinic_panel;
        private System.Windows.Forms.TextBox PatientID_txt;
        private System.Windows.Forms.PictureBox IdBackGround;
        private System.Windows.Forms.Button PatientReport_btn;
        private System.Windows.Forms.DataGridView OneReport_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OneReport_Radio;
        private System.Windows.Forms.RadioButton AllReport_Radio;
        private System.Windows.Forms.Panel AllReport_Pannel;
        private System.Windows.Forms.Button AllReport_btn;
        private System.Windows.Forms.DataGridView AllReports_Data;
    }
}