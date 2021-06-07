using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class RoomForm : Form
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

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        // VALIDATE THE STATUS (IF THE NUMBER OF BEDS  == TAKEN BEDS)
        // THEN STATUS = GlobalData.roomFull
        // ELSE STATUS = GlobalData.roomAvailable

        private void btnPreviousRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnNextRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
