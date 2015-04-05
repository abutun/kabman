using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;
using KabMan.Controls;

namespace KabMan.Forms.Connection
{
    public partial class NewConnectionName : DevExpress.XtraEditors.XtraForm
    {
        public NewConnectionName()
        {
            InitializeComponent();
            InitializeForm(); 
        }

        private void InitializeForm()
        {
            CDeviceType.StoredProcedure = sproc.Device_Select_ByCondition1;
            CDeviceType.FormToShow = typeof(DeviceManagerForm);
            //CDataCenter.StoredProcedureName = sproc.DataCenter_Select_ByLocationID;
            //CDataCenter.FormToShow = typeof(DataCenterManagerForm);
        }
        //private void CDeviceType_EditValueChanged(object sender, EventArgs e)
        //{
        //    switch (CDeviceType.GetColumnValue("Name").ToString())
        //    {
        //        case "Tape":

        //            /// Tape

        //            break;
        //        case "Server":

        //            //CDevice.FormToShow = typeof(NewRackForm);

        //            break;
        //        case "DASD":

        //            /// DASD

        //            break;
        //    }
        //}        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CManagerValidator.Validate())
            {
                DBAssistant.ExecProcedure
                     (
                         sproc.Connection_Insert, new object[] 
	                    { 
	                        "@DeviceID", CDeviceType.EditValue,
	                        "@ConnectionName", CName.EditValue,
	                        "@projectName", CProject.EditValue,
	                        "@Customer", CCostumer.EditValue,
                            "@UserID", Program.userId
	                    }
                     );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CDeviceType_EditValueChanged(object sender, EventArgs e)
        {

        }     
    }    
}