namespace KabMan.Forms
{
    partial class CableCategoryManagerForm
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
            this.CManager = new KabMan.Controls.C_ControlManagerForm();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CMustUnique = new DevExpress.XtraEditors.CheckEdit();
            this.CHasClass = new DevExpress.XtraEditors.CheckEdit();
            this.CName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CManagerValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CManager.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMustUnique.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHasClass.Properties)).BeginInit();
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
            this.CManager.LayoutPanel.Size = new System.Drawing.Size(412, 65);
            this.CManager.LayoutPanel.TabIndex = 6;
            this.CManager.Location = new System.Drawing.Point(0, 0);
            this.CManager.MinimumSize = new System.Drawing.Size(400, 460);
            this.CManager.Name = "CManager";
            this.CManager.SelectParameters = null;
            this.CManager.Size = new System.Drawing.Size(412, 466);
            this.CManager.TabIndex = 0;
            this.CManager.UpdateProcedure = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.CMustUnique);
            this.layoutControl1.Controls.Add(this.CHasClass);
            this.layoutControl1.Controls.Add(this.CName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(412, 65);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CMustUnique
            // 
            this.CMustUnique.Location = new System.Drawing.Point(212, 38);
            this.CMustUnique.Name = "CMustUnique";
            this.CMustUnique.Properties.Caption = "Is Unique Group";
            this.CMustUnique.Size = new System.Drawing.Size(194, 19);
            this.CMustUnique.StyleController = this.layoutControl1;
            this.CMustUnique.TabIndex = 6;
            // 
            // CHasClass
            // 
            this.CHasClass.Location = new System.Drawing.Point(7, 38);
            this.CHasClass.Name = "CHasClass";
            this.CHasClass.Properties.Caption = "Has Class";
            this.CHasClass.Size = new System.Drawing.Size(194, 19);
            this.CHasClass.StyleController = this.layoutControl1;
            this.CHasClass.TabIndex = 5;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(39, 7);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(367, 20);
            this.CName.StyleController = this.layoutControl1;
            this.CName.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.CManagerValidator.SetValidationRule(this.CName, conditionValidationRule1);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(412, 65);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(410, 31);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CHasClass;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 32);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CMustUnique;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(205, 31);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(205, 32);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // CableCategoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 466);
            this.Controls.Add(this.CManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "CableCategoryManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cable Category Management";
            this.Load += new System.EventHandler(this.CableCategoryManagerForm_Load);
            this.CManager.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CMustUnique.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHasClass.Properties)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider CManagerValidator;
        private DevExpress.XtraEditors.CheckEdit CMustUnique;
        private DevExpress.XtraEditors.CheckEdit CHasClass;
        private DevExpress.XtraEditors.TextEdit CName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}