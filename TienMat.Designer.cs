using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_nha_hang
{
     partial class TienMat
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
               text_TienKH = new TextBox();
               label1 = new Label();
               label2 = new Label();
               label_TienHD = new Label();
               label4 = new Label();
               label5 = new Label();
               lab_tienDu = new Label();
               label7 = new Label();
               button1 = new Button();
               label8 = new Label();
               label9 = new Label();
               label10 = new Label();
               label11 = new Label();
               SuspendLayout();
               // 
               // text_TienKH
               // 
               text_TienKH.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               text_TienKH.Location = new Point(227, 112);
               text_TienKH.Name = "text_TienKH";
               text_TienKH.Size = new Size(93, 35);
               text_TienKH.TabIndex = 0;
               text_TienKH.TextChanged += text_TienKH_TextChanged;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label1.Location = new Point(33, 112);
               label1.Name = "label1";
               label1.Size = new Size(159, 30);
               label1.TabIndex = 1;
               label1.Text = "Tiền khách đưa:";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label2.Location = new Point(33, 171);
               label2.Name = "label2";
               label2.Size = new Size(149, 30);
               label2.TabIndex = 2;
               label2.Text = "Tổng hóa đơn:";
               // 
               // label_TienHD
               // 
               label_TienHD.AutoSize = true;
               label_TienHD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label_TienHD.Location = new Point(227, 171);
               label_TienHD.Name = "label_TienHD";
               label_TienHD.Size = new Size(84, 30);
               label_TienHD.TabIndex = 3;
               label_TienHD.Text = "000.000";
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label4.Location = new Point(193, 201);
               label4.Name = "label4";
               label4.Size = new Size(157, 30);
               label4.TabIndex = 4;
               label4.Text = "------------------";
               // 
               // label5
               // 
               label5.AutoSize = true;
               label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label5.Location = new Point(88, 242);
               label5.Name = "label5";
               label5.Size = new Size(82, 30);
               label5.TabIndex = 5;
               label5.Text = "Tiền dư";
               // 
               // lab_tienDu
               // 
               lab_tienDu.AutoSize = true;
               lab_tienDu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               lab_tienDu.Location = new Point(227, 242);
               lab_tienDu.Name = "lab_tienDu";
               lab_tienDu.Size = new Size(84, 30);
               lab_tienDu.TabIndex = 6;
               lab_tienDu.Text = "000.000";
               // 
               // label7
               // 
               label7.AutoSize = true;
               label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label7.Location = new Point(326, 115);
               label7.Name = "label7";
               label7.Size = new Size(47, 30);
               label7.TabIndex = 7;
               label7.Text = "vnđ";
               // 
               // button1
               // 
               button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
               button1.Location = new Point(120, 324);
               button1.Name = "button1";
               button1.Size = new Size(183, 36);
               button1.TabIndex = 8;
               button1.Text = "Thanh toán xong";
               button1.UseVisualStyleBackColor = true;
               button1.Click += button1_Click;
               // 
               // label8
               // 
               label8.AutoSize = true;
               label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label8.Location = new Point(33, 57);
               label8.Name = "label8";
               label8.Size = new Size(162, 30);
               label8.TabIndex = 9;
               label8.Text = "Mã khách hàng:";
               // 
               // label9
               // 
               label9.AutoSize = true;
               label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label9.Location = new Point(193, 57);
               label9.Name = "label9";
               label9.Size = new Size(84, 30);
               label9.TabIndex = 10;
               label9.Text = "KH0000";
               // 
               // label10
               // 
               label10.AutoSize = true;
               label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label10.Location = new Point(326, 171);
               label10.Name = "label10";
               label10.Size = new Size(47, 30);
               label10.TabIndex = 11;
               label10.Text = "vnđ";
               // 
               // label11
               // 
               label11.AutoSize = true;
               label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
               label11.Location = new Point(326, 242);
               label11.Name = "label11";
               label11.Size = new Size(47, 30);
               label11.TabIndex = 12;
               label11.Text = "vnđ";
               // 
               // TienMat
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(442, 424);
               Controls.Add(label11);
               Controls.Add(label10);
               Controls.Add(label9);
               Controls.Add(label8);
               Controls.Add(button1);
               Controls.Add(label7);
               Controls.Add(lab_tienDu);
               Controls.Add(label5);
               Controls.Add(label4);
               Controls.Add(label_TienHD);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(text_TienKH);
               Name = "TienMat";
               Text = "TienMat";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private TextBox text_TienKH;
          private Label label1;
          private Label label2;
          private Label label_TienHD;
          private Label label4;
          private Label label5;
          private Label lab_tienDu;
          private Label label7;
          private Button button1;
          private Label label8;
          private Label label9;
          private Label label10;
          private Label label11;
     }
}