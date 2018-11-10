namespace QuanLySinhVien.Views
{
    partial class QuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNguoiDung));
            this.dtgvDSND = new System.Windows.Forms.DataGridView();
            this.maso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HovaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDKLop = new System.Windows.Forms.Button();
            this.btnClassofPerson = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.cbTuCach = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChonAnh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.datetimeSN = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbLoaiTC = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSND)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSND
            // 
            this.dtgvDSND.AllowUserToAddRows = false;
            this.dtgvDSND.AllowUserToDeleteRows = false;
            this.dtgvDSND.AllowUserToOrderColumns = true;
            this.dtgvDSND.AllowUserToResizeColumns = false;
            this.dtgvDSND.AllowUserToResizeRows = false;
            this.dtgvDSND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSND.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvDSND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maso,
            this.TuCach,
            this.HovaTen,
            this.Ten,
            this.birthday,
            this.GioiTinh,
            this.QueQuan});
            this.dtgvDSND.Location = new System.Drawing.Point(12, 40);
            this.dtgvDSND.Name = "dtgvDSND";
            this.dtgvDSND.ReadOnly = true;
            this.dtgvDSND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSND.Size = new System.Drawing.Size(664, 362);
            this.dtgvDSND.TabIndex = 0;
            this.dtgvDSND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSND_CellClick);
            // 
            // maso
            // 
            this.maso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maso.DataPropertyName = "MSSV";
            this.maso.HeaderText = "Mã Số";
            this.maso.Name = "maso";
            this.maso.ReadOnly = true;
            this.maso.Width = 63;
            // 
            // TuCach
            // 
            this.TuCach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TuCach.DataPropertyName = "TuCach";
            this.TuCach.HeaderText = "Tư Cách";
            this.TuCach.Name = "TuCach";
            this.TuCach.ReadOnly = true;
            this.TuCach.Width = 73;
            // 
            // HovaTen
            // 
            this.HovaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HovaTen.DataPropertyName = "Ho";
            this.HovaTen.HeaderText = "Họ";
            this.HovaTen.Name = "HovaTen";
            this.HovaTen.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthday.DataPropertyName = "NgayThangNamSinh";
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 76;
            // 
            // QueQuan
            // 
            this.QueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại tìm kiếm:";
            // 
            // cbTK
            // 
            this.cbTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Items.AddRange(new object[] {
            "Mã Số",
            "Tên"});
            this.cbTK.Location = new System.Drawing.Point(91, 12);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(74, 21);
            this.cbTK.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDKLop);
            this.groupBox1.Controls.Add(this.btnClassofPerson);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.cbTuCach);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtChonAnh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.datetimeSN);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.pbAnh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Location = new System.Drawing.Point(682, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnDKLop
            // 
            this.btnDKLop.Location = new System.Drawing.Point(6, 279);
            this.btnDKLop.Name = "btnDKLop";
            this.btnDKLop.Size = new System.Drawing.Size(156, 23);
            this.btnDKLop.TabIndex = 43;
            this.btnDKLop.Text = "Đăng Kí Lớp Học";
            this.btnDKLop.UseVisualStyleBackColor = true;
            this.btnDKLop.Visible = false;
            // 
            // btnClassofPerson
            // 
            this.btnClassofPerson.Location = new System.Drawing.Point(5, 308);
            this.btnClassofPerson.Name = "btnClassofPerson";
            this.btnClassofPerson.Size = new System.Drawing.Size(156, 23);
            this.btnClassofPerson.TabIndex = 42;
            this.btnClassofPerson.Text = "Lớp học";
            this.btnClassofPerson.UseVisualStyleBackColor = true;
            this.btnClassofPerson.Click += new System.EventHandler(this.btnClassofPerson_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Mã:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Password:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(239, 198);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(29, 23);
            this.btnChonAnh.TabIndex = 35;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(199, 45);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(69, 20);
            this.txtMa.TabIndex = 41;
            // 
            // cbTuCach
            // 
            this.cbTuCach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTuCach.FormattingEnabled = true;
            this.cbTuCach.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giảng Viên"});
            this.cbTuCach.Location = new System.Drawing.Point(84, 173);
            this.cbTuCach.Name = "cbTuCach";
            this.cbTuCach.Size = new System.Drawing.Size(184, 21);
            this.cbTuCach.TabIndex = 34;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 252);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(78, 20);
            this.txtPass.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ảnh:";
            // 
            // txtChonAnh
            // 
            this.txtChonAnh.Location = new System.Drawing.Point(84, 200);
            this.txtChonAnh.Name = "txtChonAnh";
            this.txtChonAnh.ReadOnly = true;
            this.txtChonAnh.Size = new System.Drawing.Size(149, 20);
            this.txtChonAnh.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Tên ĐN:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(84, 95);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(184, 21);
            this.cbGioiTinh.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tên:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(84, 226);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(78, 20);
            this.txtTenDN.TabIndex = 37;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(84, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(78, 20);
            this.txtTen.TabIndex = 31;
            // 
            // datetimeSN
            // 
            this.datetimeSN.Location = new System.Drawing.Point(84, 71);
            this.datetimeSN.Name = "datetimeSN";
            this.datetimeSN.Size = new System.Drawing.Size(184, 20);
            this.datetimeSN.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(5, 337);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(84, 337);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(78, 23);
            this.btnCapNhat.TabIndex = 26;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.Image = ((System.Drawing.Image)(resources.GetObject("pbAnh.Image")));
            this.pbAnh.Location = new System.Drawing.Point(168, 236);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(100, 124);
            this.pbAnh.TabIndex = 4;
            this.pbAnh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tư cách:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(84, 148);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(184, 20);
            this.txtQueQuan.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ và tên lót:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(84, 122);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(184, 20);
            this.txtSdt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày sinh:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(84, 19);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(184, 20);
            this.txtHo.TabIndex = 19;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(881, 421);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(853, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm người dùng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(315, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(231, 13);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(78, 20);
            this.txtTk.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nội dung:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.Location = new System.Drawing.Point(682, 10);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(47, 23);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbLoaiTC
            // 
            this.cbLoaiTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTC.FormattingEnabled = true;
            this.cbLoaiTC.Items.AddRange(new object[] {
            "Tất Cả",
            "Sinh viên",
            "Giảng viên"});
            this.cbLoaiTC.Location = new System.Drawing.Point(597, 11);
            this.cbLoaiTC.Name = "cbLoaiTC";
            this.cbLoaiTC.Size = new System.Drawing.Size(79, 21);
            this.cbLoaiTC.TabIndex = 12;
            this.cbLoaiTC.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTC_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(522, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Loại tư cách:";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(735, 10);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(112, 23);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "Người dùng đã xoá";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Kí hiệu: Ở phần giới tính, 0 là Nữ, 1 là Nam";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(53, 431);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(228, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ở phần tư cách, 0 là Sinh viên, 1 là Giảng viên";
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 456);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.cbLoaiTC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDSND);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(984, 482);
            this.Name = "QuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSND)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker datetimeSN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChonAnh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbLoaiTC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn maso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HovaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClassofPerson;
        public System.Windows.Forms.ComboBox cbTuCach;
        public System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnDKLop;
    }
}