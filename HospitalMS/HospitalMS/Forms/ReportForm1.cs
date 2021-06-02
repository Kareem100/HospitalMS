using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class ReportForm1 : Form
    {
        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        // =====================================================================//
        public ReportForm1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void Patient_Id_txt_Enter(object sender, EventArgs e)
        {
            if (Patient_Id_txt.Text == "Patient Id") Patient_Id_txt.Text = "";
        }

        private void Patient_Id_txt_Leave(object sender, EventArgs e)
        {
            if (Patient_Id_txt.Text == "") Patient_Id_txt.Text = "Patient Id";
        }

        private void Conditional_Illness_txt_Enter(object sender, EventArgs e)
        {
            if (Patient_Id_txt.Text == "Conditional Illness") Patient_Id_txt.Text = "";
        }

        private void Conditional_Illness_txt_Leave(object sender, EventArgs e)
        {
            if (Patient_Id_txt.Text == "") Patient_Id_txt.Text = "Conditional Illness";
        }
    }
}
