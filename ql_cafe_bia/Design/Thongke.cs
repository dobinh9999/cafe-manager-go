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
using System.Windows.Forms.DataVisualization.Charting;

namespace ql_cafe_bia
{
	public partial class Thongke : Form
	{
		public Thongke()
		{
			InitializeComponent();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Thongke_Load(object sender, EventArgs e)
		{

		}
		private void btnkiemtra_Click(object sender, EventArgs e)
		{
			if (cbbthongtin.SelectedItem != null && cbbthongtin.SelectedItem.ToString() == "Doanh thu bán hàng")
			{
				doanhthu();
				
			}
			if (cbbthongtin.SelectedItem != null && cbbthongtin.SelectedItem.ToString() == "Số lượng sản phẩm bán ra")
			{
				soluongbanra();
			}
			if (cbbthongtin.SelectedItem != null && cbbthongtin.SelectedItem.ToString() == "số lượng đơn hàng")
			{
				soluongdonhang();
			}
		}
		private void doanhthu()
		{
			// Tạo truy vấn SQL để lấy doanh thu theo ngày, tuần, và tháng dựa trên checkbox
			string query = "";

			// Trường hợp tính doanh thu theo ngày
			if (chkNgay.Checked)
			{
				query += @"
        SELECT 
            CONVERT(DATE, NgayGio) AS Ngay, 
            SUM(TongTien) AS DoanhThuNgay
        FROM dbo.Tb_HoaDon
        GROUP BY CONVERT(DATE, NgayGio)
        ORDER BY Ngay";
			}

			// Trường hợp tính doanh thu theo tuần
			if (chkTuan.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(ISO_WEEK, NgayGio) AS Tuan, 
            SUM(TongTien) AS DoanhThuTuan
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(ISO_WEEK, NgayGio)
        ORDER BY Nam, Tuan";
			}

			// Trường hợp tính doanh thu theo tháng
			if (chkThang.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(MONTH, NgayGio) AS Thang, 
            SUM(TongTien) AS DoanhThuThang
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(MONTH, NgayGio)
        ORDER BY Nam, Thang";
			}

			// Nếu không có checkbox nào được chọn
			if (string.IsNullOrEmpty(query))
			{
				MessageBox.Show("Vui lòng chọn ít nhất một tùy chọn để tính doanh thu.");
				return;
			}

			// Tạo DataTable để lưu dữ liệu doanh thu
			DataTable dataTable = new DataTable();

			// Kết nối đến CSDL và thực thi truy vấn
			using (SqlConnection connection = ketnoisql.TaoKetNoi())
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						adapter.Fill(dataTable);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
					return;
				}
			}

			// Gán dữ liệu cho DataGridView
			dataGridView1.DataSource = dataTable;

			// Đặt tiêu đề cho cột dựa trên trường hợp được chọn
			if (chkNgay.Checked)
			{
				dataGridView1.Columns[0].HeaderText = "Ngày";
				dataGridView1.Columns[1].HeaderText = "Doanh Thu Ngày";
			}
			if (chkTuan.Checked)
			{
				if (chkNgay.Checked)
				{
					dataGridView1.Columns[2].HeaderText = "Năm";
					dataGridView1.Columns[3].HeaderText = "Tuần";
					dataGridView1.Columns[4].HeaderText = "Doanh Thu Tuần";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tuần";
					dataGridView1.Columns[2].HeaderText = "Doanh Thu Tuần";
				}
			}
			if (chkThang.Checked)
			{
				if (chkNgay.Checked || chkTuan.Checked)
				{
					dataGridView1.Columns[5].HeaderText = "Năm";
					dataGridView1.Columns[6].HeaderText = "Tháng";
					dataGridView1.Columns[7].HeaderText = "Doanh Thu Tháng";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tháng";
					dataGridView1.Columns[2].HeaderText = "Doanh Thu Tháng";
				}
			}

			// Xóa các điểm cũ trên biểu đồ
			chart1.Series.Clear();

			// Hiển thị dữ liệu trên biểu đồ
			if (chkNgay.Checked)
			{
				// Tạo series cho biểu đồ doanh thu theo ngày
				Series seriesNgay = new Series("DoanhThuNgay");
				seriesNgay.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesNgay);

				// Lấy ngày nhỏ nhất và lớn nhất trong bảng hóa đơn
				DateTime ngayMin = dataTable.AsEnumerable().Select(row => row.Field<DateTime>("Ngay")).Min();
				DateTime ngayMax = dataTable.AsEnumerable().Select(row => row.Field<DateTime>("Ngay")).Max();

				// Tạo một khoảng thời gian từ ngày nhỏ nhất đến ngày lớn nhất
				for (DateTime date = ngayMin; date <= ngayMax; date = date.AddDays(1))
				{
					var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<DateTime>("Ngay") == date);
					double doanhThuNgay = row != null ? Convert.ToDouble(row["DoanhThuNgay"]) : 0;
					seriesNgay.Points.AddXY(date.ToString("dd/MM/yyyy"), doanhThuNgay);
				}
			}

			if (chkTuan.Checked)
			{
				// Tạo series cho biểu đồ doanh thu theo tuần
				Series seriesTuan = new Series("DoanhThuTuan");
				seriesTuan.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesTuan);

				// Lấy năm và tuần nhỏ nhất và lớn nhất trong bảng hóa đơn
				int namMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Min();
				int tuanMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Tuan")).Min();
				int namMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Max();
				int tuanMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Tuan")).Max();

				// Tạo khoảng thời gian từ tuần nhỏ nhất đến tuần lớn nhất
				for (int nam = namMin; nam <= namMax; nam++)
				{
					for (int tuan = tuanMin; tuan <= tuanMax; tuan++)
					{
						var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Nam") == nam && r.Field<int>("Tuan") == tuan);
						double doanhThuTuan = row != null ? Convert.ToDouble(row["DoanhThuTuan"]) : 0;
						seriesTuan.Points.AddXY($"Năm {nam} - Tuần {tuan}", doanhThuTuan);
					}
				}
			}

			if (chkThang.Checked)
			{
				// Tạo series cho biểu đồ doanh thu theo tháng
				Series seriesThang = new Series("DoanhThuThang");
				seriesThang.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesThang);

				// Lấy năm và tháng nhỏ nhất và lớn nhất trong bảng hóa đơn
				int namMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Min();
				int thangMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Thang")).Min();
				int namMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Max();
				int thangMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Thang")).Max();

				// Tạo khoảng thời gian từ tháng nhỏ nhất đến tháng lớn nhất
				for (int nam = namMin; nam <= namMax; nam++)
				{
					for (int thang = thangMin; thang <= thangMax; thang++)
					{
						var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Nam") == nam && r.Field<int>("Thang") == thang);
						double doanhThuThang = row != null ? Convert.ToDouble(row["DoanhThuThang"]) : 0;
						seriesThang.Points.AddXY($"Năm {nam} - Tháng {thang}", doanhThuThang);
					}
				}
			}
		}
		private void soluongbanra()
		{
			// Tạo truy vấn SQL để lấy số lượng sản phẩm bán ra theo ngày, tuần, và tháng dựa trên checkbox
			string query = "";

			// Trường hợp tính số lượng sản phẩm bán ra theo ngày
			if (chkNgay.Checked)
			{
				query += @"
        SELECT 
            CONVERT(DATE, NgayGio) AS Ngay, 
            SUM(SoLuong) AS SoLuongBanRaNgay
        FROM dbo.Tb_HoaDon
        GROUP BY CONVERT(DATE, NgayGio)
        ORDER BY Ngay";
			}

			// Trường hợp tính số lượng sản phẩm bán ra theo tuần
			if (chkTuan.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(ISO_WEEK, NgayGio) AS Tuan, 
            SUM(SoLuong) AS SoLuongBanRaTuan
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(ISO_WEEK, NgayGio)
        ORDER BY Nam, Tuan";
			}

			// Trường hợp tính số lượng sản phẩm bán ra theo tháng
			if (chkThang.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(MONTH, NgayGio) AS Thang, 
            SUM(SoLuong) AS SoLuongBanRaThang
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(MONTH, NgayGio)
        ORDER BY Nam, Thang";
			}

			// Nếu không có checkbox nào được chọn
			if (string.IsNullOrEmpty(query))
			{
				MessageBox.Show("Vui lòng chọn ít nhất một tùy chọn để tính số lượng sản phẩm bán ra.");
				return;
			}

			// Tạo DataTable để lưu dữ liệu số lượng sản phẩm
			DataTable dataTable = new DataTable();

			// Kết nối đến CSDL và thực thi truy vấn
			using (SqlConnection connection = ketnoisql.TaoKetNoi())
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						adapter.Fill(dataTable);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
					return;
				}
			}

			// Gán dữ liệu cho DataGridView
			dataGridView1.DataSource = dataTable;

			// Đặt tiêu đề cho cột dựa trên trường hợp được chọn
			if (chkNgay.Checked)
			{
				dataGridView1.Columns[0].HeaderText = "Ngày";
				dataGridView1.Columns[1].HeaderText = "Số Lượng Bán Ra (Ngày)";
			}
			if (chkTuan.Checked)
			{
				if (chkNgay.Checked)
				{
					dataGridView1.Columns[2].HeaderText = "Năm";
					dataGridView1.Columns[3].HeaderText = "Tuần";
					dataGridView1.Columns[4].HeaderText = "Số Lượng Bán Ra (Tuần)";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tuần";
					dataGridView1.Columns[2].HeaderText = "Số Lượng Bán Ra (Tuần)";
				}
			}
			if (chkThang.Checked)
			{
				if (chkNgay.Checked || chkTuan.Checked)
				{
					dataGridView1.Columns[5].HeaderText = "Năm";
					dataGridView1.Columns[6].HeaderText = "Tháng";
					dataGridView1.Columns[7].HeaderText = "Số Lượng Bán Ra (Tháng)";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tháng";
					dataGridView1.Columns[2].HeaderText = "Số Lượng Bán Ra (Tháng)";
				}
			}

			// Xóa các điểm cũ trên biểu đồ
			chart1.Series.Clear();

			// Hiển thị dữ liệu trên biểu đồ
			if (chkNgay.Checked)
			{
				// Tạo series cho biểu đồ số lượng bán ra theo ngày
				Series seriesNgay = new Series("SoLuongBanRaNgay");
				seriesNgay.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesNgay);

				// Lấy ngày nhỏ nhất và lớn nhất trong bảng hóa đơn
				DateTime ngayMin = dataTable.AsEnumerable().Select(row => row.Field<DateTime>("Ngay")).Min();
				DateTime ngayMax = dataTable.AsEnumerable().Select(row => row.Field<DateTime>("Ngay")).Max();

				// Tạo khoảng thời gian từ ngày nhỏ nhất đến ngày lớn nhất
				for (DateTime date = ngayMin; date <= ngayMax; date = date.AddDays(1))
				{
					var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<DateTime>("Ngay") == date);
					double soLuongBanRa = row != null ? Convert.ToDouble(row["SoLuongBanRaNgay"]) : 0;
					seriesNgay.Points.AddXY(date.ToString("dd/MM/yyyy"), soLuongBanRa);
				}
			}

			if (chkTuan.Checked)
			{
				// Tạo series cho biểu đồ số lượng bán ra theo tuần
				Series seriesTuan = new Series("SoLuongBanRaTuan");
				seriesTuan.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesTuan);

				// Lấy năm và tuần nhỏ nhất và lớn nhất trong bảng hóa đơn
				int namMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Min();
				int tuanMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Tuan")).Min();
				int namMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Max();
				int tuanMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Tuan")).Max();

				// Tạo khoảng thời gian từ tuần nhỏ nhất đến tuần lớn nhất
				for (int nam = namMin; nam <= namMax; nam++)
				{
					for (int tuan = tuanMin; tuan <= tuanMax; tuan++)
					{
						var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Nam") == nam && r.Field<int>("Tuan") == tuan);
						double soLuongBanRa = row != null ? Convert.ToDouble(row["SoLuongBanRaTuan"]) : 0;
						seriesTuan.Points.AddXY($"Năm {nam} - Tuần {tuan}", soLuongBanRa);
					}
				}
			}

			if (chkThang.Checked)
			{
				// Tạo series cho biểu đồ số lượng bán ra theo tháng
				Series seriesThang = new Series("SoLuongBanRaThang");
				seriesThang.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesThang);

				// Lấy năm và tháng nhỏ nhất và lớn nhất trong bảng hóa đơn
				int namMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Min();
				int thangMin = dataTable.AsEnumerable().Select(row => row.Field<int>("Thang")).Min();
				int namMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Nam")).Max();
				int thangMax = dataTable.AsEnumerable().Select(row => row.Field<int>("Thang")).Max();

				// Tạo khoảng thời gian từ tháng nhỏ nhất đến tháng lớn nhất
				for (int nam = namMin; nam <= namMax; nam++)
				{
					for (int thang = thangMin; thang <= thangMax; thang++)
					{
						var row = dataTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Nam") == nam && r.Field<int>("Thang") == thang);
						double soLuongBanRa = row != null ? Convert.ToDouble(row["SoLuongBanRaThang"]) : 0;
						seriesThang.Points.AddXY($"Năm {nam} - Tháng {thang}", soLuongBanRa);
					}
				}
			}
		}
		private void soluongdonhang()
		{
			// Tạo truy vấn SQL để lấy số lượng đơn hàng theo ngày, tuần, và tháng dựa trên checkbox
			string query = "";

			// Trường hợp tính số lượng đơn hàng theo ngày
			if (chkNgay.Checked)
			{
				query += @"
        SELECT 
            CONVERT(DATE, NgayGio) AS Ngay, 
            COUNT(MaHD) AS SoLuongDonHangNgay
        FROM dbo.Tb_HoaDon
        GROUP BY CONVERT(DATE, NgayGio)
        ORDER BY Ngay";
			}

			// Trường hợp tính số lượng đơn hàng theo tuần
			if (chkTuan.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(ISO_WEEK, NgayGio) AS Tuan, 
            COUNT(MaHD) AS SoLuongDonHangTuan
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(ISO_WEEK, NgayGio)
        ORDER BY Nam, Tuan";
			}

			// Trường hợp tính số lượng đơn hàng theo tháng
			if (chkThang.Checked)
			{
				if (!string.IsNullOrEmpty(query)) query += " UNION ALL ";
				query += @"
        SELECT 
            DATEPART(YEAR, NgayGio) AS Nam, 
            DATEPART(MONTH, NgayGio) AS Thang, 
            COUNT(MaHD) AS SoLuongDonHangThang
        FROM dbo.Tb_HoaDon
        GROUP BY DATEPART(YEAR, NgayGio), DATEPART(MONTH, NgayGio)
        ORDER BY Nam, Thang";
			}

			// Nếu không có checkbox nào được chọn
			if (string.IsNullOrEmpty(query))
			{
				MessageBox.Show("Vui lòng chọn ít nhất một tùy chọn để tính số lượng đơn hàng.");
				return;
			}

			// Tạo DataTable để lưu dữ liệu số lượng đơn hàng
			DataTable dataTable = new DataTable();

			// Kết nối đến CSDL và thực thi truy vấn
			using (SqlConnection connection = ketnoisql.TaoKetNoi())
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						adapter.Fill(dataTable);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
					return;
				}
			}

			// Gán dữ liệu cho DataGridView
			dataGridView1.DataSource = dataTable;

			// Đặt tiêu đề cho cột dựa trên trường hợp được chọn
			if (chkNgay.Checked)
			{
				dataGridView1.Columns[0].HeaderText = "Ngày";
				dataGridView1.Columns[1].HeaderText = "Số Lượng Đơn Hàng (Ngày)";
			}
			if (chkTuan.Checked)
			{
				if (chkNgay.Checked)
				{
					dataGridView1.Columns[2].HeaderText = "Năm";
					dataGridView1.Columns[3].HeaderText = "Tuần";
					dataGridView1.Columns[4].HeaderText = "Số Lượng Đơn Hàng (Tuần)";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tuần";
					dataGridView1.Columns[2].HeaderText = "Số Lượng Đơn Hàng (Tuần)";
				}
			}
			if (chkThang.Checked)
			{
				if (chkNgay.Checked || chkTuan.Checked)
				{
					dataGridView1.Columns[5].HeaderText = "Năm";
					dataGridView1.Columns[6].HeaderText = "Tháng";
					dataGridView1.Columns[7].HeaderText = "Số Lượng Đơn Hàng (Tháng)";
				}
				else
				{
					dataGridView1.Columns[0].HeaderText = "Năm";
					dataGridView1.Columns[1].HeaderText = "Tháng";
					dataGridView1.Columns[2].HeaderText = "Số Lượng Đơn Hàng (Tháng)";
				}
			}

			// Xóa các điểm cũ trên biểu đồ
			chart1.Series.Clear();

			// Hiển thị dữ liệu trên biểu đồ
			if (chkNgay.Checked)
			{
				// Tạo series cho biểu đồ số lượng đơn hàng theo ngày
				Series seriesNgay = new Series("SoLuongDonHangNgay");
				seriesNgay.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesNgay);

				// Hiển thị dữ liệu cho từng ngày
				foreach (DataRow row in dataTable.Rows)
				{
					string ngay = ((DateTime)row["Ngay"]).ToString("dd/MM/yyyy");
					double soLuongDonHang = Convert.ToDouble(row["SoLuongDonHangNgay"]);
					seriesNgay.Points.AddXY(ngay, soLuongDonHang);
				}
			}

			if (chkTuan.Checked)
			{
				// Tạo series cho biểu đồ số lượng đơn hàng theo tuần
				Series seriesTuan = new Series("SoLuongDonHangTuan");
				seriesTuan.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesTuan);

				// Hiển thị dữ liệu cho từng tuần
				foreach (DataRow row in dataTable.Rows)
				{
					string tuan = $"Năm {row["Nam"]} - Tuần {row["Tuan"]}";
					double soLuongDonHang = Convert.ToDouble(row["SoLuongDonHangTuan"]);
					seriesTuan.Points.AddXY(tuan, soLuongDonHang);
				}
			}

			if (chkThang.Checked)
			{
				// Tạo series cho biểu đồ số lượng đơn hàng theo tháng
				Series seriesThang = new Series("SoLuongDonHangThang");
				seriesThang.ChartType = SeriesChartType.Column;
				chart1.Series.Add(seriesThang);

				// Hiển thị dữ liệu cho từng tháng
				foreach (DataRow row in dataTable.Rows)
				{
					string thang = $"Năm {row["Nam"]} - Tháng {row["Thang"]}";
					double soLuongDonHang = Convert.ToDouble(row["SoLuongDonHangThang"]);
					seriesThang.Points.AddXY(thang, soLuongDonHang);
				}
			}
		}

	}
}
