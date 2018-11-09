namespace QuanLySinhVien.Views
{
    partial class DangKiHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKiHocPhan));
            this.dtgvLopChuaDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopChuaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLopChuaDK
            // 
            this.dtgvLopChuaDK.AllowUserToAddRows = false;
            this.dtgvLopChuaDK.AllowUserToDeleteRows = false;
            this.dtgvLopChuaDK.AllowUserToResizeColumns = false;
            this.dtgvLopChuaDK.AllowUserToResizeRows = false;
            this.dtgvLopChuaDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvLopChuaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopChuaDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenMon,
            this.TenGV,
            this.HocKy,
            this.NamHoc,
            this.SLDDK,
            this.Siso});
            this.dtgvLopChuaDK.Location = new System.Drawing.Point(12, 57);
            this.dtgvLopChuaDK.Name = "dtgvLopChuaDK";
            this.dtgvLopChuaDK.ReadOnly = true;
            this.dtgvLopChuaDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopChuaDK.Size = new System.Drawing.Size(651, 252);
            this.dtgvLopChuaDK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁC LỚP HỌC CHƯA ĐĂNG KÍ";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.Location = new System.Drawing.Point(508, 315);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng Kí";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Để huỷ lớp học chưa có điểm, vui lòng liên hệ với Admin";
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 68;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenMon.DataPropertyName = "TenMH";
            this.TenMon.HeaderText = "Tên Môn";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 75;
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGV.DataPropertyName = "hoten";
            this.TenGV.HeaderText = "Giảng Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
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
            // NamHoc
            // 
            this.NamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
            this.NamHoc.Width = 77;
            // 
            // SLDDK
            // 
            this.SLDDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SLDDK.DataPropertyName = "DaDK";
            this.SLDDK.HeaderText = "Đã ĐK";
            this.SLDDK.Name = "SLDDK";
            this.SLDDK.ReadOnly = true;
            this.SLDDK.Width = 64;
            // 
            // Siso
            // 
            this.Siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Siso.DataPropertyName = "SiSo";
            this.Siso.HeaderText = "Sỉ số";
            this.Siso.Name = "Siso";
            this.Siso.ReadOnly = true;
            this.Siso.Width = 55;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(589, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangKiHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvLopChuaDK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKiHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí lớp học mới";
            this.Load += new System.EventHandler(this.DangKiHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopChuaDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLopChuaDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siso;
        private System.Windows.Forms.Button button1;
    }
}