using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_nha_hang
{
     public partial class Form3 : Form
     {
          string connectionString = "Server=LAPTOP-TINNGUYE\\MSSQLSERVER01;Database=QuanLyNhaHang5;User Id=user_tin;Password=123456789@@@;Encrypt=False;";
          private System.Windows.Forms.Timer timer;
          public Form3()
          {
               InitializeComponent();
               this.Load += new EventHandler(admin_Load);

               // Tạo các nút động trong panel1
               string[] buttonTexts = { "DASHBOARD", "THÊM NHÂN VIÊN", "THÊM ACCOUNT", "THỐNG KÊ KHO", "XEM DỮ LIỆU KHÁCH HÀNG", "THỐNG KÊ BÀN ĂN", "THỐNG KÊ DOANH THU", "NHẬP KHO" };
               int y = 100;
               for (int i = 0; i < buttonTexts.Length; i++)
               {
                    Button btn = new Button
                    {
                         Text = buttonTexts[i],
                         Location = new Point(10, y),
                         Size = new Size(180, 40),
                         BackColor = Color.FromArgb(0, 71, 160),
                         FlatStyle = FlatStyle.Flat,
                         FlatAppearance = { BorderSize = 0 },
                         Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                         ForeColor = Color.White,
                         TabIndex = i + 1
                    };
                    panel1.Controls.Add(btn);

                    // Gán sự kiện cho các nút (ví dụ)
                    switch (i)
                    {
                         case 0: btn.Click += (s, e) => ShowDashboard(); break;
                         case 1: btn.Click += (s, e) => ShowAddEmployee(); break;
                         case 2: btn.Click += (s, e) => ShowAddAccount(); break;
                         case 3: btn.Click += (s, e) => ShowInventoryStats(); break;
                         case 4: btn.Click += (s, e) => ShowCustomerData(); break;
                         case 5: btn.Click += (s, e) => ShowTableStats(); break;
                         case 6: btn.Click += (s, e) => ShowRevenueStats(); break;
                         case 7: btn.Click += (s, e) => ShowStockEntry(); break;
                    }

                    y += 50;
               }

               // Cập nhật btnLogout nếu cần
               btnLogout.Click += (s, e) => this.Close();

               // Mặc định hiển thị DASHBOARD
               ShowDashboard();
          }
          private void admin_Load(object sender, EventArgs e)
          {
               timer = new System.Windows.Forms.Timer();
               timer.Interval = 1000; // Cập nhật mỗi giây
               timer.Tick += (s, ev) => lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
               timer.Start();
          }

          private void ShowDashboard()
               {
                    mainPanel.Controls.Clear();
                    chart1.Visible = true;
                    mainPanel.Controls.Add(chart1);
                    chart1.BringToFront();

                    chart1.Series.Clear();
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series("Nhân viên")
                    {
                         ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                         Color = Color.FromArgb(70, 130, 180)
                    };

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand("SELECT chucVu, COUNT(*) as Total FROM NhanVien GROUP BY chucVu", conn);
                         SqlDataReader reader = cmd.ExecuteReader();

                         while (reader.Read())
                         {
                              string chucVu = reader["chucVu"].ToString();
                              int total = Convert.ToInt32(reader["Total"]);
                              series1.Points.AddXY(chucVu, total);
                         }
                    }

                    chart1.Series.Add(series1);
                    chart1.ChartAreas[0].AxisX.Title = "Chức vụ";
                    chart1.ChartAreas[0].AxisY.Title = "Số lượng";
                    chart1.Titles.Clear();
                    chart1.Titles.Add("Thống kê nhân viên");
               }

               private void ShowAddEmployee()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "THÊM NHÂN VIÊN", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    int y = 50;
                    string[] labels = { "Mã NV", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT", "Chức vụ", "Lương" };
                    TextBox[] textBoxes = new TextBox[labels.Length];
                    for (int i = 0; i < labels.Length; i++)
                    {
                         Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                         textBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                         if (i == 2) textBoxes[i].Text = "2000-01-01"; // Giá trị mặc định
                         mainPanel.Controls.Add(lbl);
                         mainPanel.Controls.Add(textBoxes[i]);
                         y += 30;
                    }

                    // Nút Thêm
                    Button btnAdd = new Button { Text = "Thêm", Location = new Point(120, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnAdd.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text) || string.IsNullOrWhiteSpace(textBoxes[1].Text) || string.IsNullOrWhiteSpace(textBoxes[6].Text))
                              {
                                   MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand(
                                       "INSERT INTO NhanVien (maNhanVien, hoTen, ngaySinh, diaChi, sdt, chucVu, luong) VALUES (@maNhanVien, @hoTen, @ngaySinh, @diaChi, @sdt, @chucVu, @luong)",
                                       conn);
                                   cmd.Parameters.AddWithValue("@maNhanVien", textBoxes[0].Text);
                                   cmd.Parameters.AddWithValue("@hoTen", textBoxes[1].Text);
                                   cmd.Parameters.AddWithValue("@ngaySinh", textBoxes[2].Text);
                                   cmd.Parameters.AddWithValue("@diaChi", textBoxes[3].Text);
                                   cmd.Parameters.AddWithValue("@sdt", textBoxes[4].Text);
                                   cmd.Parameters.AddWithValue("@chucVu", textBoxes[5].Text);
                                   cmd.Parameters.AddWithValue("@luong", Convert.ToDecimal(textBoxes[6].Text));
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Thêm thành công!");
                                   LoadEmployeeData();
                                   Array.ForEach(textBoxes, tb => tb.Clear());
                                   textBoxes[2].Text = "2000-01-01";
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnAdd);

                    // Nút Cập nhật
                    Button btnUpdate = new Button { Text = "Cập nhật", Location = new Point(210, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnUpdate.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text))
                              {
                                   MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand(
                                       "UPDATE NhanVien SET hoTen = @hoTen, ngaySinh = @ngaySinh, diaChi = @diaChi, sdt = @sdt, chucVu = @chucVu, luong = @luong WHERE maNhanVien = @maNhanVien",
                                       conn);
                                   cmd.Parameters.AddWithValue("@maNhanVien", textBoxes[0].Text);
                                   cmd.Parameters.AddWithValue("@hoTen", textBoxes[1].Text);
                                   cmd.Parameters.AddWithValue("@ngaySinh", textBoxes[2].Text);
                                   cmd.Parameters.AddWithValue("@diaChi", textBoxes[3].Text);
                                   cmd.Parameters.AddWithValue("@sdt", textBoxes[4].Text);
                                   cmd.Parameters.AddWithValue("@chucVu", textBoxes[5].Text);
                                   cmd.Parameters.AddWithValue("@luong", Convert.ToDecimal(textBoxes[6].Text));
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Cập nhật thành công!");
                                   LoadEmployeeData();
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnUpdate);

                    // Nút Làm mới
                    Button btnClear = new Button { Text = "Làm mới", Location = new Point(300, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnClear.Click += (s, e) =>
                    {
                         Array.ForEach(textBoxes, tb => tb.Clear());
                         textBoxes[2].Text = "2000-01-01";
                    };
                    mainPanel.Controls.Add(btnClear);

                    // Nút Xóa
                    Button btnDelete = new Button { Text = "Xóa", Location = new Point(390, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnDelete.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text))
                              {
                                   MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE maNhanVien = @maNhanVien", conn);
                                   cmd.Parameters.AddWithValue("@maNhanVien", textBoxes[0].Text);
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Xóa thành công!");
                                   LoadEmployeeData();
                                   Array.ForEach(textBoxes, tb => tb.Clear());
                                   textBoxes[2].Text = "2000-01-01";
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnDelete);

                    // Sự kiện chọn dòng trong DataGridView
                    dataGridView.SelectionChanged += (s, e) =>
                    {
                         if (dataGridView.SelectedRows.Count > 0)
                         {
                              DataGridViewRow row = dataGridView.SelectedRows[0];
                              textBoxes[0].Text = row.Cells["maNhanVien"].Value.ToString();
                              textBoxes[1].Text = row.Cells["hoTen"].Value.ToString();
                              textBoxes[2].Text = row.Cells["ngaySinh"].Value.ToString();
                              textBoxes[3].Text = row.Cells["diaChi"].Value.ToString();
                              textBoxes[4].Text = row.Cells["sdt"].Value.ToString();
                              textBoxes[5].Text = row.Cells["chucVu"].Value.ToString();
                              textBoxes[6].Text = row.Cells["luong"].Value.ToString();
                         }
                    };

                    LoadEmployeeData();
               }

               private void LoadEmployeeData()
               {
                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("maNhanVien", "Mã NV");
                    dataGridView.Columns.Add("hoTen", "Họ tên");
                    dataGridView.Columns.Add("ngaySinh", "Ngày sinh");
                    dataGridView.Columns.Add("diaChi", "Địa chỉ");
                    dataGridView.Columns.Add("sdt", "SĐT");
                    dataGridView.Columns.Add("chucVu", "Chức vụ");
                    dataGridView.Columns.Add("luong", "Lương");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter("SELECT maNhanVien, hoTen, ngaySinh, diaChi, sdt, chucVu, luong FROM NhanVien", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowAddAccount()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "THÊM ACCOUNT", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    int y = 50;
                    string[] labels = { "Mã Account", "Tên đăng nhập", "Mật khẩu", "Vai trò" };
                    TextBox[] textBoxes = new TextBox[labels.Length];
                    for (int i = 0; i < labels.Length; i++)
                    {
                         Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                         textBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                         if (i == 2) textBoxes[i].PasswordChar = '*';
                         mainPanel.Controls.Add(lbl);
                         mainPanel.Controls.Add(textBoxes[i]);
                         y += 30;
                    }

                    // Nút Thêm
                    Button btnAdd = new Button { Text = "Thêm", Location = new Point(120, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnAdd.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text) || string.IsNullOrWhiteSpace(textBoxes[1].Text) || string.IsNullOrWhiteSpace(textBoxes[2].Text))
                              {
                                   MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand(
                                       "INSERT INTO Accounts (maAccount, username, password, role) VALUES (@maAccount, @username, @password, @role)",
                                       conn);
                                   cmd.Parameters.AddWithValue("@maAccount", textBoxes[0].Text);
                                   cmd.Parameters.AddWithValue("@username", textBoxes[1].Text);
                                   cmd.Parameters.AddWithValue("@password", textBoxes[2].Text);
                                   cmd.Parameters.AddWithValue("@role", textBoxes[3].Text);
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Thêm thành công!");
                                   LoadAccountData();
                                   Array.ForEach(textBoxes, tb => tb.Clear());
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnAdd);

                    // Nút Cập nhật
                    Button btnUpdate = new Button { Text = "Cập nhật", Location = new Point(210, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnUpdate.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text))
                              {
                                   MessageBox.Show("Vui lòng chọn tài khoản để cập nhật!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand(
                                       "UPDATE Accounts SET username = @username, password = @password, role = @role WHERE maAccount = @maAccount",
                                       conn);
                                   cmd.Parameters.AddWithValue("@maAccount", textBoxes[0].Text);
                                   cmd.Parameters.AddWithValue("@username", textBoxes[1].Text);
                                   cmd.Parameters.AddWithValue("@password", textBoxes[2].Text);
                                   cmd.Parameters.AddWithValue("@role", textBoxes[3].Text);
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Cập nhật thành công!");
                                   LoadAccountData();
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnUpdate);

                    // Nút Làm mới
                    Button btnClear = new Button { Text = "Làm mới", Location = new Point(300, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnClear.Click += (s, e) => Array.ForEach(textBoxes, tb => tb.Clear());
                    mainPanel.Controls.Add(btnClear);

                    // Nút Xóa
                    Button btnDelete = new Button { Text = "Xóa", Location = new Point(390, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnDelete.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text))
                              {
                                   MessageBox.Show("Vui lòng chọn tài khoản để xóa!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand("DELETE FROM Accounts WHERE maAccount = @maAccount", conn);
                                   cmd.Parameters.AddWithValue("@maAccount", textBoxes[0].Text);
                                   cmd.ExecuteNonQuery();
                                   MessageBox.Show("Xóa thành công!");
                                   LoadAccountData();
                                   Array.ForEach(textBoxes, tb => tb.Clear());
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnDelete);

                    // Sự kiện chọn dòng trong DataGridView
                    dataGridView.SelectionChanged += (s, e) =>
                    {
                         if (dataGridView.SelectedRows.Count > 0)
                         {
                              DataGridViewRow row = dataGridView.SelectedRows[0];
                              textBoxes[0].Text = row.Cells["maAccount"].Value.ToString();
                              textBoxes[1].Text = row.Cells["username"].Value.ToString();
                              textBoxes[2].Text = row.Cells["password"].Value.ToString();
                              textBoxes[3].Text = row.Cells["role"].Value.ToString();
                         }
                    };

                    LoadAccountData();
               }

               private void LoadAccountData()
               {
                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("maAccount", "Mã Account");
                    dataGridView.Columns.Add("username", "Tên đăng nhập");
                    dataGridView.Columns.Add("password", "Mật khẩu");
                    dataGridView.Columns.Add("role", "Vai trò");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter("SELECT maAccount, username, password, role FROM Accounts", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowInventoryStats()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "THỐNG KÊ KHO", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("tenNguonNguyenLieu", "Tên nguyên liệu");
                    dataGridView.Columns.Add("donViTinh", "Đơn vị");
                    dataGridView.Columns.Add("TongSoLuong", "Tổng số lượng");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter(
                             "SELECT nnl.tenNguonNguyenLieu, nnl.donViTinh, SUM(ctpn.soLuong) as TongSoLuong " +
                             "FROM NguonNguyenLieu nnl " +
                             "LEFT JOIN ChiTietPhieuNhap ctpn ON nnl.maNguonNguyenLieu = ctpn.maNguonNguyenLieu " +
                             "GROUP BY nnl.tenNguonNguyenLieu, nnl.donViTinh", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowCustomerData()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "XEM DỮ LIỆU KHÁCH HÀNG", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("maKhachHang", "Mã KH");
                    dataGridView.Columns.Add("hoTen", "Họ tên");
                    dataGridView.Columns.Add("sdt", "SĐT");
                    dataGridView.Columns.Add("diaChi", "Địa chỉ");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter("SELECT maKhachHang, hoTen, sdt, diaChi FROM KhachHang", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowTableStats()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "THỐNG KÊ BÀN ĂN", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("maBanAn", "Mã bàn");
                    dataGridView.Columns.Add("trangThai", "Trạng thái");
                    dataGridView.Columns.Add("BookingCount", "Số lần đặt");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter(
                             "SELECT ba.maBanAn, ba.trangThai, COUNT(*) as BookingCount " +
                             "FROM BanAn ba " +
                             "GROUP BY ba.maBanAn, ba.trangThai", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowRevenueStats()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "THỐNG KÊ DOANH THU", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("ngayLapHoaDon", "Ngày");
                    dataGridView.Columns.Add("TotalRevenue", "Tổng doanh thu");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter(
                             "SELECT hd.ngayLapHoaDon, SUM(hd.tongTien) as TotalRevenue " +
                             "FROM HoaDon hd " +
                             "GROUP BY hd.ngayLapHoaDon", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }

               private void ShowStockEntry()
               {
                    mainPanel.Controls.Clear();
                    dataGridView.Visible = true;
                    mainPanel.Controls.Add(dataGridView);

                    Label lblTitle = new Label { Text = "NHẬP KHO", Location = new Point(10, 10), Size = new Size(200, 30), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
                    mainPanel.Controls.Add(lblTitle);

                    int y = 50;
                    string[] labels = { "Mã phiếu nhập", "Mã nhân viên", "Tên nguyên liệu", "Số lượng", "Thành tiền" };
                    TextBox[] textBoxes = new TextBox[labels.Length];
                    ComboBox cbNguyenLieu = new ComboBox();

                    for (int i = 0; i < labels.Length; i++)
                    {
                         Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                         if (i == 2)
                         {
                              cbNguyenLieu.Location = new Point(120, y);
                              cbNguyenLieu.Size = new Size(200, 20);
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd = new SqlCommand("SELECT maNguonNguyenLieu, tenNguonNguyenLieu FROM NguonNguyenLieu", conn);
                                   SqlDataReader reader = cmd.ExecuteReader();
                                   while (reader.Read())
                                   {
                                        cbNguyenLieu.Items.Add(new { Text = reader["tenNguonNguyenLieu"].ToString(), Value = reader["maNguonNguyenLieu"].ToString() });
                                   }
                                   cbNguyenLieu.DisplayMember = "Text";
                                   cbNguyenLieu.ValueMember = "Value";
                              }
                              mainPanel.Controls.Add(cbNguyenLieu);
                         }
                         else
                         {
                              textBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                              mainPanel.Controls.Add(textBoxes[i]);
                         }
                         mainPanel.Controls.Add(lbl);
                         y += 30;
                    }

                    // Nút Thêm
                    Button btnAdd = new Button { Text = "Thêm", Location = new Point(120, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnAdd.Click += (s, e) =>
                    {
                         try
                         {
                              if (string.IsNullOrWhiteSpace(textBoxes[0].Text) || string.IsNullOrWhiteSpace(textBoxes[1].Text) || cbNguyenLieu.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxes[3].Text) || string.IsNullOrWhiteSpace(textBoxes[4].Text))
                              {
                                   MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                                   return;
                              }
                              using (SqlConnection conn = new SqlConnection(connectionString))
                              {
                                   conn.Open();
                                   SqlCommand cmd1 = new SqlCommand(
                                       "INSERT INTO PhieuNhap (maPhieuNhap, maNhanVien, ngayGiaoNhap, tongTien) VALUES (@maPhieuNhap, @maNhanVien, @ngayGiaoNhap, @tongTien)",
                                       conn);
                                   cmd1.Parameters.AddWithValue("@maPhieuNhap", textBoxes[0].Text);
                                   cmd1.Parameters.AddWithValue("@maNhanVien", textBoxes[1].Text);
                                   cmd1.Parameters.AddWithValue("@ngayGiaoNhap", DateTime.Now.ToString("yyyy-MM-dd"));
                                   cmd1.Parameters.AddWithValue("@tongTien", Convert.ToDecimal(textBoxes[4].Text));
                                   cmd1.ExecuteNonQuery();

                                   SqlCommand cmd2 = new SqlCommand(
                                       "INSERT INTO ChiTietPhieuNhap (maPhieuNhap, maNguonNguyenLieu, soLuong, trangThai) VALUES (@maPhieuNhap, @maNguonNguyenLieu, @soLuong, @trangThai)",
                                       conn);
                                   cmd2.Parameters.AddWithValue("@maPhieuNhap", textBoxes[0].Text);
                                   cmd2.Parameters.AddWithValue("@maNguonNguyenLieu", (cbNguyenLieu.SelectedItem as dynamic).Value);
                                   cmd2.Parameters.AddWithValue("@soLuong", Convert.ToInt32(textBoxes[3].Text));
                                   cmd2.Parameters.AddWithValue("@trangThai", "Hoàn thành");
                                   cmd2.ExecuteNonQuery();

                                   MessageBox.Show("Nhập kho thành công!");
                                   LoadStockEntryData();
                                   Array.ForEach(textBoxes, tb => tb.Clear());
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Lỗi: " + ex.Message);
                         }
                    };
                    mainPanel.Controls.Add(btnAdd);

                    // Nút Làm mới
                    Button btnClear = new Button { Text = "Làm mới", Location = new Point(210, y), Size = new Size(80, 30), BackColor = Color.FromArgb(0, 71, 160), ForeColor = Color.White };
                    btnClear.Click += (s, e) => Array.ForEach(textBoxes, tb => tb.Clear());
                    mainPanel.Controls.Add(btnClear);

                    LoadStockEntryData();
               }

               private void LoadStockEntryData()
               {
                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("maPhieuNhap", "Mã phiếu nhập");
                    dataGridView.Columns.Add("maNhanVien", "Mã nhân viên");
                    dataGridView.Columns.Add("ngayGiaoNhap", "Ngày nhập");
                    dataGridView.Columns.Add("tongTien", "Tổng tiền");

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter("SELECT maPhieuNhap, maNhanVien, ngayGiaoNhap, tongTien FROM PhieuNhap", conn);
                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }
     }
}
