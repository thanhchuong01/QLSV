using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_HTC.Class
{
    class LopTinChiClass
    {
        string nienkhoa, mamh, magv, makhoa;
        int maltc, hocky, nhom, sosvtt;
        bool huylop;

        public LopTinChiClass(int maltc, string nienkhoa, string mamh, string magv, string makhoa, int hocky, int nhom, int sosvtt, bool huylop)
        {
            this.maltc = maltc;
            this.nienkhoa = nienkhoa;
            this.mamh = mamh;
            this.magv = magv;
            this.makhoa = makhoa;
            this.hocky = hocky;
            this.nhom = nhom;
            this.sosvtt = sosvtt;
            this.huylop = huylop;
        }

        public int MaLTC
        {
            get { return maltc; }
            set { maltc = value; }
        }

        public string NienKhoa
        {
            get { return nienkhoa; }
            set { nienkhoa = value; }
        }

        public string MaMonHoc
        {
            get { return mamh; }
            set { mamh = value; }
        }

        public string MaGiangVien
        {
            get { return magv; }
            set { magv = value; }
        }

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }

        public int HocKy
        {
            get { return hocky; }
            set { hocky = value; }
        }

        public int Nhom
        {
            get { return nhom; }
            set { nhom = value; }
        }

        public int SoSVTT
        {
            get { return sosvtt; }
            set { sosvtt = value; }
        }

        public bool HuyLop
        {
            get { return huylop; }
            set { huylop = value; }
        }
    }
}
