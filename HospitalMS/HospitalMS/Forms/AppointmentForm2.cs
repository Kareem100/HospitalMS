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
    public partial class AppointmentForm2 : Form
    {// ========================== Rounding Edges ==========================//
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

        public AppointmentForm2()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void PatientID_txt_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PatientID_txt_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PatientID_txt_Enter(object sender, EventArgs e)
        {
            if(PatientID_txt.Text== "Patient Id")
               PatientID_txt.Text = "";
        }

        private void PatientID_txt_Leave(object sender, EventArgs e)
        {
            if (PatientID_txt.Text == "")
                PatientID_txt.Text = "Patient Id";
        }
    }

}
