﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quan_li_nha_hang
{
     partial class Form1
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
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
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ HÀNG";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(50, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textBox2.Location = new System.Drawing.Point(50, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 34);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Password";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.button1.Location = new System.Drawing.Point(128, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(155, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 280);
            this.panel1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(50, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Xem mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::Quan_li_nha_hang.Properties.Resources.c94793cf_13f3_481d_ba0d_ac7773a785b8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ NHÀ HÀNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

=======
               label1 = new Label();
               textBox1 = new TextBox();
               textBox2 = new TextBox();
               button1 = new Button();
               panel1 = new Panel();
               checkBox1 = new CheckBox();
               panel1.SuspendLayout();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = Color.Transparent;
               label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
               label1.ForeColor = SystemColors.Control;
               label1.Location = new Point(58, 39);
               label1.Name = "label1";
               label1.Size = new Size(288, 37);
               label1.TabIndex = 0;
               label1.Text = "QUẢN LÝ NHÀ HÀNG";
               label1.Click += label1_Click;
               // 
               // textBox1
               // 
               textBox1.BorderStyle = BorderStyle.FixedSingle;
               textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
               textBox1.ForeColor = SystemColors.InfoText;
               textBox1.Location = new Point(58, 130);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(300, 34);
               textBox1.TabIndex = 3;
               textBox1.Text = "Username";
               textBox1.Click += textBox1_Click;
               textBox1.KeyDown += textBox1_KeyDown;
               // 
               // textBox2
               // 
               textBox2.BorderStyle = BorderStyle.FixedSingle;
               textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
               textBox2.Location = new Point(58, 185);
               textBox2.Name = "textBox2";
               textBox2.Size = new Size(300, 34);
               textBox2.TabIndex = 4;
               textBox2.Text = "Password";
               textBox2.UseSystemPasswordChar = true;
               textBox2.Click += textBox2_Click;
               textBox2.KeyDown += textBox2_KeyDown;
               // 
               // button1
               // 
               button1.FlatStyle = FlatStyle.System;
               button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
               button1.Location = new Point(149, 260);
               button1.Name = "button1";
               button1.Size = new Size(115, 43);
               button1.TabIndex = 5;
               button1.Text = "Login";
               button1.UseVisualStyleBackColor = true;
               button1.Click += button1_Click;
               // 
               // panel1
               // 
               panel1.BackColor = Color.FromArgb(150, 255, 110, 50);
               panel1.Controls.Add(checkBox1);
               panel1.Controls.Add(label1);
               panel1.Controls.Add(button1);
               panel1.Controls.Add(textBox2);
               panel1.Controls.Add(textBox1);
               panel1.Location = new Point(181, 56);
               panel1.Name = "panel1";
               panel1.Size = new Size(410, 323);
               panel1.TabIndex = 7;
               // 
               // checkBox1
               // 
               checkBox1.AutoSize = true;
               checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
               checkBox1.Location = new Point(58, 225);
               checkBox1.Name = "checkBox1";
               checkBox1.Size = new Size(130, 24);
               checkBox1.TabIndex = 6;
               checkBox1.Text = "Xem mật khẩu";
               checkBox1.UseVisualStyleBackColor = true;
               checkBox1.CheckedChanged += checkBox1_CheckedChanged;
               // 
               // Form1
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.FromArgb(255, 110, 50);
               BackgroundImage = Properties.Resources.c94793cf_13f3_481d_ba0d_ac7773a785b8;
               BackgroundImageLayout = ImageLayout.Stretch;
               ClientSize = new Size(800, 450);
               Controls.Add(panel1);
               Name = "Form1";
               Text = "QUẢN LÝ NHÀ HÀNG";
               panel1.ResumeLayout(false);
               panel1.PerformLayout();
               ResumeLayout(false);
>>>>>>> e5e19104cdb1d89226a617bffd10d33250c3212f
          }

          #endregion

          private Label label1;
          private TextBox textBox1;
          private TextBox textBox2;
          private Button button1;
          private Panel panel1;
          private CheckBox checkBox1;
     }
}
