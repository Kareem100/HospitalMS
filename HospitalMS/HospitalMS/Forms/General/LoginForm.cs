using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;
using HospitalMS.HelperClasses;

namespace HospitalMS
{
    public partial class LoginForm : Form
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

        private Thread thread;
        private OracleConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));

            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        // ================================= MOUSE ENTER&LEAVE EFFECTS ================================= //
        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if (txtNationalID.Text == "National ID") { txtNationalID.Text = ""; txtNationalID.ForeColor = Color.Gold; }
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if (txtNationalID.Text == "") { txtNationalID.ForeColor = Color.WhiteSmoke; txtNationalID.Text = "National ID"; }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = ""; txtPassword.ForeColor = Color.Gold;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.WhiteSmoke; txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 1;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            thread = new Thread(openRegisterForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openRegisterForm(object obj)
        {
            Application.Run(new RegisterForm());
        }

        private void openHomeForm(object obj)
        {
            Application.Run(new HomeForm());
        }

        private void txtNationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        // =====================================================================//

        // ========================== LOGIN PART ========================== //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                string nationalID = txtNationalID.Text;
                string password = txtPassword.Text;
                vertifyUser(nationalID, password);
            }

            resetFields();
        }
        private bool isValidData()
        {
            string name = txtNationalID.Text.Trim();
            if (name == "" || name == "National ID" || name == null)
            {
                MessageBox.Show("Please Enter Your National ID...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string pass = txtPassword.Text.Trim();
            if (pass.Length < 3 || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Valid Password...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void vertifyUser(string nationalID, string password)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT FirstName, LastName, specialization FROM medical_staff WHERE NationalID = :nationalID AND Password = :password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("nationalID", nationalID);
            cmd.Parameters.Add("password", password);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                GlobalData.userFullName = reader[0].ToString() + " " + reader[1].ToString();
                GlobalData.userNID = nationalID;
                MessageBox.Show("You Have Logged in Successfully !!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (reader[2].ToString().Equals(GlobalData.doctorUser))
                    GlobalData.userType = GlobalData.doctorUser;
                else
                    GlobalData.userType = GlobalData.receptionistUser;

                reader.Close();
                thread = new Thread(openHomeForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Close();
            }
            else
                MessageBox.Show("No Such User Exist. !!\nMaybe You Need to Register.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void resetFields()
        {
            txtNationalID.Text = "National ID";
            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = true;
        }
        // =========================================================== //

    }
}
