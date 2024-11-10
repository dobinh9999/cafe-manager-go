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
    public partial class LoaiSP : Form
    {
        public LoaiSP()
        {
            InitializeComponent();
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_LoaiSP' table. You can move, or remove it, as needed.
            //this.tb_LoaiSPTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_LoaiSP);
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_LoaiSP";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dgv_loaiSP.DataSource = dataTable;
        }
        private void load()
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_LoaiSP";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dgv_loaiSP.DataSource = dataTable;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoaiSP = txttenloaisp.Text;

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào (ví dụ: kiểm tra xem các trường có được nhập đúng cách không)
            if (string.IsNullOrEmpty(txttenloaisp.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện truy vấn SQL để thêm dữ liệu mới vào cơ sở dữ liệu
            string insertQuery = "INSERT INTO Tb_LoaiSP (TenLoaiSP) VALUES ( @TenLoaiSP)";
            using (SqlConnection connection = ketnoisql.TaoKetNoi())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@TenLoaiSP", tenLoaiSP);

                    // Thực thi truy vấn và kiểm tra số lượng hàng bị ảnh hưởng
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        load();
                        MessageBox.Show("Đã thêm loại sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thêm loại sản phẩm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_loaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
                return;
            }

            //57 txtMaSP.Text = dgv_loaiSP.Rows[i].Cells[0].Value?.ToString();
            txtmaloaisp.Text = dgv_loaiSP.CurrentRow.Cells[0].Value.ToString();
            txttenloaisp.Text = dgv_loaiSP.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

            // Thu thập dữ liệu từ các TextBox
            int maLoaiSP = Convert.ToInt32(txtmaloaisp.Text);
            string tenLoaiSP = txttenloaisp.Text;

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtmaloaisp.Text) || string.IsNullOrEmpty(txttenloaisp.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện truy vấn SQL để cập nhật thông tin loại sản phẩm trong cơ sở dữ liệu
            string updateQuery = "UPDATE Tb_LoaiSP SET TenLoaiSP = @TenLoaiSP WHERE MaLoaiSP = @MaLoaiSP";
            using (SqlConnection connection = ketnoisql.TaoKetNoi())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);
                    command.Parameters.AddWithValue("@TenLoaiSP", tenLoaiSP);

                    // Thực thi truy vấn và kiểm tra số lượng hàng bị ảnh hưởng
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                       

                        // Cập nhật lại DataGridView sau khi sửa
                        // Đặt lại nguồn dữ liệu cho DataGridView hoặc cập nhật hàng cụ thể đã được sửa
                        // Ví dụ: dgv_loaiSP.Rows[i].Cells[1].Value = tenLoaiSP;
                        // Lấy chỉ mục của hàng đã chọn
                        int rowIndex = dgv_loaiSP.CurrentRow.Index;

                        // Cập nhật giá trị của các ô tương ứng trong hàng đó
                        dgv_loaiSP.Rows[rowIndex].Cells[1].Value = tenLoaiSP; // 1 là chỉ số cột của tên loại sản phẩm trong DataGridView
                        MessageBox.Show("Đã cập nhật thông tin loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin loại sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy mã loại sản phẩm từ TextBox txtmaloaisp
                int maLoaiSP = Convert.ToInt32(txtmaloaisp.Text);

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả của hộp thoại xác nhận
                if (result == DialogResult.Yes)
                {
                    // Thực hiện truy vấn SQL để xóa loại sản phẩm từ cơ sở dữ liệu
                    string deleteQuery = "DELETE FROM Tb_LoaiSP WHERE MaLoaiSP = @MaLoaiSP";
                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);

                            // Thực thi truy vấn
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                load(); // Load lại dữ liệu sau khi xóa

                                MessageBox.Show("Đã xóa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không có loại sản phẩm nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
