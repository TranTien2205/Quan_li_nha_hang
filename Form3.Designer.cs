using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_li_nha_hang
{
     partial class Form3
     {
          private System.ComponentModel.IContainer components = null;
          private Panel panel1;
          private PictureBox pictureBoxLogo;
          private Button btnManageMenu;
          private Button btnManageRevenue;
          private Button btnManageTables;
          private Button btnManageCustomers;
          private Button btnManageEmployees;
          private Button btnDashboard;
          private Button btnLogout;
          private Label lblClock;
          private Panel mainPanel; 
          private Panel panel4;
          private Label lblTitle;
          private Panel panel5;
          private Label lblRevenue;
          private PictureBox pictureBoxRevenue;
          private Panel panel6;
          private Label lblTableBookings;
          private PictureBox pictureBoxTable;
          private Panel panel7;
          private Chart chartMenuRevenue;
          private Panel panel8;
          private Chart chartMonthlySales;
          private DataGridView dataGridView; 
          private Chart chart1; 
          private Label lblTotalRevenue; 
          private Label lblTotalCustomers; 
          private Label lblLowInventory; 
          private Label lblTableStatus; 
          private Label lblOutstandingBalance; 
          private Label lblOutstandingBalanceValue; 
          private Label lblCustomerChartTitle; 

          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          private void InitializeComponent()
          {
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 13248D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 57088D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 41528D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 54168D);
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 40D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 60D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 120D);
               System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1000D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3000D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4000D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5000D);
               System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7000D);
               this.panel1 = new System.Windows.Forms.Panel();
               this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
               this.btnManageMenu = new System.Windows.Forms.Button();
               this.btnManageRevenue = new System.Windows.Forms.Button();
               this.btnManageTables = new System.Windows.Forms.Button();
               this.btnManageCustomers = new System.Windows.Forms.Button();
               this.btnManageEmployees = new System.Windows.Forms.Button();
               this.btnDashboard = new System.Windows.Forms.Button();
               this.btnLogout = new System.Windows.Forms.Button();
               this.lblClock = new System.Windows.Forms.Label();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.dataGridView = new System.Windows.Forms.DataGridView();
               this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.lblTotalRevenue = new System.Windows.Forms.Label();
               this.lblTotalCustomers = new System.Windows.Forms.Label();
               this.lblLowInventory = new System.Windows.Forms.Label();
               this.lblTableStatus = new System.Windows.Forms.Label();
               this.lblOutstandingBalance = new System.Windows.Forms.Label();
               this.lblOutstandingBalanceValue = new System.Windows.Forms.Label();
               this.lblCustomerChartTitle = new System.Windows.Forms.Label();
               this.panel4 = new System.Windows.Forms.Panel();
               this.lblTitle = new System.Windows.Forms.Label();
               this.panel5 = new System.Windows.Forms.Panel();
               this.lblRevenue = new System.Windows.Forms.Label();
               this.pictureBoxRevenue = new System.Windows.Forms.PictureBox();
               this.panel6 = new System.Windows.Forms.Panel();
               this.lblTableBookings = new System.Windows.Forms.Label();
               this.pictureBoxTable = new System.Windows.Forms.PictureBox();
               this.panel7 = new System.Windows.Forms.Panel();
               this.chartMenuRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.panel8 = new System.Windows.Forms.Panel();
               this.chartMonthlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
               this.mainPanel.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
               this.panel4.SuspendLayout();
               this.panel5.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).BeginInit();
               this.panel6.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
               this.panel7.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.chartMenuRevenue)).BeginInit();
               this.panel8.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySales)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel1.Controls.Add(this.pictureBoxLogo);
               this.panel1.Controls.Add(this.btnManageMenu);
               this.panel1.Controls.Add(this.btnManageRevenue);
               this.panel1.Controls.Add(this.btnManageTables);
               this.panel1.Controls.Add(this.btnManageCustomers);
               this.panel1.Controls.Add(this.btnManageEmployees);
               this.panel1.Controls.Add(this.btnDashboard);
               this.panel1.Controls.Add(this.btnLogout);
               this.panel1.Location = new System.Drawing.Point(2, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(172, 587);
               this.panel1.TabIndex = 0;
               // 
               // pictureBoxLogo
               // 
               this.pictureBoxLogo.Image = global::Quan_li_nha_hang.Properties.Resources.Nhahang;
               this.pictureBoxLogo.Location = new System.Drawing.Point(9, 3);
               this.pictureBoxLogo.Name = "pictureBoxLogo";
               this.pictureBoxLogo.Size = new System.Drawing.Size(154, 125);
               this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxLogo.TabIndex = 10;
               this.pictureBoxLogo.TabStop = false;
               // 
               // btnManageMenu
               // 
               this.btnManageMenu.BackColor = System.Drawing.Color.LightPink;
               this.btnManageMenu.FlatAppearance.BorderSize = 0;
               this.btnManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnManageMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnManageMenu.ForeColor = System.Drawing.Color.White;
               this.btnManageMenu.Location = new System.Drawing.Point(9, 339);
               this.btnManageMenu.Name = "btnManageMenu";
               this.btnManageMenu.Size = new System.Drawing.Size(154, 35);
               this.btnManageMenu.TabIndex = 9;
               this.btnManageMenu.Text = "QUẢN LÝ THỰC ĐƠN";
               this.btnManageMenu.UseVisualStyleBackColor = false;
               // 
               // btnManageRevenue
               // 
               this.btnManageRevenue.BackColor = System.Drawing.Color.LightPink;
               this.btnManageRevenue.FlatAppearance.BorderSize = 0;
               this.btnManageRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnManageRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnManageRevenue.ForeColor = System.Drawing.Color.White;
               this.btnManageRevenue.Location = new System.Drawing.Point(9, 298);
               this.btnManageRevenue.Name = "btnManageRevenue";
               this.btnManageRevenue.Size = new System.Drawing.Size(154, 35);
               this.btnManageRevenue.TabIndex = 8;
               this.btnManageRevenue.Text = "QUẢN LÝ DOANH THU";
               this.btnManageRevenue.UseVisualStyleBackColor = false;
               // 
               // btnManageTables
               // 
               this.btnManageTables.BackColor = System.Drawing.Color.LightPink;
               this.btnManageTables.FlatAppearance.BorderSize = 0;
               this.btnManageTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnManageTables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnManageTables.ForeColor = System.Drawing.Color.White;
               this.btnManageTables.Location = new System.Drawing.Point(9, 257);
               this.btnManageTables.Name = "btnManageTables";
               this.btnManageTables.Size = new System.Drawing.Size(154, 35);
               this.btnManageTables.TabIndex = 7;
               this.btnManageTables.Text = "QUẢN LÝ BÀN ĂN";
               this.btnManageTables.UseVisualStyleBackColor = false;
               // 
               // btnManageCustomers
               // 
               this.btnManageCustomers.BackColor = System.Drawing.Color.LightPink;
               this.btnManageCustomers.FlatAppearance.BorderSize = 0;
               this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnManageCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnManageCustomers.ForeColor = System.Drawing.Color.White;
               this.btnManageCustomers.Location = new System.Drawing.Point(9, 216);
               this.btnManageCustomers.Name = "btnManageCustomers";
               this.btnManageCustomers.Size = new System.Drawing.Size(154, 35);
               this.btnManageCustomers.TabIndex = 6;
               this.btnManageCustomers.Text = "QUẢN LÝ KHÁCH HÀNG";
               this.btnManageCustomers.UseVisualStyleBackColor = false;
               // 
               // btnManageEmployees
               // 
               this.btnManageEmployees.BackColor = System.Drawing.Color.LightPink;
               this.btnManageEmployees.FlatAppearance.BorderSize = 0;
               this.btnManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnManageEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnManageEmployees.ForeColor = System.Drawing.Color.White;
               this.btnManageEmployees.Location = new System.Drawing.Point(9, 175);
               this.btnManageEmployees.Name = "btnManageEmployees";
               this.btnManageEmployees.Size = new System.Drawing.Size(154, 35);
               this.btnManageEmployees.TabIndex = 3;
               this.btnManageEmployees.Text = "QUẢN LÝ NHÂN VIÊN";
               this.btnManageEmployees.UseVisualStyleBackColor = false;
               this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
               // 
               // btnDashboard
               // 
               this.btnDashboard.BackColor = System.Drawing.Color.LightPink;
               this.btnDashboard.FlatAppearance.BorderSize = 0;
               this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnDashboard.ForeColor = System.Drawing.Color.White;
               this.btnDashboard.Location = new System.Drawing.Point(9, 134);
               this.btnDashboard.Name = "btnDashboard";
               this.btnDashboard.Size = new System.Drawing.Size(154, 35);
               this.btnDashboard.TabIndex = 2;
               this.btnDashboard.Text = "DASHBOARD";
               this.btnDashboard.UseVisualStyleBackColor = false;
               // 
               // btnLogout
               // 
               this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
               this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnLogout.ForeColor = System.Drawing.Color.White;
               this.btnLogout.Location = new System.Drawing.Point(10, 546);
               this.btnLogout.Name = "btnLogout";
               this.btnLogout.Size = new System.Drawing.Size(154, 26);
               this.btnLogout.TabIndex = 1;
               this.btnLogout.Text = "Đăng xuất";
               this.btnLogout.UseVisualStyleBackColor = false;
               // 
               // lblClock
               // 
               this.lblClock.Font = new System.Drawing.Font("Segoe UI", 10F);
               this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblClock.Location = new System.Drawing.Point(789, 4);
               this.lblClock.Name = "lblClock";
               this.lblClock.Size = new System.Drawing.Size(86, 26);
               this.lblClock.TabIndex = 1;
               this.lblClock.Text = "15:46";
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.White;
               this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.mainPanel.Controls.Add(this.lblClock);
               this.mainPanel.Controls.Add(this.dataGridView);
               this.mainPanel.Controls.Add(this.chart1);
               this.mainPanel.Controls.Add(this.lblTotalRevenue);
               this.mainPanel.Controls.Add(this.lblTotalCustomers);
               this.mainPanel.Controls.Add(this.lblLowInventory);
               this.mainPanel.Controls.Add(this.lblTableStatus);
               this.mainPanel.Controls.Add(this.lblOutstandingBalance);
               this.mainPanel.Controls.Add(this.lblOutstandingBalanceValue);
               this.mainPanel.Controls.Add(this.lblCustomerChartTitle);
               this.mainPanel.Location = new System.Drawing.Point(173, 0);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(880, 269);
               this.mainPanel.TabIndex = 3;
               // 
               // dataGridView
               // 
               this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView.Location = new System.Drawing.Point(13, 50);
               this.dataGridView.Name = "dataGridView";
               this.dataGridView.Size = new System.Drawing.Size(857, 128);
               this.dataGridView.TabIndex = 1;
               // 
               // chart1
               // 
               chartArea4.BackColor = System.Drawing.Color.Transparent;
               chartArea4.Name = "ChartArea3";
               this.chart1.ChartAreas.Add(chartArea4);
               legend4.Name = "Legend3";
               this.chart1.Legends.Add(legend4);
               this.chart1.Location = new System.Drawing.Point(10, 210);
               this.chart1.Name = "chart1";
               this.chart1.Size = new System.Drawing.Size(860, 40);
               this.chart1.TabIndex = 2;
               // 
               // lblTotalRevenue
               // 
               this.lblTotalRevenue.Location = new System.Drawing.Point(120, 10);
               this.lblTotalRevenue.Name = "lblTotalRevenue";
               this.lblTotalRevenue.Size = new System.Drawing.Size(200, 20);
               this.lblTotalRevenue.TabIndex = 3;
               this.lblTotalRevenue.Text = "Doanh thu hôm nay: 0 VNĐ";
               // 
               // lblTotalCustomers
               // 
               this.lblTotalCustomers.Location = new System.Drawing.Point(10, 30);
               this.lblTotalCustomers.Name = "lblTotalCustomers";
               this.lblTotalCustomers.Size = new System.Drawing.Size(200, 20);
               this.lblTotalCustomers.TabIndex = 4;
               this.lblTotalCustomers.Text = "Khách hôm nay: 0";
               // 
               // lblLowInventory
               // 
               this.lblLowInventory.Location = new System.Drawing.Point(220, 30);
               this.lblLowInventory.Name = "lblLowInventory";
               this.lblLowInventory.Size = new System.Drawing.Size(200, 20);
               this.lblLowInventory.TabIndex = 5;
               this.lblLowInventory.Text = "Nguyên liệu thấp: 0";
               // 
               // lblTableStatus
               // 
               this.lblTableStatus.Location = new System.Drawing.Point(430, 30);
               this.lblTableStatus.Name = "lblTableStatus";
               this.lblTableStatus.Size = new System.Drawing.Size(200, 20);
               this.lblTableStatus.TabIndex = 6;
               this.lblTableStatus.Text = "Trạng thái bàn: 0/0";
               // 
               // lblOutstandingBalance
               // 
               this.lblOutstandingBalance.Location = new System.Drawing.Point(640, 30);
               this.lblOutstandingBalance.Name = "lblOutstandingBalance";
               this.lblOutstandingBalance.Size = new System.Drawing.Size(100, 20);
               this.lblOutstandingBalance.TabIndex = 7;
               this.lblOutstandingBalance.Text = "Công nợ:";
               // 
               // lblOutstandingBalanceValue
               // 
               this.lblOutstandingBalanceValue.Location = new System.Drawing.Point(740, 30);
               this.lblOutstandingBalanceValue.Name = "lblOutstandingBalanceValue";
               this.lblOutstandingBalanceValue.Size = new System.Drawing.Size(100, 20);
               this.lblOutstandingBalanceValue.TabIndex = 8;
               this.lblOutstandingBalanceValue.Text = "0 VNĐ";
               // 
               // lblCustomerChartTitle
               // 
               this.lblCustomerChartTitle.Location = new System.Drawing.Point(10, 190);
               this.lblCustomerChartTitle.Name = "lblCustomerChartTitle";
               this.lblCustomerChartTitle.Size = new System.Drawing.Size(200, 20);
               this.lblCustomerChartTitle.TabIndex = 9;
               this.lblCustomerChartTitle.Text = "Biểu đồ khách hàng";
               // 
               // panel4
               // 
               this.panel4.BackColor = System.Drawing.Color.White;
               this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel4.Controls.Add(this.lblTitle);
               this.panel4.Location = new System.Drawing.Point(173, 275);
               this.panel4.Name = "panel4";
               this.panel4.Size = new System.Drawing.Size(880, 46);
               this.panel4.TabIndex = 4;
               // 
               // lblTitle
               // 
               this.lblTitle.BackColor = System.Drawing.Color.White;
               this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTitle.ForeColor = System.Drawing.Color.Black;
               this.lblTitle.Location = new System.Drawing.Point(374, 9);
               this.lblTitle.Name = "lblTitle";
               this.lblTitle.Size = new System.Drawing.Size(107, 26);
               this.lblTitle.TabIndex = 33;
               this.lblTitle.Text = "TỔNG QUAN";
               // 
               // panel5
               // 
               this.panel5.BackColor = System.Drawing.Color.White;
               this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel5.Controls.Add(this.lblRevenue);
               this.panel5.Controls.Add(this.pictureBoxRevenue);
               this.panel5.Location = new System.Drawing.Point(173, 327);
               this.panel5.Name = "panel5";
               this.panel5.Size = new System.Drawing.Size(269, 127);
               this.panel5.TabIndex = 5;
               // 
               // lblRevenue
               // 
               this.lblRevenue.BackColor = System.Drawing.Color.White;
               this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblRevenue.ForeColor = System.Drawing.Color.Black;
               this.lblRevenue.Location = new System.Drawing.Point(84, 0);
               this.lblRevenue.Name = "lblRevenue";
               this.lblRevenue.Size = new System.Drawing.Size(91, 26);
               this.lblRevenue.TabIndex = 34;
               this.lblRevenue.Text = "Doanh thu: 0";
               // 
               // pictureBoxRevenue
               // 
               this.pictureBoxRevenue.Image = global::Quan_li_nha_hang.Properties.Resources.th;
               this.pictureBoxRevenue.Location = new System.Drawing.Point(180, 39);
               this.pictureBoxRevenue.Name = "pictureBoxRevenue";
               this.pictureBoxRevenue.Size = new System.Drawing.Size(84, 50);
               this.pictureBoxRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxRevenue.TabIndex = 35;
               this.pictureBoxRevenue.TabStop = false;
               // 
               // panel6
               // 
               this.panel6.BackColor = System.Drawing.Color.White;
               this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel6.Controls.Add(this.lblTableBookings);
               this.panel6.Controls.Add(this.pictureBoxTable);
               this.panel6.Location = new System.Drawing.Point(173, 460);
               this.panel6.Name = "panel6";
               this.panel6.Size = new System.Drawing.Size(269, 127);
               this.panel6.TabIndex = 6;
               // 
               // lblTableBookings
               // 
               this.lblTableBookings.BackColor = System.Drawing.Color.White;
               this.lblTableBookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTableBookings.ForeColor = System.Drawing.Color.Black;
               this.lblTableBookings.Location = new System.Drawing.Point(59, 0);
               this.lblTableBookings.Name = "lblTableBookings";
               this.lblTableBookings.Size = new System.Drawing.Size(142, 26);
               this.lblTableBookings.TabIndex = 35;
               this.lblTableBookings.Text = "Số lượng bàn đặt: 0";
               // 
               // pictureBoxTable
               // 
               this.pictureBoxTable.Image = global::Quan_li_nha_hang.Properties.Resources.th__1_;
               this.pictureBoxTable.Location = new System.Drawing.Point(180, 29);
               this.pictureBoxTable.Name = "pictureBoxTable";
               this.pictureBoxTable.Size = new System.Drawing.Size(84, 69);
               this.pictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxTable.TabIndex = 36;
               this.pictureBoxTable.TabStop = false;
               // 
               // panel7
               // 
               this.panel7.BackColor = System.Drawing.Color.White;
               this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel7.Controls.Add(this.chartMenuRevenue);
               this.panel7.Location = new System.Drawing.Point(448, 327);
               this.panel7.Name = "panel7";
               this.panel7.Size = new System.Drawing.Size(269, 260);
               this.panel7.TabIndex = 7;
               // 
               // chartMenuRevenue
               // 
               this.chartMenuRevenue.BackColor = System.Drawing.Color.Transparent;
               chartArea5.BackColor = System.Drawing.Color.Transparent;
               chartArea5.Name = "ChartArea1";
               this.chartMenuRevenue.ChartAreas.Add(chartArea5);
               legend5.Name = "Legend1";
               this.chartMenuRevenue.Legends.Add(legend5);
               this.chartMenuRevenue.Location = new System.Drawing.Point(0, 30);
               this.chartMenuRevenue.Name = "chartMenuRevenue";
               series4.ChartArea = "ChartArea1";
               series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
               series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
               series4.Legend = "Legend1";
               series4.Name = "Series1";
               dataPoint17.AxisLabel = "OTC Carcupples";
               dataPoint18.AxisLabel = "Appetizers";
               dataPoint19.AxisLabel = "We Care";
               dataPoint20.AxisLabel = "Grooming/boarding";
               series4.Points.Add(dataPoint17);
               series4.Points.Add(dataPoint18);
               series4.Points.Add(dataPoint19);
               series4.Points.Add(dataPoint20);
               this.chartMenuRevenue.Series.Add(series4);
               this.chartMenuRevenue.Size = new System.Drawing.Size(269, 230);
               this.chartMenuRevenue.TabIndex = 1;
               this.chartMenuRevenue.Text = "Doanh thu theo món ăn";
               // 
               // panel8
               // 
               this.panel8.BackColor = System.Drawing.Color.White;
               this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel8.Controls.Add(this.chartMonthlySales);
               this.panel8.Location = new System.Drawing.Point(723, 327);
               this.panel8.Name = "panel8";
               this.panel8.Size = new System.Drawing.Size(330, 260);
               this.panel8.TabIndex = 8;
               // 
               // chartMonthlySales
               // 
               this.chartMonthlySales.BackColor = System.Drawing.Color.Transparent;
               chartArea6.BackColor = System.Drawing.Color.Transparent;
               chartArea6.Name = "ChartArea2";
               this.chartMonthlySales.ChartAreas.Add(chartArea6);
               legend6.Name = "Legend2";
               this.chartMonthlySales.Legends.Add(legend6);
               this.chartMonthlySales.Location = new System.Drawing.Point(0, 30);
               this.chartMonthlySales.Name = "chartMonthlySales";
               series5.ChartArea = "ChartArea2";
               series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
               series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
               series5.Legend = "Legend2";
               series5.Name = "Units Sold";
               dataPoint21.AxisLabel = "Jan";
               dataPoint22.AxisLabel = "Feb";
               dataPoint23.AxisLabel = "Mar";
               dataPoint24.AxisLabel = "Apr";
               dataPoint25.AxisLabel = "May";
               dataPoint26.AxisLabel = "Jun";
               series5.Points.Add(dataPoint21);
               series5.Points.Add(dataPoint22);
               series5.Points.Add(dataPoint23);
               series5.Points.Add(dataPoint24);
               series5.Points.Add(dataPoint25);
               series5.Points.Add(dataPoint26);
               series6.ChartArea = "ChartArea2";
               series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
               series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
               series6.Legend = "Legend2";
               series6.Name = "Total Transaction";
               dataPoint27.AxisLabel = "Jan";
               dataPoint28.AxisLabel = "Feb";
               dataPoint29.AxisLabel = "Mar";
               dataPoint30.AxisLabel = "Apr";
               dataPoint31.AxisLabel = "May";
               dataPoint32.AxisLabel = "Jun";
               series6.Points.Add(dataPoint27);
               series6.Points.Add(dataPoint28);
               series6.Points.Add(dataPoint29);
               series6.Points.Add(dataPoint30);
               series6.Points.Add(dataPoint31);
               series6.Points.Add(dataPoint32);
               this.chartMonthlySales.Series.Add(series5);
               this.chartMonthlySales.Series.Add(series6);
               this.chartMonthlySales.Size = new System.Drawing.Size(330, 230);
               this.chartMonthlySales.TabIndex = 2;
               this.chartMonthlySales.Text = "Biểu đồ theo tháng";
              
               
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
               this.ClientSize = new System.Drawing.Size(1052, 585);
               this.Controls.Add(this.panel8);
               this.Controls.Add(this.panel7);
               this.Controls.Add(this.panel6);
               this.Controls.Add(this.panel5);
               this.Controls.Add(this.panel4);
               this.Controls.Add(this.mainPanel);
               this.Controls.Add(this.panel1);
               this.Name = "Form3";
               this.Text = "ADMIN";
               this.Load += new System.EventHandler(this.Form3_Load);
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
               this.mainPanel.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
               this.panel4.ResumeLayout(false);
               this.panel5.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).EndInit();
               this.panel6.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
               this.panel7.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.chartMenuRevenue)).EndInit();
               this.panel8.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySales)).EndInit();
               this.ResumeLayout(false);

               ///////////////////////////////////////////////////////////
               
          }
     }
}