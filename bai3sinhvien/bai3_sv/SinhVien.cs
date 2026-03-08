using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sv
{
    internal class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public DateTime NgaySinh;

        public SinhVien(string m, string h, DateTime n)
        {
            MaSV = m;
            HoTen = h;
            NgaySinh = n;
        }

        public virtual string getInfor()
        {
            return MaSV + " - " + HoTen + " - " + NgaySinh.ToShortDateString();
        }
    }
}
