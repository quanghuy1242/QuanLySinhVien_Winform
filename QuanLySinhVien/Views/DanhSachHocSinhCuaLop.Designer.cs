namespace QuanLySinhVien.Views
{
    partial class DanhSachHocSinhCuaLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDs = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnUpdateDiem = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDs
            // 
            this.dtgvDs.AllowUserToAddRows = false;
            this.dtgvDs.AllowUserToResizeColumns = false;
            this.dtgvDs.AllowUserToResizeRows = false;
            this.dtgvDs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDs.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvDs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hovaten,
            this.DiemTK,
            this.DiemGK,
            this.DiemCK,
            this.TongKet,
            this.XepLoai});
            this.dtgvDs.Location = new System.Drawing.Point(12, 12);
            this.dtgvDs.Name = "dtgvDs";
            this.dtgvDs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvDs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDs.Size = new System.Drawing.Size(622, 189);
            this.dtgvDs.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(559, 207);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnUpdateDiem
            // 
            this.btnUpdateDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDiem.Location = new System.Drawing.Point(478, 207);
            this.btnUpdateDiem.Name = "btnUpdateDiem";
            this.btnUpdateDiem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDiem.TabIndex = 8;
            this.btnUpdateDiem.Text = "Cập nhật";
            this.btnUpdateDiem.UseVisualStyleBackColor = true;
            this.btnUpdateDiem.Click += new System.EventHandler(this.btnUpdateDiem_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(385, 207);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(87, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Tạo báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // mssv
            // 
            this.mssv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mssv.DataPropertyName = "MSSV";
            this.mssv.HeaderText = "MSSV";
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            this.mssv.Width = 62;
            // 
            // hovaten
            // 
            this.hovaten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hovaten.DataPropertyName = "tenSV";
            this.hovaten.HeaderText = "Họ Và Tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            this.hovaten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DiemTK
            // 
            this.DiemTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiemTK.DataPropertyName = "DiemTK";
            this.DiemTK.HeaderText = "Thường Kì";
            this.DiemTK.Name = "DiemTK";
            this.DiemTK.Width = 81;
            // 
            // DiemGK
            // 
            this.DiemGK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiemGK.DataPropertyName = "DiemGK";
            this.DiemGK.HeaderText = "Giữa Kỳ";
            this.DiemGK.Name = "DiemGK";
            this.DiemGK.Width = 69;
            // 
            // DiemCK
            // 
            this.DiemCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiemCK.DataPropertyName = "DiemCK";
            this.DiemCK.HeaderText = "Cuối Kỳ";
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.Width = 68;
            // 
            // TongKet
            // 
            this.TongKet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TongKet.DataPropertyName = "DiemTongKet";
            this.TongKet.HeaderText = "Tổng Kết";
            this.TongKet.Name = "TongKet";
            this.TongKet.ReadOnly = true;
            this.TongKet.Width = 76;
            // 
            // XepLoai
            // 
            this.XepLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.XepLoai.DataPropertyName = "XepLoai";
            this.XepLoai.HeaderText = "Xếp Loại";
            this.XepLoai.Name = "XepLoai";
            this.XepLoai.ReadOnly = true;
            this.XepLoai.Width = 74;
            // 
            // DanhSachHocSinhCuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 238);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdateDiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtgvDs);
            this.Name = "DanhSachHocSinhCuaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinhCuaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDs;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnUpdateDiem;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
    }
}