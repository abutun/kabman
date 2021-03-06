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
using KabMan.Windows;
using System.Drawing.Printing;
using KabMan.XtraReports;
using KabMan.Forms.Connection;
using System.Diagnostics;
using DevExpress.XtraLayout.Utils;

namespace KabMan.Forms
{
    public partial class NewConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        private int HeightDifference1 = 140;
        private int HeightDifference2 = 170;

        public NewConnectionForm()
        {
            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
            InitializeForm();            
        }    
        private void InitializeForm()
        {
            cConnection.StoredProcedure = sproc.Connection_Select_All;
            cConnection.FormToShow = typeof(NewConnectionName);
            cConnection.Columns.Clear();
            cConnection.AddColumn("ConnectionName", "Name");
            CSwitchType.StoredProcedure = sproc.SwitchType_Select_All;
            CSwitchType.FormToShow = typeof(SwitchTypeManagerForm);
            CSwitchType.Columns.Clear();
            CSwitchType.AddColumn("Name", "Select Switch Type");
           
            CSanGroup.StoredProcedure = sproc.SanGroup_Select_All;
            CSanGroup.FormToShow = typeof(SanGroupManagerForm);
            CSanGroup.Columns.Clear();
            CSanGroup.AddColumn("Name", "Select San Group");

            CDeviceType.StoredProcedure = sproc.Device_Select_ByCondition1;
            CDeviceType.FormToShow = typeof(DeviceManagerForm);
            CDeviceType.Columns.Clear();
            CDeviceType.AddColumn("Name", "Select Device");        
        }

        private void NewConnectionForm_Load(object sender, EventArgs e)
        {
            newConnectionControlGroup.Visibility = LayoutVisibility.Never;
            this.Size = new Size(this.Size.Width, this.Size.Height - HeightDifference1);
            DccDevice.Enabled = false;
        }

        private void CLocation_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                object oDataCenterID = CLocation.GetColumnValue("DataCenterID");
                if (oDataCenterID == null || (Int64)oDataCenterID == 0)
                {
                    CDataCenter.FormParameters.Clear();
                    string LocationId = CLocation.GetColumnValue("ID").ToString();
                    CDataCenter.Parameters = new NameValuePair[] { new NameValuePair("LocationID", LocationId) };
                    CDataCenter.StoredProcedure = sproc.DataCenter_Select_ByLocationID;
                    return;
                }


                CDataCenter.FormParameters.Clear();
                CDataCenter.Columns.Clear();
                CDataCenter.AddColumn("Name", "Select Data Center");
                CDataCenter.FormParameters.Add(CLocation.EditValue);

                string DataCenterID = CLocation.GetColumnValue("DataCenterID").ToString();
                CDataCenter.Parameters = new NameValuePair[] { new NameValuePair("DataCenterID", DataCenterID) };

                CDataCenter.StoredProcedure = sproc.DataCenter_Select_ByDataCenterID;

                CDataCenter.FormToShow = typeof(DataCenterManagerForm);
                CDataCenter.ItemIndex = 0;
                CDataCenter_EditValueChanged(e, new EventArgs());
            }
            catch
            {
                //NOP
            }
        }

        private void CDeviceType_EditValueChanged(object sender, EventArgs e)
        {
            DccDeviceforType.Enabled = false;
            DccDevice.Enabled = false;
            
            switch (CDeviceType.GetColumnValue("Name").ToString())
            {
                case "Tape":

                    /// Tape

                    break;
                case "Server":

                    CDevice.FormToShow = typeof(NewRackForm);

                    try
                    {
                        CDevice.FormParameters.Clear();
                        //CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", DccDeviceforType.EditValue.ToString()), new NameValuePair("DataCenterID", CDataCenter.EditValue.ToString()) };
                        CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", "2"), new NameValuePair("DataCenterID", "0") };
                        CDevice.StoredProcedure = sproc.Server_Select_All_By_Device_Type;
                    }
                    catch (Exception ex)
                    {
                        //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case "DASD":

                    try
                    {
                        CDevice.FormParameters.Clear();
                        //CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", DccDeviceforType.EditValue.ToString()), new NameValuePair("DataCenterID", CDataCenter.EditValue.ToString()) };
                        CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", "1"), new NameValuePair("DataCenterID", "0") };
                        CDevice.StoredProcedure = sproc.Server_Select_All_By_Device_Type;
                    }
                    catch (Exception ex)
                    {
                        //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Data Center Connection":
                    DccDevice.Enabled = true;
                    DccDeviceforType.Enabled = true;
                    DccDeviceforType.FormParameters.Clear();
                    DccDeviceforType.Parameters = new NameValuePair[] { };
                    DccDeviceforType.StoredProcedure = sproc.Device_Select_ByCondition_DataCenter;                
                    break;
            }
        }

        List<Int64> ListnewConnectionID = new List<Int64>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();           
        }

        private bool Save()
        {
            if (CManagerValidator.Validate())
            {
                if (newConnectioncheck.Checked)
                {
                    DataSet ds =DBAssistant.ExecProcedure
                     (
                         sproc.Connection_Insert, new object[] 
	                    { 
	                        "@DeviceID", CDeviceType.EditValue,
	                        "@ConnectionName", CName.EditValue,
	                        "@projectName", CProject.EditValue,
	                        "@Customer", CCustomer.EditValue,
                            "@UserID", Program.userId
	                    }
                     );

                    object ID =ds.Tables[0].Rows[0][0];

                    if (CReservationValidator.Validate())
                    {
                        if (!InsertConnectionDetail(ID))
                            DBAssistant.ExecProcedure(sproc.Connection_Delete_WithDetail, new object[] { "@ID", ID });
                    }
                }
                else
                {
                    object ObjectID = CDevice.GetColumnValue("ID");
                    object ConnID = cConnection.GetColumnValue("ID");
                    DataTable dtControlCount = DBAssistant.ExecProcedure(sproc.ConnectionCount_DeviceControl, new object[] { "@ObjectID", ObjectID, "@ConnID", ConnID }).Tables[0];
                    int count = Convert.ToInt32(dtControlCount.Rows[0][0]);

                    if (CLocation.GetColumnValue("DeviceName").ToString().Equals("Server") 
                        || CLocation.GetColumnValue("DeviceName").ToString().Equals("Data Center Connection") 
                        || CLocation.GetColumnValue("DeviceName").ToString().Equals("DASD")
                        )
                    {
                        if (Convert.ToInt32(spinEdit1.Value) > count)
                        {
                            XtraMessageBox.Show("There are no empty " + CLocation.GetColumnValue("DeviceName").ToString() + " ports !", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        dtControlCount.Dispose();
                    }

                    count = -1;
                    Int64 switchTypeID = Convert.ToInt64(CSwitchType.EditValue);
                    Int64 SanGroupID = Convert.ToInt64(CSanGroup.EditValue);
                    dtControlCount = DBAssistant.ExecProcedure(sproc.ConnectionCount_SwitchControl, new object[] { "@SwitchTypeID", switchTypeID, "@SanGroupID", SanGroupID }).Tables[0];
                    count = Convert.ToInt32(dtControlCount.Rows[0][0]);
                    if (Convert.ToInt32(spinEdit1.Value) > count)
                    {
                        XtraMessageBox.Show("There are no empty switch ports !", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    //Ahmet BÜTÜN (InsertConnectionDetail now returns bool value!)
                    if (InsertConnectionDetail(cConnection.EditValue))
                        ListnewConnectionID.Add(Convert.ToInt64(ConnID));
                    else
                        return false;
                }
                RefreshAssistant.RefreshConnectionDetailForm();

                setDefaultValues();

                return true;
            }
            else
                return false;
        }

        private bool InsertConnectionDetail(object connectionID)
        {
            int res = -899;

            try
            {
                long deviceID = Convert.ToInt64(CDeviceType.EditValue);

                if (deviceID == 0)
                {
                    // Get deviceid from connection object
                    DataSet ds = DBAssistant.ExecProcedure(sproc.Connection_Select_ById, new Object[] { "@ConnectionID", connectionID });

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if(ds.Tables[0].Rows.Count>0)
                                deviceID = Convert.ToInt64(ds.Tables[0].Rows[0]["Device_ID"]);
                        }
                    }
                }

                if (deviceID == 1)

                    res = DBAssistant.ExecProcedureAndGetReturnValue
                (
                    sproc.ConnectionDetail_Insert, new object[]
                        {
                            "@ConnID", connectionID,
                            "@ObjectID", CDevice.EditValue,
                            "@DataCenterID", CDataCenter.EditValue,
                            "@CountConn", spinEdit1.EditValue,
                            "@SwitchType", CSwitchType.EditValue,
                            "@DccDeviceID",0,
                            "@Port1ID", DasdSan1lkp.EditValue,
                            "@Port2ID", DasdSan2lkp.EditValue,
                            "@SanGroupID", CSanGroup.EditValue,
                            "@ObjectType", 0
                        }

                );
                else if (deviceID == 7)
                    res = DBAssistant.ExecProcedureAndGetReturnValue
                                (
                                    sproc.ConnectionDetail_Insert, new object[]
                        {
                            "@ConnID", connectionID,
                            "@ObjectID", CDevice.EditValue,
                            "@DataCenterID", CDataCenter.EditValue,
                            "@CountConn", spinEdit1.EditValue,
                            "@SwitchType", CSwitchType.EditValue ,
                            "@DccDeviceID",DccDevice.EditValue,
                            "@Port1ID", 0,
                            "@Port2ID", 0,
                            "@SanGroupID", CSanGroup.EditValue,
                            "@ObjectType", DccDeviceforType.EditValue
                        }
                        );
                else if (deviceID == 2)
                    res = DBAssistant.ExecProcedureAndGetReturnValue
                                (
                                    sproc.ConnectionDetail_Insert, new object[]
                        {
                            "@ConnID", connectionID,
                            "@ObjectID", CDevice.EditValue,
                            "@DataCenterID", CDataCenter.EditValue,
                            "@CountConn", spinEdit1.EditValue,
                            "@SwitchType", CSwitchType.EditValue ,
                            "@DccDeviceID",0,
                            "@Port1ID", 0,
                            "@Port2ID", 0,
                            "@SanGroupID", CSanGroup.EditValue,
                            "@ObjectType", 0,
                        }
                        );

                if (res != 0)
                {
                    if (res != -899)
                        HandleReturnValue(res, deviceID);
                    else
                        XtraMessageBox.Show("Unable to Identiy Device! [Code: " + res.ToString() + "]", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return res == 0;
        }

        private void HandleReturnValue(int res, long deviceid)
        {
            switch (deviceid)
            {
                case 1: //DASD
                    switch (res)
                    {
                        case -1:
                            XtraMessageBox.Show("Unable to Identify SAN Value!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -2:
                            XtraMessageBox.Show("Unable to Identify Switch!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -3:
                            XtraMessageBox.Show("There Are No Empty DASD Ports!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -4:
                            //XtraMessageBox.Show("Unable to Identify Switch Detail!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -121:
                            XtraMessageBox.Show("Unknown Error!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            XtraMessageBox.Show("An Error Occured! [Code: " + res.ToString() + "]", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    break;
                case 2: //Server
                    switch (res)
                    {
                        case -1:
                            XtraMessageBox.Show("Unable to Identify SAN Value!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -2:
                            XtraMessageBox.Show("Unable to Identify Switch!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -3:
                            XtraMessageBox.Show("There Are No Empty Server Ports!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -4:
                            //XtraMessageBox.Show("Unable to Identify Switch Detail!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -221:
                            XtraMessageBox.Show("Unknown Error!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            XtraMessageBox.Show("An Error Occured! [Code: " + res.ToString() + "]", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    break;
                case 7: //DCC Connection
                    switch (res)
                    {
                        case -1:
                            XtraMessageBox.Show("Unable to Identify SAN Value!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -2:
                            XtraMessageBox.Show("Unable to Identify Switch!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -3:
                            XtraMessageBox.Show("Unable to Identify DCC Record!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -4:
                            XtraMessageBox.Show("There Are No Empty Ports!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -5:
                            //XtraMessageBox.Show("Unable to Identify Switch Detail!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -7:
                            XtraMessageBox.Show("There Are No Empty DCC Ports!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case -721:
                            XtraMessageBox.Show("Unknown Error!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            XtraMessageBox.Show("An Error Occured! [Code: " + res.ToString() + "]", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    break;
            }
        }

        private void CIsReservation_CheckedChanged(object sender, EventArgs e)
        {
        }

        void setDefaultValues()
        {
            CName.EditValue = string.Empty;
            InitializeForm();
            CName.Focused.ToString();     
        }        
        private void NewConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ListnewConnectionID.Count > 0)
            {
                int DeviceTypeID = 0;

                if (CDeviceType.EditValue != null)
                {
                    if (CDeviceType.EditValue.ToString() == "7")
                        DeviceTypeID = 7;
                    else
                    {
                        if (CDeviceType.EditValue != null)
                            DeviceTypeID = int.Parse(CDeviceType.EditValue.ToString());
                    }
                }

                if (XtraMessageBox.Show(
                    "Are you sure you want to print this information ?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //PRINT REPORT
                    if (DeviceTypeID == 1) //DASD
                    {
                        NewConnectionReportDASD newconectionreport = new NewConnectionReportDASD();

                        if (newconectionreport != null)
                        {
                            newconectionreport.newConnectionId = new List<long>();
                            newconectionreport.newConnectionId.AddRange(ListnewConnectionID.ToArray());
                            newconectionreport.ShowPreview();
                            ListnewConnectionID.Clear();
                        }
                    }
                    else if (DeviceTypeID == 2) //Server
                    {
                        NewConnectionReportServer newconectionreport = new NewConnectionReportServer();

                        if (newconectionreport != null)
                        {
                            newconectionreport.newConnectionId = new List<long>();
                            newconectionreport.newConnectionId.AddRange(ListnewConnectionID.ToArray());
                            newconectionreport.ShowPreview();
                            ListnewConnectionID.Clear();
                        }
                    }
                    else if (DeviceTypeID == 7)
                    {
                        NewConnectionReportDCC newconectionreport = new NewConnectionReportDCC();

                        if (newconectionreport != null)
                        {
                            newconectionreport.newConnectionId = new List<long>();
                            newconectionreport.newConnectionId.AddRange(ListnewConnectionID.ToArray());
                            newconectionreport.ShowPreview();
                            ListnewConnectionID.Clear();
                        }
                    }
                }
            }
        }

       
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cConnection_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CLocation.FormParameters.Clear();
                CLocation.FormParameters.Add(cConnection.EditValue);
                CLocation.Columns.Clear();
                CLocation.AddColumn("Name", "Select Location");

                string conID = cConnection.GetColumnValue("ID").ToString();
                CLocation.Parameters = new NameValuePair[] { new NameValuePair("ConnID", conID) };

                CLocation.StoredProcedure = sproc.Connection_return_Location_DataCenter_Device;
                if (CheckNewHasLocation())
                {
                    CLocation.FormParameters.Clear();
                    CLocation.Parameters = new NameValuePair[] { };
                    CLocation.StoredProcedure = sproc.Location_Select_All;
                    CDevice.FormParameters.Clear();
                    CDevice.Parameters = new NameValuePair[] { };
                    CDevice.AddColumn("Name", "Select Device");
                    CDevice.Columns.Clear();
                }
                else
                {
                    CLocation.ItemIndex = 0;
                    CLocation_EditValueChanged(e, new EventArgs());
                }
                CLocation.FormToShow = typeof(LocationManagerForm);
            }
            catch(Exception ex)
            {
                //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                
        private bool CheckNewHasLocation()
        {
            DataTable dt = ((DataTable)CLocation.Properties.DataSource);

            Debug.WriteLine(dt.Rows[0]["DeviceName"]);

            Debug.WriteLine(((Int64)dt.Rows[0]["ID"]));
            Debug.WriteLine(((Int64)dt.Rows[0]["DataCenterID"]));
            Debug.WriteLine(((Int64)dt.Rows[0]["ObjectID"]));

            bool result = ((Int64)dt.Rows[0]["ID"] == 0 &&
                (Int64)dt.Rows[0]["DataCenterID"] == 0 &&
                (Int64)dt.Rows[0]["ObjectID"] == 0);            
            dt.Dispose();
            
            return result;
        }     
        private void CDataCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                object oObjectID = CLocation.GetColumnValue("ObjectID");

                int DeviceTypeID = 0;

                if (CDeviceType.EditValue != null)
                {
                    if (CDeviceType.EditValue.ToString() == "7")
                    {
                        if (DccDeviceforType.EditValue != null)
                            DeviceTypeID = int.Parse(DccDeviceforType.EditValue.ToString());
                        else
                            DeviceTypeID = 7;
                    }
                    else
                    {
                        if (CDeviceType.EditValue != null)
                            DeviceTypeID = int.Parse(CDeviceType.EditValue.ToString());
                    }
                }

                if (oObjectID == null || (Int64)oObjectID == 0)
                {
                    CDevice.FormParameters.Clear();
                    CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", DeviceTypeID.ToString()), new NameValuePair("DataCenterID", CDataCenter.EditValue.ToString()) };
                    CDevice.StoredProcedure = sproc.Server_Select_All_By_Device_Type;
                    return;
                }

                string ObjectID = CLocation.GetColumnValue("ObjectID").ToString();

                CDevice.FormParameters.Clear();
                CDevice.FormParameters.Add(ObjectID);

                DataSet ds = DBAssistant.ExecProcedure(sproc.Server_Select_ById, new object[]
                                {
                                    "@DeviceName", CLocation.GetColumnValue("DeviceName"),
                                    "@ObjectID", ObjectID,
                                    "@DataCenterID", CDataCenter.EditValue,
                                    "@DeviceType", DeviceTypeID
                                });

                CDevice.Properties.DataSource = ds.Tables[0].DefaultView;
                CDevice.Properties.DisplayMember = "Name";
                CDevice.Properties.ValueMember = "ID";

                CDevice.ItemIndex = 0;

                DataTable dt = ((DataTable)CLocation.Properties.DataSource);

                long deviceID = ((Int64)dt.Rows[0]["DeviceID"]);

                if (deviceID == 2)
                {
                    DasdSan1lkp.Enabled = false;
                    DasdSan2lkp.Enabled = false;
                }
                else
                {
                    DasdSan1lkp.Enabled = true;
                    DasdSan2lkp.Enabled = true;
                    DataSet dsPorts1 = DBAssistant.ExecProcedure(sproc.Dasd_Select_Available_Port, new object[]
                                {
                                    "@DasdID", ObjectID,
                                    "@SanValue", 1
                                });

                    DasdSan1lkp.Properties.DataSource = dsPorts1.Tables[0].DefaultView;
                    DasdSan1lkp.Properties.DisplayMember = "Port";
                    DasdSan1lkp.Properties.ValueMember = "ID";

                    DasdSan1lkp.ItemIndex = 0;


                    DataSet dsPorts2 = DBAssistant.ExecProcedure(sproc.Dasd_Select_Available_Port, new object[]
                                {
                                    "@DasdID", ObjectID,
                                    "@SanValue", 2
                                });

                    DasdSan2lkp.Properties.DataSource = dsPorts2.Tables[0].DefaultView;
                    DasdSan2lkp.Properties.DisplayMember = "Port";
                    DasdSan2lkp.Properties.ValueMember = "ID";

                    DasdSan2lkp.ItemIndex = 0;
                }
            }
            catch(Exception ex)
            {
                //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (Save()) Close();
        }

        private void newConnectioncheck_CheckedChanged(object sender, EventArgs e)
        {
            if (newConnectioncheck.Checked)
            {
                cConnection.Enabled = false;
                cConnection.Visible = false;
                DccDeviceforType.Enabled = false;
                DccDevice.Enabled = false;
                newConnectionControlGroup.Visibility = LayoutVisibility.Always;
                this.Size = new Size(this.Size.Width, this.Size.Height + HeightDifference2);

                CLocation.FormParameters.Clear();
                CLocation.Parameters = new NameValuePair[] { };
                CLocation.StoredProcedure = sproc.Location_Select_All;
            }
            else 
            {
                cConnection.Enabled = true;
                cConnection.Visible = true;
                newConnectionControlGroup.Visibility = LayoutVisibility.Never;
                this.Size = new Size(this.Size.Width, this.Size.Height - HeightDifference2);
            }
        }

        private void CDevice_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (newConnectioncheck.Checked)
                {
                    long ObjectID = Convert.ToInt64(CDevice.EditValue);
                    int devicetypeID = Convert.ToInt16(CDeviceType.EditValue);

                    if (devicetypeID == 2)
                    {
                        DasdSan1lkp.Enabled = false;
                        DasdSan2lkp.Enabled = false;
                    }
                    else
                    {
                        DasdSan1lkp.Enabled = true;
                        DasdSan2lkp.Enabled = true;
                        DataSet dsPorts1 = DBAssistant.ExecProcedure(sproc.Dasd_Select_Available_Port, new object[]
                                {
                                    "@DasdID", ObjectID,
                                    "@SanValue", 1
                                });

                        DasdSan1lkp.Properties.DataSource = dsPorts1.Tables[0].DefaultView;
                        DasdSan1lkp.Properties.DisplayMember = "Port";
                        DasdSan1lkp.Properties.ValueMember = "ID";

                        DasdSan1lkp.ItemIndex = 0;


                        DataSet dsPorts2 = DBAssistant.ExecProcedure(sproc.Dasd_Select_Available_Port, new object[]
                                {
                                    "@DasdID", ObjectID,
                                    "@SanValue", 2
                                });

                        DasdSan2lkp.Properties.DataSource = dsPorts2.Tables[0].DefaultView;
                        DasdSan2lkp.Properties.DisplayMember = "Port";
                        DasdSan2lkp.Properties.ValueMember = "ID";

                        DasdSan2lkp.ItemIndex = 0;

                        DccDevice.FormParameters.Clear();
                        DccDevice.Parameters = new NameValuePair[] { };
                        DccDevice.StoredProcedure = sproc.DCC_Select_AllByName;

                    }
                }
            }
            catch(Exception ex)
            {
                //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DccDeviceforType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CDevice.FormParameters.Clear();
                //CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", DccDeviceforType.EditValue.ToString()), new NameValuePair("DataCenterID", CDataCenter.EditValue.ToString()) };
                CDevice.Parameters = new NameValuePair[] { new NameValuePair("DeviceID", DccDeviceforType.EditValue.ToString()), new NameValuePair("DataCenterID", "0") };
                CDevice.StoredProcedure = sproc.Server_Select_All_By_Device_Type;
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}