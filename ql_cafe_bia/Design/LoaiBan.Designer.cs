namespace ql_cafe_bia
{
	partial class LoaiBan
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
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txttenloai = new System.Windows.Forms.TextBox();
			this.txtsoluong = new System.Windows.Forms.TextBox();
			this.txtmaloai = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvbanbida = new System.Windows.Forms.DataGridView();
			this.tbLoaiBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_LoaiBanTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_LoaiBanTableAdapter();
			this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvbanbida)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoaiBanBindingSource)).BeginInit();
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
			this.groupBox3.Size = new System.Drawing.Size(445, 286);
			this.groupBox3.TabIndex = 28;
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
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txttenloai);
			this.groupBox2.Controls.Add(this.txtsoluong);
			this.groupBox2.Controls.Add(this.txtmaloai);
			this.groupBox2.Location = new System.Drawing.Point(13, 13);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(445, 461);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(67, 200);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tên Loại";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(67, 309);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Số Lượng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(70, 105);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mã Loại";
			// 
			// txttenloai
			// 
			this.txttenloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenloai.Location = new System.Drawing.Point(70, 220);
			this.txttenloai.Margin = new System.Windows.Forms.Padding(4);
			this.txttenloai.Name = "txttenloai";
			this.txttenloai.Size = new System.Drawing.Size(295, 26);
			this.txttenloai.TabIndex = 1;
			// 
			// txtsoluong
			// 
			this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsoluong.Location = new System.Drawing.Point(70, 329);
			this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
			this.txtsoluong.Name = "txtsoluong";
			this.txtsoluong.Size = new System.Drawing.Size(295, 26);
			this.txtsoluong.TabIndex = 1;
			// 
			// txtmaloai
			// 
			this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaloai.Location = new System.Drawing.Point(70, 125);
			this.txtmaloai.Margin = new System.Windows.Forms.Padding(4);
			this.txtmaloai.Name = "txtmaloai";
			this.txtmaloai.Size = new System.Drawing.Size(295, 26);
			this.txtmaloai.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvbanbida);
			this.groupBox1.Location = new System.Drawing.Point(478, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(697, 753);
			this.groupBox1.TabIndex = 26;
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
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
			this.dgvbanbida.DataSource = this.tbLoaiBanBindingSource;
			this.dgvbanbida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvbanbida.GridColor = System.Drawing.Color.IndianRed;
			this.dgvbanbida.Location = new System.Drawing.Point(4, 23);
			this.dgvbanbida.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvbanbida.Name = "dgvbanbida";
			this.dgvbanbida.ShowRowErrors = false;
			this.dgvbanbida.Size = new System.Drawing.Size(689, 726);
			this.dgvbanbida.TabIndex = 2;
			this.dgvbanbida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbanbida_CellClick);
			// 
			// tbLoaiBanBindingSource
			// 
			this.tbLoaiBanBindingSource.DataMember = "Tb_LoaiBan";
			this.tbLoaiBanBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
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
			this.label1.Location = new System.Drawing.Point(25, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 25;
			// 
			// tb_LoaiBanTableAdapter
			// 
			this.tb_LoaiBanTableAdapter.ClearBeforeFill = true;
			// 
			// maLoaiDataGridViewTextBoxColumn
			// 
			this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
			this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Loại";
			this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
			// 
			// tenLoaiDataGridViewTextBoxColumn
			// 
			this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
			this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên Loại";
			this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
			// 
			// soLuongDataGridViewTextBoxColumn
			// 
			this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
			this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
			this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
			// 
			// LoaiBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1188, 770);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoaiBan";
			this.Text = "LoaiBan";
			this.Load += new System.EventHandler(this.LoaiBan_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvbanbida)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoaiBanBindingSource)).EndInit();
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
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txttenloai;
		private System.Windows.Forms.TextBox txtsoluong;
		private System.Windows.Forms.TextBox txtmaloai;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvbanbida;
		private System.Windows.Forms.Label label1;
		private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
		private System.Windows.Forms.BindingSource tbLoaiBanBindingSource;
		private CAFE_AND_BIDADataSetTableAdapters.Tb_LoaiBanTableAdapter tb_LoaiBanTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
	}
}