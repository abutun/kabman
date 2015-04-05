using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Controls;
using KabMan.Data;

namespace KabMan.Forms.Connection
{
    public partial class SwitchDetailUpdateForm : DevExpress.XtraEditors.XtraForm
    {
        private long _ReservationID;
        private long ReservationID
        {
            get
            {
                return this._ReservationID;
            }
            set
            {
                this._ReservationID = value;
            }
        }

        private int _SanValue;
        private int SanValue
        {
            get
            {
                return this._SanValue;
            }
            set
            {
                this._SanValue = value;
            }
        }

        public SwitchDetailUpdateForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            InitializeForm();
        }

        public SwitchDetailUpdateForm(object argReservationID, object argSanValue)
        {
            this.ReservationID = (long)argReservationID;
            this.SanValue = (int)argSanValue;
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                DBAssistant.ExecProcedure
                    (
                        sproc.ConnectionDetail_Update_SwitchDetail, new object[]
                                        {
                                            "@ID", this.ReservationID,
	                                        "@SwitchDetailID", CSwitchDetail.EditValue,
                                            "@UserID", Program.userId
                                        }
                    );

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void c_LookUpControl2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.CSwitch.Parameters = new NameValuePair[] { new NameValuePair("SunGroupID", this.CSanGroup.EditValue.ToString()) };
                this.CSwitch.StoredProcedure = sproc.Switch_SelectBySunGroup;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CSwitch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.CSwitchDetail.Parameters = new NameValuePair[] { new NameValuePair("SwitchID", this.CSwitch.EditValue.ToString()) };
                this.CSwitchDetail.StoredProcedure = sproc.SwitchDetail_Select_BySwitchID_Specific;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}