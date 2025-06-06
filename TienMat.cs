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
    public partial class TienMat : Form
    {
        public TienMat(decimal TienHD)
        {
            InitializeComponent();
            label_TienHD.Text = TienHD.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã thanh toán!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // đóng FormQR → quay lại Form1
        }

        private void text_TienKH_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text_TienKH.Text, out decimal tienKhach) &&
        decimal.TryParse(label_TienHD.Text, out decimal tongTien))
            {
                decimal tienDu = tienKhach - tongTien;

                // Định dạng thành "000.000vnd"
                lab_tienDu.Text = tienDu.ToString();
            }
            else
            {
                lab_tienDu.Text = "ERROR";
            }
        }
    }
}
