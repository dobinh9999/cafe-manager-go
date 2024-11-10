using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_cafe_bia
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            txtmatkhau.UseSystemPasswordChar = true;
            CancelButton = button2;

            DisplayPlaceholder();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkpass.Checked)
            {
                // Hiển thị mật khẩu
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string username = txttaikhoan.Text;
            string password = txtmatkhau.Text;
            // Truy vấn SQL để lấy tài khoản và mật khẩu từ bảng Tb_TaiKhoan
            string sql = $"SELECT LoaiID FROM Tb_TaiKhoan WHERE TaiKhoan = '{username}' AND MatKhau = '{password}'";


            string LoaiID = ketnoisql.GetaValue(sql);

            if (username == "Nhập tài khoản" && password == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu để đăng nhập", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttaikhoan.Clear();
                txttaikhoan.Focus();
                
            }
            else if (username == "Nhập tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tài khoản để đăng nhập","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txttaikhoan.Clear();
                txttaikhoan.Focus();
            }
            else if(password == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu để đăng nhập", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmatkhau.Clear();
                txtmatkhau.Focus();
            }
            else 
            {
                

               

                if (LoaiID == "")
                {
                    MessageBox.Show(username + " và " + password + " chưa đúng!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttaikhoan.Focus();
                    txttaikhoan.SelectAll();
                }
                else
                {

                    MessageBox.Show("Đăng nhập thành công!", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeForm homeForm = new HomeForm(LoaiID);
                    homeForm.ShowDialog();
                    this.Show();

                    txttaikhoan.Clear();
                    txtmatkhau.Clear();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txttaikhoan.Text))
            {
                txttaikhoan.Text = "Nhập tài khoản";
                txttaikhoan.ForeColor = SystemColors.GrayText; // Màu chữ xám
            }
            if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
            {
                txtmatkhau.Text = "Nhập mật khẩu";
                txtmatkhau.ForeColor = SystemColors.GrayText; // Màu chữ xám
            }
        }
        private void txttaikhoan_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Focus()) 
            {
               // txttaikhoan.Text = "";
                txttaikhoan.Clear();

            }
        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Focus())
            {
                // txtmatkhau.Text = "";
                txtmatkhau.Clear();

            }
        }

        private void txttaikhoan_Leave(object sender, EventArgs e)
        {
            // Hiển thị lại văn bản mặc định nếu trường trống
            if (string.IsNullOrWhiteSpace(txttaikhoan.Text))
            {
                txttaikhoan.Text = "Nhập tài khoản";
                txttaikhoan.ForeColor = SystemColors.GrayText; // Màu chữ xám
            }
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {
            // Hiển thị lại văn bản mặc định nếu trường trống
            if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
            {
                txtmatkhau.Text = "Nhập mật khẩu";
                txtmatkhau.ForeColor = SystemColors.GrayText; // Màu chữ xám
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txttaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtmatkhau.Focus();
            }
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
