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
using QRCoder;

using QL_nha_hang;

namespace Quan_li_nha_hang
{
     public partial class Form2 : Form
     {
          public Form2(Form1 form_1,string user)
          {
               InitializeComponent();
               label1.Text = user;
               this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
          }

          private void Form2_Load(object sender, EventArgs e)
          {
               timer1.Start();
            
          }
          private void Form_FormClosed(object sender, FormClosedEventArgs e)
          {
               Application.Exit(); // Thoát toàn bộ ứng dụng khi Form1 đóng
          }

          private void button17_Click(object sender, EventArgs e)
          {

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

        private void button27_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            string soTien = label6.Text.Trim();
            if (string.IsNullOrEmpty(soTien))
            {
                MessageBox.Show("Tổng tiền bằng 0k ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenNguoiNhan = "NGUYEN ANH TIN";
            string soTaiKhoan = "123456789";
            string tenNganHang = "VCB";
            string noiDung = "Chuyen khoan";

            string data = $"Tên: {tenNguoiNhan}\nstk={soTaiKhoan} \nNgân hàng: {tenNganHang} \nSố tiền: {soTien} VND \nNội dung: {noiDung}";
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    QRcode formQR = new QRcode(qrCodeImage, soTien);
                    formQR.ShowDialog();
                    // pictureBoxQR.Image = qrCodeImage;
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            decimal TongHD = Convert.ToDecimal(label6.Text);
            TienMat formTM = new TienMat(TongHD);
            formTM.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      
    }
}
