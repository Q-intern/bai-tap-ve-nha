using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = (double)nudA.Value;
            double b = (double)nudB.Value;
            double c = (double)nudC.Value;

            double delta = b * b - 4 * a * c;

            if (a == 0)
            {
                txtThongBao.Text = "Không phải phương trình bậc 2";
                return;
            }

            if (delta < 0)
            {
                txtThongBao.Text = "Phương trình vô nghiệm";
                txtX1.Text = "";
                txtX2.Text = "";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);

                txtThongBao.Text = "Phương trình có nghiệm kép";
                txtX1.Text = x.ToString();
                txtX2.Text = x.ToString();
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                txtThongBao.Text = "Phương trình có 2 nghiệm phân biệt";
                txtX1.Text = x1.ToString("0.##");
                txtX2.Text = x2.ToString("0.##");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtX1.ReadOnly = true;
            txtX2.ReadOnly = true;
        }
    }
}
