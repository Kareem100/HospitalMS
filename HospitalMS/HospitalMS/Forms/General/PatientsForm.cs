using Oracle.DataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class PatientsForm : Form
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

        private string dbConnection;
        private OracleDataAdapter dataAdapter;
        private DataSet dataSet;
        private bool isAllDisplayed;
        private string doctorOldFullName;

        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            btnDisplayAll.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDisplayAll.Width, btnDisplayAll.Height, 30, 30));
            btnFilter.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFilter.Width, btnFilter.Height, 30, 30));
            
            dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            
            displayAllPatients();
            isAllDisplayed = true;
            doctorOldFullName = "";
        }

        // ====================== DATA SET & DGV ====================== //
        private void displayAllPatients()
        {
            string cmdString = "SELECT P.NationalID, P.FirstName, P.LastName, P.RoomNumber, " +
                               "D.FirstName || ' ' || D.LastName AS DOCTOR " +
                               "FROM patient P, medical_staff D WHERE d.nationalid = p.doctorid";
            dataAdapter = new OracleDataAdapter(cmdString, dbConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DGV.DataSource = dataSet.Tables[0];
            DGV.Columns[0].HeaderText = "National ID";
            DGV.Columns[0].Width = 130;
            DGV.Columns[1].HeaderText = "First Name";
            DGV.Columns[1].Width = 60;
            DGV.Columns[2].HeaderText = "Last Name";
            DGV.Columns[2].Width = 60;
            DGV.Columns[3].HeaderText = "Room Number";
            DGV.Columns[3].Width = 70;
            DGV.Columns[4].HeaderText = "Doctor";
        }

        private void filterPatients(string doctorFullName)
        {
            string cmdString = @"SELECT P.NationalID, P.FirstName, P.LastName, P.RoomNumber " +
                                "FROM patient P, medical_staff D " +
                                "WHERE D.nationalid = P.doctorid " +
                                "AND D.firstname || ' ' || D.lastname = :doctorFullName";

            dataAdapter = new OracleDataAdapter(cmdString, dbConnection);
            dataAdapter.SelectCommand.Parameters.Add("doctorFullName", doctorFullName);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DGV.DataSource = dataSet.Tables[0];

            DGV.Columns[0].HeaderText = "National ID";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].HeaderText = "First Name";
            DGV.Columns[1].Width = 80;
            DGV.Columns[2].HeaderText = "Last Name";
            DGV.Columns[2].Width = 80;
            DGV.Columns[3].HeaderText = "Room Number";
        }

        // =================== BUTTONS CLICK EVENTS =================== //
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            if (!isAllDisplayed)
            {
                displayAllPatients();
                isAllDisplayed = true;
            } 
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string doctorNewFullName = txtFullName.Text.Trim();
            if (!doctorOldFullName.Equals(doctorNewFullName))
            {
                filterPatients(doctorNewFullName);
                isAllDisplayed = false;
                doctorOldFullName = doctorNewFullName;
            }
        }

        // ====================== FOCUS EFFECTS ====================== //
        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals("Doctor Full Name"))
                txtFullName.Text = "";
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals(""))
                txtFullName.Text = "Doctor Full Name";
        }

    }
}
