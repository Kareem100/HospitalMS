using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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

        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        // ================================= MOUSE ENTER&LEAVE EFFECTS ================================= //
        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full Name") { txtFullName.Text = ""; txtFullName.ForeColor = Color.Gold; }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "") { txtFullName.ForeColor = Color.WhiteSmoke; txtFullName.Text = "Full Name"; }
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
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openForm(object obj)
        {
            Application.Run(new RegisterForm());
        }
        // =====================================================================//

        // ========================== LOGIN PART ========================== //
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                // DATABASE PART
                MessageBox.Show("You Have Logged in Successfully !!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (isValidData())
            {
                // DATABASE PART
                MessageBox.Show("You Have Logged in Successfully !!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool isValidData()
        {
            string name = txtFullName.Text.Trim();
            if (name == "" || name == "Full Name" || name == null)
            {
                MessageBox.Show("Please Enter Your Full Name...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string pass = txtPassword.Text.Trim();
            if (pass == "" || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Password...", "INVALID LOGIN !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // =========================================================== //
    }
}
