using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class AppointmentForm : Form
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
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));

        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Equals("First Name"))
                txtFirstname.Text = "";
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Equals(""))
                txtFirstname.Text = "First Name";
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            if (txtLastname.Text.Equals("Last Name"))
                txtLastname.Text = "";
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text.Equals(""))
                txtLastname.Text = "Last Name";
        }

        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals("National ID"))
                txtNationalID.Text = "";
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals(""))
                txtNationalID.Text = "National ID";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals("Description"))
                txtDescription.Text = "";
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals(""))
                txtDescription.Text = "Description";
        }
    }
}
