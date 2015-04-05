namespace KabMan.Forms
{
    partial class SanManagerForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanManagerForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CManagerValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CSanValue = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CDataCenterValue = new DevExpress.XtraEditors.TextEdit();
            this.CSwitchValue = new DevExpress.XtraEditors.TextEdit();
            this.CName = new DevExpress.XtraEditors.TextEdit();
            this.CSanGroup = new KabMan.Controls.C_LookUpControl();
            this.CBlechValue = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CManager = new KabMan.Controls.C_ControlManagerForm();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CManagerValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDataCenterValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBlechValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.CManager.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "Select San Group!";
            // 
            // CSanValue
            // 
            this.CSanValue.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CSanValue.Location = new System.Drawing.Point(100, 69);
            this.CSanValue.Name = "CSanValue";
            this.CSanValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CSanValue.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CSanValue.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CSanValue.Size = new System.Drawing.Size(101, 20);
            this.CSanValue.StyleController = this.layoutControl1;
            this.CSanValue.TabIndex = 10;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Between;
            conditionValidationRule6.ErrorText = "This value is not valid";
            conditionValidationRule6.Value1 = "0";
            conditionValidationRule6.Value2 = "3";
            this.CManagerValidator.SetValidationRule(this.CSanValue, conditionValidationRule6);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSanValue);
            this.layoutControl1.Controls.Add(this.CDataCenterValue);
            this.layoutControl1.Controls.Add(this.CSwitchValue);
            this.layoutControl1.Controls.Add(this.CName);
            this.layoutControl1.Controls.Add(this.CSanGroup);
            this.layoutControl1.Controls.Add(this.CBlechValue);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(412, 130);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CDataCenterValue
            // 
            this.CDataCenterValue.Location = new System.Drawing.Point(307, 100);
            this.CDataCenterValue.Name = "CDataCenterValue";
            this.CDataCenterValue.Properties.MaxLength = 2;
            this.CDataCenterValue.Size = new System.Drawing.Size(99, 20);
            this.CDataCenterValue.StyleController = this.layoutControl1;
            this.CDataCenterValue.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CDataCenterValue, conditionValidationRule1);
            // 
            // CSwitchValue
            // 
            this.CSwitchValue.Location = new System.Drawing.Point(100, 100);
            this.CSwitchValue.Name = "CSwitchValue";
            this.CSwitchValue.Properties.MaxLength = 2;
            this.CSwitchValue.Size = new System.Drawing.Size(103, 20);
            this.CSwitchValue.StyleController = this.layoutControl1;
            this.CSwitchValue.TabIndex = 8;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CSwitchValue, conditionValidationRule2);
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(100, 38);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(306, 20);
            this.CName.StyleController = this.layoutControl1;
            this.CName.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CName, conditionValidationRule3);
            // 
            // CSanGroup
            // 
            this.CSanGroup.AddButtonEnabled = true;
            this.CSanGroup.Columns = this.repositoryItemLookUpEdit1.Columns;
            this.CSanGroup.FormParameters = ((System.Collections.Generic.List<object>)(resources.GetObject("CSanGroup.FormParameters")));
            this.CSanGroup.Location = new System.Drawing.Point(100, 7);
            this.CSanGroup.Name = "CSanGroup";
            this.CSanGroup.NullText = "Select San Group!";
            this.CSanGroup.Parameters = new KabMan.Controls.NameValuePair[0];
            this.CSanGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CSanGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.CSanGroup.Properties.NullText = "Select San Group!";
            this.CSanGroup.RefreshButtonVisible = true;
            this.CSanGroup.Size = new System.Drawing.Size(306, 20);
            this.CSanGroup.StoredProcedure = null;
            this.CSanGroup.StyleController = this.layoutControl1;
            this.CSanGroup.TabIndex = 4;
            this.CSanGroup.TriggerControl = null;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CSanGroup, conditionValidationRule4);
            this.CSanGroup.EditValueChanged += new System.EventHandler(this.CSanGroup_EditValueChanged);
            // 
            // CBlechValue
            // 
            this.CBlechValue.Location = new System.Drawing.Point(305, 69);
            this.CBlechValue.Name = "CBlechValue";
            this.CBlechValue.Properties.MaxLength = 2;
            this.CBlechValue.Size = new System.Drawing.Size(101, 20);
            this.CBlechValue.StyleController = this.layoutControl1;
            this.CBlechValue.TabIndex = 7;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CBlechValue, conditionValidationRule5);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(412, 130);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CSanGroup;
            this.layoutControlItem1.CustomizationFormText = "Group";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(410, 31);
            this.layoutControlItem1.Text = "Group";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CName;
            this.layoutControlItem2.CustomizationFormText = "Name";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(410, 31);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CSwitchValue;
            this.layoutControlItem5.CustomizationFormText = "Switch Value";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(207, 35);
            this.layoutControlItem5.Text = "Switch Value";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CBlechValue;
            this.layoutControlItem4.CustomizationFormText = "Blech Value";
            this.layoutControlItem4.Location = new System.Drawing.Point(205, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(205, 31);
            this.layoutControlItem4.Text = "Blech Value";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CDataCenterValue;
            this.layoutControlItem6.CustomizationFormText = "Data Center Value";
            this.layoutControlItem6.Location = new System.Drawing.Point(207, 93);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(203, 35);
            this.layoutControlItem6.Text = "Data Center Value";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CSanValue;
            this.layoutControlItem3.CustomizationFormText = "SAN Value";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(205, 31);
            this.layoutControlItem3.Text = "SAN Value";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // CManager
            // 
            this.CManager.DeleteProcedure = null;
            this.CManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CManager.InsertProcedure = null;
            this.CManager.IsCancel = true;
            this.CManager.IsEdit = false;
            this.CManager.IsNew = true;
            // 
            // CManager.layoutControlPanel
            // 
            this.CManager.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CManager.LayoutPanel.Controls.Add(this.layoutControl1);
            this.CManager.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CManager.LayoutPanel.MinimumSize = new System.Drawing.Size(400, 20);
            this.CManager.LayoutPanel.Name = "layoutControlPanel";
            this.CManager.LayoutPanel.Size = new System.Drawing.Size(412, 130);
            this.CManager.LayoutPanel.TabIndex = 6;
            this.CManager.Location = new System.Drawing.Point(0, 0);
            this.CManager.MinimumSize = new System.Drawing.Size(400, 460);
            this.CManager.Name = "CManager";
            this.CManager.SelectParameters = null;
            this.CManager.SelectRequiresParameter = true;
            this.CManager.Size = new System.Drawing.Size(412, 466);
            this.CManager.TabIndex = 0;
            this.CManager.UpdateProcedure = null;
            // 
            // SanManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 466);
            this.Controls.Add(this.CManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "SanManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "San Management";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CManagerValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CDataCenterValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSwitchValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSanGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBlechValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.CManager.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private KabMan.Controls.C_ControlManagerForm CManager;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private KabMan.Controls.C_LookUpControl CSanGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit CSwitchValue;
        private DevExpress.XtraEditors.TextEdit CBlechValue;
        private DevExpress.XtraEditors.TextEdit CName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit CDataCenterValue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SpinEdit CSanValue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider CManagerValidator;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}