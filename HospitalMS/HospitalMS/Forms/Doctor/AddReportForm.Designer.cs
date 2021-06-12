
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
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.lblConditionalIllness = new System.Windows.Forms.Label();
            this.lblPatientNationalID = new System.Windows.Forms.Label();
            this.comboPatientNationalID = new System.Windows.Forms.ComboBox();
            this.lblMedecines = new System.Windows.Forms.Label();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.chechBoxMedecines = new System.Windows.Forms.CheckedListBox();
            this.lblDurationPatientSpent = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtConditionalIllness = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAddReport = new System.Windows.Forms.Label();
            this.dateTo = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.dateFrom = new HospitalMS.Custom_Controls.CustomDatePicker();
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
            this.panelContainer.Controls.Add(this.btnAddQuantity);
            this.panelContainer.Controls.Add(this.lblConditionalIllness);
            this.panelContainer.Controls.Add(this.lblPatientNationalID);
            this.panelContainer.Controls.Add(this.comboPatientNationalID);
            this.panelContainer.Controls.Add(this.lblMedecines);
            this.panelContainer.Controls.Add(this.btnAddReport);
            this.panelContainer.Controls.Add(this.chechBoxMedecines);
            this.panelContainer.Controls.Add(this.lblDurationPatientSpent);
            this.panelContainer.Controls.Add(this.lblTo);
            this.panelContainer.Controls.Add(this.lblFrom);
            this.panelContainer.Controls.Add(this.dateTo);
            this.panelContainer.Controls.Add(this.dateFrom);
            this.panelContainer.Controls.Add(this.txtConditionalIllness);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 100);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(395, 440);
            this.panelContainer.TabIndex = 5;
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuantity.FlatAppearance.BorderSize = 0;
            this.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuantity.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnAddQuantity.ForeColor = System.Drawing.Color.White;
            this.btnAddQuantity.Location = new System.Drawing.Point(255, 295);
            this.btnAddQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(93, 84);
            this.btnAddQuantity.TabIndex = 28;
            this.btnAddQuantity.Text = "Add Quantity";
            this.btnAddQuantity.UseVisualStyleBackColor = false;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            // 
            // lblConditionalIllness
            // 
            this.lblConditionalIllness.AutoSize = true;
            this.lblConditionalIllness.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblConditionalIllness.Location = new System.Drawing.Point(140, 71);
            this.lblConditionalIllness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConditionalIllness.Name = "lblConditionalIllness";
            this.lblConditionalIllness.Size = new System.Drawing.Size(125, 19);
            this.lblConditionalIllness.TabIndex = 30;
            this.lblConditionalIllness.Text = "Conditional Illness";
            // 
            // lblPatientNationalID
            // 
            this.lblPatientNationalID.AutoSize = true;
            this.lblPatientNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPatientNationalID.Location = new System.Drawing.Point(133, 15);
            this.lblPatientNationalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientNationalID.Name = "lblPatientNationalID";
            this.lblPatientNationalID.Size = new System.Drawing.Size(134, 19);
            this.lblPatientNationalID.TabIndex = 29;
            this.lblPatientNationalID.Text = "Patient National ID";
            // 
            // comboPatientNationalID
            // 
            this.comboPatientNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.comboPatientNationalID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPatientNationalID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboPatientNationalID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboPatientNationalID.FormattingEnabled = true;
            this.comboPatientNationalID.Location = new System.Drawing.Point(103, 37);
            this.comboPatientNationalID.Name = "comboPatientNationalID";
            this.comboPatientNationalID.Size = new System.Drawing.Size(209, 27);
            this.comboPatientNationalID.TabIndex = 17;
            this.comboPatientNationalID.Text = "Patient National ID";
            // 
            // lblMedecines
            // 
            this.lblMedecines.AutoSize = true;
            this.lblMedecines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMedecines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedecines.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblMedecines.ForeColor = System.Drawing.Color.White;
            this.lblMedecines.Location = new System.Drawing.Point(148, 256);
            this.lblMedecines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecines.Name = "lblMedecines";
            this.lblMedecines.Size = new System.Drawing.Size(109, 29);
            this.lblMedecines.TabIndex = 28;
            this.lblMedecines.Text = "Medecines";
            // 
            // btnAddReport
            // 
            this.btnAddReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReport.FlatAppearance.BorderSize = 0;
            this.btnAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReport.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnAddReport.ForeColor = System.Drawing.Color.White;
            this.btnAddReport.Location = new System.Drawing.Point(47, 393);
            this.btnAddReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(301, 40);
            this.btnAddReport.TabIndex = 27;
            this.btnAddReport.Text = "Add Report";
            this.btnAddReport.UseVisualStyleBackColor = false;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // chechBoxMedecines
            // 
            this.chechBoxMedecines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.chechBoxMedecines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chechBoxMedecines.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chechBoxMedecines.ForeColor = System.Drawing.Color.White;
            this.chechBoxMedecines.FormattingEnabled = true;
            this.chechBoxMedecines.Location = new System.Drawing.Point(47, 295);
            this.chechBoxMedecines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chechBoxMedecines.Name = "chechBoxMedecines";
            this.chechBoxMedecines.Size = new System.Drawing.Size(301, 84);
            this.chechBoxMedecines.TabIndex = 26;
            this.chechBoxMedecines.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chechBoxMedecines_ItemCheck);
            // 
            // lblDurationPatientSpent
            // 
            this.lblDurationPatientSpent.AutoSize = true;
            this.lblDurationPatientSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDurationPatientSpent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDurationPatientSpent.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDurationPatientSpent.ForeColor = System.Drawing.Color.White;
            this.lblDurationPatientSpent.Location = new System.Drawing.Point(91, 148);
            this.lblDurationPatientSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurationPatientSpent.Name = "lblDurationPatientSpent";
            this.lblDurationPatientSpent.Size = new System.Drawing.Size(226, 29);
            this.lblDurationPatientSpent.TabIndex = 25;
            this.lblDurationPatientSpent.Text = "Duration Patient Spent";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTo.Location = new System.Drawing.Point(201, 187);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 19);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFrom.Location = new System.Drawing.Point(16, 187);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 19);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "From";
            // 
            // txtConditionalIllness
            // 
            this.txtConditionalIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtConditionalIllness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConditionalIllness.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtConditionalIllness.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConditionalIllness.Location = new System.Drawing.Point(116, 107);
            this.txtConditionalIllness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConditionalIllness.Multiline = true;
            this.txtConditionalIllness.Name = "txtConditionalIllness";
            this.txtConditionalIllness.PasswordChar = '*';
            this.txtConditionalIllness.Size = new System.Drawing.Size(186, 21);
            this.txtConditionalIllness.TabIndex = 17;
            this.txtConditionalIllness.Text = "Conditional Illness";
            this.txtConditionalIllness.UseSystemPasswordChar = true;
            this.txtConditionalIllness.Enter += new System.EventHandler(this.Conditional_Illness_txt_Enter);
            this.txtConditionalIllness.Leave += new System.EventHandler(this.Conditional_Illness_txt_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 94);
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
            // dateTo
            // 
            this.dateTo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTo.BorderSize = 0;
            this.dateTo.CustomFormat = "dd-MMM-yy";
            this.dateTo.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(201, 209);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTo.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(177, 35);
            this.dateTo.SkinColor = System.Drawing.Color.Tomato;
            this.dateTo.TabIndex = 22;
            this.dateTo.TextColor = System.Drawing.Color.White;
            // 
            // dateFrom
            // 
            this.dateFrom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateFrom.BorderSize = 0;
            this.dateFrom.CustomFormat = "dd-MMM-yy";
            this.dateFrom.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(16, 209);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateFrom.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(177, 35);
            this.dateFrom.SkinColor = System.Drawing.Color.Tomato;
            this.dateFrom.TabIndex = 6;
            this.dateFrom.TextColor = System.Drawing.Color.White;
            this.dateFrom.Value = new System.DateTime(2021, 6, 10, 8, 50, 0, 0);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReportForm_FormClosing);
            this.Load += new System.EventHandler(this.AddReportForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox txtConditionalIllness;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Custom_Controls.CustomDatePicker dateTo;
        private Custom_Controls.CustomDatePicker dateFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblDurationPatientSpent;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckedListBox chechBoxMedecines;
        private System.Windows.Forms.Label lblMedecines;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Label lblAddReport;
        private System.Windows.Forms.ComboBox comboPatientNationalID;
        private System.Windows.Forms.Label lblPatientNationalID;
        private System.Windows.Forms.Label lblConditionalIllness;
        private System.Windows.Forms.Button btnAddQuantity;
    }
}