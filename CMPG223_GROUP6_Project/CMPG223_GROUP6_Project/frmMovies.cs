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
    public partial class frmMovies : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private ErrorProvider errorProvider;
        private ToolTip toolTip;

        public frmMovies()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            toolTip = new ToolTip();

            // Set ToolTip properties
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Add tooltips
            AddTooltips();
            ShowMovies();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            labelError.Text = "";

            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // check if the movie exists
                    using (SqlCommand checkCommand = new SqlCommand("SELECT 1 FROM MOVIE WHERE Movie_Name = @Movie_Name AND Is_Active = 1", conn))
                    {
                        checkCommand.Parameters.AddWithValue("@Movie_Name", textBoxMovieName.Text);
                        var movieExists = checkCommand.ExecuteScalar();

                        if (movieExists != null)
                        {
                            labelError.Text = "Movie already exists."; // Error Handleing if the movie exists
                            return;
                        }
                    }

                    // insert movie if it does not already exist
                    using (SqlCommand command = new SqlCommand("InsertMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_Name", textBoxMovieName.Text);
                        command.Parameters.AddWithValue("@Movie_Description", textBoxMovieDescription.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                        command.ExecuteNonQuery();
                    }

                    labelError.Text = "A new movie was added!"; 
                    ShowMovies(); // Refresh movie datagridview list
                }
            }
            catch (Exception ex)
            {
                labelError.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelError.Text = ""; // clear any previous errors

            if (dataGridView1.SelectedRows.Count == 0)
            {
                labelError.Text = "Please select a movie from the list to update";
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int movieID = Convert.ToInt32(selectedRow.Cells["Movie_ID"].Value);

            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                //Update the movies
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("UpdateMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_ID", movieID);
                        command.Parameters.AddWithValue("@Movie_Name", textBoxMovieName.Text);
                        command.Parameters.AddWithValue("@Movie_Description", textBoxMovieDescription.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Movie updated successfully!");
                    ShowMovies(); // Refresh movies DataGridView
                }
            }
            catch (SqlException ex) when (ex.Number == 50000)
            {
                labelError.Text = "A movie with the same name already exists."; //handle duplicates of if movie with the same name already exists
            }
            catch (Exception ex)
            {
                labelError.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelError.Text = ""; // Clear errors

            if (dataGridView1.SelectedRows.Count == 0)
            {
                labelError.Text = "Please select a movie from the list to delete.";
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int movieID = Convert.ToInt32(selectedRow.Cells["Movie_ID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("DeleteMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_ID", movieID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Movie was deleted successfully!");
                    ShowMovies(); // Refresh movies DataGridView
                }
            }
            catch (Exception ex)
            {
                labelError.Text = $"An error occurred: {ex.Message}";
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear(); // Clear errors

            // Validate the Movie Name
            if (string.IsNullOrWhiteSpace(textBoxMovieName.Text))
            {
                errorProvider.SetError(textBoxMovieName, "Movie name is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxMovieName, ""); 
            }

            // Validate Movie Description
            if (string.IsNullOrWhiteSpace(textBoxMovieDescription.Text))
            {
                errorProvider.SetError(textBoxMovieDescription, "Movie description is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxMovieDescription, ""); 
            }

            // Validate Price
            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || price < 0)
            {
                errorProvider.SetError(textBoxPrice, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxPrice, ""); 
            }

            return isValid;
        }

        private void ShowMovies()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("Show_Movies", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void AddTooltips()
        {
            toolTip.SetToolTip(textBoxMovieName, "Enter the name of the movie.");
            toolTip.SetToolTip(textBoxMovieDescription, "Enter a description for the movie.");
            toolTip.SetToolTip(textBoxPrice, "Enter the price of the movie, a positive decimal number.");
            toolTip.SetToolTip(buttonAdd, "Click to add a new movie.");
            toolTip.SetToolTip(buttonUpdate, "Click to update the selected movie.");
            toolTip.SetToolTip(buttonDelete, "Click to delete the selected movie.");
            toolTip.SetToolTip(btnDashboard, "Click to go back to the dashboard.");
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
