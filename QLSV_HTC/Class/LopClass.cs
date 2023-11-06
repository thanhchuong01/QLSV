using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_HTC.Class
{
    class LopClass
    {
        string malop, tenlop, nienkhoa, makhoa;

        public LopClass(string malop, string tenlop, string nienkhoa, string makhoa)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.nienkhoa = nienkhoa;
            this.makhoa = makhoa;
        }

        public string MaLop
        {
            get { return malop; }
            set { malop = value; }
        }

        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }

        public string NienKhoa
        {
            get { return nienkhoa; }
            set { nienkhoa = value; }
        }

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }
    }
}
