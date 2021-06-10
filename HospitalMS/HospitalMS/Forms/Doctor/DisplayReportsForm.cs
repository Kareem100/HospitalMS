using System.Windows.Forms;
using System.Threading.Tasks;
using HospitalMS.CrystalReports;
using CrystalDecisions.Shared;

namespace HospitalMS
{
    public partial class DisplayReportsForm : Form
    {
        ReportData ReportData;
        public DisplayReportsForm()
        {
            InitializeComponent();
        }

        private void DisplayReportsForm_Load(object sender, System.EventArgs e)
        {
            LoadReport();
        }
        private async void LoadReport()
        {
            //await Task.Delay(500);
            ReportData = new ReportData();
            ReportData.SetDatabaseLogon("scott", "tiger");
            //get all available ids into cmb
            foreach (ParameterDiscreteValue value in ReportData.ParameterFields[0].DefaultValues)
                       patientid_cmb.Items.Add(value.Value);
          
        }
        private void Evaluate_btn_Click(object sender, System.EventArgs e)
        {
            if (patientid_cmb.SelectedItem != null)
            {
                ReportData.SetParameterValue(0, patientid_cmb.Text);
                reportViewer.ReportSource = ReportData;
            }
            else
                MessageBox.Show("Please choose patient id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}

