namespace KabMan.Forms
{
    partial class CableManagerForm
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
            this.CableNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.SymbolSpinEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CableTypeGroup = new DevExpress.XtraEditors.RadioGroup();
            this.btnAddCables = new DevExpress.XtraEditors.SimpleButton();
            this.CableModelLookUp = new KabMan.Controls.C_LookUpCableModel();
            this.CableCategoryLookUp = new KabMan.Controls.C_LookUpCableCategory();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CablePropertiesGridControl = new DevExpress.XtraGrid.GridControl();
            this.CablePropertiesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.StartNoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CablesGridControl = new DevExpress.XtraGrid.GridControl();
            this.CablesGridViewControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CableNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SymbolSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableTypeGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableModelLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableCategoryLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablePropertiesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablePropertiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablesGridViewControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CableNumberEdit);
            this.layoutControl1.Controls.Add(this.SymbolSpinEdit);
            this.layoutControl1.Controls.Add(this.CableTypeGroup);
            this.layoutControl1.Controls.Add(this.btnAddCables);
            this.layoutControl1.Controls.Add(this.CableModelLookUp);
            this.layoutControl1.Controls.Add(this.CableCategoryLookUp);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.CablePropertiesGridControl);
            this.layoutControl1.Controls.Add(this.CountSpinEdit);
            this.layoutControl1.Controls.Add(this.StartNoSpinEdit);
            this.layoutControl1.Controls.Add(this.CablesGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(691, 512);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CableNumberEdit
            // 
            this.CableNumberEdit.Location = new System.Drawing.Point(87, 198);
            this.CableNumberEdit.Name = "CableNumberEdit";
            this.CableNumberEdit.Properties.MaxLength = 5;
            this.CableNumberEdit.Size = new System.Drawing.Size(306, 20);
            this.CableNumberEdit.StyleController = this.layoutControl1;
            this.CableNumberEdit.TabIndex = 19;
            // 
            // SymbolSpinEdit
            // 
            this.SymbolSpinEdit.Location = new System.Drawing.Point(87, 167);
            this.SymbolSpinEdit.Name = "SymbolSpinEdit";
            this.SymbolSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SymbolSpinEdit.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "Y",
            "Z"});
            this.SymbolSpinEdit.Properties.NullText = "Select Cable Symbol!";
            this.SymbolSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.SymbolSpinEdit.Size = new System.Drawing.Size(306, 20);
            this.SymbolSpinEdit.StyleController = this.layoutControl1;
            this.SymbolSpinEdit.TabIndex = 18;
            // 
            // CableTypeGroup
            // 
            this.CableTypeGroup.EditValue = 2;
            this.CableTypeGroup.Location = new System.Drawing.Point(87, 7);
            this.CableTypeGroup.Margin = new System.Windows.Forms.Padding(0);
            this.CableTypeGroup.MaximumSize = new System.Drawing.Size(306, 25);
            this.CableTypeGroup.MinimumSize = new System.Drawing.Size(306, 25);
            this.CableTypeGroup.Name = "CableTypeGroup";
            this.CableTypeGroup.Properties.Columns = 2;
            this.CableTypeGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Single"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Multiple")});
            this.CableTypeGroup.Size = new System.Drawing.Size(306, 25);
            this.CableTypeGroup.StyleController = this.layoutControl1;
            this.CableTypeGroup.TabIndex = 17;
            this.CableTypeGroup.SelectedIndexChanged += new System.EventHandler(this.CableTypeGroup_SelectedIndexChanged);
            // 
            // btnAddCables
            // 
            this.btnAddCables.Location = new System.Drawing.Point(313, 229);
            this.btnAddCables.Name = "btnAddCables";
            this.btnAddCables.Size = new System.Drawing.Size(80, 22);
            this.btnAddCables.StyleController = this.layoutControl1;
            this.btnAddCables.TabIndex = 16;
            this.btnAddCables.Text = "Add Cables";
            this.btnAddCables.Click += new System.EventHandler(this.btnAddCables_Click);
            // 
            // CableModelLookUp
            // 
            this.CableModelLookUp.Location = new System.Drawing.Point(87, 74);
            this.CableModelLookUp.Name = "CableModelLookUp";
            this.CableModelLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "", "Add")});
            this.CableModelLookUp.Properties.NullText = "Select Cable Model!";
            this.CableModelLookUp.Size = new System.Drawing.Size(306, 20);
            this.CableModelLookUp.StyleController = this.layoutControl1;
            this.CableModelLookUp.TabIndex = 14;
            this.CableModelLookUp.TriggerLookUpEdit = this.CableCategoryLookUp;
            this.CableModelLookUp.EditValueChanged += new System.EventHandler(this.CableModelLookUp_EditValueChanged);
            // 
            // CableCategoryLookUp
            // 
            this.CableCategoryLookUp.AddButtonEnabled = true;
            this.CableCategoryLookUp.Location = new System.Drawing.Point(87, 43);
            this.CableCategoryLookUp.Name = "CableCategoryLookUp";
            this.CableCategoryLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CableCategoryLookUp.Properties.DisplayMember = "Name";
            this.CableCategoryLookUp.Properties.NullText = "Select Cable Category!";
            this.CableCategoryLookUp.Properties.ValueMember = "ID";
            this.CableCategoryLookUp.Size = new System.Drawing.Size(306, 20);
            this.CableCategoryLookUp.StyleController = this.layoutControl1;
            this.CableCategoryLookUp.TabIndex = 13;
            this.CableCategoryLookUp.EditValueChanged += new System.EventHandler(this.CableCategoryLookUp_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(404, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(281, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Additional Properties";
            // 
            // CablePropertiesGridControl
            // 
            this.CablePropertiesGridControl.Location = new System.Drawing.Point(404, 31);
            this.CablePropertiesGridControl.MainView = this.CablePropertiesGridView;
            this.CablePropertiesGridControl.Name = "CablePropertiesGridControl";
            this.CablePropertiesGridControl.Size = new System.Drawing.Size(281, 220);
            this.CablePropertiesGridControl.TabIndex = 10;
            this.CablePropertiesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CablePropertiesGridView});
            // 
            // CablePropertiesGridView
            // 
            this.CablePropertiesGridView.GridControl = this.CablePropertiesGridControl;
            this.CablePropertiesGridView.Name = "CablePropertiesGridView";
            this.CablePropertiesGridView.OptionsBehavior.Editable = false;
            this.CablePropertiesGridView.OptionsView.ShowGroupPanel = false;
            this.CablePropertiesGridView.OptionsView.ShowIndicator = false;
            // 
            // CountSpinEdit
            // 
            this.CountSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountSpinEdit.Location = new System.Drawing.Point(87, 136);
            this.CountSpinEdit.Name = "CountSpinEdit";
            this.CountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CountSpinEdit.Properties.MaxValue = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.CountSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountSpinEdit.Size = new System.Drawing.Size(306, 20);
            this.CountSpinEdit.StyleController = this.layoutControl1;
            this.CountSpinEdit.TabIndex = 7;
            // 
            // StartNoSpinEdit
            // 
            this.StartNoSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNoSpinEdit.Location = new System.Drawing.Point(87, 105);
            this.StartNoSpinEdit.Name = "StartNoSpinEdit";
            this.StartNoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StartNoSpinEdit.Properties.MaxValue = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.StartNoSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNoSpinEdit.Size = new System.Drawing.Size(306, 20);
            this.StartNoSpinEdit.StyleController = this.layoutControl1;
            this.StartNoSpinEdit.TabIndex = 6;
            // 
            // CablesGridControl
            // 
            this.CablesGridControl.Location = new System.Drawing.Point(7, 262);
            this.CablesGridControl.MainView = this.CablesGridViewControl;
            this.CablesGridControl.Name = "CablesGridControl";
            this.CablesGridControl.Size = new System.Drawing.Size(678, 244);
            this.CablesGridControl.TabIndex = 8;
            this.CablesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CablesGridViewControl});
            // 
            // CablesGridViewControl
            // 
            this.CablesGridViewControl.GridControl = this.CablesGridControl;
            this.CablesGridViewControl.Name = "CablesGridViewControl";
            this.CablesGridViewControl.OptionsBehavior.AllowIncrementalSearch = true;
            this.CablesGridViewControl.OptionsBehavior.Editable = false;
            this.CablesGridViewControl.OptionsCustomization.AllowFilter = false;
            this.CablesGridViewControl.OptionsView.EnableAppearanceEvenRow = true;
            this.CablesGridViewControl.OptionsView.EnableAppearanceOddRow = true;
            this.CablesGridViewControl.OptionsView.ShowGroupPanel = false;
            this.CablesGridViewControl.OptionsView.ShowIndicator = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(691, 512);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CablesGridControl;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 255);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(689, 255);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.StartNoSpinEdit;
            this.layoutControlItem3.CustomizationFormText = "Start No";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Start No";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CountSpinEdit;
            this.layoutControlItem4.CustomizationFormText = "Count";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Count";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.CablePropertiesGridControl;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(397, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(292, 231);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelControl1;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(397, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(292, 24);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CableCategoryLookUp;
            this.layoutControlItem1.CustomizationFormText = "Cable Category";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Cable Category";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CableModelLookUp;
            this.layoutControlItem2.CustomizationFormText = "Cable Model";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 67);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(397, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Cable Model";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAddCables;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(306, 222);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(91, 33);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(91, 33);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(91, 33);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 222);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(306, 33);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.CableTypeGroup;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(397, 36);
            this.layoutControlItem10.Text = "Type";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.CableNumberEdit;
            this.layoutControlItem11.CustomizationFormText = "Number";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem11.Text = "Number";
            this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(75, 13);
            this.layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.SymbolSpinEdit;
            this.layoutControlItem9.CustomizationFormText = "Symbol";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(397, 31);
            this.layoutControlItem9.Text = "Symbol";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(75, 13);
            // 
            // CableManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 512);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CableManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cable Management";
            this.Load += new System.EventHandler(this.CableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CableNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SymbolSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableTypeGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableModelLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CableCategoryLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablePropertiesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablePropertiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CablesGridViewControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SpinEdit StartNoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit CountSpinEdit;
        private DevExpress.XtraGrid.GridControl CablesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CablesGridViewControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl CablePropertiesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CablePropertiesGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private KabMan.Controls.C_LookUpCableModel CableModelLookUp;
        private KabMan.Controls.C_LookUpCableCategory CableCategoryLookUp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnAddCables;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.RadioGroup CableTypeGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.ComboBoxEdit SymbolSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit CableNumberEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}