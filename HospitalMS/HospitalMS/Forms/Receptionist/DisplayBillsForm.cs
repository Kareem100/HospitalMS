using HospitalMS.CrystalReports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class DisplayBillsForm : Form
    {
        public DisplayBillsForm()
        {
            InitializeComponent();
        }

        private void DisplayBillsForm_Load(object sender, System.EventArgs e)
        {
            LoadReport();
        }

        private async void LoadReport()
        {   
            await Task.Delay(500);
            BillReport billReport = new BillReport();
            billReport.Refresh();
            billReport.SetDatabaseLogon("scott", "tiger");
            reportViewerBill.ReportSource = billReport;
        }
    }
}
