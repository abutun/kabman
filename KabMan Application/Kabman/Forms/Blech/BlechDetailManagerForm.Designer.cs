namespace KabMan.Forms
{
    partial class BlechDetailManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlechDetailManagerForm));
            this.repositoryItemLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.CToolBar = new DevExpress.XtraBars.Bar();
            this.itemExit = new DevExpress.XtraBars.BarButtonItem();
            this.CStatusBar = new DevExpress.XtraBars.Bar();
            this.itemCount = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CGridControl = new DevExpress.XtraGrid.GridControl();
            this.CGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CSan = new KabMan.Controls.C_LookUpControl();
            this.CSanGroup = new KabMan.Controls.C_LookUpControl();
            this.CCoordinate = new KabMan.Controls.C_LookUpControl();
            this.CDataCenter = new KabMan.Controls.C_LookUpControl();
            this.CLocation = new KabMan.Controls.C_LookUpControl();
            this.CSerial = new DevExpress.XtraEditors.TextEdit();
            this.CDevice = new KabMan.Controls.C_LookUpControl();
            this.CBlechType = new KabMan.Controls.C_LookUpControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCoordinate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDataCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBlechType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit7
            // 
            this.repositoryItemLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.repositoryItemLookUpEdit7.Name = "repositoryItemLookUpEdit7";
            this.repositoryItemLookUpEdit7.NullText = "Select SAN!";
            // 
            // repositoryItemLookUpEdit8
            // 
            this.repositoryItemLookUpEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemLookUpEdit8.Name = "repositoryItemLookUpEdit8";
            this.repositoryItemLookUpEdit8.NullText = "Select SAN Group!";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "Select Coordinate!";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "Select Data Center!";
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.NullText = "Select Location!";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // CBarManager
            // 
            this.CBarManager.AllowCustomization = false;
            this.CBarManager.AllowQuickCustomization = false;
            this.CBarManager.AllowShowToolbarsPopup = false;
            this.CBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.CToolBar,
            this.CStatusBar});
            this.CBarManager.DockControls.Add(this.barDockControlTop);
            this.CBarManager.DockControls.Add(this.barDockControlBottom);
            this.CBarManager.DockControls.Add(this.barDockControlLeft);
            this.CBarManager.DockControls.Add(this.barDockControlRight);
            this.CBarManager.Form = this;
            this.CBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemExit,
            this.itemCount});
            this.CBarManager.MainMenu = this.CToolBar;
            this.CBarManager.MaxItemId = 5;
            this.CBarManager.StatusBar = this.CStatusBar;
            // 
            // CToolBar
            // 
            this.CToolBar.BarName = "Tool Bar";
            this.CToolBar.DockCol = 0;
            this.CToolBar.DockRow = 0;
            this.CToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.CToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.itemExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.CToolBar.OptionsBar.AllowQuickCustomization = false;
            this.CToolBar.OptionsBar.DrawDragBorder = false;
            this.CToolBar.OptionsBar.MultiLine = true;
            this.CToolBar.OptionsBar.UseWholeRow = true;
            this.CToolBar.Text = "Tool Bar";
            // 
            // itemExit
            // 
            this.itemExit.Caption = "Exit";
            this.itemExit.Id = 3;
            this.itemExit.Name = "itemExit";
            this.itemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemExit_ItemClick);
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
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CGridControl);
            this.layoutControl1.Controls.Add(this.CSan);
            this.layoutControl1.Controls.Add(this.CSanGroup);
            this.layoutControl1.Controls.Add(this.CCoordinate);
            this.layoutControl1.Controls.Add(this.CDataCenter);
            this.layoutControl1.Controls.Add(this.CLocation);
            this.layoutControl1.Controls.Add(this.CSerial);
            this.layoutControl1.Controls.Add(this.CDevice);
            this.layoutControl1.Controls.Add(this.CBlechType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(493, 450);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CGridControl
            // 
            this.CGridControl.Location = new System.Drawing.Point(7, 7);
            this.CGridControl.MainView = this.CGridView;
            this.CGridControl.Name = "CGridControl";
            this.CGridControl.Size = new System.Drawing.Size(480, 437);
            this.CGridControl.TabIndex = 12;
            this.CGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CGridView});
            // 
            // CGridView
            // 
            this.CGridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CGridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.CGridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.CGridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.CGridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.CGridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CGridView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CGridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CGridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.CGridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.CGridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.CGridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.CGridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CGridView.Appearance.Empty.Options.UseBackColor = true;
            this.CGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.CGridView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.CGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.CGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.CGridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CGridView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.CGridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CGridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CGridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.CGridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.CGridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.CGridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.CGridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CGridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.CGridView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CGridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.CGridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.CGridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.CGridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.CGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CGridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.CGridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.CGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.CGridView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.CGridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.CGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.CGridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.CGridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.CGridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.CGridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.CGridView.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.CGridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.CGridView.Appearance.GroupButton.Options.UseForeColor = true;
            this.CGridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CGridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.CGridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.CGridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.CGridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.CGridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.CGridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.CGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CGridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.CGridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.CGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.CGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.CGridView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.CGridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.CGridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.CGridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.CGridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.CGridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.CGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.CGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.CGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.CGridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.CGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.CGridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.CGridView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.CGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.CGridView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.CGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.CGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.CGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.CGridView.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.CGridView.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.CGridView.Appearance.Preview.Options.UseBackColor = true;
            this.CGridView.Appearance.Preview.Options.UseForeColor = true;
            this.CGridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.CGridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.CGridView.Appearance.Row.Options.UseBackColor = true;
            this.CGridView.Appearance.Row.Options.UseForeColor = true;
            this.CGridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.CGridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CGridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.CGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.CGridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.CGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.CGridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.CGridView.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.CGridView.Appearance.VertLine.Options.UseBackColor = true;
            this.CGridView.GridControl = this.CGridControl;
            this.CGridView.Name = "CGridView";
            this.CGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.CGridView.OptionsBehavior.Editable = false;
            this.CGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.CGridView.OptionsView.EnableAppearanceOddRow = true;
            this.CGridView.OptionsView.ShowGroupPanel = false;
            this.CGridView.OptionsView.ShowIndicator = false;
            // 
            // CSan
            // 
            this.CSan.Columns = this.repositoryItemLookUpEdit7.Columns;
            this.CSan.DisplayMember = null;
            this.CSan.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CSan.FormParameters")));
            this.CSan.Location = new System.Drawing.Point(67, 59);
            this.CSan.Name = "CSan";
            this.CSan.NullText = "Select SAN!";
            this.CSan.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.CSan.Properties.NullText = "Select SAN!";
            this.CSan.RefreshButtonVisible = true;
            this.CSan.Size = new System.Drawing.Size(545, 20);
            this.CSan.StoredProcedure = null;
            this.CSan.StyleController = this.layoutControl1;
            this.CSan.TabIndex = 11;
            this.CSan.TriggerControl = null;
            this.CSan.ValueMember = null;
            // 
            // CSanGroup
            // 
            this.CSanGroup.AddButtonEnabled = true;
            this.CSanGroup.Columns = this.repositoryItemLookUpEdit8.Columns;
            this.CSanGroup.DisplayMember = null;
            this.CSanGroup.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CSanGroup.FormParameters")));
            this.CSanGroup.Location = new System.Drawing.Point(67, 28);
            this.CSanGroup.Name = "CSanGroup";
            this.CSanGroup.NullText = "Select SAN Group!";
            this.CSanGroup.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CSanGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CSanGroup.Properties.NullText = "Select SAN Group!";
            this.CSanGroup.RefreshButtonVisible = true;
            this.CSanGroup.Size = new System.Drawing.Size(545, 20);
            this.CSanGroup.StoredProcedure = null;
            this.CSanGroup.StyleController = this.layoutControl1;
            this.CSanGroup.TabIndex = 10;
            this.CSanGroup.TriggerControl = null;
            this.CSanGroup.ValueMember = null;
            // 
            // CCoordinate
            // 
            this.CCoordinate.Columns = this.repositoryItemLookUpEdit3.Columns;
            this.CCoordinate.DisplayMember = null;
            this.CCoordinate.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CCoordinate.FormParameters")));
            this.CCoordinate.Location = new System.Drawing.Point(74, 90);
            this.CCoordinate.Name = "CCoordinate";
            this.CCoordinate.NullText = "Select Coordinate!";
            this.CCoordinate.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CCoordinate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.CCoordinate.Properties.NullText = "Select Coordinate!";
            this.CCoordinate.RefreshButtonVisible = true;
            this.CCoordinate.Size = new System.Drawing.Size(538, 20);
            this.CCoordinate.StoredProcedure = null;
            this.CCoordinate.StyleController = this.layoutControl1;
            this.CCoordinate.TabIndex = 9;
            this.CCoordinate.TriggerControl = null;
            this.CCoordinate.ValueMember = null;
            // 
            // CDataCenter
            // 
            this.CDataCenter.Columns = this.repositoryItemLookUpEdit4.Columns;
            this.CDataCenter.DisplayMember = null;
            this.CDataCenter.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CDataCenter.FormParameters")));
            this.CDataCenter.Location = new System.Drawing.Point(74, 59);
            this.CDataCenter.Name = "CDataCenter";
            this.CDataCenter.NullText = "Select Data Center!";
            this.CDataCenter.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CDataCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.CDataCenter.Properties.NullText = "Select Data Center!";
            this.CDataCenter.RefreshButtonVisible = true;
            this.CDataCenter.Size = new System.Drawing.Size(538, 20);
            this.CDataCenter.StoredProcedure = null;
            this.CDataCenter.StyleController = this.layoutControl1;
            this.CDataCenter.TabIndex = 8;
            this.CDataCenter.TriggerControl = null;
            this.CDataCenter.ValueMember = null;
            // 
            // CLocation
            // 
            this.CLocation.AddButtonEnabled = true;
            this.CLocation.Columns = this.repositoryItemLookUpEdit5.Columns;
            this.CLocation.DisplayMember = null;
            this.CLocation.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CLocation.FormParameters")));
            this.CLocation.Location = new System.Drawing.Point(74, 28);
            this.CLocation.Name = "CLocation";
            this.CLocation.NullText = "Select Location!";
            this.CLocation.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CLocation.Properties.NullText = "Select Location!";
            this.CLocation.RefreshButtonVisible = true;
            this.CLocation.Size = new System.Drawing.Size(538, 20);
            this.CLocation.StoredProcedure = null;
            this.CLocation.StyleController = this.layoutControl1;
            this.CLocation.TabIndex = 7;
            this.CLocation.TriggerControl = null;
            this.CLocation.ValueMember = null;
            // 
            // CSerial
            // 
            this.CSerial.Location = new System.Drawing.Point(74, 90);
            this.CSerial.Name = "CSerial";
            this.CSerial.Size = new System.Drawing.Size(538, 20);
            this.CSerial.StyleController = this.layoutControl1;
            this.CSerial.TabIndex = 6;
            // 
            // CDevice
            // 
            this.CDevice.AddButtonEnabled = true;
            this.CDevice.Columns = this.repositoryItemLookUpEdit1.Columns;
            this.CDevice.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CDevice.FormParameters")));
            this.CDevice.Location = new System.Drawing.Point(74, 59);
            this.CDevice.Name = "CDevice";
            this.CDevice.NullText = "Select Device to use Blech with!";
            this.CDevice.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CDevice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CDevice.Properties.NullText = "Select Device to use Blech with!";
            this.CDevice.RefreshButtonVisible = true;
            this.CDevice.Size = new System.Drawing.Size(538, 20);
            this.CDevice.StoredProcedure = null;
            this.CDevice.StyleController = this.layoutControl1;
            this.CDevice.TabIndex = 5;
            this.CDevice.TriggerControl = null;
            // 
            // CBlechType
            // 
            this.CBlechType.AddButtonEnabled = true;
            this.CBlechType.Columns = this.repositoryItemLookUpEdit2.Columns;
            this.CBlechType.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CBlechType.FormParameters")));
            this.CBlechType.Location = new System.Drawing.Point(74, 28);
            this.CBlechType.Name = "CBlechType";
            this.CBlechType.NullText = "Select Blech Type!";
            this.CBlechType.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CBlechType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CBlechType.Properties.NullText = "Select Blech Type!";
            this.CBlechType.RefreshButtonVisible = true;
            this.CBlechType.Size = new System.Drawing.Size(538, 20);
            this.CBlechType.StoredProcedure = null;
            this.CBlechType.StyleController = this.layoutControl1;
            this.CBlechType.TabIndex = 4;
            this.CBlechType.TriggerControl = null;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(493, 450);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.CGridControl;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(491, 448);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // BlechDetailManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 499);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "BlechDetailManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blech Details";
            this.Load += new System.EventHandler(this.BlechManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCoordinate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDataCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBlechType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager CBarManager;
        private DevExpress.XtraBars.Bar CToolBar;
        private DevExpress.XtraBars.Bar CStatusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem itemExit;
        private DevExpress.XtraBars.BarStaticItem itemCount;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit CSerial;
        private KabMan.Controls.C_LookUpControl CDevice;
        private KabMan.Controls.C_LookUpControl CBlechType;
        private KabMan.Controls.C_LookUpControl CSan;
        private KabMan.Controls.C_LookUpControl CSanGroup;
        private KabMan.Controls.C_LookUpControl CCoordinate;
        private KabMan.Controls.C_LookUpControl CDataCenter;
        private KabMan.Controls.C_LookUpControl CLocation;
        private DevExpress.XtraGrid.GridControl CGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit8;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;

    }
}