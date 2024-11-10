using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_cafe_bia
{
    public partial class HomeForm : Form
    {
        private string LoaiID;

        public HomeForm(string LoaiID)
        {
            InitializeComponent();
            
            this.LoaiID = LoaiID;

        }
       
        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (LoaiID == "admin")
            {
				// trường hợp này tài khoản là admin
				btndichvubia.Visible = false;
			}
            else
            {
                btnThongKe.Visible = false;
                btndichvubia.Visible = false;
            }
        }
        private void grbwelcom_Enter(object sender, EventArgs e)
        {
            
        }
      
        bool chieucao_menuCafe = false;
        private void timer_MenuCafe_Tick(object sender, EventArgs e)
        {
            if (chieucao_menuCafe == false)
            {
                pan_MenuCafe.Height += 10;
                if (pan_MenuCafe.Height >= 350)
                {
                    timer_MenuCafe.Stop();
                    chieucao_menuCafe = true;
                }
            }
            else
            {
                pan_MenuCafe.Height -= 10;
                if (pan_MenuCafe.Height <= 60)
                {
                    timer_MenuCafe.Stop();
                    chieucao_menuCafe = false;
                }
            }
        }

        private void Menu_Cafe_Click(object sender, EventArgs e)
        {
            timer_MenuCafe.Start();
        }

        bool chieucao_QLkho = false;
        private void timer_QLkho_Tick(object sender, EventArgs e)
        {
            if (chieucao_QLkho == false)
            {
                pan_KhoNL.Height += 10;
                if (pan_KhoNL.Height >= 172)
                {
                    timer_QLkho.Stop();
                    chieucao_QLkho = true;
                }
            }
            else
            {
                pan_KhoNL.Height -= 10;
                if (pan_KhoNL.Height <= 57)
                {
                    timer_QLkho.Stop();
                    chieucao_QLkho = false;
                }
            }
        }
        private void btn_QL_KhoNL_Click_1(object sender, EventArgs e)
        {
            timer_QLkho.Start();
        }
        bool chieucao_DV_BIDA = false;
        private void timer_DV_BIDA_Tick(object sender, EventArgs e)
        {
            if (chieucao_DV_BIDA == false)
            {
                pan_DV_BIDA.Height += 10;
                if (pan_DV_BIDA.Height >= 232)
                {
                    timer_DV_BIDA.Stop();
                    chieucao_DV_BIDA = true;
                }
            }
            else
            {
                pan_DV_BIDA.Height -= 10;
                if (pan_DV_BIDA.Height <= 57)
                {
                    timer_DV_BIDA.Stop();
                    chieucao_DV_BIDA = false;
                }
            }
        }
        private void btnDV_BIDA(object sender, EventArgs e)
        {
            timer_DV_BIDA.Start();
        }
        private void pan_DV_BIDA_Paint(object sender, PaintEventArgs e)
        {
           
        }
        bool chieurong_menuTarkbar = false;
       
        private void timer_MenuTarkbar_Tick(object sender, EventArgs e)
        {
            if(chieurong_menuTarkbar == false)
            {
                pan_MenuTarkbar.Width += 10;
                if(pan_MenuTarkbar.Width >= 212)
                {
                    timer_MenuTarkbar.Stop();
                    chieurong_menuTarkbar=true ;
                    groupBox2.Text = "Danh Mục Quản Lý";
                    groupBox3.Text = "Hệ Thống";
                    btntaikhoan.Text = "Quản Lý Tài Khoản";
                    btnexit.Text = "Đăng Xuất";
                }
            }
            else
            {
                pan_MenuTarkbar.Width -= 10;
                if(pan_MenuTarkbar.Width <= 67)
                {
                    timer_MenuTarkbar.Stop();
                    chieurong_menuTarkbar = false;
                    groupBox2.Text = "";
                    groupBox3.Text = "";
                    btntaikhoan.Text = "";
                    btnexit.Text = "";

                }
            }
        }

        private void Menu_Tarkbar_Click(object sender, EventArgs e)
        {
            timer_MenuTarkbar.Start();       
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
			// Hiển thị hộp thoại xác nhận
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Xác nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Nếu người dùng chọn Yes, form sẽ đóng
				this.Close();
			}
			
		}

        private void timer_lbl1_Tick(object sender, EventArgs e)
        {

            lbl1.Text = lbl1.Text[lbl1.Text.Length - 1] +
            lbl1.Text.Substring(0, lbl1.Text.Length - 1);
        }

        private void pan_HomForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form currentFormChild; // hiện form con
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pan_HomForm.Controls.Add(childForm);
            pan_HomForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
           
            string password = Microsoft.VisualBasic.Interaction.InputBox("Nhập password trước khi vô để bảo mật hơn :", "Password"," Nhập password là : 2003 để vô đây ạ !");
            
            if (password == "2003")
            {
               
                OpenChildForm(new F_SanPham());
                label1.Text ="Thông tin " + btnSanPham.Text;
                grbwelcom.Text = "welcom";
            }
            else
            {
              
                MessageBox.Show("Nhập không đúng password thì không cho vào đâu! .","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            
            }
            label1.Text = "HeLLo friend!!";
            
            if (LoaiID == "admin")
            {
                // Hiển thị tên tài khoản của admin từ SQL
                string tenTaiKhoanAdmin = LayTenTaiKhoanAdmin();
                if (!string.IsNullOrEmpty(tenTaiKhoanAdmin))
                {
                    grbwelcom.Text = "admin : " + tenTaiKhoanAdmin;
                }
            }
            else
            {
                string tenTaiKhoanNhanvien = LayTenTaiKhoannhanvien();
                if (!string.IsNullOrEmpty(tenTaiKhoanNhanvien))
                {
                    grbwelcom.Text = "Nhân Viên : " + tenTaiKhoanNhanvien;
                }
            }
        }
        private string LayTenTaiKhoanAdmin()
        {
            string tenTaiKhoan = "";
            try
            {
                string query = "SELECT TenTK FROM Tb_TaiKhoan WHERE LoaiID = 'admin'";
                tenTaiKhoan = ketnoisql.GetaValue(query); // Sử dụng phương thức GetaValue để lấy giá trị từ SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tên tài khoản admin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tenTaiKhoan;
        }
        private string LayTenTaiKhoannhanvien()
        {
            string tenTaiKhoan = "";
            try
            {
                string query = "SELECT TenTK FROM Tb_TaiKhoan WHERE LoaiID = 'user'";
                tenTaiKhoan = ketnoisql.GetaValue(query); // Sử dụng phương thức GetaValue để lấy giá trị từ SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tên tài khoản nhanvien: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tenTaiKhoan;
        }

        private void btnloaiSP_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new LoaiSP());
            label1.Text = "Thông tin " + btnloaiSP.Text;
            grbwelcom.Text = "welcom";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new KhachHang());
            label1.Text = "Thông tin " + btnKhachHang.Text;
            grbwelcom.Text = "welcom";
        }

        private void btnKhoNL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhoNL());
            label1.Text = "Thông tin " + btnKhoNL.Text;
            grbwelcom.Text = "welcom";
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NguyenLieu());
            label1.Text = "Thông tin " + btnNguyenLieu.Text;
            grbwelcom.Text = "welcom";
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Oder_HoaDon());
            label1.Text = "Thông tin " + btnorder.Text;
            grbwelcom.Text = "welcom";
        }

        private void btnVoiCher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Voicher());
            label1.Text = "Thông tin " + btnVoiCher.Text;
            grbwelcom.Text = "welcom";
        }

		private void btnHoaDon_Click(object sender, EventArgs e)
		{
            OpenChildForm(new HoaDonSP());
            label1.Text = "Thông Tin "+ btnHoaDon.Text;
            grbwelcom.Text = "Welcom";
		}

		private void btntaikhoan_Click(object sender, EventArgs e)
		{
            OpenChildForm(new TaiKhoan());
			label1.Text = "Thông Tin " + btntaikhoan.Text;
			grbwelcom.Text = "Welcom";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenChildForm(new BanBIDA());
			label1.Text = "Thông Tin " + btnbanbida.Text;
			grbwelcom.Text = "Welcom";
		}

		private void btnloaiban_Click(object sender, EventArgs e)
		{
			OpenChildForm(new LoaiBan());
			label1.Text = "Thông Tin " + btnloaiban.Text;
			grbwelcom.Text = "Welcom";
		}

		private void btnoderban_Click(object sender, EventArgs e)
		{
			OpenChildForm(new OderBan());
			label1.Text = "Thông Tin " + btnoderban.Text;
			grbwelcom.Text = "Welcom";
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Thongke());
			label1.Text = "Thông Tin " + btnThongKe.Text;
			grbwelcom.Text = "Welcom";
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Xác nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Nếu người dùng chọn Yes,đóng toàn bộ ct
                Application.Exit();
				
			}
		}
	}
}
