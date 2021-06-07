using System;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using HospitalMS.HelperClasses;

namespace HospitalMS.Forms
{
    public partial class UserDataForm : Form
    {
        private OracleConnection conn;

        public UserDataForm()
        {
            InitializeComponent();
        }

        private void UserDataForm_Load(object sender, EventArgs e)
        {
            dateEmploymentYear.visibleIcon = false;
            dateShiftStarting.visibleIcon = false;
            dateShiftEnding.visibleIcon = false;

            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();

            if (GlobalData.userType.Equals(GlobalData.receptionistUser))
            {
                groupSpecialization.Enabled = false;
            }
            else
                loadClinics();
            loadData();
        }

        private void loadClinics()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT clinicname FROM medical_stuff WHERE ClinicName is not null";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboClinics.Items.Add(reader[0].ToString());
            reader.Close();
        }

        private void loadData()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM medical_stuff WHERE NationalID = :nationalID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("nationalID", GlobalData.userNID);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtFirstName.Text = reader[1].ToString();   // First Name
                txtLastName.Text = reader[2].ToString();    // Last Name
                if (reader[4].ToString().Equals("Male"))    // Gender
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;
                int age = Convert.ToInt32(reader[5].ToString());
                lblMyAge.Text = age.ToString();
                DateTime birthDate = new DateTime(DateTime.Now.Year-age, DateTime.Now.Month, DateTime.Now.Day);
                dateBirthdate.Value = birthDate;
                //dateShiftStarting.Value = Convert.ToDateTime(reader[6].ToString());
                //dateShiftEnding.Value = Convert.ToDateTime(reader[7].ToString());
                DateTime employmentDate = new DateTime(int.Parse(reader[9].ToString()), 05, 28);
                dateEmploymentYear.Value = employmentDate;              
                string clinic = reader[10].ToString();
                if (clinic != null)
                    comboClinics.SelectedIndex = comboClinics.Items.IndexOf(clinic);

                cmd.CommandText = "SELECT ContactNumber FROM stuff_contacts WHERE employeeid = :nationalID";
                reader = cmd.ExecuteReader();
                txtPhones.Text = "";
                while (reader.Read())
                    txtPhones.Text += reader[0].ToString() + "\n";
            }
            else
                MessageBox.Show("Mismatch Data !\nSomething went Wrong.", "LOAD USER DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        // ============================ FOCUS & EFFECTS ====================== //
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

        private void dateBirthdate_ValueChanged(object sender, EventArgs e)
        {
            lblMyAge.Text = Convert.ToString((DateTime.Now.Year - dateBirthdate.Value.Year));
        }

        private void UserDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
        // ===================================================================== //
    }
}
