using System;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using HospitalMS.HelperClasses;
using System.Linq;
using System.Collections.Generic;

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
                groupSpecialization.Enabled = false;
            else
                loadClinics();
            loadUserData();
        }

        // ============================ LOADING DATA ====================== //
        private void loadClinics()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ClinicName FROM clinic";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboClinics.Items.Add(reader[0]);
            reader.Close();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT clinicname FROM medical_stuff WHERE NationalID=:NID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("NID", GlobalData.userNID);
            comboClinics.SelectedValue = cmd.ExecuteScalar().ToString();
        }

        private void loadUserData()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM medical_stuff WHERE NationalID = :nationalID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("nationalID", GlobalData.userNID);

            OracleDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                // --- FIRST/LAST NAME & GENDER ---
                txtFirstName.Text = reader[1].ToString();   // First Name
                txtLastName.Text = reader[2].ToString();    // Last Name
                if (reader[4].ToString().Equals("Male"))    // Gender
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;

                // --- AGE & BIRTHDATE ---
                int age = Convert.ToInt32(reader[5].ToString());
                lblMyAge.Text = age.ToString();
                DateTime birthDate = new DateTime(DateTime.Now.Year-age, DateTime.Now.Month, DateTime.Now.Day);
                dateBirthdate.Value = birthDate;

                // --- EMPLYMENT YEAR ---
                DateTime employmentDate = new DateTime(int.Parse(reader[9].ToString()), 05, 28);
                dateEmploymentYear.Value = employmentDate;

                // --- STARTING/ENDING SHIFT HOUR --
                string startingShift = reader[6].ToString();
                if (!startingShift.Equals("Not Stated"))
                {
                    // --- STARTING SHIFT HOUR --
                    char[] delimiterChars = { ' ', ':' };
                    string[] shiftTime = (startingShift).Split(delimiterChars);
                    int hour = int.Parse(shiftTime[0]);
                    int minute = int.Parse(shiftTime[1]);
                    int tt = 0;
                    if (shiftTime[2] == "PM" && hour != 12) tt = 12;

                    DateTime shiftingHour = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (hour + tt), minute, 0);
                    dateShiftStarting.Value = shiftingHour;

                    // --- ENDING SHIFT HOUR ---
                    shiftTime = (reader[7].ToString()).Split(delimiterChars);
                    hour = int.Parse(shiftTime[0]);
                    minute = int.Parse(shiftTime[1]);
                    tt = 0;
                    if (shiftTime[2] == "PM") tt = 12;

                    shiftingHour = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour + tt, minute, 0);
                    dateShiftEnding.Value = shiftingHour;
                }

                // --- CLINIC ---
                string clinic = reader[10].ToString();
                if (clinic != null)
                    comboClinics.SelectedIndex = comboClinics.Items.IndexOf(clinic);

                // --- CONTACT NUMBERS ---
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

        // ============================ VALIDATION & UPDATE ====================== //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                MedicalStuff medicalStuff = new MedicalStuff();
                medicalStuff.firstName = txtFirstName.Text.Trim();
                medicalStuff.lastName = txtLastName.Text.Trim();
                medicalStuff.gender = groupGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                medicalStuff.age = Convert.ToInt32(lblMyAge.Text);
                medicalStuff.shiftStart = dateShiftStarting.Text;
                medicalStuff.shiftEnd = dateShiftEnding.Text;
                medicalStuff.specialization = GlobalData.userType;
                medicalStuff.employmentYear = Convert.ToInt32(dateEmploymentYear.Text.Trim());
                medicalStuff.clinic = comboClinics.Text.Trim();
                medicalStuff.nationalID = GlobalData.userNID;
                medicalStuff.phones = new List<string>();
                for (int i = 0; i < txtPhones.Lines.Length-1; ++i)
                    medicalStuff.phones.Add(txtPhones.Lines[i].Trim());

                updateMedicalStuff(medicalStuff);
            }
        }

        private bool isValidData()
        {
            // ------- FIRST & LAST NAME
            string name = txtFirstName.Text.Trim();
            if (name == "" || name == "First Name" || name == null)
            {
                MessageBox.Show("Please Enter Your First Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in name)
                if (c <= '9' && c >= '0')
                {
                    MessageBox.Show("First Name Cannot Contains Numbers...", "Invalid Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            name = txtLastName.Text.Trim();
            if (name == "" || name == "Last Name" || name == null)
            {
                MessageBox.Show("Please Enter Your Last Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in name)
                if (c <= '9' && c >= '0')
                {
                    MessageBox.Show("Last Name Cannot Contains Numbers...", "Invalid Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            // ------- CLINIC COMBOBOX
            if (GlobalData.userType == GlobalData.doctorUser && comboClinics.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Your Assigned Clinic...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ------- PHONENUMBER
            string phone = txtPhones.Text.Trim();

            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsNumber(phone[i]))
                {
                    MessageBox.Show("Phone number can't contain letters !");
                    return false;
                }
            }

            if (phone == "" || phone == "Phone Number" || phone == null)
            {
                MessageBox.Show("Please Enter at Least One Phone Number...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < txtPhones.Lines.Length; ++i)
                if (txtPhones.Lines[i].Length % 11 != 0)
                {
                    MessageBox.Show("Egypt Phone Number Should Consists of 11 Digits...", "Invalid Phone Number !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

        private void updateMedicalStuff(MedicalStuff medicalStuff)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "updateMedicalStuff";
                cmd.CommandType = CommandType.StoredProcedure;
            
                // START PARAMETERS
                cmd.Parameters.Add("NID", medicalStuff.nationalID);
                cmd.Parameters.Add("mFirstName", medicalStuff.firstName);
                cmd.Parameters.Add("mLastName", medicalStuff.lastName);
                cmd.Parameters.Add("mGender", medicalStuff.gender);
                cmd.Parameters.Add("mAge", medicalStuff.age);
                cmd.Parameters.Add("mShiftStart", medicalStuff.shiftStart);
                cmd.Parameters.Add("mShiftEnd", medicalStuff.shiftEnd);
                cmd.Parameters.Add("mSpecialization", medicalStuff.specialization);
                cmd.Parameters.Add("mYearOfEmployment", medicalStuff.employmentYear);
                cmd.Parameters.Add("mClinicName", medicalStuff.clinic);
                // END PARAMETERS
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM stuff_contacts WHERE EmployeeID = :EmployeeID";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("EmployeeID", medicalStuff.nationalID);
                cmd.ExecuteNonQuery();
            
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO stuff_contacts VALUES(:NID, :phone)";
                cmd.CommandType = CommandType.Text;
                for (int i = 0; i < medicalStuff.phones.Count; ++i)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("NID", medicalStuff.nationalID);
                    cmd.Parameters.Add("phone", medicalStuff.phones[i]);
                    cmd.ExecuteNonQuery();
                }
            
                MessageBox.Show("Your Data has been Updated Successfully !", "UPDATE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
