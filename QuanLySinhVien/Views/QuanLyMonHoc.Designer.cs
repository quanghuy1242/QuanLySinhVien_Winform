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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMonHoc));
            this.dtgvMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnUpdateAdd = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNamHoc = new System.Windows.Forms.ComboBox();
            this.txtHK = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.ComboBox();
            this.txtMaGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSiSo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnHuyThem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvNamHocHocKy = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLopHuy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.RadioButton();
            this.kcp = new System.Windows.Forms.RadioButton();
            this.updateStateAllow = new System.Windows.Forms.Button();
            this.mainNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hientai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNamHocHocKy)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.dtgvMonHoc.Size = new System.Drawing.Size(359, 163);
            this.dtgvMonHoc.TabIndex = 0;
            this.dtgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick);
            this.dtgvMonHoc.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvMonHoc_CellMouseDown);
            this.dtgvMonHoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvMonHoc_MouseClick);
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
            this.TenLop,
            this.MaGV,
            this.tenGV,
            this.MonHoc,
            this.HocKy,
            this.namhoc,
            this.siso});
            this.dtgvLopHoc.Location = new System.Drawing.Point(13, 241);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.ReadOnly = true;
            this.dtgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopHoc.Size = new System.Drawing.Size(625, 164);
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
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
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
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "TenMH";
            this.MonHoc.HeaderText = "Môn Học";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Width = 62;
            // 
            // namhoc
            // 
            this.namhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namhoc.DataPropertyName = "NamHoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.Name = "namhoc";
            this.namhoc.ReadOnly = true;
            this.namhoc.Width = 69;
            // 
            // siso
            // 
            this.siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.siso.DataPropertyName = "SiSo";
            this.siso.HeaderText = "Sỉ số";
            this.siso.Name = "siso";
            this.siso.ReadOnly = true;
            this.siso.Width = 51;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(12, 476);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(88, 23);
            this.btnNewClass.TabIndex = 4;
            this.btnNewClass.Text = "Mở lớp học mới";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // btnUpdateAdd
            // 
            this.btnUpdateAdd.Location = new System.Drawing.Point(106, 476);
            this.btnUpdateAdd.Name = "btnUpdateAdd";
            this.btnUpdateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdd.TabIndex = 25;
            this.btnUpdateAdd.Text = "Cập nhật";
            this.btnUpdateAdd.UseVisualStyleBackColor = true;
            this.btnUpdateAdd.Click += new System.EventHandler(this.btnUpdateAdd_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(566, 476);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(94, 183);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(93, 21);
            this.cbNamHoc.TabIndex = 34;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // cbHK
            // 
            this.cbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Location = new System.Drawing.Point(12, 183);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(76, 21);
            this.cbHK.TabIndex = 32;
            this.cbHK.SelectedIndexChanged += new System.EventHandler(this.cbHK_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNamHoc);
            this.panel1.Controls.Add(this.txtHK);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Controls.Add(this.txtMaGV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudSiSo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 59);
            this.panel1.TabIndex = 35;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNamHoc.FormattingEnabled = true;
            this.txtNamHoc.Location = new System.Drawing.Point(377, 5);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(117, 21);
            this.txtNamHoc.TabIndex = 50;
            // 
            // txtHK
            // 
            this.txtHK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHK.FormattingEnabled = true;
            this.txtHK.Location = new System.Drawing.Point(209, 5);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(103, 21);
            this.txtHK.TabIndex = 40;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(59, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(91, 20);
            this.txtTenLop.TabIndex = 49;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(551, 31);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(70, 20);
            this.txtMaLop.TabIndex = 48;
            this.txtMaLop.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tên Lớp:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenGV.FormattingEnabled = true;
            this.txtTenGV.Location = new System.Drawing.Point(209, 31);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(162, 21);
            this.txtTenGV.TabIndex = 40;
            this.txtTenGV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMaGV
            // 
            this.txtMaGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaGV.FormattingEnabled = true;
            this.txtMaGV.Location = new System.Drawing.Point(59, 31);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(91, 21);
            this.txtMaGV.TabIndex = 40;
            this.txtMaGV.SelectedIndexChanged += new System.EventHandler(this.txtMaGV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tên GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Năm học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Học Kỳ:";
            // 
            // nudSiSo
            // 
            this.nudSiSo.Location = new System.Drawing.Point(416, 31);
            this.nudSiSo.Name = "nudSiSo";
            this.nudSiSo.Size = new System.Drawing.Size(78, 20);
            this.nudSiSo.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Sỉ số:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mã GV:";
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(271, 181);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateSubject.TabIndex = 36;
            this.btnUpdateSubject.Text = "Cập nhật môn học";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnHuyThem
            // 
            this.btnHuyThem.Location = new System.Drawing.Point(185, 476);
            this.btnHuyThem.Name = "btnHuyThem";
            this.btnHuyThem.Size = new System.Drawing.Size(75, 23);
            this.btnHuyThem.TabIndex = 38;
            this.btnHuyThem.Text = "Huỷ";
            this.btnHuyThem.UseVisualStyleBackColor = true;
            this.btnHuyThem.Click += new System.EventHandler(this.btnHuyThem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(380, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 223);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtgvNamHocHocKy);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Học Kỳ, Năm Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvNamHocHocKy
            // 
            this.dtgvNamHocHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNamHocHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainNamHoc,
            this.mainHK,
            this.hientai});
            this.dtgvNamHocHocKy.Location = new System.Drawing.Point(3, 7);
            this.dtgvNamHocHocKy.Name = "dtgvNamHocHocKy";
            this.dtgvNamHocHocKy.Size = new System.Drawing.Size(244, 155);
            this.dtgvNamHocHocKy.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHuy);
            this.tabPage1.Controls.Add(this.btnDK);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMaLopHuy);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtMaSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Huỷ lớp sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(129, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 55;
            this.btnHuy.Text = "Huỷ lớp";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(48, 120);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(75, 23);
            this.btnDK.TabIndex = 54;
            this.btnDK.Text = "Đăng kí";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "HUỶ LỚP HỌC SINH VIÊN";
            // 
            // txtMaLopHuy
            // 
            this.txtMaLopHuy.Location = new System.Drawing.Point(109, 89);
            this.txtMaLopHuy.Name = "txtMaLopHuy";
            this.txtMaLopHuy.Size = new System.Drawing.Size(116, 20);
            this.txtMaLopHuy.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Mã Sinh viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Mã lớp:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(109, 63);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(116, 20);
            this.txtMaSV.TabIndex = 51;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáMônHọcToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // xoáMônHọcToolStripMenuItem
            // 
            this.xoáMônHọcToolStripMenuItem.Name = "xoáMônHọcToolStripMenuItem";
            this.xoáMônHọcToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.xoáMônHọcToolStripMenuItem.Text = "Xoá môn học";
            this.xoáMônHọcToolStripMenuItem.Click += new System.EventHandler(this.xoáMônHọcToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Giảng viên cập nhật điểm trong HK này:";
            // 
            // cp
            // 
            this.cp.AutoSize = true;
            this.cp.Location = new System.Drawing.Point(215, 215);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(38, 17);
            this.cp.TabIndex = 41;
            this.cp.TabStop = true;
            this.cp.Text = "Có";
            this.cp.UseVisualStyleBackColor = true;
            // 
            // kcp
            // 
            this.kcp.AutoSize = true;
            this.kcp.Location = new System.Drawing.Point(259, 215);
            this.kcp.Name = "kcp";
            this.kcp.Size = new System.Drawing.Size(56, 17);
            this.kcp.TabIndex = 42;
            this.kcp.TabStop = true;
            this.kcp.Text = "Không";
            this.kcp.UseVisualStyleBackColor = true;
            // 
            // updateStateAllow
            // 
            this.updateStateAllow.Location = new System.Drawing.Point(317, 212);
            this.updateStateAllow.Name = "updateStateAllow";
            this.updateStateAllow.Size = new System.Drawing.Size(57, 23);
            this.updateStateAllow.TabIndex = 43;
            this.updateStateAllow.Text = "Thay đổi";
            this.updateStateAllow.UseVisualStyleBackColor = true;
            this.updateStateAllow.Click += new System.EventHandler(this.updateStateAllow_Click);
            // 
            // mainNamHoc
            // 
            this.mainNamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainNamHoc.DataPropertyName = "NamHoc";
            this.mainNamHoc.HeaderText = "Năm học";
            this.mainNamHoc.Name = "mainNamHoc";
            // 
            // mainHK
            // 
            this.mainHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainHK.DataPropertyName = "HocKy";
            this.mainHK.HeaderText = "Học Kỳ";
            this.mainHK.Name = "mainHK";
            this.mainHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // hientai
            // 
            this.hientai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hientai.DataPropertyName = "HienTai";
            this.hientai.HeaderText = "Now";
            this.hientai.Name = "hientai";
            this.hientai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hientai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hientai.Width = 35;
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 508);
            this.Controls.Add(this.updateStateAllow);
            this.Controls.Add(this.kcp);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHuyThem);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nội dung";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNamHocHocKy)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMonHoc;
        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnUpdateAdd;
        private System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.ComboBox cbNamHoc;
        public System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudSiSo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyThem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLopHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtMaGV;
        private System.Windows.Forms.ComboBox txtTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox txtNamHoc;
        private System.Windows.Forms.ComboBox txtHK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvNamHocHocKy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoáMônHọcToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton cp;
        private System.Windows.Forms.RadioButton kcp;
        private System.Windows.Forms.Button updateStateAllow;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn hientai;
    }
}