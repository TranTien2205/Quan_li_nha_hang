using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
          private Label lblRevenue;
          private Label lblCustomerChartTitle;

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
               this.panel1 = new System.Windows.Forms.Panel();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.btnDashboard = new System.Windows.Forms.Button();
               this.btnAddEmployee = new System.Windows.Forms.Button();
               this.btnAddAccount = new System.Windows.Forms.Button();
               this.btnInventoryStats = new System.Windows.Forms.Button();
               this.btnCustomerData = new System.Windows.Forms.Button();
               this.btnTableStats = new System.Windows.Forms.Button();
               this.btnRevenueStats = new System.Windows.Forms.Button();
               this.btnStockEntry = new System.Windows.Forms.Button();
               this.btnLogout = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.lblTitle = new System.Windows.Forms.Label();
               this.lblClock = new System.Windows.Forms.Label();
               this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.lblCustomerChartTitle = new System.Windows.Forms.Label();
               this.lblRevenue = new System.Windows.Forms.Label();
               this.dataGridView = new System.Windows.Forms.DataGridView();
               this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
               this.panel1.Controls.Add(this.btnDashboard);
               this.panel1.Controls.Add(this.btnAddEmployee);
               this.panel1.Controls.Add(this.btnAddAccount);
               this.panel1.Controls.Add(this.btnInventoryStats);
               this.panel1.Controls.Add(this.btnCustomerData);
               this.panel1.Controls.Add(this.btnTableStats);
               this.panel1.Controls.Add(this.btnRevenueStats);
               this.panel1.Controls.Add(this.btnStockEntry);
               this.panel1.Controls.Add(this.btnLogout);
               this.panel1.Location = new System.Drawing.Point(2, 76);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(172, 508);
               this.panel1.TabIndex = 0;
               // 
               // pictureBox1
               // 
              // this.pictureBox1.Image = global::Quan_li_nha_hang.Properties.Resources.png_clipart_teacher_education_student_course_school_avatar_child_face;
               this.pictureBox1.Location = new System.Drawing.Point(8, 3);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(154, 125);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 10;
               this.pictureBox1.TabStop = false;
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
               this.btnDashboard.TabIndex = 1;
               this.btnDashboard.Text = "DASHBOARD";
               this.btnDashboard.UseVisualStyleBackColor = false;
               //this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
               // 
               // btnAddEmployee
               // 
               this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnAddEmployee.FlatAppearance.BorderSize = 0;
               this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
               this.btnAddEmployee.Location = new System.Drawing.Point(9, 175);
               this.btnAddEmployee.Name = "btnAddEmployee";
               this.btnAddEmployee.Size = new System.Drawing.Size(154, 35);
               this.btnAddEmployee.TabIndex = 2;
               this.btnAddEmployee.Text = "THÊM NHÂN VIÊN";
               this.btnAddEmployee.UseVisualStyleBackColor = false;
               // 
               // btnAddAccount
               // 
               this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnAddAccount.FlatAppearance.BorderSize = 0;
               this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnAddAccount.ForeColor = System.Drawing.Color.White;
               this.btnAddAccount.Location = new System.Drawing.Point(9, 216);
               this.btnAddAccount.Name = "btnAddAccount";
               this.btnAddAccount.Size = new System.Drawing.Size(154, 35);
               this.btnAddAccount.TabIndex = 3;
               this.btnAddAccount.Text = "THÊM ACCOUNT";
               this.btnAddAccount.UseVisualStyleBackColor = false;
               // 
               // btnInventoryStats
               // 
               this.btnInventoryStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnInventoryStats.FlatAppearance.BorderSize = 0;
               this.btnInventoryStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnInventoryStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnInventoryStats.ForeColor = System.Drawing.Color.White;
               this.btnInventoryStats.Location = new System.Drawing.Point(9, 257);
               this.btnInventoryStats.Name = "btnInventoryStats";
               this.btnInventoryStats.Size = new System.Drawing.Size(154, 35);
               this.btnInventoryStats.TabIndex = 4;
               this.btnInventoryStats.Text = "THỐNG KÊ KHO";
               this.btnInventoryStats.UseVisualStyleBackColor = false;
               // 
               // btnCustomerData
               // 
               this.btnCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnCustomerData.FlatAppearance.BorderSize = 0;
               this.btnCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnCustomerData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnCustomerData.ForeColor = System.Drawing.Color.White;
               this.btnCustomerData.Location = new System.Drawing.Point(9, 298);
               this.btnCustomerData.Name = "btnCustomerData";
               this.btnCustomerData.Size = new System.Drawing.Size(154, 35);
               this.btnCustomerData.TabIndex = 5;
               this.btnCustomerData.Text = "XEM DỮ LIỆU KHÁCH HÀNG";
               this.btnCustomerData.UseVisualStyleBackColor = false;
               // 
               // btnTableStats
               // 
               this.btnTableStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnTableStats.FlatAppearance.BorderSize = 0;
               this.btnTableStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTableStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnTableStats.ForeColor = System.Drawing.Color.White;
               this.btnTableStats.Location = new System.Drawing.Point(9, 339);
               this.btnTableStats.Name = "btnTableStats";
               this.btnTableStats.Size = new System.Drawing.Size(154, 35);
               this.btnTableStats.TabIndex = 6;
               this.btnTableStats.Text = "THỐNG KÊ BÀN ĂN";
               this.btnTableStats.UseVisualStyleBackColor = false;
               // 
               // btnRevenueStats
               // 
               this.btnRevenueStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnRevenueStats.FlatAppearance.BorderSize = 0;
               this.btnRevenueStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnRevenueStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnRevenueStats.ForeColor = System.Drawing.Color.White;
               this.btnRevenueStats.Location = new System.Drawing.Point(9, 380);
               this.btnRevenueStats.Name = "btnRevenueStats";
               this.btnRevenueStats.Size = new System.Drawing.Size(154, 35);
               this.btnRevenueStats.TabIndex = 7;
               this.btnRevenueStats.Text = "THỐNG KÊ DOANH THU";
               this.btnRevenueStats.UseVisualStyleBackColor = false;
               // 
               // btnStockEntry
               // 
               this.btnStockEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               this.btnStockEntry.FlatAppearance.BorderSize = 0;
               this.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnStockEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
               this.btnStockEntry.ForeColor = System.Drawing.Color.White;
               this.btnStockEntry.Location = new System.Drawing.Point(9, 421);
               this.btnStockEntry.Name = "btnStockEntry";
               this.btnStockEntry.Size = new System.Drawing.Size(154, 35);
               this.btnStockEntry.TabIndex = 8;
               this.btnStockEntry.Text = "NHẬP KHO";
               this.btnStockEntry.UseVisualStyleBackColor = false;
               // 
               // btnLogout
               // 
               this.btnLogout.BackColor = System.Drawing.Color.Tomato;
               this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnLogout.ForeColor = System.Drawing.Color.White;
               this.btnLogout.Location = new System.Drawing.Point(9, 477);
               this.btnLogout.Name = "btnLogout";
               this.btnLogout.Size = new System.Drawing.Size(154, 26);
               this.btnLogout.TabIndex = 9;
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
               this.lblClock.Text = "10:18:45";
               // 
               // chart1
               // 
               chartArea1.Name = "ChartArea1";
               this.chart1.ChartAreas.Add(chartArea1);
               legend1.Name = "Legend1";
               this.chart1.Legends.Add(legend1);
               this.chart1.Location = new System.Drawing.Point(450, 150);
               this.chart1.Name = "chart1";
               series1.ChartArea = "ChartArea1";
               series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
               series1.Legend = "Legend1";
               series1.Name = "Series1";
               this.chart1.Series.Add(series1);
               this.chart1.Size = new System.Drawing.Size(400, 300);
               this.chart1.TabIndex = 0;
               this.chart1.Text = "Khách hàng theo thâm niên";
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
               this.mainPanel.Controls.Add(this.lblCustomerChartTitle);
               this.mainPanel.Controls.Add(this.lblRevenue);
               this.mainPanel.Controls.Add(this.chart1);
               this.mainPanel.Controls.Add(this.dataGridView);
               this.mainPanel.Location = new System.Drawing.Point(178, 76);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(863, 498);
               this.mainPanel.TabIndex = 2;
               // 
               // lblCustomerChartTitle
               // 
               this.lblCustomerChartTitle.AutoSize = true;
               this.lblCustomerChartTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
               this.lblCustomerChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblCustomerChartTitle.Location = new System.Drawing.Point(450, 130);
               this.lblCustomerChartTitle.Name = "lblCustomerChartTitle";
               this.lblCustomerChartTitle.Size = new System.Drawing.Size(190, 19);
               this.lblCustomerChartTitle.TabIndex = 3;
               this.lblCustomerChartTitle.Text = "Khách hàng theo thâm niên";
               // 
               // lblRevenue
               // 
               this.lblRevenue.AutoSize = true;
               this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
               this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
               this.lblRevenue.Location = new System.Drawing.Point(50, 50);
               this.lblRevenue.Name = "lblRevenue";
               this.lblRevenue.Size = new System.Drawing.Size(159, 37);
               this.lblRevenue.TabIndex = 2;
               this.lblRevenue.Text = "15.200.000";
               // 
               // dataGridView
               // 
               this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
               this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
               this.dataGridViewTextBoxColumn1,
               this.dataGridViewTextBoxColumn2,
               this.dataGridViewTextBoxColumn3,
               this.dataGridViewTextBoxColumn4});
               this.dataGridView.Location = new System.Drawing.Point(50, 150);
               this.dataGridView.Name = "dataGridView";
               this.dataGridView.Size = new System.Drawing.Size(350, 300);
               this.dataGridView.TabIndex = 1;
               // 
               // dataGridViewTextBoxColumn1
               // 
               this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
               // 
               // dataGridViewTextBoxColumn2
               // 
               this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
               // 
               // dataGridViewTextBoxColumn3
               // 
               this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
               // 
               // dataGridViewTextBoxColumn4
               // 
               this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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

          #endregion

          private PictureBox pictureBox1;
          private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
          private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
          private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
          private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
     }
}