﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views
{
    public partial class Thongtin : Form
    {
        public Thongtin()
        {
            InitializeComponent();
            rtxtDes.Text = "Chương trình Quản lý thông tin \n2018";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
