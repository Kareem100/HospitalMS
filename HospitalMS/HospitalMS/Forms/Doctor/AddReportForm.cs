using HospitalMS.HelperClasses;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class AddReportForm : Form
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
        public List<MedicineInfo> medicinesList;
        private int reportID;

        public AddReportForm()
        {
            InitializeComponent();
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
        }

        private void AddReportForm_Load(object sender, EventArgs e)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();

            loadPatientsIDs();
            loadMedicines();
        }

        //  ======== LOAD PATIENT & MEDICINE DATA FROM DATABASE  ======== //
        // SELECT ONLY the patients who has not a report yet.
         private void loadPatientsIDs()
         {
             OracleCommand cmd = new OracleCommand();
             cmd.Connection = conn;
             cmd.CommandText = "SELECT NationalID FROM patient WHERE NationalID not in (SELECT patientID FROM case_report)";
             cmd.CommandType = CommandType.Text;
             OracleDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
                 comboPatientNationalID.Items.Add(reader[0]);

             reader.Close();
        }

        // SELECT All patients
        #region pointOfView
        /*private void loadPatientsIDs()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NationalID FROM patient";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboPatientNationalID.Items.Add(reader[0]);

            reader.Close();
        }*/
        #endregion

        private void loadMedicines()
        {
            medicinesList = new List<MedicineInfo>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CodeNumber, MedicineName FROM medicine";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MedicineInfo medicineInfo = new MedicineInfo();
                medicineInfo.code = Convert.ToInt32(reader[0]);
                medicineInfo.name = reader[1].ToString();
                medicineInfo.quantity = 1;
                medicinesList.Add(medicineInfo);
                chechBoxMedecines.Items.Add(reader[1]);
            }

            reader.Close();
        }

        // HELPER METHOD to create the current ReportID
        private int getMaxID()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX(ReportID) FROM case_report";
            cmd.CommandType = CommandType.Text;
            int maxID;
            try
            {
                maxID = Convert.ToInt32(cmd.ExecuteScalar()); 
            }
            catch
            {
                maxID = 9;
            }
            return maxID;
        }

        // ==================== BUTTONS CLICK EVENT ====================== //
        private void btnAddReport_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if (isPatientExists(comboPatientNationalID.Text.Trim()))
                {
                    insertReport();
                    if (chechBoxMedecines.CheckedItems.Count == 0)
                        MessageBox.Show("Report has been Added Successfully !\nNo Medicines were Added...", "ADDING REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        attachMedicinesToReport();
                        MessageBox.Show("Report has been Added Successfully !\nMedicines were Added !", "ADDING REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    resetFields();
                }
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            getMedicinesQuantity();
        }

        // ====================== FIELDS VALIDATION ====================== //
        private bool isValidData()
        {
            // --- National ID ---
            string NID = comboPatientNationalID.Text.Trim();
            if(!isNumbers(NID))
            {
                MessageBox.Show("NationalID Should not Contains Letters !!", "INVALID FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (NID.Length != 14)
            {
                MessageBox.Show("Egyptian National ID Must Consist of 14 Digits!!", "INVALID FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- Conditional Illness ---
            string illness = txtConditionalIllness.Text.Trim();
            if (illness.Length < 5 || illness.Equals("Conditional Illness") || isNumbers(illness))
            {
                MessageBox.Show("Please Specify a true Conditional Illness !!", "INVALID FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- From & To Dates ---
            if (dateFrom.Value > dateTo.Value)
            {
                MessageBox.Show("Patient Out Date Can't be After his In Date !!", "INVALID FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- Medecines
            // no validation for medecines;

            return true;
        }

        private bool isNumbers(string text)
        {
            for (int i = 0; i < text.Length; ++i)
                if (text[i] > '9' || text[i] < '0')
                    return false;
            return true;
        }

        private bool isPatientExists(string patientNationalID)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT (NationalID) FROM patient WHERE NationalID = :patientNationalID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("patientNationalID", patientNationalID);
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            if (res == 0)
                return false;
            return true;
        }

        // ====== EXTRACT THE QUANTITY FOR EACH ASSIGNED MEDICINE ====== //
        private void getMedicinesQuantity()
        {
            for (int i = 0; i < chechBoxMedecines.Items.Count; i++)
                if (chechBoxMedecines.GetItemChecked(i))
                    CustomMessageBox2.Show(this, medicinesList[i].code, medicinesList[i].name);
        }

        // SEARCH For a specified code and update it's quantity
        public void setQuantity(int code, int quantity)
        {
            for (int i = 0; i < medicinesList.Count; ++i)
                if (medicinesList[i].code == code)
                {
                    medicinesList[i].quantity = quantity;
                    break;
                }
        }

        // ================ INSERT REPORT & LINK MEDICINES =============== //
        private void insertReport()
        {
            // Extract data from the control fields
            reportID = getMaxID() + 1;
            string dateIn = dateFrom.Text;
            string dateOut = dateTo.Text;
            string conditionalIllness = txtConditionalIllness.Text.Trim();
            string patientID = comboPatientNationalID.Text.Trim();
            string doctorID = GlobalData.userNID;

            // Insert row To case_report table
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO case_report VALUES (:reportID, :dateIn, :dateOut, :conditionalIllness, :patientID, :doctorID)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("reportID", reportID);
            cmd.Parameters.Add("dateIn", dateIn);
            cmd.Parameters.Add("dateOut", dateOut);
            cmd.Parameters.Add("conditionalIllness", conditionalIllness);
            cmd.Parameters.Add("patientID", patientID);
            cmd.Parameters.Add("doctorID", doctorID);
            cmd.ExecuteNonQuery();
        }

        // Add Medicens To Report_Medecine Table
        private void attachMedicinesToReport()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO report_and_medicine VALUES(:reportID, :medicineCode, :quantity)";
            cmd.CommandType = CommandType.Text;
            for (int i = 0; i < chechBoxMedecines.Items.Count; i++)
                if (chechBoxMedecines.GetItemChecked(i))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("reportID", reportID);
                    cmd.Parameters.Add("medicineCode", medicinesList[i].code);
                    cmd.Parameters.Add("quantity", medicinesList[i].quantity);
                    cmd.ExecuteNonQuery();
                }
        }

        // ============== HELPER CLASS THAT HOLDS MEDICINE INFORMATION ============== //
        public class MedicineInfo
        {
            public int code { get; set; }
            public string name { get; set; }
            public int quantity { get; set; }
        }

        // ====================== FOCUS EFFECTS & FROM CLOSING ====================== //
        private void resetFields()
        {
            comboPatientNationalID.Text = "Patient National ID";
            txtConditionalIllness.Text = "Conditional Illness";
            for (int i = 0; i < chechBoxMedecines.Items.Count; ++i)
                chechBoxMedecines.SetItemChecked(i, false);
        }

        public void enableAddReportButton()
        {
            btnAddReport.Enabled = true;
        }
        public void disableAddReportButton()
        {
            btnAddReport.Enabled = false;
        }

        private void chechBoxMedecines_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chechBoxMedecines.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
                enableAddReportButton();
            else
                disableAddReportButton();
        }

        private void Conditional_Illness_txt_Enter(object sender, EventArgs e)
        {
            if (txtConditionalIllness.Text == "Conditional Illness") txtConditionalIllness.Text = "";
        }

        private void Conditional_Illness_txt_Leave(object sender, EventArgs e)
        {
            if (txtConditionalIllness.Text == "") txtConditionalIllness.Text = "Conditional Illness";
        }

        private void AddReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
