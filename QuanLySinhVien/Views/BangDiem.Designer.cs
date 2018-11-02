namespace QuanLySinhVien.Views
{
    partial class BangDiem
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
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongKEt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHK
            // 
            this.cbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(60, 12);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 21);
            this.cbHK.TabIndex = 3;
            this.cbHK.SelectionChangeCommitted += new System.EventHandler(this.cbHK_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kì:";
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.AllowUserToAddRows = false;
            this.dtgvDiem.AllowUserToResizeColumns = false;
            this.dtgvDiem.AllowUserToResizeRows = false;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenMH,
            this.diemTK,
            this.diemGK,
            this.diemCK,
            this.diemTong,
            this.xepLoai});
            this.dtgvDiem.Location = new System.Drawing.Point(12, 45);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.ReadOnly = true;
            this.dtgvDiem.Size = new System.Drawing.Size(580, 212);
            this.dtgvDiem.TabIndex = 4;
            this.dtgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiem_CellClick);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(517, 299);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tạo báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(247, 12);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cbNamHoc.TabIndex = 9;
            this.cbNamHoc.SelectionChangeCommitted += new System.EventHandler(this.cbHK_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Môn:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(41, 264);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(110, 20);
            this.txtTenMon.TabIndex = 11;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(215, 264);
            this.txtTK.Name = "txtTK";
            this.txtTK.ReadOnly = true;
            this.txtTK.Size = new System.Drawing.Size(43, 20);
            this.txtTK.TabIndex = 13;
            this.txtTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thường kì:";
            // 
            // txtGK
            // 
            this.txtGK.Location = new System.Drawing.Point(304, 264);
            this.txtGK.Name = "txtGK";
            this.txtGK.ReadOnly = true;
            this.txtGK.Size = new System.Drawing.Size(43, 20);
            this.txtGK.TabIndex = 15;
            this.txtGK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giữa kì:";
            // 
            // txtCk
            // 
            this.txtCk.Location = new System.Drawing.Point(392, 264);
            this.txtCk.Name = "txtCk";
            this.txtCk.ReadOnly = true;
            this.txtCk.Size = new System.Drawing.Size(43, 20);
            this.txtCk.TabIndex = 17;
            this.txtCk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cuối kì:";
            // 
            // txtTongKEt
            // 
            this.txtTongKEt.Location = new System.Drawing.Point(490, 263);
            this.txtTongKEt.Name = "txtTongKEt";
            this.txtTongKEt.ReadOnly = true;
            this.txtTongKEt.Size = new System.Drawing.Size(43, 20);
            this.txtTongKEt.TabIndex = 19;
            this.txtTongKEt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng kết:";
            // 
            // txtXL
            // 
            this.txtXL.Location = new System.Drawing.Point(566, 263);
            this.txtXL.Name = "txtXL";
            this.txtXL.ReadOnly = true;
            this.txtXL.Size = new System.Drawing.Size(26, 20);
            this.txtXL.TabIndex = 21;
            this.txtXL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Loại:";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // tenMH
            // 
            this.tenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMH.DataPropertyName = "TenMH";
            this.tenMH.HeaderText = "Tên Môn";
            this.tenMH.Name = "tenMH";
            this.tenMH.ReadOnly = true;
            // 
            // diemTK
            // 
            this.diemTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diemTK.DataPropertyName = "DiemTK";
            this.diemTK.HeaderText = "Thường kì";
            this.diemTK.Name = "diemTK";
            this.diemTK.ReadOnly = true;
            this.diemTK.Width = 80;
            // 
            // diemGK
            // 
            this.diemGK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diemGK.DataPropertyName = "DiemGK";
            this.diemGK.HeaderText = "Giữa kì";
            this.diemGK.Name = "diemGK";
            this.diemGK.ReadOnly = true;
            this.diemGK.Width = 65;
            // 
            // diemCK
            // 
            this.diemCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diemCK.DataPropertyName = "DiemCK";
            this.diemCK.HeaderText = "Cuối kì";
            this.diemCK.Name = "diemCK";
            this.diemCK.ReadOnly = true;
            this.diemCK.Width = 64;
            // 
            // diemTong
            // 
            this.diemTong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diemTong.DataPropertyName = "DiemTongKet";
            this.diemTong.HeaderText = "Tổng kết";
            this.diemTong.Name = "diemTong";
            this.diemTong.ReadOnly = true;
            this.diemTong.Width = 75;
            // 
            // xepLoai
            // 
            this.xepLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xepLoai.DataPropertyName = "XepLoai";
            this.xepLoai.HeaderText = "Xếp loại";
            this.xepLoai.Name = "xepLoai";
            this.xepLoai.ReadOnly = true;
            this.xepLoai.Width = 70;
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 329);
            this.Controls.Add(this.txtXL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongKEt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.BangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongKEt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepLoai;
    }
}