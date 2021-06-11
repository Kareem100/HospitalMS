
namespace HospitalMS
{
    partial class PatientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            this.lblShowingPatients = new System.Windows.Forms.Label();
            this.panelFiltersContainer = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.picFullnameBackground = new System.Windows.Forms.PictureBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.panelFiltersContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullnameBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowingPatients
            // 
            this.lblShowingPatients.AutoSize = true;
            this.lblShowingPatients.BackColor = System.Drawing.Color.Transparent;
            this.lblShowingPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowingPatients.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShowingPatients.ForeColor = System.Drawing.Color.Crimson;
            this.lblShowingPatients.Location = new System.Drawing.Point(242, 28);
            this.lblShowingPatients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowingPatients.Name = "lblShowingPatients";
            this.lblShowingPatients.Size = new System.Drawing.Size(239, 40);
            this.lblShowingPatients.TabIndex = 19;
            this.lblShowingPatients.Text = "Showing Patients";
            // 
            // panelFiltersContainer
            // 
            this.panelFiltersContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltersContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelFiltersContainer.Controls.Add(this.btnDisplayAll);
            this.panelFiltersContainer.Controls.Add(this.btnFilter);
            this.panelFiltersContainer.Controls.Add(this.lblDisplay);
            this.panelFiltersContainer.Controls.Add(this.txtFullName);
            this.panelFiltersContainer.Controls.Add(this.picFullnameBackground);
            this.panelFiltersContainer.Location = new System.Drawing.Point(150, 100);
            this.panelFiltersContainer.Name = "panelFiltersContainer";
            this.panelFiltersContainer.Size = new System.Drawing.Size(424, 71);
            this.panelFiltersContainer.TabIndex = 20;
            // 
            // DGV
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle28;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.Crimson;
            this.DGV.Location = new System.Drawing.Point(148, 189);
            this.DGV.Name = "DGV";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.RowTemplate.DividerHeight = 2;
            this.DGV.RowTemplate.Height = 35;
            this.DGV.Size = new System.Drawing.Size(426, 331);
            this.DGV.TabIndex = 21;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFullName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.Location = new System.Drawing.Point(35, 37);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(165, 24);
            this.txtFullName.TabIndex = 22;
            this.txtFullName.Text = "Doctor Full Name";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // picFullnameBackground
            // 
            this.picFullnameBackground.BackColor = System.Drawing.Color.Transparent;
            this.picFullnameBackground.Image = ((System.Drawing.Image)(resources.GetObject("picFullnameBackground.Image")));
            this.picFullnameBackground.Location = new System.Drawing.Point(18, 32);
            this.picFullnameBackground.Name = "picFullnameBackground";
            this.picFullnameBackground.Size = new System.Drawing.Size(194, 35);
            this.picFullnameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFullnameBackground.TabIndex = 23;
            this.picFullnameBackground.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(17, 12);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(195, 19);
            this.lblDisplay.TabIndex = 24;
            this.lblDisplay.Text = "Display Patients With Doctor";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.Location = new System.Drawing.Point(238, 38);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(180, 29);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter Patients";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDisplayAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayAll.FlatAppearance.BorderSize = 0;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAll.Location = new System.Drawing.Point(238, 5);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(180, 29);
            this.btnDisplayAll.TabIndex = 26;
            this.btnDisplayAll.Text = "Display All Patients";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panelFiltersContainer);
            this.Controls.Add(this.lblShowingPatients);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.panelFiltersContainer.ResumeLayout(false);
            this.panelFiltersContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullnameBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowingPatients;
        private System.Windows.Forms.Panel panelFiltersContainer;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.PictureBox picFullnameBackground;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDisplayAll;
    }
}