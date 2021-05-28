using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class RegisterForm : Form
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

        public RegisterForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
            dateEmploymentYear.visibleIcon = false;
            radioDoctor.Checked = true;
            radioMale.Checked = true;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        // ================================= MOUSE ENTER LEAVE EFFECTS ================================= //

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = ""; txtFirstName.ForeColor = Color.Gold;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name"; txtFirstName.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = ""; txtLastName.ForeColor = Color.Gold;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name"; txtLastName.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone Number")
            {
                txtPhone.Text = ""; txtPhone.ForeColor = Color.Gold;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone Number"; txtPhone.ForeColor = Color.WhiteSmoke;
            }
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
                txtPassword.Text = "Password"; txtPassword.ForeColor = Color.WhiteSmoke;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = ""; txtConfirmPassword.ForeColor = Color.Gold;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password"; txtConfirmPassword.ForeColor = Color.WhiteSmoke;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        // ==================== REGISTER PART ==================== //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                // DATABASE PART

                MessageBox.Show("You Have Been Registered Successfully !!", "Congratulations...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isValidData()
        {
            string name = txtFirstName.Text.Trim();
            if (name == "" || name == "First Name" || name == null)
            {
                MessageBox.Show("Please Enter Your First Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            name = txtLastName.Text.Trim();
            if (name == "" || name == "Last Name" || name == null)
            {
                MessageBox.Show("Please Enter Your Last Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string phone = txtPhone.Text.Trim();
            if (phone == "" || phone == "Phone Number" || phone == null)
            {
                MessageBox.Show("Please Enter Your Phone Number...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < phone.Length; ++i)
                if (phone[i] > '9' || phone[i] < '0')
                {
                    MessageBox.Show("Please Enter a Correct Phone Number...", "Invalid Phone Number !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            string pass = txtPassword.Text.Trim();
            if (pass == "" || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string rePass = txtConfirmPassword.Text.Trim();
            if (rePass == "" || rePass == "Confirm Password" || rePass == null)
            {
                MessageBox.Show("Please Confirm Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pass != rePass)
            {
                MessageBox.Show("Passwords Doesn't Match !!", "Missmatch Passwords !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
