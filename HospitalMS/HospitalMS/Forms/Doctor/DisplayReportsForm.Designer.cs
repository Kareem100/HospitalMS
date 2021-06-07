
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
            this.SuspendLayout();
            // 
            // lblAddReport
            // 
            this.lblAddReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddReport.AutoSize = true;
            this.lblAddReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddReport.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddReport.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddReport.Location = new System.Drawing.Point(177, 20);
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
            this.reportViewer.Location = new System.Drawing.Point(150, 100);
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
            this.reportViewer.Size = new System.Drawing.Size(449, 445);
            this.reportViewer.TabIndex = 19;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DisplayReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.lblAddReport);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DisplayReportsForm";
            this.Text = "DisplayReportsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
    }
}