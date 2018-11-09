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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiem));
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReportMark = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvDiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDiem.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenMH,
            this.diemTK,
            this.diemGK,
            this.diemCK,
            this.diemTong,
            this.xepLoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDiem.Location = new System.Drawing.Point(12, 45);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.ReadOnly = true;
            this.dtgvDiem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDiem.Size = new System.Drawing.Size(580, 212);
            this.dtgvDiem.TabIndex = 4;
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
            this.diemCK.Width = 60;
            // 
            // diemTong
            // 
            this.diemTong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diemTong.DataPropertyName = "DiemTongKet";
            this.diemTong.HeaderText = "Tổng kết";
            this.diemTong.Name = "diemTong";
            this.diemTong.ReadOnly = true;
            this.diemTong.Width = 69;
            // 
            // xepLoai
            // 
            this.xepLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xepLoai.DataPropertyName = "XepLoai";
            this.xepLoai.HeaderText = "Xếp loại";
            this.xepLoai.Name = "xepLoai";
            this.xepLoai.ReadOnly = true;
            this.xepLoai.Width = 51;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(517, 272);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReportMark
            // 
            this.btnReportMark.Location = new System.Drawing.Point(424, 272);
            this.btnReportMark.Name = "btnReportMark";
            this.btnReportMark.Size = new System.Drawing.Size(87, 23);
            this.btnReportMark.TabIndex = 7;
            this.btnReportMark.Text = "Tạo báo cáo";
            this.btnReportMark.UseVisualStyleBackColor = true;
            this.btnReportMark.Click += new System.EventHandler(this.btnReportMark_Click);
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
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 302);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReportMark);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.cbHK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReportMark;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepLoai;
        public System.Windows.Forms.DataGridView dtgvDiem;
    }
}