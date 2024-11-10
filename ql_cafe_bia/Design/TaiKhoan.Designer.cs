namespace ql_cafe_bia
{
	partial class TaiKhoan
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
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txttk = new System.Windows.Forms.TextBox();
			this.txtmk = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.txttentk = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.tbTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tb_TaiKhoanTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_TaiKhoanTableAdapter();
			this.usersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loaiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtloaiID = new System.Windows.Forms.ComboBox();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoanBindingSource)).BeginInit();
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
			this.groupBox3.Location = new System.Drawing.Point(59, 521);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(477, 307);
			this.groupBox3.TabIndex = 20;
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
			this.groupBox2.Controls.Add(this.txtloaiID);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txttk);
			this.groupBox2.Controls.Add(this.txtmk);
			this.groupBox2.Controls.Add(this.txtuser);
			this.groupBox2.Controls.Add(this.txttentk);
			this.groupBox2.Location = new System.Drawing.Point(59, 29);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(478, 472);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 266);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Loại ID";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(80, 100);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tài Khoản";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(83, 181);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Mật Khẩu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 370);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên Tài Khoản";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "UsersID";
			// 
			// txttk
			// 
			this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttk.Location = new System.Drawing.Point(83, 120);
			this.txttk.Margin = new System.Windows.Forms.Padding(4);
			this.txttk.Name = "txttk";
			this.txttk.Size = new System.Drawing.Size(295, 26);
			this.txttk.TabIndex = 1;
			// 
			// txtmk
			// 
			this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmk.Location = new System.Drawing.Point(86, 201);
			this.txtmk.Margin = new System.Windows.Forms.Padding(4);
			this.txtmk.Name = "txtmk";
			this.txtmk.Size = new System.Drawing.Size(295, 26);
			this.txtmk.TabIndex = 1;
			// 
			// txtuser
			// 
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.Location = new System.Drawing.Point(83, 51);
			this.txtuser.Margin = new System.Windows.Forms.Padding(4);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(295, 26);
			this.txtuser.TabIndex = 1;
			// 
			// txttentk
			// 
			this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttentk.Location = new System.Drawing.Point(87, 390);
			this.txttentk.Margin = new System.Windows.Forms.Padding(4);
			this.txttentk.Name = "txttentk";
			this.txttentk.Size = new System.Drawing.Size(295, 26);
			this.txttentk.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvtaikhoan);
			this.groupBox1.Location = new System.Drawing.Point(545, 29);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(771, 805);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tâi Khoản";
			// 
			// dgvtaikhoan
			// 
			this.dgvtaikhoan.AutoGenerateColumns = false;
			this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvtaikhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvtaikhoan.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvtaikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersIDDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.loaiIDDataGridViewTextBoxColumn,
            this.tenTKDataGridViewTextBoxColumn});
			this.dgvtaikhoan.DataSource = this.tbTaiKhoanBindingSource;
			this.dgvtaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvtaikhoan.GridColor = System.Drawing.Color.IndianRed;
			this.dgvtaikhoan.Location = new System.Drawing.Point(4, 23);
			this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvtaikhoan.Name = "dgvtaikhoan";
			this.dgvtaikhoan.ShowRowErrors = false;
			this.dgvtaikhoan.Size = new System.Drawing.Size(763, 778);
			this.dgvtaikhoan.TabIndex = 2;
			this.dgvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 105);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 17;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbTaiKhoanBindingSource
			// 
			this.tbTaiKhoanBindingSource.DataMember = "Tb_TaiKhoan";
			this.tbTaiKhoanBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
			// 
			// tb_TaiKhoanTableAdapter
			// 
			this.tb_TaiKhoanTableAdapter.ClearBeforeFill = true;
			// 
			// usersIDDataGridViewTextBoxColumn
			// 
			this.usersIDDataGridViewTextBoxColumn.DataPropertyName = "UsersID";
			this.usersIDDataGridViewTextBoxColumn.HeaderText = "UsersID";
			this.usersIDDataGridViewTextBoxColumn.Name = "usersIDDataGridViewTextBoxColumn";
			this.usersIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// taiKhoanDataGridViewTextBoxColumn
			// 
			this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
			this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
			this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
			// 
			// matKhauDataGridViewTextBoxColumn
			// 
			this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
			this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
			this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
			// 
			// loaiIDDataGridViewTextBoxColumn
			// 
			this.loaiIDDataGridViewTextBoxColumn.DataPropertyName = "LoaiID";
			this.loaiIDDataGridViewTextBoxColumn.HeaderText = "Loại ID";
			this.loaiIDDataGridViewTextBoxColumn.Name = "loaiIDDataGridViewTextBoxColumn";
			// 
			// tenTKDataGridViewTextBoxColumn
			// 
			this.tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
			this.tenTKDataGridViewTextBoxColumn.HeaderText = "Tên Tài Khoản";
			this.tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
			// 
			// txtloaiID
			// 
			this.txtloaiID.FormattingEnabled = true;
			this.txtloaiID.Items.AddRange(new object[] {
            "admin",
            "user"});
			this.txtloaiID.Location = new System.Drawing.Point(86, 289);
			this.txtloaiID.Name = "txtloaiID";
			this.txtloaiID.Size = new System.Drawing.Size(291, 28);
			this.txtloaiID.TabIndex = 3;
			// 
			// TaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1374, 863);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TaiKhoan";
			this.Text = "TaiKhoan";
			this.Load += new System.EventHandler(this.TaiKhoan_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoanBindingSource)).EndInit();
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
		private System.Windows.Forms.TextBox txttk;
		private System.Windows.Forms.TextBox txtmk;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.TextBox txttentk;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvtaikhoan;
		private System.Windows.Forms.Label label1;
		private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
		private System.Windows.Forms.BindingSource tbTaiKhoanBindingSource;
		private CAFE_AND_BIDADataSetTableAdapters.Tb_TaiKhoanTableAdapter tb_TaiKhoanTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn usersIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loaiIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox txtloaiID;
	}
}