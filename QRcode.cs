using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_nha_hang
{
     public partial class QRcode : Form
     {
          private Bitmap qrImage;
          private string soTien;

          /// <summary>
          /// Constructor nhận hình ảnh QR và số tiền để hiển thị
          /// </summary>
          public QRcode(Bitmap qrImage, string soTien)
          {
               InitializeComponent();
               this.qrImage = qrImage;
               this.soTien = soTien;
               InitializeForm();
          }

          /// <summary>
          /// Khởi tạo form với hình ảnh QR và thông tin số tiền
          /// </summary>
          private void InitializeForm()
          {
               QRBox.Image = qrImage; // Gán hình ảnh QR
               SotienLabel1.Text = $"Số tiền: {soTien} VNĐ"; // Hiển thị số tiền
          }

          /// <summary>
          /// Xử lý khi nhấn nút "Đã chuyển khoản"
          /// </summary>
          private void button1_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close(); // Đóng form sau khi xác nhận
          }
     }
}