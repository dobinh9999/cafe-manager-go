namespace ql_cafe_bia
{
    partial class HoaDon
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.datagviewHoaDon = new System.Windows.Forms.DataGridView();
			this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbldtl = new System.Windows.Forms.Label();
			this.lbltongtien = new System.Windows.Forms.Label();
			this.lbltongtienthanhtoan = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.lbldtlnhanduoc = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lblsdt = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.lbltenkh = new System.Windows.Forms.Label();
			this.cbbvoicher = new System.Windows.Forms.ComboBox();
			this.txtngaytao = new System.Windows.Forms.DateTimePicker();
			this.tb_HoaDonTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_HoaDonTableAdapter();
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.cbbtenvoicher = new System.Windows.Forms.ComboBox();
			this.btninhoadon = new System.Windows.Forms.Button();
			this.lbltongtien1 = new System.Windows.Forms.Label();
			this.btnluu = new System.Windows.Forms.Button();
			this.lbltongtienthanhtoan1 = new System.Windows.Forms.Label();
			this.tbHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cbbdtl = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.datagviewHoaDon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHoaDonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(233, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "CaFe and BiDa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(234, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "   Địa Chỉ : số 30 Bà Triệu , \r\nPhường Nam Định,Tỉnh Việt Nam ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(219, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(251, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "ĐT : 0333555999   -   0666888999";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(218, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Hóa Đơn Thanh Toán";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 243);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Điểm tích lũy hiện tại";
			// 
			// datagviewHoaDon
			// 
			this.datagviewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagviewHoaDon.BackgroundColor = System.Drawing.Color.Tan;
			this.datagviewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagviewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.GiaSP,
            this.SoLuong,
            this.TongTien});
			this.datagviewHoaDon.Location = new System.Drawing.Point(17, 303);
			this.datagviewHoaDon.Name = "datagviewHoaDon";
			this.datagviewHoaDon.Size = new System.Drawing.Size(683, 288);
			this.datagviewHoaDon.TabIndex = 2;
			this.datagviewHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagviewHoaDon_CellContentClick);
			// 
			// TenSP
			// 
			this.TenSP.HeaderText = "Tên Sản Phẩm";
			this.TenSP.Name = "TenSP";
			// 
			// GiaSP
			// 
			this.GiaSP.HeaderText = "Giá Sản Phẩm";
			this.GiaSP.Name = "GiaSP";
			// 
			// SoLuong
			// 
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.Name = "SoLuong";
			// 
			// TongTien
			// 
			this.TongTien.HeaderText = "Tổng Tiền";
			this.TongTien.Name = "TongTien";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 698);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(694, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 770);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(207, 24);
			this.label8.TabIndex = 3;
			this.label8.Text = "Tổng Tiền Thanh Toán";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 594);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 24);
			this.label9.TabIndex = 3;
			this.label9.Text = "Tổng Tiền";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(9, 641);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(193, 24);
			this.label10.TabIndex = 3;
			this.label10.Text = "Sử dụng điểm tích lũy";
			// 
			// lbldtl
			// 
			this.lbldtl.AutoSize = true;
			this.lbldtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbldtl.Location = new System.Drawing.Point(515, 243);
			this.lbldtl.Name = "lbldtl";
			this.lbldtl.Size = new System.Drawing.Size(43, 24);
			this.lbldtl.TabIndex = 1;
			this.lbldtl.Text = "Null";
			// 
			// lbltongtien
			// 
			this.lbltongtien.AutoSize = true;
			this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltongtien.Location = new System.Drawing.Point(506, 594);
			this.lbltongtien.Name = "lbltongtien";
			this.lbltongtien.Size = new System.Drawing.Size(98, 24);
			this.lbltongtien.TabIndex = 3;
			this.lbltongtien.Text = "Tổng Tiền";
			// 
			// lbltongtienthanhtoan
			// 
			this.lbltongtienthanhtoan.AutoSize = true;
			this.lbltongtienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltongtienthanhtoan.Location = new System.Drawing.Point(506, 770);
			this.lbltongtienthanhtoan.Name = "lbltongtienthanhtoan";
			this.lbltongtienthanhtoan.Size = new System.Drawing.Size(43, 24);
			this.lbltongtienthanhtoan.TabIndex = 3;
			this.lbltongtienthanhtoan.Text = "Null";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(440, 815);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 43);
			this.button1.TabIndex = 4;
			this.button1.Text = "Tính Tiền";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnthoat.Location = new System.Drawing.Point(593, 815);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(113, 43);
			this.btnthoat.TabIndex = 4;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(12, 676);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(162, 24);
			this.label16.TabIndex = 3;
			this.label16.Text = "Sử Dụng Voucher\r\n";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(20, 210);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(92, 24);
			this.label18.TabIndex = 1;
			this.label18.Text = "Ngày Tạo";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(13, 618);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(694, 24);
			this.label20.TabIndex = 3;
			this.label20.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(13, 722);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(214, 24);
			this.label21.TabIndex = 1;
			this.label21.Text = "Điểm tích lũy nhận được";
			// 
			// lbldtlnhanduoc
			// 
			this.lbldtlnhanduoc.AutoSize = true;
			this.lbldtlnhanduoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbldtlnhanduoc.Location = new System.Drawing.Point(506, 722);
			this.lbldtlnhanduoc.Name = "lbldtlnhanduoc";
			this.lbldtlnhanduoc.Size = new System.Drawing.Size(0, 24);
			this.lbldtlnhanduoc.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 746);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(694, 24);
			this.label6.TabIndex = 3;
			this.label6.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(20, 276);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(224, 24);
			this.label12.TabIndex = 3;
			this.label12.Text = "Sử dụng voucher hiện có\r\n";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(20, 177);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(130, 24);
			this.label24.TabIndex = 1;
			this.label24.Text = "Số Điện Thoại\r\n";
			// 
			// lblsdt
			// 
			this.lblsdt.AutoSize = true;
			this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsdt.Location = new System.Drawing.Point(515, 177);
			this.lblsdt.Name = "lblsdt";
			this.lblsdt.Size = new System.Drawing.Size(43, 24);
			this.lblsdt.TabIndex = 1;
			this.lblsdt.Text = "Null";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(20, 144);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(154, 24);
			this.label26.TabIndex = 1;
			this.label26.Text = "Tên Khách Hàng";
			// 
			// lbltenkh
			// 
			this.lbltenkh.AutoSize = true;
			this.lbltenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltenkh.Location = new System.Drawing.Point(515, 144);
			this.lbltenkh.Name = "lbltenkh";
			this.lbltenkh.Size = new System.Drawing.Size(43, 24);
			this.lbltenkh.TabIndex = 1;
			this.lbltenkh.Text = "Null";
			// 
			// cbbvoicher
			// 
			this.cbbvoicher.FormattingEnabled = true;
			this.cbbvoicher.Location = new System.Drawing.Point(506, 672);
			this.cbbvoicher.Name = "cbbvoicher";
			this.cbbvoicher.Size = new System.Drawing.Size(182, 28);
			this.cbbvoicher.TabIndex = 5;
			// 
			// txtngaytao
			// 
			this.txtngaytao.CalendarMonthBackground = System.Drawing.Color.Tan;
			this.txtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtngaytao.Location = new System.Drawing.Point(514, 208);
			this.txtngaytao.Name = "txtngaytao";
			this.txtngaytao.Size = new System.Drawing.Size(178, 26);
			this.txtngaytao.TabIndex = 7;
			// 
			// tb_HoaDonTableAdapter
			// 
			this.tb_HoaDonTableAdapter.ClearBeforeFill = true;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cbbtenvoicher
			// 
			this.cbbtenvoicher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbtenvoicher.FormattingEnabled = true;
			this.cbbtenvoicher.Location = new System.Drawing.Point(514, 269);
			this.cbbtenvoicher.Name = "cbbtenvoicher";
			this.cbbtenvoicher.Size = new System.Drawing.Size(178, 28);
			this.cbbtenvoicher.TabIndex = 5;
			this.cbbtenvoicher.SelectedIndexChanged += new System.EventHandler(this.cbbtenvoicher_SelectedIndexChanged);
			// 
			// btninhoadon
			// 
			this.btninhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btninhoadon.Location = new System.Drawing.Point(24, 815);
			this.btninhoadon.Name = "btninhoadon";
			this.btninhoadon.Size = new System.Drawing.Size(113, 43);
			this.btninhoadon.TabIndex = 4;
			this.btninhoadon.Text = "In Hóa Đơn";
			this.btninhoadon.UseVisualStyleBackColor = true;
			this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
			// 
			// lbltongtien1
			// 
			this.lbltongtien1.AutoSize = true;
			this.lbltongtien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltongtien1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.lbltongtien1.Location = new System.Drawing.Point(610, 594);
			this.lbltongtien1.Name = "lbltongtien1";
			this.lbltongtien1.Size = new System.Drawing.Size(98, 24);
			this.lbltongtien1.TabIndex = 3;
			this.lbltongtien1.Text = "Tổng Tiền";
			// 
			// btnluu
			// 
			this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnluu.Location = new System.Drawing.Point(286, 815);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(113, 43);
			this.btnluu.TabIndex = 4;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
			// 
			// lbltongtienthanhtoan1
			// 
			this.lbltongtienthanhtoan1.AutoSize = true;
			this.lbltongtienthanhtoan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltongtienthanhtoan1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbltongtienthanhtoan1.Location = new System.Drawing.Point(633, 770);
			this.lbltongtienthanhtoan1.Name = "lbltongtienthanhtoan1";
			this.lbltongtienthanhtoan1.Size = new System.Drawing.Size(43, 24);
			this.lbltongtienthanhtoan1.TabIndex = 3;
			this.lbltongtienthanhtoan1.Text = "Null";
			// 
			// tbHoaDonBindingSource
			// 
			this.tbHoaDonBindingSource.DataMember = "Tb_HoaDon";
			// 
			// cbbdtl
			// 
			this.cbbdtl.Location = new System.Drawing.Point(506, 639);
			this.cbbdtl.Name = "cbbdtl";
			this.cbbdtl.Size = new System.Drawing.Size(182, 26);
			this.cbbdtl.TabIndex = 8;
			// 
			// HoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(711, 860);
			this.Controls.Add(this.cbbdtl);
			this.Controls.Add(this.txtngaytao);
			this.Controls.Add(this.cbbtenvoicher);
			this.Controls.Add(this.cbbvoicher);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btninhoadon);
			this.Controls.Add(this.btnluu);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.lbltongtien1);
			this.Controls.Add(this.lbltongtien);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbltongtienthanhtoan1);
			this.Controls.Add(this.lbltongtienthanhtoan);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.datagviewHoaDon);
			this.Controls.Add(this.lbldtlnhanduoc);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.lbltenkh);
			this.Controls.Add(this.lblsdt);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.lbldtl);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "HoaDon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hóa Đơn";
			this.Load += new System.EventHandler(this.HoaDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.datagviewHoaDon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHoaDonBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView datagviewHoaDon;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbldtl;
		private System.Windows.Forms.Label lbltongtien;
		private System.Windows.Forms.Label lbltongtienthanhtoan;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnthoat;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lbldtlnhanduoc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lblsdt;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label lbltenkh;
		private System.Windows.Forms.ComboBox cbbvoicher;
		private System.Windows.Forms.DateTimePicker txtngaytao;
		private CAFE_AND_BIDADataSetTableAdapters.Tb_HoaDonTableAdapter tb_HoaDonTableAdapter;
		private System.Windows.Forms.BindingSource tbHoaDonBindingSource;
		private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
		private System.Windows.Forms.ComboBox cbbtenvoicher;
		private System.Windows.Forms.Button btninhoadon;
		private System.Windows.Forms.Label lbltongtien1;
		private System.Windows.Forms.Button btnluu;
		private System.Windows.Forms.Label lbltongtienthanhtoan1;
		private System.Windows.Forms.TextBox cbbdtl;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiaSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
	}
}