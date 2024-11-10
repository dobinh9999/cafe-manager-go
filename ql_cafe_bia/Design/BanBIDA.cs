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
	public partial class BanBIDA : Form
	{
		public BanBIDA()
		{
			InitializeComponent();
		}

		private void BanBIDA_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_BanBIDA' table. You can move, or remove it, as needed.
            this.tb_BanBIDATableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_BanBIDA);

        }
		private void loaddata()
		{
			string sql = "SELECT * FROM Tb_BanBIDA";

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
			string insertQuery = "INSERT INTO Tb_BanBIDA (TenBan, MaLoai, SLbi, SLgay, TrangThai) " +
						"VALUES (@TenBan, @MaLoai, @SLbi, @SLgay, @TrangThai)";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						command.Parameters.AddWithValue("@TenBan", txtban.Text);
						command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text);
						command.Parameters.AddWithValue("@SLbi", txtslbi.Text);
						command.Parameters.AddWithValue("@SLgay", txtslgay.Text);
						command.Parameters.AddWithValue("@TrangThai", txttrangthai.Text);

						command.ExecuteNonQuery();
						MessageBox.Show("Đã thêm bàn BIDA thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			string updateQuery = "UPDATE Tb_BanBIDA SET TenBan = @TenBan, MaLoai = @MaLoai, SLbi = @SLbi, SLgay = @SLgay, TrangThai = @TrangThai " +
						 "WHERE MaBan = @MaBan";
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(updateQuery, connection))
					{
						command.Parameters.AddWithValue("@MaBan", txtmaban.Text);
						command.Parameters.AddWithValue("@TenBan", txtban.Text);
						command.Parameters.AddWithValue("@MaLoai", txtmaloai.Text);
						command.Parameters.AddWithValue("@SLbi", txtslbi.Text);
						command.Parameters.AddWithValue("@SLgay", txtslgay.Text);
						command.Parameters.AddWithValue("@TrangThai", txttrangthai.Text);

						command.ExecuteNonQuery();
						MessageBox.Show("Đã cập nhật bàn BIDA thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa bàn BIDA này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string deleteQuery = "DELETE FROM Tb_BanBIDA WHERE MaBan = @MaBan";
				try
				{
					using (SqlConnection connection = ketnoisql.TaoKetNoi())
					{
						connection.Open();
						using (SqlCommand command = new SqlCommand(deleteQuery, connection))
						{
							command.Parameters.AddWithValue("@MaBan", txtmaban.Text);

							command.ExecuteNonQuery();
							MessageBox.Show("Đã xóa bàn BIDA thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void dgvbanbida_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			if (i < 0)
			{
				MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
				return;
			}

			//57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
			txtmaban.Text = dgvbanbida.CurrentRow.Cells[0].Value.ToString();
			txtban.Text = dgvbanbida.CurrentRow.Cells[1].Value.ToString();
			txtmaloai.Text = dgvbanbida.CurrentRow.Cells[2].Value.ToString();
			txtslbi.Text = dgvbanbida.CurrentRow.Cells[3].Value.ToString();
			txtslgay.Text = dgvbanbida.CurrentRow.Cells[4].Value.ToString();
			txttrangthai.Text = dgvbanbida.CurrentRow.Cells[5].Value.ToString();
		}
	}
}
