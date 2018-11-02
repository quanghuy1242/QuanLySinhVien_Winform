namespace QuanLySinhVien.Views
{
    partial class KhoiPhucNguoiDung
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
            this.dtgvRestore = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTuCach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRestore
            // 
            this.dtgvRestore.AllowUserToAddRows = false;
            this.dtgvRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRestore.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvRestore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRestore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.TuCach,
            this.Ho,
            this.Ten,
            this.birthday,
            this.gioitinh,
            this.quequan});
            this.dtgvRestore.Location = new System.Drawing.Point(13, 13);
            this.dtgvRestore.Name = "dtgvRestore";
            this.dtgvRestore.ReadOnly = true;
            this.dtgvRestore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRestore.Size = new System.Drawing.Size(619, 270);
            this.dtgvRestore.TabIndex = 0;
            this.dtgvRestore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRestore_CellClick);
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manv.DataPropertyName = "MSSV";
            this.manv.HeaderText = "Mã số";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 61;
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
            // Ho
            // 
            this.Ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
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
            this.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthday.DataPropertyName = "NgayThangNamSinh";
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 70;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gioitinh.DataPropertyName = "GioiTinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 76;
            // 
            // quequan
            // 
            this.quequan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quequan.DataPropertyName = "QueQuan";
            this.quequan.HeaderText = "Quê Quán";
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            this.quequan.Width = 81;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(476, 289);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Khôi phục";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(557, 289);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMa.Location = new System.Drawing.Point(42, 291);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(46, 20);
            this.txtMa.TabIndex = 4;
            // 
            // txtTuCach
            // 
            this.txtTuCach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTuCach.Location = new System.Drawing.Point(342, 291);
            this.txtTuCach.Name = "txtTuCach";
            this.txtTuCach.ReadOnly = true;
            this.txtTuCach.Size = new System.Drawing.Size(38, 20);
            this.txtTuCach.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tư cách:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHoTen.Location = new System.Drawing.Point(157, 291);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(121, 20);
            this.txtHoTen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ và tên:";
            // 
            // KhoiPhucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 321);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuCach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dtgvRestore);
            this.Name = "KhoiPhucNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục người dùng";
            this.Load += new System.EventHandler(this.KhoiPhucNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRestore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTuCach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
    }
}