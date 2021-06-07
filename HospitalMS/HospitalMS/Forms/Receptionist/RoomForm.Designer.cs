
namespace HospitalMS
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.lblRooms = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnNextRoom = new System.Windows.Forms.Button();
            this.btnPreviousRoom = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTakenBeds = new System.Windows.Forms.Label();
            this.lblNumberOfBeds = new System.Windows.Forms.Label();
            this.lblStatusDesign = new System.Windows.Forms.Label();
            this.lblNumberOfBedsDesign = new System.Windows.Forms.Label();
            this.lblTakenBedsDesign = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.lblFloorNumberDesign = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomNumberDesign = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRooms.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRooms.ForeColor = System.Drawing.Color.Crimson;
            this.lblRooms.Location = new System.Drawing.Point(285, 20);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(98, 40);
            this.lblRooms.TabIndex = 15;
            this.lblRooms.Text = "Rooms";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.btnNextRoom);
            this.panelContainer.Controls.Add(this.btnPreviousRoom);
            this.panelContainer.Controls.Add(this.lblStatus);
            this.panelContainer.Controls.Add(this.lblTakenBeds);
            this.panelContainer.Controls.Add(this.lblNumberOfBeds);
            this.panelContainer.Controls.Add(this.lblStatusDesign);
            this.panelContainer.Controls.Add(this.lblNumberOfBedsDesign);
            this.panelContainer.Controls.Add(this.lblTakenBedsDesign);
            this.panelContainer.Controls.Add(this.lblFloorNumber);
            this.panelContainer.Controls.Add(this.lblFloorNumberDesign);
            this.panelContainer.Controls.Add(this.lblRoomNumber);
            this.panelContainer.Controls.Add(this.lblRoomNumberDesign);
            this.panelContainer.Location = new System.Drawing.Point(150, 100);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(377, 368);
            this.panelContainer.TabIndex = 26;
            // 
            // btnNextRoom
            // 
            this.btnNextRoom.BackColor = System.Drawing.Color.Crimson;
            this.btnNextRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnNextRoom.ForeColor = System.Drawing.Color.Gold;
            this.btnNextRoom.Location = new System.Drawing.Point(335, 333);
            this.btnNextRoom.Name = "btnNextRoom";
            this.btnNextRoom.Size = new System.Drawing.Size(41, 34);
            this.btnNextRoom.TabIndex = 37;
            this.btnNextRoom.Text = "->";
            this.btnNextRoom.UseVisualStyleBackColor = false;
            this.btnNextRoom.Click += new System.EventHandler(this.btnNextRoom_Click);
            // 
            // btnPreviousRoom
            // 
            this.btnPreviousRoom.BackColor = System.Drawing.Color.Crimson;
            this.btnPreviousRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousRoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPreviousRoom.ForeColor = System.Drawing.Color.Gold;
            this.btnPreviousRoom.Location = new System.Drawing.Point(1, 333);
            this.btnPreviousRoom.Name = "btnPreviousRoom";
            this.btnPreviousRoom.Size = new System.Drawing.Size(41, 34);
            this.btnPreviousRoom.TabIndex = 36;
            this.btnPreviousRoom.Text = "<-";
            this.btnPreviousRoom.UseVisualStyleBackColor = false;
            this.btnPreviousRoom.Click += new System.EventHandler(this.btnPreviousRoom_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(225, 291);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 25);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "Available";
            // 
            // lblTakenBeds
            // 
            this.lblTakenBeds.AutoSize = true;
            this.lblTakenBeds.ForeColor = System.Drawing.Color.Crimson;
            this.lblTakenBeds.Location = new System.Drawing.Point(252, 228);
            this.lblTakenBeds.Name = "lblTakenBeds";
            this.lblTakenBeds.Size = new System.Drawing.Size(20, 23);
            this.lblTakenBeds.TabIndex = 34;
            this.lblTakenBeds.Text = "4";
            // 
            // lblNumberOfBeds
            // 
            this.lblNumberOfBeds.AutoSize = true;
            this.lblNumberOfBeds.ForeColor = System.Drawing.Color.Crimson;
            this.lblNumberOfBeds.Location = new System.Drawing.Point(252, 165);
            this.lblNumberOfBeds.Name = "lblNumberOfBeds";
            this.lblNumberOfBeds.Size = new System.Drawing.Size(20, 23);
            this.lblNumberOfBeds.TabIndex = 33;
            this.lblNumberOfBeds.Text = "6";
            // 
            // lblStatusDesign
            // 
            this.lblStatusDesign.AutoSize = true;
            this.lblStatusDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusDesign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatusDesign.Location = new System.Drawing.Point(71, 291);
            this.lblStatusDesign.Name = "lblStatusDesign";
            this.lblStatusDesign.Size = new System.Drawing.Size(69, 23);
            this.lblStatusDesign.TabIndex = 32;
            this.lblStatusDesign.Text = "Status:";
            // 
            // lblNumberOfBedsDesign
            // 
            this.lblNumberOfBedsDesign.AutoSize = true;
            this.lblNumberOfBedsDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfBedsDesign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberOfBedsDesign.Location = new System.Drawing.Point(71, 165);
            this.lblNumberOfBedsDesign.Name = "lblNumberOfBedsDesign";
            this.lblNumberOfBedsDesign.Size = new System.Drawing.Size(143, 23);
            this.lblNumberOfBedsDesign.TabIndex = 31;
            this.lblNumberOfBedsDesign.Text = "Number of Beds:";
            // 
            // lblTakenBedsDesign
            // 
            this.lblTakenBedsDesign.AutoSize = true;
            this.lblTakenBedsDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblTakenBedsDesign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTakenBedsDesign.Location = new System.Drawing.Point(71, 228);
            this.lblTakenBedsDesign.Name = "lblTakenBedsDesign";
            this.lblTakenBedsDesign.Size = new System.Drawing.Size(106, 23);
            this.lblTakenBedsDesign.TabIndex = 30;
            this.lblTakenBedsDesign.Text = "Taken Beds:";
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblFloorNumber.Location = new System.Drawing.Point(252, 102);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(20, 23);
            this.lblFloorNumber.TabIndex = 29;
            this.lblFloorNumber.Text = "3";
            // 
            // lblFloorNumberDesign
            // 
            this.lblFloorNumberDesign.AutoSize = true;
            this.lblFloorNumberDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblFloorNumberDesign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFloorNumberDesign.Location = new System.Drawing.Point(71, 102);
            this.lblFloorNumberDesign.Name = "lblFloorNumberDesign";
            this.lblFloorNumberDesign.Size = new System.Drawing.Size(122, 23);
            this.lblFloorNumberDesign.TabIndex = 28;
            this.lblFloorNumberDesign.Text = "Floor Number:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblRoomNumber.Location = new System.Drawing.Point(249, 39);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(30, 23);
            this.lblRoomNumber.TabIndex = 27;
            this.lblRoomNumber.Text = "12";
            // 
            // lblRoomNumberDesign
            // 
            this.lblRoomNumberDesign.AutoSize = true;
            this.lblRoomNumberDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumberDesign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRoomNumberDesign.Location = new System.Drawing.Point(71, 39);
            this.lblRoomNumberDesign.Name = "lblRoomNumberDesign";
            this.lblRoomNumberDesign.Size = new System.Drawing.Size(122, 23);
            this.lblRoomNumberDesign.TabIndex = 26;
            this.lblRoomNumberDesign.Text = "Room Number:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblRooms);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTakenBeds;
        private System.Windows.Forms.Label lblNumberOfBeds;
        private System.Windows.Forms.Label lblStatusDesign;
        private System.Windows.Forms.Label lblNumberOfBedsDesign;
        private System.Windows.Forms.Label lblTakenBedsDesign;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.Label lblFloorNumberDesign;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomNumberDesign;
        private System.Windows.Forms.Button btnNextRoom;
        private System.Windows.Forms.Button btnPreviousRoom;
    }
}