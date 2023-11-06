using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_HTC.Class
{
    class MonHocClass
    {
        string mamh, tenmh;
        int sotietlt, sotietth;

        public MonHocClass(string mamh, string tenmh, int sotietlt, int sotietth)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.sotietlt = sotietlt;
            this.sotietth = sotietth;
        }

        public string TenMonHoc
        {
            get { return tenmh; }
            set{ tenmh = value; }
        }

        public string MaMonHoc
        {
            get { return mamh; }
            set { mamh = value; }
        }

        public int SoTietLT
        {
            get { return sotietlt; }
            set { sotietlt = value; }
        }

        public int SoTietTH
        {
            get { return sotietth; }
            set { sotietth = value; }
        }

    }
}
