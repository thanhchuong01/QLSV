
namespace QLSV_HTC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.loginBtn = new DevExpress.XtraBars.BarButtonItem();
            this.logoutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.registerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMH = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.quanLyPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dangKyPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.baoCaoPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.loginBtn,
            this.logoutBtn,
            this.BtnInDSSV,
            this.BtnInDSLTC,
            this.BtnInPhieuDiem,
            this.BtnInBDMH,
            this.BtnInBDTK,
            this.registerBtn,
            this.barButtonItem9,
            this.barBtnMH,
            this.barBtnLTC,
            this.barBtnSV,
            this.barBtnDiem,
            this.barBtnLop,
            this.barBtnDKLTC,
            this.barBtnGV});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.baoCaoPage});
            this.ribbonControl1.Size = new System.Drawing.Size(1056, 158);
            // 
            // loginBtn
            // 
            this.loginBtn.Caption = "Đăng nhập";
            this.loginBtn.Enabled = false;
            this.loginBtn.Id = 1;
            this.loginBtn.ImageOptions.Image = global::QLSV_HTC.Properties.Resources.login;
            this.loginBtn.LargeWidth = 80;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Caption = "Đăng xuất";
            this.logoutBtn.Id = 2;
            this.logoutBtn.ImageOptions.Image = global::QLSV_HTC.Properties.Resources.logout;
            this.logoutBtn.LargeWidth = 80;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.logoutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logoutBtn_ItemClick);
            // 
            // BtnInDSSV
            // 
            this.BtnInDSSV.Caption = "Danh sách sinh viên";
            this.BtnInDSSV.Id = 4;
            this.BtnInDSSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInDSSV.ImageOptions.Image")));
            this.BtnInDSSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInDSSV.ImageOptions.LargeImage")));
            this.BtnInDSSV.LargeWidth = 80;
            this.BtnInDSSV.Name = "BtnInDSSV";
            this.BtnInDSSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnInDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInDSSV_ItemClick);
            // 
            // BtnInDSLTC
            // 
            this.BtnInDSLTC.Caption = "Danh sách lớp tín chỉ";
            this.BtnInDSLTC.Id = 5;
            this.BtnInDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInDSL.ImageOptions.Image")));
            this.BtnInDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInDSL.ImageOptions.LargeImage")));
            this.BtnInDSLTC.LargeWidth = 80;
            this.BtnInDSLTC.Name = "BtnInDSLTC";
            this.BtnInDSLTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnInDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInDSLTC_ItemClick);
            // 
            // BtnInPhieuDiem
            // 
            this.BtnInPhieuDiem.Caption = "Phiếu điểm";
            this.BtnInPhieuDiem.Id = 6;
            this.BtnInPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInPhieuDiem.ImageOptions.Image")));
            this.BtnInPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInPhieuDiem.ImageOptions.LargeImage")));
            this.BtnInPhieuDiem.LargeWidth = 80;
            this.BtnInPhieuDiem.Name = "BtnInPhieuDiem";
            this.BtnInPhieuDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnInPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInPhieuDiem_ItemClick);
            // 
            // BtnInBDMH
            // 
            this.BtnInBDMH.Caption = "Bảng điểm môn học";
            this.BtnInBDMH.Id = 7;
            this.BtnInBDMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInBDMH.ImageOptions.Image")));
            this.BtnInBDMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInBDMH.ImageOptions.LargeImage")));
            this.BtnInBDMH.LargeWidth = 80;
            this.BtnInBDMH.Name = "BtnInBDMH";
            this.BtnInBDMH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnInBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInBDMH_ItemClick);
            // 
            // BtnInBDTK
            // 
            this.BtnInBDTK.Caption = "Bảng điểm tổng kết";
            this.BtnInBDTK.Id = 9;
            this.BtnInBDTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInBDTK.ImageOptions.Image")));
            this.BtnInBDTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInBDTK.ImageOptions.LargeImage")));
            this.BtnInBDTK.LargeWidth = 80;
            this.BtnInBDTK.Name = "BtnInBDTK";
            this.BtnInBDTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnInBDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInBDTK_ItemClick);
            // 
            // registerBtn
            // 
            this.registerBtn.Caption = "Tạo tài khoản";
            this.registerBtn.Id = 10;
            this.registerBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("registerBtn.ImageOptions.SvgImage")));
            this.registerBtn.LargeWidth = 65;
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.registerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.registerBtn_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Danh sách";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.LargeWidth = 80;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barBtnMH
            // 
            this.barBtnMH.Caption = "Môn Học";
            this.barBtnMH.Id = 12;
            this.barBtnMH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnMH.ImageOptions.SvgImage")));
            this.barBtnMH.LargeWidth = 80;
            this.barBtnMH.Name = "barBtnMH";
            this.barBtnMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMH_ItemClick);
            // 
            // barBtnLTC
            // 
            this.barBtnLTC.Caption = "Lớp Tín Chỉ";
            this.barBtnLTC.Id = 14;
            this.barBtnLTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLTC.ImageOptions.SvgImage")));
            this.barBtnLTC.LargeWidth = 80;
            this.barBtnLTC.Name = "barBtnLTC";
            this.barBtnLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLTC_ItemClick);
            // 
            // barBtnSV
            // 
            this.barBtnSV.Caption = "Sinh Viên";
            this.barBtnSV.Id = 15;
            this.barBtnSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSV.ImageOptions.SvgImage")));
            this.barBtnSV.LargeWidth = 80;
            this.barBtnSV.Name = "barBtnSV";
            this.barBtnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSV_ItemClick);
            // 
            // barBtnDiem
            // 
            this.barBtnDiem.Caption = "Điểm";
            this.barBtnDiem.Id = 16;
            this.barBtnDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDiem.ImageOptions.SvgImage")));
            this.barBtnDiem.LargeWidth = 80;
            this.barBtnDiem.Name = "barBtnDiem";
            this.barBtnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDiem_ItemClick);
            // 
            // barBtnLop
            // 
            this.barBtnLop.Caption = "Lớp";
            this.barBtnLop.Id = 17;
            this.barBtnLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLop.ImageOptions.SvgImage")));
            this.barBtnLop.LargeWidth = 80;
            this.barBtnLop.Name = "barBtnLop";
            this.barBtnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLop_ItemClick);
            // 
            // barBtnDKLTC
            // 
            this.barBtnDKLTC.Caption = "Đăng ký lớp tín chỉ";
            this.barBtnDKLTC.Id = 18;
            this.barBtnDKLTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDKLTC.ImageOptions.SvgImage")));
            this.barBtnDKLTC.Name = "barBtnDKLTC";
            this.barBtnDKLTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDKLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDKLTC_ItemClick);
            // 
            // barBtnGV
            // 
            this.barBtnGV.Caption = "Giảng viên";
            this.barBtnGV.Id = 21;
            this.barBtnGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGV.ImageOptions.Image")));
            this.barBtnGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGV.ImageOptions.LargeImage")));
            this.barBtnGV.LargeWidth = 80;
            this.barBtnGV.Name = "barBtnGV";
            this.barBtnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGV_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.usersGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.loginBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.logoutBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // usersGroup
            // 
            this.usersGroup.ItemLinks.Add(this.registerBtn);
            this.usersGroup.Name = "usersGroup";
            this.usersGroup.Text = "Users";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.quanLyPageGroup,
            this.dangKyPageGroup});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Trị";
            // 
            // quanLyPageGroup
            // 
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnMH);
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnLop);
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnLTC);
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnSV);
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnGV);
            this.quanLyPageGroup.ItemLinks.Add(this.barBtnDiem);
            this.quanLyPageGroup.Name = "quanLyPageGroup";
            this.quanLyPageGroup.Text = "Quản lý";
            // 
            // dangKyPageGroup
            // 
            this.dangKyPageGroup.ItemLinks.Add(this.barBtnDKLTC);
            this.dangKyPageGroup.Name = "dangKyPageGroup";
            this.dangKyPageGroup.Text = "Đăng ký";
            // 
            // baoCaoPage
            // 
            this.baoCaoPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.baoCaoPage.Name = "baoCaoPage";
            this.baoCaoPage.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnInDSSV);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnInDSLTC);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnInPhieuDiem);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnInBDMH);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnInBDTK);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "In ấn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách sinh viên";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh sách sinh viên";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel3.Text = "MA";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel2.Text = "HOTEN";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "NHOM";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Đăng nhập";
            this.barButtonItem8.Enabled = false;
            this.barButtonItem8.Id = 1;
            this.barButtonItem8.ImageOptions.Image = global::QLSV_HTC.Properties.Resources.login;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 651);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm sinh viên theo hệ tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup quanLyPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage baoCaoPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem loginBtn;
        private DevExpress.XtraBars.BarButtonItem logoutBtn;
        private DevExpress.XtraBars.BarButtonItem BtnInDSSV;
        private DevExpress.XtraBars.BarButtonItem BtnInDSLTC;
        private DevExpress.XtraBars.BarButtonItem BtnInPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem BtnInBDTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BtnInBDMH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem registerBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup usersGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnMH;
        private DevExpress.XtraBars.BarButtonItem barBtnLTC;
        private DevExpress.XtraBars.BarButtonItem barBtnSV;
        private DevExpress.XtraBars.BarButtonItem barBtnDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup dangKyPageGroup;
        private DevExpress.XtraBars.BarButtonItem barBtnLop;
        private DevExpress.XtraBars.BarButtonItem barBtnDKLTC;
        private DevExpress.XtraBars.BarButtonItem barBtnGV;
    }
}

