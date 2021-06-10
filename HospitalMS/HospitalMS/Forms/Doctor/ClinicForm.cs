using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class ClinicForm : Form
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
        public ClinicForm()
        {
            InitializeComponent();
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void ClinicName_txt_Enter(object sender, EventArgs e)
        {
            if (ClinicName_txt.Text == "Clinic Name")
                ClinicName_txt.Text = "";
        }

        private void ClinicName_txt_Leave(object sender, EventArgs e)
        {
            if (ClinicName_txt.Text == "")
                ClinicName_txt.Text = "Clinic Name";
        }

        private void FloorNumber_txt_Enter(object sender, EventArgs e)
        {
            if (FloorNumber_txt.Text == "Floor Number")
                FloorNumber_txt.Text = "";
        }

        private void FloorNumber_txt_Leave(object sender, EventArgs e)
        {
            if (FloorNumber_txt.Text == "")
                FloorNumber_txt.Text = "Floor Number";
        }

        private void AllClinics_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (AllClinics_Radio.Checked == true)
            {
                AllClinics_Data.Visible = true;
                AllClinics_Data.BringToFront();
            }
            else
            {
                AllClinics_Data.Visible = false;
            }
        }
    }
}
