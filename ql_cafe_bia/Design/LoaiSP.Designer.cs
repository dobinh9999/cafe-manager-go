namespace ql_cafe_bia
{
    partial class LoaiSP
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txttenloaisp = new System.Windows.Forms.TextBox();
			this.txtmaloaisp = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgv_loaiSP = new System.Windows.Forms.DataGridView();
			this.maLoaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenLoaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbLoaiSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_LoaiSPTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_LoaiSPTableAdapter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_loaiSP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoaiSPBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txttenloaisp);
			this.groupBox2.Controls.Add(this.txtmaloaisp);
			this.groupBox2.Location = new System.Drawing.Point(12, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(359, 312);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên Loại Sản Phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã Loại Sản Phẩm";
			// 
			// txttenloaisp
			// 
			this.txttenloaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenloaisp.Location = new System.Drawing.Point(63, 188);
			this.txttenloaisp.Name = "txttenloaisp";
			this.txttenloaisp.Size = new System.Drawing.Size(222, 26);
			this.txttenloaisp.TabIndex = 1;
			// 
			// txtmaloaisp
			// 
			this.txtmaloaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaloaisp.Location = new System.Drawing.Point(63, 82);
			this.txtmaloaisp.Name = "txtmaloaisp";
			this.txtmaloaisp.Size = new System.Drawing.Size(222, 26);
			this.txtmaloaisp.TabIndex = 1;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(28, 231);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(137, 48);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa ";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(189, 108);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(137, 48);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(28, 108);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(137, 48);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgv_loaiSP);
			this.groupBox1.Location = new System.Drawing.Point(377, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(689, 643);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sản Phẩm ";
			// 
			// dgv_loaiSP
			// 
			this.dgv_loaiSP.AutoGenerateColumns = false;
			this.dgv_loaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_loaiSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgv_loaiSP.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgv_loaiSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgv_loaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_loaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSPDataGridViewTextBoxColumn,
            this.tenLoaiSPDataGridViewTextBoxColumn});
			this.dgv_loaiSP.DataSource = this.tbLoaiSPBindingSource;
			this.dgv_loaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_loaiSP.GridColor = System.Drawing.Color.IndianRed;
			this.dgv_loaiSP.Location = new System.Drawing.Point(3, 22);
			this.dgv_loaiSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgv_loaiSP.Name = "dgv_loaiSP";
			this.dgv_loaiSP.ShowRowErrors = false;
			this.dgv_loaiSP.Size = new System.Drawing.Size(683, 618);
			this.dgv_loaiSP.TabIndex = 2;
			this.dgv_loaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiSP_CellClick);
			// 
			// maLoaiSPDataGridViewTextBoxColumn
			// 
			this.maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
			this.maLoaiSPDataGridViewTextBoxColumn.HeaderText = "MaLoaiSP";
			this.maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
			// 
			// tenLoaiSPDataGridViewTextBoxColumn
			// 
			this.tenLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSP";
			this.tenLoaiSPDataGridViewTextBoxColumn.HeaderText = "TenLoaiSP";
			this.tenLoaiSPDataGridViewTextBoxColumn.Name = "tenLoaiSPDataGridViewTextBoxColumn";
			// 
			// tbLoaiSPBindingSource
			// 
			this.tbLoaiSPBindingSource.DataMember = "Tb_LoaiSP";
			this.tbLoaiSPBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
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
			this.label1.Location = new System.Drawing.Point(37, 88);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 5;
			// 
			// tb_LoaiSPTableAdapter
			// 
			this.tb_LoaiSPTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Location = new System.Drawing.Point(13, 344);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 322);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức Năng";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(189, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 48);
			this.button2.TabIndex = 0;
			this.button2.Text = "Xóa ";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// LoaiSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1078, 681);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoaiSP";
			this.Text = "LoaiSP";
			this.Load += new System.EventHandler(this.LoaiSP_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_loaiSP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLoaiSPBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cAFE_AND_BIDADataSet)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmaloaisp;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_loaiSP;
        private System.Windows.Forms.Label label1;
        private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
        private System.Windows.Forms.BindingSource tbLoaiSPBindingSource;
        private CAFE_AND_BIDADataSetTableAdapters.Tb_LoaiSPTableAdapter tb_LoaiSPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenloaisp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}