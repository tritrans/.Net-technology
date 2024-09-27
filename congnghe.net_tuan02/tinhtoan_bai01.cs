using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congnghe.net_tuan02
{
    internal class tinhtoan_bai01
    {
        float a, b;
        public float b1
        {
            get { return b; }
            set { b = value; }
        }
        public float a1
        {
            get { return a; }
            set { a = value; }
        }
        public tinhtoan_bai01() { a = b = 0; }
        public tinhtoan_bai01(float a, float b)
        {
            a1 = a;
            b1 = b;
        }
        public float Cong ()
        {
            return a1 + b1;
        }
        public float Tru()
        {
            return a1 - b1;
        }
        public float nhan()
        {
            return a1 *b1;
        }
        public float Chia()
        {
            return a1 / b1;
        }
    }
}
