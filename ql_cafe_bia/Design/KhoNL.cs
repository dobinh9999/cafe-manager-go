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
    public partial class KhoNL : Form
    {
        public KhoNL()
        {
            InitializeComponent();
        }

        private void KhoNL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_KhoNL' table. You can move, or remove it, as needed.
            this.tb_KhoNLTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_KhoNL);
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_KhoNL' table. You can move, or remove it, as needed.
            //this.tb_KhoNLTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_KhoNL);
           btnluu.Visible = false;
           btnhuy.Visible = false;

        }
        private void load()
        {
            // Thực hiện truy vấn SQL để lấy lại dữ liệu từ cơ sở dữ liệu
            string selectQuery = "SELECT * FROM Tb_KhoNL";
            DataTable dataTable = ketnoisql.GetDataTable(selectQuery);

            // Cập nhật dữ liệu trong DataGridView
            dgvKhoNL.DataSource = dataTable;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool  isadding = false;
        private bool isediting = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            isadding = true;
            isediting = false;
            txtMaKNL.Visible = false;
            btnThem.Visible = false;
            btnSua.Visible = true;
            btnluu.Visible = true;
            btnhuy.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isadding = false;
            isediting = true;
            txtMaKNL.Visible = false;
            btnSua.Visible = false;
            btnThem.Visible=true;
            btnluu.Visible = true;
            btnhuy.Visible = true;
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtMaKNL.Visible = true;
            btnSua.Visible = true;
            btnThem.Visible = true;
            btnhuy.Visible = false;
            btnluu.Visible = false;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (isadding) 
            {
                try
                {
                    // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                    if (string.IsNullOrWhiteSpace(txtTenNL.Text) ||
                        string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonVi.Text) )
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo câu truy vấn SQL để thêm vào kho
                    string insertQuery = "INSERT INTO Tb_KhoNL (TenNL, SoLuong, DonVi) " +
                                         "VALUES (@TenNL, @SoLuong, @DonVi)";

                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Đưa các giá trị từ các ô TextBox vào câu truy vấn
                            command.Parameters.AddWithValue("@TenNL", txtTenNL.Text);
                            command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text); // Giả sử SoLuong là kiểu INT
                            command.Parameters.AddWithValue("@DonVi", txtDonVi.Text);
                            

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
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm vào kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(isediting)
            {
                // Kiểm tra xem các trường dữ liệu có được điền đầy đủ không
                if (string.IsNullOrWhiteSpace(txtTenNL.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDonVi.Text)
                    )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Cập nhật dữ liệu vào cơ sở dữ liệu
                string updateQuery = "UPDATE Tb_KhoNL SET TenNL = @TenNL, SoLuong = @SoLuong, DonVi = @DonVi WHERE MaKNL = @MaKNL";

                    try
                    {
                        using (SqlConnection connection = ketnoisql.TaoKetNoi())
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Đưa các giá trị từ các ô TextBox vào câu truy vấn
                                command.Parameters.AddWithValue("@TenNL", txtTenNL.Text);
                                command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                                command.Parameters.AddWithValue("@DonVi", txtDonVi.Text);
                                command.Parameters.AddWithValue("@MaKNL", txtMaKNL.Text);



                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                                    load();
                                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtMaKNL.Visible = true;
                                    btnSua.Visible = true;
                                    btnluu.Visible = false;  
                                    btnhuy.Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("Không có dữ liệu nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvKhoNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn lại !", "thông báo !");
                return;
            }

            //57 txtMaSP.Text = dgv_SP.Rows[i].Cells[0].Value?.ToString();
            txtTenNL.Text = dgvKhoNL.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvKhoNL.CurrentRow.Cells[1].Value.ToString();
            txtDonVi.Text = dgvKhoNL.CurrentRow.Cells[2].Value.ToString();
            txtMaKNL.Text = dgvKhoNL.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoNL.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc Mã kho cần xóa
                string MaKNL = dgvKhoNL.SelectedRows[3].Cells["MaKNL"].Value.ToString();

                // Thực hiện xóa
                string deleteQuery = "DELETE FROM KhoNL WHERE MaKNL = @MaKNL";
                try
                {
                    using (SqlConnection connection = ketnoisql.TaoKetNoi())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaKNL", MaKNL);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Sau khi xóa thành công, làm mới DataGridView để cập nhật dữ liệu
                                load();
                                MessageBox.Show("Xóa khỏi kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            load();
            txtTenNL.Text = "";
            txtSoLuong.Text = "";
            txtDonVi.Text = "";
            txtMaKNL.Text = "";
        }
    }
}
