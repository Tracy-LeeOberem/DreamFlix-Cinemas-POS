using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_GROUP6_Project
{
    public partial class frmMovieRoom : Form
    {
        string connectionString = @"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private bool isUpdating = false; // Track if the operation is an update or an add
        ToolTip toolTip;
        
        public frmMovieRoom()
        {
            InitializeComponent();

            // Initialize the ToolTip control
            toolTip = new ToolTip();

            // Set up the delays for the ToolTip
            toolTip.AutoPopDelay = 5000; // How long the tooltip stays visible
            toolTip.InitialDelay = 1000; // Delay before tooltip appears
            toolTip.ReshowDelay = 500;   // Delay before tooltip reappears
            toolTip.ShowAlways = true;   // Force the tooltip to show even if the form is not active

            // Assign ToolTips to controls
            toolTip.SetToolTip(this.cmbMovieID, "Select the Movie ID from the list.");
            toolTip.SetToolTip(this.cmbRoomID, "Select the Room ID from the list.");
            toolTip.SetToolTip(this.txtRoomNum, "Enter the room number.");
            toolTip.SetToolTip(this.txtNumSeats, "This is a read-only field.");
            toolTip.SetToolTip(this.btnAdd, "Click to add a new movie room.");
            toolTip.SetToolTip(this.btnUpdate, "Click to update the selected movie room.");
            toolTip.SetToolTip(this.btnDelete, "Click to delete the selected movie room.");
            toolTip.SetToolTip(this.btnShow, "Click to display all movie rooms.");
            toolTip.SetToolTip(this.btnMakeChanges, "Click to apply the changes.");

            // Hide the Room Details controls and MakeChanges button initially
            ToggleRoomDetailsControls(false, false);

            // Populate ComboBoxes when the form loads
            PopulateMovieComboBox();
            PopulateRoomComboBox();
        }
        private void PopulateMovieComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Modify the query to only select movies where IsActive = 1 (true)
                SqlCommand command = new SqlCommand("SELECT Movie_ID FROM dbo.MOVIE WHERE Is_Active = 1", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMovieID.Items.Add(reader["Movie_ID"].ToString());
                }

                conn.Close();
            }
        }

        private void PopulateRoomComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Room_ID FROM dbo.MOVIE_ROOM", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbRoomID.Items.Add(reader["Room_ID"].ToString());
                }

                conn.Close();
            }
        }

        private void ToggleRoomDetailsControls(bool isVisible, bool showRoomID = false)
        {
            lbID.Visible = isVisible;
            cmbMovieID.Visible = isVisible;
            lbNumber.Visible = isVisible;
            txtRoomNum.Visible = isVisible;
            lbSeats.Visible = isVisible;
            txtNumSeats.Visible = isVisible;
            btnMakeChanges.Visible = isVisible;
            lbMovieName.Visible = isVisible;
            txtMovieName.Visible = isVisible;

            lbRoomID.Visible = showRoomID;
            cmbRoomID.Visible = showRoomID;
        }

        // Add a new movie room
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdating = false; // add operation
            ToggleRoomDetailsControls(true, false);

            // Clear fields for new input
            cmbRoomID.SelectedIndex = -1;
            cmbMovieID.SelectedIndex = -1;
            txtRoomNum.Clear();
            txtNumSeats.Clear();

            // Set txtNumSeats to editable since it's an add operation
            txtNumSeats.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Please select a row to hide.");
                return;
            }

            errorProvider1.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete_MovieRoom", conn);  // Stored procedure to set isActive = 0
                command.CommandType = CommandType.StoredProcedure;

                int roomId = int.Parse(dataGridView1.SelectedRows[0].Cells["Room_ID"].Value.ToString());
                command.Parameters.AddWithValue("@Room_ID", roomId);

                command.ExecuteNonQuery();

                // Refresh the data grid to hide inactive records
                btnShow_Click(sender, e);

                conn.Close();
            }            
            ToggleRoomDetailsControls(false);
        }

        // Show all movie rooms in the DataGridView
        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Show_MovieRooms", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["IsActive"].Visible = false;

                    lbStatus.Text = "Movie rooms loaded successfully!";
                    lbStatus.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lbStatus.Text = "Error: " + ex.Message;
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        //Handling DataGridView row selection to fill fields
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1) // Ensure a valid row is selected and not the empty new row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cmbRoomID.Text = row.Cells["Room_ID"].Value.ToString();
                cmbMovieID.Text = row.Cells["Movie_ID"].Value.ToString();
                txtRoomNum.Text = row.Cells["Room_Num"].Value.ToString();
                txtNumSeats.Text = row.Cells["Num_Seats"].Value.ToString();

                ToggleRoomDetailsControls(true);
            }
        }

        private void btnMakeChanges_Click(object sender, EventArgs e)
        {
            // Validate if the fields are filled
            if (string.IsNullOrEmpty(cmbMovieID.Text))
            {
                errorProvider1.SetError(cmbMovieID, "Please select a Movie ID.");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbMovieID, string.Empty);
            }

            if (string.IsNullOrEmpty(txtRoomNum.Text) || !int.TryParse(txtRoomNum.Text, out int roomNum))
            {
                errorProvider1.SetError(txtRoomNum, "Please enter a valid room number.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtRoomNum, string.Empty);
            }

            if (string.IsNullOrEmpty(txtNumSeats.Text) || !int.TryParse(txtNumSeats.Text, out int numSeats))
            {
                errorProvider1.SetError(txtNumSeats, "Please enter a valid number of seats.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNumSeats, string.Empty);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if the room number already exists
                SqlCommand checkRoomCommand = new SqlCommand("SELECT COUNT(*) FROM dbo.MOVIE_ROOM WHERE Room_Num = @Room_Num AND IsActive = 1", conn);
                checkRoomCommand.Parameters.AddWithValue("@Room_Num", roomNum);
                int roomCount = (int)checkRoomCommand.ExecuteScalar();

                // If the room count is greater than zero and we're not updating the same room, show error
                if (roomCount > 0 && !isUpdating)
                {
                    errorProvider1.SetError(txtRoomNum, "This room number is already assigned to an active movie room.");
                    lbStatus.Text = "Room number already exists!";
                    lbStatus.ForeColor = Color.Red;
                    return;  // Stop the operation
                }

                if (!isUpdating)
                {
                    // Add new room and set Is_Active to true
                    SqlCommand addCommand = new SqlCommand("Add_MovieRoom", conn);
                    addCommand.CommandType = CommandType.StoredProcedure;

                    addCommand.Parameters.AddWithValue("@Movie_ID", int.Parse(cmbMovieID.Text));
                    addCommand.Parameters.AddWithValue("@Room_Num", roomNum);
                    addCommand.Parameters.AddWithValue("@Num_Seats", numSeats);
                    addCommand.Parameters.Add("@Is_Added", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;

                    addCommand.ExecuteNonQuery();
                    bool Is_Added = Convert.ToBoolean(addCommand.Parameters["@Is_Added"].Value);

                    if (!Is_Added)
                    {
                        errorProvider1.SetError(txtRoomNum, "The movie room already exists.");
                        return;
                    }
                    else
                    {
                        lbStatus.Text = "A new movie room was added successfully!";
                        lbStatus.ForeColor = Color.Green;
                    }
                }
                else // Update operation
                {
                    SqlCommand updateCommand = new SqlCommand("Update_MovieRoom", conn);
                    updateCommand.CommandType = CommandType.StoredProcedure;

                    if (!int.TryParse(cmbRoomID.Text, out int roomID))
                    {
                        errorProvider1.SetError(cmbRoomID, "Invalid Room ID.");
                        return;
                    }

                    updateCommand.Parameters.AddWithValue("@Room_ID", roomID);
                    updateCommand.Parameters.AddWithValue("@Movie_ID", int.Parse(cmbMovieID.Text));
                    updateCommand.Parameters.AddWithValue("@Room_Num", roomNum);
                    updateCommand.Parameters.AddWithValue("@Num_Seats", numSeats);

                    updateCommand.ExecuteNonQuery();

                    lbStatus.Text = "The movie room was updated successfully!";
                    lbStatus.ForeColor = Color.Green;
                }

                conn.Close();
            }

            // Reload the DataGridView after the operation (for both add and update)
            using (SqlConnection reloadConn = new SqlConnection(connectionString))
            {
                reloadConn.Open();
                SqlCommand reloadCommand = new SqlCommand("Show_MovieRooms", reloadConn);
                reloadCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                dt.Load(reloadCommand.ExecuteReader());
                dataGridView1.DataSource = dt;

                reloadConn.Close();
            }

            // Reset form and hide room details after the add/update operation
            ToggleRoomDetailsControls(false);
        }
        private bool ValidateRoomDetails()
        {
            return !string.IsNullOrEmpty(cmbMovieID.SelectedItem?.ToString()) &&
                   !string.IsNullOrEmpty(txtRoomNum.Text) &&
                   !string.IsNullOrEmpty(txtNumSeats.Text);
        }

        private void ResetRoomDetailsControls()
        {
            cmbMovieID.SelectedIndex = -1;
            txtRoomNum.Clear();
            txtNumSeats.Clear();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Please select a row to update.");
                return;
            }

            errorProvider1.Clear();

            isUpdating = true; 
            ToggleRoomDetailsControls(true, true);  
            txtNumSeats.ReadOnly = true;  

            // Fill the input fields with the selected room's data
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            cmbRoomID.Text = selectedRow.Cells["Room_ID"].Value.ToString();
            cmbMovieID.Text = selectedRow.Cells["Movie_ID"].Value.ToString();
            txtRoomNum.Text = selectedRow.Cells["Room_Num"].Value.ToString();
            txtNumSeats.Text = selectedRow.Cells["Num_Seats"].Value.ToString();
        }

        private void cmbMovieID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a movie is selected
            if (cmbMovieID.SelectedItem == null)
            {
                txtMovieName.Clear();
                return;
            }

            // Get the selected Movie_ID
            string selectedMovieID = cmbMovieID.SelectedItem.ToString();

            // Retrieve the Movie_Name from the database based on the selected Movie_ID
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Movie_Name FROM dbo.MOVIE WHERE Movie_ID = @Movie_ID", conn);
                command.Parameters.AddWithValue("@Movie_ID", selectedMovieID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Set the Movie_Name in the txtMovieName TextBox
                    txtMovieName.Text = reader["Movie_Name"].ToString();
                }
                else
                {
                    // Clear the textbox if no movie name is found
                    txtMovieName.Clear();
                }

                reader.Close();
                conn.Close();
            }
        }
    }
}
