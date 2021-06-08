
namespace HospitalMS
{
    partial class AddBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBillForm));
            this.lblAddBill = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReportIds = new System.Windows.Forms.Label();
            this.lblMedicsOlusAccomodation = new System.Windows.Forms.Label();
            this.lblTotalBillCost = new System.Windows.Forms.Label();
            this.txtTotalBillCost = new System.Windows.Forms.TextBox();
            this.picTotalBillCostBackground = new System.Windows.Forms.PictureBox();
            this.lblTotalMedsCost = new System.Windows.Forms.Label();
            this.txtTotalMedsCost = new System.Windows.Forms.TextBox();
            this.picTotalMedsCostBackground = new System.Windows.Forms.PictureBox();
            this.txtPatientFullname = new System.Windows.Forms.TextBox();
            this.picPatientFullnameBackground = new System.Windows.Forms.PictureBox();
            this.comboReportID = new System.Windows.Forms.ComboBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalBillCostBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalMedsCostBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientFullnameBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddBill
            // 
            this.lblAddBill.AutoSize = true;
            this.lblAddBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddBill.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddBill.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddBill.Location = new System.Drawing.Point(268, 20);
            this.lblAddBill.Name = "lblAddBill";
            this.lblAddBill.Size = new System.Drawing.Size(158, 40);
            this.lblAddBill.TabIndex = 17;
            this.lblAddBill.Text = "Adding Bill";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.lblReportIds);
            this.panelContainer.Controls.Add(this.lblMedicsOlusAccomodation);
            this.panelContainer.Controls.Add(this.lblTotalBillCost);
            this.panelContainer.Controls.Add(this.txtTotalBillCost);
            this.panelContainer.Controls.Add(this.picTotalBillCostBackground);
            this.panelContainer.Controls.Add(this.lblTotalMedsCost);
            this.panelContainer.Controls.Add(this.txtTotalMedsCost);
            this.panelContainer.Controls.Add(this.picTotalMedsCostBackground);
            this.panelContainer.Controls.Add(this.txtPatientFullname);
            this.panelContainer.Controls.Add(this.picPatientFullnameBackground);
            this.panelContainer.Controls.Add(this.comboReportID);
            this.panelContainer.Controls.Add(this.btnAddBill);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 99);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(395, 420);
            this.panelContainer.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Patient Full Name";
            // 
            // lblReportIds
            // 
            this.lblReportIds.AutoSize = true;
            this.lblReportIds.Location = new System.Drawing.Point(158, 20);
            this.lblReportIds.Name = "lblReportIds";
            this.lblReportIds.Size = new System.Drawing.Size(98, 23);
            this.lblReportIds.TabIndex = 37;
            this.lblReportIds.Text = "Report IDs";
            // 
            // lblMedicsOlusAccomodation
            // 
            this.lblMedicsOlusAccomodation.AutoSize = true;
            this.lblMedicsOlusAccomodation.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicsOlusAccomodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMedicsOlusAccomodation.Location = new System.Drawing.Point(142, 280);
            this.lblMedicsOlusAccomodation.Name = "lblMedicsOlusAccomodation";
            this.lblMedicsOlusAccomodation.Size = new System.Drawing.Size(139, 15);
            this.lblMedicsOlusAccomodation.TabIndex = 36;
            this.lblMedicsOlusAccomodation.Text = "(Medics + accomodation)";
            // 
            // lblTotalBillCost
            // 
            this.lblTotalBillCost.AutoSize = true;
            this.lblTotalBillCost.Location = new System.Drawing.Point(146, 258);
            this.lblTotalBillCost.Name = "lblTotalBillCost";
            this.lblTotalBillCost.Size = new System.Drawing.Size(127, 23);
            this.lblTotalBillCost.TabIndex = 35;
            this.lblTotalBillCost.Text = "Total Bill Cost ";
            // 
            // txtTotalBillCost
            // 
            this.txtTotalBillCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtTotalBillCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBillCost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTotalBillCost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalBillCost.Location = new System.Drawing.Point(103, 311);
            this.txtTotalBillCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalBillCost.Multiline = true;
            this.txtTotalBillCost.Name = "txtTotalBillCost";
            this.txtTotalBillCost.ReadOnly = true;
            this.txtTotalBillCost.Size = new System.Drawing.Size(209, 21);
            this.txtTotalBillCost.TabIndex = 34;
            this.txtTotalBillCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalBillCost.UseSystemPasswordChar = true;
            // 
            // picTotalBillCostBackground
            // 
            this.picTotalBillCostBackground.BackColor = System.Drawing.Color.Transparent;
            this.picTotalBillCostBackground.Image = ((System.Drawing.Image)(resources.GetObject("picTotalBillCostBackground.Image")));
            this.picTotalBillCostBackground.Location = new System.Drawing.Point(90, 298);
            this.picTotalBillCostBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picTotalBillCostBackground.Name = "picTotalBillCostBackground";
            this.picTotalBillCostBackground.Size = new System.Drawing.Size(232, 44);
            this.picTotalBillCostBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTotalBillCostBackground.TabIndex = 33;
            this.picTotalBillCostBackground.TabStop = false;
            // 
            // lblTotalMedsCost
            // 
            this.lblTotalMedsCost.AutoSize = true;
            this.lblTotalMedsCost.Location = new System.Drawing.Point(139, 173);
            this.lblTotalMedsCost.Name = "lblTotalMedsCost";
            this.lblTotalMedsCost.Size = new System.Drawing.Size(138, 23);
            this.lblTotalMedsCost.TabIndex = 32;
            this.lblTotalMedsCost.Text = "Total Meds Cost";
            // 
            // txtTotalMedsCost
            // 
            this.txtTotalMedsCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtTotalMedsCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalMedsCost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTotalMedsCost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalMedsCost.Location = new System.Drawing.Point(103, 212);
            this.txtTotalMedsCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalMedsCost.Multiline = true;
            this.txtTotalMedsCost.Name = "txtTotalMedsCost";
            this.txtTotalMedsCost.ReadOnly = true;
            this.txtTotalMedsCost.Size = new System.Drawing.Size(209, 21);
            this.txtTotalMedsCost.TabIndex = 31;
            this.txtTotalMedsCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalMedsCost.UseSystemPasswordChar = true;
            // 
            // picTotalMedsCostBackground
            // 
            this.picTotalMedsCostBackground.BackColor = System.Drawing.Color.Transparent;
            this.picTotalMedsCostBackground.Image = ((System.Drawing.Image)(resources.GetObject("picTotalMedsCostBackground.Image")));
            this.picTotalMedsCostBackground.Location = new System.Drawing.Point(90, 199);
            this.picTotalMedsCostBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picTotalMedsCostBackground.Name = "picTotalMedsCostBackground";
            this.picTotalMedsCostBackground.Size = new System.Drawing.Size(232, 44);
            this.picTotalMedsCostBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTotalMedsCostBackground.TabIndex = 30;
            this.picTotalMedsCostBackground.TabStop = false;
            // 
            // txtPatientFullname
            // 
            this.txtPatientFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtPatientFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientFullname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPatientFullname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientFullname.Location = new System.Drawing.Point(103, 127);
            this.txtPatientFullname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPatientFullname.Multiline = true;
            this.txtPatientFullname.Name = "txtPatientFullname";
            this.txtPatientFullname.ReadOnly = true;
            this.txtPatientFullname.Size = new System.Drawing.Size(209, 21);
            this.txtPatientFullname.TabIndex = 29;
            this.txtPatientFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatientFullname.UseSystemPasswordChar = true;
            // 
            // picPatientFullnameBackground
            // 
            this.picPatientFullnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picPatientFullnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picPatientFullnameBackground.Image")));
            this.picPatientFullnameBackground.Location = new System.Drawing.Point(90, 114);
            this.picPatientFullnameBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPatientFullnameBackground.Name = "picPatientFullnameBackground";
            this.picPatientFullnameBackground.Size = new System.Drawing.Size(232, 44);
            this.picPatientFullnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPatientFullnameBackground.TabIndex = 28;
            this.picPatientFullnameBackground.TabStop = false;
            // 
            // comboReportID
            // 
            this.comboReportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.comboReportID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboReportID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReportID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboReportID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboReportID.FormattingEnabled = true;
            this.comboReportID.Location = new System.Drawing.Point(103, 46);
            this.comboReportID.Name = "comboReportID";
            this.comboReportID.Size = new System.Drawing.Size(209, 27);
            this.comboReportID.TabIndex = 17;
            this.comboReportID.SelectedIndexChanged += new System.EventHandler(this.comboPatientNationalID_SelectedIndexChanged);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBill.Enabled = false;
            this.btnAddBill.FlatAppearance.BorderSize = 0;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.btnAddBill.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddBill.Location = new System.Drawing.Point(90, 359);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(232, 40);
            this.btnAddBill.TabIndex = 27;
            this.btnAddBill.Text = "ADD BILL";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblAddBill);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddBillForm";
            this.Text = "BillForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillForm_FormClosing);
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalBillCostBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalMedsCostBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientFullnameBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBill;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ComboBox comboReportID;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.TextBox txtPatientFullname;
        private System.Windows.Forms.PictureBox picPatientFullnameBackground;
        private System.Windows.Forms.Label lblTotalMedsCost;
        private System.Windows.Forms.TextBox txtTotalMedsCost;
        private System.Windows.Forms.PictureBox picTotalMedsCostBackground;
        private System.Windows.Forms.Label lblMedicsOlusAccomodation;
        private System.Windows.Forms.Label lblTotalBillCost;
        private System.Windows.Forms.TextBox txtTotalBillCost;
        private System.Windows.Forms.PictureBox picTotalBillCostBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReportIds;
    }
}