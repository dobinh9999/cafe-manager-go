namespace ql_cafe_bia
{
    partial class Voicher
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
			this.txtapdung = new System.Windows.Forms.ComboBox();
			this.txtngaytao = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txttenvc = new System.Windows.Forms.TextBox();
			this.txtmavc = new System.Windows.Forms.TextBox();
			this.txttenSPapdung = new System.Windows.Forms.TextBox();
			this.txtgiatri = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvvoicher = new System.Windows.Forms.DataGridView();
			this.mavoicherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giaTriGGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbVoicherBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cAFE_AND_BIDADataSet = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.tb_VoicherTableAdapter = new ql_cafe_bia.CAFE_AND_BIDADataSetTableAdapters.Tb_VoicherTableAdapter();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvvoicher)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVoicherBindingSource)).BeginInit();
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
			this.groupBox3.Location = new System.Drawing.Point(12, 445);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 248);
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
			this.groupBox2.Controls.Add(this.txtapdung);
			this.groupBox2.Controls.Add(this.txtngaytao);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txttenvc);
			this.groupBox2.Controls.Add(this.txtmavc);
			this.groupBox2.Controls.Add(this.txttenSPapdung);
			this.groupBox2.Controls.Add(this.txtgiatri);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(359, 427);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hiển Thị Thông Tin";
			// 
			// txtapdung
			// 
			this.txtapdung.FormattingEnabled = true;
			this.txtapdung.Items.AddRange(new object[] {
            "999999999"});
			this.txtapdung.Location = new System.Drawing.Point(59, 361);
			this.txtapdung.Name = "txtapdung";
			this.txtapdung.Size = new System.Drawing.Size(222, 28);
			this.txtapdung.TabIndex = 4;
			this.txtapdung.SelectedIndexChanged += new System.EventHandler(this.txtapdung_SelectedIndexChanged);
			// 
			// txtngaytao
			// 
			this.txtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.txtngaytao.Location = new System.Drawing.Point(59, 211);
			this.txtngaytao.Name = "txtngaytao";
			this.txtngaytao.Size = new System.Drawing.Size(146, 26);
			this.txtngaytao.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ngày Tạo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã Voucher";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tên Voicher";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 338);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Áp Dụng (theo mã sản )";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Giá Trị Voucher(theo %)";
			// 
			// txttenvc
			// 
			this.txttenvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenvc.Location = new System.Drawing.Point(59, 128);
			this.txttenvc.Name = "txttenvc";
			this.txttenvc.Size = new System.Drawing.Size(222, 26);
			this.txttenvc.TabIndex = 1;
			// 
			// txtmavc
			// 
			this.txtmavc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmavc.Location = new System.Drawing.Point(59, 55);
			this.txtmavc.Name = "txtmavc";
			this.txtmavc.Size = new System.Drawing.Size(222, 26);
			this.txtmavc.TabIndex = 1;
			// 
			// txttenSPapdung
			// 
			this.txttenSPapdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttenSPapdung.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txttenSPapdung.Location = new System.Drawing.Point(59, 395);
			this.txttenSPapdung.Name = "txttenSPapdung";
			this.txttenSPapdung.Size = new System.Drawing.Size(222, 26);
			this.txttenSPapdung.TabIndex = 1;
			this.txttenSPapdung.Text = "Sản Phẩm dc áp dụng";
			// 
			// txtgiatri
			// 
			this.txtgiatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtgiatri.Location = new System.Drawing.Point(59, 299);
			this.txtgiatri.Name = "txtgiatri";
			this.txtgiatri.Size = new System.Drawing.Size(222, 26);
			this.txtgiatri.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.dgvvoicher);
			this.groupBox1.Location = new System.Drawing.Point(377, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(673, 681);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh Sách VoiCher";
			// 
			// dgvvoicher
			// 
			this.dgvvoicher.AutoGenerateColumns = false;
			this.dgvvoicher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvvoicher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvvoicher.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvvoicher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dgvvoicher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvvoicher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavoicherDataGridViewTextBoxColumn,
            this.tenVCDataGridViewTextBoxColumn,
            this.ngayGioDataGridViewTextBoxColumn,
            this.giaTriGGDataGridViewTextBoxColumn,
            this.apDungDataGridViewTextBoxColumn});
			this.dgvvoicher.DataSource = this.tbVoicherBindingSource;
			this.dgvvoicher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvvoicher.GridColor = System.Drawing.Color.IndianRed;
			this.dgvvoicher.Location = new System.Drawing.Point(3, 22);
			this.dgvvoicher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvvoicher.Name = "dgvvoicher";
			this.dgvvoicher.ShowRowErrors = false;
			this.dgvvoicher.Size = new System.Drawing.Size(667, 656);
			this.dgvvoicher.TabIndex = 2;
			this.dgvvoicher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvoicher_CellEnter);
			// 
			// mavoicherDataGridViewTextBoxColumn
			// 
			this.mavoicherDataGridViewTextBoxColumn.DataPropertyName = "Mavoicher";
			this.mavoicherDataGridViewTextBoxColumn.HeaderText = "Mavoicher";
			this.mavoicherDataGridViewTextBoxColumn.Name = "mavoicherDataGridViewTextBoxColumn";
			// 
			// tenVCDataGridViewTextBoxColumn
			// 
			this.tenVCDataGridViewTextBoxColumn.DataPropertyName = "TenVC";
			this.tenVCDataGridViewTextBoxColumn.HeaderText = "TenVC";
			this.tenVCDataGridViewTextBoxColumn.Name = "tenVCDataGridViewTextBoxColumn";
			// 
			// ngayGioDataGridViewTextBoxColumn
			// 
			this.ngayGioDataGridViewTextBoxColumn.DataPropertyName = "NgayGio";
			this.ngayGioDataGridViewTextBoxColumn.HeaderText = "NgayGio";
			this.ngayGioDataGridViewTextBoxColumn.Name = "ngayGioDataGridViewTextBoxColumn";
			// 
			// giaTriGGDataGridViewTextBoxColumn
			// 
			this.giaTriGGDataGridViewTextBoxColumn.DataPropertyName = "GiaTriGG";
			this.giaTriGGDataGridViewTextBoxColumn.HeaderText = "GiaTriGG";
			this.giaTriGGDataGridViewTextBoxColumn.Name = "giaTriGGDataGridViewTextBoxColumn";
			// 
			// apDungDataGridViewTextBoxColumn
			// 
			this.apDungDataGridViewTextBoxColumn.DataPropertyName = "ApDung";
			this.apDungDataGridViewTextBoxColumn.HeaderText = "ApDung";
			this.apDungDataGridViewTextBoxColumn.Name = "apDungDataGridViewTextBoxColumn";
			// 
			// tbVoicherBindingSource
			// 
			this.tbVoicherBindingSource.DataMember = "Tb_Voicher";
			this.tbVoicherBindingSource.DataSource = this.cAFE_AND_BIDADataSet;
			// 
			// cAFE_AND_BIDADataSet
			// 
			this.cAFE_AND_BIDADataSet.DataSetName = "CAFE_AND_BIDADataSet";
			this.cAFE_AND_BIDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tb_VoicherTableAdapter
			// 
			this.tb_VoicherTableAdapter.ClearBeforeFill = true;
			// 
			// Voicher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1062, 705);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Voicher";
			this.Load += new System.EventHandler(this.Voicher_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvvoicher)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVoicherBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txttenvc;
        private System.Windows.Forms.TextBox txtmavc;
        private System.Windows.Forms.TextBox txtgiatri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvvoicher;
        private CAFE_AND_BIDADataSet cAFE_AND_BIDADataSet;
        private System.Windows.Forms.BindingSource tbVoicherBindingSource;
        private CAFE_AND_BIDADataSetTableAdapters.Tb_VoicherTableAdapter tb_VoicherTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavoicherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriGGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker txtngaytao;
        private System.Windows.Forms.ComboBox txtapdung;
		private System.Windows.Forms.TextBox txttenSPapdung;
	}
}