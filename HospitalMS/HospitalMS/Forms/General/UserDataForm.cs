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
    }
}
