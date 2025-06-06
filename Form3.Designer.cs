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
          private Panel panel2;
          private Chart chart1;
          private Button btnDashboard;
          private Button btnManageEmployees;
          private Button btnManageCustomers;
          private Button btnManageTables;
          private Button btnManageRevenue;
          private Button btnManageMenu;
          private Button btnLogout;
          private Panel mainPanel;
          private Label lblTitle;
          private Label lblClock;
          private DataGridView dataGridView;
          private Label lblRevenue;
          private Label lblTotalRevenue;
          private Label lblTotalCustomers;
          private Label lblTableStatus;
          private Label lblLowInventory;
          private Label lblCustomerChartTitle;
          private Label lblOutstandingBalance;
          private Label lblOutstandingBalanceValue;
          private PictureBox pictureBox1;
          private DataGridViewTextBoxColumn colID;
          private DataGridViewTextBoxColumn colCustomerName;
          private DataGridViewTextBoxColumn colAddress;
          private DataGridViewTextBoxColumn colCity;

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
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               this.panel1 = new System.Windows.Forms.Panel();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.btnManageMenu = new System.Windows.Forms.Button();
               this.btnManageRevenue = new System.Windows.Forms.Button();
               this.btnManageTables = new System.Windows.Forms.Button();
               this.btnManageCustomers = new System.Windows.Forms.Button();
               this.btnManageEmployees = new System.Windows.Forms.Button();
               this.btnDashboard = new System.Windows.Forms.Button();
               this.btnLogout = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.lblTitle = new System.Windows.Forms.Label();
               this.lblClock = new System.Windows.Forms.Label();
               this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.lblTableStatus = new System.Windows.Forms.Label();
               this.lblLowInventory = new System.Windows.Forms.Label();
               this.lblTotalCustomers = new System.Windows.Forms.Label();
               this.lblTotalRevenue = new System.Windows.Forms.Label();
               this.lblOutstandingBalance = new System.Windows.Forms.Label();
               this.lblOutstandingBalanceValue = new System.Windows.Forms.Label();
               this.lblCustomerChartTitle = new System.Windows.Forms.Label();
               this.lblRevenue = new System.Windows.Forms.Label();
               this.dataGridView = new System.Windows.Forms.DataGridView();
               this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
               this.mainPanel.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel1.Controls.Add(this.pictureBox1);
               this.panel1.Controls.Add(this.btnManageMenu);
               this.panel1.Controls.Add(this.btnManageRevenue);
               this.panel1.Controls.Add(this.btnManageTables);
               this.panel1.Controls.Add(this.btnManageCustomers);
               this.panel1.Controls.Add(this.btnManageEmployees);
               this.panel1.Controls.Add(this.btnDashboard);
               this.panel1.Controls.Add(this.btnLogout);
               this.panel1.Location = new System.Drawing.Point(2, 76);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(172, 508);
               this.panel1.TabIndex = 0;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(8, 3);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(154, 125);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 10;
               this.pictureBox1.TabStop = false;
               // 
               // btnManageMenu
               // 
               this.btnManageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               this.btnManageRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               this.btnManageTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               this.btnManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               this.btnManageEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               // 
               // btnDashboard
               // 
               this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
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
               this.btnLogout.Location = new System.Drawing.Point(9, 477);
               this.btnLogout.Name = "btnLogout";
               this.btnLogout.Size = new System.Drawing.Size(154, 26);
               this.btnLogout.TabIndex = 1;
               this.btnLogout.Text = "Đăng xuất";
               this.btnLogout.UseVisualStyleBackColor = false;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel2.Controls.Add(this.lblTitle);
               this.panel2.Controls.Add(this.lblClock);
               this.panel2.Location = new System.Drawing.Point(2, 23);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1049, 49);
               this.panel2.TabIndex = 1;
               // 
               // lblTitle
               // 
               this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
               this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblTitle.Location = new System.Drawing.Point(9, 9);
               this.lblTitle.Name = "lblTitle";
               this.lblTitle.Size = new System.Drawing.Size(171, 26);
               this.lblTitle.TabIndex = 0;
               this.lblTitle.Text = "QUẢN LÝ NHÀ HÀNG";
               // 
               // lblClock
               // 
               this.lblClock.Font = new System.Drawing.Font("Segoe UI", 10F);
               this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblClock.Location = new System.Drawing.Point(857, 9);
               this.lblClock.Name = "lblClock";
               this.lblClock.Size = new System.Drawing.Size(86, 26);
               this.lblClock.TabIndex = 1;
               this.lblClock.Text = "09:13";
               // 
               // chart1
               // 
               this.chart1.BackColor = System.Drawing.Color.Transparent;
               chartArea1.BackColor = System.Drawing.Color.Transparent;
               chartArea1.Name = "ChartArea1";
               this.chart1.ChartAreas.Add(chartArea1);
               legend1.Enabled = false;
               legend1.Name = "Legend1";
               this.chart1.Legends.Add(legend1);
               this.chart1.Location = new System.Drawing.Point(450, 150);
               this.chart1.Name = "chart1";
               series1.ChartArea = "ChartArea1";
               series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
               series1.Legend = "Legend1";
               series1.Name = "Series1";
               this.chart1.Series.Add(series1);
               this.chart1.Size = new System.Drawing.Size(400, 300);
               this.chart1.TabIndex = 0;
               this.chart1.Text = "Doanh thu theo ngày";
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(233)))), ((int)(((byte)(212)))));
               this.mainPanel.Controls.Add(this.lblTableStatus);
               this.mainPanel.Controls.Add(this.lblLowInventory);
               this.mainPanel.Controls.Add(this.lblTotalCustomers);
               this.mainPanel.Controls.Add(this.lblTotalRevenue);
               this.mainPanel.Controls.Add(this.lblOutstandingBalance);
               this.mainPanel.Controls.Add(this.lblOutstandingBalanceValue);
               this.mainPanel.Controls.Add(this.lblCustomerChartTitle);
               this.mainPanel.Controls.Add(this.lblRevenue);
               this.mainPanel.Controls.Add(this.chart1);
               this.mainPanel.Controls.Add(this.dataGridView);
               this.mainPanel.Location = new System.Drawing.Point(178, 76);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(863, 498);
               this.mainPanel.TabIndex = 2;
               // 
               // lblTableStatus
               // 
               this.lblTableStatus.AutoSize = true;
               this.lblTableStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTableStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblTableStatus.Location = new System.Drawing.Point(450, 70);
               this.lblTableStatus.Name = "lblTableStatus";
               this.lblTableStatus.Size = new System.Drawing.Size(193, 28);
               this.lblTableStatus.TabIndex = 9;
               this.lblTableStatus.Text = "Trạng thái bàn: 0/0";
               // 
               // lblLowInventory
               // 
               this.lblLowInventory.AutoSize = true;
               this.lblLowInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblLowInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblLowInventory.Location = new System.Drawing.Point(14, 70);
               this.lblLowInventory.Name = "lblLowInventory";
               this.lblLowInventory.Size = new System.Drawing.Size(199, 28);
               this.lblLowInventory.TabIndex = 8;
               this.lblLowInventory.Text = "Nguyên liệu thấp: 0";
               // 
               // lblTotalCustomers
               // 
               this.lblTotalCustomers.AutoSize = true;
               this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblTotalCustomers.Location = new System.Drawing.Point(14, 100);
               this.lblTotalCustomers.Name = "lblTotalCustomers";
               this.lblTotalCustomers.Size = new System.Drawing.Size(181, 28);
               this.lblTotalCustomers.TabIndex = 7;
               this.lblTotalCustomers.Text = "Khách hôm nay: 0";
               // 
               // lblTotalRevenue
               // 
               this.lblTotalRevenue.AutoSize = true;
               this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblTotalRevenue.Location = new System.Drawing.Point(450, 100);
               this.lblTotalRevenue.Name = "lblTotalRevenue";
               this.lblTotalRevenue.Size = new System.Drawing.Size(273, 28);
               this.lblTotalRevenue.TabIndex = 6;
               this.lblTotalRevenue.Text = "Doanh thu hôm nay: 0 VNĐ";
               // 
               // lblOutstandingBalance
               // 
               this.lblOutstandingBalance.AutoSize = true;
               this.lblOutstandingBalance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
               this.lblOutstandingBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblOutstandingBalance.Location = new System.Drawing.Point(14, 350);
               this.lblOutstandingBalance.Name = "lblOutstandingBalance";
               this.lblOutstandingBalance.Size = new System.Drawing.Size(239, 32);
               this.lblOutstandingBalance.TabIndex = 4;
               this.lblOutstandingBalance.Text = "Thống tin quỹ hàng";
               // 
               // lblOutstandingBalanceValue
               // 
               this.lblOutstandingBalanceValue.AutoSize = true;
               this.lblOutstandingBalanceValue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
               this.lblOutstandingBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblOutstandingBalanceValue.Location = new System.Drawing.Point(14, 390);
               this.lblOutstandingBalanceValue.Name = "lblOutstandingBalanceValue";
               this.lblOutstandingBalanceValue.Size = new System.Drawing.Size(457, 106);
               this.lblOutstandingBalanceValue.TabIndex = 5;
               this.lblOutstandingBalanceValue.Text = "15.200.000";
               // 
               // lblCustomerChartTitle
               // 
               this.lblCustomerChartTitle.AutoSize = true;
               this.lblCustomerChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.lblCustomerChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblCustomerChartTitle.Location = new System.Drawing.Point(451, 128);
               this.lblCustomerChartTitle.Name = "lblCustomerChartTitle";
               this.lblCustomerChartTitle.Size = new System.Drawing.Size(213, 28);
               this.lblCustomerChartTitle.TabIndex = 3;
               this.lblCustomerChartTitle.Text = "Doanh thu theo ngày";
               // 
               // lblRevenue
               // 
               this.lblRevenue.AutoSize = true;
               this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
               this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblRevenue.Location = new System.Drawing.Point(450, 15);
               this.lblRevenue.Name = "lblRevenue";
               this.lblRevenue.Size = new System.Drawing.Size(134, 32);
               this.lblRevenue.TabIndex = 2;
               this.lblRevenue.Text = "Doanh thu";
               // 
               // dataGridView
               // 
               this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
               this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dataGridView.ColumnHeadersHeight = 29;
               this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCustomerName,
            this.colAddress,
            this.colCity});
               this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
               this.dataGridView.Location = new System.Drawing.Point(14, 150);
               this.dataGridView.Name = "dataGridView";
               this.dataGridView.RowHeadersVisible = false;
               this.dataGridView.RowHeadersWidth = 51;
               this.dataGridView.Size = new System.Drawing.Size(400, 150);
               this.dataGridView.TabIndex = 1;
               // 
               // colID
               // 
               this.colID.HeaderText = "ID";
               this.colID.MinimumWidth = 30;
               this.colID.Name = "colID";
               // 
               // colCustomerName
               // 
               this.colCustomerName.HeaderText = "Tên khách hàng";
               this.colCustomerName.MinimumWidth = 6;
               this.colCustomerName.Name = "colCustomerName";
               // 
               // colAddress
               // 
               this.colAddress.HeaderText = "Địa chỉ";
               this.colAddress.MinimumWidth = 6;
               this.colAddress.Name = "colAddress";
               // 
               // colCity
               // 
               this.colCity.HeaderText = "Thành phố";
               this.colCity.MinimumWidth = 6;
               this.colCity.Name = "colCity";
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1052, 585);
               this.Controls.Add(this.mainPanel);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Name = "Form3";
               this.Text = "ADMIN";
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
               this.mainPanel.ResumeLayout(false);
               this.mainPanel.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
               this.ResumeLayout(false);

          }
     }
}