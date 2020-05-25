using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanSo;

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
            int tu01 = int.Parse(txtTuSo01.Text);
            int mau01 = int.Parse(txtMauSo01.Text);
            int tu02 = int.Parse(txtTuSo02.Text);
            int mau02 = int.Parse(txtMauSo02.Text);

            PhanSo ps01 = new PhanSo(tu01, mau01);
            PhanSo ps02 = new PhanSo(tu02, mau02);

            if (PhanSo.sosanh(ps01, ps02) == true)
                MessageBox.Show("Hai phân số bằng nhau!","Thông báo");
            else
                MessageBox.Show("Hai phân số không bằng nhau!", "Thông báo");
        }
    }
}
