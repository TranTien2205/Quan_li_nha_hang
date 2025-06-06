using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Quan_li_nha_hang
{
     partial class QRcode
     {
          private System.ComponentModel.IContainer components = null;
          private PictureBox QRBox;
          private Label SotienLabel1;
          private System.Windows.Forms.Button button1; // Chỉ định rõ namespace

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
               QRBox = new PictureBox();
               SotienLabel1 = new Label();
               button1 = new System.Windows.Forms.Button(); // Chỉ định rõ namespace
               ((System.ComponentModel.ISupportInitialize)QRBox).BeginInit();
               SuspendLayout();
               // 
               // QRBox
               // 
               QRBox.Location = new Point(128, 63);
               QRBox.Name = "QRBox";
               QRBox.Size = new Size(232, 224);
               QRBox.TabIndex = 0;
               QRBox.TabStop = false;
               // 
               // SotienLabel1
               // 
               SotienLabel1.AutoSize = true;
               SotienLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
               SotienLabel1.Location = new Point(184, 322);
               SotienLabel1.Name = "SotienLabel1";
               SotienLabel1.Size = new Size(125, 28);
               SotienLabel1.TabIndex = 1;
               SotienLabel1.Text = "SotienLabel1";
               // 
               // button1
               // 
               button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
               button1.Location = new Point(157, 379);
               button1.Name = "button1";
               button1.Size = new Size(191, 44);
               button1.TabIndex = 2;
               button1.Text = "Đã chuyển khoản";
               button1.UseVisualStyleBackColor = true;
               button1.Click += button1_Click;
               // 
               // QRcode
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(524, 439);
               Controls.Add(button1);
               Controls.Add(SotienLabel1);
               Controls.Add(QRBox);
               Name = "QRcode";
               Text = "QRcode";
               ((System.ComponentModel.ISupportInitialize)QRBox).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion
     }
}