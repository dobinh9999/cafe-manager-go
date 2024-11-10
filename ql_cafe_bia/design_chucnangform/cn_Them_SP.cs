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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ql_cafe_bia
{
    public partial class cn_Them_SP : Form
    {
        public cn_Them_SP()
        {
            InitializeComponent();
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


            //string selectQuery = "SELECT * FROM Tb_NguyenLieu where MaNL = @MaNL";
            //DataTable dataTable = ketnoisql.GetDataTable(selectQuery);       
            //dgvNguyenLieu.DataSource = dataTable;
            // Chuỗi truy vấn SQL
            string selectQuery = "SELECT * FROM Tb_NguyenLieu WHERE MaSP = @MaSP";


            using (SqlConnection connection = ketnoisql.TaoKetNoi())
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {

                    command.Parameters.AddWithValue("@MaSP", cbbMaSP.Text);


                    DataTable dt = new DataTable();

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ SqlCommand vào dt
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvNguyenLieu.DataSource = dt;
                }
            }
        }
        private void cn_Them_SP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet1.Tb_NguyenLieu' table. You can move, or remove it, as needed.
            //this.tb_NguyenLieuTableAdapter1.Fill(this.cAFE_AND_BIDADataSet1.Tb_NguyenLieu);
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_NguyenLieu' table. You can move, or remove it, as needed.
            ArrayList tenNguyenLieuList = ketnoisql.GetList("SELECT TenNL FROM Tb_KhoNL");
            foreach (string tenNL in tenNguyenLieuList)
            {
                cbbtenNL.Items.Add(tenNL);
            }

            ArrayList donvinNguyenLieuList = ketnoisql.GetList("SELECT donvi FROM Tb_KhoNL");
            foreach (string donvi in donvinNguyenLieuList)
            {
                cbbdonvi.Items.Add(donvi);
            }

            ArrayList MaSPList = ketnoisql.GetList("SELECT MaSP FROM Tb_SanPham");
            foreach (string Masp in MaSPList)
            {
                cbbMaSP.Items.Add(Masp);
            }

			ArrayList MaloaiSPList = ketnoisql.GetList("SELECT MaLoaiSP FROM Tb_LoaiSP");
			foreach (string MaLoaiSP in MaloaiSPList)
			{
				cbbmaloai.Items.Add(MaLoaiSP);
			}

			txttenloai.Enabled = false;

		}
		public string Gettenloai(string MaLoaiSP)
		{
			string TenLoaiSP = string.Empty;
			try
			{
				string query = "SELECT TenLoaiSP FROM Tb_LoaiSP WHERE MaLoaiSP = @MaLoaiSP";

				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								TenLoaiSP = reader["TenLoaiSP"].ToString();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return TenLoaiSP;
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
        private void LoadMaSPList()
        {
            try
            {
                // Xóa tất cả các mục hiện tại trong ComboBox cbbMaSP
                cbbMaSP.Items.Clear();

                // Lấy danh sách Mã Sản Phẩm từ cơ sở dữ liệu và thêm vào ComboBox cbbMaSP
                string query = "SELECT MaSP FROM Tb_SanPham";
                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbbMaSP.Items.Add(reader["MaSP"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách Mã Sản Phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn ảnh cho sản phẩm hay chưa
             if (string.IsNullOrEmpty(txtImagePath.Text))
            {
                MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin sản phẩm từ giao diện người dùng
            string tenSP = txttensp.Text;
            int maLoaiSP = Convert.ToInt32(cbbmaloai.Text);
            decimal giaSP = Convert.ToDecimal(txtgiasp.Text);


            // Lấy đường dẫn của ảnh từ TextBox txtImagePath
            string imagePath = txtImagePath.Text;

            // Chuyển đổi đường dẫn của ảnh thành mảng byte
            byte[] imageData = File.ReadAllBytes(imagePath);

            // Tạo câu lệnh SQL để thêm sản phẩm vào bảng Tb_SanPham
            string insertQuery = "INSERT INTO Tb_SanPham (TenSP, MaLoaiSP, GiaSP, AnhSP) VALUES (@TenSP, @MaLoaiSP, @GiaSP, @AnhSP);";

            // Mở kết nối đến cơ sở dữ liệu và thực thi câu lệnh thêm
            using (SqlConnection connection = ketnoisql.TaoKetNoi())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@TenSP", tenSP);
                    command.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);
                    command.Parameters.AddWithValue("@GiaSP", giaSP);
                    command.Parameters.AddWithValue("@AnhSP", imageData);

                    command.ExecuteNonQuery();

					MessageBox.Show(" Đã thêm sản phẩm thành công!", " thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					load();
                    LoadMaSPList();
                    // Sau khi lấy mã sản phẩm vừa thêm

                }
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
        private void cbbtenNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một tên nguyên liệu nào đó hay chưa
            if (cbbtenNL.SelectedIndex != -1)
            {
                // Lấy tên nguyên liệu được chọn
                string selectedTenNL = cbbtenNL.SelectedItem.ToString();

                // Gọi phương thức GetDonVi để lấy đơn vị tương ứng
                string donVi = GetDonVi(selectedTenNL);

                // Gán đơn vị vào ComboBoxDonVi
                cbbdonvi.Text = donVi;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (string.IsNullOrWhiteSpace(cbbtenNL.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(cbbdonvi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              

                // Lấy tên nguyên liệu được chọn từ ComboBoxTenNguyenLieu
                string selectedTenNL = cbbtenNL.SelectedItem.ToString();

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
                        command.Parameters.AddWithValue("@MaSP",cbbMaSP.Text);
                        command.Parameters.AddWithValue("@MaKNL", maKNL);
                        command.Parameters.AddWithValue("@TenNL", cbbtenNL.Text);
                        command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                        command.Parameters.AddWithValue("@DonVi", cbbdonvi.Text);

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
                string selectedTenNL = cbbMaSP.SelectedItem.ToString();
            }
        }

        private void dgvNguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void cbbmaloai_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbmaloai.SelectedIndex != -1)
			{
				// Lấy tên nguyên liệu được chọn
				string selectedMaloai = cbbmaloai.SelectedItem.ToString();

				// Gọi phương thức GetDonVi để lấy đơn vị tương ứng
				string tenloaisp = Gettenloai(selectedMaloai);

				// Gán đơn vị vào ComboBoxDonVi
				txttenloai.Text = tenloaisp;
			}
		}
	}
}
    

