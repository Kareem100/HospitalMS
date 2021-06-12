using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using HospitalMS.HelperClasses;

namespace HospitalMS
{
    public partial class ClinicForm : Form
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
        private string doctorNID;
        private string clinicName;
        private string floorNumber;
        private string startTime;
        private string endTime;
        private DataTable clinicTable;

        public ClinicForm()
        {
            InitializeComponent();
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void ClinicName_txt_Enter(object sender, EventArgs e)
        {
            if (ClinicName_txt.Text == "Clinic Name")
                ClinicName_txt.Text = "";
        }

        private void ClinicName_txt_Leave(object sender, EventArgs e)
        {
            if (ClinicName_txt.Text == "")
                ClinicName_txt.Text = "Clinic Name";
        }

        private void FloorNumber_txt_Enter(object sender, EventArgs e)
        {
            if (FloorNumber_txt.Text == "Floor Number")
                FloorNumber_txt.Text = "";
        }

        private void FloorNumber_txt_Leave(object sender, EventArgs e)
        {
            if (FloorNumber_txt.Text == "")
                FloorNumber_txt.Text = "Floor Number";
        }

        private void ClinicForm_Load(object sender, EventArgs e)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();

            doctorNID = GlobalData.userNID; //get current logged in doctor
            clinicName = " ";
            floorNumber = " ";
            startTime = " ";
            endTime = " ";
            clinicTable = new DataTable();
            clinicTable.Columns.Add("clinic name");
            clinicTable.Columns.Add("floor number");
            clinicTable.Columns.Add("start time");
            clinicTable.Columns.Add("end time");

            if (OneClinic_Radio.Checked == true)
            {
                getOneClinic();
            }
        }

        private void OneClinic_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (OneClinic_Radio.Checked == true)
            {
                getOneClinic();
            }
        }

        private void AllClinics_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (AllClinics_Radio.Checked == true)
            {
                getAllClinics();
                AllClinics_Data.DataSource = clinicTable;
                AllClinics_Data.Visible = true;
                AllClinics_Data.BringToFront();
            }
            else
            {
                AllClinics_Data.Visible = false;
            }
        }

        private void getOneClinic()
        {
            if (clinicExist())
            {
                getClinicName();
                getClinicInfo();
                ClinicName_txt.Text = clinicName;
                FloorNumber_txt.Text = floorNumber;
                txtFrom.Text = startTime;
                txtTo.Text = endTime;
            }
            else
                MessageBox.Show("you are not assigned to a clinic yet");
        }

        private bool clinicExist()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(clinicname) from medical_staff where nationalid =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", doctorNID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        private void getClinicName()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select clinicname from medical_staff where nationalid =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", doctorNID);
            clinicName = cmd.ExecuteScalar().ToString();
        }

        private void getClinicInfo()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from clinic where clinicname =:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", clinicName);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                floorNumber = dr["floornumber"].ToString();
                startTime = dr["workingstarttime"].ToString();
                endTime = dr["workingendtime"].ToString();
            }
            dr.Close();
        }

        private void getAllClinics()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getClinics";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("clinics", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataRow row = clinicTable.NewRow();
                row["clinic name"] = dr["clinicname"];
                row["floor number"] = dr["floornumber"];
                row["start time"] = dr["workingstarttime"];
                row["end time"] = dr["workingendtime"];
                clinicTable.Rows.Add(row);
            }
            dr.Close();
        }

    }
}
