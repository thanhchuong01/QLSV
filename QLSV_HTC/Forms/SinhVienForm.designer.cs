
namespace QLSV_HTC.Forms
{
    partial class SinhVienForm
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel1;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVienForm));
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLSV_HTC.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Add = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRenew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOut = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sINHVIENTableAdapter = new QLSV_HTC.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLSV_HTC.DSTableAdapters.LOPTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bds_DangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GC_SV = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GC_Lop = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pASSWORDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NghiHoc_Label = new DevExpress.XtraEditors.LabelControl();
            this.dANGHIHOCCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckBox_Phai = new System.Windows.Forms.CheckBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.DateEdit_NgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.TextBox_Ten = new System.Windows.Forms.TextBox();
            this.TextBox_Ho = new System.Windows.Forms.TextBox();
            this.TextBox_MaSV = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cHUYENNGANHTableAdapter = new QLSV_HTC.DSTableAdapters.CHUYENNGANHTableAdapter();
            this.btnChuyenLop = new System.Windows.Forms.Button();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel1 = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSWORDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgaySinh.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(33, 24);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(44, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MÃ SV: ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(33, 56);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(29, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ: ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(33, 97);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(33, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN: ";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(33, 162);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(65, 13);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(33, 196);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(54, 13);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "ĐỊA CHỈ: ";
            // 
            // pHAILabel1
            // 
            pHAILabel1.AutoSize = true;
            pHAILabel1.Location = new System.Drawing.Point(37, 131);
            pHAILabel1.Name = "pHAILabel1";
            pHAILabel1.Size = new System.Drawing.Size(29, 13);
            pHAILabel1.TabIndex = 14;
            pHAILabel1.Text = "NỮ: ";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(33, 236);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(68, 13);
            pASSWORDLabel.TabIndex = 17;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSINHVIEN.DataSource = this.lOPBindingSource;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Add,
            this.barButtonEdit,
            this.barButtonDelete,
            this.barButtonUndo,
            this.barButtonSave,
            this.barButtonOut,
            this.barButtonRenew,
            this.barButtonHuy});
            this.barManager1.MainMenu = this.bar6;
            this.barManager1.MaxItemId = 8;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonRenew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonOut)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // barButtonItem_Add
            // 
            this.barButtonItem_Add.Caption = "Thêm";
            this.barButtonItem_Add.Id = 0;
            this.barButtonItem_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem_Add.ImageOptions.SvgImage")));
            this.barButtonItem_Add.Name = "barButtonItem_Add";
            this.barButtonItem_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Caption = "Sửa";
            this.barButtonEdit.Id = 1;
            this.barButtonEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonEdit.ImageOptions.SvgImage")));
            this.barButtonEdit.Name = "barButtonEdit";
            this.barButtonEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonEdit_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Xóa";
            this.barButtonDelete.Id = 2;
            this.barButtonDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDelete.ImageOptions.SvgImage")));
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDelete_ItemClick);
            // 
            // barButtonUndo
            // 
            this.barButtonUndo.Caption = "Phục hồi";
            this.barButtonUndo.Enabled = false;
            this.barButtonUndo.Id = 3;
            this.barButtonUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonUndo.ImageOptions.SvgImage")));
            this.barButtonUndo.Name = "barButtonUndo";
            this.barButtonUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUndo_ItemClick);
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "Ghi";
            this.barButtonSave.Enabled = false;
            this.barButtonSave.Id = 4;
            this.barButtonSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonSave.ImageOptions.SvgImage")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // barButtonHuy
            // 
            this.barButtonHuy.Caption = "Hủy";
            this.barButtonHuy.Enabled = false;
            this.barButtonHuy.Id = 7;
            this.barButtonHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonHuy.ImageOptions.SvgImage")));
            this.barButtonHuy.Name = "barButtonHuy";
            this.barButtonHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHuy_ItemClick);
            // 
            // barButtonRenew
            // 
            this.barButtonRenew.Caption = "Làm mới";
            this.barButtonRenew.Id = 6;
            this.barButtonRenew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonRenew.ImageOptions.SvgImage")));
            this.barButtonRenew.Name = "barButtonRenew";
            this.barButtonRenew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonRenew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRenew_ItemClick);
            // 
            // barButtonOut
            // 
            this.barButtonOut.Caption = "Thoát";
            this.barButtonOut.Id = 5;
            this.barButtonOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonOut.ImageOptions.SvgImage")));
            this.barButtonOut.Name = "barButtonOut";
            this.barButtonOut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonOut_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1898, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 868);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 844);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1898, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 844);
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Caption = "Thêm";
            this.barButtonAdd.Id = 0;
            this.barButtonAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAdd.ImageOptions.SvgImage")));
            this.barButtonAdd.Name = "barButtonAdd";
            this.barButtonAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm";
            this.barButtonItem3.Id = 0;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm";
            this.barButtonItem4.Id = 0;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thêm";
            this.barButtonItem5.Id = 0;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thêm";
            this.barButtonItem6.Id = 0;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thêm";
            this.barButtonItem7.Id = 0;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thêm";
            this.barButtonItem8.Id = 0;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thêm";
            this.barButtonItem9.Id = 0;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Thêm";
            this.barButtonItem10.Id = 0;
            this.barButtonItem10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.SvgImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Thêm";
            this.barButtonItem11.Id = 0;
            this.barButtonItem11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem11.ImageOptions.SvgImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Thêm";
            this.barButtonItem12.Id = 0;
            this.barButtonItem12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem12.ImageOptions.SvgImage")));
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Thêm";
            this.barButtonItem13.Id = 0;
            this.barButtonItem13.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem13.ImageOptions.SvgImage")));
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Thêm";
            this.barButtonItem14.Id = 0;
            this.barButtonItem14.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem14.ImageOptions.SvgImage")));
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Thêm";
            this.barButtonItem15.Id = 0;
            this.barButtonItem15.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem15.ImageOptions.SvgImage")));
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbKhoa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 24);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1898, 36);
            this.panelControl2.TabIndex = 12;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(81, 6);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(167, 21);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Khoa";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KEHOACHGIANGDAYTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGDAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LICHHOCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.THOIGIANDKTableAdapter = null;
            this.tableAdapterManager.THOIGIANHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Location = new System.Drawing.Point(51, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(4, 4);
            this.panelControl1.TabIndex = 21;
            // 
            // GC_SV
            // 
            this.GC_SV.DataSource = this.bdsSINHVIEN;
            this.GC_SV.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_SV.Location = new System.Drawing.Point(384, 3);
            this.GC_SV.MainView = this.gridView2;
            this.GC_SV.MenuManager = this.barManager1;
            this.GC_SV.Name = "GC_SV";
            this.GC_SV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GC_SV.Size = new System.Drawing.Size(988, 712);
            this.GC_SV.TabIndex = 16;
            this.GC_SV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.GC_SV.Click += new System.EventHandler(this.GC_SV_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colDANGHIHOC,
            this.colMACN});
            this.gridView2.GridControl = this.GC_SV;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.AllowFocus = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.AllowFocus = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.AllowFocus = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.OptionsColumn.AllowFocus = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.AllowFocus = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.AllowFocus = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.Caption = "Đã Nghỉ Học";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.OptionsColumn.AllowEdit = false;
            this.colDANGHIHOC.OptionsColumn.AllowFocus = false;
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 6;
            // 
            // bds_DangKy
            // 
            this.bds_DangKy.DataMember = "FK_DANGKY_SINHVIEN";
            this.bds_DangKy.DataSource = this.bdsSINHVIEN;
            // colMACN
            // 
            this.colMACN.Caption = "Chuyên ngành";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP});
            this.gridView1.GridControl = this.GC_Lop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMALOP, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.AllowFocus = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 135;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.AllowFocus = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 548;
            // 
            // GC_Lop
            // 
            this.GC_Lop.DataSource = this.lOPBindingSource;
            this.GC_Lop.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_Lop.Location = new System.Drawing.Point(3, 3);
            this.GC_Lop.MainView = this.gridView1;
            this.GC_Lop.MenuManager = this.barManager1;
            this.GC_Lop.Name = "GC_Lop";
            this.GC_Lop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GC_Lop.Size = new System.Drawing.Size(375, 712);
            this.GC_Lop.TabIndex = 16;
            this.GC_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            this.GC_Lop.Click += new System.EventHandler(this.GC_Lop_Click);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.GC_Lop;
            this.gridView3.Name = "gridView3";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnChuyenLop);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.comboBox1);
            this.panelControl3.Controls.Add(pASSWORDLabel);
            this.panelControl3.Controls.Add(this.pASSWORDTextEdit);
            this.panelControl3.Controls.Add(this.NghiHoc_Label);
            this.panelControl3.Controls.Add(this.dANGHIHOCCheckBox);
            this.panelControl3.Controls.Add(pHAILabel1);
            this.panelControl3.Controls.Add(this.CheckBox_Phai);
            this.panelControl3.Controls.Add(dIACHILabel);
            this.panelControl3.Controls.Add(this.dIACHITextBox);
            this.panelControl3.Controls.Add(nGAYSINHLabel);
            this.panelControl3.Controls.Add(this.DateEdit_NgaySinh);
            this.panelControl3.Controls.Add(tENLabel);
            this.panelControl3.Controls.Add(this.TextBox_Ten);
            this.panelControl3.Controls.Add(hOLabel);
            this.panelControl3.Controls.Add(this.TextBox_Ho);
            this.panelControl3.Controls.Add(mASVLabel);
            this.panelControl3.Controls.Add(this.TextBox_MaSV);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Enabled = false;
            this.panelControl3.Location = new System.Drawing.Point(1378, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(508, 712);
            this.panelControl3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chuyên ngành";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSINHVIEN, "MACN", true));
            this.comboBox1.DataSource = this.cHUYENNGANHBindingSource;
            this.comboBox1.DisplayMember = "TENCN";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "MACN";
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataMember = "CHUYENNGANH";
            this.cHUYENNGANHBindingSource.DataSource = this.dS;
            // 
            // pASSWORDTextEdit
            // 
            this.pASSWORDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "PASSWORD", true));
            this.pASSWORDTextEdit.Location = new System.Drawing.Point(116, 233);
            this.pASSWORDTextEdit.MenuManager = this.barManager1;
            this.pASSWORDTextEdit.Name = "pASSWORDTextEdit";
            this.pASSWORDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pASSWORDTextEdit.TabIndex = 18;
            // 
            // NghiHoc_Label
            // 
            this.NghiHoc_Label.Location = new System.Drawing.Point(36, 312);
            this.NghiHoc_Label.Name = "NghiHoc_Label";
            this.NghiHoc_Label.Size = new System.Drawing.Size(68, 13);
            this.NghiHoc_Label.TabIndex = 17;
            this.NghiHoc_Label.Text = "ĐÃ NGHỈ HỌC";
            // 
            // dANGHIHOCCheckBox
            // 
            this.dANGHIHOCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSINHVIEN, "DANGHIHOC", true));
            this.dANGHIHOCCheckBox.Location = new System.Drawing.Point(121, 307);
            this.dANGHIHOCCheckBox.Name = "dANGHIHOCCheckBox";
            this.dANGHIHOCCheckBox.Size = new System.Drawing.Size(16, 24);
            this.dANGHIHOCCheckBox.TabIndex = 16;
            this.dANGHIHOCCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Phai
            // 
            this.CheckBox_Phai.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSINHVIEN, "PHAI", true));
            this.CheckBox_Phai.Location = new System.Drawing.Point(116, 126);
            this.CheckBox_Phai.Name = "CheckBox_Phai";
            this.CheckBox_Phai.Size = new System.Drawing.Size(15, 24);
            this.CheckBox_Phai.TabIndex = 15;
            this.CheckBox_Phai.UseVisualStyleBackColor = true;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSINHVIEN, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(116, 193);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(200, 21);
            this.dIACHITextBox.TabIndex = 11;
            // 
            // DateEdit_NgaySinh
            // 
            this.DateEdit_NgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "NGAYSINH", true));
            this.DateEdit_NgaySinh.EditValue = null;
            this.DateEdit_NgaySinh.Location = new System.Drawing.Point(116, 159);
            this.DateEdit_NgaySinh.MenuManager = this.barManager1;
            this.DateEdit_NgaySinh.Name = "DateEdit_NgaySinh";
            this.DateEdit_NgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_NgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.DateEdit_NgaySinh.TabIndex = 9;
            // 
            // TextBox_Ten
            // 
            this.TextBox_Ten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSINHVIEN, "TEN", true));
            this.TextBox_Ten.Location = new System.Drawing.Point(116, 94);
            this.TextBox_Ten.Name = "TextBox_Ten";
            this.TextBox_Ten.Size = new System.Drawing.Size(200, 21);
            this.TextBox_Ten.TabIndex = 5;
            // 
            // TextBox_Ho
            // 
            this.TextBox_Ho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSINHVIEN, "HO", true));
            this.TextBox_Ho.Location = new System.Drawing.Point(116, 53);
            this.TextBox_Ho.Name = "TextBox_Ho";
            this.TextBox_Ho.Size = new System.Drawing.Size(200, 21);
            this.TextBox_Ho.TabIndex = 3;
            // 
            // TextBox_MaSV
            // 
            this.TextBox_MaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSINHVIEN, "MASV", true));
            this.TextBox_MaSV.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TextBox_MaSV.Location = new System.Drawing.Point(116, 21);
            this.TextBox_MaSV.Name = "TextBox_MaSV";
            this.TextBox_MaSV.Size = new System.Drawing.Size(200, 21);
            this.TextBox_MaSV.TabIndex = 1;
            this.TextBox_MaSV.TextChanged += new System.EventHandler(this.TextBox_MaSV_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GC_Lop);
            this.flowLayoutPanel1.Controls.Add(this.GC_SV);
            this.flowLayoutPanel1.Controls.Add(this.panelControl3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1897, 715);
            this.flowLayoutPanel1.TabIndex = 22;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // cHUYENNGANHTableAdapter
            // 
            this.cHUYENNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Location = new System.Drawing.Point(121, 353);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(121, 38);
            this.btnChuyenLop.TabIndex = 21;
            this.btnChuyenLop.Text = "Chuyển lớp";
            this.btnChuyenLop.UseVisualStyleBackColor = true;
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 868);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SinhVienForm";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSWORDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgaySinh.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Add;
        private DevExpress.XtraBars.BarButtonItem barButtonEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonRenew;
        private DevExpress.XtraBars.BarButtonItem barButtonOut;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS dS;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource bds_DangKy;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GC_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.GridControl GC_SV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit pASSWORDTextEdit;
        private DevExpress.XtraEditors.LabelControl NghiHoc_Label;
        private System.Windows.Forms.CheckBox dANGHIHOCCheckBox;
        private System.Windows.Forms.CheckBox CheckBox_Phai;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private DevExpress.XtraEditors.DateEdit DateEdit_NgaySinh;
        private System.Windows.Forms.TextBox TextBox_Ten;
        private System.Windows.Forms.TextBox TextBox_Ho;
        private System.Windows.Forms.TextBox TextBox_MaSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private DSTableAdapters.CHUYENNGANHTableAdapter cHUYENNGANHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.Button btnChuyenLop;
    }
}