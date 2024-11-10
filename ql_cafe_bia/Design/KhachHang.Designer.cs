namespace ql_cafe_bia
{
    partial class KhachHang
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
			this.btnluu = new System.Windows.Forms.Button();
			this.btnhuy = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txttongchitieu = new System.Windows.Forms.TextBox();
			this.txtdtl = new System.Windows.Forms.TextBox();
			this.txtsdt = new System.Windows.Forms.TextBox();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemTichLuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tongChiTieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet2 = new ql_cafe_bia.CAFE_AND_BIDADataSet2();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_KhachHangTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSet2TableAdapters.Tb_KhachHangTableAdapter();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKhachHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.btnload);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnluu);
			this.groupBox3.Controls.Add(this.btnhuy);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Location = new System.Drawing.Point(13, 445);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 231);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức Năng";
			// 
			// btnload
			// 
			this.btnload.Location = new System.Drawing.Point(186, 165);
			this.btnload.Name = "btnload";
			this.btnload.Size = new System.Drawing.Size(137, 48);
			this.btnload.TabIndex = 0;
			this.btnload.Text = "Reset";
			this.btnload.UseVisualStyleBackColor = true;
			this.btnload.Click += new System.EventHandler(this.btnload_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(25, 165);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(137, 48);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa ";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(25, 96);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(137, 48);
			this.btnluu.TabIndex = 0;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
			// 
			// btnhuy
			// 
			this.btnhuy.Location = new System.Drawing.Point(186, 96);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(137, 48);
			this.btnhuy.TabIndex = 0;
			this.btnhuy.Text = "Hủy";
			this.btnhuy.UseVisualStyleBackColor = true;
			this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(25, 42);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(137, 48);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(186, 42);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(137, 48);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txttongchitieu);
			this.groupBox2.Controls.Add(this.txtdtl);
			this.groupBox2.Controls.Add(this.txtsdt);
			this.groupBox2.Controls.Add(this.txtTenKH);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(359, 427);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(61, 337);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tổng Chi Tiêu";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Điểm Tích Lũy";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên Khách Hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số Điện Thoại";
			// 
			// txttongchitieu
			// 
			this.txttongchitieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttongchitieu.Location = new System.Drawing.Point(65, 360);
			this.txttongchitieu.Name = "txttongchitieu";
			this.txttongchitieu.Size = new System.Drawing.Size(222, 26);
			this.txttongchitieu.TabIndex = 1;
			// 
			// txtdtl
			// 
			this.txtdtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdtl.Location = new System.Drawing.Point(65, 260);
			this.txtdtl.Name = "txtdtl";
			this.txtdtl.Size = new System.Drawing.Size(222, 26);
			this.txtdtl.TabIndex = 1;
			// 
			// txtsdt
			// 
			this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsdt.Location = new System.Drawing.Point(65, 85);
			this.txtsdt.Name = "txtsdt";
			this.txtsdt.Size = new System.Drawing.Size(222, 26);
			this.txtsdt.TabIndex = 1;
			// 
			// txtTenKH
			// 
			this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKH.Location = new System.Drawing.Point(65, 167);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(222, 26);
			this.txtTenKH.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvKhachHang);
			this.groupBox1.Location = new System.Drawing.Point(377, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(740, 664);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sản Phẩm ";
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.AutoGenerateColumns = false;
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvKhachHang.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDTDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.diemTichLuyDataGridViewTextBoxColumn,
            this.tongChiTieuDataGridViewTextBoxColumn});
			this.dgvKhachHang.DataSource = this.tbKhachHangBindingSource;
			this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKhachHang.GridColor = System.Drawing.Color.IndianRed;
			this.dgvKhachHang.Location = new System.Drawing.Point(3, 22);
			this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.ShowRowErrors = false;
			this.dgvKhachHang.Size = new System.Drawing.Size(734, 639);
			this.dgvKhachHang.TabIndex = 2;
			this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
			// 
			// sDTDataGridViewTextBoxColumn
			// 
			this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
			this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
			this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
			// 
			// tenKHDataGridViewTextBoxColumn
			// 
			this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
			this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
			this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
			// 
			// diemTichLuyDataGridViewTextBoxColumn
			// 
			this.diemTichLuyDataGridViewTextBoxColumn.DataPropertyName = "DiemTichLuy";
			this.diemTichLuyDataGridViewTextBoxColumn.HeaderText = "DiemTichLuy";
			this.diemTichLuyDataGridViewTextBoxColumn.Name = "diemTichLuyDataGridViewTextBoxColumn";
			// 
			// tongChiTieuDataGridViewTextBoxColumn
			// 
			this.tongChiTieuDataGridViewTextBoxColumn.DataPropertyName = "TongChiTieu";
			this.tongChiTieuDataGridViewTextBoxColumn.HeaderText = "TongChiTieu";
			this.tongChiTieuDataGridViewTextBoxColumn.Name = "tongChiTieuDataGridViewTextBoxColumn";
			// 
			// tbKhachHangBindingSource
			// 
			this.tbKhachHangBindingSource.DataMember = "Tb_KhachHang";
			this.tbKhachHangBindingSource.DataSource = this.cAFE_AND_BIDADataSet2;
			// 
			// cAFE_AND_BIDADataSet2
			// 
			this.cAFE_AND_BIDADataSet2.DataSetName = "CAFE_AND_BIDADataSet2";
			this.cAFE_AND_BIDADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 9;
			// 
			// tb_KhachHangTableAdapter
			// 
			this.tb_KhachHangTableAdapter.ClearBeforeFill = true;
			// 
			// KhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1129, 688);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "KhachHang";
			this.Text = "KhachHang";
			this.Load += new System.EventHandler(this.KhachHang_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKhachHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttongchitieu;
        private System.Windows.Forms.TextBox txtdtl;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
		private CAFE_AND_BIDADataSet2 cAFE_AND_BIDADataSet2;
		private System.Windows.Forms.BindingSource tbKhachHangBindingSource;
		private CAFE_AND_BIDADataSet2TableAdapters.Tb_KhachHangTableAdapter tb_KhachHangTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tongChiTieuDataGridViewTextBoxColumn;
	}
}