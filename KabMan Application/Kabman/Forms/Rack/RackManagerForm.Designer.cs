namespace KabMan.Forms
{
    partial class RackManagerForm
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
            this.CBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.CStatusBar = new DevExpress.XtraBars.Bar();
            this.itemCount = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.itemNew = new DevExpress.XtraBars.BarButtonItem();
            this.itemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.itemDetails = new DevExpress.XtraBars.BarButtonItem();
            this.itemExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CRackGrid = new DevExpress.XtraGrid.GridControl();
            this.CRackView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRackGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRackView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBarManager
            // 
            this.CBarManager.AllowCustomization = false;
            this.CBarManager.AllowQuickCustomization = false;
            this.CBarManager.AllowShowToolbarsPopup = false;
            this.CBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.CStatusBar,
            this.bar1});
            this.CBarManager.DockControls.Add(this.barDockControlTop);
            this.CBarManager.DockControls.Add(this.barDockControlBottom);
            this.CBarManager.DockControls.Add(this.barDockControlLeft);
            this.CBarManager.DockControls.Add(this.barDockControlRight);
            this.CBarManager.Form = this;
            this.CBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemCount,
            this.itemNew,
            this.itemDelete,
            this.itemDetails,
            this.itemExit});
            this.CBarManager.MaxItemId = 9;
            this.CBarManager.StatusBar = this.CStatusBar;
            // 
            // CStatusBar
            // 
            this.CStatusBar.BarName = "Status Bar";
            this.CStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.CStatusBar.DockCol = 0;
            this.CStatusBar.DockRow = 0;
            this.CStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.CStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemCount)});
            this.CStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.CStatusBar.OptionsBar.DrawDragBorder = false;
            this.CStatusBar.OptionsBar.UseWholeRow = true;
            this.CStatusBar.Text = "Status Bar";
            // 
            // itemCount
            // 
            this.itemCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemCount.Caption = "0";
            this.itemCount.Id = 4;
            this.itemCount.Name = "itemCount";
            this.itemCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemDetails, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemExit, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 4";
            // 
            // itemNew
            // 
            this.itemNew.Caption = "New";
            this.itemNew.Id = 5;
            this.itemNew.Name = "itemNew";
            this.itemNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.itemNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemNew_ItemClick);
            // 
            // itemDelete
            // 
            this.itemDelete.Caption = "Delete";
            this.itemDelete.Id = 6;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // itemDetails
            // 
            this.itemDetails.Caption = "View Details";
            this.itemDetails.Id = 7;
            this.itemDetails.Name = "itemDetails";
            this.itemDetails.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.itemDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemDetails_ItemClick);
            // 
            // itemExit
            // 
            this.itemExit.Caption = "Exit";
            this.itemExit.Id = 8;
            this.itemExit.Name = "itemExit";
            this.itemExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.itemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemExit_ItemClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CRackGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(556, 533);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CRackGrid
            // 
            this.CRackGrid.Location = new System.Drawing.Point(7, 7);
            this.CRackGrid.MainView = this.CRackView;
            this.CRackGrid.Name = "CRackGrid";
            this.CRackGrid.Size = new System.Drawing.Size(543, 520);
            this.CRackGrid.TabIndex = 4;
            this.CRackGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CRackView});
            this.CRackGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CRackGrid_MouseDoubleClick);
            // 
            // CRackView
            // 
            this.CRackView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CRackView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.CRackView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.CRackView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.CRackView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.CRackView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CRackView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CRackView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CRackView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.CRackView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.CRackView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.CRackView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.CRackView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CRackView.Appearance.Empty.Options.UseBackColor = true;
            this.CRackView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CRackView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.CRackView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CRackView.Appearance.EvenRow.Options.UseBackColor = true;
            this.CRackView.Appearance.EvenRow.Options.UseForeColor = true;
            this.CRackView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CRackView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.CRackView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CRackView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CRackView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.CRackView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.CRackView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.CRackView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.CRackView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CRackView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.CRackView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CRackView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.CRackView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.CRackView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.CRackView.Appearance.FixedLine.Options.UseBackColor = true;
            this.CRackView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CRackView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.CRackView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.CRackView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.CRackView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.CRackView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.CRackView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.CRackView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.CRackView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.CRackView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.CRackView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.CRackView.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.GroupButton.Options.UseBackColor = true;
            this.CRackView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.CRackView.Appearance.GroupButton.Options.UseForeColor = true;
            this.CRackView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CRackView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CRackView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.CRackView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.CRackView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.CRackView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.CRackView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.CRackView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CRackView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.CRackView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.CRackView.Appearance.GroupPanel.Options.UseFont = true;
            this.CRackView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.CRackView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.CRackView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.GroupRow.Options.UseBackColor = true;
            this.CRackView.Appearance.GroupRow.Options.UseForeColor = true;
            this.CRackView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CRackView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.CRackView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.CRackView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CRackView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.CRackView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.CRackView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CRackView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.CRackView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.CRackView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.HorzLine.Options.UseBackColor = true;
            this.CRackView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.CRackView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.CRackView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.CRackView.Appearance.OddRow.Options.UseBackColor = true;
            this.CRackView.Appearance.OddRow.Options.UseForeColor = true;
            this.CRackView.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.CRackView.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.CRackView.Appearance.Preview.Options.UseBackColor = true;
            this.CRackView.Appearance.Preview.Options.UseForeColor = true;
            this.CRackView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.CRackView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.CRackView.Appearance.Row.Options.UseBackColor = true;
            this.CRackView.Appearance.Row.Options.UseForeColor = true;
            this.CRackView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.CRackView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CRackView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.CRackView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.CRackView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.CRackView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.CRackView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.CRackView.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.CRackView.Appearance.VertLine.Options.UseBackColor = true;
            this.CRackView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.CRackView.GridControl = this.CRackGrid;
            this.CRackView.Name = "CRackView";
            this.CRackView.OptionsBehavior.AllowIncrementalSearch = true;
            this.CRackView.OptionsBehavior.Editable = false;
            this.CRackView.OptionsView.EnableAppearanceEvenRow = true;
            this.CRackView.OptionsView.EnableAppearanceOddRow = true;
            this.CRackView.OptionsView.ShowAutoFilterRow = true;
            this.CRackView.OptionsView.ShowGroupPanel = false;
            this.CRackView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "ID";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Location";
            this.gridColumn2.FieldName = "LocationName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Data Center";
            this.gridColumn3.FieldName = "DataCenterName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Coordinate";
            this.gridColumn4.FieldName = "CoordinateName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Operating System";
            this.gridColumn5.FieldName = "OSName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Port Count";
            this.gridColumn6.FieldName = "PortCount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(556, 533);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CRackGrid;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(554, 531);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // RackManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 582);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RackManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rack Management";
            this.Load += new System.EventHandler(this.RackManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CRackGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRackView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager CBarManager;
        private DevExpress.XtraBars.Bar CStatusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl CRackGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CRackView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarStaticItem itemCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem itemNew;
        private DevExpress.XtraBars.BarButtonItem itemDelete;
        private DevExpress.XtraBars.BarButtonItem itemDetails;
        private DevExpress.XtraBars.BarButtonItem itemExit;
    }
}