using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanSo
{
    public class PhanSo
    {
        private int tuso, mauso;

        public PhanSo(int t, int m)
        {
            this.tuso = t;
            this.mauso = m;
        }

        public static bool sosanh(PhanSo ps01, PhanSo ps02)
        {
            int tu01 = ps01.tuso * ps02.mauso;
            int tu02 = ps02.tuso * ps01.mauso;

            return tu01 == tu02; 
        }
    }
}
