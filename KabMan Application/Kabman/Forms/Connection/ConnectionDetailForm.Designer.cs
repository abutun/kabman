namespace KabMan.Forms
{
    partial class ConnectionDetailForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.CDetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CGrid = new DevExpress.XtraGrid.GridControl();
            this.CMasterView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CDetailContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.itemReservation = new DevExpress.XtraBars.BarButtonItem();
            this.itemSwitchUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.itemDetailDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.itemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.itemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.CMasterContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.DeviceIDLookUp = new KabMan.Controls.C_LookUpDeviceSpecific();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.CDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDetailContextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMasterContextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceIDLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // CDetailView
            // 
            this.CDetailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn21,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn20,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn22,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.CDetailView.GridControl = this.CGrid;
            this.CDetailView.Name = "CDetailView";
            this.CDetailView.OptionsBehavior.AllowIncrementalSearch = true;
            this.CDetailView.OptionsBehavior.Editable = false;
            this.CDetailView.OptionsView.ShowGroupPanel = false;
            this.CDetailView.OptionsView.ShowIndicator = false;
            this.CDetailView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CDetailView_MouseMove);
            this.CDetailView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CDetailView_MouseDown);
            this.CDetailView.ColumnWidthChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.CDetailView_ColumnWidthChanged);
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Type";
            this.gridColumn19.FieldName = "DeviceType";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 33;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Connection Name";
            this.gridColumn21.FieldName = "ConnectionName";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            this.gridColumn21.Width = 53;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Server Name";
            this.gridColumn5.FieldName = "ServerName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 44;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Rack";
            this.gridColumn6.FieldName = "Rack";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 42;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Port";
            this.gridColumn20.FieldName = "Port";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 3;
            this.gridColumn20.Width = 53;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "LCURM";
            this.gridColumn7.FieldName = "LCURM";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 42;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Blech";
            this.gridColumn8.FieldName = "Blech";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 42;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Trunk";
            this.gridColumn9.FieldName = "Trunk";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 42;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "VTPort";
            this.gridColumn10.FieldName = "VTPort";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            this.gridColumn10.Width = 42;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "UrmUrm";
            this.gridColumn11.FieldName = "UrmUrm";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            this.gridColumn11.Width = 46;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "UrmUrm1";
            this.gridColumn22.FieldName = "UrmUrm1";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 10;
            this.gridColumn22.Width = 66;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "VTPort1";
            this.gridColumn12.FieldName = "VTPort1";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 13;
            this.gridColumn12.Width = 51;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "Trunk";
            this.gridColumn13.FieldName = "Trunk1";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            this.gridColumn13.Width = 40;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "VTPort";
            this.gridColumn25.FieldName = "VTPort3";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 15;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "VTPort2";
            this.gridColumn23.FieldName = "VTPort2";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 11;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "UrmUrm2";
            this.gridColumn24.FieldName = "UrmUrm2";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 14;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "Blech";
            this.gridColumn14.FieldName = "Blech1";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 16;
            this.gridColumn14.Width = 40;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.Caption = "LCURM";
            this.gridColumn15.FieldName = "LCURM1";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 17;
            this.gridColumn15.Width = 40;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.Caption = "PortNo";
            this.gridColumn16.FieldName = "PortNo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 18;
            this.gridColumn16.Width = 40;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.Caption = "Switch Name";
            this.gridColumn17.FieldName = "Switch";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 19;
            this.gridColumn17.Width = 90;
            // 
            // CGrid
            // 
            gridLevelNode1.LevelTemplate = this.CDetailView;
            gridLevelNode1.RelationName = "Level1";
            this.CGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.CGrid.Location = new System.Drawing.Point(7, 38);
            this.CGrid.MainView = this.CMasterView;
            this.CGrid.Name = "CGrid";
            this.CGrid.ShowOnlyPredefinedDetails = true;
            this.CGrid.Size = new System.Drawing.Size(810, 472);
            this.CGrid.TabIndex = 4;
            this.CGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CMasterView,
            this.CDetailView});
            this.CGrid.DragOver += new System.Windows.Forms.DragEventHandler(this.CGrid_DragOver);
            this.CGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.CGrid_DragDrop);
            this.CGrid.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.CGrid_FocusedViewChanged);
            // 
            // CMasterView
            // 
            this.CMasterView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CMasterView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.CMasterView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.CMasterView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.CMasterView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.CMasterView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CMasterView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CMasterView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CMasterView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.CMasterView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.CMasterView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.CMasterView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.CMasterView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CMasterView.Appearance.Empty.Options.UseBackColor = true;
            this.CMasterView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CMasterView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.CMasterView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CMasterView.Appearance.EvenRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.EvenRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CMasterView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.CMasterView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CMasterView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CMasterView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.CMasterView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.CMasterView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.CMasterView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.CMasterView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CMasterView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CMasterView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.CMasterView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.CMasterView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.CMasterView.Appearance.FixedLine.Options.UseBackColor = true;
            this.CMasterView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CMasterView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.CMasterView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.CMasterView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.CMasterView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.CMasterView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.CMasterView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.CMasterView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.CMasterView.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.GroupButton.Options.UseBackColor = true;
            this.CMasterView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.CMasterView.Appearance.GroupButton.Options.UseForeColor = true;
            this.CMasterView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CMasterView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CMasterView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.CMasterView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.CMasterView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.CMasterView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.CMasterView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.CMasterView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CMasterView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.CMasterView.Appearance.GroupPanel.Options.UseFont = true;
            this.CMasterView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.CMasterView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.CMasterView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.GroupRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.GroupRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CMasterView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.CMasterView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.CMasterView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CMasterView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.CMasterView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.CMasterView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CMasterView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.HorzLine.Options.UseBackColor = true;
            this.CMasterView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.CMasterView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.CMasterView.Appearance.OddRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.OddRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.CMasterView.Appearance.Preview.Options.UseBackColor = true;
            this.CMasterView.Appearance.Preview.Options.UseForeColor = true;
            this.CMasterView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.CMasterView.Appearance.Row.Options.UseBackColor = true;
            this.CMasterView.Appearance.Row.Options.UseForeColor = true;
            this.CMasterView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CMasterView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.CMasterView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.CMasterView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.CMasterView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.CMasterView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.CMasterView.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.CMasterView.Appearance.VertLine.Options.UseBackColor = true;
            this.CMasterView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn18});
            this.CMasterView.GridControl = this.CGrid;
            this.CMasterView.Name = "CMasterView";
            this.CMasterView.OptionsBehavior.Editable = false;
            this.CMasterView.OptionsView.EnableAppearanceEvenRow = true;
            this.CMasterView.OptionsView.EnableAppearanceOddRow = true;
            this.CMasterView.OptionsView.ShowAutoFilterRow = true;
            this.CMasterView.OptionsView.ShowGroupPanel = false;
            this.CMasterView.OptionsView.ShowIndicator = false;
            this.CMasterView.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.CMasterView_MasterRowExpanded);
            this.CMasterView.ColumnWidthChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.CMasterView_ColumnWidthChanged);
            this.CMasterView.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.CMasterView_ShowGridMenu);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Connection Name";
            this.gridColumn2.FieldName = "ConnectionName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Project Name";
            this.gridColumn3.FieldName = "ProjectName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Customer";
            this.gridColumn4.FieldName = "Customer";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "ID";
            this.gridColumn18.FieldName = "ID";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // CDetailContextMenu
            // 
            this.CDetailContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemReservation),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemSwitchUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemDetailDelete)});
            this.CDetailContextMenu.Manager = this.barManager1;
            this.CDetailContextMenu.Name = "CDetailContextMenu";
            // 
            // itemReservation
            // 
            this.itemReservation.Caption = "Reservation";
            this.itemReservation.Id = 0;
            this.itemReservation.Name = "itemReservation";
            this.itemReservation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemReservation_ItemClick);
            // 
            // itemSwitchUpdate
            // 
            this.itemSwitchUpdate.Caption = "Switch Update";
            this.itemSwitchUpdate.Id = 4;
            this.itemSwitchUpdate.Name = "itemSwitchUpdate";
            this.itemSwitchUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemSwitchUpdate_ItemClick);
            // 
            // itemDetailDelete
            // 
            this.itemDetailDelete.Caption = "Delete";
            this.itemDetailDelete.Id = 1;
            this.itemDetailDelete.Name = "itemDetailDelete";
            this.itemDetailDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemDetailDelete_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemReservation,
            this.itemDetailDelete,
            this.itemDelete,
            this.itemPrint,
            this.itemSwitchUpdate});
            this.barManager1.MaxItemId = 5;
            // 
            // itemDelete
            // 
            this.itemDelete.Caption = "Delete";
            this.itemDelete.Id = 2;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemDelete_ItemClick);
            // 
            // itemPrint
            // 
            this.itemPrint.Caption = "Print";
            this.itemPrint.Id = 3;
            this.itemPrint.Name = "itemPrint";
            this.itemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemPrint_ItemClick);
            // 
            // CMasterContextMenu
            // 
            this.CMasterContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemPrint)});
            this.CMasterContextMenu.Manager = this.barManager1;
            this.CMasterContextMenu.Name = "CMasterContextMenu";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl2.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl2.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl2.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl2.Controls.Add(this.DeviceIDLookUp);
            this.layoutControl2.Controls.Add(this.CGrid);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(823, 516);
            this.layoutControl2.TabIndex = 6;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // DeviceIDLookUp
            // 
            this.DeviceIDLookUp.Location = new System.Drawing.Point(44, 7);
            this.DeviceIDLookUp.MenuManager = this.barManager1;
            this.DeviceIDLookUp.Name = "DeviceIDLookUp";
            this.DeviceIDLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.DeviceIDLookUp.Properties.NullText = "Select Device!";
            this.DeviceIDLookUp.Size = new System.Drawing.Size(773, 20);
            this.DeviceIDLookUp.StyleController = this.layoutControl2;
            this.DeviceIDLookUp.TabIndex = 5;
            this.DeviceIDLookUp.EditValueChanged += new System.EventHandler(this.c_LookUpDeviceSpecific1_EditValueChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(823, 516);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "layoutControlGroup1";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CGrid;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(821, 483);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DeviceIDLookUp;
            this.layoutControlItem2.CustomizationFormText = "Device";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(98, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(821, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Device";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(32, 13);
            // 
            // ConnectionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 516);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ConnectionDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection List";
            this.Load += new System.EventHandler(this.ConnectionDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDetailContextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMasterContextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceIDLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu CDetailContextMenu;
        private DevExpress.XtraBars.PopupMenu CMasterContextMenu;
        private DevExpress.XtraGrid.GridControl CGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CMasterView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView CDetailView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem itemReservation;
        private DevExpress.XtraBars.BarButtonItem itemDetailDelete;
        private DevExpress.XtraBars.BarButtonItem itemDelete;
        private DevExpress.XtraBars.BarButtonItem itemPrint;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private KabMan.Controls.C_LookUpDeviceSpecific DeviceIDLookUp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraBars.BarButtonItem itemSwitchUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
    }
}