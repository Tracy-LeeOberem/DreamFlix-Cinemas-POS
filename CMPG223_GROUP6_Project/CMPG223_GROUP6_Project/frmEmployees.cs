using CMPG223_GROUP6_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaintainEmployees
{
    public partial class frmMaintainEmployees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //SqlConnection con = new SqlConnection(@"Data Source=R_LAPTOP\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public frmMaintainEmployees()
        {
            InitializeComponent();

        }
        private void frmMaintainEmployees_Load_1(object sender, EventArgs e)
        {
            viewAllEmployees();
            LoadMovieRoomsComboBoxUpdate();
            LoadMovieRoomsComboBoxDelete();
            resetInputsUpdate();
            resetInputsAdd();
            resetInputsDelete();
            cmbEmployeeIDDelete.SelectedIndex = -1;
            cmbEmployeeIDUpdate.SelectedIndex = -1;
        }

        private void tabPageAdd_Click(object sender, EventArgs e)
        {
        }

        public void viewAllEmployees()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Corrected SQL query (fixed the bracket for Is_Active column).
                string sql = @"SELECT [Employee_ID], [Is_Admin], [Employee_Name], [Employee_Surname], 
                              [Cellphone_Num], [Username], [Password] 
                       FROM EMPLOYEE 
                       WHERE [Is_Active] = 1"; // Corrected the closing bracket here

                cmd = new SqlCommand(sql, con);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                // Filling dataset with results from the SQL query.
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "EMPLOYEE");

                // Displaying dataset.
                dgwDisplayEmployee.DataMember = "EMPLOYEE";
                dgwDisplayEmployee.DataSource = ds;

                // Renaming column names.
                dgwDisplayEmployee.Columns["Employee_ID"].HeaderText = "Employee ID";
                dgwDisplayEmployee.Columns["Is_Admin"].HeaderText = "Admin";
                dgwDisplayEmployee.Columns["Employee_Name"].HeaderText = "First Name";
                dgwDisplayEmployee.Columns["Employee_Surname"].HeaderText = "Surname";
                dgwDisplayEmployee.Columns["Cellphone_Num"].HeaderText = "Cell Number";
                dgwDisplayEmployee.Columns["Username"].HeaderText = "Username"; // Corrected "Usernamer" to "Username"
                dgwDisplayEmployee.Columns["Password"].HeaderText = "Password";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
        public void resetInputsAdd()
        {
            txtNameAdd.Text = string.Empty;
            txtSurnameAdd.Text = string.Empty;
            txtCellNumAdd.Text = string.Empty;
            txtUsernameAdd.Text = string.Empty;
            txtPasswordAdd.Text = string.Empty;
            chkIsAdminAdd.Checked = false;
            lblError.Text = string.Empty;
        }

        public void resetInputsUpdate()
        {
            cmbEmployeeIDUpdate.SelectedIndex = -1;

            txtNameUpdate.Text = string.Empty;
            txtSurnameUpdate.Text = string.Empty;
            txtCellNumUpdate.Text = string.Empty;
            txtUsernameUpdate.Text = string.Empty;
            txtPasswordUpdate.Text = string.Empty;
            chkIsAdminUpdate.Checked = false;
            lblErrorUpdate.Text = string.Empty;
        }

        public void resetInputsDelete()
        {
            cmbEmployeeIDDelete.SelectedIndex = -1;
            lblErrorDelete.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z\s\-']+$";
            string phonePattern = @"^\d{10}$";
            int isAdmin = 0;

            // Check if textbox name is empty or contains invalid characters
            if (string.IsNullOrEmpty(txtNameAdd.Text) || !Regex.IsMatch(txtNameAdd.Text, pattern))
            {
                lblError.Text = "Please enter a valid name (letters only).";
                return ;
            }

            // Check if text box surname is empty or contains invalid characters
            if (string.IsNullOrEmpty(txtSurnameAdd.Text) || !Regex.IsMatch(txtSurnameAdd.Text, pattern))
            {
                lblError.Text = "Please enter a valid surname (letters only).";
                return ;
            }

            // Check if cellphone number is empty or not exactly 10 digits
            if (string.IsNullOrEmpty(txtCellNumAdd.Text) || !Regex.IsMatch(txtCellNumAdd.Text, phonePattern) || txtCellNumAdd.Text.Length != 10)
            {
                lblError.Text = "Enter a valid 10-digit cellphone number.";
                return;
            }

            // Validating username input.
            if (string.IsNullOrEmpty(txtUsernameAdd.Text))
            {
                lblError.Text = "Enter a valid username.";
                return;
            }
            // Validating password input.

            if (string.IsNullOrEmpty(txtPasswordAdd.Text))
            {
                lblError.Text = "Enter a valid password.";
                return;
            }

            if (chkIsAdminAdd.Checked == true)
            {
                isAdmin = 1;
            }

            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Add new room seat record.
                using (SqlCommand command = new SqlCommand("Add_Employee", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Is_Admin", isAdmin);
                    command.Parameters.AddWithValue("@Employee_Name", txtNameAdd.Text);
                    command.Parameters.AddWithValue("@Employee_Surname", txtSurnameAdd.Text);
                    command.Parameters.AddWithValue("@Cellphone_Num", txtCellNumAdd.Text);
                    command.Parameters.AddWithValue("@Username", txtUsernameAdd.Text);
                    command.Parameters.AddWithValue("@Password", txtPasswordAdd.Text);
                    command.ExecuteNonQuery();
                }

                viewAllEmployees();
                MessageBox.Show("You have successfully added an new employee.", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                resetInputsUpdate();
                resetInputsAdd();
                resetInputsDelete();
                LoadMovieRoomsComboBoxUpdate();
                LoadMovieRoomsComboBoxDelete();
                cmbEmployeeIDDelete.SelectedIndex = -1;
                cmbEmployeeIDUpdate.SelectedIndex = -1;
            }

        }

        public void LoadMovieRoomsComboBoxUpdate()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Query to get existing movie rooms.
                string sql = "SELECT Employee_ID FROM EMPLOYEE WHERE Is_Active = 1";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();

                // Fill the DataTable with the query result.    
                adapter.Fill(dt);

                // Bind the DataTable to the combobox.
                cmbEmployeeIDUpdate.DisplayMember = "Employee_ID";
                cmbEmployeeIDUpdate.ValueMember = "Employee_ID";
                cmbEmployeeIDUpdate.DataSource = dt;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                cmbEmployeeIDDelete.SelectedIndex = -1;
                cmbEmployeeIDUpdate.SelectedIndex = -1;
            }
        }

        public void LoadMovieRoomsComboBoxDelete()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Query to get existing movie rooms.
                string sql = "SELECT Employee_ID FROM EMPLOYEE WHERE Is_Active = 1";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();

                // Fill the DataTable with the query result.    
                adapter.Fill(dt);

                // Bind the DataTable to the combobox.
                cmbEmployeeIDDelete.DisplayMember = "Employee_ID";
                cmbEmployeeIDDelete.ValueMember = "Employee_ID";
                cmbEmployeeIDDelete.DataSource = dt;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                cmbEmployeeIDDelete.SelectedIndex = -1;
                cmbEmployeeIDUpdate.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z\s\-']+$";
            string phonePattern = @"^\d{10}$";
            int isAdminUpdate = 0;

            // Check if textbox name is empty or contains invalid characters.
            if (cmbEmployeeIDUpdate.SelectedIndex == -1)
            {
                lblErrorUpdate.Text = "Please enter select and employee ID to update.";
                return;
            }


            // Check if textbox name is empty or contains invalid characters.
            if (string.IsNullOrEmpty(txtNameUpdate.Text) || !Regex.IsMatch(txtNameUpdate.Text, pattern))
            {
                lblErrorUpdate.Text = "Please enter a valid name (letters only).";
                return;
            }

            // Check if text box surname is empty or contains invalid characters.
            if (string.IsNullOrEmpty(txtSurnameUpdate.Text) || !Regex.IsMatch(txtSurnameUpdate.Text, pattern))
            {
                lblErrorUpdate.Text = "Please enter a valid surname (letters only).";
                return;
            }

            // Check if cellphone number is empty or not exactly 10 digits.
            if (string.IsNullOrEmpty(txtCellNumUpdate.Text) || !Regex.IsMatch(txtCellNumUpdate.Text, phonePattern) || txtCellNumUpdate.Text.Length != 10)
            {
                lblErrorUpdate.Text = "Enter a valid 10-digit cellphone number.";
                return;
            }


            // Validating Username input.
            if (string.IsNullOrEmpty(txtUsernameUpdate.Text))
            {
                lblErrorUpdate.Text = "Enter a valid username.";
                return;
            }

            // Validating password input.
            if (string.IsNullOrEmpty(txtPasswordUpdate.Text))
            {
                lblErrorUpdate.Text = "Enter a valid password.";
                return;
            }

            if (chkIsAdminUpdate.Checked == true)
            {
                isAdminUpdate = 1;
            }

            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Add new room seat record.
                using (SqlCommand command = new SqlCommand("Update_Employee", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Is_Admin", isAdminUpdate);
                    command.Parameters.AddWithValue("@Employee_Name", txtNameUpdate.Text);
                    command.Parameters.AddWithValue("@Employee_Surname", txtSurnameUpdate.Text);
                    command.Parameters.AddWithValue("@Cellphone_Num", txtCellNumUpdate.Text);
                    command.Parameters.AddWithValue("@Username", txtUsernameUpdate.Text);
                    command.Parameters.AddWithValue("@Password", txtPasswordUpdate.Text);
                    command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(cmbEmployeeIDUpdate.SelectedValue));
                    command.ExecuteNonQuery();
                }

                viewAllEmployees();
                MessageBox.Show("You have successfully updated the employee.", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblErrorUpdate.Text = ex.Message;
            }
            finally
            {
                con.Close();
                resetInputsUpdate();
                resetInputsAdd();
                resetInputsDelete();
                LoadMovieRoomsComboBoxUpdate();
                LoadMovieRoomsComboBoxDelete();
                cmbEmployeeIDDelete.SelectedIndex = -1;
                cmbEmployeeIDUpdate.SelectedIndex = -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Deleting a room seat (switching Is_Active = false).
                using (SqlCommand command = new SqlCommand("Delete_Employee", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(cmbEmployeeIDDelete.SelectedValue));
                    command.ExecuteNonQuery();
                }

                viewAllEmployees();
                MessageBox.Show("You have succesfully deleted the employee!", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblErrorDelete.Text = ex.Message;
            }
            finally
            {
                con.Close();
                resetInputsUpdate();
                resetInputsAdd();
                resetInputsDelete();
                LoadMovieRoomsComboBoxUpdate();
                LoadMovieRoomsComboBoxDelete();
                cmbEmployeeIDDelete.SelectedIndex = -1;
                cmbEmployeeIDUpdate.SelectedIndex = -1;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnBackUpdate_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnBackDelete_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }
    }

}

        
    
