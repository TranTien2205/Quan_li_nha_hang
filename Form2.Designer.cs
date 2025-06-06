using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Quan_li_nha_hang     
{
     partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button31);
            this.panel2.Controls.Add(this.button30);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 577);
            this.panel2.TabIndex = 26;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.button31.Location = new System.Drawing.Point(363, 439);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(197, 41);
            this.button31.TabIndex = 7;
            this.button31.Text = "Chuyển khoản 💳";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.button30.Location = new System.Drawing.Point(189, 439);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(161, 41);
            this.button30.TabIndex = 6;
            this.button30.Text = "Tiền mặt 💲";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.button26.Location = new System.Drawing.Point(15, 439);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(161, 41);
            this.button26.TabIndex = 5;
            this.button26.Text = "In hóa đơn 🖨️";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label6.Location = new System.Drawing.Point(389, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "000.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(239, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(563, 343);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "STT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên món";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.Name = "Column3";
            this.Column3.Width = 133;
            // 
            // Column5
            // 
            this.Column5.HeaderText = " ";
            this.Column5.Name = "Column5";
            this.Column5.Text = "X";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.Location = new System.Drawing.Point(200, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bàn :....";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phiếu yêu cầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(45, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "user...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1167, 29);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem1});
            this.càiĐặtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            this.đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            this.đổiMậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(1056, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "08:53:21";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 42);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_li_nha_hang.Properties.Resources.Download_premium_png_of_Account_png_line_icon_user_symbol_by_Aew_about_profile_icon__person_icon__person_icon_png__profile_png__and_profile_3012376_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(572, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 577);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(586, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button27);
            this.tabPage2.Controls.Add(this.button28);
            this.tabPage2.Controls.Add(this.button29);
            this.tabPage2.Controls.Add(this.button32);
            this.tabPage2.Controls.Add(this.button33);
            this.tabPage2.Controls.Add(this.button34);
            this.tabPage2.Controls.Add(this.button35);
            this.tabPage2.Controls.Add(this.button36);
            this.tabPage2.Controls.Add(this.button37);
            this.tabPage2.Controls.Add(this.button38);
            this.tabPage2.Controls.Add(this.button39);
            this.tabPage2.Controls.Add(this.button40);
            this.tabPage2.Controls.Add(this.button41);
            this.tabPage2.Controls.Add(this.button42);
            this.tabPage2.Controls.Add(this.button43);
            this.tabPage2.Controls.Add(this.button44);
            this.tabPage2.Controls.Add(this.button45);
            this.tabPage2.Controls.Add(this.button46);
            this.tabPage2.Controls.Add(this.button47);
            this.tabPage2.Controls.Add(this.button48);
            this.tabPage2.Controls.Add(this.button49);
            this.tabPage2.Controls.Add(this.button50);
            this.tabPage2.Controls.Add(this.button51);
            this.tabPage2.Controls.Add(this.button52);
            this.tabPage2.Controls.Add(this.button53);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt bàn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(586, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thực đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button27.FlatAppearance.BorderSize = 2;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(10, 15);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(88, 79);
            this.button27.TabIndex = 50;
            this.button27.Text = "Bàn 1";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button28.FlatAppearance.BorderSize = 2;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(488, 446);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(88, 79);
            this.button28.TabIndex = 74;
            this.button28.Text = "Bàn 25";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button29.FlatAppearance.BorderSize = 2;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(130, 15);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(88, 79);
            this.button29.TabIndex = 51;
            this.button29.Text = "Bàn 2";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button32.FlatAppearance.BorderSize = 2;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(371, 446);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(88, 79);
            this.button32.TabIndex = 73;
            this.button32.Text = "Bàn 24";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button33.FlatAppearance.BorderSize = 2;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(253, 15);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(88, 79);
            this.button33.TabIndex = 52;
            this.button33.Text = "Bàn 3";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button34.FlatAppearance.BorderSize = 2;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(253, 446);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(88, 79);
            this.button34.TabIndex = 72;
            this.button34.Text = "Bàn 23";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button35.FlatAppearance.BorderSize = 2;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(372, 15);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(88, 79);
            this.button35.TabIndex = 53;
            this.button35.Text = "Bàn 4";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button36.FlatAppearance.BorderSize = 2;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(488, 339);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(88, 79);
            this.button36.TabIndex = 69;
            this.button36.Text = "Bàn 20";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button37.FlatAppearance.BorderSize = 2;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Location = new System.Drawing.Point(130, 446);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(88, 79);
            this.button37.TabIndex = 71;
            this.button37.Text = "Bàn 22";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button38.FlatAppearance.BorderSize = 2;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(371, 339);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(88, 79);
            this.button38.TabIndex = 68;
            this.button38.Text = "Bàn 19";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button39.FlatAppearance.BorderSize = 2;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Location = new System.Drawing.Point(10, 126);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(88, 79);
            this.button39.TabIndex = 55;
            this.button39.Text = "Bàn 6";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button40.FlatAppearance.BorderSize = 2;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(253, 339);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(88, 79);
            this.button40.TabIndex = 67;
            this.button40.Text = "Bàn 18";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button41.FlatAppearance.BorderSize = 2;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Location = new System.Drawing.Point(10, 446);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(88, 79);
            this.button41.TabIndex = 70;
            this.button41.Text = "Bàn 21";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button42.FlatAppearance.BorderSize = 2;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Location = new System.Drawing.Point(488, 232);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(88, 79);
            this.button42.TabIndex = 64;
            this.button42.Text = "Bàn 15";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // button43
            // 
            this.button43.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button43.FlatAppearance.BorderSize = 2;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Location = new System.Drawing.Point(10, 232);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(88, 79);
            this.button43.TabIndex = 60;
            this.button43.Text = "Bàn 11";
            this.button43.UseVisualStyleBackColor = true;
            // 
            // button44
            // 
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button44.FlatAppearance.BorderSize = 2;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Location = new System.Drawing.Point(372, 232);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(88, 79);
            this.button44.TabIndex = 63;
            this.button44.Text = "Bàn 14";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button45.FlatAppearance.BorderSize = 2;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Location = new System.Drawing.Point(10, 339);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(88, 79);
            this.button45.TabIndex = 65;
            this.button45.Text = "Bàn 16";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button46.FlatAppearance.BorderSize = 2;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button46.Location = new System.Drawing.Point(253, 232);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(88, 79);
            this.button46.TabIndex = 62;
            this.button46.Text = "Bàn 13";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button47.FlatAppearance.BorderSize = 2;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Location = new System.Drawing.Point(130, 339);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(88, 79);
            this.button47.TabIndex = 66;
            this.button47.Text = "Bàn 17";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button48.FlatAppearance.BorderSize = 2;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.Location = new System.Drawing.Point(488, 126);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(88, 79);
            this.button48.TabIndex = 59;
            this.button48.Text = "Bàn 10";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button49
            // 
            this.button49.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button49.FlatAppearance.BorderSize = 2;
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.Location = new System.Drawing.Point(488, 15);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(88, 79);
            this.button49.TabIndex = 54;
            this.button49.Text = "Bàn 5";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            this.button50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button50.FlatAppearance.BorderSize = 2;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.Location = new System.Drawing.Point(371, 126);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(88, 79);
            this.button50.TabIndex = 58;
            this.button50.Text = "Bàn 9";
            this.button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            this.button51.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button51.FlatAppearance.BorderSize = 2;
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.Location = new System.Drawing.Point(130, 126);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(88, 79);
            this.button51.TabIndex = 56;
            this.button51.Text = "Bàn 7";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button52.FlatAppearance.BorderSize = 2;
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.Location = new System.Drawing.Point(253, 126);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(88, 79);
            this.button52.TabIndex = 57;
            this.button52.Text = "Bàn 8";
            this.button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.button53.FlatAppearance.BorderSize = 2;
            this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button53.Location = new System.Drawing.Point(130, 232);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(88, 79);
            this.button53.TabIndex = 61;
            this.button53.Text = "Bàn 12";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 653);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "QUẢN LÝ NHÀ HÀNG dành cho nhân viên  ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion
          private Panel panel2;
          private Label label1;
          private Label label3;
          private Label label2;
          private MenuStrip menuStrip1;
          private ToolStripMenuItem càiĐặtToolStripMenuItem;
          private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
          private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
          private PictureBox pictureBox1;
          private Label label4;
          private System.Windows.Forms.Timer timer1;
          private Panel panel3;
          private DataGridView dataGridView1;
          private Label label6;
          private Label label5;
          private Button button30;
          private Button button26;
          private Button button31;
          private ImageList imageList1;
          private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column5;
        private Timer timer2;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private Button button42;
        private Button button43;
        private Button button44;
        private Button button45;
        private Button button46;
        private Button button47;
        private Button button48;
        private Button button49;
        private Button button50;
        private Button button51;
        private Button button52;
        private Button button53;
    }
}