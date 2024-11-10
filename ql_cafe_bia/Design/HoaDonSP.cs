using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_cafe_bia
{
	public partial class HoaDonSP : Form
	{
		public HoaDonSP()
		{
			InitializeComponent();
		}

		private void HoaDonSP_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet3.Tb_HoaDon' table. You can move, or remove it, as needed.
            this.tb_HoaDonTableAdapter.Fill(this.cAFE_AND_BIDADataSet3.Tb_HoaDon);
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet2.Tb_HoaDon' table. You can move, or remove it, as needed.
            //this.tb_HoaDonTableAdapter.Fill(this.cAFE_AND_BIDADataSet2.Tb_HoaDon);

        }

		private void loaddata()
		{
			string sql = " select * from Tb_HoaDon";

			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
					DataTable dataTable = new DataTable();

					dataAdapter.Fill(dataTable);
					
					dgvHoaDon.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			string insertQuery = @"INSERT INTO Tb_HoaDon (TenKH, NgayGio, DiemTichLuy, TenVC, SoLuong, TongTien) 
                           VALUES (@TenKH, @NgayGio, @DiemTichLuy, @TenVC, @SoLuong, @TongTien)";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						command.Parameters.AddWithValue("@TenKH", txttenkh.Text);
						command.Parameters.AddWithValue("@NgayGio", txtngaytao.Value);
						command.Parameters.AddWithValue("@DiemTichLuy", txtdtl.Text);
						command.Parameters.AddWithValue("@TenVC", txttenvoicher.Text);
						command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
						command.Parameters.AddWithValue("@TongTien", txttongtien.Text);

						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							loaddata();
							MessageBox.Show("Đã lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Không có hóa đơn nào được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			if (i < 0)
			{
				MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
				return;
			}

			//57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
			txtmahd.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
			txttenkh.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
			txtngaytao.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
			txtdtl.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
			txttenvoicher.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
			txtSoLuong.Text = dgvHoaDon.CurrentRow.Cells[5].Value.ToString();
			txttongtien.Text = dgvHoaDon.CurrentRow.Cells[6].Value.ToString();

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string updateQuery = @"UPDATE Tb_HoaDon 
                           SET TenKH = @TenKH, NgayGio = @NgayGio, DiemTichLuy = @DiemTichLuy, TenVC = @TenVC, SoLuong = @SoLuong, TongTien = @TongTien 
                           WHERE MaHD = @MaHD";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(updateQuery, connection))
					{
						command.Parameters.AddWithValue("@MaHD", txtmahd.Text);
						command.Parameters.AddWithValue("@TenKH", txttenkh.Text);
						command.Parameters.AddWithValue("@NgayGio", txtngaytao.Value);
						command.Parameters.AddWithValue("@DiemTichLuy", txtdtl.Text);
						command.Parameters.AddWithValue("@TenVC", txttenvoicher.Text);
						command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
						command.Parameters.AddWithValue("@TongTien", txttongtien.Text);

						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							loaddata();
							MessageBox.Show("Đã cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Không có hóa đơn nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string deleteQuery = @"DELETE FROM Tb_HoaDon WHERE MaHD = @MaHD";
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = ketnoisql.TaoKetNoi())
					{
						connection.Open();
						using (SqlCommand command = new SqlCommand(deleteQuery, connection))
						{
							command.Parameters.AddWithValue("@MaHD", txtmahd.Text);

							int rowsAffected = command.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								loaddata();
								MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("Không có hóa đơn nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnload_Click(object sender, EventArgs e)
		{
			loaddata();
		}

		private void btnmohoadon_Click(object sender, EventArgs e)
		{
			// Lấy mã hóa đơn từ TextBox
			string maHoaDon = txtmahd.Text;

			// Tạo đường dẫn tới file PDF hóa đơn
			string filePath = Path.Combine(@"C:\Invoices\hoadon_"+ maHoaDon + ".pdf");

			// Kiểm tra xem file có tồn tại không
			if (File.Exists(filePath))
			{
				try
				{
					// Mở file PDF bằng ứng dụng mặc định
					System.Diagnostics.Process.Start(filePath);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi mở file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
