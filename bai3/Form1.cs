using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            rad5.Visible = chkGiamGia.Checked;
            rad10.Visible = chkGiamGia.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad5.Visible = false;
            rad10.Visible = false;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            double tong = dongia * soluong;

            if (chkGiamGia.Checked)
            {
                if (rad5.Checked)
                    tong = tong * 0.95;

                if (rad10.Checked)
                    tong = tong * 0.9;
            }

            txtTongTien.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
