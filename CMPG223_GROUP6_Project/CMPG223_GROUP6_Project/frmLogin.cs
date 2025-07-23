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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool bLogin;

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //Validate username
            if (txtUsername.Text == "")
            {
                erpLogin.SetError(txtUsername, "Please enter username.");
                bLogin = false;
            }
            else
                erpLogin.SetError(txtUsername, "");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //Validate password
            if (txtPassword.Text == "")
            {
                erpLogin.SetError(txtPassword, "Please enter password.");
                bLogin = false;
            }
            else
                erpLogin.SetError(txtPassword, "");
        }       

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            int width = this.Width / 2 - pnlLogin.Width / 2;
            int heigth = this.Height / 2 - pnlLogin.Height / 2;
            pnlLogin.Location = new Point(width, heigth);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Assume input is correct
            bLogin = true;

            //Validate username and password
            txtUsername_TextChanged(sender, e);
            txtPassword_TextChanged(sender, e);

            //Validate input
            if (bLogin)
            {
                //Declare variables
                bool Is_Admin = false;
                string Employee_Name = "";

                //Open database connection to execute login stored procedure
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();

                //Search for Administrator on system
                SqlCommand command = new SqlCommand("Get_Employee_Credentials", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                //Add Movie_ID to table
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //Close connection to database after login stored procedure has executed
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    int Employee_ID = int.Parse(dt.Rows[0][0].ToString());
                    Is_Admin = bool.Parse(dt.Rows[0][1].ToString());
                    Employee_Name = dt.Rows[0][2].ToString();

                    //Close frmLogin, save memory by closing instead of hiding the form
                    this.Close();

                    if (Is_Admin)
                    {
                        //Open the administrator dashboard
                        frmDashboard AdministratorDashboard = new frmDashboard();
                        AdministratorDashboard.fName = Employee_Name;
                        AdministratorDashboard.Show();
                    }
                    else
                    {
                        //Open the sell a ticket form
                        frmSellTicket SellTicketForm = new frmSellTicket();
                        //Transfer the connection and the administrator's name and surname
                        SellTicketForm.fEmployee_ID = Employee_ID;
                        SellTicketForm.Show();
                    }
                }
                else
                {
                    //Display error in label
                    erpLogin.SetError(btnLogin, "Username or password is incorrect.");
                }
            }
        }
    }
}
