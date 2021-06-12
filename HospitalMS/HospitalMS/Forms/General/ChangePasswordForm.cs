using HospitalMS.HelperClasses;
using Oracle.DataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class ChangePasswordForm : Form
    {
        // ==================== Rounding Design Edges ==========================//
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
        private Thread thread;
        private OracleConnection conn;
        private HomeForm home;

        public ChangePasswordForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.home = homeForm;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            // For Adding Rounded Edges Around the Form Borders
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
            btnChangePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnChangePassword.Width, btnChangePassword.Height, 30, 30));
            btnCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 30, 30));

            // Establishing a database connection for SCOTT Schema
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();
        }

        //--------------- CHANGE PASSWORD --------------------
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (OldPasswordIsCorrect())
            {
                if (newPasswordIsOk())
                {
                    updatePassword();
                    MessageBox.Show("Your Password Is Updated ..", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    thread = new Thread(openLoginForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    home.Close();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Password..", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------- CANCEL OPERATION -------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //---------------- CHECK OLD PASSWORD ------------------
        private bool OldPasswordIsCorrect()
        {
            String oldPassword = txtOldPassword.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT PASSWORD FROM MEDICAL_STAFF where NATIONALID =:NID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("NID", GlobalData.userNID);
            String password = cmd.ExecuteScalar().ToString();
            if (!password.Equals(oldPassword))
            {
                return false;
            }
            return true;
        }

        //------------------- UPDATE PASSWORD --------------------
        private void updatePassword()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATEPASSWORD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NID", GlobalData.userNID);
            cmd.Parameters.Add("NewPassword", txtNewPassword.Text);
            cmd.ExecuteNonQuery();
        }
        //---------------- CHECK NEW PASSWORD --------------------
        private bool newPasswordIsOk()
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text.Equals("New Password"))
            {
                MessageBox.Show("Please Enter New Password..", "Change Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNewPassword.Text.Length < 3)
            {
                MessageBox.Show("New Password should be at least 3 digits..", "Change Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //---------------- OPEN LOGIN FORM ------------------------
        private void openLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        //--------------- OPEN HOME PAGE--------------------
        private void openHomeForm(object obj)
        {
            Application.Run(new HomeForm());
        }
        //----------------------------------------------------------

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Old Password")
            {
                txtOldPassword.Text = "";
            }
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                txtOldPassword.Text = "Old Password";
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "New Password")
            {
                txtNewPassword.Text = "";
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.Text = "New Password";
            }
        }

    }
}
