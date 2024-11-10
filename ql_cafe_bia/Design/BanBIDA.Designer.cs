namespace ql_cafe_bia
{
	partial class BanBIDA
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
			this.txttrangthai = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtban = new System.Windows.Forms.TextBox();
			this.txtmaloai = new System.Windows.Forms.TextBox();
			this.txtmaban = new System.Windows.Forms.TextBox();
			this.txtslgay = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvbanbida = new System.Windows.Forms.DataGridView();
			this.tbBanBIDABindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_BanBIDATableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_BanBIDATableAdapter();
			this.txtslbi = new System.Windows.Forms.TextBox();
			this.maBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sLbiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sLgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvbanbida)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBanBIDABindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).BeginInit();
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
			this.groupBox3.Location = new System.Drawing.Point(13, 480);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(464, 309);
			this.groupBox3.TabIndex = 24;
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
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(48, 128);
			this.btnluu.Margin = new System.Windows.Forms.Padding(4);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(165, 49);
			this.btnluu.TabIndex = 0;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = true;
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
			this.groupBox2.Controls.Add(this.txttrangthai);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtban);
			this.groupBox2.Controls.Add(this.txtmaloai);
			this.groupBox2.Controls.Add(this.txtmaban);
			this.groupBox2.Controls.Add(this.txtslbi);
			this.groupBox2.Controls.Add(this.txtslgay);
			this.groupBox2.Location = new System.Drawing.Point(13, 11);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(465, 449);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// txttrangthai
			// 
			this.txttrangthai.FormattingEnabled = true;
			this.txttrangthai.Items.AddRange(new object[] {
            "Tốt",
            "Hỏng"});
			this.txttrangthai.Location = new System.Drawing.Point(87, 400);
			this.txttrangthai.Name = "txttrangthai";
			this.txttrangthai.Size = new System.Drawing.Size(291, 28);
			this.txttrangthai.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(87, 381);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Trạng Thái";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(83, 237);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Số Lượng Bi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(80, 100);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tên Bàn";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(83, 168);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Mã Loại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 315);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số Lượng Gây";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mã Bàn";
			// 
			// txtban
			// 
			this.txtban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtban.Location = new System.Drawing.Point(83, 120);
			this.txtban.Margin = new System.Windows.Forms.Padding(4);
			this.txtban.Name = "txtban";
			this.txtban.Size = new System.Drawing.Size(295, 26);
			this.txtban.TabIndex = 1;
			// 
			// txtmaloai
			// 
			this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaloai.Location = new System.Drawing.Point(86, 188);
			this.txtmaloai.Margin = new System.Windows.Forms.Padding(4);
			this.txtmaloai.Name = "txtmaloai";
			this.txtmaloai.Size = new System.Drawing.Size(295, 26);
			this.txtmaloai.TabIndex = 1;
			// 
			// txtmaban
			// 
			this.txtmaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaban.Location = new System.Drawing.Point(83, 51);
			this.txtmaban.Margin = new System.Windows.Forms.Padding(4);
			this.txtmaban.Name = "txtmaban";
			this.txtmaban.Size = new System.Drawing.Size(295, 26);
			this.txtmaban.TabIndex = 1;
			// 
			// txtslgay
			// 
			this.txtslgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtslgay.Location = new System.Drawing.Point(87, 335);
			this.txtslgay.Margin = new System.Windows.Forms.Padding(4);
			this.txtslgay.Name = "txtslgay";
			this.txtslgay.Size = new System.Drawing.Size(295, 26);
			this.txtslgay.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvbanbida);
			this.groupBox1.Location = new System.Drawing.Point(486, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(770, 776);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bàn BiDa";
			// 
			// dgvbanbida
			// 
			this.dgvbanbida.AutoGenerateColumns = false;
			this.dgvbanbida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvbanbida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvbanbida.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvbanbida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvbanbida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvbanbida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBanDataGridViewTextBoxColumn,
            this.tenBanDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.sLbiDataGridViewTextBoxColumn,
            this.sLgayDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
			this.dgvbanbida.DataSource = this.tbBanBIDABindingSource;
			this.dgvbanbida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvbanbida.GridColor = System.Drawing.Color.IndianRed;
			this.dgvbanbida.Location = new System.Drawing.Point(4, 23);
			this.dgvbanbida.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvbanbida.Name = "dgvbanbida";
			this.dgvbanbida.ShowRowErrors = false;
			this.dgvbanbida.Size = new System.Drawing.Size(762, 749);
			this.dgvbanbida.TabIndex = 2;
			this.dgvbanbida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbanbida_CellClick);
			// 
			// tbBanBIDABindingSource
			// 
			this.tbBanBIDABindingSource.DataMember = "Tb_BanBIDA";
			this.tbBanBIDABindingSource.DataSource = this.cAFE_AND_BIDADataSet;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 21;
			// 
			// tb_BanBIDATableAdapter
			// 
			this.tb_BanBIDATableAdapter.ClearBeforeFill = true;
			// 
			// txtslbi
			// 
			this.txtslbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtslbi.Location = new System.Drawing.Point(87, 261);
			this.txtslbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtslbi.Name = "txtslbi";
			this.txtslbi.Size = new System.Drawing.Size(295, 26);
			this.txtslbi.TabIndex = 1;
			// 
			// maBanDataGridViewTextBoxColumn
			// 
			this.maBanDataGridViewTextBoxColumn.DataPropertyName = "MaBan";
			this.maBanDataGridViewTextBoxColumn.HeaderText = "Mã Bàn";
			this.maBanDataGridViewTextBoxColumn.Name = "maBanDataGridViewTextBoxColumn";
			// 
			// tenBanDataGridViewTextBoxColumn
			// 
			this.tenBanDataGridViewTextBoxColumn.DataPropertyName = "TenBan";
			this.tenBanDataGridViewTextBoxColumn.HeaderText = "Tên Bàn";
			this.tenBanDataGridViewTextBoxColumn.Name = "tenBanDataGridViewTextBoxColumn";
			// 
			// maLoaiDataGridViewTextBoxColumn
			// 
			this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
			this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Loại";
			this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
			// 
			// sLbiDataGridViewTextBoxColumn
			// 
			this.sLbiDataGridViewTextBoxColumn.DataPropertyName = "SLbi";
			this.sLbiDataGridViewTextBoxColumn.HeaderText = "Số Lượng Bi";
			this.sLbiDataGridViewTextBoxColumn.Name = "sLbiDataGridViewTextBoxColumn";
			// 
			// sLgayDataGridViewTextBoxColumn
			// 
			this.sLgayDataGridViewTextBoxColumn.DataPropertyName = "SLgay";
			this.sLgayDataGridViewTextBoxColumn.HeaderText = "Số Lượng Gậy";
			this.sLgayDataGridViewTextBoxColumn.Name = "sLgayDataGridViewTextBoxColumn";
			// 
			// trangThaiDataGridViewTextBoxColumn
			// 
			this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
			this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
			this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
			// 
			// BanBIDA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1269, 802);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "BanBIDA";
			this.Text = "BanBIDA";
			this.Load += new System.EventHandler(this.BanBIDA_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvbanbida)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBanBIDABindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnload;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnluu;
		private System.Windows.Forms.Button btnhuy;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtban;
		private System.Windows.Forms.TextBox txtmaloai;
		private System.Windows.Forms.TextBox txtmaban;
		private System.Windows.Forms.TextBox txtslgay;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvbanbida;
		private System.Windows.Forms.Label label1;
		private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
		private System.Windows.Forms.BindingSource tbBanBIDABindingSource;
		private CAFE_AND_BIDADataSetTableAdapters.Tb_BanBIDATableAdapter tb_BanBIDATableAdapter;
		private System.Windows.Forms.ComboBox txttrangthai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtslbi;
		private System.Windows.Forms.DataGridViewTextBoxColumn maBanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenBanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sLbiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sLgayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
	}
}