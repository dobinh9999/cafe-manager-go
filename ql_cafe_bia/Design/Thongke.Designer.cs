namespace ql_cafe_bia
{
	partial class Thongke
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tb_HoaDonChiTietTableAdapter1 = new ql_cafe_bia.CAFE_AND_BIDADataSet2TableAdapters.Tb_HoaDonChiTietTableAdapter();
			this.btnkiemtra = new System.Windows.Forms.Button();
			this.cbbthongtin = new System.Windows.Forms.ComboBox();
			this.cafE_AND_BIDADataSet1 = new ql_cafe_bia.CAFE_AND_BIDADataSet();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.chkNgay = new System.Windows.Forms.RadioButton();
			this.chkTuan = new System.Windows.Forms.RadioButton();
			this.chkThang = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cafE_AND_BIDADataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.chart1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(23, 392);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1102, 221);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Biểu Thị";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(18, 25);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(1064, 180);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkThang);
			this.groupBox2.Controls.Add(this.chkTuan);
			this.groupBox2.Controls.Add(this.chkNgay);
			this.groupBox2.Controls.Add(this.cbbthongtin);
			this.groupBox2.Controls.Add(this.btnkiemtra);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(23, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(396, 374);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chọn Thông Tin Tìm Kiếm";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(434, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(691, 374);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông số chi tiết";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// tb_HoaDonChiTietTableAdapter1
			// 
			this.tb_HoaDonChiTietTableAdapter1.ClearBeforeFill = true;
			// 
			// btnkiemtra
			// 
			this.btnkiemtra.Location = new System.Drawing.Point(132, 204);
			this.btnkiemtra.Name = "btnkiemtra";
			this.btnkiemtra.Size = new System.Drawing.Size(116, 41);
			this.btnkiemtra.TabIndex = 0;
			this.btnkiemtra.Text = "Kiểm Tra";
			this.btnkiemtra.UseVisualStyleBackColor = true;
			this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
			// 
			// cbbthongtin
			// 
			this.cbbthongtin.FormattingEnabled = true;
			this.cbbthongtin.Items.AddRange(new object[] {
            "Doanh thu bán hàng",
            "Số lượng sản phẩm bán ra",
            "số lượng đơn hàng",
            "khách hàng"});
			this.cbbthongtin.Location = new System.Drawing.Point(73, 48);
			this.cbbthongtin.Name = "cbbthongtin";
			this.cbbthongtin.Size = new System.Drawing.Size(236, 28);
			this.cbbthongtin.TabIndex = 1;
			// 
			// cafE_AND_BIDADataSet1
			// 
			this.cafE_AND_BIDADataSet1.DataSetName = "CAFE_AND_BIDADataSet";
			this.cafE_AND_BIDADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(679, 343);
			this.dataGridView1.TabIndex = 0;
			// 
			// chkNgay
			// 
			this.chkNgay.AutoSize = true;
			this.chkNgay.Location = new System.Drawing.Point(153, 102);
			this.chkNgay.Name = "chkNgay";
			this.chkNgay.Size = new System.Drawing.Size(63, 24);
			this.chkNgay.TabIndex = 3;
			this.chkNgay.TabStop = true;
			this.chkNgay.Text = "Ngày";
			this.chkNgay.UseVisualStyleBackColor = true;
			// 
			// chkTuan
			// 
			this.chkTuan.AutoSize = true;
			this.chkTuan.Location = new System.Drawing.Point(153, 132);
			this.chkTuan.Name = "chkTuan";
			this.chkTuan.Size = new System.Drawing.Size(63, 24);
			this.chkTuan.TabIndex = 3;
			this.chkTuan.TabStop = true;
			this.chkTuan.Text = "Tuần";
			this.chkTuan.UseVisualStyleBackColor = true;
			// 
			// chkThang
			// 
			this.chkThang.AutoSize = true;
			this.chkThang.Location = new System.Drawing.Point(153, 162);
			this.chkThang.Name = "chkThang";
			this.chkThang.Size = new System.Drawing.Size(72, 24);
			this.chkThang.TabIndex = 3;
			this.chkThang.TabStop = true;
			this.chkThang.Text = "Tháng";
			this.chkThang.UseVisualStyleBackColor = true;
			// 
			// Thongke
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1137, 625);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Thongke";
			this.Text = "Thongke";
			this.Load += new System.EventHandler(this.Thongke_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cafE_AND_BIDADataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbbthongtin;
		private System.Windows.Forms.Button btnkiemtra;
		private CAFE_AND_BIDADataSet2TableAdapters.Tb_HoaDonChiTietTableAdapter tb_HoaDonChiTietTableAdapter1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private CAFE_AND_BIDADataSet cafE_AND_BIDADataSet1;
		private System.Windows.Forms.RadioButton chkNgay;
		private System.Windows.Forms.RadioButton chkThang;
		private System.Windows.Forms.RadioButton chkTuan;
	}
}