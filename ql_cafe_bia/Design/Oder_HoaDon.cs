using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_cafe_bia
{
    public partial class Oder_HoaDon : Form
    {
        public Oder_HoaDon()
        {
            InitializeComponent();
        }

        private void Oder_HoaDon_Load(object sender, EventArgs e)
        {
          


        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_SanPham";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dataGridView1.DataSource = dataTable;
        }

		private bool CheckColumnsExistence(DataGridView dataGridView, string[] columnNames)
        {
            foreach (string columnName in columnNames)
            {
                if (!dataGridView.Columns.Contains(columnName))
                {
                    return false;
                }
            }
            return true;
        }


		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				int i = e.RowIndex;
				if (i < 0)
				{
					MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
					return;
				}

				// Lấy dữ liệu từ các ô của dòng được chọn trong dataGridView1
				string tensp = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
				string giasp = dataGridView1.CurrentRow.Cells[3].Value?.ToString();

				// Kiểm tra xem sản phẩm đã tồn tại trong dataGridView3 hay chưa
				bool productExists = false;

				foreach (DataGridViewRow row in dataGridView3.Rows)
				{
					if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == tensp)
					{
						// Sản phẩm đã tồn tại, tăng số lượng
						int soLuong = int.Parse(row.Cells[2].Value.ToString());
						soLuong++;
						row.Cells[2].Value = soLuong.ToString();
						productExists = true;
						break;
					}
				}

				if (!productExists)
				{
					// Sản phẩm chưa tồn tại, thêm sản phẩm mới với số lượng là 1
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView3);
					newRow.Cells[0].Value = tensp;
					newRow.Cells[1].Value = giasp;
					newRow.Cells[2].Value = 1; // Số lượng ban đầu là 1

					dataGridView3.Rows.Add(newRow);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btnhuy_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
			btnthanhtoan.Text = "Thanh Toán";

		}

		public  string TenSP { get; set; }
		public  string GiaSP { get; set; }
		public  string SoLuong { get; set; }
		public  float TongTien { get; set; }
		
		private List<Oder_HoaDon> GetDataGridView3Data()
		{
			List<Oder_HoaDon> products = new List<Oder_HoaDon>();

			foreach (DataGridViewRow row in dataGridView3.Rows)
			{
				if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
				{
					float tongTien;
					if (float.TryParse(row.Cells[3].Value.ToString(), out tongTien))
					{
						Oder_HoaDon product = new Oder_HoaDon
						{
							TenSP = row.Cells[0].Value.ToString(),
							GiaSP = row.Cells[1].Value.ToString(),
							SoLuong = row.Cells[2].Value.ToString(),
							TongTien = tongTien
						};

						products.Add(product);
					}
					else
					{
						MessageBox.Show("Giá trị tổng tiền không hợp lệ: " + row.Cells[3].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			return products;
		}
		private void dataGridView3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Hiển thị menu ngữ cảnh
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                
                DataGridView.HitTestInfo hitTestInfo = dataGridView3.HitTest(e.X, e.Y);
                int rowIndex = hitTestInfo.RowIndex;

                // Kiểm tra dòng được chọn có hợp lệ không
                if (rowIndex >= 0)
                {

                    contextMenu.Items.Add("Xóa dòng").Click += (s, args) =>
                    {
                        // Xóa dòng được chọn
                        dataGridView3.Rows.RemoveAt(rowIndex);
                    };
                   
                    contextMenu.Items.Add("Tính Tổng Tiền all").Click += (s, args) =>
                    {
                        foreach (DataGridViewRow row in dataGridView3.Rows)
                        {
                            // Lấy giá trị từ cột "Sanpham" và "giaSP" của mỗi dòng
                            string giaSPtr = row.Cells[1].Value?.ToString();
                            string SoLuongtr = row.Cells[2].Value?.ToString();

                            float SoLuong, giaSP;
                            if (float.TryParse(giaSPtr, out giaSP) && float.TryParse(SoLuongtr, out SoLuong))
                            {
								// Tính tổng tiền của mỗi dòng
								TongTien = SoLuong * giaSP ;

                                // Đưa tổng tiền của mỗi dòng vào cột "Tongtien" của dòng tương ứng
                                row.Cells[3].Value = TongTien.ToString() + ",000";
                            }


							float tongTienTatCa = 0;
							foreach (DataGridViewRow roww in dataGridView3.Rows)
							{

								string tongtien = roww.Cells[3].Value?.ToString();

								
								float tien;
								if (float.TryParse(tongtien, out tien))
								{
									// Tính tổng tiền của mỗi dòng và cộng vào tổng tiền tất cả
									tongTienTatCa += tien;
								}

							}
							btnthanhtoan.Text = "Thanh Toán " + tongTienTatCa.ToString() + ",000 &đ";
						};
                    };
                    contextMenu.Show(dataGridView3, e.Location); // Hiển thị menu ngữ cảnh ở vị trí chuột được nhấn
                }

            }
		}
		
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				string key = txttimkiem.Text.Trim();
				string sql;

				if (string.IsNullOrEmpty(key))
				{
					MessageBox.Show("Hãy nhập thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					sql = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE N'%" + key + "%'";

					// Lấy kết quả truy vấn từ cơ sở dữ liệu
					DataTable dataTable = ketnoisql.GetDataTable(sql);

					// Kiểm tra kết quả truy vấn có trả về dữ liệu hay không
					if (dataTable.Rows.Count > 0)
					{
						dataGridView1.DataSource = dataTable;
						MessageBox.Show("Tìm kiếm thành công: " + key, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Không tìm thấy '" + key + "' trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

		}

		private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.SelectAll();


        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
          
			List<Oder_HoaDon> products = GetDataGridView3Data();
			HoaDon hoaDonForm = new HoaDon(products,arrlist);
			hoaDonForm.Show();
		}
		public string SDT { get; set; }
		public string TenKH { get; set; }
		public int DiemTichLuy { get; set; }

		ArrayList arrlist = new ArrayList();

		private void btncheck_Click(object sender, EventArgs e)
		{
			// Tạo đối tượng ThongTin và gán giá trị từ TextBox
			Oder_HoaDon thongTin = new Oder_HoaDon
			{
				SDT = txtSDT.Text,
				TenKH = txttenKH.Text
			};

			// Kiểm tra SDT trong bảng Tb_KhachHang
			
			string query = "SELECT SDT, TenKH, DiemTichLuy FROM Tb_KhachHang WHERE SDT = @SDT";

			using (SqlConnection connection = ketnoisql.TaoKetNoi())
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@SDT", thongTin.SDT);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					// Nếu tìm thấy SDT trong bảng Tb_KhachHang
					thongTin.TenKH = reader["TenKH"].ToString();
					thongTin.DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"]);
					arrlist.Add(thongTin);
					txttenKH.Text = thongTin.TenKH;
					MessageBox.Show("Khách hàng quen , Thông tin đã được lưu!", "Thông báo");
					
				}
				else
				{
					// Nếu không tìm thấy SDT trong bảng Tb_KhachHang
					arrlist.Add(thongTin);
					MessageBox.Show("Khách Hàng Mới , Thông tin đã được lưu! ", "Thông báo");
				}
			}
		}

		private void txtSDT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				btncheck_Click(sender, e);
			}
		}

		private void txttenKH_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) { 
				btncheck_Click(sender,e);
			}
		}

		private void btncafe_Click(object sender, EventArgs e)
		{

			try
			{
				// Định nghĩa câu truy vấn SQL để lấy các sản phẩm có tên hoặc thuộc loại cafe
				string sql = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE N'%cafe%' OR TenSP LIKE N'%cà phê%'";
				// Thực thi truy vấn và lấy kết quả vào DataTable
				DataTable dataTable = ketnoisql.GetDataTable(sql);

				// Kiểm tra xem có sản phẩm cafe nào không
				if (dataTable.Rows.Count > 0)
				{
					// Đưa dữ liệu vào dataGridView1 (hoặc một DataGridView khác)
					dataGridView1.DataSource = dataTable;
				}
				else
				{
					MessageBox.Show("Không có loại cafe nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy danh sách cafe: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btntra_Click(object sender, EventArgs e)
		{
			try
			{
				// Định nghĩa câu truy vấn SQL để lấy các sản phẩm có tên hoặc thuộc loại cafe
				string sql = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE N'%Trà%'";
				// Thực thi truy vấn và lấy kết quả vào DataTable
				DataTable dataTable = ketnoisql.GetDataTable(sql);

				// Kiểm tra xem có sản phẩm cafe nào không
				if (dataTable.Rows.Count > 0)
				{
					// Đưa dữ liệu vào dataGridView1 (hoặc một DataGridView khác)
					dataGridView1.DataSource = dataTable;
				}
				else
				{
					MessageBox.Show("Không có loại trà nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy danh sách trà: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btntrasua_Click(object sender, EventArgs e)
		{
			try
			{
				// Định nghĩa câu truy vấn SQL để lấy các sản phẩm có tên hoặc thuộc loại cafe
				string sql = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE N'%trà sữa%'";
				// Thực thi truy vấn và lấy kết quả vào DataTable
				DataTable dataTable = ketnoisql.GetDataTable(sql);

				// Kiểm tra xem có sản phẩm cafe nào không
				if (dataTable.Rows.Count > 0)
				{
					// Đưa dữ liệu vào dataGridView1 (hoặc một DataGridView khác)
					dataGridView1.DataSource = dataTable;
				}
				else
				{
					MessageBox.Show("Không có loại trà sữa nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy danh sách trà sữa: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnbanh_Click(object sender, EventArgs e)
		{
			try
			{
				// Định nghĩa câu truy vấn SQL để lấy các sản phẩm có tên hoặc thuộc loại cafe
				string sql = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE N'%bánh%'";
				// Thực thi truy vấn và lấy kết quả vào DataTable
				DataTable dataTable = ketnoisql.GetDataTable(sql);

				// Kiểm tra xem có sản phẩm cafe nào không
				if (dataTable.Rows.Count > 0)
				{
					// Đưa dữ liệu vào dataGridView1 (hoặc một DataGridView khác)
					dataGridView1.DataSource = dataTable;
				}
				else
				{
					MessageBox.Show("Không có loại bánh nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy danh sách bánh: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btndoanvat_Click(object sender, EventArgs e)
		{
			try
			{
				// Định nghĩa câu truy vấn SQL để lấy các sản phẩm có tên hoặc thuộc loại cafe
				string sql = "SELECT * FROM Tb_SanPham WHERE MaLoaiSP = '1002'";
				// Thực thi truy vấn và lấy kết quả vào DataTable
				DataTable dataTable = ketnoisql.GetDataTable(sql);

				// Kiểm tra xem có sản phẩm cafe nào không
				if (dataTable.Rows.Count > 0)
				{
					// Đưa dữ liệu vào dataGridView1 (hoặc một DataGridView khác)
					dataGridView1.DataSource = dataTable;
				}
				else
				{
					MessageBox.Show("Không có loại đồ ăn vặt nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy danh sách đồ ăn vặt: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txttimkiem_TextChanged(object sender, EventArgs e)
		{

		}
		private void tinhtongne()
		{
			float tongTienTatCa = 0;

			foreach (DataGridViewRow row in dataGridView3.Rows)
			{
				// Lấy giá trị từ cột "Sanpham" và "giaSP" của mỗi dòng
				string giaSPtr = row.Cells[1].Value?.ToString();
				string SoLuongtr = row.Cells[2].Value?.ToString();

				float SoLuong, giaSP;

				if (float.TryParse(giaSPtr, out giaSP) && float.TryParse(SoLuongtr, out SoLuong))
				{
					// Tính tổng tiền của mỗi dòng
					float tongTien = SoLuong * giaSP;

					// Đưa tổng tiền của mỗi dòng vào cột "Tongtien" của dòng tương ứng
					row.Cells[3].Value = tongTien.ToString() + ",000";

					// Cộng tổng tiền của mỗi dòng vào tổng tiền tất cả
					tongTienTatCa += tongTien;
				}
			}

			// Hiển thị tổng tiền tất cả trên nút thanh toán
			btnthanhtoan.Text = "Thanh Toán " + tongTienTatCa.ToString() + ",000 &đ";
		}
		private void btntinhtien_Click(object sender, EventArgs e)
		{
			tinhtongne();
		}
	}
}
