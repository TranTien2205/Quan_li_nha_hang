using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Quan_li_nha_hang;
using System.Reflection.Emit;

namespace Quan_li_nha_hang
{
     public partial class Form2 : Form
     {
          public Form2(Form1 form_1)
          {
               InitializeComponent();
               this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
          }

          private void Form2_Load(object sender, EventArgs e)
          {
               timer1.Start();
               panel1.Visible = false;

               panel5.Visible = false;
          }
          private void Form_FormClosed(object sender, FormClosedEventArgs e)
          {
               Application.Exit(); // Thoát toàn bộ ứng dụng khi Form1 đóng
          }

          private void button17_Click(object sender, EventArgs e)
          {

          }

          private void button27_Click(object sender, EventArgs e)
          {

               button27.BackColor = Color.LightGoldenrodYellow;
               button27.ForeColor = Color.Red;
               button27.FlatStyle = FlatStyle.Flat;
               button27.FlatAppearance.BorderColor = Color.LightGoldenrodYellow;

               button28.BackColor = Color.DeepSkyBlue;
               button28.ForeColor = Color.Black;
               button28.FlatStyle = FlatStyle.Standard;

               button29.BackColor = Color.DeepSkyBlue;
               button29.ForeColor = Color.Black;
               button29.FlatStyle = FlatStyle.Standard;

               panel1.Visible = false;

               panel5.Visible = false;
          }


          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void label3_Click(object sender, EventArgs e)
          {

          }
          private void timer1_Tick(object sender, EventArgs e)
          {
               label4.Text = DateTime.Now.ToString("HH:mm:ss");
          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label6_Click(object sender, EventArgs e)
          {

          }

          private void button28_Click(object sender, EventArgs e)
          {
               button27.BackColor = Color.DeepSkyBlue;
               button27.ForeColor = Color.Black;
               button27.FlatStyle = FlatStyle.Standard;


               button28.BackColor = Color.LightGoldenrodYellow;
               button28.ForeColor = Color.Red;
               button28.FlatStyle = FlatStyle.Flat;
               button28.FlatAppearance.BorderColor = Color.LightGoldenrodYellow;

               button29.BackColor = Color.DeepSkyBlue;
               button29.ForeColor = Color.Black;
               button29.FlatStyle = FlatStyle.Standard;

               panel1.Visible = true;

               panel5.Visible = false;
          }

          private void button29_Click(object sender, EventArgs e)
          {
               button27.BackColor = Color.DeepSkyBlue;
               button27.ForeColor = Color.Black;
               button27.FlatStyle = FlatStyle.Standard;

               button28.BackColor = Color.DeepSkyBlue;
               button28.ForeColor = Color.Black;
               button28.FlatStyle = FlatStyle.Standard;

               button29.BackColor = Color.LightGoldenrodYellow;
               button29.ForeColor = Color.Red;
               button29.FlatStyle = FlatStyle.Flat;
               button29.FlatAppearance.BorderColor = Color.LightGoldenrodYellow;

               panel1.Visible = false;

               panel5.Visible = true;
          }
          private void btnBan_Click(object sender, EventArgs e)
          {
               Button btn = sender as Button;
               //int trangThai = Convert.ToInt32(btn.Tag);

               //if (trangThai == 0)
               //{
               //   MessageBox.Show($"{btn.Text} đang trống.");
               // }
               //else
               //{
               //    MessageBox.Show($"{btn.Text} đang có khách.");
               //}
               label3.Text = btn.Text;
          }

          private void button36_Click(object sender, EventArgs e)
          {

          }

          private void button27_Click_1(object sender, EventArgs e)
          {

          }
     }
}
