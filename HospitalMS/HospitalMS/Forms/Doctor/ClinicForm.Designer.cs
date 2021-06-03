
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
            this.label1 = new System.Windows.Forms.Label();
            this.OneClinic_Radio = new System.Windows.Forms.RadioButton();
            this.AllClinics_Radio = new System.Windows.Forms.RadioButton();
            this.OneClinic_panel = new System.Windows.Forms.Panel();
            this.ClinicName_txt = new System.Windows.Forms.TextBox();
            this.IdBackGround = new System.Windows.Forms.PictureBox();
            this.OneClinic_btn = new System.Windows.Forms.Button();
            this.OneClinic_Data = new System.Windows.Forms.DataGridView();
            this.AllClinics_Panel = new System.Windows.Forms.Panel();
            this.AllClinics_btn = new System.Windows.Forms.Button();
            this.AllClinics_Data = new System.Windows.Forms.DataGridView();
            this.panelContainer.SuspendLayout();
            this.OneClinic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneClinic_Data)).BeginInit();
            this.AllClinics_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllClinics_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.OneClinic_Radio);
            this.panelContainer.Controls.Add(this.AllClinics_Radio);
            this.panelContainer.Controls.Add(this.OneClinic_panel);
            this.panelContainer.Controls.Add(this.AllClinics_Panel);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(518, 522);
            this.panelContainer.TabIndex = 11;
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
            // OneClinic_Radio
            // 
            this.OneClinic_Radio.AutoSize = true;
            this.OneClinic_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OneClinic_Radio.ForeColor = System.Drawing.Color.White;
            this.OneClinic_Radio.Location = new System.Drawing.Point(266, 113);
            this.OneClinic_Radio.Name = "OneClinic_Radio";
            this.OneClinic_Radio.Size = new System.Drawing.Size(179, 28);
            this.OneClinic_Radio.TabIndex = 6;
            this.OneClinic_Radio.TabStop = true;
            this.OneClinic_Radio.Text = "Display One Clinic";
            this.OneClinic_Radio.UseVisualStyleBackColor = true;
            // 
            // AllClinics_Radio
            // 
            this.AllClinics_Radio.AutoSize = true;
            this.AllClinics_Radio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllClinics_Radio.ForeColor = System.Drawing.Color.White;
            this.AllClinics_Radio.Location = new System.Drawing.Point(23, 113);
            this.AllClinics_Radio.Name = "AllClinics_Radio";
            this.AllClinics_Radio.Size = new System.Drawing.Size(176, 28);
            this.AllClinics_Radio.TabIndex = 5;
            this.AllClinics_Radio.TabStop = true;
            this.AllClinics_Radio.Text = "Display All Clinics";
            this.AllClinics_Radio.UseVisualStyleBackColor = true;
            // 
            // OneClinic_panel
            // 
            this.OneClinic_panel.Controls.Add(this.ClinicName_txt);
            this.OneClinic_panel.Controls.Add(this.IdBackGround);
            this.OneClinic_panel.Controls.Add(this.OneClinic_btn);
            this.OneClinic_panel.Controls.Add(this.OneClinic_Data);
            this.OneClinic_panel.Location = new System.Drawing.Point(0, 181);
            this.OneClinic_panel.Name = "OneClinic_panel";
            this.OneClinic_panel.Size = new System.Drawing.Size(518, 357);
            this.OneClinic_panel.TabIndex = 2;
            // 
            // ClinicName_txt
            // 
            this.ClinicName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.ClinicName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClinicName_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ClinicName_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClinicName_txt.Location = new System.Drawing.Point(144, 41);
            this.ClinicName_txt.Multiline = true;
            this.ClinicName_txt.Name = "ClinicName_txt";
            this.ClinicName_txt.PasswordChar = '*';
            this.ClinicName_txt.Size = new System.Drawing.Size(205, 25);
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
            this.IdBackGround.Location = new System.Drawing.Point(127, 29);
            this.IdBackGround.Name = "IdBackGround";
            this.IdBackGround.Size = new System.Drawing.Size(243, 45);
            this.IdBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IdBackGround.TabIndex = 22;
            this.IdBackGround.TabStop = false;
            // 
            // OneClinic_btn
            // 
            this.OneClinic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OneClinic_btn.FlatAppearance.BorderSize = 0;
            this.OneClinic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneClinic_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneClinic_btn.ForeColor = System.Drawing.Color.White;
            this.OneClinic_btn.Location = new System.Drawing.Point(130, 293);
            this.OneClinic_btn.Name = "OneClinic_btn";
            this.OneClinic_btn.Size = new System.Drawing.Size(248, 35);
            this.OneClinic_btn.TabIndex = 21;
            this.OneClinic_btn.Text = "Display Clinic";
            this.OneClinic_btn.UseVisualStyleBackColor = false;
            // 
            // OneClinic_Data
            // 
            this.OneClinic_Data.BackgroundColor = System.Drawing.Color.White;
            this.OneClinic_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OneClinic_Data.Location = new System.Drawing.Point(64, 86);
            this.OneClinic_Data.Name = "OneClinic_Data";
            this.OneClinic_Data.RowHeadersWidth = 51;
            this.OneClinic_Data.RowTemplate.Height = 29;
            this.OneClinic_Data.Size = new System.Drawing.Size(391, 188);
            this.OneClinic_Data.TabIndex = 20;
            // 
            // AllClinics_Panel
            // 
            this.AllClinics_Panel.Controls.Add(this.AllClinics_btn);
            this.AllClinics_Panel.Controls.Add(this.AllClinics_Data);
            this.AllClinics_Panel.Location = new System.Drawing.Point(0, 181);
            this.AllClinics_Panel.Name = "AllClinics_Panel";
            this.AllClinics_Panel.Size = new System.Drawing.Size(518, 357);
            this.AllClinics_Panel.TabIndex = 4;
            // 
            // AllClinics_btn
            // 
            this.AllClinics_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllClinics_btn.FlatAppearance.BorderSize = 0;
            this.AllClinics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllClinics_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllClinics_btn.ForeColor = System.Drawing.Color.White;
            this.AllClinics_btn.Location = new System.Drawing.Point(133, 297);
            this.AllClinics_btn.Name = "AllClinics_btn";
            this.AllClinics_btn.Size = new System.Drawing.Size(221, 40);
            this.AllClinics_btn.TabIndex = 1;
            this.AllClinics_btn.Text = "Display All Clinics";
            this.AllClinics_btn.UseVisualStyleBackColor = false;
            // 
            // AllClinics_Data
            // 
            this.AllClinics_Data.BackgroundColor = System.Drawing.Color.White;
            this.AllClinics_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClinics_Data.Location = new System.Drawing.Point(56, 30);
            this.AllClinics_Data.Name = "AllClinics_Data";
            this.AllClinics_Data.RowHeadersWidth = 51;
            this.AllClinics_Data.RowTemplate.Height = 29;
            this.AllClinics_Data.Size = new System.Drawing.Size(402, 242);
            this.AllClinics_Data.TabIndex = 0;
            // 
            // ClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClinicForm";
            this.Text = "ClinicForm";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.OneClinic_panel.ResumeLayout(false);
            this.OneClinic_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneClinic_Data)).EndInit();
            this.AllClinics_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllClinics_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OneClinic_Radio;
        private System.Windows.Forms.RadioButton AllClinics_Radio;
        private System.Windows.Forms.Panel AllClinics_Panel;
        private System.Windows.Forms.Button AllClinics_btn;
        private System.Windows.Forms.DataGridView AllClinics_Data;
        private System.Windows.Forms.Panel OneClinic_panel;
        private System.Windows.Forms.TextBox ClinicName_txt;
        private System.Windows.Forms.PictureBox IdBackGround;
        private System.Windows.Forms.Button OneClinic_btn;
        private System.Windows.Forms.DataGridView OneClinic_Data;
    }
}