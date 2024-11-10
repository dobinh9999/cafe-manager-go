using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;

namespace ql_cafe_bia
{
	public partial class HoaDon : Form
	{
		private List<Oder_HoaDon> _products;
		public HoaDon(List<Oder_HoaDon> products, ArrayList arrlist)
		{
			InitializeComponent();
			Load += (s, e) => LoadDataIntoDataGridView(products);
			_products = products;
			_arrlist = arrlist;

		}
		private ArrayList _arrlist;
		ArrayList tongalltien = new ArrayList();
		private String allsoluong;

		private void LoadDataIntoDataGridView(List<Oder_HoaDon> products)
		{
			foreach (var product in products)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(datagviewHoaDon); // Giả sử dataGridViewHoaDon là DataGridView trong form mới
				row.Cells[0].Value = product.TenSP;
				row.Cells[1].Value = product.GiaSP;
				row.Cells[2].Value = product.SoLuong;
				row.Cells[3].Value = product.TongTien + ",000".ToString();
				datagviewHoaDon.Rows.Add(row);
			}
			int tongsoluong = 0;
			foreach (DataGridViewRow roww in datagviewHoaDon.Rows)
			{

				string allsluong = roww.Cells[2].Value?.ToString();


				if (int.TryParse(allsluong, out int sluong))
				{
					// Tính tổng tiền của mỗi dòng và cộng vào tổng tiền tất cả
					tongsoluong += sluong;

				}

			}

			allsoluong = tongsoluong.ToString();

			float tongTienTatCa = 0;
			foreach (DataGridViewRow roww in datagviewHoaDon.Rows)
			{

				string tongtien = roww.Cells[3].Value?.ToString();

				float tien;
				if (float.TryParse(tongtien, out tien))
				{

					tongTienTatCa += tien;

					// Thêm tổng tiền tất cả vào ArrayList
					tongalltien.Add(tongTienTatCa);
				}

			}
			lbltongtien.Text = tongTienTatCa + ".000 đ".ToString();
			lbltongtien1.Text = tongTienTatCa.ToString();

			ArrayList VoicherList = ketnoisql.GetList($"SELECT TenVC FROM Tb_Voicher");
			foreach (string Voicher in VoicherList)
			{
				cbbtenvoicher.Items.Add(Voicher);
			}

		}


		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void HoaDon_Load(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'cAFE_AND_BIDADataSet2.Tb_HoaDonChiTiet' table. You can move, or remove it, as needed.
			//this.tb_HoaDonChiTietTableAdapter.Fill(this.cAFE_AND_BIDADataSet2.Tb_HoaDonChiTiet);
			foreach (Oder_HoaDon tt in _arrlist)
			{
				lbltenkh.Text = tt.TenKH;
				lblsdt.Text = tt.SDT;
				lbldtl.Text = tt.DiemTichLuy.ToString();
			}

			foreach (Oder_HoaDon tt in _arrlist)
			{
				ArrayList DiemTichLuyList = ketnoisql.GetList($"SELECT DiemTichLuy FROM Tb_KhachHang where SDT ='{lblsdt.Text}'");
				foreach (string DiemTichLuy in DiemTichLuyList)
				{

				}
			}


		}


		private void datagviewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		public string GetGiaTriGGByTenVoiCher(string TenVoiCher)
		{
			string MGiaTriGG = string.Empty;
			try
			{
				string query = "SELECT v.GiaTriGG " +
							   "FROM Tb_Voicher v " +
							   "WHERE v.TenVC = @TenVoiCher";

				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@TenVoiCher", TenVoiCher);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								MGiaTriGG = reader["GiaTriGG"].ToString();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return MGiaTriGG;
		}
		private void cbbtenvoicher_SelectedIndexChanged(object sender, EventArgs e)
		{

			// Kiểm tra xem người dùng đã chọn một tên voucher nào đó hay chưa
			if (cbbtenvoicher.SelectedIndex != -1)
			{
				// Lấy tên voucher được chọn
				string selectedTenVoiCher = cbbtenvoicher.SelectedItem.ToString();

				// Gọi phương thức GetApDungByTenVoiCher để lấy mã ApDung tương ứng
				string GiaTriGG = GetGiaTriGGByTenVoiCher(selectedTenVoiCher);

				// Hiển thị mã GiaTriGG
				cbbvoicher.Text = GiaTriGG;
			}

		}




		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(lbltenkh.Text) && string.IsNullOrEmpty(lblsdt.Text))
			{
				lbldtlnhanduoc.Text = "Null";
			}
			else if (int.TryParse(lbldtl.Text, out int number))
			{
				// Kiểm tra xem lbltongtien có giá trị hợp lệ hay không trước khi chia
				if (int.TryParse(lbltongtien1.Text, out int tongTien))
				{
					// Thực hiện phép chia và gán kết quả cho lbldtlnhanduoc
					lbldtlnhanduoc.Text = (tongTien / 10).ToString();
				}
				else
				{
					// Xử lý trường hợp lbltongtien không phải là một số hợp lệ
					lbldtlnhanduoc.Text = "Null";
				}
			}
			else
			{
				lbldtlnhanduoc.Text = "Null";
			}

			// In ra kết quả cuối cùng trong console (chỉ để kiểm tra)
			Console.WriteLine("Kết quả: " + lbldtlnhanduoc.Text);

			if (!string.IsNullOrEmpty(lbltongtien1.Text))
			{
				// Lấy giá trị lbltongtien1
				decimal tongtien = 0;
				decimal.TryParse(lbltongtien1.Text, out tongtien);

				// Khai báo các giá trị giảm giá và phần trăm voucher, ban đầu bằng 0
				decimal dtl = 0;
				decimal voucherPercentage = 0;

				// Nếu txtdtl không null hoặc không rỗng, parse nó ra số
				if (!string.IsNullOrEmpty(cbbdtl.Text))
				{
					decimal.TryParse(cbbdtl.Text, out dtl);
				}

				// Nếu txtvoicher không null hoặc không rỗng, parse nó ra số
				if (!string.IsNullOrEmpty(cbbvoicher.Text))
				{
					decimal.TryParse(cbbvoicher.Text, out voucherPercentage);
				}

				// Tính giá trị sau khi trừ dtl và phần trăm voucher
				decimal voucherValue = tongtien * (voucherPercentage / 100);
				decimal result = tongtien - dtl - voucherValue;

				// Cập nhật giá trị cho lblkq
				lbltongtienthanhtoan.Text = result + ",000".ToString();
				lbltongtienthanhtoan1.Text = result.ToString();
			}
			else
			{
				lbltongtienthanhtoan.Text = "Null";
			}
		}
		private string SDT ;
		private void btnluu_Click(object sender, EventArgs e)
		{
			SDT = lblsdt.Text;
			if (lblsdt.Text != "Null" &&
				lbltenkh.Text != "Null" &&
				lbldtlnhanduoc.Text != "Null")
			{
				string insertQuery = "INSERT INTO Tb_KhachHang (SDT,TenKH, DiemTichLuy, TongChiTieu) " + "VALUES (@SDT,@TenKH, @DiemTichLuy, @TongChiTieu)";

				string updateQuery = @"UPDATE Tb_KhachHang SET TenKH = @TenKH, DiemTichLuy = DiemTichLuy + @DiemTichLuy, TongChiTieu = TongChiTieu + @TongChiTieu WHERE SDT = @SDT";

				string checkQuery = "SELECT COUNT(*) FROM Tb_KhachHang WHERE SDT = @SDT";

				try
				{
					using (SqlConnection connection = ketnoisql.TaoKetNoi())
					{
						connection.Open();

						// Kiểm tra sự tồn tại của SDT
						using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
						{
							checkCommand.Parameters.AddWithValue("@SDT", lblsdt.Text);
							int count = (int)checkCommand.ExecuteScalar();

							if (count > 0)
							{
								// Nếu SDT tồn tại, thực hiện câu lệnh UPDATE
								using (SqlCommand command = new SqlCommand(updateQuery, connection))
								{
									// Đưa các giá trị từ các ô TextBox vào câu truy vấn
									command.Parameters.AddWithValue("@TenKH", lbltenkh.Text);
									command.Parameters.AddWithValue("@SDT", lblsdt.Text);
									if (string.IsNullOrEmpty(lbldtlnhanduoc.Text))
									{
										command.Parameters.AddWithValue("@DiemTichLuy", (string.IsNullOrEmpty(lbldtlnhanduoc.Text) ? 0 : Convert.ToDecimal(lbldtlnhanduoc.Text)) + (string.IsNullOrEmpty(lbldtl.Text) ? 0 : Convert.ToDecimal(lbldtl.Text)) - (string.IsNullOrEmpty(lbldtl.Text) ? 0 : Convert.ToDecimal(lbldtl.Text)));
									}
									else
									{
										command.Parameters.AddWithValue("@DiemTichLuy", (string.IsNullOrEmpty(lbldtlnhanduoc.Text) ? 0 : Convert.ToDecimal(lbldtlnhanduoc.Text)) + ((string.IsNullOrEmpty(lbldtl.Text) ? 0 : Convert.ToDecimal(lbldtl.Text)) - (string.IsNullOrEmpty(lbldtl.Text) ? 0 : Convert.ToDecimal(lbldtl.Text)) - (string.IsNullOrEmpty(cbbdtl.Text) ? 0 : Convert.ToDecimal(cbbdtl.Text))));
									}

									command.Parameters.AddWithValue("@TongChiTieu", string.IsNullOrEmpty(lbltongtienthanhtoan1.Text) ? 0 : Convert.ToDecimal(lbltongtienthanhtoan1.Text));

									// Thực thi câu truy vấn
									int rowsAffected = command.ExecuteNonQuery();
									if (rowsAffected > 0)
									{
										MessageBox.Show("Đã cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
									else
									{
										MessageBox.Show("Không có khách hàng nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									}
								}
							}
							else
							{
								try
								{


									using (SqlCommand command = new SqlCommand(insertQuery, connection))
									{
										// Đưa các giá trị từ các ô TextBox vào câu truy vấn
										command.Parameters.AddWithValue("@SDT", lblsdt.Text);
										command.Parameters.AddWithValue("@TenKH", lbltenkh.Text);
										command.Parameters.AddWithValue("@DiemTichLuy", lbldtlnhanduoc.Text);
										command.Parameters.AddWithValue("@TongChiTieu", lbltongtienthanhtoan1.Text);

										// Thực thi câu truy vấn
										int rowsAffected = command.ExecuteNonQuery();
										if (rowsAffected > 0)
										{

											MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

										}
										else
										{
											MessageBox.Show("Không thể thêm khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
										}
									}

								}
								catch (Exception ex)
								{
									MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			luuhoadon();
		}
		private int maHoaDonMoi;
		private void luuhoadon()
		{


			string insertQuery = @"INSERT INTO Tb_HoaDon (TenKH, NgayGio, DiemTichLuy, TenVC,SoLuong,TongTien) 
                           VALUES (@TenKH, @NgayGio, @DiemTichLuy, @TenVC,@SoLuong,@TongTien);
							SELECT SCOPE_IDENTITY();";

			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						// Đưa các giá trị từ các điều khiển vào câu truy vấn
						// 	
						command.Parameters.AddWithValue("@TenKH", lbltenkh.Text);
						command.Parameters.AddWithValue("@NgayGio", Convert.ToDateTime(txtngaytao.Text));
						if (string.IsNullOrEmpty(lbldtlnhanduoc.Text) || lbldtlnhanduoc.Text == "Null")
						{
							command.Parameters.AddWithValue("@DiemTichLuy", 0);
						}
						else
						{
							command.Parameters.AddWithValue("@DiemTichLuy", Convert.ToDecimal(lbldtlnhanduoc.Text));
						}
						if (string.IsNullOrEmpty(cbbtenvoicher.Text))
						{
							command.Parameters.AddWithValue("@TenVC", DBNull.Value);
						}
						else
						{
							command.Parameters.AddWithValue("@TenVC", cbbtenvoicher.Text);
						}

						command.Parameters.AddWithValue("@SoLuong", allsoluong.ToString());
						command.Parameters.AddWithValue("@TongTien", lbltongtienthanhtoan1.Text);

						
						// Thực thi câu truy vấn và lấy mã hóa đơn vừa tạo
						object result = command.ExecuteScalar();
						if (result != null)
						{
							maHoaDonMoi = Convert.ToInt32(result);
							MessageBox.Show("Đã lưu hóa đơn thành công với mã hóa đơn: " + maHoaDonMoi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							DialogResult result1 = MessageBox.Show("Bạn có muốn lưu hóa đơn ?", "Xác nhận !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

							if (result1 == DialogResult.Yes)
							{
								
								// Sau khi lưu, in hóa đơn
								InHoaDon(maHoaDonMoi);
							}
							
						}
						else
						{
							MessageBox.Show("Không có hóa đơn nào được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi lef: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btninhoadon_Click(object sender, EventArgs e)
		{
			if (maHoaDonMoi > 0) // Kiểm tra xem mã hóa đơn mới đã được lưu chưa
			{
				InHoaDon(maHoaDonMoi);  // Gọi hàm InHoaDon với mã hóa đơn mới nhất
			}
			else
			{
				MessageBox.Show("Chưa có hóa đơn nào được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void InHoaDon(int maHoaDon)
		{
			try
			{
				using (SqlConnection connection = ketnoisql.TaoKetNoi())
				{
					connection.Open();

					// Lấy thông tin hóa đơn dựa trên mã hóa đơn
					string query = "SELECT * FROM Tb_HoaDon WHERE MaHD = @MaHD";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@MaHD", maHoaDon);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								// Đọc dữ liệu của hóa đơn
								string tenKH = reader["TenKH"].ToString();
								DateTime ngayGio = Convert.ToDateTime(reader["NgayGio"]);
								decimal diemTichLuy = Convert.ToDecimal(reader["DiemTichLuy"]);
								string tenVC = reader["TenVC"] != DBNull.Value ? reader["TenVC"].ToString() : "Không có";
								int soLuong = Convert.ToInt32(reader["SoLuong"]);
								decimal tongTien = Convert.ToDecimal(reader["TongTien"]);

								// Tạo file PDF và lưu hóa đơn vào đó (hoặc in ra giao diện)
								SaveInvoiceToPDF(tenKH, ngayGio, diemTichLuy, tenVC, soLuong, tongTien);
							}
							else
							{
								MessageBox.Show("Không tìm thấy hóa đơn với mã này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SaveInvoiceToPDF(string tenKH, DateTime ngayGio, decimal diemTichLuy, string tenVC, int soLuong, decimal tongTien)
		{
			// Tạo tên file tự động dựa trên ngày giờ hiện tại
			string fileName = "hoadon_" + maHoaDonMoi + ".pdf";

			// Đường dẫn thư mục lưu file (ổ C)
			string folderPath = @"C:\Invoices\";

			// Kiểm tra và tạo thư mục nếu chưa tồn tại
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			// Đường dẫn đầy đủ của file PDF
			string filePath = Path.Combine(folderPath, fileName);

			// Tạo đối tượng Document
			Document doc = new Document();
			try
			{
				// Tạo đối tượng PdfWriter để ghi file
				PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

				// Mở tài liệu
				doc.Open();

				string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
				BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
				iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD); // Font cho tiêu đề
				iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL); // Font cho nội dung thông thường

				// Thêm tiêu đề quán với thông tin địa chỉ và số điện thoại
				Paragraph header = new Paragraph("CaFe mang đi", titleFont) { Alignment = Element.ALIGN_CENTER };
				doc.Add(header);

				Paragraph address = new Paragraph("Địa Chỉ: số 30 Bà Triệu, Phường Nam Định, Tỉnh Việt Nam\nĐT: 0333555999 - 0666888999", textFont) { Alignment = Element.ALIGN_CENTER };
				doc.Add(address);

				// phân cách dòng 
				doc.Add(new Paragraph(new Chunk(new LineSeparator(0.5f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -2))));

				// Thêm dòng trống
				doc.Add(new Paragraph(Environment.NewLine));
				// Thêm thông tin khách hàng và hóa đơn
				doc.Add(new Paragraph("Khách hàng : " + tenKH, textFont));
				doc.Add(new Paragraph("Số điện thoại: " + SDT, textFont));
				doc.Add(new Paragraph("Voucher áp dụng: " + tenVC, textFont));
				doc.Add(new Paragraph("Điểm tích lũy nhận được: " + diemTichLuy, textFont));
				doc.Add(new Paragraph("Ngày Tạo : " + ngayGio.ToString("dd/MM/yyyy"), textFont));
		
				// Thêm dòng trống
				doc.Add(new Paragraph(Environment.NewLine));

				// Tạo bảng cho sản phẩm
				PdfPTable table = new PdfPTable(4); // 4 cột cho bảng
				table.WidthPercentage = 100;

				// Thêm tiêu đề cột vào bảng
				table.AddCell(new Phrase("Tên Sản Phẩm", textFont));
				table.AddCell(new Phrase("Giá Sản Phẩm", textFont));
				table.AddCell(new Phrase("Số Lượng", textFont));
				table.AddCell(new Phrase("Tổng Tiền", textFont));

				// Giả sử bạn đã có danh sách sản phẩm từ DataGridView
				foreach (var product in _products)
				{
					table.AddCell(new Phrase(product.TenSP, textFont));
					table.AddCell(new Phrase(product.GiaSP, textFont));
					table.AddCell(new Phrase(product.SoLuong, textFont));
					table.AddCell(new Phrase(product.TongTien + ",000", textFont));
				}

				// Thêm bảng vào tài liệu PDF
				doc.Add(table);

				// Dòng phân cách dưới bảng
				doc.Add(new Paragraph(new Chunk(new LineSeparator(0.5f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -2))));

				// Thêm tổng tiền thanh toán
				doc.Add(new Paragraph("Tổng Tiền: " + tongTien, textFont));

				// Thêm footer
				Paragraph footer = new Paragraph("Cảm ơn quý khách!", textFont) { Alignment = Element.ALIGN_CENTER };
				doc.Add(footer);





				// Sau khi lưu hóa đơn, hiển thị MessageBox và hỏi người dùng có muốn mở file không
				DialogResult result = MessageBox.Show("Hóa đơn đã được lưu thành công tại: " + filePath + "\nBạn có muốn mở file PDF để in không?",
													 "Thông báo!",
													 MessageBoxButtons.YesNo,
													 MessageBoxIcon.Information);

				// Nếu người dùng chọn "Yes", mở file PDF
				if (result == DialogResult.Yes)
				{
					try
					{
						System.Diagnostics.Process.Start(filePath);  // Mở file PDF
					}
					catch (Exception ex)
					{
						MessageBox.Show("Không thể mở file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tạo file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Đóng document
				if (doc.IsOpen())
				{
					doc.Close();
				}
			}
		}
	}

}
