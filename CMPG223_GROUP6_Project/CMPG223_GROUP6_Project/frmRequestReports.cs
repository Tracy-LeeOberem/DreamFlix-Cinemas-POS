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
using System.Windows.Forms.DataVisualization.Charting;

namespace CMPG223_GROUP6_Project
{
    public partial class frmRequestReports : Form
    {
        public frmRequestReports()
        {
            InitializeComponent();
        }

        //Validate input variable (Used in 2 methods)
        bool bValidDates = true;

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            List<DateTime> TimePeriod = new List<DateTime>();
            int[] iMonthly_Tickets = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string sReportTitle = "", sOrderBy = "", sEmployee_Name = "", sCommand = "", sMovie_Name = "";
            int iMovie_ID = 0, iEmployee_ID = 0, iMonth = 0, iMonthly_Tickets_Per_Movie_OR_Employee = 0, iTicketTotal = 0, iCounter = 0;
            decimal dRevenueTotal = 0m;
            SqlCommand mainCommand, subCommand;
            DataTable mainDt, subDt;
            SqlDataAdapter adapter;

            //Validate input
            if (bValidDates)
            {
                //Display report timestamp
                lblTimeStamp.Text = DateTime.Now.ToString();

                //Get report title
                if (rbtnTicketEmployee.Checked)
                    sReportTitle += rbtnTicketEmployee.Text + " from " + dtpStartDate.Value.ToShortDateString() + " to " + dtpEndDate.Value.ToShortDateString();
                else
                    sReportTitle += rbtnTicketMovie.Text + " from " + dtpStartDate.Value.ToShortDateString() + " to " + dtpEndDate.Value.ToShortDateString();

                //If sort option checked
                if (grpSort.Enabled)
                {
                    switch (cmbSort.Text)
                    {
                        case "Employee name": sOrderBy = "Employee_Name_"; break;
                        case "Movie name": sOrderBy = "Movie_Name_"; break;
                        case "Total tickets": sOrderBy = "Ticket_Total_"; break;
                        case "Total revenue": sOrderBy = "Revenue_Total_"; break;
                    }

                    if (rbtnAscending.Checked)
                    {
                        sReportTitle += "\nordered by " + cmbSort.Text + " " + rbtnAscending.Text;
                        sOrderBy += "ASC";
                    }
                    else
                    {
                        sReportTitle += "\nordered by " + cmbSort.Text + " " + rbtnDescending.Text;
                        sOrderBy += "DESC";
                    }
                }
                else if (rbtnTicketEmployee.Checked)
                    sOrderBy = "Employee_ID";
                else
                    sOrderBy = "Movie_ID";

                //Display report title
                lblReportTitle.Text = sReportTitle;

                //Clear all rows and chart
                grdReport.Rows.Clear();
                chtReport.Series.Clear();

                //Hide all columns
                foreach (DataGridViewColumn column in grdReport.Columns)
                    column.Visible = false;

                //Display relevant columns based on report choice
                if (rbtnTicketEmployee.Checked)
                {
                    grdReport.Columns["Employee_Name"].Visible = true;
                    grdReport.Columns["Employee_Name"].DisplayIndex = 0;
                    grdReport.Columns["Employee_ID"].Visible = true;
                    grdReport.Columns["Employee_ID"].DisplayIndex = 1;
                }
                else
                {
                    grdReport.Columns["Movie_Name"].Visible = true;
                    grdReport.Columns["Movie_Name"].DisplayIndex = 0;
                    grdReport.Columns["Movie_ID"].Visible = true;
                    grdReport.Columns["Movie_ID"].DisplayIndex = 1;
                }
                grdReport.Columns["Total_Tickets"].Visible = true;

                //Get all years and months within the selected financial year
                for (DateTime DateCounter = dtpStartDate.Value.Date.AddDays(1); DateCounter <= dtpEndDate.Value.Date; DateCounter = DateCounter.AddDays(1))
                {
                    DateTime OldDate = DateCounter.AddDays(-1);
                    if (OldDate == dtpStartDate.Value.Date)
                        TimePeriod.Add(OldDate);
                    else if (DateCounter.Month == OldDate.Month && DateCounter.Year != OldDate.Year)
                        TimePeriod.Add(DateCounter);
                    else if (DateCounter.Month != OldDate.Month)
                        TimePeriod.Add(DateCounter);
                }

                //Show month columns applicable
                for (int i = 0; i < TimePeriod.Count; i++)
                {
                    if (i == 12)
                    {
                        grdReport.Columns["Month12"].DisplayIndex = 2 + i;
                        grdReport.Columns["Month12"].Visible = true;
                        grdReport.Columns["Month12"].HeaderText = TimePeriod[i].ToString("MMM-yy");
                    }
                    else
                    {
                        grdReport.Columns["Month" + (TimePeriod[i].Month - 1)].DisplayIndex = 2 + i;
                        grdReport.Columns["Month" + (TimePeriod[i].Month - 1)].Visible = true;
                        grdReport.Columns["Month" + (TimePeriod[i].Month - 1)].HeaderText = TimePeriod[i].ToString("MMM-yy");
                    }
                }

                //Show revenue if requested
                if (chbRevenue.Checked)
                    grdReport.Columns["Total_Revenue"].Visible = true;

                //Open database connection to execute report stored procedures
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AlternativeDB.mdf;Integrated Security=True");
                conn.Open();

                //Get report choice
                if (rbtnTicketEmployee.Checked)
                    sCommand = "Report_Employee_Names_And_Ticket_Totals";
                else
                    sCommand = "Report_Movie_Names_And_Ticket_Totals";

                //Execute report stored procedure
                mainCommand = new SqlCommand(sCommand, conn);
                mainCommand.CommandType = CommandType.StoredProcedure;
                mainCommand.Parameters.AddWithValue("@Start_Date", dtpStartDate.Value.Date);
                mainCommand.Parameters.AddWithValue("@End_Date", dtpEndDate.Value.Date);
                mainCommand.Parameters.AddWithValue("@Order_By", sOrderBy);

                //Read report query into datatable
                adapter = new SqlDataAdapter(mainCommand);
                mainDt = new DataTable();
                adapter.Fill(mainDt);

                //For each movie or employee depending on report choice
                foreach (DataRow totalRow in mainDt.Rows)
                {
                    grdReport.Rows.Add();

                    //Run relative sub report to display movie or employee tickets per month
                    if (rbtnTicketEmployee.Checked)
                    {
                        iEmployee_ID = int.Parse(totalRow[0].ToString());
                        sEmployee_Name = totalRow[1].ToString();
                        grdReport.Rows[grdReport.RowCount - 1].Cells["Employee_Name"].Value = sEmployee_Name;
                        grdReport.Rows[grdReport.RowCount - 1].Cells["Employee_ID"].Value = iEmployee_ID;

                        //Get employee's tickets sold per month
                        subCommand = new SqlCommand("Report_Monthly_Employee_Tickets", conn);
                        subCommand.CommandType = CommandType.StoredProcedure;
                        subCommand.Parameters.AddWithValue("@Employee_Number", iEmployee_ID);
                    }
                    else
                    {
                        iMovie_ID = int.Parse(totalRow[0].ToString());
                        sMovie_Name = totalRow[1].ToString();
                        grdReport.Rows[grdReport.RowCount - 1].Cells["Movie_Name"].Value = sMovie_Name;
                        grdReport.Rows[grdReport.RowCount - 1].Cells["Movie_ID"].Value = iMovie_ID;

                        //Get movie's tickets sold per month
                        subCommand = new SqlCommand("Report_Monthly_Movie_Tickets", conn);
                        subCommand.CommandType = CommandType.StoredProcedure;
                        subCommand.Parameters.AddWithValue("@Movie_Number", iMovie_ID);
                    }

                    //Get total tickets and total revenue
                    iTicketTotal = int.Parse(totalRow[2].ToString());
                    dRevenueTotal = decimal.Parse(totalRow[3].ToString());
                    subCommand.Parameters.AddWithValue("@Start_Date", dtpStartDate.Value.Date);
                    subCommand.Parameters.AddWithValue("@End_Date", dtpEndDate.Value.Date);

                    //Fill datatable with sub report
                    adapter = new SqlDataAdapter(subCommand);
                    subDt = new DataTable();
                    adapter.Fill(subDt);

                    //Get monthly tickets for every movie or employee
                    foreach (DataRow ticketRow in subDt.Rows)
                    {
                        iMonthly_Tickets_Per_Movie_OR_Employee = int.Parse(ticketRow[2].ToString());

                        if (iCounter == 12)
                        {
                            iMonthly_Tickets[12] = iMonthly_Tickets_Per_Movie_OR_Employee;
                        }
                        else
                        {
                            iMonth = int.Parse(ticketRow[1].ToString());

                            switch (iMonth)
                            {
                                case 1: iMonthly_Tickets[0] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 2: iMonthly_Tickets[1] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 3: iMonthly_Tickets[2] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 4: iMonthly_Tickets[3] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 5: iMonthly_Tickets[4] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 6: iMonthly_Tickets[5] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 7: iMonthly_Tickets[6] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 8: iMonthly_Tickets[7] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 9: iMonthly_Tickets[8] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 10: iMonthly_Tickets[9] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 11: iMonthly_Tickets[10] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                                case 12: iMonthly_Tickets[11] = iMonthly_Tickets_Per_Movie_OR_Employee; break;
                            }
                        }
                        iCounter++;
                    }

                    //Fill in months with employee or movie tickets
                    iCounter = 0;
                    foreach (DateTime MonthYear in TimePeriod)
                    {
                        int iRow = grdReport.RowCount - 1;
                        if (iCounter == 12)
                        {
                            string sColumn = "Month" + 12;
                            grdReport.Rows[iRow].Cells[sColumn].Value = iMonthly_Tickets[12];
                        }
                        else
                        {
                            string sColumn = "Month" + (MonthYear.Month - 1);
                            grdReport.Rows[iRow].Cells[sColumn].Value = iMonthly_Tickets[MonthYear.Month - 1];
                        }
                        iCounter++;
                    }

                    //Fill in employee or movie total tickets and revenue
                    grdReport.Rows[grdReport.RowCount - 1].Cells["Total_Tickets"].Value = iTicketTotal;
                    grdReport.Rows[grdReport.RowCount - 1].Cells["Total_Revenue"].Value = dRevenueTotal;

                    //Clear array for next movie or employee
                    iMonthly_Tickets = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                }

                //Fill datatable with grand total report
                mainCommand = new SqlCommand("Report_Grand_Total_Tickets_And_Revenue", conn);
                mainCommand.CommandType = CommandType.StoredProcedure;
                mainCommand.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                mainCommand.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                mainCommand.Parameters.AddWithValue("@OrderBy", sOrderBy);
                mainCommand.Parameters.AddWithValue("@ReportChoice", sCommand);

                //Add timeslot_ID to table
                adapter = new SqlDataAdapter(mainCommand);
                mainDt = new DataTable();
                adapter.Fill(mainDt);

                //Display ticket and revenue grand total
                int.TryParse(mainDt.Rows[0][0].ToString(), out int GrandTotalTickets);
                decimal.TryParse(mainDt.Rows[0][1].ToString(), out decimal GrandTotalRevenue);
                lblGrandTotalTickets.Text = "Grand total tickets: " + GrandTotalTickets;
                lblGrandTotalRevenue.Text = "Grand total revenue: " + GrandTotalRevenue.ToString("C");

                //Close connection to database after report stored procedures have executed
                conn.Close();

                //If chart option is selected
                if (chbChart.Checked && grdReport.Rows.Count > 0)
                {
                    //X and Y axis titles
                    chtReport.ChartAreas[0].AxisX.Title = "Month and year";
                    chtReport.ChartAreas[0].AxisY.Title = "Tickets";

                    //Chart report information
                    int iColumn = 0;
                    if (rbtnTicketEmployee.Checked)
                    {
                        iColumn = grdReport.Columns["Employee_ID"].Index;
                        chtReport.Legends[0].Title = "Employee number:";
                    }
                    else
                    {
                        iColumn = grdReport.Columns["Movie_ID"].Index;
                        chtReport.Legends[0].Title = "Movie number:";
                    }

                    //For random colour
                    Random r = new Random();

                    //Get data into columns
                    for (int i = 0; i < grdReport.Rows.Count; i++)
                    {
                        Series S = chtReport.Series.Add(grdReport.Rows[i].Cells[iColumn].Value.ToString());
                        S.ChartType = SeriesChartType.Column;
                        S.Color = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));

                        foreach (DataGridViewColumn myColumn in grdReport.Columns.OfType<DataGridViewColumn>().OrderBy(x => x.DisplayIndex))
                        {
                            if (myColumn.Name.Contains("Month") && myColumn.Visible)
                                chtReport.Series[i].Points.AddXY(myColumn.HeaderText, grdReport.Rows[i].Cells[myColumn.Name].Value);
                        }
                    }
                }
            }
        }

        private void frmRequestReports_Load(object sender, EventArgs e)
        {
            //Initialise date for implementation
            dtpStartDate.MinDate = new DateTime(2024, 9, 1);
            dtpEndDate.MinDate = new DateTime(2024, 9, 2);

            //Access control
            grpSort.Enabled = false;

            //Format columns
            grdReport.Columns["Employee_ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReport.Columns["Movie_ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReport.Columns["Total_Tickets"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReport.Columns["Total_Revenue"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Format month columns and hide all columns
            foreach (DataGridViewColumn column in grdReport.Columns)
            {
                if (column.Name.Contains("Month"))
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                column.Visible = false;
            }
        }

        private void rbtnTicketEmployee_CheckedChanged(object sender, EventArgs e)
        {
            chbSort_CheckedChanged(sender, e);
        }

        private void rbtnTicketMovie_CheckedChanged(object sender, EventArgs e)
        {
            chbSort_CheckedChanged(sender, e);
        }

        private void chbSort_CheckedChanged(object sender, EventArgs e)
        {
            cmbSort.Items.Clear();

            //Add sorting options
            if (chbSort.Checked)
            {
                grpSort.Enabled = true;
                rbtnAscending.Checked = true;

                if (rbtnTicketEmployee.Checked)
                    cmbSort.Items.Add("Employee name");
                else
                    cmbSort.Items.Add("Movie name");

                cmbSort.Items.Add("Total tickets");

                if (chbRevenue.Checked)
                    cmbSort.Items.Add("Total revenue");

                cmbSort.SelectedIndex = 0;
            }
            else
            {
                cmbSort.SelectedIndex = -1;
                rbtnAscending.Checked = false;
                rbtnDescending.Checked = false;
                grpSort.Enabled = false;
            }
        }

        private void chbRevenue_CheckedChanged(object sender, EventArgs e)
        {
            //If revenue checked or unchecked 
            if (chbSort.Checked && chbRevenue.Checked == false && cmbSort.Items.Contains("Total revenue"))
                cmbSort.Items.RemoveAt(2);
            if (chbSort.Checked && chbRevenue.Checked && cmbSort.Items.Contains("Total revenue") == false)
                cmbSort.Items.Add("Total revenue");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            //Validate dates
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                erpDates.SetError(dtpEndDate, "End date cannot be earlier than the start date.");
                bValidDates = false;
            }
            else if ((dtpEndDate.Value - dtpStartDate.Value).TotalDays > 365)
            {
                erpDates.SetError(dtpEndDate, "Max date range is 1 financial year (365 days).");
                bValidDates = false;
            }
            else
            {
                erpDates.SetError(dtpEndDate, "");
                bValidDates = true;
            }
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