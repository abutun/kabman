namespace KabMan.Forms
{
    partial class SwitchDetailManagerForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CSwitchGrid = new DevExpress.XtraGrid.GridControl();
            this.CSwitchView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLcUrm = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSwitchGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(828, 511);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CSwitchGrid
            // 
            this.CSwitchGrid.Location = new System.Drawing.Point(7, 7);
            this.CSwitchGrid.MainView = this.CSwitchView;
            this.CSwitchGrid.Name = "CSwitchGrid";
            this.CSwitchGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLcUrm});
            this.CSwitchGrid.Size = new System.Drawing.Size(815, 498);
            this.CSwitchGrid.TabIndex = 4;
            this.CSwitchGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CSwitchView,
            this.gridView2});
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
            this.CSwitchView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn11,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.CSwitchView.GridControl = this.CSwitchGrid;
            this.CSwitchView.Name = "CSwitchView";
            this.CSwitchView.OptionsView.EnableAppearanceEvenRow = true;
            this.CSwitchView.OptionsView.EnableAppearanceOddRow = true;
            this.CSwitchView.OptionsView.ShowAutoFilterRow = true;
            this.CSwitchView.OptionsView.ShowGroupPanel = false;
            this.CSwitchView.OptionsView.ShowIndicator = false;
            this.CSwitchView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CSwitchView_CellValueChanged);
            this.CSwitchView.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.CSwitchView_BeforeLeaveRow);
            this.CSwitchView.ColumnWidthChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.CSwitchView_ColumnWidthChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Switch Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Port";
            this.gridColumn2.FieldName = "PortNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "LC URM";
            this.gridColumn3.FieldName = "LcUrm";
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
            this.gridColumn4.Caption = "Blech";
            this.gridColumn4.FieldName = "Blech";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Trunk";
            this.gridColumn5.FieldName = "Trunk";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "VTPort";
            this.gridColumn6.FieldName = "VTPort";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "URM URM";
            this.gridColumn7.FieldName = "UrmUrm";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Target";
            this.gridColumn8.FieldName = "Target";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Available";
            this.gridColumn9.FieldName = "Available";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "Connected";
            this.gridColumn11.FieldName = "Connected";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "Reserved";
            this.gridColumn10.FieldName = "Reserved";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "gridColumn12";
            this.gridColumn12.FieldName = "ID";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "gridColumn13";
            this.gridColumn13.FieldName = "LcUrm_ID";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "gridColumn14";
            this.gridColumn14.FieldName = "UrmUrm_ID";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.Caption = "pWWN";
            this.gridColumn15.FieldName = "pWWN";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 11;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.Caption = "Status";
            this.gridColumn16.FieldName = "PortStateTitle";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 12;
            // 
            // repLcUrm
            // 
            this.repLcUrm.AutoHeight = false;
            this.repLcUrm.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLcUrm.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Connected", "Connected", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Number")});
            this.repLcUrm.DisplayMember = "Number";
            this.repLcUrm.Name = "repLcUrm";
            this.repLcUrm.NullText = "";
            this.repLcUrm.ValueMember = "ID";
            this.repLcUrm.Popup += new System.EventHandler(this.repLcUrm_Popup);
            this.repLcUrm.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repLcUrm_Closed);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.CSwitchGrid;
            this.gridView2.Name = "gridView2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(828, 511);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(826, 509);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // SwitchDetailManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 511);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SwitchDetailManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SwitchDetailManagerForm";
            this.Load += new System.EventHandler(this.SwitchDetailManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl CSwitchGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CSwitchView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLcUrm;

    }
}