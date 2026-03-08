using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sv
{
    internal class SinhVienChuyenNganh : SinhVien
    {
        public string ChuyenNganh;
        public double DiemTB;

        public SinhVienChuyenNganh(string ma, string ten, DateTime ns,
                                   string cn, double dtb)
            : base(ma, ten, ns)
        {
            ChuyenNganh = cn;
            DiemTB = dtb;
        }

        public string XepLoai()
        {
            if (DiemTB >= 8)
                return "Giỏi";
            else if (DiemTB >= 7)
                return "Khá";
            else if (DiemTB >= 5)
                return "Trung bình";
            else
                return "Yếu";
        }

        public override string getInfor()
        {
            return base.getInfor() +
                   "\nChuyên ngành: " + ChuyenNganh +
                   "\nĐiểm TB: " + DiemTB +
                   "\nXếp loại: " + XepLoai();
        }
    }
}
