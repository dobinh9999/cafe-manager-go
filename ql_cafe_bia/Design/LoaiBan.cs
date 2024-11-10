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

namespace ql_cafe_bia
{
	public partial class LoaiBan : Form
	{
		public LoaiBan()
		{
			InitializeComponent();
		}

		private void LoaiBan_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_LoaiBan' table. You can move, or remove it, as needed.
            this.tb_LoaiBanTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_LoaiBan);

        }
		private void loaddata()
		{
			string sql = "SELECT * FROM Tb_LoaiBan";

			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);
					dgvbanbida.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			string insertQuery = "INSERT INTO Tb_LoaiBan (TenLoai, SoLuong) " +
						"VALUES (@TenLoai, @SoLuong)";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						command.Parameters.AddWithValue("@TenLoai", txttenloai.Text);
						command.Parameters.AddWithValue("@SoLuong", txtsoluong.Text);

						command.ExecuteNonQuery();
						MessageBox.Show("Đã thêm loại bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						loaddata(); // Tải lại dữ liệu sau khi thêm
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
			string updateQuery = "UPDATE Tb_LoaiBan SET TenLoai = @TenLoai, SoLuong = @SoLuong " +
						"WHERE MaLoai = @MaLoai";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(updateQuery, connection))
					{
						command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text);
						command.Parameters.AddWithValue("@TenLoai", txttenloai.Text);
						command.Parameters.AddWithValue("@SoLuong", txtsoluong.Text);

						command.ExecuteNonQuery();
						MessageBox.Show("Đã cập nhật loại bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						loaddata(); // Tải lại dữ liệu sau khi sửa
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
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại bàn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string deleteQuery = "DELETE FROM Tb_LoaiBan WHERE MaLoai = @MaLoai";
				try
				{
					using (SqlConnection connection = ketnoisql.TaoKetNoi())
					{
						connection.Open();
						using (SqlCommand command = new SqlCommand(deleteQuery, connection))
						{
							command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text);

							command.ExecuteNonQuery();
							MessageBox.Show("Đã xóa loại bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							loaddata(); // Tải lại dữ liệu sau khi xóa
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

		private void dgvbanbida_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			if (i < 0)
			{
				MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
				return;
			}

			txtmaloai.Text = dgvbanbida.Rows[i].Cells[0].Value?.ToString();
			txttenloai.Text = dgvbanbida.Rows[i].Cells[1].Value?.ToString();
			txtsoluong.Text = dgvbanbida.Rows[i].Cells[2].Value?.ToString();
		}
	}
}
