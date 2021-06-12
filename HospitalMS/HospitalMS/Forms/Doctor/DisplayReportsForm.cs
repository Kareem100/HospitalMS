using System.Windows.Forms;
using HospitalMS.CrystalReports;
using CrystalDecisions.Shared;

namespace HospitalMS
{
    public partial class DisplayReportsForm : Form
    {
        private ReportData ReportData;
        public DisplayReportsForm()
        {
            InitializeComponent();
        }

        private void DisplayReportsForm_Load(object sender, System.EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            ReportData = new ReportData();
            ReportData.Refresh();
            ReportData.SetDatabaseLogon("scott", "tiger");
            reportViewer.ReportSource = ReportData;
            ReportData.SetParameterValue(1, true);
            ReportData.SetParameterValue(0, patientid_cmb.Text);
            foreach (ParameterDiscreteValue value in ReportData.ParameterFields[0].DefaultValues)
                patientid_cmb.Items.Add(value.Value);
        }

        private void Evaluate_btn_Click(object sender, System.EventArgs e)
        {
            if (patientid_cmb.SelectedItem != null)
            {
                ReportData.SetParameterValue(1, false);
                ReportData.SetParameterValue(0, patientid_cmb.Text);
                reportViewer.ReportSource = ReportData;
            }
            else
                MessageBox.Show("Please choose patient id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

