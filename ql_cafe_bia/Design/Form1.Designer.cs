namespace ql_cafe_bia
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkpass = new System.Windows.Forms.CheckBox();
			this.btndangnhap = new System.Windows.Forms.Button();
			this.txttaikhoan = new System.Windows.Forms.TextBox();
			this.txtmatkhau = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkpass);
			this.groupBox1.Controls.Add(this.btndangnhap);
			this.groupBox1.Controls.Add(this.txttaikhoan);
			this.groupBox1.Controls.Add(this.txtmatkhau);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(375, 2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(373, 427);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// checkpass
			// 
			this.checkpass.AutoSize = true;
			this.checkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkpass.Location = new System.Drawing.Point(243, 232);
			this.checkpass.Name = "checkpass";
			this.checkpass.Size = new System.Drawing.Size(62, 24);
			this.checkpass.TabIndex = 5;
			this.checkpass.Text = "pass";
			this.checkpass.UseVisualStyleBackColor = true;
			this.checkpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btndangnhap
			// 
			this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndangnhap.Location = new System.Drawing.Point(82, 262);
			this.btndangnhap.Name = "btndangnhap";
			this.btndangnhap.Size = new System.Drawing.Size(214, 46);
			this.btndangnhap.TabIndex = 3;
			this.btndangnhap.Text = "Đăng Nhập";
			this.btndangnhap.UseVisualStyleBackColor = true;
			this.btndangnhap.Click += new System.EventHandler(this.button1_Click);
			this.btndangnhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
			// 
			// txttaikhoan
			// 
			this.txttaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttaikhoan.Location = new System.Drawing.Point(80, 118);
			this.txttaikhoan.Name = "txttaikhoan";
			this.txttaikhoan.Size = new System.Drawing.Size(225, 31);
			this.txttaikhoan.TabIndex = 1;
			this.txttaikhoan.Click += new System.EventHandler(this.txttaikhoan_Click);
			this.txttaikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttaikhoan_KeyDown);
			this.txttaikhoan.Leave += new System.EventHandler(this.txttaikhoan_Leave);
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmatkhau.Location = new System.Drawing.Point(82, 183);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.Size = new System.Drawing.Size(223, 31);
			this.txtmatkhau.TabIndex = 2;
			this.txtmatkhau.Click += new System.EventHandler(this.txtmatkhau_Click);
			this.txtmatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown);
			this.txtmatkhau.Leave += new System.EventHandler(this.txtmatkhau_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài Khoản :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(106, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 60);
			this.label3.TabIndex = 0;
			this.label3.Text = "LOGIN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(83, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật Khẩu :";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(82, 330);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(214, 47);
			this.button2.TabIndex = 4;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(107)))), ((int)(((byte)(55)))));
			this.label4.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(299, 47);
			this.label4.TabIndex = 5;
			this.label4.Text = "CAFE MANG ĐI";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(107)))), ((int)(((byte)(55)))));
			this.pictureBox1.Image = global::ql_cafe_bia.Properties.Resources.Cafe_and_bida_Logo;
			this.pictureBox1.Location = new System.Drawing.Point(15, 67);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(354, 362);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(107)))), ((int)(((byte)(55)))));
			this.ClientSize = new System.Drawing.Size(759, 440);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giao diện đăng nhập ";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkpass;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

