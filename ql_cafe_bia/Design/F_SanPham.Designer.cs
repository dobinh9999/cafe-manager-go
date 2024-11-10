namespace ql_cafe_bia
{
    partial class F_SanPham
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgv_SP = new System.Windows.Forms.DataGridView();
			this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maLoaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giaSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anhSPDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.tbSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.btnload = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btntimKiem = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.tb_SanPhamTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_SanPhamTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSanPhamBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgv_SP);
			this.groupBox1.Location = new System.Drawing.Point(303, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(947, 495);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sản Phẩm ";
			// 
			// dgv_SP
			// 
			this.dgv_SP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_SP.AutoGenerateColumns = false;
			this.dgv_SP.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgv_SP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgv_SP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maLoaiSPDataGridViewTextBoxColumn,
            this.giaSPDataGridViewTextBoxColumn,
            this.anhSPDataGridViewImageColumn});
			this.dgv_SP.DataSource = this.tbSanPhamBindingSource;
			this.dgv_SP.GridColor = System.Drawing.Color.IndianRed;
			this.dgv_SP.Location = new System.Drawing.Point(3, 22);
			this.dgv_SP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgv_SP.Name = "dgv_SP";
			this.dgv_SP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_SP.ShowRowErrors = false;
			this.dgv_SP.Size = new System.Drawing.Size(941, 470);
			this.dgv_SP.TabIndex = 2;
			this.dgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellClick);
			// 
			// maSPDataGridViewTextBoxColumn
			// 
			this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
			this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
			this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
			this.maSPDataGridViewTextBoxColumn.Width = 180;
			// 
			// tenSPDataGridViewTextBoxColumn
			// 
			this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
			this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản Phẩm";
			this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
			this.tenSPDataGridViewTextBoxColumn.Width = 179;
			// 
			// maLoaiSPDataGridViewTextBoxColumn
			// 
			this.maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
			this.maLoaiSPDataGridViewTextBoxColumn.HeaderText = "Mã Loại Sản Phẩm ";
			this.maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
			this.maLoaiSPDataGridViewTextBoxColumn.Width = 180;
			// 
			// giaSPDataGridViewTextBoxColumn
			// 
			this.giaSPDataGridViewTextBoxColumn.DataPropertyName = "GiaSP";
			this.giaSPDataGridViewTextBoxColumn.HeaderText = "Giá Sản Phẩm";
			this.giaSPDataGridViewTextBoxColumn.Name = "giaSPDataGridViewTextBoxColumn";
			this.giaSPDataGridViewTextBoxColumn.Width = 179;
			// 
			// anhSPDataGridViewImageColumn
			// 
			this.anhSPDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.anhSPDataGridViewImageColumn.DataPropertyName = "AnhSP";
			this.anhSPDataGridViewImageColumn.HeaderText = "Ảnh Sản Phẩm";
			this.anhSPDataGridViewImageColumn.Name = "anhSPDataGridViewImageColumn";
			// 
			// tbSanPhamBindingSource
			// 
			this.tbSanPhamBindingSource.DataMember = "Tb_SanPham";
			this.tbSanPhamBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.txtMaSP);
			this.groupBox2.Controls.Add(this.btnload);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(285, 601);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức Năng";
			// 
			// txtMaSP
			// 
			this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.Location = new System.Drawing.Point(31, 87);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(222, 26);
			this.txtMaSP.TabIndex = 1;
			// 
			// btnload
			// 
			this.btnload.Location = new System.Drawing.Point(6, 402);
			this.btnload.Name = "btnload";
			this.btnload.Size = new System.Drawing.Size(267, 48);
			this.btnload.TabIndex = 0;
			this.btnload.Text = "RESET";
			this.btnload.UseVisualStyleBackColor = true;
			this.btnload.Click += new System.EventHandler(this.btnload_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(6, 321);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(267, 48);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa Dữ Liệu";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(6, 236);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(267, 48);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa Dữ Liệu";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(6, 157);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(267, 48);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm Dữ Liệu";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btntimKiem
			// 
			this.btntimKiem.Location = new System.Drawing.Point(499, 22);
			this.btntimKiem.Name = "btntimKiem";
			this.btntimKiem.Size = new System.Drawing.Size(167, 48);
			this.btntimKiem.TabIndex = 0;
			this.btntimKiem.Text = "Tìm Kiếm";
			this.btntimKiem.UseVisualStyleBackColor = true;
			this.btntimKiem.Click += new System.EventHandler(this.btntimkiem_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.txtTimKiem);
			this.groupBox3.Controls.Add(this.btntimKiem);
			this.groupBox3.Location = new System.Drawing.Point(306, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(941, 100);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tìm Kiếm Thông Tin";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(258, 33);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(224, 26);
			this.txtTimKiem.TabIndex = 1;
			this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
			// 
			// tb_SanPhamTableAdapter
			// 
			this.tb_SanPhamTableAdapter.ClearBeforeFill = true;
			// 
			// F_SanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1262, 628);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "F_SanPham";
			this.Text = "F_SanPham";
			this.Load += new System.EventHandler(this.F_SanPham_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSanPhamBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btntimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnload;
        private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
        private System.Windows.Forms.BindingSource tbSanPhamBindingSource;
        private CAFE_AND_BIDADataSetTableAdapters.Tb_SanPhamTableAdapter tb_SanPhamTableAdapter;
        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhSPDataGridViewImageColumn;
    }
}