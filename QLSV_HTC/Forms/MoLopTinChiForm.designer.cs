using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace QLSV_HTC.Forms
{
    partial class MoLopTinChiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoLopTinChiForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlTGH = new DevExpress.XtraGrid.GridControl();
            this.spGetAllTGHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLSV_HTC.DS();
            this.gridViewTGH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
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
            this.lookUpEditTimeHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.tHOIGIANHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelTime = new System.Windows.Forms.Button();
            this.buttonAddtime = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDKTime = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.radioBtnNew = new System.Windows.Forms.RadioButton();
            this.radioBtnAva = new System.Windows.Forms.RadioButton();
            this.lookUpEditTimeDK = new DevExpress.XtraEditors.LookUpEdit();
            this.tHOIGIANDKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datiNewEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datiNewStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaTGDK = new DevExpress.XtraEditors.SpinEdit();
            this.bdsLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlGV = new DevExpress.XtraGrid.GridControl();
            this.spGetGVLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddGV = new System.Windows.Forms.Button();
            this.buttonDelGV = new System.Windows.Forms.Button();
            this.hUYLOPCheckBox = new System.Windows.Forms.CheckBox();
            this.txtMaLTC = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoSVTT = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtNhom = new DevExpress.XtraEditors.SpinEdit();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxGV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsGIANGVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spinTGDK = new DevExpress.XtraLayout.LayoutControlItem();
            this.spGetAllTGHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHOIGIANDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsfKLICHHOCLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.bdsfKLOPTINCHITHOIGIANDK = new System.Windows.Forms.BindingSource(this.components);
            this.fKDAYLOPTINCHIBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dAYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDAYLOPTINCHIBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.LOPTINCHITableAdapter = new QLSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            this.gcLOPTINCHI = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATGDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.MONHOCTableAdapter = new QLSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.GIANGVIENTableAdapter = new QLSV_HTC.DSTableAdapters.GIANGVIENTableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dAYTableAdapter = new QLSV_HTC.DSTableAdapters.DAYTableAdapter();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHOIGIANDKTableAdapter = new QLSV_HTC.DSTableAdapters.THOIGIANDKTableAdapter();
            this.lICHHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lICHHOCTableAdapter = new QLSV_HTC.DSTableAdapters.LICHHOCTableAdapter();
            this.tHOIGIANHOCTableAdapter = new QLSV_HTC.DSTableAdapters.THOIGIANHOCTableAdapter();
            this.bdsfKDANGKYLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.fKDANGKYLOPTINCHIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDAYLOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDAYLOPTINCHIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetGVLTCTableAdapter = new QLSV_HTC.DSTableAdapters.sp_GetGVLTCTableAdapter();
            this.sp_GetAllTGHTableAdapter = new QLSV_HTC.DSTableAdapters.sp_GetAllTGHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllTGHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTimeHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTimeDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANDKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTGDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGVLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSVTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTGDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllTGHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKLICHHOCLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKLOPTINCHITHOIGIANDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKDANGKYLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDANGKYLOPTINCHIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AllowTouchScroll = true;
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Enabled = false;
            this.panelControl1.FireScrollEventOnMouseWheel = true;
            this.panelControl1.Location = new System.Drawing.Point(0, 740);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.ScrollBarSmallChange = 3;
            this.panelControl1.Size = new System.Drawing.Size(1898, 269);
            this.panelControl1.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlTGH);
            this.groupControl3.Controls.Add(this.lookUpEditTimeHoc);
            this.groupControl3.Controls.Add(this.buttonDelTime);
            this.groupControl3.Controls.Add(this.buttonAddtime);
            this.groupControl3.Location = new System.Drawing.Point(1236, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(657, 265);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Thời gian học";
            // 
            // gridControlTGH
            // 
            this.gridControlTGH.DataSource = this.spGetAllTGHBindingSource1;
            this.gridControlTGH.Location = new System.Drawing.Point(26, 123);
            this.gridControlTGH.MainView = this.gridViewTGH;
            this.gridControlTGH.MenuManager = this.barManager1;
            this.gridControlTGH.Name = "gridControlTGH";
            this.gridControlTGH.Size = new System.Drawing.Size(444, 118);
            this.gridControlTGH.TabIndex = 4;
            this.gridControlTGH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTGH});
            // 
            // spGetAllTGHBindingSource1
            // 
            this.spGetAllTGHBindingSource1.DataMember = "sp_GetAllTGH";
            this.spGetAllTGHBindingSource1.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewTGH
            // 
            this.gridViewTGH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC1,
            this.colMATGH,
            this.colTHOIGIAN});
            this.gridViewTGH.GridControl = this.gridControlTGH;
            this.gridViewTGH.Name = "gridViewTGH";
            this.gridViewTGH.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewTGH.OptionsView.ShowGroupPanel = false;
            // 
            // colMALTC1
            // 
            this.colMALTC1.FieldName = "MALTC";
            this.colMALTC1.Name = "colMALTC1";
            // 
            // colMATGH
            // 
            this.colMATGH.Caption = "Mã thời gian học";
            this.colMATGH.FieldName = "MATGH";
            this.colMATGH.Name = "colMATGH";
            this.colMATGH.Visible = true;
            this.colMATGH.VisibleIndex = 0;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Thời gian";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonAdd,
            this.barButtonEdit,
            this.barButtonDelete,
            this.barButtonUndo,
            this.barButtonSave,
            this.barButtonOut,
            this.barButtonRenew,
            this.barButtonHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonRenew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonOut)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Caption = "Thêm";
            this.barButtonAdd.Id = 0;
            this.barButtonAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAdd.ImageOptions.SvgImage")));
            this.barButtonAdd.Name = "barButtonAdd";
            this.barButtonAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAdd_ItemClick);
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
            this.barButtonOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCancel_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1009);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 985);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1898, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 985);
            // 
            // lookUpEditTimeHoc
            // 
            this.lookUpEditTimeHoc.Location = new System.Drawing.Point(26, 87);
            this.lookUpEditTimeHoc.MenuManager = this.barManager1;
            this.lookUpEditTimeHoc.Name = "lookUpEditTimeHoc";
            this.lookUpEditTimeHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTimeHoc.Properties.DataSource = this.tHOIGIANHOCBindingSource;
            this.lookUpEditTimeHoc.Properties.DisplayMember = "MATGH";
            this.lookUpEditTimeHoc.Properties.NullText = "Chọn thời gian";
            this.lookUpEditTimeHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditTimeHoc.Properties.ValueMember = "MATGH";
            this.lookUpEditTimeHoc.Size = new System.Drawing.Size(444, 20);
            this.lookUpEditTimeHoc.TabIndex = 3;
            this.lookUpEditTimeHoc.EditValueChanged += new System.EventHandler(this.lookUpEditTimeHoc_EditValueChanged);
            // 
            // tHOIGIANHOCBindingSource
            // 
            this.tHOIGIANHOCBindingSource.DataMember = "THOIGIANHOC";
            this.tHOIGIANHOCBindingSource.DataSource = this.DS;
            // 
            // buttonDelTime
            // 
            this.buttonDelTime.Location = new System.Drawing.Point(495, 150);
            this.buttonDelTime.Name = "buttonDelTime";
            this.buttonDelTime.Size = new System.Drawing.Size(75, 52);
            this.buttonDelTime.TabIndex = 2;
            this.buttonDelTime.Text = "Xóa buổi";
            this.buttonDelTime.UseVisualStyleBackColor = true;
            this.buttonDelTime.Click += new System.EventHandler(this.buttonDelTime_Click);
            // 
            // buttonAddtime
            // 
            this.buttonAddtime.Enabled = false;
            this.buttonAddtime.Location = new System.Drawing.Point(495, 65);
            this.buttonAddtime.Name = "buttonAddtime";
            this.buttonAddtime.Size = new System.Drawing.Size(75, 43);
            this.buttonAddtime.TabIndex = 1;
            this.buttonAddtime.Text = "Thêm buổi";
            this.buttonAddtime.UseVisualStyleBackColor = true;
            this.buttonAddtime.Click += new System.EventHandler(this.buttonAddtime_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.btnDKTime);
            this.groupControl2.Controls.Add(this.textBoxTime);
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(667, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(563, 241);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thời gian đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian đăng ký của lớp tín chỉ";
            // 
            // btnDKTime
            // 
            this.btnDKTime.Location = new System.Drawing.Point(468, 47);
            this.btnDKTime.Name = "btnDKTime";
            this.btnDKTime.Size = new System.Drawing.Size(75, 48);
            this.btnDKTime.TabIndex = 3;
            this.btnDKTime.Text = "Đăng ký thời gian";
            this.btnDKTime.UseVisualStyleBackColor = true;
            this.btnDKTime.Click += new System.EventHandler(this.btnDKTime_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(179, 178);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(329, 21);
            this.textBoxTime.TabIndex = 2;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.radioBtnNew);
            this.layoutControl2.Controls.Add(this.radioBtnAva);
            this.layoutControl2.Controls.Add(this.lookUpEditTimeDK);
            this.layoutControl2.Controls.Add(this.datiNewEnd);
            this.layoutControl2.Controls.Add(this.label1);
            this.layoutControl2.Controls.Add(this.datiNewStart);
            this.layoutControl2.Controls.Add(this.label2);
            this.layoutControl2.Location = new System.Drawing.Point(5, 38);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(457, 102);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // radioBtnNew
            // 
            this.radioBtnNew.Location = new System.Drawing.Point(12, 53);
            this.radioBtnNew.Name = "radioBtnNew";
            this.radioBtnNew.Size = new System.Drawing.Size(83, 25);
            this.radioBtnNew.TabIndex = 5;
            this.radioBtnNew.Text = "Tạo mới";
            this.radioBtnNew.UseVisualStyleBackColor = true;
            this.radioBtnNew.CheckedChanged += new System.EventHandler(this.radioBtnNew_CheckedChanged);
            // 
            // radioBtnAva
            // 
            this.radioBtnAva.Checked = true;
            this.radioBtnAva.Location = new System.Drawing.Point(12, 12);
            this.radioBtnAva.Name = "radioBtnAva";
            this.radioBtnAva.Size = new System.Drawing.Size(83, 25);
            this.radioBtnAva.TabIndex = 4;
            this.radioBtnAva.TabStop = true;
            this.radioBtnAva.Text = "Có sẵn";
            this.radioBtnAva.UseVisualStyleBackColor = true;
            this.radioBtnAva.CheckedChanged += new System.EventHandler(this.radioBtnAva_CheckedChanged);
            // 
            // lookUpEditTimeDK
            // 
            this.lookUpEditTimeDK.Location = new System.Drawing.Point(99, 14);
            this.lookUpEditTimeDK.MenuManager = this.barManager1;
            this.lookUpEditTimeDK.Name = "lookUpEditTimeDK";
            this.lookUpEditTimeDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTimeDK.Properties.DataSource = this.tHOIGIANDKBindingSource1;
            this.lookUpEditTimeDK.Properties.DisplayFormat.FormatString = "{1} - {2}";
            this.lookUpEditTimeDK.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.lookUpEditTimeDK.Properties.DisplayMember = "MATGDK";
            this.lookUpEditTimeDK.Properties.NullText = "Chọn thời gian đăng ký";
            this.lookUpEditTimeDK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditTimeDK.Properties.ValueMember = "MATGDK";
            this.lookUpEditTimeDK.Size = new System.Drawing.Size(346, 20);
            this.lookUpEditTimeDK.StyleController = this.layoutControl2;
            this.lookUpEditTimeDK.TabIndex = 18;
            this.lookUpEditTimeDK.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // tHOIGIANDKBindingSource1
            // 
            this.tHOIGIANDKBindingSource1.DataMember = "THOIGIANDK";
            this.tHOIGIANDKBindingSource1.DataSource = this.DS;
            // 
            // datiNewEnd
            // 
            this.datiNewEnd.Checked = false;
            this.datiNewEnd.Enabled = false;
            this.datiNewEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datiNewEnd.Location = new System.Drawing.Point(198, 67);
            this.datiNewEnd.Name = "datiNewEnd";
            this.datiNewEnd.Size = new System.Drawing.Size(247, 21);
            this.datiNewEnd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày kết thúc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datiNewStart
            // 
            this.datiNewStart.Checked = false;
            this.datiNewStart.Enabled = false;
            this.datiNewStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datiNewStart.Location = new System.Drawing.Point(198, 41);
            this.datiNewStart.Name = "datiNewStart";
            this.datiNewStart.Size = new System.Drawing.Size(247, 21);
            this.datiNewStart.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày bắt đầu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem20,
            this.layoutControlItem11,
            this.layoutControlItem1,
            this.layoutControlItem14});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(457, 102);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.label2;
            this.layoutControlItem15.Location = new System.Drawing.Point(87, 29);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.datiNewStart;
            this.layoutControlItem16.Location = new System.Drawing.Point(186, 29);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(251, 24);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.label1;
            this.layoutControlItem17.Location = new System.Drawing.Point(87, 53);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(99, 29);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem20.Control = this.datiNewEnd;
            this.layoutControlItem20.Location = new System.Drawing.Point(186, 53);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(251, 29);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem11.Control = this.lookUpEditTimeDK;
            this.layoutControlItem11.Location = new System.Drawing.Point(87, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(350, 29);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioBtnAva;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(87, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem14.Control = this.radioBtnNew;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(87, 53);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 265);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin lớp tín chỉ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaTGDK);
            this.layoutControl1.Controls.Add(this.gridControlGV);
            this.layoutControl1.Controls.Add(this.btnAddGV);
            this.layoutControl1.Controls.Add(this.buttonDelGV);
            this.layoutControl1.Controls.Add(this.hUYLOPCheckBox);
            this.layoutControl1.Controls.Add(this.txtMaLTC);
            this.layoutControl1.Controls.Add(this.txtSoSVTT);
            this.layoutControl1.Controls.Add(this.txtMaKhoa);
            this.layoutControl1.Controls.Add(this.txtNhom);
            this.layoutControl1.Controls.Add(this.txtHocKy);
            this.layoutControl1.Controls.Add(this.txtNienKhoa);
            this.layoutControl1.Controls.Add(this.txtMaMonHoc);
            this.layoutControl1.Controls.Add(this.comboBoxGV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(655, 240);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaTGDK
            // 
            this.txtMaTGDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "MATGDK", true));
            this.txtMaTGDK.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaTGDK.Location = new System.Drawing.Point(437, 84);
            this.txtMaTGDK.MenuManager = this.barManager1;
            this.txtMaTGDK.Name = "txtMaTGDK";
            this.txtMaTGDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaTGDK.Properties.IsFloatValue = false;
            this.txtMaTGDK.Properties.Mask.EditMask = "N00";
            this.txtMaTGDK.Size = new System.Drawing.Size(58, 20);
            this.txtMaTGDK.StyleController = this.layoutControl1;
            this.txtMaTGDK.TabIndex = 20;
            // 
            // bdsLOPTINCHI
            // 
            this.bdsLOPTINCHI.DataMember = "LOPTINCHI";
            this.bdsLOPTINCHI.DataSource = this.DS;
            // 
            // gridControlGV
            // 
            this.gridControlGV.DataSource = this.spGetGVLTCBindingSource;
            this.gridControlGV.Location = new System.Drawing.Point(12, 132);
            this.gridControlGV.MainView = this.gridViewGV;
            this.gridControlGV.MenuManager = this.barManager1;
            this.gridControlGV.Name = "gridControlGV";
            this.gridControlGV.Size = new System.Drawing.Size(517, 96);
            this.gridControlGV.TabIndex = 19;
            this.gridControlGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGV});
            // 
            // spGetGVLTCBindingSource
            // 
            this.spGetGVLTCBindingSource.DataMember = "sp_GetGVLTC";
            this.spGetGVLTCBindingSource.DataSource = this.DS;
            // 
            // gridViewGV
            // 
            this.gridViewGV.ActiveFilterEnabled = false;
            this.gridViewGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAGV,
            this.TEN});
            this.gridViewGV.GridControl = this.gridControlGV;
            this.gridViewGV.Name = "gridViewGV";
            this.gridViewGV.OptionsBehavior.ReadOnly = true;
            this.gridViewGV.OptionsCustomization.AllowFilter = false;
            this.gridViewGV.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewGV.OptionsFilter.AllowFilterEditor = false;
            this.gridViewGV.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridViewGV.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gridViewGV.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewGV.OptionsView.ShowGroupPanel = false;
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã Giảng viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsEditForm.Caption = "Mã giảng viên";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.OptionsColumn.AllowEdit = false;
            this.TEN.OptionsEditForm.Caption = "Tên";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            // 
            // btnAddGV
            // 
            this.btnAddGV.Enabled = false;
            this.btnAddGV.Location = new System.Drawing.Point(533, 108);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(110, 45);
            this.btnAddGV.TabIndex = 16;
            this.btnAddGV.Text = "Thêm";
            this.btnAddGV.UseVisualStyleBackColor = true;
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // buttonDelGV
            // 
            this.buttonDelGV.Location = new System.Drawing.Point(533, 157);
            this.buttonDelGV.Name = "buttonDelGV";
            this.buttonDelGV.Size = new System.Drawing.Size(110, 71);
            this.buttonDelGV.TabIndex = 17;
            this.buttonDelGV.Text = "Xóa";
            this.buttonDelGV.UseVisualStyleBackColor = true;
            this.buttonDelGV.Click += new System.EventHandler(this.btnDelGV_Click);
            // 
            // hUYLOPCheckBox
            // 
            this.hUYLOPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsLOPTINCHI, "HUYLOP", true));
            this.hUYLOPCheckBox.Location = new System.Drawing.Point(12, 84);
            this.hUYLOPCheckBox.Name = "hUYLOPCheckBox";
            this.hUYLOPCheckBox.Size = new System.Drawing.Size(341, 20);
            this.hUYLOPCheckBox.TabIndex = 14;
            this.hUYLOPCheckBox.Text = "Hủy lớp";
            this.hUYLOPCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtMaLTC
            // 
            this.txtMaLTC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "MALTC", true));
            this.txtMaLTC.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaLTC.Location = new System.Drawing.Point(579, 84);
            this.txtMaLTC.MenuManager = this.barManager1;
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaLTC.Properties.IsFloatValue = false;
            this.txtMaLTC.Properties.Mask.EditMask = "N00";
            this.txtMaLTC.Size = new System.Drawing.Size(64, 20);
            this.txtMaLTC.StyleController = this.layoutControl1;
            this.txtMaLTC.TabIndex = 13;
            // 
            // txtSoSVTT
            // 
            this.txtSoSVTT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "SOSVTT", true));
            this.txtSoSVTT.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoSVTT.Location = new System.Drawing.Point(437, 12);
            this.txtSoSVTT.MenuManager = this.barManager1;
            this.txtSoSVTT.Name = "txtSoSVTT";
            this.txtSoSVTT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoSVTT.Properties.IsFloatValue = false;
            this.txtSoSVTT.Properties.Mask.EditMask = "N00";
            this.txtSoSVTT.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtSoSVTT.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoSVTT.Size = new System.Drawing.Size(206, 20);
            this.txtSoSVTT.StyleController = this.layoutControl1;
            this.txtSoSVTT.TabIndex = 2;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(437, 36);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(206, 20);
            this.txtMaKhoa.StyleController = this.layoutControl1;
            this.txtMaKhoa.TabIndex = 6;
            // 
            // txtNhom
            // 
            this.txtNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "NHOM", true));
            this.txtNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Location = new System.Drawing.Point(437, 60);
            this.txtNhom.MenuManager = this.barManager1;
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhom.Properties.IsFloatValue = false;
            this.txtNhom.Properties.Mask.EditMask = "N00";
            this.txtNhom.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Size = new System.Drawing.Size(206, 20);
            this.txtNhom.StyleController = this.layoutControl1;
            this.txtNhom.TabIndex = 7;
            // 
            // txtHocKy
            // 
            this.txtHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "HOCKY", true));
            this.txtHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(92, 36);
            this.txtHocKy.MenuManager = this.barManager1;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Properties.IsFloatValue = false;
            this.txtHocKy.Properties.Mask.EditMask = "N00";
            this.txtHocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Size = new System.Drawing.Size(261, 20);
            this.txtHocKy.StyleController = this.layoutControl1;
            this.txtHocKy.TabIndex = 3;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(92, 12);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.txtNienKhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNienKhoa.Size = new System.Drawing.Size(261, 20);
            this.txtNienKhoa.StyleController = this.layoutControl1;
            this.txtNienKhoa.TabIndex = 0;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOPTINCHI, "MAMH", true));
            this.txtMaMonHoc.Location = new System.Drawing.Point(92, 60);
            this.txtMaMonHoc.MenuManager = this.barManager1;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaMonHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtMaMonHoc.Properties.DataSource = this.bdsMONHOC;
            this.txtMaMonHoc.Properties.DisplayMember = "MAMH";
            this.txtMaMonHoc.Properties.NullText = "Chọn môn học";
            this.txtMaMonHoc.Properties.PopupSizeable = false;
            this.txtMaMonHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtMaMonHoc.Properties.ValueMember = "MAMH";
            this.txtMaMonHoc.Size = new System.Drawing.Size(261, 20);
            this.txtMaMonHoc.StyleController = this.layoutControl1;
            this.txtMaMonHoc.TabIndex = 5;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // comboBoxGV
            // 
            this.comboBoxGV.Location = new System.Drawing.Point(92, 108);
            this.comboBoxGV.MenuManager = this.barManager1;
            this.comboBoxGV.Name = "comboBoxGV";
            this.comboBoxGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxGV.Properties.CascadingMember = "MAKHOA;TEN";
            this.comboBoxGV.Properties.DataSource = this.bdsGIANGVIEN;
            this.comboBoxGV.Properties.DisplayMember = "TEN";
            this.comboBoxGV.Properties.KeyMember = "TEN";
            this.comboBoxGV.Properties.NullText = "Chọn giảng viên ";
            this.comboBoxGV.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.comboBoxGV.Properties.PopupSizeable = false;
            this.comboBoxGV.Properties.ShowHeader = false;
            this.comboBoxGV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.comboBoxGV.Properties.ValueMember = "MAGV";
            this.comboBoxGV.Size = new System.Drawing.Size(437, 20);
            this.comboBoxGV.StyleController = this.layoutControl1;
            this.comboBoxGV.TabIndex = 18;
            this.comboBoxGV.EditValueChanged += new System.EventHandler(this.comboBoxGV_EditValueChanged);
            // 
            // bdsGIANGVIEN
            // 
            this.bdsGIANGVIEN.DataMember = "GIANGVIEN";
            this.bdsGIANGVIEN.DataSource = this.DS;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem13,
            this.layoutControlItem12,
            this.layoutControlItem19,
            this.layoutControlItem6,
            this.spinTGDK});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(655, 240);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNienKhoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem2.Text = "Niên khóa:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtHocKy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem3.Text = "Học kỳ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaMonHoc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem4.Text = "Mã môn học:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtMaKhoa;
            this.layoutControlItem7.Location = new System.Drawing.Point(345, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem7.Text = "Mã khoa:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtSoSVTT;
            this.layoutControlItem8.Location = new System.Drawing.Point(345, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem8.Text = "Số SV tối thiểu:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtMaLTC;
            this.layoutControlItem10.Enabled = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(487, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(148, 24);
            this.layoutControlItem10.Text = "Mã lớp tín chỉ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.hUYLOPCheckBox;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem9.Text = "HUYLOP:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNhom;
            this.layoutControlItem5.Location = new System.Drawing.Point(345, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem5.Text = "Nhóm:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.buttonDelGV;
            this.layoutControlItem13.Location = new System.Drawing.Point(521, 145);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(114, 75);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnAddGV;
            this.layoutControlItem12.Location = new System.Drawing.Point(521, 96);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(114, 49);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.comboBoxGV;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(521, 24);
            this.layoutControlItem19.Text = "Giảng viên thêm";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControlGV;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(521, 100);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // spinTGDK
            // 
            this.spinTGDK.Control = this.txtMaTGDK;
            this.spinTGDK.Location = new System.Drawing.Point(345, 72);
            this.spinTGDK.Name = "spinTGDK";
            this.spinTGDK.Size = new System.Drawing.Size(142, 24);
            this.spinTGDK.Text = "Mã TGDK";
            this.spinTGDK.TextSize = new System.Drawing.Size(77, 13);
            // 
            // spGetAllTGHBindingSource
            // 
            this.spGetAllTGHBindingSource.DataMember = "sp_GetAllTGH";
            this.spGetAllTGHBindingSource.DataSource = this.DS;
            // 
            // tHOIGIANDKBindingSource
            // 
            this.tHOIGIANDKBindingSource.DataMember = "THOIGIANDK";
            this.tHOIGIANDKBindingSource.DataSource = this.DS;
            // 
            // bdsfKLICHHOCLOPTINCHI
            // 
            this.bdsfKLICHHOCLOPTINCHI.DataMember = "FK_LICHHOC_LOPTINCHI";
            this.bdsfKLICHHOCLOPTINCHI.DataSource = this.bdsLOPTINCHI;
            // 
            // bdsfKLOPTINCHITHOIGIANDK
            // 
            this.bdsfKLOPTINCHITHOIGIANDK.DataMember = "FK_LOPTINCHI_THOIGIANDK";
            this.bdsfKLOPTINCHITHOIGIANDK.DataSource = this.tHOIGIANDKBindingSource;
            // 
            // fKDAYLOPTINCHIBindingSource3
            // 
            this.fKDAYLOPTINCHIBindingSource3.DataMember = "FK_DAY_LOPTINCHI";
            this.fKDAYLOPTINCHIBindingSource3.DataSource = this.bdsLOPTINCHI;
            // 
            // fKDAYLOPTINCHIBindingSource2
            // 
            this.fKDAYLOPTINCHIBindingSource2.DataMember = "FK_DAY_LOPTINCHI";
            this.fKDAYLOPTINCHIBindingSource2.DataSource = this.bdsLOPTINCHI;
            // 
            // dAYBindingSource
            // 
            this.dAYBindingSource.DataMember = "DAY";
            this.dAYBindingSource.DataSource = this.DS;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.THOIGIANDKTableAdapter = null;
            this.tableAdapterManager.THOIGIANHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // gcLOPTINCHI
            // 
            this.gcLOPTINCHI.DataSource = this.bdsLOPTINCHI;
            this.gcLOPTINCHI.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode4.RelationName = "FK_DANGKY_LOPTINCHI";
            gridLevelNode5.RelationName = "FK_DAY_LOPTINCHI";
            gridLevelNode6.RelationName = "FK_LICHHOC_LOPTINCHI";
            this.gcLOPTINCHI.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4,
            gridLevelNode5,
            gridLevelNode6});
            this.gcLOPTINCHI.Location = new System.Drawing.Point(2, 2);
            this.gcLOPTINCHI.MainView = this.gridView1;
            this.gcLOPTINCHI.MenuManager = this.barManager1;
            this.gcLOPTINCHI.Name = "gcLOPTINCHI";
            this.gcLOPTINCHI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gcLOPTINCHI.Size = new System.Drawing.Size(1894, 677);
            this.gcLOPTINCHI.TabIndex = 11;
            this.gcLOPTINCHI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHOCKY,
            this.colNIENKHOA,
            this.colMAMH,
            this.colNHOM,
            this.colMAKHOA,
            this.colSOSVTT,
            this.colHUYLOP,
            this.colMATGDK});
            this.gridView1.GridControl = this.gcLOPTINCHI;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.AllowEdit = false;
            this.colHOCKY.OptionsColumn.AllowFocus = false;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA.OptionsColumn.AllowFocus = false;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowFocus = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.AllowFocus = false;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.OptionsColumn.AllowFocus = false;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 4;
            // 
            // colSOSVTT
            // 
            this.colSOSVTT.Caption = "Số SV tối thiểu";
            this.colSOSVTT.FieldName = "SOSVTT";
            this.colSOSVTT.Name = "colSOSVTT";
            this.colSOSVTT.OptionsColumn.AllowEdit = false;
            this.colSOSVTT.OptionsColumn.AllowFocus = false;
            this.colSOSVTT.Visible = true;
            this.colSOSVTT.VisibleIndex = 5;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.Caption = "Hủy lớp";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.OptionsColumn.AllowEdit = false;
            this.colHUYLOP.OptionsColumn.AllowFocus = false;
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 6;
            // 
            // colMATGDK
            // 
            this.colMATGDK.Caption = "Mã thời gian đăng ký";
            this.colMATGDK.FieldName = "MATGDK";
            this.colMATGDK.Name = "colMATGDK";
            this.colMATGDK.OptionsColumn.AllowEdit = false;
            this.colMATGDK.OptionsColumn.AllowFocus = false;
            this.colMATGDK.Visible = true;
            this.colMATGDK.VisibleIndex = 7;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.dAYBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "MAGV";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "MAGV";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDANGKY.DataSource = this.bdsLOPTINCHI;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // GIANGVIENTableAdapter
            // 
            this.GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbKhoa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 24);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1898, 35);
            this.panelControl2.TabIndex = 16;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(81, 6);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(186, 21);
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcLOPTINCHI);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 59);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1898, 681);
            this.panelControl3.TabIndex = 17;
            // 
            // dAYTableAdapter
            // 
            this.dAYTableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.DS;
            // 
            // tHOIGIANDKTableAdapter
            // 
            this.tHOIGIANDKTableAdapter.ClearBeforeFill = true;
            // 
            // lICHHOCBindingSource
            // 
            this.lICHHOCBindingSource.DataMember = "LICHHOC";
            this.lICHHOCBindingSource.DataSource = this.DS;
            // 
            // lICHHOCTableAdapter
            // 
            this.lICHHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tHOIGIANHOCTableAdapter
            // 
            this.tHOIGIANHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsfKDANGKYLOPTINCHI
            // 
            this.bdsfKDANGKYLOPTINCHI.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsfKDANGKYLOPTINCHI.DataSource = this.bdsLOPTINCHI;
            // 
            // fKDANGKYLOPTINCHIBindingSource1
            // 
            this.fKDANGKYLOPTINCHIBindingSource1.DataMember = "FK_DANGKY_LOPTINCHI";
            this.fKDANGKYLOPTINCHIBindingSource1.DataSource = this.bdsLOPTINCHI;
            // 
            // fKDAYLOPTINCHIBindingSource
            // 
            this.fKDAYLOPTINCHIBindingSource.DataMember = "FK_DAY_LOPTINCHI";
            this.fKDAYLOPTINCHIBindingSource.DataSource = this.bdsLOPTINCHI;
            // 
            // fKDAYLOPTINCHIBindingSource1
            // 
            this.fKDAYLOPTINCHIBindingSource1.DataMember = "FK_DAY_LOPTINCHI";
            this.fKDAYLOPTINCHIBindingSource1.DataSource = this.bdsLOPTINCHI;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.DS;
            // 
            // sp_GetGVLTCTableAdapter
            // 
            this.sp_GetGVLTCTableAdapter.ClearBeforeFill = true;
            // 
            // sp_GetAllTGHTableAdapter
            // 
            this.sp_GetAllTGHTableAdapter.ClearBeforeFill = true;
            // 
            // MoLopTinChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1009);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MoLopTinChiForm";
            this.Text = "Mở lớp tín chỉ";
            this.Load += new System.EventHandler(this.MoLopTinChiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllTGHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTimeHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTimeDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANDKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTGDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGVLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoSVTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTGDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAllTGHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKLICHHOCLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKLOPTINCHITHOIGIANDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsfKDANGKYLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDANGKYLOPTINCHIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDAYLOPTINCHIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonOut;
        private DevExpress.XtraBars.BarButtonItem barButtonRenew;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bdsLOPTINCHI;
        private DSTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcLOPTINCHI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit txtSoSVTT;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.SpinEdit txtNhom;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.LookUpEdit txtMaMonHoc;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private DSTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsGIANGVIEN;
        private DSTableAdapters.GIANGVIENTableAdapter GIANGVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraEditors.SpinEdit txtMaLTC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.CheckBox hUYLOPCheckBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource dAYBindingSource;
        private DSTableAdapters.DAYTableAdapter dAYTableAdapter;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource tHOIGIANDKBindingSource;
        private DSTableAdapters.THOIGIANDKTableAdapter tHOIGIANDKTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.RadioButton radioBtnNew;
        private System.Windows.Forms.RadioButton radioBtnAva;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datiNewEnd;
        private System.Windows.Forms.DateTimePicker datiNewStart;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.BindingSource lICHHOCBindingSource;
        private DSTableAdapters.LICHHOCTableAdapter lICHHOCTableAdapter;
        private System.Windows.Forms.BindingSource tHOIGIANHOCBindingSource;
        private DSTableAdapters.THOIGIANHOCTableAdapter tHOIGIANHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsfKLICHHOCLOPTINCHI;        
        private System.Windows.Forms.BindingSource bdsfKLOPTINCHITHOIGIANDK;
        private System.Windows.Forms.BindingSource bdsfKDANGKYLOPTINCHI;
        private System.Windows.Forms.BindingSource fKDANGKYLOPTINCHIBindingSource1;
        private System.Windows.Forms.BindingSource fKDAYLOPTINCHIBindingSource1;
        private System.Windows.Forms.BindingSource fKDAYLOPTINCHIBindingSource;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private System.Windows.Forms.BindingSource fKDAYLOPTINCHIBindingSource2;
        private System.Windows.Forms.BindingSource dAYBindingSource1;
        private System.Windows.Forms.BindingSource fKDAYLOPTINCHIBindingSource3;
        private System.Windows.Forms.Button buttonDelGV;
        private System.Windows.Forms.Button btnAddGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.LookUpEdit comboBoxGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraGrid.Columns.GridColumn colMATGDK;     
        private System.Windows.Forms.TextBox textBoxTime;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTimeHoc;
        private System.Windows.Forms.Button buttonDelTime;
        private System.Windows.Forms.Button buttonAddtime;
        private System.Windows.Forms.Button btnDKTime;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTimeDK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private System.Windows.Forms.BindingSource tHOIGIANDKBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource spGetGVLTCBindingSource;
        private DSTableAdapters.sp_GetGVLTCTableAdapter sp_GetGVLTCTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlTGH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTGH;
        private DevExpress.XtraGrid.GridControl gridControlGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource spGetAllTGHBindingSource;
        private DSTableAdapters.sp_GetAllTGHTableAdapter sp_GetAllTGHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATGH;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.BindingSource spGetAllTGHBindingSource1;
        private DevExpress.XtraEditors.SpinEdit txtMaTGDK;
        private DevExpress.XtraLayout.LayoutControlItem spinTGDK;
    }
}