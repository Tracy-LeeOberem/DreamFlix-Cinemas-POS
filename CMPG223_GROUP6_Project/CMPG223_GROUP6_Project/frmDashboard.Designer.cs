namespace CMPG223_GROUP6_Project
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnRoomSeats = new System.Windows.Forms.Button();
            this.btnMaintainMovieRooms = new System.Windows.Forms.Button();
            this.btnMaintainMovies = new System.Windows.Forms.Button();
            this.btnMaintainTimeslots = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMaintainEmployees = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(252, 57);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(153, 33);
            this.lblWelcome.TabIndex = 34;
            this.lblWelcome.Text = "Welcome:";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Maroon;
            this.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDashboard.Controls.Add(this.btnRoomSeats);
            this.pnlDashboard.Controls.Add(this.btnMaintainMovieRooms);
            this.pnlDashboard.Controls.Add(this.btnMaintainMovies);
            this.pnlDashboard.Controls.Add(this.btnMaintainTimeslots);
            this.pnlDashboard.Controls.Add(this.btnReports);
            this.pnlDashboard.Controls.Add(this.btnLogout);
            this.pnlDashboard.Controls.Add(this.btnMaintainEmployees);
            this.pnlDashboard.Location = new System.Drawing.Point(258, 113);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(302, 280);
            this.pnlDashboard.TabIndex = 33;
            // 
            // btnRoomSeats
            // 
            this.btnRoomSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSeats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRoomSeats.Location = new System.Drawing.Point(16, 160);
            this.btnRoomSeats.Name = "btnRoomSeats";
            this.btnRoomSeats.Size = new System.Drawing.Size(120, 48);
            this.btnRoomSeats.TabIndex = 34;
            this.btnRoomSeats.Text = "Maintain Room Seats";
            this.btnRoomSeats.UseVisualStyleBackColor = false;
            this.btnRoomSeats.Click += new System.EventHandler(this.btnRoomSeats_Click);
            // 
            // btnMaintainMovieRooms
            // 
            this.btnMaintainMovieRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaintainMovieRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainMovieRooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintainMovieRooms.Location = new System.Drawing.Point(160, 88);
            this.btnMaintainMovieRooms.Name = "btnMaintainMovieRooms";
            this.btnMaintainMovieRooms.Size = new System.Drawing.Size(120, 48);
            this.btnMaintainMovieRooms.TabIndex = 33;
            this.btnMaintainMovieRooms.Text = "Maintain Movie Rooms";
            this.btnMaintainMovieRooms.UseVisualStyleBackColor = false;
            this.btnMaintainMovieRooms.Click += new System.EventHandler(this.btnMaintainMovieRooms_Click);
            // 
            // btnMaintainMovies
            // 
            this.btnMaintainMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaintainMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainMovies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintainMovies.Location = new System.Drawing.Point(16, 88);
            this.btnMaintainMovies.Name = "btnMaintainMovies";
            this.btnMaintainMovies.Size = new System.Drawing.Size(120, 48);
            this.btnMaintainMovies.TabIndex = 32;
            this.btnMaintainMovies.Text = "Maintain Movies";
            this.btnMaintainMovies.UseVisualStyleBackColor = false;
            this.btnMaintainMovies.Click += new System.EventHandler(this.btnMaintainMovies_Click);
            // 
            // btnMaintainTimeslots
            // 
            this.btnMaintainTimeslots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaintainTimeslots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainTimeslots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintainTimeslots.Location = new System.Drawing.Point(160, 16);
            this.btnMaintainTimeslots.Name = "btnMaintainTimeslots";
            this.btnMaintainTimeslots.Size = new System.Drawing.Size(120, 48);
            this.btnMaintainTimeslots.TabIndex = 31;
            this.btnMaintainTimeslots.Text = "Maintain Timeslots";
            this.btnMaintainTimeslots.UseVisualStyleBackColor = false;
            this.btnMaintainTimeslots.Click += new System.EventHandler(this.btnMaintainTimeslots_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Location = new System.Drawing.Point(160, 160);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 48);
            this.btnReports.TabIndex = 30;
            this.btnReports.Text = "Request reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(88, 232);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 32);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMaintainEmployees
            // 
            this.btnMaintainEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaintainEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainEmployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintainEmployees.Location = new System.Drawing.Point(16, 16);
            this.btnMaintainEmployees.Name = "btnMaintainEmployees";
            this.btnMaintainEmployees.Size = new System.Drawing.Size(120, 48);
            this.btnMaintainEmployees.TabIndex = 0;
            this.btnMaintainEmployees.Text = "Maintain Employees";
            this.btnMaintainEmployees.UseVisualStyleBackColor = false;
            this.btnMaintainEmployees.Click += new System.EventHandler(this.btnMaintainEmployees_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 153);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlDashboard);
            this.DoubleBuffered = true;
            this.Name = "frmDashboard";
            this.Text = "Dashboard form";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Resize += new System.EventHandler(this.frmDashboard_Resize);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnRoomSeats;
        private System.Windows.Forms.Button btnMaintainMovieRooms;
        private System.Windows.Forms.Button btnMaintainMovies;
        private System.Windows.Forms.Button btnMaintainTimeslots;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMaintainEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}