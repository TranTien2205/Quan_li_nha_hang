using Quan_li_nha_hang;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace Quan_li_nha_hang
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label3_Click(object sender, EventArgs e)
          {

          }



          private void button1_Click(object sender, EventArgs e)
          {
               string username = textBox1.Text.Trim();
               string password = textBox2.Text.Trim();

               string connectionString = "Server=LAPTOP-TINNGUYE\\MSSQLSERVER01;Database=QuanLyNhaHang5;User Id=user_tin;Password=123456789@@@;Encrypt=False;";

               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                    conn.Open();
                    string query = "SELECT VaiTro,TenDangNhap FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                         cmd.Parameters.AddWithValue("@user", username);
                         cmd.Parameters.AddWithValue("@pass", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader[0].ToString();
                            string tenDangNhap = reader[1].ToString();

                            if (role == "admin")
                            {
                                Form3 f3 = new Form3();
                                this.Hide();
                                f3.Show();
                            }
                            else if (role == "user")
                            {
                                Form2 f2 = new Form2(this, tenDangNhap);
                                this.Hide();
                                f2.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
               }
          }




          private void textBox1_Click(object sender, EventArgs e)
          {
               textBox1.Text = " ";
          }

          private void textBox2_Click(object sender, EventArgs e)
          {
               textBox2.Text = " ";
          }

          private void textBox1_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    textBox2.Focus();
                    e.SuppressKeyPress = true;
               }
          }
          private void textBox2_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    button1.PerformClick();
                    e.SuppressKeyPress = true;
               }
          }

          private void checkBox1_CheckedChanged(object sender, EventArgs e)
          {
               textBox2.UseSystemPasswordChar = false;
          }

        
    }
}
