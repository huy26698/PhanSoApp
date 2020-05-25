using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn thoát","Thông báo",MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtTuSo01.Text);
            int b = int.Parse(txtMauSo01.Text);
        }
    }
}
