using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_GROUP6_Project
{
    public partial class frmSellTicket : Form
    {
        public frmSellTicket()
        {
            InitializeComponent();
        }

        //Global connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public string fName;
        public int fEmployee_ID;
        bool wasButton = false;
        bool bValid;

        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            try
            {
                ShowTickets();

                conn.Open();

                //Get timeslots
                SqlCommand command = new SqlCommand("Get_Timeslots", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@All_Or_Restrict", true);

                //Display timeslots in drop down list
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbTimeslot.DataSource = dt;
                cmbTimeslot.DisplayMember = "A_Time";

                //Get movies
                command = new SqlCommand("Get_Movies", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@All_Or_Specific", false);

                //Display movies in drop down list
                dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbMovie.DataSource = dt;
                cmbMovie.DisplayMember = "Movie_Name";

                conn.Close();

                cmbTimeslot.SelectedIndex = -1;
                cmbMovie.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTickets()
        {
            conn.Open();

            SqlCommand command = new SqlCommand("Get_Tickets", conn);
            command.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            conn.Close();
            dtgShowSeats.DataSource = dt;
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovie.Text != "")
            {
                erpInput.SetError(cmbMovie, "");

                //Get chosen movie
                string sMovieName = cmbMovie.Text;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //Get rooms in which the movie is displayed
                SqlCommand command = new SqlCommand("Get_Room_For_Movie", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Movie_Name", sMovieName);

                //Display rooms in drop down list
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbRoom.DisplayMember = "Room_Num";
                cmbRoom.DataSource = dt;

            }
            else
            {
                erpInput.SetError(cmbMovie, "Movie not selected.");
                bValid = false;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.Text != "")
            {
                erpInput.SetError(cmbRoom, "");

                //Get chosen movie
                int Room_Num = int.Parse(cmbRoom.Text);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //Get rooms in which the movie is displayed
                SqlCommand command = new SqlCommand("Get_Available_Seats_For_Room", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Room_Num", Room_Num);

                //Display rooms in drop down list
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbSeat.DataSource = dt;
                cmbSeat.DisplayMember = "Seat_Num";

                conn.Close();
            }
            else
            {
                erpInput.SetError(cmbRoom, "Room not selected.");
                bValid = false;
            }
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            bValid = true;

            cmbTimeslot_SelectedIndexChanged(sender, e);
            cmbMovie_SelectedIndexChanged(sender, e);
            cmbRoom_SelectedIndexChanged(sender, e);

            if (bValid)
            {
                if (cmbSeat.Text != "")
                {
                    erpInput.SetError(cmbSeat, "");

                    conn.Open();
                    SqlCommand command = new SqlCommand("Add_Ticket", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Employee_ID", fEmployee_ID);
                    command.Parameters.AddWithValue("@Movie_Name", cmbMovie.Text);
                    command.Parameters.AddWithValue("@Room_Num", cmbRoom.Text);
                    command.Parameters.AddWithValue("@Seat_Num", cmbSeat.Text);
                    command.Parameters.AddWithValue("@A_Time", cmbTimeslot.Text);
                    command.Parameters.AddWithValue("@A_Date", DateTime.Today.Date);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("The ticket wass added successfully.");
                    ShowTickets();
                }
                else
                {
                    erpInput.SetError(cmbSeat, "Seat not selected.");
                }
            }
        }

        private void cmbSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeslot.Text != "")
            {
                erpInput.SetError(cmbTimeslot, "");
            }
            else
            {
                erpInput.SetError(cmbTimeslot, "Timeslot not selected.");
                bValid = false;
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Open Login form
            wasButton = true;
            this.Close();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }

        private void frmSellTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!wasButton)
                Environment.Exit(1);
        }

        private void cmbTimeslot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeslot.Text != "")
            {
                erpInput.SetError(cmbTimeslot, "");
            }
            else
            {
                erpInput.SetError(cmbTimeslot, "Timeslot not selected.");
                bValid = false;
            }
        }

    }
}
