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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet2.Tb_KhachHang' table. You can move, or remove it, as needed.
			this.tb_KhachHangTableAdapter.Fill(this.cAFE_AND_BIDADataSet2.Tb_KhachHang);
			
			btnluu.Visible = false;
            btnhuy.Visible = false;

        }

        private void load()
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_KhachHang";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dgvKhachHang.DataSource = dataTable;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
                return;
            }

			//57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
			txtsdt.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
			txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
           
            txtdtl.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txttongchitieu.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }
        private bool isEditing = false; 
        private bool isAdding = false; 

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEditing = false;
            isAdding = true;
            btnThem.Visible = false;
            btnluu.Visible = true;
            btnhuy.Visible = true;
           
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(isAdding)
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtsdt.Text) || string.IsNullOrWhiteSpace(txtdtl.Text) ||
                    string.IsNullOrWhiteSpace(txttongchitieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu truy vấn SQL để thêm khách hàng mới
                string insertQuery = "INSERT INTO Tb_KhachHang (TenKH, SDT, DiemTichLuy, TongChiTieu) " +
                                     "VALUES (@TenKH, @SDT, @DiemTichLuy, @TongChiTieu)";

                try
                {
                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Đưa các giá trị từ các ô TextBox vào câu truy vấn
                            command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                            command.Parameters.AddWithValue("@SDT", txtsdt.Text);
                            command.Parameters.AddWithValue("@DiemTichLuy", txtdtl.Text);
                            command.Parameters.AddWithValue("@TongChiTieu", txttongchitieu.Text);

                            // Thực thi câu truy vấn
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Sau khi thêm thành công, làm mới DataGridView để hiển thị dữ liệu mới
                                load();

                                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnluu.Visible = false;
                                btnThem.Visible = true;
                                btnhuy.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(isEditing)
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (
                    string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtsdt.Text) ||
                    string.IsNullOrWhiteSpace(txtdtl.Text) ||
                    string.IsNullOrWhiteSpace(txttongchitieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu truy vấn SQL để cập nhật thông tin khách hàng
                string updateQuery = "UPDATE Tb_KhachHang SET TenKH = @TenKH, DiemTichLuy = @DiemTichLuy, TongChiTieu = @TongChiTieu WHERE SDT = @SDT";

                try
                {
                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Đưa các giá trị từ các ô TextBox vào câu truy vấn
                           
                            command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                            command.Parameters.AddWithValue("@SDT", txtsdt.Text);
                            command.Parameters.AddWithValue("@DiemTichLuy", txtdtl.Text);
                            command.Parameters.AddWithValue("@TongChiTieu", txttongchitieu.Text);

                            // Thực thi câu truy vấn
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Sau khi cập nhật thành công, làm mới DataGridView để hiển thị dữ liệu mới
                                load();
                                MessageBox.Show("Đã cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnluu.Visible = false;
                                btnSua.Visible = true;
                                btnhuy.Visible = false;
                               
                                btnThem.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Không có khách hàng nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnSua.Visible = true;
           
            btnThem.Visible = true;
            btnluu.Visible=false;
            btnhuy.Visible=false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEditing = true;
            isAdding = false;
            btnSua.Visible = false;
            btnluu.Visible = true;
            btnhuy.Visible = true;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn khách hàng để xóa chưa
            if (!string.IsNullOrEmpty(txtsdt.Text))
            {
                // Lấy mã khách hàng từ TextBox
                int maKH;
                if (int.TryParse(txtsdt.Text, out maKH))
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Tạo câu truy vấn SQL để xóa khách hàng
                        string deleteQuery = "DELETE FROM Tb_KhachHang WHERE MaKH = @MaKH";

                        try
                        {
                            using (SqlConnection connection = ketnoisql.TaoKetNoi())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                {
                                    // Thêm tham số cho câu truy vấn
                                    command.Parameters.AddWithValue("@MaKH", maKH);

                                    // Thực thi câu truy vấn
                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // Sau khi xóa thành công, làm mới DataGridView để hiển thị dữ liệu mới
                                        load();
                                        MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có khách hàng nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            load();
           
            txtTenKH.Text = "";
            txtsdt.Text = "";
            txtdtl.Text = "";
            txttongchitieu.Text = "";
        }
    }
}
