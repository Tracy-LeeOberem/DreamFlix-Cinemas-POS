namespace CMPG223_GROUP6_Project
{
    partial class frmRequestReports
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlReportOptions = new System.Windows.Forms.Panel();
            this.grpDateRange = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSummaryInformation = new System.Windows.Forms.GroupBox();
            this.chbRevenue = new System.Windows.Forms.CheckBox();
            this.chbChart = new System.Windows.Forms.CheckBox();
            this.chbSort = new System.Windows.Forms.CheckBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.rbtnDescending = new System.Windows.Forms.RadioButton();
            this.rbtnAscending = new System.Windows.Forms.RadioButton();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.rbtnTicketMovie = new System.Windows.Forms.RadioButton();
            this.rbtnTicketEmployee = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chtReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblGrandTotalRevenue = new System.Windows.Forms.Label();
            this.lblGrandTotalTickets = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblEndOfReport = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.erpDates = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlReportOptions.SuspendLayout();
            this.grpDateRange.SuspendLayout();
            this.grpSummaryInformation.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.grpReportType.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtReport)).BeginInit();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDates)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportOptions
            // 
            this.pnlReportOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReportOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReportOptions.Controls.Add(this.grpDateRange);
            this.pnlReportOptions.Controls.Add(this.btnGenerateReport);
            this.pnlReportOptions.Controls.Add(this.label1);
            this.pnlReportOptions.Controls.Add(this.grpSummaryInformation);
            this.pnlReportOptions.Controls.Add(this.grpSort);
            this.pnlReportOptions.Controls.Add(this.grpReportType);
            this.pnlReportOptions.Location = new System.Drawing.Point(8, 8);
            this.pnlReportOptions.Name = "pnlReportOptions";
            this.pnlReportOptions.Size = new System.Drawing.Size(648, 368);
            this.pnlReportOptions.TabIndex = 1;
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.dtpEndDate);
            this.grpDateRange.Controls.Add(this.dtpStartDate);
            this.grpDateRange.Controls.Add(this.label3);
            this.grpDateRange.Controls.Add(this.label2);
            this.grpDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDateRange.Location = new System.Drawing.Point(8, 184);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.Size = new System.Drawing.Size(352, 112);
            this.grpDateRange.TabIndex = 7;
            this.grpDateRange.TabStop = false;
            this.grpDateRange.Text = "Date range (One financial year)";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(96, 72);
            this.dtpEndDate.MinDate = new System.DateTime(2024, 9, 2, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 26);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.Value = new System.DateTime(2024, 9, 2, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(96, 32);
            this.dtpStartDate.MinDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 26);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.Value = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "End date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start date:";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(8, 312);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(160, 40);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report options";
            // 
            // grpSummaryInformation
            // 
            this.grpSummaryInformation.Controls.Add(this.chbRevenue);
            this.grpSummaryInformation.Controls.Add(this.chbChart);
            this.grpSummaryInformation.Controls.Add(this.chbSort);
            this.grpSummaryInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummaryInformation.Location = new System.Drawing.Point(376, 48);
            this.grpSummaryInformation.Name = "grpSummaryInformation";
            this.grpSummaryInformation.Size = new System.Drawing.Size(256, 128);
            this.grpSummaryInformation.TabIndex = 3;
            this.grpSummaryInformation.TabStop = false;
            this.grpSummaryInformation.Text = "Summary information";
            // 
            // chbRevenue
            // 
            this.chbRevenue.AutoSize = true;
            this.chbRevenue.Location = new System.Drawing.Point(8, 96);
            this.chbRevenue.Name = "chbRevenue";
            this.chbRevenue.Size = new System.Drawing.Size(138, 24);
            this.chbRevenue.TabIndex = 3;
            this.chbRevenue.Text = "Show revenue?";
            this.chbRevenue.UseVisualStyleBackColor = true;
            this.chbRevenue.CheckedChanged += new System.EventHandler(this.chbRevenue_CheckedChanged);
            // 
            // chbChart
            // 
            this.chbChart.AutoSize = true;
            this.chbChart.Location = new System.Drawing.Point(8, 64);
            this.chbChart.Name = "chbChart";
            this.chbChart.Size = new System.Drawing.Size(129, 24);
            this.chbChart.TabIndex = 2;
            this.chbChart.Text = "Include chart?";
            this.chbChart.UseVisualStyleBackColor = true;
            // 
            // chbSort
            // 
            this.chbSort.AutoSize = true;
            this.chbSort.Location = new System.Drawing.Point(8, 32);
            this.chbSort.Name = "chbSort";
            this.chbSort.Size = new System.Drawing.Size(150, 24);
            this.chbSort.TabIndex = 1;
            this.chbSort.Text = "Sort information?";
            this.chbSort.UseVisualStyleBackColor = true;
            this.chbSort.CheckedChanged += new System.EventHandler(this.chbSort_CheckedChanged);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.cmbSort);
            this.grpSort.Controls.Add(this.rbtnDescending);
            this.grpSort.Controls.Add(this.rbtnAscending);
            this.grpSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSort.Location = new System.Drawing.Point(376, 184);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(256, 112);
            this.grpSort.TabIndex = 1;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort by";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(8, 24);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(240, 28);
            this.cmbSort.TabIndex = 23;
            // 
            // rbtnDescending
            // 
            this.rbtnDescending.AutoSize = true;
            this.rbtnDescending.Location = new System.Drawing.Point(136, 72);
            this.rbtnDescending.Name = "rbtnDescending";
            this.rbtnDescending.Size = new System.Drawing.Size(112, 24);
            this.rbtnDescending.TabIndex = 2;
            this.rbtnDescending.TabStop = true;
            this.rbtnDescending.Text = "Descending";
            this.rbtnDescending.UseVisualStyleBackColor = true;
            // 
            // rbtnAscending
            // 
            this.rbtnAscending.AutoSize = true;
            this.rbtnAscending.Location = new System.Drawing.Point(16, 72);
            this.rbtnAscending.Name = "rbtnAscending";
            this.rbtnAscending.Size = new System.Drawing.Size(102, 24);
            this.rbtnAscending.TabIndex = 1;
            this.rbtnAscending.TabStop = true;
            this.rbtnAscending.Text = "Ascending";
            this.rbtnAscending.UseVisualStyleBackColor = true;
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.rbtnTicketMovie);
            this.grpReportType.Controls.Add(this.rbtnTicketEmployee);
            this.grpReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(8, 48);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(352, 128);
            this.grpReportType.TabIndex = 0;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Report type";
            // 
            // rbtnTicketMovie
            // 
            this.rbtnTicketMovie.AutoSize = true;
            this.rbtnTicketMovie.Location = new System.Drawing.Point(16, 72);
            this.rbtnTicketMovie.Name = "rbtnTicketMovie";
            this.rbtnTicketMovie.Size = new System.Drawing.Size(258, 24);
            this.rbtnTicketMovie.TabIndex = 1;
            this.rbtnTicketMovie.TabStop = true;
            this.rbtnTicketMovie.Text = "Tickets sold per Movie per Month";
            this.rbtnTicketMovie.UseVisualStyleBackColor = true;
            this.rbtnTicketMovie.CheckedChanged += new System.EventHandler(this.rbtnTicketMovie_CheckedChanged);
            // 
            // rbtnTicketEmployee
            // 
            this.rbtnTicketEmployee.AutoSize = true;
            this.rbtnTicketEmployee.Location = new System.Drawing.Point(16, 32);
            this.rbtnTicketEmployee.Name = "rbtnTicketEmployee";
            this.rbtnTicketEmployee.Size = new System.Drawing.Size(287, 24);
            this.rbtnTicketEmployee.TabIndex = 0;
            this.rbtnTicketEmployee.TabStop = true;
            this.rbtnTicketEmployee.Text = "Tickets sold per Employee per Month";
            this.rbtnTicketEmployee.UseVisualStyleBackColor = true;
            this.rbtnTicketEmployee.CheckedChanged += new System.EventHandler(this.rbtnTicketEmployee_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chtReport);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(666, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 366);
            this.panel1.TabIndex = 6;
            // 
            // chtReport
            // 
            this.chtReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -90;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chtReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtReport.Legends.Add(legend1);
            this.chtReport.Location = new System.Drawing.Point(8, 48);
            this.chtReport.Name = "chtReport";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtReport.Series.Add(series1);
            this.chtReport.Size = new System.Drawing.Size(630, 312);
            this.chtReport.TabIndex = 9;
            this.chtReport.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chart";
            // 
            // pnlReport
            // 
            this.pnlReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReport.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReport.Controls.Add(this.btnDashboard);
            this.pnlReport.Controls.Add(this.lblGrandTotalRevenue);
            this.pnlReport.Controls.Add(this.lblGrandTotalTickets);
            this.pnlReport.Controls.Add(this.lblPage);
            this.pnlReport.Controls.Add(this.lblEndOfReport);
            this.pnlReport.Controls.Add(this.lblReportTitle);
            this.pnlReport.Controls.Add(this.lblTimeStamp);
            this.pnlReport.Controls.Add(this.grdReport);
            this.pnlReport.Controls.Add(this.label5);
            this.pnlReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReport.Location = new System.Drawing.Point(8, 384);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1304, 375);
            this.pnlReport.TabIndex = 7;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(1128, 319);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 40);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "Back to dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblGrandTotalRevenue
            // 
            this.lblGrandTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrandTotalRevenue.AutoSize = true;
            this.lblGrandTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalRevenue.Location = new System.Drawing.Point(288, 287);
            this.lblGrandTotalRevenue.Name = "lblGrandTotalRevenue";
            this.lblGrandTotalRevenue.Size = new System.Drawing.Size(154, 20);
            this.lblGrandTotalRevenue.TabIndex = 13;
            this.lblGrandTotalRevenue.Text = "Grand total revenue:";
            // 
            // lblGrandTotalTickets
            // 
            this.lblGrandTotalTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrandTotalTickets.AutoSize = true;
            this.lblGrandTotalTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalTickets.Location = new System.Drawing.Point(16, 287);
            this.lblGrandTotalTickets.Name = "lblGrandTotalTickets";
            this.lblGrandTotalTickets.Size = new System.Drawing.Size(143, 20);
            this.lblGrandTotalTickets.TabIndex = 12;
            this.lblGrandTotalTickets.Text = "Grand total tickets:";
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(1200, 40);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(90, 20);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "Page 1 of 1";
            // 
            // lblEndOfReport
            // 
            this.lblEndOfReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEndOfReport.AutoSize = true;
            this.lblEndOfReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOfReport.Location = new System.Drawing.Point(16, 335);
            this.lblEndOfReport.Name = "lblEndOfReport";
            this.lblEndOfReport.Size = new System.Drawing.Size(183, 20);
            this.lblEndOfReport.TabIndex = 10;
            this.lblEndOfReport.Text = "*** END OF REPORT ***";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(16, 80);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(91, 20);
            this.lblReportTitle.TabIndex = 9;
            this.lblReportTitle.Text = "Report title:";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStamp.Location = new System.Drawing.Point(16, 48);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(87, 20);
            this.lblTimeStamp.TabIndex = 8;
            this.lblTimeStamp.Text = "timestamp:";
            // 
            // grdReport
            // 
            this.grdReport.AllowUserToAddRows = false;
            this.grdReport.AllowUserToDeleteRows = false;
            this.grdReport.AllowUserToResizeColumns = false;
            this.grdReport.AllowUserToResizeRows = false;
            this.grdReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Name,
            this.Movie_Name,
            this.Employee_ID,
            this.Movie_ID,
            this.Month0,
            this.Month1,
            this.Month2,
            this.Month3,
            this.Month4,
            this.Month5,
            this.Month6,
            this.Month7,
            this.Month8,
            this.Month9,
            this.Month10,
            this.Month11,
            this.Month12,
            this.Total_Tickets,
            this.Total_Revenue});
            this.grdReport.Location = new System.Drawing.Point(16, 128);
            this.grdReport.Name = "grdReport";
            this.grdReport.ReadOnly = true;
            this.grdReport.RowHeadersVisible = false;
            this.grdReport.RowHeadersWidth = 10;
            this.grdReport.Size = new System.Drawing.Size(1272, 143);
            this.grdReport.TabIndex = 7;
            // 
            // Employee_Name
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Employee_Name.DefaultCellStyle = dataGridViewCellStyle1;
            this.Employee_Name.FillWeight = 121.8274F;
            this.Employee_Name.HeaderText = "Employee name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employee_Name.Width = 116;
            // 
            // Movie_Name
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Movie_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Movie_Name.HeaderText = "Movie name";
            this.Movie_Name.Name = "Movie_Name";
            this.Movie_Name.ReadOnly = true;
            this.Movie_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Movie_Name.Width = 90;
            // 
            // Employee_ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Employee_ID.FillWeight = 119.9383F;
            this.Employee_ID.HeaderText = "Employee number";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            this.Employee_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employee_ID.Width = 129;
            // 
            // Movie_ID
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Movie_ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.Movie_ID.HeaderText = "Movie number";
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.ReadOnly = true;
            this.Movie_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Movie_ID.Width = 103;
            // 
            // Month0
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month0.DefaultCellStyle = dataGridViewCellStyle5;
            this.Month0.FillWeight = 97.01673F;
            this.Month0.HeaderText = "Month0";
            this.Month0.Name = "Month0";
            this.Month0.ReadOnly = true;
            this.Month0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month0.Width = 69;
            // 
            // Month1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Month1.FillWeight = 97.01673F;
            this.Month1.HeaderText = "Month1";
            this.Month1.Name = "Month1";
            this.Month1.ReadOnly = true;
            this.Month1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month1.Width = 69;
            // 
            // Month2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Month2.FillWeight = 97.01673F;
            this.Month2.HeaderText = "Month2";
            this.Month2.Name = "Month2";
            this.Month2.ReadOnly = true;
            this.Month2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month2.Width = 69;
            // 
            // Month3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Month3.FillWeight = 97.01673F;
            this.Month3.HeaderText = "Month3";
            this.Month3.Name = "Month3";
            this.Month3.ReadOnly = true;
            this.Month3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month3.Width = 69;
            // 
            // Month4
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month4.DefaultCellStyle = dataGridViewCellStyle9;
            this.Month4.FillWeight = 97.01673F;
            this.Month4.HeaderText = "Month4";
            this.Month4.Name = "Month4";
            this.Month4.ReadOnly = true;
            this.Month4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month4.Width = 69;
            // 
            // Month5
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month5.DefaultCellStyle = dataGridViewCellStyle10;
            this.Month5.FillWeight = 97.01673F;
            this.Month5.HeaderText = "Month5";
            this.Month5.Name = "Month5";
            this.Month5.ReadOnly = true;
            this.Month5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month5.Width = 69;
            // 
            // Month6
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month6.DefaultCellStyle = dataGridViewCellStyle11;
            this.Month6.FillWeight = 97.01673F;
            this.Month6.HeaderText = "Month6";
            this.Month6.Name = "Month6";
            this.Month6.ReadOnly = true;
            this.Month6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month6.Width = 69;
            // 
            // Month7
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month7.DefaultCellStyle = dataGridViewCellStyle12;
            this.Month7.FillWeight = 97.01673F;
            this.Month7.HeaderText = "Month7";
            this.Month7.Name = "Month7";
            this.Month7.ReadOnly = true;
            this.Month7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month7.Width = 69;
            // 
            // Month8
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month8.DefaultCellStyle = dataGridViewCellStyle13;
            this.Month8.FillWeight = 97.01673F;
            this.Month8.HeaderText = "Month8";
            this.Month8.Name = "Month8";
            this.Month8.ReadOnly = true;
            this.Month8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month8.Width = 69;
            // 
            // Month9
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month9.DefaultCellStyle = dataGridViewCellStyle14;
            this.Month9.FillWeight = 97.01673F;
            this.Month9.HeaderText = "Month9";
            this.Month9.Name = "Month9";
            this.Month9.ReadOnly = true;
            this.Month9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month9.Width = 69;
            // 
            // Month10
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month10.DefaultCellStyle = dataGridViewCellStyle15;
            this.Month10.FillWeight = 97.01673F;
            this.Month10.HeaderText = "Month10";
            this.Month10.Name = "Month10";
            this.Month10.ReadOnly = true;
            this.Month10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month10.Width = 78;
            // 
            // Month11
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month11.DefaultCellStyle = dataGridViewCellStyle16;
            this.Month11.FillWeight = 97.01673F;
            this.Month11.HeaderText = "Month11";
            this.Month11.Name = "Month11";
            this.Month11.ReadOnly = true;
            this.Month11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month11.Width = 78;
            // 
            // Month12
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Month12.DefaultCellStyle = dataGridViewCellStyle17;
            this.Month12.HeaderText = "Month12";
            this.Month12.Name = "Month12";
            this.Month12.ReadOnly = true;
            this.Month12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Month12.Width = 78;
            // 
            // Total_Tickets
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Total_Tickets.DefaultCellStyle = dataGridViewCellStyle18;
            this.Total_Tickets.FillWeight = 97.01673F;
            this.Total_Tickets.HeaderText = "Total tickets";
            this.Total_Tickets.Name = "Total_Tickets";
            this.Total_Tickets.ReadOnly = true;
            this.Total_Tickets.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total_Tickets.Width = 90;
            // 
            // Total_Revenue
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.Total_Revenue.DefaultCellStyle = dataGridViewCellStyle19;
            this.Total_Revenue.FillWeight = 97.01673F;
            this.Total_Revenue.HeaderText = "Total revenue";
            this.Total_Revenue.Name = "Total_Revenue";
            this.Total_Revenue.ReadOnly = true;
            this.Total_Revenue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Report";
            // 
            // erpDates
            // 
            this.erpDates.ContainerControl = this;
            // 
            // frmRequestReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 767);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReportOptions);
            this.Name = "frmRequestReports";
            this.Text = "Request reports form";
            this.Load += new System.EventHandler(this.frmRequestReports_Load);
            this.pnlReportOptions.ResumeLayout(false);
            this.pnlReportOptions.PerformLayout();
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            this.grpSummaryInformation.ResumeLayout(false);
            this.grpSummaryInformation.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtReport)).EndInit();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportOptions;
        private System.Windows.Forms.GroupBox grpDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSummaryInformation;
        private System.Windows.Forms.CheckBox chbRevenue;
        private System.Windows.Forms.CheckBox chbChart;
        private System.Windows.Forms.CheckBox chbSort;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.RadioButton rbtnDescending;
        private System.Windows.Forms.RadioButton rbtnAscending;
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton rbtnTicketMovie;
        private System.Windows.Forms.RadioButton rbtnTicketEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblGrandTotalRevenue;
        private System.Windows.Forms.Label lblGrandTotalTickets;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblEndOfReport;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.DataGridView grdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Revenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider erpDates;
    }
}