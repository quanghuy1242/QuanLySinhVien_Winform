namespace QuanLySinhVien.Views
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTenLot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGioiTInh = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxDieuKhoan = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtChonAnh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nếu bạn muốn đăng kí với tư cách Giảng viên, hãy liên hệ với Admin để nhận giúp đ" +
    "ỡ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(158, 68);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(248, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtTenLot
            // 
            this.txtTenLot.Location = new System.Drawing.Point(159, 120);
            this.txtTenLot.Name = "txtTenLot";
            this.txtTenLot.Size = new System.Drawing.Size(248, 20);
            this.txtTenLot.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ và tên đệm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày tháng năm sinh:";
            // 
            // datetimeBirthday
            // 
            this.datetimeBirthday.Location = new System.Drawing.Point(159, 172);
            this.datetimeBirthday.Name = "datetimeBirthday";
            this.datetimeBirthday.Size = new System.Drawing.Size(248, 20);
            this.datetimeBirthday.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới tính:";
            // 
            // cbGioiTInh
            // 
            this.cbGioiTInh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTInh.FormattingEnabled = true;
            this.cbGioiTInh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTInh.Location = new System.Drawing.Point(159, 198);
            this.cbGioiTInh.Name = "cbGioiTInh";
            this.cbGioiTInh.Size = new System.Drawing.Size(248, 21);
            this.cbGioiTInh.TabIndex = 6;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(159, 225);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(248, 20);
            this.txtSdt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số điện thoại:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(159, 251);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(248, 20);
            this.txtQueQuan.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quê Quán:";
            // 
            // checkBoxDieuKhoan
            // 
            this.checkBoxDieuKhoan.AutoSize = true;
            this.checkBoxDieuKhoan.Location = new System.Drawing.Point(41, 317);
            this.checkBoxDieuKhoan.Name = "checkBoxDieuKhoan";
            this.checkBoxDieuKhoan.Size = new System.Drawing.Size(344, 17);
            this.checkBoxDieuKhoan.TabIndex = 11;
            this.checkBoxDieuKhoan.Text = "Bằng việc đăng kí, bạn chấp nhận các điều khoản của an quản lý";
            this.checkBoxDieuKhoan.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(94, 349);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng kí";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(256, 349);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(175, 349);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtChonAnh
            // 
            this.txtChonAnh.Location = new System.Drawing.Point(159, 278);
            this.txtChonAnh.Name = "txtChonAnh";
            this.txtChonAnh.ReadOnly = true;
            this.txtChonAnh.Size = new System.Drawing.Size(213, 20);
            this.txtChonAnh.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ảnh:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(159, 146);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(248, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Password:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(378, 277);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(29, 23);
            this.btnChonAnh.TabIndex = 10;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(158, 94);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(248, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tên:";
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 384);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChonAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.checkBoxDieuKhoan);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGioiTInh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datetimeBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenLot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtTenLot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimeBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGioiTInh;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxDieuKhoan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtChonAnh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label11;
    }
}