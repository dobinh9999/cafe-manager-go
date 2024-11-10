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
    public partial class NguyenLieu : Form
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet.Tb_NguyenLieu' table. You can move, or remove it, as needed.
            this.tb_NguyenLieuTableAdapter.Fill(this.cAFE_AND_BIDADataSet.Tb_NguyenLieu);

        }
		public void SetSanPhamInfo(int maNL, int maSP, int maKNL, string tenNL, int soLuong, string donVi)
		{
			txtMaNL.Text = maNL.ToString();   // Hiển thị mã nguyên liệu
			txtMaSP.Text = maSP.ToString();   // Hiển thị mã sản phẩm
			txtMaKNL.Text = maKNL.ToString(); // Hiển thị mã kho nguyên liệu
			txtTenNL.Text = tenNL;            // Hiển thị tên nguyên liệu
			txtSoLuong.Text = soLuong.ToString(); // Hiển thị số lượng
			txtDonVi.Text = donVi;            // Hiển thị đơn vị
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			int maNL = int.Parse(txtMaNL.Text);
			int maSP = int.Parse(txtMaSP.Text);
			int maKNL = int.Parse(txtMaKNL.Text);
			string tenNL = txtTenNL.Text;
			int soLuong = int.Parse(txtSoLuong.Text);
			string donVi = txtDonVi.Text;

			// Tạo một form mới để hiển thị thông tin (giả sử form này tên là ThongTinSanPhamForm)
			NguyenLieu thongTinForm = new NguyenLieu();

			// Truyền dữ liệu vào form mới
			thongTinForm.SetSanPhamInfo(maNL, maSP, maKNL, tenNL, soLuong, donVi);

			// Hiển thị form mới
			thongTinForm.ShowDialog();
		}
	}
}
