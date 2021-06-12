using System;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace HospitalMS
{
    public partial class MedicineForm : Form
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

        public MedicineForm()
        {
            InitializeComponent();
        }
        private OracleDataAdapter dataAdapter;
        private OracleCommandBuilder commandBuilder;
        private DataSet DataSet;
       
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            string cmdtring = "select * from MEDICINE";
            dataAdapter = new OracleDataAdapter(cmdtring, dbConnection);
            DataSet = new DataSet();
            dataAdapter.Fill(DataSet);
            DGV.DataSource = DataSet.Tables[0];

            DGV.Columns[0].HeaderText = "Code";
            DGV.Columns[1].HeaderText = "Medicine Name";
            DGV.Columns[2].HeaderText = "Price";
            DGV.Columns[3].HeaderText = "Quantity";
            DGV.Columns[0].ReadOnly = true;
            Save_btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Save_btn.Width, Save_btn.Height, 30, 30));
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            commandBuilder = new OracleCommandBuilder(dataAdapter);
            dataAdapter.Update(DataSet.Tables[0]);
            MessageBox.Show("Data Updated Succeffully.", "MEDICINE CHANGES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
