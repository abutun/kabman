namespace KabMan.Forms
{
    partial class ReportForm
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
            this.itemResultCount = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.itemPreview = new DevExpress.XtraBars.BarButtonItem();
            this.ItemBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.itemClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CSearchType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CResultGrid = new DevExpress.XtraGrid.GridControl();
            this.CResultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CSearchThis = new DevExpress.XtraEditors.TextEdit();
            this.CSearchIn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CSearchTypeItemControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchThis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchTypeItemControl)).BeginInit();
            this.SuspendLayout();
            // 
            // CBarManager
            // 
            this.CBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.CStatusBar,
            this.bar1});
            this.CBarManager.DockControls.Add(this.barDockControlTop);
            this.CBarManager.DockControls.Add(this.barDockControlBottom);
            this.CBarManager.DockControls.Add(this.barDockControlLeft);
            this.CBarManager.DockControls.Add(this.barDockControlRight);
            this.CBarManager.Form = this;
            this.CBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemClose,
            this.itemResultCount,
            this.barButtonItem1,
            this.itemPreview,
            this.ItemBtnClose});
            this.CBarManager.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.itemResultCount)});
            this.CStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.CStatusBar.OptionsBar.DrawDragBorder = false;
            this.CStatusBar.OptionsBar.UseWholeRow = true;
            this.CStatusBar.Text = "Status Bar";
            // 
            // itemResultCount
            // 
            this.itemResultCount.Caption = "0";
            this.itemResultCount.Id = 1;
            this.itemResultCount.Name = "itemResultCount";
            this.itemResultCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.itemPreview, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.ItemBtnClose, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // itemPreview
            // 
            this.itemPreview.Caption = "Print Preview";
            this.itemPreview.Id = 3;
            this.itemPreview.Name = "itemPreview";
            this.itemPreview.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.itemPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ItemBtnClose
            // 
            this.ItemBtnClose.Caption = "Exit";
            this.ItemBtnClose.Glyph = global::KabMan.Properties.Resources.ManagerExit;
            this.ItemBtnClose.Id = 4;
            this.ItemBtnClose.Name = "ItemBtnClose";
            this.ItemBtnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ItemBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemClose_ItemClick);
            // 
            // itemClose
            // 
            this.itemClose.Caption = "&Close";
            this.itemClose.Id = 0;
            this.itemClose.Name = "itemClose";
            this.itemClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.itemClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemClose_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Print Preview";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSearchType);
            this.layoutControl1.Controls.Add(this.CResultGrid);
            this.layoutControl1.Controls.Add(this.CSearchThis);
            this.layoutControl1.Controls.Add(this.CSearchIn);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(721, 546);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CSearchType
            // 
            this.CSearchType.Location = new System.Drawing.Point(68, 59);
            this.CSearchType.MenuManager = this.CBarManager;
            this.CSearchType.Name = "CSearchType";
            this.CSearchType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CSearchType.Properties.Items.AddRange(new object[] {
            "DASD",
            "Server",
            "DCC"});
            this.CSearchType.Properties.NullText = "Select Device!";
            this.CSearchType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CSearchType.Size = new System.Drawing.Size(302, 20);
            this.CSearchType.StyleController = this.layoutControl1;
            this.CSearchType.TabIndex = 7;
            this.CSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // CResultGrid
            // 
            this.CResultGrid.Location = new System.Drawing.Point(7, 124);
            this.CResultGrid.MainView = this.CResultView;
            this.CResultGrid.Name = "CResultGrid";
            this.CResultGrid.Size = new System.Drawing.Size(708, 416);
            this.CResultGrid.TabIndex = 6;
            this.CResultGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CResultView});
            // 
            // CResultView
            // 
            this.CResultView.GridControl = this.CResultGrid;
            this.CResultView.Name = "CResultView";
            this.CResultView.OptionsBehavior.Editable = false;
            this.CResultView.OptionsView.EnableAppearanceEvenRow = true;
            this.CResultView.OptionsView.EnableAppearanceOddRow = true;
            this.CResultView.OptionsView.ShowGroupPanel = false;
            this.CResultView.OptionsView.ShowIndicator = false;
            // 
            // CSearchThis
            // 
            this.CSearchThis.Location = new System.Drawing.Point(68, 90);
            this.CSearchThis.Name = "CSearchThis";
            this.CSearchThis.Size = new System.Drawing.Size(302, 20);
            this.CSearchThis.StyleController = this.layoutControl1;
            this.CSearchThis.TabIndex = 5;
            this.CSearchThis.EditValueChanged += new System.EventHandler(this.CSearchThis_EditValueChanged);
            // 
            // CSearchIn
            // 
            this.CSearchIn.Location = new System.Drawing.Point(68, 28);
            this.CSearchIn.Name = "CSearchIn";
            this.CSearchIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CSearchIn.Properties.Items.AddRange(new object[] {
            "Cable",
            "Connection",
            "Server",
            "Switch",
            "DASD",
            "DCC"});
            this.CSearchIn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CSearchIn.Size = new System.Drawing.Size(302, 20);
            this.CSearchIn.StyleController = this.layoutControl1;
            this.CSearchIn.TabIndex = 4;
            this.CSearchIn.SelectedIndexChanged += new System.EventHandler(this.CSearchIn_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(721, 546);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CResultGrid;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(719, 427);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(377, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(342, 117);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Kategorized Report";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.CSearchTypeItemControl});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(377, 117);
            this.layoutControlGroup2.Text = "Categorized Report";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CSearchIn;
            this.layoutControlItem1.CustomizationFormText = "Search in";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(371, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(371, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(371, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Search in";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CSearchThis;
            this.layoutControlItem2.CustomizationFormText = "Search this";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(371, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(371, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(371, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Search this";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // CSearchTypeItemControl
            // 
            this.CSearchTypeItemControl.Control = this.CSearchType;
            this.CSearchTypeItemControl.CustomizationFormText = "Device";
            this.CSearchTypeItemControl.Location = new System.Drawing.Point(0, 31);
            this.CSearchTypeItemControl.Name = "CSearchTypeItemControl";
            this.CSearchTypeItemControl.Size = new System.Drawing.Size(371, 31);
            this.CSearchTypeItemControl.Text = "Device";
            this.CSearchTypeItemControl.TextLocation = DevExpress.Utils.Locations.Left;
            this.CSearchTypeItemControl.TextSize = new System.Drawing.Size(53, 13);
            this.CSearchTypeItemControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 595);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ReportForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSearchType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchThis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSearchTypeItemControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager CBarManager;
        private DevExpress.XtraBars.Bar CStatusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem itemClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl CResultGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CResultView;
        private DevExpress.XtraEditors.TextEdit CSearchThis;
        private DevExpress.XtraEditors.ComboBoxEdit CSearchIn;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarStaticItem itemResultCount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem itemPreview;
        private DevExpress.XtraBars.BarButtonItem ItemBtnClose;
        private DevExpress.XtraEditors.ComboBoxEdit CSearchType;
        private DevExpress.XtraLayout.LayoutControlItem CSearchTypeItemControl;
    }
}