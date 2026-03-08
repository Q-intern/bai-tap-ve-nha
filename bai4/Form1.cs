using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace bai4
{
    public partial class Form1 : Form
    {
        double so1;
        double so2;
        string pheptoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "1";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "2";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "3";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "4";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "5";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "6";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "7";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "8";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "9";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "0";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "+";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "/";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtManHinh.Text, null);
                txtManHinh.Text = result.ToString();
            }
            catch
            {
                txtManHinh.Text = "Error";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtManHinh.Clear();
        }
    }
}
