using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_HTC.Class
{
    class GiangVienClass
    {
        string MaGV, MaKhoa, Ho, Ten, HocVi, HocHam, ChuyenMon;


        public GiangVienClass(string maGV, string maKhoa, string ho, string ten, string hocVi, string hocHam, string chuyenMon)
        {
            MaGV = maGV;
            Ho = ho;
            Ten = ten;
            HocVi = hocVi;
            HocHam = hocHam;
            ChuyenMon = chuyenMon;
            MaKhoa = maKhoa;
        }

        public string maGV
        {
            get { return MaGV; }
            set { MaGV = value; }
        }
        public string ho
        {
            get { return Ho; }
            set { ho = value; }
        }
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public string maKhoa
        {
            get { return MaKhoa; }
            set { MaKhoa = value; }
        }
        public string hocVi
        {
            get { return HocVi; }
            set { HocVi = value; }
        }
        public string hocHam
        {
            get { return HocHam; }
            set { HocHam = value; }
        }
        public string chuyenMon
        {
            get { return ChuyenMon; }
            set { ChuyenMon = value; }
        }
    }
}
