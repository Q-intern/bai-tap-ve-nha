using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_sv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboChuyenNganh.Items.Add("CNTT");
            cboChuyenNganh.Items.Add("HTTTQL");
            cboChuyenNganh.Items.Add("Ngân hàng");
            cboChuyenNganh.Items.Add("Tài chính");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SinhVienChuyenNganh sv = new SinhVienChuyenNganh(
            txtMaSV.Text,
            txtTen.Text,
            dtNgaySinh.Value,
            cboChuyenNganh.Text,
            double.Parse(txtDiemTB.Text)
             );

            lblKQ.Text = sv.getInfor();
        }
    }
}
