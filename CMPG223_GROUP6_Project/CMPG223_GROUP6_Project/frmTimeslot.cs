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
using System.Data.SqlClient;

namespace CMPG223_GROUP6_Project
{
    public partial class frmTimeSlot : Form
    {
        private const String ConnectionString = @"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        //DataSet dataSet;
        ToolTip tooltip;
        ErrorProvider errorProvider1 = new ErrorProvider();
        public frmTimeSlot()
        {
            InitializeComponent();

            tooltip = new ToolTip();

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;


            tooltip.SetToolTip(this.txtTimeslotAdd, "Add a timeslot here in the format hh:mm:ss");
            tooltip.SetToolTip(this.txtTimeslotUpdate, "Add a timeslot here in the format hh:mm:ss");

            tooltip.SetToolTip(this.cmbTimeslotIDUpdate, "Select a timeslot to update ");
            tooltip.SetToolTip(this.cmbTimeslotIdDelete, "Select a timeslot to delete");


            tooltip.SetToolTip(this.btnShowAdd, "Click to add a new timeslot");
            tooltip.SetToolTip(this.btnUpdate, "Click to update the selected timeslot");
            tooltip.SetToolTip(this.btnDelete, "Click to delete the selected timeslot");
            showAdd();
            showUpdate();
            showDelete();
            PopulateTimeslotComboBoxes();
        }

        private void showAdd()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    command = new SqlCommand("ShowIsActive_TimeSlot", con);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    dataGridView1.DataSource = dt;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void PopulateTimeslotComboBoxes()
        {
            cmbTimeslotIdDelete.Items.Clear();
            cmbTimeslotIDUpdate.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT DISTINCT Timeslot_ID FROM TIMESLOT WHERE Is_Active = 1", con);
                    reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbTimeslotIDUpdate.Items.Add(reader["Timeslot_ID"].ToString());
                        cmbTimeslotIdDelete.Items.Add(reader["Timeslot_ID"].ToString());
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showDelete()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    command = new SqlCommand("ShowIsActive_TimeSlot", con);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    dataGridView3.DataSource = dt;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void showUpdate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    command = new SqlCommand("ShowIsActive_TimeSlot", con);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    dataGridView2.DataSource = dt;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    DateTime parsedTime;
                    con.Open();
                    command = new SqlCommand("Add_TimeSlot", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@A_Time", txtTimeslotAdd.Text);
                    command.Parameters.Add("@Is_Added", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    bool Is_Added = Convert.ToBoolean(command.Parameters["@Is_Added"].Value);




                    String format = "HH:mm:ss";

                    if (string.IsNullOrEmpty(txtTimeslotAdd.Text))
                    {
                        errorProvider1.SetError(txtTimeslotAdd, "Please enter a timeslot");
                    }
                    else
                    {
                        errorProvider1.SetError(txtTimeslotAdd, string.Empty);
                    }

                    bool isValidTimeFormat = DateTime.TryParseExact(txtTimeslotAdd.Text, format, null, System.Globalization.DateTimeStyles.None, out parsedTime);



                    if (Is_Added == false)
                    {
                        errorProvider1.SetError(txtTimeslotAdd, "Did not add because value already exists");
                    }

                    if (isValidTimeFormat && Is_Added == true)
                    {
                        MessageBox.Show("A new timeslot has been added");

                    }
                    if (isValidTimeFormat == false)
                    {
                        errorProvider1.SetError(txtTimeslotAdd, "Please enter time in the correct format HH:mm:ss");
                    }



                }
                showAdd();
                showUpdate();
                showDelete();
                PopulateTimeslotComboBoxes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime parsedTime;


            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    command = new SqlCommand("update_TimeSlot", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Timeslot_ID", cmbTimeslotIDUpdate.Text);
                    command.Parameters.AddWithValue("@A_Time", txtTimeslotUpdate.Text);
                    command.Parameters.Add("@Is_Updated", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    command.Dispose();

                    bool Is_Updated = Convert.ToBoolean(command.Parameters["@Is_Updated"].Value);


                    adapter = new SqlDataAdapter(command);


                    if (string.IsNullOrEmpty(cmbTimeslotIDUpdate.Text))
                    {
                        errorProvider1.SetError(cmbTimeslotIDUpdate, "Please select a timeslot");
                    }
                    else
                    {
                        errorProvider1.SetError(cmbTimeslotIDUpdate, string.Empty);
                    }


                    String format = "HH:mm:ss";

                    if (string.IsNullOrEmpty(cmbTimeslotIDUpdate.Text))
                    {
                        errorProvider1.SetError(cmbTimeslotIDUpdate, "Please select a timeslot");
                    }


                    if (string.IsNullOrEmpty(txtTimeslotUpdate.Text))
                    {
                        errorProvider1.SetError(txtTimeslotUpdate, "Please enter a timeslot");
                    }
                    else
                    {
                        errorProvider1.SetError(txtTimeslotUpdate, string.Empty);
                    }

                    bool isValidTimeFormat = DateTime.TryParseExact(txtTimeslotUpdate.Text, format, null, System.Globalization.DateTimeStyles.None, out parsedTime);


                    if (isValidTimeFormat && Is_Updated == true)
                    {

                        MessageBox.Show("The timeslot has been updated!");
                    }
                    if (Is_Updated == false)
                    {
                        errorProvider1.SetError(txtTimeslotUpdate, "Did not update because value already exists");
                    }
                    if (isValidTimeFormat == false)
                    {
                        errorProvider1.SetError(txtTimeslotUpdate, "Please enter time in the correct format HH:mm:ss");
                    }



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAdd();
            showUpdate();
            showDelete();
            PopulateTimeslotComboBoxes();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    command = new SqlCommand("change_IsActive", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Timeslot_ID", cmbTimeslotIdDelete.Text);


                    adapter = new SqlDataAdapter(command);

                    command.ExecuteNonQuery();
                    command.Dispose();

                    if (string.IsNullOrEmpty(cmbTimeslotIdDelete.Text))
                    {
                        errorProvider1.SetError(cmbTimeslotIdDelete, "Please select a timeslot");
                    }
                    else
                    {
                        errorProvider1.SetError(cmbTimeslotIdDelete, string.Empty);
                        MessageBox.Show("Timeslot deleted sucessfully!");
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAdd();
            showUpdate();
            showDelete();
            PopulateTimeslotComboBoxes();
        }

        private void frmTimeSlot_Load(object sender, EventArgs e)
        {
            showAdd();
            showUpdate();
            showDelete();
            PopulateTimeslotComboBoxes();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

    }
}

