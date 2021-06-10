
namespace HospitalMS
{
    partial class DisplayReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayReportsForm));
            this.lblAddReport = new System.Windows.Forms.Label();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.patientid = new System.Windows.Forms.Label();
            this.Evaluate_btn = new System.Windows.Forms.Button();
            this.patientid_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAddReport
            // 
            this.lblAddReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddReport.AutoSize = true;
            this.lblAddReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddReport.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddReport.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddReport.Location = new System.Drawing.Point(233, 9);
            this.lblAddReport.Name = "lblAddReport";
            this.lblAddReport.Size = new System.Drawing.Size(233, 40);
            this.lblAddReport.TabIndex = 18;
            this.lblAddReport.Text = "Showing Reports";
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Location = new System.Drawing.Point(150, 133);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowCloseButton = false;
            this.reportViewer.ShowCopyButton = false;
            this.reportViewer.ShowExportButton = false;
            this.reportViewer.ShowGotoPageButton = false;
            this.reportViewer.ShowGroupTreeButton = false;
            this.reportViewer.ShowLogo = false;
            this.reportViewer.ShowPageNavigateButtons = false;
            this.reportViewer.ShowParameterPanelButton = false;
            this.reportViewer.ShowPrintButton = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowTextSearchButton = false;
            this.reportViewer.ShowZoomButton = false;
            this.reportViewer.Size = new System.Drawing.Size(516, 419);
            this.reportViewer.TabIndex = 19;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // patientid
            // 
            this.patientid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patientid.AutoSize = true;
            this.patientid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patientid.Location = new System.Drawing.Point(167, 102);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(90, 23);
            this.patientid.TabIndex = 21;
            this.patientid.Text = "Patient Id";
            // 
            // Evaluate_btn
            // 
            this.Evaluate_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Evaluate_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Evaluate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Evaluate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evaluate_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Evaluate_btn.Location = new System.Drawing.Point(466, 94);
            this.Evaluate_btn.Name = "Evaluate_btn";
            this.Evaluate_btn.Size = new System.Drawing.Size(183, 31);
            this.Evaluate_btn.TabIndex = 26;
            this.Evaluate_btn.Text = "Generate Report";
            this.Evaluate_btn.UseVisualStyleBackColor = false;
            this.Evaluate_btn.Click += new System.EventHandler(this.Evaluate_btn_Click);
            // 
            // patientid_cmb
            // 
            this.patientid_cmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patientid_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientid_cmb.FormattingEnabled = true;
            this.patientid_cmb.Location = new System.Drawing.Point(275, 96);
            this.patientid_cmb.Name = "patientid_cmb";
            this.patientid_cmb.Size = new System.Drawing.Size(176, 31);
            this.patientid_cmb.TabIndex = 29;
            // 
            // DisplayReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 545);
            this.Controls.Add(this.patientid_cmb);
            this.Controls.Add(this.Evaluate_btn);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.lblAddReport);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DisplayReportsForm";
            this.Text = "DisplayReportsForm";
            this.Load += new System.EventHandler(this.DisplayReportsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.Label patientid;
        private System.Windows.Forms.Button Evaluate_btn;
        private System.Windows.Forms.ComboBox patientid_cmb;
    }
}