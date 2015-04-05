using System;
using System.Windows.Forms;
using KabMan.Controls;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class ActivateReservationForm : DevExpress.XtraEditors.XtraForm
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

        private int _UrmType;
        private int UrmType
        {
            get
            {
                return this._UrmType;
            }
            set
            {
                this._UrmType = value;
            }
        }

        public ActivateReservationForm()
        {
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            InitializeForm();
        }

        public ActivateReservationForm(object argReservationID, object argSanValue, object argUrmType)
        {
            this.ReservationID = (long)argReservationID;
            this.SanValue = (int)argSanValue;
            this.UrmType = (int)argUrmType;
            Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            InitializeForm();
            foreach (NameValuePair nv in CSwitch.Parameters)
            {
                nv.Value = nv.Name == "@SanValue" ? this.SanValue.ToString() : "1";
            }
        }

        private void InitializeForm()
        {
            if (this.UrmType == 7)
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSanGroup.FormToShow = typeof(SanGroupManagerForm);

            CSwitch.StoredProcedure = sproc.Switch_Select_ForConnection;
            CSwitch.FormToShow = typeof(NewSwitchForm);

            //Ahmet BUTUN
            //CURM.Parameters = new NameValuePair[] { new NameValuePair("ModelName", "'%'") };
            CURM.StoredProcedure = sproc.Cable_Select_ByModelName;
            CURM.Columns.Clear();
            CURM.AddColumn("Number", "Select Cable");
            CURM.FormToShow = typeof(CableManagerForm);
        }

        private void NewConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                if (this.UrmType==7)
                {
                    DBAssistant.ExecProcedure
                    (
                        sproc.ConnectionDetail_UpdateForDcc, new object[]
                    {
                        "@ID", this.ReservationID,
	                    "@UrmUrmID", CURM.EditValue,
                        "@UrmType", this.UrmUrmTypeRadio.EditValue,
                        "@UserID", Program.userId
                    }
                    );
                }
                else
                {
                    DBAssistant.ExecProcedure
                    (
                        sproc.ConnectionDetail_Update, new object[]
                    {
                        "@ID", this.ReservationID,
	                    "@UrmUrmID", CURM.EditValue,
                        "@UserID", Program.userId
                    }
                    );
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CURM_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}