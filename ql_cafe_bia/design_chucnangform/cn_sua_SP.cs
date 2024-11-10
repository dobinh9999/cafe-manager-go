using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_cafe_bia
{
    public partial class cn_sua_SP : Form
    {
        private int maSP;
        private int maKNL;
		
		public cn_sua_SP(int maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            load();
        }
        private void load()
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_SanPham";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dgvSanPham.DataSource = dataTable;
        }
        private void load1()
        {
            try
            {
                // Kiểm tra xem txtMaSP có giá trị không
                if (string.IsNullOrEmpty(cbbMaSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã sản phẩm từ TextBox txtMaSP
                int maSP;
                if (!int.TryParse(cbbMaSP.Text, out maSP))
                {
                    MessageBox.Show("Mã Sản phẩm phải là một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu với điều kiện MaSP
                string selectQuery = "SELECT * FROM Tb_NguyenLieu WHERE MaSP = @MaSP";

                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        // Tạo một đối tượng DataTable để chứa dữ liệu từ truy vấn SQL
                        DataTable dataTable = new DataTable();

                        // Sử dụng một đối tượng SqlDataReader để thực thi truy vấn và đọc dữ liệu vào DataTable
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        // Cập nhật dữ liệu trong DataGridView
                        dgvnguyenlieu.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthemanh_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của hộp thoại
            openFileDialog.Title = "Chọn hình ảnh"; // Tiêu đề của hộp thoại
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"; // Bộ lọc file

            // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn hình ảnh hay chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến file hình ảnh đã chọn
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Tạo một hình ảnh từ đường dẫn và đặt nó vào PictureBox
                    ptbanhSP.Image = Image.FromFile(imagePath);

                    // Lưu đường dẫn của hình ảnh vào một TextBox hoặc nơi thích hợp khác để sử dụng sau này
                    txtImagePath.Text = imagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở hình ảnh: " + ex.Message);
                }
            }
        }

        private void cn_sua_SP_Load(object sender, EventArgs e)
        {
           
                // Viết truy vấn SQL để lấy thông tin sản phẩm từ mã sản phẩm
                string query = "SELECT TenSP, MaLoaiSP, GiaSP, AnhSP FROM Tb_SanPham WHERE MaSP = @MaSP";

                // Sử dụng kết nối và thực thi truy vấn để lấy thông tin sản phẩm
                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);
                        SqlDataReader reader = command.ExecuteReader();

                        // Kiểm tra xem có dữ liệu trả về không
                        if (reader.Read())
                        {
                            // Lấy thông tin sản phẩm từ dữ liệu đọc được
                            string tenSP = reader["TenSP"].ToString();
                            int maLoaiSP = Convert.ToInt32(reader["MaLoaiSP"]);
                            decimal giaSP = Convert.ToDecimal(reader["GiaSP"]);

                            // Hiển thị thông tin sản phẩm lên các TextBox tương ứng
                            txttensp.Text = tenSP;
                            txtmaloai.Text = maLoaiSP.ToString();
                            txtgiasp.Text = giaSP.ToString();

                            // Hiển thị ảnh sản phẩm lên PictureBox
                            if (reader["AnhSP"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["AnhSP"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    ptbanhSP.Image = Image.FromStream(ms);
                                }
                            }
                        }

                        reader.Close();

                    }

                }

                try
                {
                    // Tạo câu truy vấn SQL để lấy thông tin nguyên liệu từ MaSP
                    string selectQuery = "SELECT * FROM Tb_NguyenLieu WHERE MaSP = @MaSP";

                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaSP", maSP);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Lấy thông tin từ các cột trong SqlDataReader và hiển thị lên giao diện
                                    string MaSP = reader["MaSP"].ToString();
                                    string maKNL = reader["MaKNL"].ToString();
                                    string tenNL = reader["TenNL"].ToString();
                                    string soLuong = reader["SoLuong"].ToString();
                                    string donVi = reader["DonVi"].ToString();

                                    // Hiển thị thông tin lên các control trên giao diện
                                    cbbMaSP.Text = MaSP;
                                    ccbtennl.Text = tenNL;
                                    txtsoluong.Text = soLuong;
                                    ccbdonvi.Text = donVi;
                                }
                                else
                                {
                                    // Nếu không có thông tin nguyên liệu cho sản phẩm này, có thể hiển thị thông báo hoặc xử lý khác tùy theo logic của bạn
                                    MessageBox.Show("Không có thông tin nguyên liệu cho sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    // Tạo câu truy vấn SQL để lấy thông tin nguyên liệu từ MaSP
                    string selectQuery = "SELECT * FROM Tb_NguyenLieu WHERE MaSP = @MaSP";

                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaSP", maSP);

                            // Tạo SqlDataAdapter để lấy dữ liệu từ SQL Server và đổ vào DataTable
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Gán DataTable làm nguồn dữ liệu cho DataGridView
                            dgvnguyenlieu.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            ArrayList tenNguyenLieuList = ketnoisql.GetList("SELECT TenNL FROM Tb_KhoNL");
            foreach (string tenNL in tenNguyenLieuList)
            {
                ccbtennl.Items.Add(tenNL);
            }
          
			ArrayList maspList = ketnoisql.GetList("SELECT MaSP FROM Tb_SanPham");
			foreach (string MaSP in maspList)
			{
				cbbMaSP.Items.Add(MaSP);
			}

			
		}

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenSP = txttensp.Text;
            int maLoaiSP = Convert.ToInt32(txtmaloai.Text);
            decimal giaSP = Convert.ToDecimal(txtgiasp.Text);

            // Chuyển đổi ảnh thành mảng byte
            byte[] imageData = null;
            if (!string.IsNullOrEmpty(txtImagePath.Text))
            {
                imageData = File.ReadAllBytes(txtImagePath.Text);
            }

            // Viết truy vấn SQL để cập nhật thông tin sản phẩm
            string updateQuery = "UPDATE Tb_SanPham SET TenSP = @TenSP, MaLoaiSP = @MaLoaiSP, GiaSP = @GiaSP, AnhSP = @AnhSP WHERE MaSP = @MaSP";

            // Sử dụng kết nối và thực hiện truy vấn để cập nhật thông tin sản phẩm
            using (SqlConnection connection = ketnoisql.TaoKetNoi())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TenSP", tenSP);
                    command.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);
                    command.Parameters.AddWithValue("@GiaSP", giaSP);
                    command.Parameters.AddWithValue("@AnhSP", (object)imageData ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MaSP", maSP);

                    // Thực hiện truy vấn cập nhật
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có sản phẩm nào đã được cập nhật không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin sản phẩm thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        load();
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm nào được cập nhật!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvnguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
                return;
            }

            //57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
            txtMaNL.Text = dgvnguyenlieu.CurrentRow.Cells[0].Value.ToString();
			cbbMaSP.Text = dgvnguyenlieu.CurrentRow.Cells[1].Value.ToString();
            ccbtennl.Text = dgvnguyenlieu.CurrentRow.Cells[3].Value.ToString();
           
            txtsoluong.Text = dgvnguyenlieu.CurrentRow.Cells[4].Value.ToString();
            ccbdonvi.Text = dgvnguyenlieu.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (
                    string.IsNullOrWhiteSpace(ccbtennl.Text) ||
                    string.IsNullOrWhiteSpace(txtsoluong.Text) ||
                    string.IsNullOrWhiteSpace(ccbdonvi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tên nguyên liệu được chọn từ ComboBoxTenNguyenLieu
                string selectedTenNL = ccbtennl.SelectedItem.ToString();

                // Lấy MaKNL từ bảng KhoNL dựa trên tên nguyên liệu được chọn
                string selectMaKNLQuery = "SELECT MaKNL FROM Tb_KhoNL WHERE TenNL = @TenNL";

                string maKNL;
                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(selectMaKNLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@TenNL", selectedTenNL);

                        // Thực thi câu truy vấn và lấy MaKNL
                        maKNL = command.ExecuteScalar()?.ToString();
                    }
                }

                // Sửa dữ liệu trong bảng nguyên liệu
                string updateQuery = "UPDATE Tb_NguyenLieu " +
									 "SET  MaKNL = @MaKNL,TenNL = @TenNL, SoLuong = @SoLuong, DonVi = @DonVi " +
									 "WHERE MaNL = @MaNL ";

                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
						command.Parameters.AddWithValue("@MaNL", txtMaNL.Text);
						command.Parameters.AddWithValue("@MaSP", cbbMaSP.Text);
                        command.Parameters.AddWithValue("@MaKNL", maKNL);
                        command.Parameters.AddWithValue("@TenNL", ccbtennl.Text);
                        command.Parameters.AddWithValue("@SoLuong", txtsoluong.Text);
                        command.Parameters.AddWithValue("@DonVi", ccbdonvi.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            load1();
                            MessageBox.Show("Sửa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GetDonVi(string tenNL)
        {
            string donVi = string.Empty;
            try
            {
                string query = "SELECT DonVi FROM Tb_KhoNL WHERE TenNL = @tenNL";

                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tenNL", tenNL);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                donVi = reader["DonVi"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return donVi;
        }
        private void ccbtennl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một tên nguyên liệu nào đó hay chưa
            if (ccbtennl.SelectedIndex != -1)
            {
                // Lấy tên nguyên liệu được chọn
                string selectedTenNL = ccbtennl.SelectedItem.ToString();

                // Gọi phương thức GetDonVi để lấy đơn vị tương ứng
                string donVi = GetDonVi(selectedTenNL);

                // Gán đơn vị vào ComboBoxDonVi
                ccbdonvi.Text = donVi;
            }
        }
        private void XoaNguyenLieu()
        {
            try
            {
                // Tạo câu truy vấn SQL để xóa nguyên liệu
                string deleteQuery = "DELETE FROM Tb_NguyenLieu WHERE MaNL = @MaNL";

                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaNL", txtMaNL.Text);
                       

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
							load1(); // Load lại dữ liệu sau khi xóa
							MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            XoaNguyenLieu();

		}

        private void btnthemnl_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (string.IsNullOrWhiteSpace(ccbtennl.Text) ||
                    string.IsNullOrWhiteSpace(txtsoluong.Text) ||
                    string.IsNullOrWhiteSpace(ccbdonvi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Lấy tên nguyên liệu được chọn từ ComboBoxTenNguyenLieu
                string selectedTenNL = ccbtennl.SelectedItem.ToString();

                // Lấy MaKNL từ bảng KhoNL dựa trên tên nguyên liệu được chọn
                string selectMaKNLQuery = "SELECT MaKNL FROM Tb_KhoNL WHERE TenNL = @TenNL";

                string maKNL;
                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(selectMaKNLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@TenNL", selectedTenNL);

                        // Thực thi câu truy vấn và lấy MaKNL
                        maKNL = command.ExecuteScalar()?.ToString();
                    }
                }

                // Thêm dữ liệu vào bảng nguyên liệu
                string insertQuery = "INSERT INTO Tb_NguyenLieu (MaSP, MaKNL, TenNL, SoLuong, DonVi) " +
                                     "VALUES (@MaSP, @MaKNL, @TenNL, @SoLuong, @DonVi)";

                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", cbbMaSP.Text);
                        command.Parameters.AddWithValue("@MaKNL", maKNL);
                        command.Parameters.AddWithValue("@TenNL", ccbtennl.Text);
                        command.Parameters.AddWithValue("@SoLuong", txtsoluong.Text);
                        command.Parameters.AddWithValue("@DonVi", ccbdonvi.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            load1();
                            MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			// Kiểm tra xem người dùng đã chọn một tên nguyên liệu nào đó hay chưa
			if (cbbMaSP.SelectedIndex != -1)
			{
				// Lấy tên nguyên liệu được chọn
				string SELECTMAsp = cbbMaSP.SelectedItem.ToString();
			}
		}
	}
}
