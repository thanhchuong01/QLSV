using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLSV_HTC.Reports
{
    public partial class InDSSVLop_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InDSSVLop_RP(string Khoa, string malop, string tenlop)
        {
            InitializeComponent();
            this.xrKHOA.Text = "KHOA " + Khoa.ToUpper();
            this.xrLop.Text = "LỚP " + tenlop;
        }

    }
}
