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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ql_cafe_bia
{
    public partial class Voicher : Form
    {
        private int MavoiCher;

		public Voicher()
        {
            InitializeComponent();
        }

        private void Voicher_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_Voicher' table. You can move, or remove it, as needed.
			//this.tb_VoicherTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_Voicher);
			load();
            btnluu.Visible = false;
            btnhuy.Visible = false;

			string sql = "SELECT MaSP FROM Tb_SanPham";
			ArrayList productList = ketnoisql.GetList(sql);
			foreach (string product in productList)
			{
				txtapdung.Items.Add(product);
			}
		

		}
        private void load()
        {
            string sql = "select * from Tb_Voicher";

            DataTable dt = ketnoisql.GetDataTable(sql);
            dgvvoicher.DataSource = dt;
        }
        private void dgvvoicher_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvvoicher.CurrentRow != null)
            {
                txtmavc.Text = dgvvoicher.CurrentRow.Cells[0].Value.ToString();
                txttenvc.Text = dgvvoicher.CurrentRow.Cells[1].Value.ToString();
                txtngaytao.Text = dgvvoicher.CurrentRow.Cells[2].Value.ToString();
                txtgiatri.Text = dgvvoicher.CurrentRow.Cells[3].Value.ToString();
                txtapdung.Text = dgvvoicher.CurrentRow.Cells[4].Value.ToString();
                

            }
        }
        private bool isadding = false;
        private bool isediting = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            isadding = true;
            isediting = false;
            btnThem.Visible = false;
            btnSua.Visible = true;
            btnluu.Visible = true;
            btnhuy.Visible = true;
            txtmavc.Visible = false;
            label3.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isadding = false;
            isediting = true;
            btnSua.Visible = false;
            btnThem.Visible = true;
            btnluu.Visible = true;
            btnhuy.Visible = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnluu.Visible = false;
            btnhuy.Visible = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
                     
            if (isadding)
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                    if (string.IsNullOrWhiteSpace(txttenvc.Text) ||
                        string.IsNullOrWhiteSpace(txtgiatri.Text) || string.IsNullOrWhiteSpace(txtapdung.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo câu truy vấn SQL để thêm vào kho
                    string insertQuery = "INSERT INTO Tb_Voicher ( TenVC, NgayGio, GiaTriGG, ApDung) VALUES ( @tenvc, @ngaytao, @giatri, @apdung)";

                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            
                            command.Parameters.AddWithValue("@tenvc", txttenvc.Text);
                            command.Parameters.AddWithValue("@ngaytao", txtngaytao.Value);
                            command.Parameters.AddWithValue("@giatri", txtgiatri.Text);
                            command.Parameters.AddWithValue("@apdung", txtapdung.Text);
						    

						// Thực thi câu truy vấn
						    int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Sau khi thêm thành công, làm mới DataGridView để hiển thị dữ liệu mới
                                load(); // Load lại dữ liệu
                                MessageBox.Show("Thêm vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnluu.Visible = false; // Ẩn nút "Lưu" sau khi thêm thành công
                                btnhuy.Visible = false;
                                btnThem.Visible = true;
                                btnSua.Visible = true;
								txtmavc.Visible = true;
								label3.Visible = true;

						}
                            else
                            {
                                MessageBox.Show("Không thể thêm vào kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                
            }
            else if (isediting ==true)
            {
				// Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
				if (string.IsNullOrWhiteSpace(txttenvc.Text) ||
					string.IsNullOrWhiteSpace(txtgiatri.Text) || string.IsNullOrWhiteSpace(txtapdung.Text))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Tạo câu truy vấn SQL để sửa đổi voicher dựa trên MaVC
				string updateQuery = "UPDATE Tb_Voicher SET TenVC = @tenvc, NgayGio = @ngaytao, GiaTriGG = @giatri, ApDung = @apdung WHERE MavoiCher = @mavc";

				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(updateQuery, connection))
					{
						// Thêm tham số cho câu truy vấn SQL
						command.Parameters.AddWithValue("@mavc", txtmavc.Text);
						command.Parameters.AddWithValue("@tenvc", txttenvc.Text);
						command.Parameters.AddWithValue("@ngaytao", txtngaytao.Value);
						command.Parameters.AddWithValue("@giatri", txtgiatri.Text);
						command.Parameters.AddWithValue("@apdung", txtapdung.Text);

						// Thực thi câu truy vấn
						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							// Sau khi sửa thành công, làm mới DataGridView để hiển thị dữ liệu mới
							load(); // Load lại dữ liệu
							MessageBox.Show("Sửa voicher thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							btnluu.Visible = false; // Ẩn nút "Lưu" sau khi sửa thành công
							btnhuy.Visible = false;
							btnThem.Visible = true;
                            btnSua.Visible = true;
						}
						else
						{
							MessageBox.Show("Không thể sửa voicher!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
        }
		public string GettenSP(string MaSP)
		{
			string tenSP = string.Empty;
			try
			{
				string query = "SELECT TenSP FROM Tb_SanPham WHERE MaSP = @MaSP";

				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@MaSP", MaSP);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								tenSP = reader["tenSP"].ToString();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return tenSP;
		}
		private void txtapdung_SelectedIndexChanged(object sender, EventArgs e)
		{

			// Kiểm tra xem người dùng đã chọn một tên nguyên liệu nào đó hay chưa
			if (txtapdung.SelectedIndex != -1)
			{
				// Lấy tên nguyên liệu được chọn
				string selectedMaSP = txtapdung.SelectedItem.ToString();

				// Gọi phương thức GetDonVi để lấy đơn vị tương ứng
				string tenSP = GettenSP(selectedMaSP);

				// Gán đơn vị vào ComboBoxDonVi
				txttenSPapdung.Text = tenSP;
			}


			

		}

		private void btnload_Click(object sender, EventArgs e)
		{
			load();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Xác nhận trước khi xóa
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa voicher này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				// Tạo câu truy vấn SQL để xóa voicher dựa trên MaVC
				string deleteQuery = "DELETE FROM Tb_Voicher WHERE MavoiCher = @mavc";

				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(deleteQuery, connection))
					{
						// Thêm tham số cho câu truy vấn SQL
						command.Parameters.AddWithValue("@mavc", txtmavc.Text);

						// Thực thi câu truy vấn
						int rowsAffected = command.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							// Sau khi xóa thành công, làm mới DataGridView để hiển thị dữ liệu mới
							load(); // Load lại dữ liệu
							MessageBox.Show("Xóa voicher thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Không thể xóa voicher!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
		}
	}
}
