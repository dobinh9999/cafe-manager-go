namespace ql_cafe_bia
{
	partial class HoaDonSP
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnload = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnmohoadon = new System.Windows.Forms.Button();
			this.btnhuy = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtngaytao = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txttenvoicher = new System.Windows.Forms.TextBox();
			this.txttongtien = new System.Windows.Forms.TextBox();
			this.txttenkh = new System.Windows.Forms.TextBox();
			this.txtdtl = new System.Windows.Forms.TextBox();
			this.txtmahd = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemTichLuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet3 = new ql_cafe_bia.CAFE_AND_BIDADataSet3();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_HoaDonTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSet3TableAdapters.Tb_HoaDonTableAdapter();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHoaDonBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.btnload);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnmohoadon);
			this.groupBox3.Controls.Add(this.btnhuy);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Location = new System.Drawing.Point(13, 505);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(477, 307);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức Năng";
			// 
			// btnload
			// 
			this.btnload.Location = new System.Drawing.Point(262, 224);
			this.btnload.Margin = new System.Windows.Forms.Padding(4);
			this.btnload.Name = "btnload";
			this.btnload.Size = new System.Drawing.Size(165, 49);
			this.btnload.TabIndex = 0;
			this.btnload.Text = "Reset";
			this.btnload.UseVisualStyleBackColor = true;
			this.btnload.Click += new System.EventHandler(this.btnload_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(48, 224);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(165, 49);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa ";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnmohoadon
			// 
			this.btnmohoadon.Location = new System.Drawing.Point(48, 128);
			this.btnmohoadon.Margin = new System.Windows.Forms.Padding(4);
			this.btnmohoadon.Name = "btnmohoadon";
			this.btnmohoadon.Size = new System.Drawing.Size(165, 49);
			this.btnmohoadon.TabIndex = 0;
			this.btnmohoadon.Text = "Mở hóa đơn";
			this.btnmohoadon.UseVisualStyleBackColor = true;
			this.btnmohoadon.Click += new System.EventHandler(this.btnmohoadon_Click);
			// 
			// btnhuy
			// 
			this.btnhuy.Location = new System.Drawing.Point(262, 128);
			this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(165, 49);
			this.btnhuy.TabIndex = 0;
			this.btnhuy.Text = "Hủy";
			this.btnhuy.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(48, 49);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(165, 49);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(262, 49);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(165, 49);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtngaytao);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txttenvoicher);
			this.groupBox2.Controls.Add(this.txttongtien);
			this.groupBox2.Controls.Add(this.txttenkh);
			this.groupBox2.Controls.Add(this.txtdtl);
			this.groupBox2.Controls.Add(this.txtmahd);
			this.groupBox2.Controls.Add(this.txtSoLuong);
			this.groupBox2.Location = new System.Drawing.Point(13, 13);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(478, 472);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức Năng";
			// 
			// txtngaytao
			// 
			this.txtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtngaytao.Location = new System.Drawing.Point(86, 181);
			this.txtngaytao.Name = "txtngaytao";
			this.txtngaytao.Size = new System.Drawing.Size(186, 22);
			this.txtngaytao.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(81, 286);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "Tên Voicher";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 418);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tổng Tiền";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(80, 100);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tên Khách Hàng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(83, 224);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Điểm Tích Lũy";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(84, 162);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ngày Tạo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 345);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số Lượng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mã Hóa Đơn";
			// 
			// txttenvoicher
			// 
			this.txttenvoicher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenvoicher.Location = new System.Drawing.Point(86, 315);
			this.txttenvoicher.Margin = new System.Windows.Forms.Padding(4);
			this.txttenvoicher.Name = "txttenvoicher";
			this.txttenvoicher.Size = new System.Drawing.Size(295, 26);
			this.txttenvoicher.TabIndex = 1;
			// 
			// txttongtien
			// 
			this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttongtien.Location = new System.Drawing.Point(83, 438);
			this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
			this.txttongtien.Name = "txttongtien";
			this.txttongtien.Size = new System.Drawing.Size(295, 26);
			this.txttongtien.TabIndex = 1;
			// 
			// txttenkh
			// 
			this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenkh.Location = new System.Drawing.Point(83, 120);
			this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
			this.txttenkh.Name = "txttenkh";
			this.txttenkh.Size = new System.Drawing.Size(295, 26);
			this.txttenkh.TabIndex = 1;
			// 
			// txtdtl
			// 
			this.txtdtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdtl.Location = new System.Drawing.Point(86, 244);
			this.txtdtl.Margin = new System.Windows.Forms.Padding(4);
			this.txtdtl.Name = "txtdtl";
			this.txtdtl.Size = new System.Drawing.Size(295, 26);
			this.txtdtl.TabIndex = 1;
			// 
			// txtmahd
			// 
			this.txtmahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmahd.Location = new System.Drawing.Point(83, 51);
			this.txtmahd.Margin = new System.Windows.Forms.Padding(4);
			this.txtmahd.Name = "txtmahd";
			this.txtmahd.Size = new System.Drawing.Size(295, 26);
			this.txtmahd.TabIndex = 1;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(83, 365);
			this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(295, 26);
			this.txtSoLuong.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvHoaDon);
			this.groupBox1.Location = new System.Drawing.Point(499, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(771, 805);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sản Phẩm ";
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.AutoGenerateColumns = false;
			this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvHoaDon.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.ngayGioDataGridViewTextBoxColumn,
            this.diemTichLuyDataGridViewTextBoxColumn,
            this.tenVCDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
			this.dgvHoaDon.DataSource = this.tbHoaDonBindingSource;
			this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHoaDon.GridColor = System.Drawing.Color.IndianRed;
			this.dgvHoaDon.Location = new System.Drawing.Point(4, 19);
			this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.ShowRowErrors = false;
			this.dgvHoaDon.Size = new System.Drawing.Size(763, 782);
			this.dgvHoaDon.TabIndex = 2;
			this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
			// 
			// maHDDataGridViewTextBoxColumn
			// 
			this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
			this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
			this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
			this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tenKHDataGridViewTextBoxColumn
			// 
			this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
			this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
			this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
			// 
			// ngayGioDataGridViewTextBoxColumn
			// 
			this.ngayGioDataGridViewTextBoxColumn.DataPropertyName = "NgayGio";
			this.ngayGioDataGridViewTextBoxColumn.HeaderText = "NgayGio";
			this.ngayGioDataGridViewTextBoxColumn.Name = "ngayGioDataGridViewTextBoxColumn";
			// 
			// diemTichLuyDataGridViewTextBoxColumn
			// 
			this.diemTichLuyDataGridViewTextBoxColumn.DataPropertyName = "DiemTichLuy";
			this.diemTichLuyDataGridViewTextBoxColumn.HeaderText = "DiemTichLuy";
			this.diemTichLuyDataGridViewTextBoxColumn.Name = "diemTichLuyDataGridViewTextBoxColumn";
			// 
			// tenVCDataGridViewTextBoxColumn
			// 
			this.tenVCDataGridViewTextBoxColumn.DataPropertyName = "TenVC";
			this.tenVCDataGridViewTextBoxColumn.HeaderText = "TenVC";
			this.tenVCDataGridViewTextBoxColumn.Name = "tenVCDataGridViewTextBoxColumn";
			// 
			// soLuongDataGridViewTextBoxColumn
			// 
			this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
			this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
			this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
			// 
			// tongTienDataGridViewTextBoxColumn
			// 
			this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
			this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
			this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
			// 
			// tbHoaDonBindingSource
			// 
			this.tbHoaDonBindingSource.DataMember = "Tb_HoaDon";
			this.tbHoaDonBindingSource.DataSource = this.cAFE_AND_BIDADataSet3;
			// 
			// cAFE_AND_BIDADataSet3
			// 
			this.cAFE_AND_BIDADataSet3.DataSetName = "CAFE_AND_BIDADataSet3";
			this.cAFE_AND_BIDADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 89);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 13;
			// 
			// tb_HoaDonTableAdapter
			// 
			this.tb_HoaDonTableAdapter.ClearBeforeFill = true;
			// 
			// HoaDonSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1283, 825);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "HoaDonSP";
			this.Text = "HoaDonSP";
			this.Load += new System.EventHandler(this.HoaDonSP_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHoaDonBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnload;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnmohoadon;
		private System.Windows.Forms.Button btnhuy;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtdtl;
		private System.Windows.Forms.TextBox txtmahd;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvHoaDon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txttenvoicher;
		private System.Windows.Forms.TextBox txttongtien;
		private System.Windows.Forms.DateTimePicker txtngaytao;
		private CAFE_AND_BIDADataSet3 cAFE_AND_BIDADataSet3;
		private System.Windows.Forms.BindingSource tbHoaDonBindingSource;
		private CAFE_AND_BIDADataSet3TableAdapters.Tb_HoaDonTableAdapter tb_HoaDonTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayGioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenVCDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txttenkh;
	}
}