using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HospitalMS
{
    public partial class MedicineForm : Form
    {
        public MedicineForm()
        {
            InitializeComponent();
        }
        private OracleDataAdapter dataAdapter;
        private OracleCommandBuilder commandBuilder;
        private DataSet DataSet;
       
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            string strconn = "Data Source=orcl; User Id=scott;Password=tiger;";
            string cmdtring = "select * from MEDICINE";
            dataAdapter = new OracleDataAdapter(cmdtring, strconn);
            DataSet = new DataSet();
            dataAdapter.Fill(DataSet);
            DGV.DataSource = DataSet.Tables[0];

            DGV.Columns[0].HeaderText = "Code";
            DGV.Columns[1].HeaderText = "Medicine Name";
            DGV.Columns[2].HeaderText = "Price";
            DGV.Columns[3].HeaderText = "Quantity";



        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            commandBuilder = new OracleCommandBuilder(dataAdapter);
            dataAdapter.Update(DataSet.Tables[0]);
            MessageBox.Show("updated succefully.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
