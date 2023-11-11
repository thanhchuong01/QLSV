using QLSV_HTC.Forms;
using QLSV_HTC.FormRP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_HTC.Reports;

namespace QLSV_HTC
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool check = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void logout()
        {
            Program.AuthUserID = string.Empty;
            Program.AuthLogin = string.Empty;
            Program.AuthPassword = string.Empty;
            Program.AuthGroup = string.Empty;
            Program.AuthHoten = string.Empty;

            Program.MaKhoa = "";
            Program.Conn.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            Program.LoginForm.StartPosition = FormStartPosition.CenterScreen;
            Program.LoginForm.Show();
            Program.Bds_Dspm.RemoveFilter();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set thông tin dưới status trip
            statusStrip1.Items[0].Text = string.Format("MÃ SỐ: {0}", Program.AuthUserID);
            statusStrip1.Items[1].Text = string.Format("HỌ VÀ TÊN: {0}", Program.AuthHoten);
            statusStrip1.Items[2].Text = string.Format("NHÓM: {0}", Program.AuthGroup);

            //Hiện tính năng cho mỗi quyền khác nhau
            if (Program.AuthGroup == "SV")
            {
                usersGroup.Visible = false;
            }
            if (Program.AuthGroup == "PGV")
            {
                barBtnDiem.Enabled = false;
            }
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void registerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(AddLoginForm));
        }


        private void barBtnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(SinhVienForm));
        }

        private void barBtnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(MonHocForm));
        }

        private void barBtnLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(MoLopTinChiForm));
        }
        private void barBtnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(LopForm));
        }
        
        private void barBtnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                ShowMdiChildren(typeof(DiemForm));
            }
        
       private void barBtnDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
                ShowMdiChildren(typeof(DangKyLTCForm));
       }

       private void BtnInDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
               ShowMdiChildren(typeof(InDSSV));
       }

       private void BtnInPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
            ShowMdiChildren(typeof(InPhieuDiem));
       }

       private void BtnInBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
                ShowMdiChildren(typeof(InDiemForm));
       }
                   
       private void BtnInBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
                ShowMdiChildren(typeof(InBangDiemTongKet));
       }

       
        private void BtnInDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InDSLOPTINCHI));
        }

        private void barBtnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(GiangVienForm));
        }
    } 
    
}