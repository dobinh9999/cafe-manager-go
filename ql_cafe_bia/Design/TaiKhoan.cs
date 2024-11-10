using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ql_cafe_bia
{
	public partial class TaiKhoan : Form
	{
		public TaiKhoan()
		{
			InitializeComponent();
		}

		private void TaiKhoan_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_TaiKhoan' table. You can move, or remove it, as needed.
            this.tb_TaiKhoanTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_TaiKhoan);

        }
		private void loaddata()
		{
			string sql = "SELECT * FROM Tb_TaiKhoan";

			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
					DataTable dataTable = new DataTable();

					// Đổ dữ liệu vào DataTable
					dataAdapter.Fill(dataTable);

					// Gán DataTable làm nguồn dữ liệu cho DataGridView
					dgvtaikhoan.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			if (i < 0)
			{
				MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
				return;
			}

			//57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
			txtuser.Text = dgvtaikhoan.CurrentRow.Cells[0].Value.ToString();
			txttk.Text = dgvtaikhoan.CurrentRow.Cells[1].Value.ToString();
			txtmk.Text = dgvtaikhoan.CurrentRow.Cells[2].Value.ToString();
			txtloaiID.Text = dgvtaikhoan.CurrentRow.Cells[3].Value.ToString();
			txttentk.Text = dgvtaikhoan.CurrentRow.Cells[4].Value.ToString();
			
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			

			string insertQuery = "INSERT INTO Tb_TaiKhoan ( TaiKhoan, MatKhau, LoaiID, TenTK) " +
						 "VALUES ( @TaiKhoan, @MatKhau, @LoaiID, @TenTK)";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						
						command.Parameters.AddWithValue("@TaiKhoan", txttk.Text);
						command.Parameters.AddWithValue("@MatKhau", txtmk.Text);
						command.Parameters.AddWithValue("@LoaiID", txtloaiID.Text);
						command.Parameters.AddWithValue("@TenTK", txttentk.Text);

						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							loaddata();
							MessageBox.Show("Đã thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Không có người dùng nào được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string updateQuery = "UPDATE Tb_TaiKhoan SET TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, LoaiID = @LoaiID, TenTK = @TenTK " +
						 "WHERE UsersID = @UsersID";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(updateQuery, connection))
					{
						command.Parameters.AddWithValue("@UsersID", txtuser.Text);
						command.Parameters.AddWithValue("@TaiKhoan", txttk.Text);
						command.Parameters.AddWithValue("@MatKhau", txtmk.Text);
						command.Parameters.AddWithValue("@LoaiID", txtloaiID.Text);
						command.Parameters.AddWithValue("@TenTK", txttentk.Text);

						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							loaddata();
							MessageBox.Show("Đã cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Không có người dùng nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			string deleteQuery = "DELETE FROM Tb_TaiKhoan WHERE UsersID = @UsersID";
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					using (SqlConnection connection = ketnoisql.TaoKetNoi())
					{
						connection.Open();
						using (SqlCommand command = new SqlCommand(deleteQuery, connection))
						{
							command.Parameters.AddWithValue("@UsersID", txtuser.Text);

							int rowsAffected = command.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								loaddata();
								MessageBox.Show("Đã xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("Không có người dùng nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			txtuser.Clear();
			txttk.Clear();
			txtmk.Clear();
			txttentk.Clear();
		}
	}
}
