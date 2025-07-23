using MaintainEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_GROUP6_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        //Declare field variables
        public string fName;

        private void btnMaintainEmployees_Click(object sender, EventArgs e)
        {
            //Open maintain employee form
            this.Close();
            frmMaintainEmployees maintainEmployeesForm = new frmMaintainEmployees();
            maintainEmployeesForm.Show();           
        }

        private void btnMaintainTimeslots_Click(object sender, EventArgs e)
        {
            //Open maintain timeslot form
            this.Close();
            frmTimeSlot maintainTimeslotsForm = new frmTimeSlot();
            maintainTimeslotsForm.Show();           
        }

        private void btnMaintainMovies_Click(object sender, EventArgs e)
        {
            //Open maintain movies form
            this.Close();
            frmMovies maintainMoviesForm = new frmMovies();
            maintainMoviesForm.Show();
        }

        private void btnMaintainMovieRooms_Click(object sender, EventArgs e)
        {
            //Open maintain movie rooms form
            this.Close();
            frmMovieRoom maintainMovieRoomsForm = new frmMovieRoom();
            maintainMovieRoomsForm.Show();
        }

        private void btnRoomSeats_Click(object sender, EventArgs e)
        {
            //Open the room seat maintain form
            this.Close();
            frmRoomSeat newFrmRoomSeat = new frmRoomSeat();
            newFrmRoomSeat.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //Open request report form
            this.Close();
            frmRequestReports requestReportForm = new frmRequestReports();
            requestReportForm.Show();            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Open Login form
            this.Close();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //Welcome the administrator
            lblWelcome.Text = "Welcome" + fName + "!";

            //Resize the form properly
            if (lblWelcome.Width > this.Width)
            {
                this.Width = lblWelcome.Width;
                this.MinimumSize = new Size(lblWelcome.Width, 530);
            }
            else
            {
                frmDashboard_Resize(sender, e);
                this.MinimumSize = new Size(this.Width, 530);
            }
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            //Resize the panel and the welcome label properly
            pnlDashboard.Location = new Point(this.Width / 2 - pnlDashboard.Width / 2, this.Height / 2 - pnlDashboard.Height / 2);
            if (this.Width > lblWelcome.Width)
                lblWelcome.Location = new Point(this.Width / 2 - lblWelcome.Width / 2, this.Height / 2 - pnlDashboard.Width / 2 - 60);
            else if (lblWelcome.Width > pnlDashboard.Width)
                lblWelcome.Location = new Point(0, this.Height / 2 - pnlDashboard.Height / 2 - 60);
        }

    }
}