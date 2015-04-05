namespace KabMan.Forms
{
    partial class SwitchManagerForm
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
            this.CSwitchGrid = new DevExpress.XtraGrid.GridControl();
            this.CSwitchView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchView)).BeginInit();
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
            this.CStatusBar.BarName = "Status bar";
            this.CStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.CStatusBar.DockCol = 0;
            this.CStatusBar.DockRow = 0;
            this.CStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.CStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemCount)});
            this.CStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.CStatusBar.OptionsBar.DrawDragBorder = false;
            this.CStatusBar.OptionsBar.UseWholeRow = true;
            this.CStatusBar.Text = "Status bar";
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
            this.itemDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemViewDetails_ItemClick);
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
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSwitchGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(500, 433);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CSwitchGrid
            // 
            this.CSwitchGrid.Location = new System.Drawing.Point(7, 7);
            this.CSwitchGrid.MainView = this.CSwitchView;
            this.CSwitchGrid.Name = "CSwitchGrid";
            this.CSwitchGrid.Size = new System.Drawing.Size(487, 420);
            this.CSwitchGrid.TabIndex = 4;
            this.CSwitchGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CSwitchView});
            this.CSwitchGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CSwitchGrid_MouseDoubleClick);
            // 
            // CSwitchView
            // 
            this.CSwitchView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CSwitchView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.CSwitchView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.CSwitchView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.CSwitchView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CSwitchView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CSwitchView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CSwitchView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.CSwitchView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.CSwitchView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.CSwitchView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CSwitchView.Appearance.Empty.Options.UseBackColor = true;
            this.CSwitchView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CSwitchView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.CSwitchView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CSwitchView.Appearance.EvenRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.EvenRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CSwitchView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.CSwitchView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CSwitchView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CSwitchView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.CSwitchView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.CSwitchView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CSwitchView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CSwitchView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.CSwitchView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.CSwitchView.Appearance.FixedLine.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CSwitchView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.CSwitchView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.CSwitchView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.CSwitchView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.CSwitchView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.CSwitchView.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.GroupButton.Options.UseBackColor = true;
            this.CSwitchView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.GroupButton.Options.UseForeColor = true;
            this.CSwitchView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CSwitchView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CSwitchView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.CSwitchView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.CSwitchView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.CSwitchView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.CSwitchView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CSwitchView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.CSwitchView.Appearance.GroupPanel.Options.UseFont = true;
            this.CSwitchView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.CSwitchView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.CSwitchView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.GroupRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.GroupRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CSwitchView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.CSwitchView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.CSwitchView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CSwitchView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.CSwitchView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.CSwitchView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CSwitchView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.HorzLine.Options.UseBackColor = true;
            this.CSwitchView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.CSwitchView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.CSwitchView.Appearance.OddRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.OddRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.CSwitchView.Appearance.Preview.Options.UseBackColor = true;
            this.CSwitchView.Appearance.Preview.Options.UseForeColor = true;
            this.CSwitchView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.CSwitchView.Appearance.Row.Options.UseBackColor = true;
            this.CSwitchView.Appearance.Row.Options.UseForeColor = true;
            this.CSwitchView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CSwitchView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.CSwitchView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.CSwitchView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.CSwitchView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.CSwitchView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.CSwitchView.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.CSwitchView.Appearance.VertLine.Options.UseBackColor = true;
            this.CSwitchView.GridControl = this.CSwitchGrid;
            this.CSwitchView.Name = "CSwitchView";
            this.CSwitchView.OptionsBehavior.Editable = false;
            this.CSwitchView.OptionsView.EnableAppearanceEvenRow = true;
            this.CSwitchView.OptionsView.EnableAppearanceOddRow = true;
            this.CSwitchView.OptionsView.ShowGroupPanel = false;
            this.CSwitchView.OptionsView.ShowIndicator = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 433);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CSwitchGrid;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(498, 431);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // SwitchManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "SwitchManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Switch Manager";
            this.Load += new System.EventHandler(this.SwitchManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchView)).EndInit();
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
        private DevExpress.XtraGrid.GridControl CSwitchGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CSwitchView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarStaticItem itemCount;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem itemNew;
        private DevExpress.XtraBars.BarButtonItem itemDelete;
        private DevExpress.XtraBars.BarButtonItem itemDetails;
        private DevExpress.XtraBars.BarButtonItem itemExit;
    }
}