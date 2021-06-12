using HospitalMS.HelperClasses;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class AppointmentForm : Form
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
        private OracleConnection conn;
        private List<double> DoctorsIDS = new List<double>();

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();
            getDoctorsNames();
            getAvailableRooms();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            int AppointmentId = getMaxID() + 1;
            string ReceptionistId = GlobalData.userNID;
            if (!checkNumberOfCharactersOfInputs())
            {
                // Do nothing
            }
            else if (IsValid())
            {
                if (!PatientIsExist())
                {
                    insertPatientData();
                    insertAppointmentData(AppointmentId, ReceptionistId);
                }
                else
                {
                    MessageBox.Show("Patient Already Have An Appointment..", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Data..", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------- GET DOCTORS IDS ----------------------
        private double getDoctorID()
        {
            int IndexOfName = comboDoctors.SelectedIndex;
            double DoctorId = DoctorsIDS[IndexOfName];
            return DoctorId;
        }

        //------------ GET DOCTORS NAMES --------------------
        private void getDoctorsNames()
        {
            String FullName;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NATIONALID ,FIRSTNAME ,LASTNAME FROM MEDICAL_STAFF WHERE specialization = 'Doctor'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DoctorsIDS.Add(double.Parse(reader[0].ToString()));
                FullName = reader[1].ToString() + " " + reader[2].ToString();
                comboDoctors.Items.Add(FullName);
            }
            reader.Close();
        }

        //----------- GET AVAILABLE ROOMS -----------------
        private void getAvailableRooms()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ROOMNUMBER FROM ROOM where NUMBEROFTAKENBEDS < NUMBEROFALLBEDS";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboRooms.Items.Add(reader[0].ToString());
            reader.Close();
        }

        //------------- CHECK PATIENT --------------------
        private bool PatientIsExist()
        {
            string PatientId = txtNationalID.Text;
            List<string> IDS = new List<string>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NATIONALID FROM PATIENT";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                IDS.Add(reader[0].ToString());
            }

            for (int i = 0; i < IDS.Count; i++)
            {
                if (IDS[i].Equals(PatientId))
                {
                    return true;
                }
            }
            return false;
        }

        //------------ INSERT PATIENT DATA -------------------
        private void insertPatientData()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERTPATIENT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("NID", txtNationalID.Text);
            cmd.Parameters.Add("FirstName", txtFirstname.Text);
            cmd.Parameters.Add("LastName", txtLastname.Text);
            cmd.Parameters.Add("RoomNum", comboRooms.SelectedItem);
            cmd.Parameters.Add("DoctorID", getDoctorID());
            cmd.ExecuteNonQuery();      
        }

        //------------ SET APPOINTMENT ID --------------------
        private int getMaxID()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX(APPOINTMENTID) FROM APPOINTMENT";
            cmd.CommandType = CommandType.Text;
            int maxID;
            try
            {
                maxID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                maxID = 79;
            }
            return maxID;
        }

        //------------ INSERT APPOINTMENT --------------------
        private void insertAppointmentData(int AppointmentId, string ReceptionistId)
        {
            string FirstName = txtFirstname.Text;
            string LastName = txtLastname.Text;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERTAPPOINTMENT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("AppointmentId", AppointmentId);
            cmd.Parameters.Add("Description", txtDescription.Text);
            cmd.Parameters.Add("PatientID", txtNationalID.Text);
            cmd.Parameters.Add("ReceptionistID", ReceptionistId);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Appointment For Patient " + FirstName +" "+ LastName + " has been Added Successfully !", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateNumberOfTakenBeds(int.Parse(comboRooms.SelectedItem.ToString()));
        }

        //----------- INCREASE NUMBER OF TAKEN BEDS --------------
        private void updateNumberOfTakenBeds( int NumberOfRoom)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATETAKENBEDS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("RoomNum", NumberOfRoom);
            int res = cmd.ExecuteNonQuery();
        }

        //------------ CHECK VALIDATION--------------------
        private bool IsValid()
        {
            if(string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
              string.IsNullOrWhiteSpace(txtNationalID.Text) || string.IsNullOrWhiteSpace(txtDescription.Text)||
              comboDoctors.SelectedItem == null || comboRooms.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

	private bool checkNumberOfCharactersOfInputs()
        {
            if (!checkIfMoreThan20(txtFirstname.Text.ToString(), "First Name"))
            {
                return false;
            }
            else if (!checkIfMoreThan20(txtLastname.Text.ToString(), "Last Name"))
            {
                return false;
            }
            else if (!checkIfMoreThan20(txtDescription.Text.ToString(), "Description"))
            {
                return false;
            }
            return true;
        }

        private bool checkIfMoreThan20(string name, string label)
        {
            if (name.Length > 20)
            {
                MessageBox.Show("You can't add more than 20 characters in " + label, "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //---------- Validate NationalID (Should be 14 digits and only numbers)------------
        private void txtNationalID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {   
            if (!Regex.IsMatch(txtNationalID.Text, @"^\d+$"))
            {
                MessageBox.Show("National Id should be only numbers..", "National Id Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalID.Text.Remove(txtNationalID.Text.Length - 1);
            }
            else if(txtNationalID.Text.Length != 14)
            {
                MessageBox.Show("National Id should be 14 digits..", "National Id Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //-----------------------------------------------------
        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Equals("First Name"))
                txtFirstname.Text = "";
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Equals(""))
                txtFirstname.Text = "First Name";
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            if (txtLastname.Text.Equals("Last Name"))
                txtLastname.Text = "";
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text.Equals(""))
                txtLastname.Text = "Last Name";
        }

        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals("National ID"))
                txtNationalID.Text = "";
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Equals(""))
                txtNationalID.Text = "National ID";
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals("Description"))
                txtDescription.Text = "";
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals(""))
                txtDescription.Text = "Description";
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
