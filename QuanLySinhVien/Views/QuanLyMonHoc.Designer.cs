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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.dtgvMonHoc.Size = new System.Drawing.Size(394, 148);
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
            this.dtgvLopHoc.Size = new System.Drawing.Size(629, 164);
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
            this.btnNewClass.Location = new System.Drawing.Point(391, 407);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(88, 23);
            this.btnNewClass.TabIndex = 4;
            this.btnNewClass.Text = "Mở lớp học mới";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // btnUpdateAdd
            // 
            this.btnUpdateAdd.Location = new System.Drawing.Point(485, 407);
            this.btnUpdateAdd.Name = "btnUpdateAdd";
            this.btnUpdateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdd.TabIndex = 25;
            this.btnUpdateAdd.Text = "Cập nhật";
            this.btnUpdateAdd.UseVisualStyleBackColor = true;
            this.btnUpdateAdd.Click += new System.EventHandler(this.btnUpdateAdd_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(566, 407);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(206, 4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.ReadOnly = true;
            this.txtTenGV.Size = new System.Drawing.Size(122, 20);
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
            this.panel1.Size = new System.Drawing.Size(629, 31);
            this.panel1.TabIndex = 35;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(551, 6);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(70, 20);
            this.txtNamHoc.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Năm:";
            // 
            // txtHK
            // 
            this.txtHK.Location = new System.Drawing.Point(473, 6);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(36, 20);
            this.txtHK.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Học Kỳ:";
            // 
            // nudSiSo
            // 
            this.nudSiSo.Location = new System.Drawing.Point(373, 4);
            this.nudSiSo.Name = "nudSiSo";
            this.nudSiSo.Size = new System.Drawing.Size(40, 20);
            this.nudSiSo.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Sỉ số:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(150, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(50, 20);
            this.txtMaGV.TabIndex = 34;
            this.txtMaGV.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
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
            this.btnUpdateSubject.Location = new System.Drawing.Point(304, 165);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateSubject.TabIndex = 36;
            this.btnUpdateSubject.Text = "Cập nhật môn học";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(414, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 175);
            this.panel2.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Huỷ lớp đã đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mã lớp huỷ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "HUỶ LỚP HỌC";
            // 
            // btnHuyThem
            // 
            this.btnHuyThem.Location = new System.Drawing.Point(310, 407);
            this.btnHuyThem.Name = "btnHuyThem";
            this.btnHuyThem.Size = new System.Drawing.Size(75, 23);
            this.btnHuyThem.TabIndex = 38;
            this.btnHuyThem.Text = "Huỷ";
            this.btnHuyThem.UseVisualStyleBackColor = true;
            this.btnHuyThem.Click += new System.EventHandler(this.btnHuyThem_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 437);
            this.Controls.Add(this.btnHuyThem);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuyThem;
    }
}