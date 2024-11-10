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
    public partial class F_SanPham : Form
    {
        public F_SanPham()
        {
            InitializeComponent();
        }

        private void F_SanPham_Load(object sender, EventArgs e)
        {
           
            //this.tb_SanPhamTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_SanPham);
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_SanPham";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);    
            dgv_SP.DataSource = dataTable;
        }
        private void LoadData()
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_SanPham";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);          
            dgv_SP.DataSource = dataTable;
        }
        private void dgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
                return;
            }

            //57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
            txtMaSP.Text = dgv_SP.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cn_Them_SP cn_Them_SP = new cn_Them_SP();
            cn_Them_SP.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtMaSP.Text))
            {
                int maSP = Convert.ToInt32(txtMaSP.Text);

                // Viết mã truy vấn SQL để kiểm tra mã sản phẩm trong cơ sở dữ liệu
                string query = "SELECT COUNT(*) FROM Tb_SanPham WHERE MaSP = @MaSP";

                // Sử dụng kết nối và thực thi truy vấn để kiểm tra
                using (SqlConnection connection = ketnoisql.TaoKetNoi())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Thay vì sử dụng ExecuteScalar, bạn có thể sử dụng phương thức GetaValue để lấy giá trị trực tiếp từ cơ sở dữ liệu
                        int count = Convert.ToInt32(ketnoisql.GetaValue(query, "@MaSP", maSP));

                        // Kiểm tra xem mã sản phẩm có tồn tại trong cơ sở dữ liệu hay không
                        if (count > 0)
                        {
                            // Nếu mã sản phẩm tồn tại, hiển thị form sửa sản phẩm
                            // Truyền mã sản phẩm vào form sửa để load dữ liệu chi tiết của sản phẩm
                            cn_sua_SP SuaSanPham = new cn_sua_SP(maSP);
                            SuaSanPham.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Mã sản phẩm không tồn tại!", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(" Hãy nhập mã sản phẩm để thực hiện chức này !"," thông báo!",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (!string.IsNullOrEmpty(txtMaSP.Text))
                {
                    
                    int maSP;
                    if (int.TryParse(txtMaSP.Text, out maSP))
                    {
                       
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                       
                        if (result == DialogResult.Yes)
                        {
                           
                            string deleteQuery = "DELETE FROM Tb_SanPham WHERE MaSP = @MaSP";
                            using (SqlConnection connection = ketnoisql.TaoKetNoi())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@MaSP", maSP);

                                    
                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                       
                                        LoadData();
                                        txtMaSP.Text = null;
                                        MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có sản phẩm nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    string searchQuery = "SELECT * FROM Tb_SanPham WHERE TenSP LIKE @keyword OR MaLoaiSP LIKE @keyword OR GiaSP LIKE @keyword OR MaSP LIKE @keyword ";

                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dgv_SP.DataSource = dataTable;
                            MessageBox.Show("Đã tìm thấy sản phẩm phù hợp.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                           
                            dgv_SP.DataSource = null; // Xóa dữ liệu hiển thị nếu không tìm thấy kết quả
                            MessageBox.Show("Không tìm thấy sản phẩm phù hợp.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btntimkiem_Click(sender, e); }
        }
    }
}
