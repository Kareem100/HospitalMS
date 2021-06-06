using System;
using System.Windows.Forms;

namespace HospitalMS.Forms
{
    public partial class UserDataForm : Form
    {
        public UserDataForm()
        {
            InitializeComponent();
        }

        private void UserDataForm_Load(object sender, EventArgs e)
        {
            dateEmploymentYear.visibleIcon = false;
            dateShiftStarting.visibleIcon = false;
            dateShiftEnding.visibleIcon = false;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("First Name"))
                txtFirstName.Text = "";
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
                txtFirstName.Text = "First Name";
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals("Last Name"))
                txtLastName.Text = "";
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals(""))
                txtLastName.Text = "Last Name";
        }

        private void txtPhones_Enter(object sender, EventArgs e)
        {
            if (txtPhones.Text.Equals("Phones"))
                txtPhones.Text = "";
        }

        private void txtPhones_Leave(object sender, EventArgs e)
        {
            if (txtPhones.Text.Equals(""))
                txtPhones.Text = "Phones";
        }
    }
}
