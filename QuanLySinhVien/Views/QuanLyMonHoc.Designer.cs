namespace QuanLySinhVien.Views
{
    partial class QuanLyMonHoc
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
            this.dtgvMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnUpdateAdd = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSiSo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMonHoc
            // 
            this.dtgvMonHoc.AllowUserToResizeColumns = false;
            this.dtgvMonHoc.AllowUserToResizeRows = false;
            this.dtgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.TinChi});
            this.dtgvMonHoc.Location = new System.Drawing.Point(13, 12);
            this.dtgvMonHoc.Name = "dtgvMonHoc";
            this.dtgvMonHoc.Size = new System.Drawing.Size(500, 148);
            this.dtgvMonHoc.TabIndex = 0;
            this.dtgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick);
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaMon.DataPropertyName = "MaMH";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 70;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMH";
            this.TenMon.HeaderText = "Tên Môn học";
            this.TenMon.Name = "TenMon";
            // 
            // TinChi
            // 
            this.TinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TinChi.DataPropertyName = "TinChi";
            this.TinChi.HeaderText = "Tín chỉ";
            this.TinChi.Name = "TinChi";
            this.TinChi.Width = 66;
            // 
            // dtgvLopHoc
            // 
            this.dtgvLopHoc.AllowUserToAddRows = false;
            this.dtgvLopHoc.AllowUserToResizeColumns = false;
            this.dtgvLopHoc.AllowUserToResizeRows = false;
            this.dtgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.MaGV,
            this.tenGV,
            this.HocKy,
            this.namhoc,
            this.siso});
            this.dtgvLopHoc.Location = new System.Drawing.Point(13, 194);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.ReadOnly = true;
            this.dtgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopHoc.Size = new System.Drawing.Size(500, 164);
            this.dtgvLopHoc.TabIndex = 3;
            this.dtgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick_1);
            // 
            // malop
            // 
            this.malop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.malop.DataPropertyName = "MaLop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            this.malop.Width = 64;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            this.MaGV.Visible = false;
            // 
            // tenGV
            // 
            this.tenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenGV.DataPropertyName = "HoTenGV";
            this.tenGV.HeaderText = "Giảng viên";
            this.tenGV.Name = "tenGV";
            this.tenGV.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Width = 67;
            // 
            // namhoc
            // 
            this.namhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namhoc.DataPropertyName = "NamHoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.Name = "namhoc";
            this.namhoc.ReadOnly = true;
            this.namhoc.Width = 75;
            // 
            // siso
            // 
            this.siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siso.DataPropertyName = "SiSo";
            this.siso.HeaderText = "Sỉ số";
            this.siso.Name = "siso";
            this.siso.ReadOnly = true;
            this.siso.Width = 55;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(263, 433);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(88, 23);
            this.btnNewClass.TabIndex = 4;
            this.btnNewClass.Text = "Mở lớp học mới";
            this.btnNewClass.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAdd
            // 
            this.btnUpdateAdd.Location = new System.Drawing.Point(357, 433);
            this.btnUpdateAdd.Name = "btnUpdateAdd";
            this.btnUpdateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdd.TabIndex = 25;
            this.btnUpdateAdd.Text = "Cập nhật";
            this.btnUpdateAdd.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(438, 433);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(265, 3);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.ReadOnly = true;
            this.txtTenGV.Size = new System.Drawing.Size(147, 20);
            this.txtTenGV.TabIndex = 18;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(94, 167);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(93, 21);
            this.cbNamHoc.TabIndex = 34;
            // 
            // cbHK
            // 
            this.cbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(12, 167);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(76, 21);
            this.cbHK.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNamHoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudSiSo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtMaGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Location = new System.Drawing.Point(13, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 56);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên GV:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(160, 30);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(84, 20);
            this.txtNamHoc.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Năm học:";
            // 
            // txtHK
            // 
            this.txtHK.Location = new System.Drawing.Point(49, 30);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(50, 20);
            this.txtHK.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Học Kỳ:";
            // 
            // nudSiSo
            // 
            this.nudSiSo.Location = new System.Drawing.Point(457, 4);
            this.nudSiSo.Name = "nudSiSo";
            this.nudSiSo.Size = new System.Drawing.Size(40, 20);
            this.nudSiSo.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Sỉ số:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(160, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(50, 20);
            this.txtMaGV.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mã GV:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(49, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(50, 20);
            this.txtMaLop.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mã lớp:";
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(410, 165);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateSubject.TabIndex = 36;
            this.btnUpdateSubject.Text = "Cập nhật môn học";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 468);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnUpdateAdd);
            this.Controls.Add(this.btnNewClass);
            this.Controls.Add(this.dtgvLopHoc);
            this.Controls.Add(this.dtgvMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMonHoc;
        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnUpdateAdd;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtTenGV;
        public System.Windows.Forms.ComboBox cbNamHoc;
        public System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudSiSo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}