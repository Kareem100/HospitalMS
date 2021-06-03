using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class AddReportForm : Form
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
        public AddReportForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void Conditional_Illness_txt_Enter(object sender, EventArgs e)
        {
            if (Conditional_Illness_txt.Text == "Conditional Illness") Conditional_Illness_txt.Text = "";
        }

        private void Conditional_Illness_txt_Leave(object sender, EventArgs e)
        {
            if (Conditional_Illness_txt.Text == "") Conditional_Illness_txt.Text = "Conditional Illness";
        }
    }
}
