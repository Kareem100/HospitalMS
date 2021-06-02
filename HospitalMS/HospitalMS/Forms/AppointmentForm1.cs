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
    public partial class AppointmentForm1 : Form
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
        public AppointmentForm1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void First_Appointment_txt_Enter(object sender, EventArgs e)
        {
            if (First_Appointment_txt.Text == "First Name") First_Appointment_txt.Text = "";
        }

        private void First_Appointment_txt_Leave(object sender, EventArgs e)
        {
            if (First_Appointment_txt.Text == "") First_Appointment_txt.Text = "First Name";
        }

        private void Second_Appointment_txt_Enter(object sender, EventArgs e)
        {
            if (Second_Appointment_txt.Text == "Last Name") Second_Appointment_txt.Text = "";
        }

        private void Second_Appointment_txt_Leave(object sender, EventArgs e)
        {
            if (Second_Appointment_txt.Text == "") Second_Appointment_txt.Text = "Last Name";
        }

        private void Id_Appointment_txt_Enter(object sender, EventArgs e)
        {
            if (Second_Appointment_txt.Text == "National Id") Second_Appointment_txt.Text = "";
        }

        private void Id_Appointment_txt_Leave(object sender, EventArgs e)
        {
            if (Second_Appointment_txt.Text == "") Second_Appointment_txt.Text = "National Id";
        }

        private void Des_Appointment_txt_Enter(object sender, EventArgs e)
        {
          if (Second_Appointment_txt.Text == "Description") Second_Appointment_txt.Text = "";
        }

        private void Des_Appointment_txt_Leave(object sender, EventArgs e)
        {
            if (Second_Appointment_txt.Text == "") Second_Appointment_txt.Text = "Description";
        }
    }
}
