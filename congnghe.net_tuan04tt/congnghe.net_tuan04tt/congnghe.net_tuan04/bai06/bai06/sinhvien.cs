using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai06
{
    internal class sinhvien
    {
        public string hoVaTen { get; set; }
        public string masinhvien { get; set; }
        public string gioitinh { get; set; }
        public string ngoaingu { get; set; }
        public string dantoc { get; set; }

        public sinhvien(string hovaten, string masinhvien, string gioitinh, string ngoaingu, string dantoc)
        {
            this.hoVaTen = hovaten;
            this.masinhvien = masinhvien;
            this.gioitinh = gioitinh;
            this.ngoaingu = ngoaingu;
            this.dantoc = dantoc;
        }
    }
}
