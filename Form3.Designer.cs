using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Thêm dòng này nếu chưa có
namespace Quan_li_nha_hang
{
     partial class Form3
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
          private System.Windows.Forms.Button btnDashboard;
          private System.Windows.Forms.Button btnAddEmployee;
          private System.Windows.Forms.Button btnAddAccount;
          private System.Windows.Forms.Button btnInventoryStats;
          private System.Windows.Forms.Button btnCustomerData;
          private System.Windows.Forms.Button btnTableStats;
          private System.Windows.Forms.Button btnRevenueStats;
          private System.Windows.Forms.Button btnStockEntry;
          private System.Windows.Forms.Panel mainPanel;
          private System.Windows.Forms.Button btnLogout;
          private System.Windows.Forms.Label lblTitle;
          private System.Windows.Forms.Label lblClock;
          private System.Windows.Forms.DataGridView dataGridView;
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
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               panel1 = new Panel();
               btnDashboard = new Button();
               btnAddEmployee = new Button();
               btnAddAccount = new Button();
               btnInventoryStats = new Button();
               btnCustomerData = new Button();
               btnTableStats = new Button();
               btnRevenueStats = new Button();
               btnStockEntry = new Button();
               btnLogout = new Button();
               panel2 = new Panel();
               lblTitle = new Label();
               lblClock = new Label();
               chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
               mainPanel = new Panel();
               dataGridView = new DataGridView();
               panel1.SuspendLayout();
               panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
               mainPanel.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
               SuspendLayout();
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(0, 71, 160);
               panel1.BorderStyle = BorderStyle.FixedSingle;
               panel1.Controls.Add(btnDashboard);
               panel1.Controls.Add(btnAddEmployee);
               panel1.Controls.Add(btnAddAccount);
               panel1.Controls.Add(btnInventoryStats);
               panel1.Controls.Add(btnCustomerData);
               panel1.Controls.Add(btnTableStats);
               panel1.Controls.Add(btnRevenueStats);
               panel1.Controls.Add(btnStockEntry);
               panel1.Controls.Add(btnLogout);
               panel1.Location = new Point(2, 88);
               panel1.Name = "panel1";
               panel1.Size = new Size(200, 586);
               panel1.TabIndex = 0;
               // 
               // btnDashboard
               // 
               btnDashboard.BackColor = Color.FromArgb(0, 71, 160);
               btnDashboard.FlatAppearance.BorderSize = 0;
               btnDashboard.FlatStyle = FlatStyle.Flat;
               btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnDashboard.ForeColor = Color.White;
               btnDashboard.Location = new Point(10, 100);
               btnDashboard.Name = "btnDashboard";
               btnDashboard.Size = new Size(180, 40);
               btnDashboard.TabIndex = 1;
               btnDashboard.Text = "DASHBOARD";
               btnDashboard.UseVisualStyleBackColor = false;
               // 
               // btnAddEmployee
               // 
               btnAddEmployee.BackColor = Color.FromArgb(0, 71, 160);
               btnAddEmployee.FlatAppearance.BorderSize = 0;
               btnAddEmployee.FlatStyle = FlatStyle.Flat;
               btnAddEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnAddEmployee.ForeColor = Color.White;
               btnAddEmployee.Location = new Point(10, 150);
               btnAddEmployee.Name = "btnAddEmployee";
               btnAddEmployee.Size = new Size(180, 40);
               btnAddEmployee.TabIndex = 2;
               btnAddEmployee.Text = "THÊM NHÂN VIÊN";
               btnAddEmployee.UseVisualStyleBackColor = false;
               // 
               // btnAddAccount
               // 
               btnAddAccount.BackColor = Color.FromArgb(0, 71, 160);
               btnAddAccount.FlatAppearance.BorderSize = 0;
               btnAddAccount.FlatStyle = FlatStyle.Flat;
               btnAddAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnAddAccount.ForeColor = Color.White;
               btnAddAccount.Location = new Point(10, 200);
               btnAddAccount.Name = "btnAddAccount";
               btnAddAccount.Size = new Size(180, 40);
               btnAddAccount.TabIndex = 3;
               btnAddAccount.Text = "THÊM ACCOUNT";
               btnAddAccount.UseVisualStyleBackColor = false;
               // 
               // btnInventoryStats
               // 
               btnInventoryStats.BackColor = Color.FromArgb(0, 71, 160);
               btnInventoryStats.FlatAppearance.BorderSize = 0;
               btnInventoryStats.FlatStyle = FlatStyle.Flat;
               btnInventoryStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnInventoryStats.ForeColor = Color.White;
               btnInventoryStats.Location = new Point(10, 250);
               btnInventoryStats.Name = "btnInventoryStats";
               btnInventoryStats.Size = new Size(180, 40);
               btnInventoryStats.TabIndex = 4;
               btnInventoryStats.Text = "THỐNG KÊ KHO";
               btnInventoryStats.UseVisualStyleBackColor = false;
               // 
               // btnCustomerData
               // 
               btnCustomerData.BackColor = Color.FromArgb(0, 71, 160);
               btnCustomerData.FlatAppearance.BorderSize = 0;
               btnCustomerData.FlatStyle = FlatStyle.Flat;
               btnCustomerData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCustomerData.ForeColor = Color.White;
               btnCustomerData.Location = new Point(10, 300);
               btnCustomerData.Name = "btnCustomerData";
               btnCustomerData.Size = new Size(180, 40);
               btnCustomerData.TabIndex = 5;
               btnCustomerData.Text = "XEM DỮ LIỆU KHÁCH HÀNG";
               btnCustomerData.UseVisualStyleBackColor = false;
               // 
               // btnTableStats
               // 
               btnTableStats.BackColor = Color.FromArgb(0, 71, 160);
               btnTableStats.FlatAppearance.BorderSize = 0;
               btnTableStats.FlatStyle = FlatStyle.Flat;
               btnTableStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnTableStats.ForeColor = Color.White;
               btnTableStats.Location = new Point(10, 350);
               btnTableStats.Name = "btnTableStats";
               btnTableStats.Size = new Size(180, 40);
               btnTableStats.TabIndex = 6;
               btnTableStats.Text = "THỐNG KÊ BÀN ĂN";
               btnTableStats.UseVisualStyleBackColor = false;
               // 
               // btnRevenueStats
               // 
               btnRevenueStats.BackColor = Color.FromArgb(0, 71, 160);
               btnRevenueStats.FlatAppearance.BorderSize = 0;
               btnRevenueStats.FlatStyle = FlatStyle.Flat;
               btnRevenueStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnRevenueStats.ForeColor = Color.White;
               btnRevenueStats.Location = new Point(10, 400);
               btnRevenueStats.Name = "btnRevenueStats";
               btnRevenueStats.Size = new Size(180, 40);
               btnRevenueStats.TabIndex = 7;
               btnRevenueStats.Text = "THỐNG KÊ DOANH THU";
               btnRevenueStats.UseVisualStyleBackColor = false;
               // 
               // btnStockEntry
               // 
               btnStockEntry.BackColor = Color.FromArgb(0, 71, 160);
               btnStockEntry.FlatAppearance.BorderSize = 0;
               btnStockEntry.FlatStyle = FlatStyle.Flat;
               btnStockEntry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnStockEntry.ForeColor = Color.White;
               btnStockEntry.Location = new Point(10, 450);
               btnStockEntry.Name = "btnStockEntry";
               btnStockEntry.Size = new Size(180, 40);
               btnStockEntry.TabIndex = 8;
               btnStockEntry.Text = "NHẬP KHO";
               btnStockEntry.UseVisualStyleBackColor = false;
               // 
               // btnLogout
               // 
               btnLogout.BackColor = Color.IndianRed;
               btnLogout.FlatStyle = FlatStyle.Flat;
               btnLogout.ForeColor = Color.White;
               btnLogout.Location = new Point(10, 550);
               btnLogout.Name = "btnLogout";
               btnLogout.Size = new Size(180, 30);
               btnLogout.TabIndex = 9;
               btnLogout.Text = "Đăng xuất";
               btnLogout.UseVisualStyleBackColor = false;
               // 
               // panel2
               // 
               panel2.BackColor = Color.FromArgb(0, 71, 160);
               panel2.BorderStyle = BorderStyle.FixedSingle;
               panel2.Controls.Add(lblTitle);
               panel2.Controls.Add(lblClock);
               panel2.Location = new Point(2, 26);
               panel2.Name = "panel2";
               panel2.Size = new Size(1223, 56);
               panel2.TabIndex = 1;
               // 
               // lblTitle
               // 
               lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
               lblTitle.ForeColor = Color.White;
               lblTitle.Location = new Point(10, 10);
               lblTitle.Name = "lblTitle";
               lblTitle.Size = new Size(200, 30);
               lblTitle.TabIndex = 0;
               lblTitle.Text = "QUẢN LÝ NHÀ HÀNG";
               // 
               // lblClock
               // 
               lblClock.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
               lblClock.ForeColor = Color.White;
               lblClock.Location = new Point(1000, 10);
               lblClock.Name = "lblClock";
               lblClock.Size = new Size(100, 30);
               lblClock.TabIndex = 1;
               lblClock.Text = "10:18:45";
               // 
               // chart1
               // 
               chartArea1.Name = "ChartArea1";
               chart1.ChartAreas.Add(chartArea1);
               legend1.Name = "Legend1";
               chart1.Legends.Add(legend1);
               chart1.Location = new Point(10, 50);
               chart1.Name = "chart1";
               series1.ChartArea = "ChartArea1";
               series1.Legend = "Legend1";
               series1.Name = "Series1";
               chart1.Series.Add(series1);
               chart1.Size = new Size(987, 500);
               chart1.TabIndex = 0;
               chart1.Visible = false;
               // 
               // mainPanel
               // 
               mainPanel.Controls.Add(chart1);
               mainPanel.Controls.Add(dataGridView);
               mainPanel.Location = new Point(208, 88);
               mainPanel.Name = "mainPanel";
               mainPanel.Size = new Size(1007, 575);
               mainPanel.TabIndex = 2;
               // 
               // dataGridView
               // 
               dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               dataGridView.Location = new Point(10, 100);
               dataGridView.Name = "dataGridView";
               dataGridView.Size = new Size(987, 400);
               dataGridView.TabIndex = 1;
               dataGridView.Visible = false;
               // 
               // admin
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1227, 675);
               Controls.Add(mainPanel);
               Controls.Add(panel2);
               Controls.Add(panel1);
               Name = "admin";
               Text = "ADMIN";
               panel1.ResumeLayout(false);
               panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
               mainPanel.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
               ResumeLayout(false);

          }

          #endregion
     }
}