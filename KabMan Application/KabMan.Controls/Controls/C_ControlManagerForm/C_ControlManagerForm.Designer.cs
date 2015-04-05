namespace KabMan.Controls
{
    partial class C_ControlManagerForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.statustextCount = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.newButton = new DevExpress.XtraBars.BarButtonItem();
            this.editButton = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveButton = new DevExpress.XtraBars.BarButtonItem();
            this.cancelButton = new DevExpress.XtraBars.BarButtonItem();
            this.exitButton = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.managerGridControl = new DevExpress.XtraGrid.GridControl();
            this.managerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlPanel = new System.Windows.Forms.Panel();
            this.rootPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).BeginInit();
            this.rootPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar,
            this.bar1});
            this.barManager.Controller = this.barAndDockingController1;
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.statustextCount,
            this.barButtonItem1,
            this.newButton,
            this.editButton,
            this.deleteButton,
            this.saveButton,
            this.cancelButton,
            this.exitButton});
            this.barManager.MaxItemId = 15;
            this.barManager.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status Bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statustextCount)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status Bar";
            // 
            // statustextCount
            // 
            this.statustextCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statustextCount.Caption = "0";
            this.statustextCount.Id = 5;
            this.statustextCount.Name = "statustextCount";
            this.statustextCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar1
            // 
            this.bar1.BarName = "Toolbar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.newButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.editButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.exitButton, true)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Toolbar";
            // 
            // newButton
            // 
            this.newButton.Caption = "New";
            this.newButton.Id = 9;
            this.newButton.Name = "newButton";
            this.newButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.newButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newButton_ItemClick);
            // 
            // editButton
            // 
            this.editButton.Caption = "Edit";
            this.editButton.Id = 10;
            this.editButton.Name = "editButton";
            this.editButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.editButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editButton_ItemClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Caption = "Delete";
            this.deleteButton.Id = 11;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteButton_ItemClick);
            // 
            // saveButton
            // 
            this.saveButton.Caption = "Save";
            this.saveButton.Id = 12;
            this.saveButton.Name = "saveButton";
            this.saveButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.saveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveButton_ItemClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Caption = "Cancel";
            this.cancelButton.Id = 13;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.cancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelButton_ItemClick);
            // 
            // exitButton
            // 
            this.exitButton.Caption = "Exit";
            this.exitButton.Id = 14;
            this.exitButton.Name = "exitButton";
            this.exitButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.exitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitButton_ItemClick);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // managerGridControl
            // 
            this.managerGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.managerGridControl.Location = new System.Drawing.Point(0, 26);
            this.managerGridControl.MainView = this.managerGridView;
            this.managerGridControl.Name = "managerGridControl";
            this.managerGridControl.Size = new System.Drawing.Size(400, 379);
            this.managerGridControl.TabIndex = 5;
            this.managerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.managerGridView});
            this.managerGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.managerGridControl_MouseDoubleClick);
            // 
            // managerGridView
            // 
            this.managerGridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.managerGridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.managerGridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.managerGridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.managerGridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.managerGridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.managerGridView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.managerGridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.managerGridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.managerGridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.managerGridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.managerGridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.managerGridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.managerGridView.Appearance.Empty.Options.UseBackColor = true;
            this.managerGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.managerGridView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.managerGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.managerGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.managerGridView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.managerGridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.managerGridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.managerGridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.managerGridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.managerGridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.managerGridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.managerGridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.managerGridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.managerGridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.managerGridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.managerGridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.managerGridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.managerGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.managerGridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.managerGridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.managerGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.managerGridView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.managerGridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.managerGridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.managerGridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.managerGridView.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.managerGridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.managerGridView.Appearance.GroupButton.Options.UseForeColor = true;
            this.managerGridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.managerGridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.managerGridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.managerGridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.managerGridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.managerGridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.managerGridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.managerGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.managerGridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.managerGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.managerGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.managerGridView.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.managerGridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.managerGridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.managerGridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.managerGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.managerGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.managerGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.managerGridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.managerGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.managerGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.managerGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.managerGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.managerGridView.Appearance.Preview.Options.UseBackColor = true;
            this.managerGridView.Appearance.Preview.Options.UseForeColor = true;
            this.managerGridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.managerGridView.Appearance.Row.Options.UseBackColor = true;
            this.managerGridView.Appearance.Row.Options.UseForeColor = true;
            this.managerGridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.managerGridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.managerGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.managerGridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.managerGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.managerGridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.managerGridView.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.managerGridView.Appearance.VertLine.Options.UseBackColor = true;
            this.managerGridView.GridControl = this.managerGridControl;
            this.managerGridView.Name = "managerGridView";
            this.managerGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.managerGridView.OptionsBehavior.Editable = false;
            this.managerGridView.OptionsCustomization.AllowFilter = false;
            this.managerGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.managerGridView.OptionsView.EnableAppearanceOddRow = true;
            this.managerGridView.OptionsView.ShowGroupPanel = false;
            this.managerGridView.OptionsView.ShowIndicator = false;
            // 
            // layoutControlPanel
            // 
            this.layoutControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControlPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPanel.MinimumSize = new System.Drawing.Size(400, 20);
            this.layoutControlPanel.Name = "layoutControlPanel";
            this.layoutControlPanel.Size = new System.Drawing.Size(400, 20);
            this.layoutControlPanel.TabIndex = 6;
            this.layoutControlPanel.Resize += new System.EventHandler(this.layoutControlPanel_Resize);
            this.layoutControlPanel.Move += new System.EventHandler(this.layoutControlPanel_Move);
            // 
            // rootPanel
            // 
            this.rootPanel.Controls.Add(this.managerGridControl);
            this.rootPanel.Controls.Add(this.layoutControlPanel);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 24);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Size = new System.Drawing.Size(400, 411);
            this.rootPanel.TabIndex = 7;
            this.rootPanel.Resize += new System.EventHandler(this.rootPanel_Resize);
            // 
            // C_ControlManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(400, 460);
            this.Name = "C_ControlManagerForm";
            this.Size = new System.Drawing.Size(400, 460);
            this.Load += new System.EventHandler(this.C_ControlManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).EndInit();
            this.rootPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem statustextCount;
        private DevExpress.XtraGrid.GridControl managerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView managerGridView;
        private System.Windows.Forms.Panel layoutControlPanel;
        private DevExpress.XtraEditors.PanelControl rootPanel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem newButton;
        private DevExpress.XtraBars.BarButtonItem editButton;
        private DevExpress.XtraBars.BarButtonItem deleteButton;
        private DevExpress.XtraBars.BarButtonItem saveButton;
        private DevExpress.XtraBars.BarButtonItem cancelButton;
        private DevExpress.XtraBars.BarButtonItem exitButton;

    }
}
