namespace ql_cafe_bia
{
    partial class NguyenLieu
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
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDonVi = new System.Windows.Forms.TextBox();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.txtMaNL = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtTenNL = new System.Windows.Forms.TextBox();
			this.txtMaKNL = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvKhoNL = new System.Windows.Forms.DataGridView();
			this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maNLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makNLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenNLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbNguyenLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.tb_NguyenLieuTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_NguyenLieuTableAdapter();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoNL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbNguyenLieuBindingSource)).BeginInit();
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
			this.groupBox3.Location = new System.Drawing.Point(13, 415);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 234);
			this.groupBox3.TabIndex = 18;
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
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(25, 165);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(137, 48);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa ";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(25, 96);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(137, 48);
			this.btnluu.TabIndex = 0;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			// 
			// btnhuy
			// 
			this.btnhuy.Location = new System.Drawing.Point(186, 96);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(137, 48);
			this.btnhuy.TabIndex = 0;
			this.btnhuy.Text = "Hủy";
			this.btnhuy.UseVisualStyleBackColor = true;
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
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtDonVi);
			this.groupBox2.Controls.Add(this.txtMaSP);
			this.groupBox2.Controls.Add(this.txtMaNL);
			this.groupBox2.Controls.Add(this.txtSoLuong);
			this.groupBox2.Controls.Add(this.txtTenNL);
			this.groupBox2.Controls.Add(this.txtMaKNL);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(359, 397);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 329);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Đơn Vị";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên Nguyên Liệu";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(65, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Mã Sản Phẩm ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã Nguyên Liệu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(65, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số Lượng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã Kho Nguyên Liệu";
			// 
			// txtDonVi
			// 
			this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonVi.Location = new System.Drawing.Point(69, 352);
			this.txtDonVi.Name = "txtDonVi";
			this.txtDonVi.Size = new System.Drawing.Size(222, 26);
			this.txtDonVi.TabIndex = 1;
			// 
			// txtMaSP
			// 
			this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.Location = new System.Drawing.Point(69, 48);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(222, 26);
			this.txtMaSP.TabIndex = 1;
			// 
			// txtMaNL
			// 
			this.txtMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNL.Location = new System.Drawing.Point(69, 109);
			this.txtMaNL.Name = "txtMaNL";
			this.txtMaNL.Size = new System.Drawing.Size(222, 26);
			this.txtMaNL.TabIndex = 1;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(69, 169);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(222, 26);
			this.txtSoLuong.TabIndex = 1;
			// 
			// txtTenNL
			// 
			this.txtTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNL.Location = new System.Drawing.Point(69, 300);
			this.txtTenNL.Name = "txtTenNL";
			this.txtTenNL.Size = new System.Drawing.Size(222, 26);
			this.txtTenNL.TabIndex = 1;
			// 
			// txtMaKNL
			// 
			this.txtMaKNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaKNL.Location = new System.Drawing.Point(69, 237);
			this.txtMaKNL.Name = "txtMaKNL";
			this.txtMaKNL.Size = new System.Drawing.Size(222, 26);
			this.txtMaKNL.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvKhoNL);
			this.groupBox1.Location = new System.Drawing.Point(377, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(871, 640);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sản Phẩm ";
			// 
			// dgvKhoNL
			// 
			this.dgvKhoNL.AutoGenerateColumns = false;
			this.dgvKhoNL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhoNL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvKhoNL.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvKhoNL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvKhoNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhoNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.maNLDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.makNLDataGridViewTextBoxColumn,
            this.tenNLDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn});
			this.dgvKhoNL.DataSource = this.tbNguyenLieuBindingSource;
			this.dgvKhoNL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKhoNL.GridColor = System.Drawing.Color.IndianRed;
			this.dgvKhoNL.Location = new System.Drawing.Point(3, 22);
			this.dgvKhoNL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvKhoNL.Name = "dgvKhoNL";
			this.dgvKhoNL.ShowRowErrors = false;
			this.dgvKhoNL.Size = new System.Drawing.Size(865, 615);
			this.dgvKhoNL.TabIndex = 2;
			// 
			// maSPDataGridViewTextBoxColumn
			// 
			this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
			this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
			this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
			// 
			// maNLDataGridViewTextBoxColumn
			// 
			this.maNLDataGridViewTextBoxColumn.DataPropertyName = "MaNL";
			this.maNLDataGridViewTextBoxColumn.HeaderText = "MaNL";
			this.maNLDataGridViewTextBoxColumn.Name = "maNLDataGridViewTextBoxColumn";
			// 
			// soLuongDataGridViewTextBoxColumn
			// 
			this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
			this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
			this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
			// 
			// makNLDataGridViewTextBoxColumn
			// 
			this.makNLDataGridViewTextBoxColumn.DataPropertyName = "MakNL";
			this.makNLDataGridViewTextBoxColumn.HeaderText = "MakNL";
			this.makNLDataGridViewTextBoxColumn.Name = "makNLDataGridViewTextBoxColumn";
			// 
			// tenNLDataGridViewTextBoxColumn
			// 
			this.tenNLDataGridViewTextBoxColumn.DataPropertyName = "TenNL";
			this.tenNLDataGridViewTextBoxColumn.HeaderText = "TenNL";
			this.tenNLDataGridViewTextBoxColumn.Name = "tenNLDataGridViewTextBoxColumn";
			// 
			// donViDataGridViewTextBoxColumn
			// 
			this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
			this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
			this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
			// 
			// tbNguyenLieuBindingSource
			// 
			this.tbNguyenLieuBindingSource.DataMember = "Tb_NguyenLieu";
			this.tbNguyenLieuBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tb_NguyenLieuTableAdapter
			// 
			this.tb_NguyenLieuTableAdapter.ClearBeforeFill = true;
			// 
			// NguyenLieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1260, 664);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "NguyenLieu";
			this.Text = "NguyenLieu";
			this.Load += new System.EventHandler(this.NguyenLieu_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoNL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbNguyenLieuBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtMaKNL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhoNL;
        private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
        private System.Windows.Forms.BindingSource tbNguyenLieuBindingSource;
        private CAFE_AND_BIDADataSetTableAdapters.Tb_NguyenLieuTableAdapter tb_NguyenLieuTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makNLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
    }
}