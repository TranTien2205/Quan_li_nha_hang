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
    public partial class QRcode : Form
    {
        public QRcode(Bitmap qrImage, string sotien)
        {
            InitializeComponent();
            QRBox.Image = qrImage;
            QRBox.SizeMode = PictureBoxSizeMode.Zoom;
            QRBox.Dock = DockStyle.Top;
            QRBox.Height = 300;

            SotienLabel1.Text = sotien + " VND";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã chuyển khoản!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // đóng FormQR → quay lại Form1
        }
    }
}
