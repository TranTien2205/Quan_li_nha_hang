using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_li_nha_hang
{
     public partial class Form3 : Form
     {
          private readonly string connectionString = "Server=DESKTOP-TFIHHV8\\SQLSERVER;Database=QuanLyNhaHang;Trusted_Connection=True;";
          private System.Windows.Forms.Timer timer;
          private TextBox[] employeeTextBoxes;
          private TextBox[] customerTextBoxes;
          private TextBox[] tableTextBoxes;
          private TextBox[] menuTextBoxes;

          public Form3()
          {
               InitializeComponent();
               this.Load += new EventHandler(Form3_Load);

               // Gán sự kiện cho các nút
               btnDashboard.Click += (s, e) => ShowDashboard();
               btnManageEmployees.Click += (s, e) => ShowManageEmployees();
               btnManageCustomers.Click += (s, e) => ShowManageCustomers();
               btnManageTables.Click += (s, e) => ShowManageTables();
               btnManageRevenue.Click += (s, e) => ShowManageRevenue();
               btnManageMenu.Click += (s, e) => ShowManageMenu();
               btnLogout.Click += (s, e) => this.Close();

               // Hiển thị mặc định: DASHBOARD
               ShowDashboard();
          }

          private void Form3_Load(object sender, EventArgs e)
          {
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         // Kết nối thành công
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message);
                    this.Close();
                    return;
               }

               timer = new System.Windows.Forms.Timer
               {
                    Interval = 1000 // Cập nhật mỗi giây
               };
               timer.Tick += (s, ev) => lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
               timer.Start();
          }

          private void ShowDashboard()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = true;
               lblRevenue.Visible = true;
               lblTotalRevenue.Visible = true;
               lblTotalCustomers.Visible = true;
               lblLowInventory.Visible = true;
               lblTableStatus.Visible = true;
               lblOutstandingBalance.Visible = true;
               lblOutstandingBalanceValue.Visible = true;
               lblCustomerChartTitle.Visible = true;

               mainPanel.Controls.Add(dataGridView);
               mainPanel.Controls.Add(chart1);
               mainPanel.Controls.Add(lblRevenue);
               mainPanel.Controls.Add(lblTotalRevenue);
               mainPanel.Controls.Add(lblTotalCustomers);
               mainPanel.Controls.Add(lblLowInventory);
               mainPanel.Controls.Add(lblTableStatus);
               mainPanel.Controls.Add(lblOutstandingBalance);
               mainPanel.Controls.Add(lblOutstandingBalanceValue);
               mainPanel.Controls.Add(lblCustomerChartTitle);

               // Cập nhật nhãn tổng doanh thu hôm nay
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand(
                             "SELECT SUM(tongTien) as Total FROM HoaDon WHERE CAST(ngayLapHoaDon AS DATE) = CAST(GETDATE() AS DATE)", conn);
                         object result = cmd.ExecuteScalar();
                         lblTotalRevenue.Text = result != DBNull.Value ? "Doanh thu hôm nay: " + Convert.ToDecimal(result).ToString("N0") + " VNĐ" : "Doanh thu hôm nay: 0 VNĐ";
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải doanh thu: " + ex.Message);
               }

               // Cập nhật số lượng khách hàng hôm nay
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand(
                             "SELECT COUNT(DISTINCT KH.maKhachHang) as Total FROM HoaDon HD " +
                             "JOIN PhieuYeuCau P ON P.maPhieuYeuCau=HD.maPhieuYeuCau " +
                             "JOIN KhachHang KH ON KH.maKhachHang=P.maKhachHang " +
                             "WHERE CAST(ngayLapHoaDon AS DATE) = CAST(GETDATE() AS DATE)", conn);
                         object result = cmd.ExecuteScalar();
                         lblTotalCustomers.Text = result != DBNull.Value ? "Khách hôm nay: " + Convert.ToInt32(result).ToString() : "Khách hôm nay: 0";
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải số khách hàng: " + ex.Message);
               }

               // Cập nhật số nguyên liệu tồn kho thấp
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand(
                             "SELECT COUNT(*) as LowStock FROM chiTietPhieuNhap c JOIN nguyenLieu n ON c.maNguyenLieu = n.maNguyenLieu WHERE c.soLuong < 10", conn);
                         object result = cmd.ExecuteScalar();
                         lblLowInventory.Text = result != DBNull.Value ? "Nguyên liệu thấp: " + Convert.ToInt32(result).ToString() : "Nguyên liệu thấp: 0";
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải tồn kho: " + ex.Message);
               }

               // Cập nhật trạng thái bàn
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand(
                             "SELECT COUNT(*) as Occupied FROM BanAn WHERE trangThai = N'Đang sử dụng'", conn);
                         object result = cmd.ExecuteScalar();
                         int occupied = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                         cmd = new SqlCommand("SELECT COUNT(*) FROM BanAn", conn);
                         result = cmd.ExecuteScalar();
                         int total = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                         lblTableStatus.Text = "Trạng thái bàn: " + occupied + "/" + total;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải trạng thái bàn: " + ex.Message);
               }

               // Cập nhật biểu đồ doanh thu theo ngày (7 ngày gần nhất)
               chart1.Series.Clear();
               var series = new Series("Doanh thu")
               {
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(70, 130, 180)
               };
               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlCommand cmd = new SqlCommand(
                             "SELECT CAST(ngayLapHoaDon AS DATE) as Ngay, SUM(tongTien) as Total " +
                             "FROM HoaDon " +
                             "WHERE ngayLapHoaDon >= DATEADD(day, -7, GETDATE()) " +
                             "GROUP BY CAST(ngayLapHoaDon AS DATE) " +
                             "ORDER BY Ngay", conn);
                         SqlDataReader reader = cmd.ExecuteReader();
                         bool hasData = false;
                         while (reader.Read())
                         {
                              hasData = true;
                              DateTime ngay = Convert.ToDateTime(reader["Ngay"]);
                              decimal total = Convert.ToDecimal(reader["Total"]);
                              series.Points.AddXY(ngay.ToString("dd/MM"), total);
                         }
                         if (!hasData)
                         {
                              chart1.Titles.Clear();
                              chart1.Titles.Add("Không có dữ liệu doanh thu trong 7 ngày gần nhất");
                         }
                         else
                         {
                              chart1.Series.Add(series);
                              chart1.ChartAreas[0].AxisX.Title = "Ngày";
                              chart1.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
                              chart1.Titles.Clear();
                              chart1.Titles.Add("Doanh thu 7 ngày gần nhất");
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải biểu đồ doanh thu: " + ex.Message);
               }

               LoadCustomerData();
          }

          private void LoadCustomerData()
          {
               dataGridView.Columns.Clear();

               dataGridView.Columns.Add(new DataGridViewTextBoxColumn
               {
                    Name = "ID",
                    HeaderText = "ID",
                    DataPropertyName = "ID"
               });
               dataGridView.Columns.Add(new DataGridViewTextBoxColumn
               {
                    Name = "Tên khách hàng",
                    HeaderText = "Tên khách hàng",
                    DataPropertyName = "TenKhachHang"
               });
               dataGridView.Columns.Add(new DataGridViewTextBoxColumn
               {
                    Name = "Địa chỉ",
                    HeaderText = "Địa chỉ",
                    DataPropertyName = "DiaChi"
               });
               dataGridView.Columns.Add(new DataGridViewTextBoxColumn
               {
                    Name = "SĐT",
                    HeaderText = "SĐT",
                    DataPropertyName = "SDT"
               });

               try
               {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         SqlDataAdapter adapter = new SqlDataAdapter(
                             "SELECT DISTINCT TOP 10 KH.maKhachHang as ID, KH.HoTen as TenKhachHang, KH.DiaChi as DiaChi, KH.SDT as SDT " +
                             "FROM KhachHang KH " +
                             "WHERE KH.maKhachHang IN (" +
                             "    SELECT DISTINCT KH2.maKhachHang FROM HoaDon HD " +
                             "    JOIN PhieuYeuCau P ON P.maPhieuYeuCau = HD.maPhieuYeuCau " +
                             "    JOIN KhachHang KH2 ON KH2.maKhachHang = P.maKhachHang)", conn);

                         DataTable dt = new DataTable();
                         adapter.Fill(dt);
                         dataGridView.DataSource = dt;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi tải dữ liệu khách hàng: " + ex.Message);
               }
          }


          private void ShowManageEmployees()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = false;
               lblRevenue.Visible = false;
               lblTotalRevenue.Visible = false;
               lblTotalCustomers.Visible = false;
               lblLowInventory.Visible = false;
               lblTableStatus.Visible = false;
               lblOutstandingBalance.Visible = false;
               lblOutstandingBalanceValue.Visible = false;
               lblCustomerChartTitle.Visible = false;

               mainPanel.Controls.Add(dataGridView);

               Label lblTitle = new Label
               {
                    Text = "QUẢN LÝ NHÂN VIÊN",
                    Location = new Point(10, 10),
                    Size = new Size(200, 30),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold)
               };
               mainPanel.Controls.Add(lblTitle);

               int y = 50;
               string[] labels = { "Mã NV", "Họ tên", "Giới tính", "Ngày sinh", "Địa chỉ", "SĐT", "Chức vụ", "Lương" };
               employeeTextBoxes = new TextBox[labels.Length];
               for (int i = 0; i < labels.Length; i++)
               {
                    Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                    employeeTextBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                    //if (i == 2) employeeTextBoxes[i].Text = "Nam";
                    //if (i == 3) employeeTextBoxes[i].Text = "2000-01-01";
                    mainPanel.Controls.Add(lbl);
                    mainPanel.Controls.Add(employeeTextBoxes[i]);
                    y += 30;
               }

               Button btnAdd = new Button
               {
                    Text = "Thêm",
                    Location = new Point(120, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnAdd.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(employeeTextBoxes[0].Text) || string.IsNullOrWhiteSpace(employeeTextBoxes[1].Text) || string.IsNullOrWhiteSpace(employeeTextBoxes[7].Text))
                         {
                              MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                              return;
                         }

                         if (!DateTime.TryParse(employeeTextBoxes[3].Text, out DateTime ngaySinh))
                         {
                              MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập theo định dạng yyyy-MM-dd.");
                              return;
                         }

                         if (!decimal.TryParse(employeeTextBoxes[7].Text, out decimal luong) || luong < 0)
                         {
                              MessageBox.Show("Lương không hợp lệ! Vui lòng nhập số dương.");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE maNhanVien = @maNhanVien", conn);
                              checkCmd.Parameters.AddWithValue("@maNhanVien", employeeTextBoxes[0].Text);
                              int count = (int)checkCmd.ExecuteScalar();
                              if (count > 0)
                              {
                                   MessageBox.Show("Mã nhân viên đã tồn tại!");
                                   return;
                              }

                              SqlCommand cmd = new SqlCommand(
                                  "INSERT INTO NhanVien (maNhanVien, hoTen, gioiTinh, ngaySinh, DiaChi, sdt, chucVu, luong) VALUES (@maNhanVien, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @sdt, @chucVu, @luong)",
                                  conn);
                              cmd.Parameters.AddWithValue("@maNhanVien", employeeTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@hoTen", employeeTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@gioiTinh", employeeTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                              cmd.Parameters.AddWithValue("@diaChi", employeeTextBoxes[4].Text);
                              cmd.Parameters.AddWithValue("@sdt", employeeTextBoxes[5].Text);
                              cmd.Parameters.AddWithValue("@chucVu", employeeTextBoxes[6].Text);
                              cmd.Parameters.AddWithValue("@luong", luong);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Thêm thành công!");
                              LoadEmployeeData();
                              Array.ForEach(employeeTextBoxes, tb => tb.Clear());
                              employeeTextBoxes[2].Text = "Nam";
                              employeeTextBoxes[3].Text = "2000-01-01";
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnAdd);

               Button btnUpdate = new Button
               {
                    Text = "Cập nhật",
                    Location = new Point(210, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnUpdate.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(employeeTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!");
                              return;
                         }

                         if (!DateTime.TryParse(employeeTextBoxes[3].Text, out DateTime ngaySinh))
                         {
                              MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập theo định dạng yyyy-MM-dd.");
                              return;
                         }

                         if (!decimal.TryParse(employeeTextBoxes[7].Text, out decimal luong) || luong < 0)
                         {
                              MessageBox.Show("Lương không hợp lệ! Vui lòng nhập số dương.");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand(
                                  "UPDATE NhanVien SET hoTen = @hoTen, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, diaChi = @diaChi, sdt = @sdt, chucVu = @chucVu, luong = @luong WHERE maNhanVien = @maNhanVien",
                                  conn);
                              cmd.Parameters.AddWithValue("@maNhanVien", employeeTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@hoTen", employeeTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@gioiTinh", employeeTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                              cmd.Parameters.AddWithValue("@diaChi", employeeTextBoxes[4].Text);
                              cmd.Parameters.AddWithValue("@sdt", employeeTextBoxes[5].Text);
                              cmd.Parameters.AddWithValue("@chucVu", employeeTextBoxes[6].Text);
                              cmd.Parameters.AddWithValue("@luong", luong);
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

               Button btnDelete = new Button
               {
                    Text = "Xóa",
                    Location = new Point(300, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnDelete.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(employeeTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                              return;
                         }
                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE maNhanVien = @maNhanVien", conn);
                              cmd.Parameters.AddWithValue("@maNhanVien", employeeTextBoxes[0].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Xóa thành công!");
                              LoadEmployeeData();
                              Array.ForEach(employeeTextBoxes, tb => tb.Clear());
                              employeeTextBoxes[2].Text = "Nam";
                              employeeTextBoxes[3].Text = "2000-01-01";
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnDelete);

               dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Employees;
               dataGridView.SelectionChanged += DataGridView_SelectionChanged_Employees;

               LoadEmployeeData();
          }

          private void LoadEmployeeData()
          {
               try
               {
                    // Clear existing columns
                    dataGridView.Columns.Clear();
                    dataGridView.AutoGenerateColumns = false; // Prevent auto-generated columns

                    // Define columns with formatting
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "maNhanVien",
                         HeaderText = "Mã NV",
                         DataPropertyName = "maNhanVien",
                         Width = 80
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "hoTen",
                         HeaderText = "Họ tên",
                         DataPropertyName = "hoTen",
                         Width = 150
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "gioiTinh",
                         HeaderText = "Giới tính",
                         DataPropertyName = "gioiTinh",
                         Width = 80
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "ngaySinh",
                         HeaderText = "Ngày sinh",
                         DataPropertyName = "ngaySinh",
                         Width = 100,
                         DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } // Format date
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "diaChi",
                         HeaderText = "Địa chỉ",
                         DataPropertyName = "diaChi",
                         Width = 200
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "sdt",
                         HeaderText = "SĐT",
                         DataPropertyName = "sdt",
                         Width = 100
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "chucVu",
                         HeaderText = "Chức vụ",
                         DataPropertyName = "chucVu",
                         Width = 120
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "luong",
                         HeaderText = "Lương",
                         DataPropertyName = "luong",
                         Width = 100,
                         DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } // Format as number (no decimals)
                    });

                    // Load data from database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT maNhanVien, hoTen, gioiTinh, ngaySinh, diaChi, sdt, chucVu, luong FROM NhanVien", conn))
                         {
                              DataTable dt = new DataTable();
                              adapter.Fill(dt);
                              dataGridView.DataSource = dt;
                         }
                    }
               }
               catch (SqlException ex)
               {
                    MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi tải dữ liệu nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void DataGridView_SelectionChanged_Employees(object sender, EventArgs e)
          {
               if (dataGridView.SelectedRows.Count > 0)
               {
                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    employeeTextBoxes[0].Text = row.Cells["maNhanVien"].Value?.ToString() ?? "";
                    employeeTextBoxes[1].Text = row.Cells["hoTen"].Value?.ToString() ?? "";
                    employeeTextBoxes[2].Text = row.Cells["gioiTinh"].Value?.ToString() ?? "Nam";
                    employeeTextBoxes[3].Text = row.Cells["ngaySinh"].Value?.ToString() ?? "2000-01-01";
                    employeeTextBoxes[4].Text = row.Cells["diaChi"].Value?.ToString() ?? "";
                    employeeTextBoxes[5].Text = row.Cells["sdt"].Value?.ToString() ?? "";
                    employeeTextBoxes[6].Text = row.Cells["chucVu"].Value?.ToString() ?? "";
                    employeeTextBoxes[7].Text = row.Cells["luong"].Value?.ToString() ?? "";
               }
          }

          private void ShowManageCustomers()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = false;
               lblRevenue.Visible = false;
               lblTotalRevenue.Visible = false;
               lblTotalCustomers.Visible = false;
               lblLowInventory.Visible = false;
               lblTableStatus.Visible = false;
               lblOutstandingBalance.Visible = false;
               lblOutstandingBalanceValue.Visible = false;
               lblCustomerChartTitle.Visible = false;

               mainPanel.Controls.Add(dataGridView);

               Label lblTitle = new Label
               {
                    Text = "QUẢN LÝ KHÁCH HÀNG",
                    Location = new Point(10, 10),
                    Size = new Size(200, 30),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold)
               };
               mainPanel.Controls.Add(lblTitle);

               int y = 50;
               string[] labels = { "Mã KH", "Họ tên", "Giới tính", "SĐT", "Địa chỉ" };
               customerTextBoxes = new TextBox[labels.Length];
               for (int i = 0; i < labels.Length; i++)
               {
                    Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                    customerTextBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                    if (i == 2) customerTextBoxes[i].Text = "Nam";
                    mainPanel.Controls.Add(lbl);
                    mainPanel.Controls.Add(customerTextBoxes[i]);
                    y += 30;
               }

               Button btnAdd = new Button
               {
                    Text = "Thêm",
                    Location = new Point(120, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnAdd.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(customerTextBoxes[0].Text) || string.IsNullOrWhiteSpace(customerTextBoxes[1].Text))
                         {
                              MessageBox.Show("Vui lòng điền mã và họ tên!");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE maKhachHang = @maKhachHang", conn);
                              checkCmd.Parameters.AddWithValue("@maKhachHang", customerTextBoxes[0].Text);
                              int count = (int)checkCmd.ExecuteScalar();
                              if (count > 0)
                              {
                                   MessageBox.Show("Mã khách hàng đã tồn tại!");
                                   return;
                              }

                              SqlCommand cmd = new SqlCommand(
                                  "INSERT INTO KhachHang (maKhachHang, hoTen, gioiTinh, sdt, diaChi) VALUES (@maKhachHang, @hoTen, @gioiTinh, @sdt, @diaChi)",
                                  conn);
                              cmd.Parameters.AddWithValue("@maKhachHang", customerTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@hoTen", customerTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@gioiTinh", customerTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@sdt", customerTextBoxes[3].Text);
                              cmd.Parameters.AddWithValue("@diaChi", customerTextBoxes[4].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Thêm thành công!");
                              LoadCustomerData();
                              Array.ForEach(customerTextBoxes, tb => tb.Clear());
                              customerTextBoxes[2].Text = "Nam";
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnAdd);

               Button btnUpdate = new Button
               {
                    Text = "Cập nhật",
                    Location = new Point(210, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnUpdate.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(customerTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn khách hàng để cập nhật!");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand(
                                  "UPDATE KhachHang SET hoTen = @hoTen, gioiTinh = @gioiTinh, sdt = @sdt, diaChi = @diaChi WHERE maKhachHang = @maKhachHang",
                                  conn);
                              cmd.Parameters.AddWithValue("@maKhachHang", customerTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@hoTen", customerTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@gioiTinh", customerTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@sdt", customerTextBoxes[3].Text);
                              cmd.Parameters.AddWithValue("@diaChi", customerTextBoxes[4].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Cập nhật thành công!");
                              LoadCustomerData();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnUpdate);

               Button btnDelete = new Button
               {
                    Text = "Xóa",
                    Location = new Point(300, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnDelete.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(customerTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                              return;
                         }
                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE maKhachHang = @maKhachHang", conn);
                              cmd.Parameters.AddWithValue("@maKhachHang", customerTextBoxes[0].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Xóa thành công!");
                              LoadCustomerData();
                              Array.ForEach(customerTextBoxes, tb => tb.Clear());
                              customerTextBoxes[2].Text = "Nam";
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnDelete);

               dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Customers;
               dataGridView.SelectionChanged += DataGridView_SelectionChanged_Customers;

               LoadCustomerData();
          }

          private void DataGridView_SelectionChanged_Customers(object sender, EventArgs e)
          {
               if (dataGridView.SelectedRows.Count > 0)
               {
                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    customerTextBoxes[0].Text = row.Cells["ID"].Value?.ToString() ?? "";
                    customerTextBoxes[1].Text = row.Cells["Tên khách hàng"].Value?.ToString() ?? "";
                    customerTextBoxes[2].Text = row.Cells["Giới tính"].Value?.ToString() ?? "Nam"; // Cần thêm cột GioiTinh vào SQL nếu cần
                    customerTextBoxes[3].Text = row.Cells["SĐT"].Value?.ToString() ?? "";
                    customerTextBoxes[4].Text = row.Cells["Địa chỉ"].Value?.ToString() ?? "";
               }
          }

          private void ShowManageTables()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = false;
               lblRevenue.Visible = false;
               lblTotalRevenue.Visible = false;
               lblTotalCustomers.Visible = false;
               lblLowInventory.Visible = false;
               lblTableStatus.Visible = false;
               lblOutstandingBalance.Visible = false;
               lblOutstandingBalanceValue.Visible = false;
               lblCustomerChartTitle.Visible = false;

               mainPanel.Controls.Add(dataGridView);

               Label lblTitle = new Label
               {
                    Text = "QUẢN LÝ BÀN ĂN",
                    Location = new Point(10, 10),
                    Size = new Size(200, 30),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold)
               };
               mainPanel.Controls.Add(lblTitle);

               int y = 50;
               string[] labels = { "Mã Bàn", "Trạng thái" };
               tableTextBoxes = new TextBox[labels.Length];
               for (int i = 0; i < labels.Length; i++)
               {
                    Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                    tableTextBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                    if (i == 1) tableTextBoxes[i].Text = "Trống";
                    mainPanel.Controls.Add(lbl);
                    mainPanel.Controls.Add(tableTextBoxes[i]);
                    y += 30;
               }

               Button btnUpdateStatus = new Button
               {
                    Text = "Cập nhật",
                    Location = new Point(120, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnUpdateStatus.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(tableTextBoxes[0].Text) || string.IsNullOrWhiteSpace(tableTextBoxes[1].Text))
                         {
                              MessageBox.Show("Vui lòng điền mã bàn và trạng thái!");
                              return;
                         }
                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand(
                                  "UPDATE BanAn SET trangThai = @trangThai WHERE maBanAn = @maBanAn",
                                  conn);
                              cmd.Parameters.AddWithValue("@maBanAn", tableTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@trangThai", tableTextBoxes[1].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Cập nhật thành công!");
                              LoadTableData();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnUpdateStatus);

               dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Tables;
               dataGridView.SelectionChanged += DataGridView_SelectionChanged_Tables;

               LoadTableData();
          }

          private void LoadTableData()
          {
               try
               {
                    // Clear existing columns and disable auto-generated columns
                    dataGridView.Columns.Clear();
                    dataGridView.AutoGenerateColumns = false;

                    // Define columns
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "maBanAn",
                         HeaderText = "Mã Bàn",
                         DataPropertyName = "maBanAn",
                         Width = 100,
                         ReadOnly = true
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "trangThai",
                         HeaderText = "Trạng thái",
                         DataPropertyName = "trangThai",
                         Width = 120,
                         ReadOnly = true
                    });

                    // Load data from database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT maBanAn, trangThai FROM BanAn", conn))
                         {
                              DataTable dt = new DataTable();
                              adapter.Fill(dt);

                              // Transform status values for display
                              foreach (DataRow row in dt.Rows)
                              {
                                   if (row["trangThai"] != DBNull.Value)
                                   {
                                        string status = row["trangThai"].ToString();
                                        if (status == "0")
                                             row["trangThai"] = "Trống";
                                        else if (status == "1")
                                             row["trangThai"] = "Đã đặt";
                                        else
                                             row["trangThai"] = status; // Fallback for unexpected values
                                   }
                                   else
                                   {
                                        row["trangThai"] = "Trống";
                                   }
                              }

                              dataGridView.DataSource = dt;
                         }
                    }

                    // Enhance DataGridView appearance
                    dataGridView.AllowUserToOrderColumns = true;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
               }
               catch (SqlException ex)
               {
                    MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi tải dữ liệu bàn ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void DataGridView_SelectionChanged_Tables(object sender, EventArgs e)
          {
               if (dataGridView.SelectedRows.Count == 0 || tableTextBoxes?.Length < 2 || tableTextBoxes[0] == null || tableTextBoxes[1] == null)
                    return;

               try
               {
                    // Temporarily unsubscribe to prevent recursive updates
                    dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Tables;

                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    tableTextBoxes[0].Text = row.Cells["maBanAn"].Value?.ToString() ?? "";
                    tableTextBoxes[1].Text = row.Cells["trangThai"].Value?.ToString() ?? "Trống";
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi khi chọn bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               finally
               {
                    // Re-subscribe to the event
                    dataGridView.SelectionChanged += DataGridView_SelectionChanged_Tables;
               }
          }

          private void ShowManageRevenue()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = false;
               lblRevenue.Visible = false;
               lblTotalRevenue.Visible = false;
               lblTotalCustomers.Visible = false;
               lblLowInventory.Visible = false;
               lblTableStatus.Visible = false;
               lblOutstandingBalance.Visible = false;
               lblOutstandingBalanceValue.Visible = false;
               lblCustomerChartTitle.Visible = false;

               mainPanel.Controls.Add(dataGridView);

               Label lblTitle = new Label
               {
                    Text = "QUẢN LÝ DOANH THU",
                    Location = new Point(10, 10),
                    Size = new Size(200, 30),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold)
               };
               mainPanel.Controls.Add(lblTitle);

               LoadRevenueData();
          }

          private void LoadRevenueData()
          {
               try
               {
                    // Clear existing columns and disable auto-generated columns
                    dataGridView.Columns.Clear();
                    dataGridView.AutoGenerateColumns = false;

                    // Define columns with formatting
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "maHoaDon",
                         HeaderText = "Mã Hóa đơn",
                         DataPropertyName = "maHoaDon",
                         Width = 100,
                         ReadOnly = true
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "ngayLapHoaDon",
                         HeaderText = "Ngày lập",
                         DataPropertyName = "ngayLapHoaDon",
                         Width = 120,
                         DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } // Format date
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "tongTien",
                         HeaderText = "Tổng tiền",
                         DataPropertyName = "tongTien",
                         Width = 120,
                         DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } // Format as number
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "maKhachHang",
                         HeaderText = "Mã Khách hàng",
                         DataPropertyName = "maKhachHang",
                         Width = 100,
                         ReadOnly = true
                    });

                    // Load data from database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         string query = @"
                SELECT DISTINCT HD.maHoaDon, HD.ngayLapHoaDon, HD.tongTien, KH.maKhachHang 
                FROM HoaDon HD
                INNER JOIN PhieuYeuCau P ON P.maPhieuYeuCau = HD.maPhieuYeuCau
                INNER JOIN KhachHang KH ON KH.maKhachHang = P.maKhachHang";
                         using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                         {
                              DataTable dt = new DataTable();
                              adapter.Fill(dt);
                              dataGridView.DataSource = dt;
                         }
                    }

                    // Enhance DataGridView appearance
                    dataGridView.AllowUserToOrderColumns = true;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
               }
               catch (SqlException ex)
               {
                    MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi tải dữ liệu doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void ShowManageMenu()
          {
               mainPanel.Controls.Clear();
               dataGridView.Visible = true;
               chart1.Visible = false;
               lblRevenue.Visible = false;
               lblTotalRevenue.Visible = false;
               lblTotalCustomers.Visible = false;
               lblLowInventory.Visible = false;
               lblTableStatus.Visible = false;
               lblOutstandingBalance.Visible = false;
               lblOutstandingBalanceValue.Visible = false;
               lblCustomerChartTitle.Visible = false;

               mainPanel.Controls.Add(dataGridView);

               Label lblTitle = new Label
               {
                    Text = "QUẢN LÝ THỰC ĐƠN",
                    Location = new Point(10, 10),
                    Size = new Size(200, 30),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold)
               };
               mainPanel.Controls.Add(lblTitle);

               int y = 50;
               string[] labels = { "Mã Món", "Tên Món", "Đơn vị tính", "Giá tiền" };
               menuTextBoxes = new TextBox[labels.Length];
               for (int i = 0; i < labels.Length; i++)
               {
                    Label lbl = new Label { Text = labels[i], Location = new Point(10, y), Size = new Size(100, 20) };
                    menuTextBoxes[i] = new TextBox { Location = new Point(120, y), Size = new Size(200, 20) };
                    mainPanel.Controls.Add(lbl);
                    mainPanel.Controls.Add(menuTextBoxes[i]);
                    y += 30;
               }

               Button btnAdd = new Button
               {
                    Text = "Thêm",
                    Location = new Point(120, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnAdd.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(menuTextBoxes[0].Text) || string.IsNullOrWhiteSpace(menuTextBoxes[1].Text) || string.IsNullOrWhiteSpace(menuTextBoxes[3].Text))
                         {
                              MessageBox.Show("Vui lòng điền mã, tên và giá!");
                              return;
                         }

                         if (!decimal.TryParse(menuTextBoxes[3].Text, out decimal giaTien) || giaTien < 0)
                         {
                              MessageBox.Show("Giá tiền không hợp lệ! Vui lòng nhập số dương.");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM MonAn WHERE maMonAn = @maMonAn", conn);
                              checkCmd.Parameters.AddWithValue("@maMonAn", menuTextBoxes[0].Text);
                              int count = (int)checkCmd.ExecuteScalar();
                              if (count > 0)
                              {
                                   MessageBox.Show("Mã món đã tồn tại!");
                                   return;
                              }

                              SqlCommand cmd = new SqlCommand(
                                  "INSERT INTO MonAn (maMonAn, tenMonAn, donViTinh, giaTien) VALUES (@maMonAn, @tenMonAn, @donViTinh, @giaTien)",
                                  conn);
                              cmd.Parameters.AddWithValue("@maMonAn", menuTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@tenMonAn", menuTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@donViTinh", menuTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@giaTien", giaTien);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Thêm thành công!");
                              LoadMenuData();
                              Array.ForEach(menuTextBoxes, tb => tb.Clear());
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnAdd);

               Button btnUpdate = new Button
               {
                    Text = "Cập nhật",
                    Location = new Point(210, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnUpdate.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(menuTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn món để cập nhật!");
                              return;
                         }

                         if (!decimal.TryParse(menuTextBoxes[3].Text, out decimal giaTien) || giaTien < 0)
                         {
                              MessageBox.Show("Giá tiền không hợp lệ! Vui lòng nhập số dương.");
                              return;
                         }

                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand(
                                  "UPDATE MonAn SET tenMonAn = @tenMonAn, donViTinh = @donViTinh, giaTien = @giaTien WHERE maMonAn = @maMonAn",
                                  conn);
                              cmd.Parameters.AddWithValue("@maMonAn", menuTextBoxes[0].Text);
                              cmd.Parameters.AddWithValue("@tenMonAn", menuTextBoxes[1].Text);
                              cmd.Parameters.AddWithValue("@donViTinh", menuTextBoxes[2].Text);
                              cmd.Parameters.AddWithValue("@giaTien", giaTien);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Cập nhật thành công!");
                              LoadMenuData();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnUpdate);

               Button btnDelete = new Button
               {
                    Text = "Xóa",
                    Location = new Point(300, y),
                    Size = new Size(80, 30),
                    BackColor = Color.FromArgb(0, 71, 160),
                    ForeColor = Color.White
               };
               btnDelete.Click += (s, e) =>
               {
                    try
                    {
                         if (string.IsNullOrWhiteSpace(menuTextBoxes[0].Text))
                         {
                              MessageBox.Show("Vui lòng chọn món để xóa!");
                              return;
                         }
                         using (SqlConnection conn = new SqlConnection(connectionString))
                         {
                              conn.Open();
                              SqlCommand cmd = new SqlCommand("DELETE FROM MonAn WHERE maMonAn = @maMonAn", conn);
                              cmd.Parameters.AddWithValue("@maMonAn", menuTextBoxes[0].Text);
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Xóa thành công!");
                              LoadMenuData();
                              Array.ForEach(menuTextBoxes, tb => tb.Clear());
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi: " + ex.Message);
                    }
               };
               mainPanel.Controls.Add(btnDelete);

               dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Menu;
               dataGridView.SelectionChanged += DataGridView_SelectionChanged_Menu;

               LoadMenuData();
          }

          private void LoadMenuData()
          {
               try
               {
                    // Clear existing columns and disable auto-generated columns
                    dataGridView.Columns.Clear();
                    dataGridView.AutoGenerateColumns = false;

                    // Define columns with formatting
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "maMonAn",
                         HeaderText = "Mã Món",
                         DataPropertyName = "maMonAn",
                         Width = 100,
                         ReadOnly = true
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "tenMonAn",
                         HeaderText = "Tên Món",
                         DataPropertyName = "tenMonAn",
                         Width = 200,
                         ReadOnly = true
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "donViTinh",
                         HeaderText = "Đơn vị tính",
                         DataPropertyName = "donViTinh",
                         Width = 100,
                         ReadOnly = true
                    });
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                         Name = "giaTien",
                         HeaderText = "Giá tiền",
                         DataPropertyName = "giaTien",
                         Width = 120,
                         DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } // Format as number
                    });

                    // Load data from database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                         conn.Open();
                         string query = "SELECT maMonAn, tenMonAn, donViTinh, giaTien FROM MonAn";
                         using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                         {
                              DataTable dt = new DataTable();
                              adapter.Fill(dt);

                              // Handle null values in DataTable
                              foreach (DataRow row in dt.Rows)
                              {
                                   if (row["donViTinh"] == DBNull.Value)
                                        row["donViTinh"] = "N/A";
                                   if (row["giaTien"] == DBNull.Value)
                                        row["giaTien"] = 0;
                              }

                              dataGridView.DataSource = dt;
                         }
                    }

                    // Enhance DataGridView appearance
                    dataGridView.AllowUserToOrderColumns = true;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
               }
               catch (SqlException ex)
               {
                    MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi tải dữ liệu thực đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void DataGridView_SelectionChanged_Menu(object sender, EventArgs e)
          {
               if (dataGridView.SelectedRows.Count == 0 || menuTextBoxes?.Length < 4 || menuTextBoxes.Any(tb => tb == null))
                    return;

               try
               {
                    // Temporarily unsubscribe to prevent recursive updates
                    dataGridView.SelectionChanged -= DataGridView_SelectionChanged_Menu;

                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    menuTextBoxes[0].Text = row.Cells["maMonAn"].Value?.ToString() ?? "";
                    menuTextBoxes[1].Text = row.Cells["tenMonAn"].Value?.ToString() ?? "";
                    menuTextBoxes[2].Text = row.Cells["donViTinh"].Value?.ToString() ?? "N/A";
                    menuTextBoxes[3].Text = row.Cells["giaTien"].Value != null ? Convert.ToDecimal(row.Cells["giaTien"].Value).ToString("N0") : "";
               }
               catch (Exception ex)
               {
                    MessageBox.Show($"Lỗi khi chọn món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               finally
               {
                    // Re-subscribe to the event
                    dataGridView.SelectionChanged += DataGridView_SelectionChanged_Menu;
               }
          }
     }
}