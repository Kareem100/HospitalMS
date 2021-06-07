
namespace HospitalMS
{
    partial class DisplayBillsForm
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
            this.lblAddReport = new System.Windows.Forms.Label();
            this.reportViewerBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblAddReport
            // 
            this.lblAddReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddReport.AutoSize = true;
            this.lblAddReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddReport.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddReport.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddReport.Location = new System.Drawing.Point(214, 20);
            this.lblAddReport.Name = "lblAddReport";
            this.lblAddReport.Size = new System.Drawing.Size(186, 40);
            this.lblAddReport.TabIndex = 20;
            this.lblAddReport.Text = "Showing Bills";
            // 
            // reportViewerBill
            // 
            this.reportViewerBill.ActiveViewIndex = -1;
            this.reportViewerBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerBill.AutoScroll = true;
            this.reportViewerBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewerBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewerBill.Location = new System.Drawing.Point(150, 100);
            this.reportViewerBill.Name = "reportViewerBill";
            this.reportViewerBill.ShowCloseButton = false;
            this.reportViewerBill.ShowCopyButton = false;
            this.reportViewerBill.ShowExportButton = false;
            this.reportViewerBill.ShowGotoPageButton = false;
            this.reportViewerBill.ShowGroupTreeButton = false;
            this.reportViewerBill.ShowLogo = false;
            this.reportViewerBill.ShowPageNavigateButtons = false;
            this.reportViewerBill.ShowParameterPanelButton = false;
            this.reportViewerBill.ShowPrintButton = false;
            this.reportViewerBill.ShowRefreshButton = false;
            this.reportViewerBill.ShowTextSearchButton = false;
            this.reportViewerBill.ShowZoomButton = false;
            this.reportViewerBill.Size = new System.Drawing.Size(451, 445);
            this.reportViewerBill.TabIndex = 21;
            this.reportViewerBill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.reportViewerBill.ToolPanelWidth = 180;
            // 
            // DisplayBillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.reportViewerBill);
            this.Controls.Add(this.lblAddReport);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DisplayBillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DisplayBillsForm";
            this.Load += new System.EventHandler(this.DisplayBillsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewerBill;
    }
}