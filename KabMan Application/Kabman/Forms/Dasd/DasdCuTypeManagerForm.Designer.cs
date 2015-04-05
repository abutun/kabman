namespace KabMan.Forms
{
    partial class DasdCuTypeManagerForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.CManager = new KabMan.Controls.C_ControlManagerForm();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CStartNo = new DevExpress.XtraEditors.SpinEdit();
            this.CPortCount = new DevExpress.XtraEditors.SpinEdit();
            this.CName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CManagerValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CManager.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CStartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPortCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.CManager.LayoutPanel.Size = new System.Drawing.Size(404, 97);
            this.CManager.LayoutPanel.TabIndex = 6;
            this.CManager.Location = new System.Drawing.Point(0, 0);
            this.CManager.MinimumSize = new System.Drawing.Size(400, 460);
            this.CManager.Name = "CManager";
            this.CManager.SelectParameters = null;
            this.CManager.Size = new System.Drawing.Size(404, 462);
            this.CManager.TabIndex = 0;
            this.CManager.UpdateProcedure = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CStartNo);
            this.layoutControl1.Controls.Add(this.CPortCount);
            this.layoutControl1.Controls.Add(this.CName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(404, 97);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CStartNo
            // 
            this.CStartNo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CStartNo.Location = new System.Drawing.Point(64, 69);
            this.CStartNo.Name = "CStartNo";
            this.CStartNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CStartNo.Properties.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CStartNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CStartNo.Size = new System.Drawing.Size(334, 20);
            this.CStartNo.StyleController = this.layoutControl1;
            this.CStartNo.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule1.Value1 = "0";
            this.CManagerValidator.SetValidationRule(this.CStartNo, conditionValidationRule1);
            // 
            // CPortCount
            // 
            this.CPortCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPortCount.Location = new System.Drawing.Point(64, 38);
            this.CPortCount.Name = "CPortCount";
            this.CPortCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CPortCount.Properties.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CPortCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPortCount.Size = new System.Drawing.Size(334, 20);
            this.CPortCount.StyleController = this.layoutControl1;
            this.CPortCount.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule2.Value1 = "0";
            this.CManagerValidator.SetValidationRule(this.CPortCount, conditionValidationRule2);
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(64, 7);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(334, 20);
            this.CName.StyleController = this.layoutControl1;
            this.CName.TabIndex = 4;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CName, conditionValidationRule3);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(404, 97);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CName;
            this.layoutControlItem1.CustomizationFormText = "Name";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(402, 31);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CPortCount;
            this.layoutControlItem2.CustomizationFormText = "Port Count";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(402, 31);
            this.layoutControlItem2.Text = "Port Count";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CStartNo;
            this.layoutControlItem3.CustomizationFormText = "Start No";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(402, 33);
            this.layoutControlItem3.Text = "Start No";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 13);
            // 
            // DasdCuTypeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 462);
            this.Controls.Add(this.CManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "DasdCuTypeManagerForm";
            this.ShowInTaskbar = false;
            this.Text = "Dasd CuType Manager";
            this.CManager.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CStartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPortCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CManagerValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KabMan.Controls.C_ControlManagerForm CManager;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit CStartNo;
        private DevExpress.XtraEditors.SpinEdit CPortCount;
        private DevExpress.XtraEditors.TextEdit CName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider CManagerValidator;
    }
}