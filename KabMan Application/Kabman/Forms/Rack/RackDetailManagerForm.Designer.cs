namespace KabMan.Forms
{
    partial class RackDetailManagerForm
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
            this.CSan2Grid = new DevExpress.XtraGrid.GridControl();
            this.CSan2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLcUrmSan2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBlechSan2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repVtPortSan2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CSan1Grid = new DevExpress.XtraGrid.GridControl();
            this.CSan1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBlechSan1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLcUrmSan1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repVtPortSan1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSan2Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrmSan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBlechSan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVtPortSan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBlechSan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrmSan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVtPortSan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSan2Grid);
            this.layoutControl1.Controls.Add(this.CSan1Grid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(814, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CSan2Grid
            // 
            this.CSan2Grid.Location = new System.Drawing.Point(7, 269);
            this.CSan2Grid.MainView = this.CSan2View;
            this.CSan2Grid.Name = "CSan2Grid";
            this.CSan2Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLcUrmSan2,
            this.repVtPortSan2,
            this.repBlechSan2});
            this.CSan2Grid.Size = new System.Drawing.Size(801, 251);
            this.CSan2Grid.TabIndex = 5;
            this.CSan2Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CSan2View});
            // 
            // CSan2View
            // 
            this.CSan2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn17,
            this.gridColumn18});
            this.CSan2View.GridControl = this.CSan2Grid;
            this.CSan2View.Name = "CSan2View";
            this.CSan2View.OptionsView.ShowAutoFilterRow = true;
            this.CSan2View.OptionsView.ShowGroupPanel = false;
            this.CSan2View.OptionsView.ShowIndicator = false;
            this.CSan2View.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CSan2View_CellValueChanged);
            this.CSan2View.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.CSan2View_ShowingEditor);
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "ID";
            this.gridColumn19.FieldName = "ID";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Server Name";
            this.gridColumn8.FieldName = "Name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "LC URM";
            this.gridColumn9.ColumnEdit = this.repLcUrmSan2;
            this.gridColumn9.FieldName = "LcUrmCableID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // repLcUrmSan2
            // 
            this.repLcUrmSan2.AutoHeight = false;
            this.repLcUrmSan2.AutoSearchColumnIndex = 1;
            this.repLcUrmSan2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLcUrmSan2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Number"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Connected", "Connected")});
            this.repLcUrmSan2.DisplayMember = "Number";
            this.repLcUrmSan2.Name = "repLcUrmSan2";
            this.repLcUrmSan2.NullText = "";
            this.repLcUrmSan2.PopupWidth = 250;
            this.repLcUrmSan2.ValueMember = "ID";
            this.repLcUrmSan2.Popup += new System.EventHandler(this.repLcUrmSan2_Popup);
            this.repLcUrmSan2.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repLcUrmSan2_Closed);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Blech";
            this.gridColumn10.ColumnEdit = this.repBlechSan2;
            this.gridColumn10.FieldName = "BlechDetailId";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // repBlechSan2
            // 
            this.repBlechSan2.AutoHeight = false;
            this.repBlechSan2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repBlechSan2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechDetailId", "Blech Detail Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechId", "Blech Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechName", "Blech"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Connected", "Connected", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.repBlechSan2.DisplayMember = "BlechName";
            this.repBlechSan2.Name = "repBlechSan2";
            this.repBlechSan2.NullText = "";
            this.repBlechSan2.ValueMember = "BlechDetailId";
            this.repBlechSan2.Popup += new System.EventHandler(this.repBlechSan2_Popup);
            this.repBlechSan2.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repBlechSan2_Closed);
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Trunk Cable";
            this.gridColumn11.FieldName = "TrunkCable";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "VT Port";
            this.gridColumn12.ColumnEdit = this.repVtPortSan2;
            this.gridColumn12.FieldName = "VTPortDetailId";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // repVtPortSan2
            // 
            this.repVtPortSan2.AutoHeight = false;
            this.repVtPortSan2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repVtPortSan2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VTPortDetailId", "VTPortDetailId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VTPort", "VTPort")});
            this.repVtPortSan2.DisplayMember = "VTPort";
            this.repVtPortSan2.Name = "repVtPortSan2";
            this.repVtPortSan2.NullText = "";
            this.repVtPortSan2.ValueMember = "VTPortDetailId";
            this.repVtPortSan2.Popup += new System.EventHandler(this.repVtPortSan2_Popup);
            this.repVtPortSan2.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repVtPortSan2_Closed);
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "URM URM";
            this.gridColumn13.FieldName = "UrmUrmCable";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Line Available";
            this.gridColumn14.FieldName = "Available";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Reserved";
            this.gridColumn17.FieldName = "Reserved";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 7;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Connected";
            this.gridColumn18.FieldName = "Connected";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 8;
            // 
            // CSan1Grid
            // 
            this.CSan1Grid.Location = new System.Drawing.Point(7, 7);
            this.CSan1Grid.MainView = this.CSan1View;
            this.CSan1Grid.Name = "CSan1Grid";
            this.CSan1Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLcUrmSan1,
            this.repVtPortSan1,
            this.repBlechSan1});
            this.CSan1Grid.Size = new System.Drawing.Size(801, 251);
            this.CSan1Grid.TabIndex = 4;
            this.CSan1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CSan1View,
            this.gridView2});
            // 
            // CSan1View
            // 
            this.CSan1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn21,
            this.gridColumn22});
            this.CSan1View.GridControl = this.CSan1Grid;
            this.CSan1View.Name = "CSan1View";
            this.CSan1View.OptionsView.ShowAutoFilterRow = true;
            this.CSan1View.OptionsView.ShowGroupPanel = false;
            this.CSan1View.OptionsView.ShowIndicator = false;
            this.CSan1View.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CSan1View_CellValueChanged);
            this.CSan1View.ShownEditor += new System.EventHandler(this.CSan1View_ShownEditor);
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "ID";
            this.gridColumn20.FieldName = "ID";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Server Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Blech";
            this.gridColumn7.ColumnEdit = this.repBlechSan1;
            this.gridColumn7.FieldName = "BlechDetailId";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // repBlechSan1
            // 
            this.repBlechSan1.AutoHeight = false;
            this.repBlechSan1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repBlechSan1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechName", "Blech"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechDetailId", "Detail Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlechId", "Blech Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Connected", "Connected", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.repBlechSan1.DisplayMember = "BlechName";
            this.repBlechSan1.Name = "repBlechSan1";
            this.repBlechSan1.NullText = "";
            this.repBlechSan1.ValueMember = "BlechDetailId";
            this.repBlechSan1.Popup += new System.EventHandler(this.repBlechSan1_Popup);
            this.repBlechSan1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repBlechSan1_Closed);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "LC URM";
            this.gridColumn2.ColumnEdit = this.repLcUrmSan1;
            this.gridColumn2.FieldName = "LcUrmCableID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repLcUrmSan1
            // 
            this.repLcUrmSan1.AutoHeight = false;
            this.repLcUrmSan1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLcUrmSan1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Number"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Connected", "Connected")});
            this.repLcUrmSan1.DisplayMember = "Number";
            this.repLcUrmSan1.Name = "repLcUrmSan1";
            this.repLcUrmSan1.NullText = "";
            this.repLcUrmSan1.PopupWidth = 250;
            this.repLcUrmSan1.ValueMember = "ID";
            this.repLcUrmSan1.Popup += new System.EventHandler(this.repLcUrmSan1_Popup);
            this.repLcUrmSan1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repLcUrmSan1_Closed);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trunk Cable";
            this.gridColumn3.FieldName = "TrunkCable";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "VT Port";
            this.gridColumn4.ColumnEdit = this.repVtPortSan1;
            this.gridColumn4.FieldName = "VTPortDetailId";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // repVtPortSan1
            // 
            this.repVtPortSan1.AutoHeight = false;
            this.repVtPortSan1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repVtPortSan1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VTPortId", "VTPortId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VTPort", "VTPort")});
            this.repVtPortSan1.DisplayMember = "VTPort";
            this.repVtPortSan1.Name = "repVtPortSan1";
            this.repVtPortSan1.NullText = "";
            this.repVtPortSan1.ValueMember = "VTPortDetailId";
            this.repVtPortSan1.Popup += new System.EventHandler(this.repVtPortSan1_Popup);
            this.repVtPortSan1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repVtPortSan1_Closed);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "URM URM";
            this.gridColumn5.FieldName = "UrmUrmCable";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Line Available";
            this.gridColumn6.FieldName = "Available";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Reserved";
            this.gridColumn15.FieldName = "Reserved";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Connected";
            this.gridColumn16.FieldName = "Connected";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 8;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "VTPort Id";
            this.gridColumn21.FieldName = "VTPortId";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Blech Id";
            this.gridColumn22.FieldName = "BlechId";
            this.gridColumn22.Name = "gridColumn22";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.CSan1Grid;
            this.gridView2.Name = "gridView2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 526);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CSan1Grid;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(812, 262);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CSan2Grid;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 262);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(812, 262);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // RackDetailManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RackDetailManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rack Manager Detail";
            this.Load += new System.EventHandler(this.RackDetailManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSan2Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrmSan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBlechSan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVtPortSan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSan1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBlechSan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLcUrmSan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVtPortSan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl CSan2Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView CSan2View;
        private DevExpress.XtraGrid.GridControl CSan1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView CSan1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLcUrmSan2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLcUrmSan1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repVtPortSan1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repVtPortSan2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repBlechSan1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repBlechSan2;

    }
}