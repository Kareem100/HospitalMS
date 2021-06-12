using HospitalMS.Forms;
using HospitalMS.HelperClasses;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class HomeForm : Form
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

        private Form activeForm = null;
        private Thread thread;
        private bool isRegion;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            btnShowReports.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShowReports.Width, btnShowReports.Height, 30, 30));
            isRegion = true;
            
            lblUserName.Text = "";
            string[] names = GlobalData.userFullName.Split(' ');
            lblUserName.Text = names[0][0] + "." + names[1];
            if (GlobalData.userType == GlobalData.doctorUser)
            {
                btnAppointment.Visible = false;
                btnBill.Visible = false;
                btnShowRooms.Visible = false;
                lblDoctorReceptionist.Text = "Doctor";
            }
            else if (GlobalData.userType == GlobalData.receptionistUser)
            {
                btnClinic.Visible = false;
                btnReports.Visible = false;
                btnShowReports.Text = "Show Bills";
                lblDoctorReceptionist.Text = "Recept";
            }
        }

        /********************* PICTURE BUTTONS **************************/
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            if (panelSettingsContextMenu.Visible == false)
            {
                panelSettingsContextMenu.Visible = true;
                panelSettingsHolder.Visible = true;
                panelSettingsContextMenu.BringToFront();
                picSettings.BackColor = Color.Crimson;
            }
            else
            {
                panelSettingsContextMenu.Visible = false;
                panelSettingsHolder.Visible = false;
                picSettings.BackColor = Color.Transparent;
            }
        }
        /****************************************************************/

        /***************** BUTTONS CLICK EVENTS**************************/
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            highlightSelectedButton(btnHome);
            resetContextMenus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            openForm(new UserDataForm());
            highlightSelectedButton(btnData);
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            openForm(new ClinicForm());
            highlightSelectedButton(btnClinic);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            openForm(new AddReportForm());
            highlightSelectedButton(btnReports);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            openForm(new AppointmentForm());
            highlightSelectedButton(btnAppointment);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            openForm(new AddBillForm());
            highlightSelectedButton(btnBill);
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            openForm(new RoomForm());
            highlightSelectedButton(btnShowRooms);
        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            if (GlobalData.userType == GlobalData.doctorUser)
                openForm(new DisplayReportsForm());
            else
                openForm(new DisplayBillsForm());

            Region = null;
            isRegion = false;
            WindowState = FormWindowState.Maximized;
            resetContextMenus();
        }

        private void btnChangeNID_Click(object sender, EventArgs e)
        {
            // openForm(new FormName());
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //openForm(new ChangePasswordForm());
            openForm(new ChangePasswordForm(this));
            resetContextMenus();

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            openForm(new MedicineForm());
            resetContextMenus();

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            openForm(new PatientsForm());
            resetContextMenus();

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            thread = new Thread(openThread);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openThread(object obj)
        {
            Application.Run(new LoginForm());
        }
        /****************************************************************/

        /******************TRANSITION & EFFECTS *************************/
        private void highlightSelectedButton(Button selectedButton)
        {
            foreach (Control b in panelButtonsNavigation.Controls)
                if (b == selectedButton)
                {
                    panelSidebar.Top = b.Top;
                    b.ForeColor = Color.Crimson;
                }
                else if (b is Button)
                    b.ForeColor = Color.WhiteSmoke;

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void resetContextMenus()
        {
            panelSettingsHolder.Visible = false;
            panelSettingsContextMenu.Visible = false;
            picSettings.BackColor = Color.Transparent;
        }

        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildContainer.Controls.Add(childForm);
            panelChildContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            resetContextMenus();
        }
        /****************************************************************/

    }
}
