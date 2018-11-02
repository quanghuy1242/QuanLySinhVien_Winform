namespace QuanLySinhVien.Views
{
    partial class ThongTinLopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.dtgvLop = new System.Windows.Forms.DataGridView();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDanhSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kì:";
            // 
            // cbHK
            // 
            this.cbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(60, 13);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(121, 21);
            this.cbHK.TabIndex = 1;
            this.cbHK.SelectionChangeCommitted += new System.EventHandler(this.cbHK_SelectionChangeCommitted);
            // 
            // dtgvLop
            // 
            this.dtgvLop.AllowUserToAddRows = false;
            this.dtgvLop.AllowUserToDeleteRows = false;
            this.dtgvLop.AllowUserToOrderColumns = true;
            this.dtgvLop.AllowUserToResizeColumns = false;
            this.dtgvLop.AllowUserToResizeRows = false;
            this.dtgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.hoTenGV,
            this.monHoc,
            this.siSo});
            this.dtgvLop.Location = new System.Drawing.Point(12, 43);
            this.dtgvLop.Name = "dtgvLop";
            this.dtgvLop.ReadOnly = true;
            this.dtgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLop.Size = new System.Drawing.Size(511, 182);
            this.dtgvLop.TabIndex = 2;
            this.dtgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLop_CellClick);
            // 
            // maLop
            // 
            this.maLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maLop.DataPropertyName = "MaLop";
            this.maLop.HeaderText = "Mã Lớp";
            this.maLop.Name = "maLop";
            this.maLop.ReadOnly = true;
            this.maLop.Width = 63;
            // 
            // hoTenGV
            // 
            this.hoTenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTenGV.DataPropertyName = "TenGV";
            this.hoTenGV.HeaderText = "Họ tên Giảng Viên";
            this.hoTenGV.Name = "hoTenGV";
            this.hoTenGV.ReadOnly = true;
            // 
            // monHoc
            // 
            this.monHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monHoc.DataPropertyName = "TenMH";
            this.monHoc.HeaderText = "Môn học";
            this.monHoc.Name = "monHoc";
            this.monHoc.ReadOnly = true;
            // 
            // siSo
            // 
            this.siSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siSo.DataPropertyName = "SiSo";
            this.siSo.HeaderText = "Sỉ số";
            this.siSo.Name = "siSo";
            this.siSo.ReadOnly = true;
            this.siSo.Width = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(110, 232);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(163, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(110, 258);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.ReadOnly = true;
            this.txtHoTenGV.Size = new System.Drawing.Size(163, 20);
            this.txtHoTenGV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ tên giáo viên:";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(360, 257);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(163, 20);
            this.txtSiSo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sỉ số:";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(360, 231);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.ReadOnly = true;
            this.txtMonHoc.Size = new System.Drawing.Size(163, 20);
            this.txtMonHoc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(448, 283);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(250, 13);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cbNamHoc.TabIndex = 14;
            this.cbNamHoc.SelectionChangeCommitted += new System.EventHandler(this.cbHK_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Năm học:";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(19, 283);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(171, 23);
            this.btnDanhSach.TabIndex = 15;
            this.btnDanhSach.Text = "Danh sách học sinh của lớp này";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // ThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 312);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoTenGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvLop);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.ThongTinLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDanhSach;
        public System.Windows.Forms.TextBox txtMaLop;
        public System.Windows.Forms.ComboBox cbHK;
        public System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
    }
}