namespace KabMan.Forms
{
    partial class BlechTypeManagerForm
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
            this.BlechTypeControlsValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.BlechTypeCManager = new KabMan.Controls.C_ControlManagerForm();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.PortCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.NameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.BlechTypeControlsValidator)).BeginInit();
            this.BlechTypeCManager.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // BlechTypeCManager
            // 
            this.BlechTypeCManager.DeleteProcedure = null;
            this.BlechTypeCManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlechTypeCManager.InsertProcedure = null;
            this.BlechTypeCManager.IsCancel = true;
            this.BlechTypeCManager.IsEdit = false;
            this.BlechTypeCManager.IsNew = true;
            // 
            // BlechTypeCManager.layoutControlPanel
            // 
            this.BlechTypeCManager.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BlechTypeCManager.LayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.BlechTypeCManager.LayoutPanel.Controls.Add(this.layoutControl1);
            this.BlechTypeCManager.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BlechTypeCManager.LayoutPanel.MinimumSize = new System.Drawing.Size(400, 20);
            this.BlechTypeCManager.LayoutPanel.Name = "layoutControlPanel";
            this.BlechTypeCManager.LayoutPanel.Size = new System.Drawing.Size(412, 34);
            this.BlechTypeCManager.LayoutPanel.TabIndex = 6;
            this.BlechTypeCManager.Location = new System.Drawing.Point(0, 0);
            this.BlechTypeCManager.MinimumSize = new System.Drawing.Size(400, 460);
            this.BlechTypeCManager.Name = "BlechTypeCManager";
            this.BlechTypeCManager.SelectParameters = null;
            this.BlechTypeCManager.Size = new System.Drawing.Size(412, 466);
            this.BlechTypeCManager.TabIndex = 0;
            this.BlechTypeCManager.UpdateProcedure = null;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.PortCountSpinEdit);
            this.layoutControl1.Controls.Add(this.NameTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(412, 34);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // PortCountSpinEdit
            // 
            this.PortCountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PortCountSpinEdit.Location = new System.Drawing.Point(315, 7);
            this.PortCountSpinEdit.Name = "PortCountSpinEdit";
            this.PortCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.PortCountSpinEdit.Size = new System.Drawing.Size(91, 20);
            this.PortCountSpinEdit.StyleController = this.layoutControl1;
            this.PortCountSpinEdit.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(64, 7);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 20);
            this.NameTextBox.StyleController = this.layoutControl1;
            this.NameTextBox.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(412, 34);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NameTextBox;
            this.layoutControlItem1.CustomizationFormText = "Name";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 32);
            this.layoutControlItem1.Text = "Name";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.PortCountSpinEdit;
            this.layoutControlItem2.CustomizationFormText = "Port Count";
            this.layoutControlItem2.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(159, 32);
            this.layoutControlItem2.Text = "Port Count";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // BlechTypeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 466);
            this.Controls.Add(this.BlechTypeCManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "BlechTypeManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blech Type Manager";
            ((System.ComponentModel.ISupportInitialize)(this.BlechTypeControlsValidator)).EndInit();
            this.BlechTypeCManager.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PortCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KabMan.Controls.C_ControlManagerForm BlechTypeCManager;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider BlechTypeControlsValidator;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit NameTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit PortCountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}