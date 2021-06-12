using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HospitalMS
{
    public partial class CustomMessageBox2 : Form
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

        public static int code;
        private static string name;
        public static int quantity;
        private static AddReportForm form;

        public CustomMessageBox2()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            lblCode.Text = code.ToString();
            lblMedicine.Text = name;
            quantity = -1;
            TopMost = true;
            TopLevel = true;
        }

        internal static void Show(AddReportForm reportForm, int MedicineCode, string MedicineName)
        {
            form = reportForm;
            code = MedicineCode;
            name = MedicineName;
            CustomMessageBox2 messageBox = new CustomMessageBox2();
            messageBox.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string quan = txtQuantity.Text.Trim();
            if (quan.Any(x => char.IsLetter(x)) || quan.Equals("0") || quan.Equals("Quantity"))
                lblError.Visible = true;
            else
            {
                code = Convert.ToInt32(lblCode.Text);
                quantity = Convert.ToInt32(quan);
                form.setQuantity(code, quantity);
                form.enableAddReportButton();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            quantity = -1;
            form.disableAddReportButton();
            Close();
        }


        // ================= FOCUS (ENTER/LEAVE) EFFECTS & Close ================= // 
        private void pictureClose_Click(object sender, EventArgs e)
        {
            form.disableAddReportButton();
            Close();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals("Quantity"))
                txtQuantity.Text = "";
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
                txtQuantity.Text = "Quantity";
        }
    }
}
