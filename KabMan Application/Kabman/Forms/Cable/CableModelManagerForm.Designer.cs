namespace KabMan.Forms
{
    partial class CableModelManagerForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.CManager = new KabMan.Controls.C_ControlManagerForm();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CSample = new DevExpress.XtraEditors.PictureEdit();
            this.CCategory = new KabMan.Controls.C_LookUpCableCategory();
            this.CLineCount = new DevExpress.XtraEditors.SpinEdit();
            this.CCableCount = new DevExpress.XtraEditors.SpinEdit();
            this.CLength = new DevExpress.XtraEditors.SpinEdit();
            this.CModel = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CManagerValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CManager.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLineCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCableCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CManagerValidator)).BeginInit();
            this.SuspendLayout();
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
            this.CManager.LayoutPanel.Size = new System.Drawing.Size(497, 162);
            this.CManager.LayoutPanel.TabIndex = 6;
            this.CManager.Location = new System.Drawing.Point(0, 0);
            this.CManager.MinimumSize = new System.Drawing.Size(400, 460);
            this.CManager.Name = "CManager";
            this.CManager.SelectParameters = null;
            this.CManager.SelectRequiresParameter = true;
            this.CManager.Size = new System.Drawing.Size(497, 531);
            this.CManager.TabIndex = 0;
            this.CManager.UpdateProcedure = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CSample);
            this.layoutControl1.Controls.Add(this.CCategory);
            this.layoutControl1.Controls.Add(this.CLineCount);
            this.layoutControl1.Controls.Add(this.CCableCount);
            this.layoutControl1.Controls.Add(this.CLength);
            this.layoutControl1.Controls.Add(this.CModel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(497, 162);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CSample
            // 
            this.CSample.Location = new System.Drawing.Point(334, 7);
            this.CSample.Name = "CSample";
            this.CSample.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.CSample.Size = new System.Drawing.Size(157, 149);
            this.CSample.StyleController = this.layoutControl1;
            this.CSample.TabIndex = 11;
            // 
            // CCategory
            // 
            this.CCategory.AddButtonEnabled = true;
            this.CCategory.Location = new System.Drawing.Point(125, 7);
            this.CCategory.Name = "CCategory";
            this.CCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("Refresh", DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton("Add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.CCategory.Properties.DisplayMember = "Name";
            this.CCategory.Properties.NullText = "Select Cable Category!";
            this.CCategory.Properties.ValueMember = "ID";
            this.CCategory.Size = new System.Drawing.Size(198, 20);
            this.CCategory.StyleController = this.layoutControl1;
            this.CCategory.TabIndex = 10;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CCategory, conditionValidationRule1);
            this.CCategory.EditValueChanged += new System.EventHandler(this.CCategory_EditValueChanged);
            // 
            // CLineCount
            // 
            this.CLineCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CLineCount.Location = new System.Drawing.Point(125, 131);
            this.CLineCount.Name = "CLineCount";
            this.CLineCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CLineCount.Size = new System.Drawing.Size(198, 20);
            this.CLineCount.StyleController = this.layoutControl1;
            this.CLineCount.TabIndex = 7;
            // 
            // CCableCount
            // 
            this.CCableCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CCableCount.Location = new System.Drawing.Point(125, 100);
            this.CCableCount.Name = "CCableCount";
            this.CCableCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CCableCount.Size = new System.Drawing.Size(198, 20);
            this.CCableCount.StyleController = this.layoutControl1;
            this.CCableCount.TabIndex = 6;
            // 
            // CLength
            // 
            this.CLength.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CLength.Location = new System.Drawing.Point(125, 69);
            this.CLength.Name = "CLength";
            this.CLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CLength.Size = new System.Drawing.Size(198, 20);
            this.CLength.StyleController = this.layoutControl1;
            this.CLength.TabIndex = 5;
            // 
            // CModel
            // 
            this.CModel.Location = new System.Drawing.Point(125, 38);
            this.CModel.Name = "CModel";
            this.CModel.Size = new System.Drawing.Size(198, 20);
            this.CModel.StyleController = this.layoutControl1;
            this.CModel.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CModel, conditionValidationRule2);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(497, 162);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CModel;
            this.layoutControlItem1.CustomizationFormText = "Cable Model";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(327, 31);
            this.layoutControlItem1.Text = "Cable Model";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(113, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CLength;
            this.layoutControlItem2.CustomizationFormText = "Length";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(327, 31);
            this.layoutControlItem2.Text = "Length";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(113, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CCableCount;
            this.layoutControlItem3.CustomizationFormText = "Cable Count in Package";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(327, 31);
            this.layoutControlItem3.Text = "Cable Count in Package";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(113, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CLineCount;
            this.layoutControlItem4.CustomizationFormText = "Line Count per Cable";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(327, 36);
            this.layoutControlItem4.Text = "Line Count per Cable";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(113, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.CCategory;
            this.layoutControlItem10.CustomizationFormText = "Category";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(327, 31);
            this.layoutControlItem10.Text = "Category";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(113, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CSample;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(327, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(168, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(168, 31);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(168, 160);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // CableModelManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 531);
            this.Controls.Add(this.CManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "CableModelManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cable Model Management";
            this.CManager.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLineCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCableCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CManagerValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KabMan.Controls.C_ControlManagerForm CManager;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit CModel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit CLineCount;
        private DevExpress.XtraEditors.SpinEdit CCableCount;
        private DevExpress.XtraEditors.SpinEdit CLength;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private KabMan.Controls.C_LookUpCableCategory CCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider CManagerValidator;
        private DevExpress.XtraEditors.PictureEdit CSample;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}