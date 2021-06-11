using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;
using System.Collections.Generic;

namespace HospitalMS
{
    public partial class RoomForm : Form
    {
        private OracleConnection conn;
        private OracleCommand cmd;
        private List<int> AllRoomsIDsList = new List<int>() { 201, 205, 210, 218, 223 };
        private const int AllRoomsListSize = 5;
        // CurrentRoomIndex initialized to -1 to be increased when the form loaded.
        private int CurrentRoomIndex = -1;


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

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));

            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();

            // The parameter is true because it's intialized to -1 so now it'll be 0
            controlRoom(true);
        } 
        private void btnPreviousRoom_Click(object sender, EventArgs e)
        {
            controlRoom(false);
        }

        private void btnNextRoom_Click(object sender, EventArgs e)
        {
            controlRoom(true);
        }

        private void controlRoom(bool MoveToNextRoom)
        {
            checkRoomIndex(MoveToNextRoom);
            handleRoomProcedure();
            increaseSizeOfParameters();
            cmd.ExecuteNonQuery();
            changeLabelsText();
        }
        private void handleRoomProcedure()
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "RETRIEVEROOM";
            cmd.CommandType = CommandType.StoredProcedure;

            // Input Parameter
            cmd.Parameters.Add("RoomID", AllRoomsIDsList[CurrentRoomIndex]);
            // Output Parameters
            cmd.Parameters.Add("RoomNumber_Out", "").Direction = ParameterDirection.Output;
            cmd.Parameters.Add("FloorNumber_Out", "").Direction = ParameterDirection.Output;
            cmd.Parameters.Add("NumberOfAllBeds_Out", "").Direction = ParameterDirection.Output;
            cmd.Parameters.Add("NumberOfTakenBeds_Out", "").Direction = ParameterDirection.Output;
        }

        private void increaseSizeOfParameters()
        {
            cmd.Parameters["RoomNumber_Out"].Size = 255;
            cmd.Parameters["FloorNumber_Out"].Size = 255;
            cmd.Parameters["NumberOfAllBeds_Out"].Size = 255;
            cmd.Parameters["NumberOfTakenBeds_Out"].Size = 255;
        }
        private void changeLabelsText()
        {
            this.lblRoomNumber.Text = (string)cmd.Parameters["RoomNumber_Out"].Value;
            this.lblFloorNumber.Text = (string)cmd.Parameters["FloorNumber_Out"].Value;
            this.lblNumberOfBeds.Text = (string)cmd.Parameters["NumberOfAllBeds_Out"].Value;
            this.lblTakenBeds.Text = (string)cmd.Parameters["NumberOfTakenBeds_Out"].Value;

            if (this.lblNumberOfBeds.Text == this.lblTakenBeds.Text)
            {
                this.lblStatus.Text = "Not Available";
                this.lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.lblStatus.Text = "Available";
                this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            }
        }

        private void checkRoomIndex(bool MoveToNextRoom)
        {
            if (MoveToNextRoom)
            {
                if (CurrentRoomIndex + 1 < AllRoomsListSize)
                {
                    CurrentRoomIndex++;
                }
            }
            else
            {
                if (CurrentRoomIndex - 1 >= 0)
                {
                    CurrentRoomIndex--;
                }
            }
        }
    }
} 