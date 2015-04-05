using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Data
{
    public static class sproc
    {
        //
        //public static string  = string.Format(SPROC_TEMPLATE, "");


        

        #region General

        //
        public static string SPROC_TEMPLATE = "[sproc].[{0}]";
        //
        public static string GetNextID = string.Format(SPROC_TEMPLATE, "GetNextID");
        //
        public static string GetAssociatedTable_ByDeviceName = string.Format(SPROC_TEMPLATE, "GetAssociatedTable_ByDeviceName");
        public static string Full_Delete = string.Format(SPROC_TEMPLATE, "Full_Delete");

        #endregion

        #region Logs

        public static string Log_SelectAll = string.Format(SPROC_TEMPLATE, "Log_SelectAll");

        public static string Log_DeleteAll = string.Format(SPROC_TEMPLATE, "Log_DeleteAll");

        #endregion

        #region Blech

        #region Blech

        //
        public static string Blech_Select_All = string.Format(SPROC_TEMPLATE, "Blech_Select_All");
        //
        public static string Blech_Select_ForServer_ByTypeID = string.Format(SPROC_TEMPLATE, "Blech_Select_ForServer_ByTypeID");
        //
        public static string Blech_Insert = string.Format(SPROC_TEMPLATE, "Blech_Insert");
        //
        public static string Blech_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "Blech_InsertWithDetails");
        //
        public static string Blech_Insert_forImport = string.Format(SPROC_TEMPLATE, "Blech_Insert_forImport");

        #endregion

        #region Blech Detail

        //
        public static string BlechDetail_Select_ByBlechID = string.Format(SPROC_TEMPLATE, "BlechDetail_Select_ByBlechID");
        //
        public static string BlechDetail_Insert = string.Format(SPROC_TEMPLATE, "BlechDetail_Insert");

        #endregion

        #region Blech Type

        //
        public static string BlechType_Select_All = string.Format(SPROC_TEMPLATE, "BlechType_Select_All");
        //
        public static string BlechType_Insert = string.Format(SPROC_TEMPLATE, "BlechType_Insert");
        //
        public static string BlechType_Update_ByID = string.Format(SPROC_TEMPLATE, "BlechType_Update_ByID");
        //
        public static string BlechType_Delete_ByID = string.Format(SPROC_TEMPLATE, "BlechType_Delete_ByID");

        #endregion

        #endregion

        #region DASD

        #region DASD

        //
        public static string DASD_Select_All = string.Format(SPROC_TEMPLATE, "DASD_Select_All");
        //
        public static string DASD_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "DASD_Insert_WithDetails");
        //
        public static string DASD_Insert_Check_Record = string.Format(SPROC_TEMPLATE, "DASD_Insert_Check_Record");

        #endregion

        #region DASD Detail

        //
        public static string DASDDetail_Select_BySanValue = string.Format(SPROC_TEMPLATE, "DASDDetail_Select_BySanValue");
        //
        public static string DASD_Insert_forImport = string.Format(SPROC_TEMPLATE, "DASD_Insert_forImport");
        //
        public static string DASDDetail_Insert_forImport = string.Format(SPROC_TEMPLATE, "DASDDetail_Insert_forImport");
        //
        public static string VTPort_For_Dasd_BySanGroupId = string.Format(SPROC_TEMPLATE, "VTPort_For_Dasd_BySanGroupId");
        //
        public static string DASDDetail_Select_BySanGroupId = string.Format(SPROC_TEMPLATE, "DASDDetail_Select_BySanGroupId");
        //
        public static string Blech_For_Dasd = string.Format(SPROC_TEMPLATE, "Blech_For_Dasd");
        //
        public static string DasdDetail_Update_LcUrm = string.Format(SPROC_TEMPLATE, "DasdDetail_Update_LcUrm");
        //
        public static string DasdDetail_Blech_VTPort_Update = string.Format(SPROC_TEMPLATE, "DasdDetail_Blech_VTPort_Update");
        //
        public static string Dasd_Select_Available_Port = string.Format(SPROC_TEMPLATE, "Dasd_Select_Available_Port");   
             
        #endregion

        #region DASD CuType

        //
        public static string DasdCuType_Select_All = string.Format(SPROC_TEMPLATE, "DasdCuType_Select_All");
        //
        public static string DasdCuType_Insert = string.Format(SPROC_TEMPLATE, "DasdCuType_Insert");
        //
        public static string DasdCuType_Update_ByID = string.Format(SPROC_TEMPLATE, "DasdCuType_Update_ByID");
        //
        public static string DasdCuType_Delete_ByID = string.Format(SPROC_TEMPLATE, "DasdCuType_Delete_ByID");

        #endregion

        #endregion

        #region Cable

        #region Cable

        //
        public static string Cable_Insert = string.Format(SPROC_TEMPLATE, "Cable_Insert");
        //
        public static string Cable_Insert_Specific = string.Format(SPROC_TEMPLATE, "Cable_Insert_Specific");
        //
        public static string Cable_Select_ByCableModelID = string.Format(SPROC_TEMPLATE, "Cable_Select_ByCableModelID");
        //
        public static string Cable_Select_ByCategoryID = string.Format(SPROC_TEMPLATE, "Cable_Select_ByCategoryID");
        //
        public static string Cable_Select_ByModelName = string.Format(SPROC_TEMPLATE, "Cable_Select_ByModelName");
        //
        public static string Cable_Select_MaxNumber_ByCategoryID = string.Format(SPROC_TEMPLATE, "Cable_Select_MaxNumber_ByCategoryID");
        //
        public static string Cable_Select_LcByLength = string.Format(SPROC_TEMPLATE, "Cable_Select_LcByLength");
        //
        public static string Cable_Select_TrunkCableTypes = string.Format(SPROC_TEMPLATE, "Cable_Select_TrunkCables");
        //
        public static string Cable_Select_FirstTrunk_BySanValue = string.Format(SPROC_TEMPLATE, "Cable_Select_FirstTrunk_BySanValue");
        //
        public static string Cable_Select_TrunkCables_ByCableLine = string.Format(SPROC_TEMPLATE, "Cable_Select_TrunkCables_ByCableLine");
        //
        public static string Cable_Select_LengthsByCategory = string.Format(SPROC_TEMPLATE, "Cable_Select_LengthsByCategory");
        //
        public static string Cable_Select_Available_LcUrm_For_Rack = string.Format(SPROC_TEMPLATE, "Cable_Select_Available_LcUrm_For_Rack");
        //
        public static string Trunk_Select_ConnectionCounts = string.Format(SPROC_TEMPLATE, "Trunk_Select_ConnectionCounts");
        //
        public static string Cable_Select_Available_LcUrm_For_Rack_BySanGroupId = string.Format(SPROC_TEMPLATE, "Cable_Select_Available_LcUrm_For_Rack_BySanGroupId");
        //
        public static string Cable_Select_Available_LcUrm_For_Dasd = string.Format(SPROC_TEMPLATE, "Cable_Select_Available_LcUrm_For_Dasd");
        //
        public static string Cable_Select_Available_LcUrm_For_Dasd_BySanGroupId = string.Format(SPROC_TEMPLATE, "Cable_Select_Available_LcUrm_For_Dasd_BySanGroupId");
        
        #endregion

        #region Cable Category

        //
        public static string CableCategory_Select_All = string.Format(SPROC_TEMPLATE, "CableCategory_Select_All");
        //
        public static string CableCategory_Insert = string.Format(SPROC_TEMPLATE, "CableCategory_Insert");
        //
        public static string CableCategory_Update_ByID = string.Format(SPROC_TEMPLATE, "CableCategory_Update_ByID");
        //
        public static string CableCategory_Delete_ByID = string.Format(SPROC_TEMPLATE, "CableCategory_Delete_ByID");

        #endregion

        #region Cable Model

        //
        public static string CableModel_Get_ClassCount = string.Format(SPROC_TEMPLATE, "CableModel_Get_ClassCount");
        //
        public static string CableModel_Update_ByID = string.Format(SPROC_TEMPLATE, "CableModel_Update_ByID");
        //
        public static string CableModel_Delete_ByID = string.Format(SPROC_TEMPLATE, "CableModel_Delete_ByID");
        //
        public static string CableModel_Insert = string.Format(SPROC_TEMPLATE, "CableModel_Insert");
        //
        public static string CableModel_Select_ByCategoryID = string.Format(SPROC_TEMPLATE, "CableModel_Select_ByCategoryID");
        //
        public static string CableModel_Select_ByCategoryID2 = string.Format(SPROC_TEMPLATE, "CableModel_Select_ByCategoryID2");
        //
        public static string CableModel_Select_ByModelID2 = string.Format(SPROC_TEMPLATE, "CableModel_Select_ByModelID2");
        #endregion

        #region Cable Properties

        //
        public static string CableProperties_Insert = string.Format(SPROC_TEMPLATE, "CableProperties_Insert");
        //
        public static string CableProperties_Select_ByCableModelID = string.Format(SPROC_TEMPLATE, "CableProperties_Select_ByCableModelID");

        #endregion

        #endregion

        #region System

        #region Class

        //
        public static string Class_Select_All = string.Format(SPROC_TEMPLATE, "Class_SelectAll");

        #endregion

        #region Operating System

        //
        public static string OS_Select_All = string.Format(SPROC_TEMPLATE, "OS_Select_All");
        //
        public static string OS_Insert = string.Format(SPROC_TEMPLATE, "OS_Insert");
        //
        public static string OS_Update_ByID = string.Format(SPROC_TEMPLATE, "OS_Update_ByID");
        //
        public static string OS_Delete_ByID = string.Format(SPROC_TEMPLATE, "OS_Delete_ByID");

        #endregion

        #region Device

        //
        public static string Device_Select_All = string.Format(SPROC_TEMPLATE, "Device_Select_All");
        //
        public static string Device_Select_Specific = string.Format(SPROC_TEMPLATE, "Device_Select_Specific");
        //
        public static string Device_Select_ByCondition1 = string.Format(SPROC_TEMPLATE, "Device_Select_ByCondition1");
        //
        public static string Device_Select_ByCondition2 = string.Format(SPROC_TEMPLATE, "Device_Select_ByCondition2");
        //
        public static string Device_Insert = string.Format(SPROC_TEMPLATE, "Device_Insert");
        //
        public static string Device_Update_ByID = string.Format(SPROC_TEMPLATE, "Device_Update_ByID");
        //
        public static string Device_Delete_ByID = string.Format(SPROC_TEMPLATE, "Device_Delete_ByID");
        //
        public static string Device_Select_ByCondition_DataCenter = string.Format(SPROC_TEMPLATE, "Device_Select_ByCondition_DataCenter");

        #endregion

        #region Defaults

        //
        public static string Set_Defaults = string.Format(SPROC_TEMPLATE, "Set_Defaults");
        //
        public static string SetDefaultSettingByKey = string.Format(SPROC_TEMPLATE, "SetDefaultSettingByKey");
        //
        public static string Defaults_Select_All = string.Format(SPROC_TEMPLATE, "Defaults_Select_All");
        //
        public static string Defaults_Update_ByID = string.Format(SPROC_TEMPLATE, "Defaults_Update_ByID");

        #endregion

        #region Tree

        //
        public static string Tree_Select_ByGroupName = string.Format(SPROC_TEMPLATE, "Tree_Select_ByGroupName");

        #endregion

        #endregion

        #region Location

        #region Coordinate

        //
        public static string Coordinate_Delete_ByID = string.Format(SPROC_TEMPLATE, "Coordinate_Delete_ByID");
        //
        public static string Coordinate_Insert = string.Format(SPROC_TEMPLATE, "Coordinate_Insert");
        
        //        
        public static string Coordinate_Insert_WithDataCenterName = string.Format(SPROC_TEMPLATE, "Coordinate_Insert_WithDataCenterName");

        public static string Coordinate_Select_ByDataCenterID = string.Format(SPROC_TEMPLATE, "Coordinate_Select_ByDataCenterID");
        
        //
        public static string Coordinate_Update_ByID = string.Format(SPROC_TEMPLATE, "Coordinate_Update_ByID");

        #endregion

        #region Data Center

        //
        public static string DataCenter_Delete_ByID = string.Format(SPROC_TEMPLATE, "DataCenter_Delete_ByID");
        //
        public static string DataCenter_Insert = string.Format(SPROC_TEMPLATE, "DataCenter_Insert");

        //
        public static string DataCenter_Insert_WithLocationName = string.Format(SPROC_TEMPLATE, "DataCenter_Insert_WithLocationName");
        
        //
        public static string DataCenter_Select_ByLocationID = string.Format(SPROC_TEMPLATE, "DataCenter_Select_ByLocationID");
        //
        public static string DataCenter_Update_ByID = string.Format(SPROC_TEMPLATE, "DataCenter_Update_ByID");

        #endregion

        #region Location

        //
        public static string Location_Delete_ByID = string.Format(SPROC_TEMPLATE, "Location_Delete_ByID");
        //
        public static string Location_Insert = string.Format(SPROC_TEMPLATE, "Location_Insert");
        //
        public static string Location_Select_All = string.Format(SPROC_TEMPLATE, "Location_SelectAll");
        //
        public static string Location_Update_ByID = string.Format(SPROC_TEMPLATE, "Location_Update_ByID");



        #endregion

        #endregion

        #region Server

        #region Server

        //
        public static string Server_Select_All = string.Format(SPROC_TEMPLATE, "Server_Select_All");
        //
        public static string Server_Insert = string.Format(SPROC_TEMPLATE, "Server_Insert");
        //
        public static string Server_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "Server_Insert_WithDetails");
        //
        public static string Server_Insert_forImport = string.Format(SPROC_TEMPLATE, "Server_Insert_forImport");
        //
        public static string Server_Insert_Check_Record = string.Format(SPROC_TEMPLATE, "Server_Insert_Check_Record");

        #endregion

        #region User Kontrol
        public static string LoginCheck = string.Format(SPROC_TEMPLATE, "LoginCheck");

        public static string LogoutCheck = string.Format(SPROC_TEMPLATE, "LogoutCheck");

        public static string LoginUserList = string.Format(SPROC_TEMPLATE, "LoginUser_Select");

        public static string LoginUserInsert = string.Format(SPROC_TEMPLATE, "LoginUser_Insert");

        public static string LoginUserDelete = string.Format(SPROC_TEMPLATE, "LoginUser_Delete");

        public static string LoginUserDetail = string.Format(SPROC_TEMPLATE, "LoginUser_Select_Detail");

        public static string UserLog = string.Format(SPROC_TEMPLATE, "UserLog_Insert");
#endregion
         
        #region Server Detail

        //
        public static string ServerDetail_Select_BySanValue = string.Format(SPROC_TEMPLATE, "ServerDetail_Select_BySanValue");
        //
        public static string ServerDetail_Insert = string.Format(SPROC_TEMPLATE, "ServerDetail_Insert");
        //
        public static string ServerDetail_Insert_forImport = string.Format(SPROC_TEMPLATE, "ServerDetail_Insert_forImport");
        //
        public static string ServerDetail_Update_LcUrm = string.Format(SPROC_TEMPLATE, "ServerDetail_Update_LcUrm");
        //
        public static string VTPort_For_Rack = string.Format(SPROC_TEMPLATE, "VTPort_For_Rack");
        //
        public static string ServerDetail_Select_BySanGroupId = string.Format(SPROC_TEMPLATE, "ServerDetail_Select_BySanGroupId");
        //
        public static string ServerDetail_Blech_VTPort_Update = string.Format(SPROC_TEMPLATE, "ServerDetail_Blech_VTPort_Update");
        //
        public static string DccDetail_VTPort_Update = string.Format(SPROC_TEMPLATE, "DccDetail_VTPort_Update");
        //
        public static string VTPort_For_Rack_BySanGroupId = string.Format(SPROC_TEMPLATE, "VTPort_For_Rack_BySanGroupId");
        //
        public static string VTPort_For_Dcc_BySanGroupId = string.Format(SPROC_TEMPLATE, "VTPort_For_Dcc_BySanGroupId");

        public static string VTPort_For_Dcc1_BySanGroupId = string.Format(SPROC_TEMPLATE, "VTPort_For_Dcc1_BySanGroupId");

        public static string VTPort_For_Dcc2_BySanGroupId = string.Format(SPROC_TEMPLATE, "VTPort_For_Dcc2_BySanGroupId");
        //
        public static string Blech_For_Rack = string.Format(SPROC_TEMPLATE, "Blech_For_Rack");
        #endregion

        #endregion

        #region Switch

        #region Switch

        //
        public static string Switch_Select_All = string.Format(SPROC_TEMPLATE, "Switch_Select_All");
        //
        public static string Switch_SelectBySunGroup = string.Format(SPROC_TEMPLATE, "Switch_SelectBySunGroup");
        //
        public static string Switch_Select_ByTypeID = string.Format(SPROC_TEMPLATE, "Switch_Select_ByTypeID");
        //
        public static string Switch_Select_ByTypeName = string.Format(SPROC_TEMPLATE, "Switch_Select_ByTypeName");
        //
        public static string Switch_Insert = string.Format(SPROC_TEMPLATE, "Switch_Insert");
        //
        public static string Switch_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "Switch_Insert_WithDetails");
        //
        public static string Switch_Insert_Check_Record = string.Format(SPROC_TEMPLATE, "Switch_Insert_Check_Record");

        #endregion

        #region Switch Detail
        //
        public static string SwitchDetail_Select_BySwitchID = string.Format(SPROC_TEMPLATE, "SwitchDetail_Select_BySwitchID");
        //
        public static string SwitchDetail_Select_BySwitchID_Specific = string.Format(SPROC_TEMPLATE, "SwitchDetail_Select_BySwitchID_Specific");
        //
        public static string SwitchDetail_Insert = string.Format(SPROC_TEMPLATE, "SwitchDetail_Insert");

        //
        public static string Cable_Select_Available_LcUrm_For_Switch = string.Format(SPROC_TEMPLATE, "Cable_Select_Available_LcUrm_For_Switch");

         //
        public static string SwitchDetail_Update_LcUrm = string.Format(SPROC_TEMPLATE, "SwitchDetail_Update_LcUrm");
      
        

        #endregion

        #region Switch Model

        /// <summary>
        /// 
        /// </summary>
        public static string SwitchModel_Select_All = string.Format(SPROC_TEMPLATE, "SwitchModel_Select_All");
        
        /// <summary>
        /// 
        /// </summary>
        public static string SwitchModel_Insert = string.Format(SPROC_TEMPLATE, "SwitchModel_Insert");
        
        /// <summary>
        /// 
        /// </summary>
        public static string Switch_Insert_forImport = string.Format(SPROC_TEMPLATE, "Switch_Insert_forImport");

        /// <summary>
        /// 
        /// </summary>
        public static string SwitchDetail_Insert_forImport = string.Format(SPROC_TEMPLATE, "SwitchDetail_Insert_forImport");
        
        #endregion

        #region Switch Type

        //
        public static string SwitchType_Select_All = string.Format(SPROC_TEMPLATE, "SwitchType_Select_All");
        //
        public static string SwitchType_Insert = string.Format(SPROC_TEMPLATE, "SwitchType_Insert");
        //
        public static string SwitchType_Update_ByID = string.Format(SPROC_TEMPLATE, "SwitchType_Update_ByID");
        //
        public static string SwitchType_Delete_ByID = string.Format(SPROC_TEMPLATE, "SwitchType_Delete_ByID");


        #endregion

        #endregion

        #region VTPort

        #region VTPort

        //
        public static string VtPort_Select_All = string.Format(SPROC_TEMPLATE, "VtPort_Select_All");
        //
        public static string VtPort_Select_BySanID = string.Format(SPROC_TEMPLATE, "VtPort_Select_BySanID");
        //
        public static string VtPort_Select_BySanValue = string.Format(SPROC_TEMPLATE, "VtPort_Select_BySanValue");
        //
        public static string VtPort_Insert = string.Format(SPROC_TEMPLATE, "VtPort_Insert");
        //
        public static string VtPort_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "VtPort_InsertWithDetails");
        //
        public static string VTPort_Insert_forImport = string.Format(SPROC_TEMPLATE, "VTPort_Insert_forImport");


        #endregion

        #region VTPort Detail

        //
        public static string VtPortDetail_Select_ByVtPortID = string.Format(SPROC_TEMPLATE, "VtPortDetail_Select_ByVtPortID");
        //
        public static string VtPortDetail_Insert = string.Format(SPROC_TEMPLATE, "VtPortDetail_Insert");

        #endregion

        #endregion

        #region San

        #region San

        //
        public static string San_Select_ByGroupID = string.Format(SPROC_TEMPLATE, "San_Select_ByGroupID");
        //
        public static string San_Insert = string.Format(SPROC_TEMPLATE, "San_Insert");
        //
        public static string San_Update_ByID = string.Format(SPROC_TEMPLATE, "San_Update_ByID");
        //
        public static string San_Delete_ByID = string.Format(SPROC_TEMPLATE, "San_Delete_ByID");

        #endregion

        #region San Group

        // 
        public static string SanGroup_Select_All = string.Format(SPROC_TEMPLATE, "SanGroup_Select_All");
        // 
        public static string SanGroup_Insert = string.Format(SPROC_TEMPLATE, "SanGroup_Insert");
        //
        public static string SanGroup_Update_ByID = string.Format(SPROC_TEMPLATE, "SanGroup_Update_ByID");
        //
        public static string SanGroup_Delete_ByID = string.Format(SPROC_TEMPLATE, "SanGroup_Delete_ByID");

        #endregion

        #endregion

        #region Connection

        #region Connection

        //
        public static string Connection_Insert = string.Format(SPROC_TEMPLATE, "Connection_Insert");
        //
        public static string Connection_Select_All = string.Format(SPROC_TEMPLATE, "Connection_Select_All");
        public static string Connection_Select_ById = string.Format(SPROC_TEMPLATE, "Connection_Select_ById");
        //
        public static string Connection_Insert_WithDetail = string.Format(SPROC_TEMPLATE, "Connection_Insert_WithDetail");
        //
        public static string ConnectionDetail_Insert = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Insert");
        //
        public static string Switch_Select_ForConnection = string.Format(SPROC_TEMPLATE, "Switch_Select_ForConnection");
        //
        public static string Reservation_Insert = string.Format(SPROC_TEMPLATE, "Reservation_Insert");

        public static string Connection_return_Location_DataCenter_Device = string.Format(SPROC_TEMPLATE, "Connection_return_Location_DataCenter_Device");
        public static string DataCenter_Select_ByDataCenterID = string.Format(SPROC_TEMPLATE, "DataCenter_Select_ByDataCenterID");

        public static string Server_Select_ById = string.Format(SPROC_TEMPLATE, "Server_Select_ById");

        public static string ConnectionCount_DeviceControl = string.Format(SPROC_TEMPLATE, "ConnectionCount_DeviceControl");

        public static string ConnectionCount_SwitchControl = string.Format(SPROC_TEMPLATE, "ConnectionCount_SwitchControl");

        public static string Server_Select_All_By_Device_Type = string.Format(SPROC_TEMPLATE, "Server_Select_All_By_Device_Type");


        
        

        #endregion

        #region ConnectionDetail

        //
        public static string ConnectionDetail_Update_SwitchDetail = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Update_SwitchDetail");
        //
        public static string ConnectionDetail_UpdateForDcc = string.Format(SPROC_TEMPLATE, "ConnectionDetail_UpdateForDcc");
        //
        public static string ConnectionDetail_Update = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Update");
        //
        public static string Connection_Delete_WithDetail = string.Format(SPROC_TEMPLATE, "Connection_Delete_WithDetail");

        //
        public static string ConnectionDetail_Select_ByConnectionID = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Select_ByConnectionID");

        public static string ConnectionDetail_Delete_byID = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Delete_byID");

        public static string ConnectionDetail_Move = string.Format(SPROC_TEMPLATE, "ConnectionDetail_Move");
        
        #endregion

        #endregion

        #region Data Center Connection

        //
        public static string DCC_Select_All = string.Format(SPROC_TEMPLATE, "DCC_Select_All");
        public static string DCC_Select_AllByName = string.Format(SPROC_TEMPLATE, "DCC_Select_AllByName");
        public static string DCC_Select_ById = string.Format(SPROC_TEMPLATE, "DCC_Select_ById");
        //
        public static string Dcc_Insert_forImport = string.Format(SPROC_TEMPLATE, "Dcc_Insert_forImport");
        //
        public static string DccDetail_Insert_forImport = string.Format(SPROC_TEMPLATE, "DccDetail_Insert_forImport");
        //
        public static string DCCDetail_Select_BySanValue = string.Format(SPROC_TEMPLATE, "DCCDetail_Select_BySanValue");
        //
        public static string DCC_Insert_WithDetails = string.Format(SPROC_TEMPLATE, "DCC_Insert_WithDetails");

        #endregion

        #region Search

        //
        public static string Search_Cable_Select_All = string.Format(SPROC_TEMPLATE, "Search_Cable_Select_All");
        //
        public static string Search_Server_Select_All = string.Format(SPROC_TEMPLATE, "Search_Server_Select_All");
        //
        public static string Search_Connection_Select_All = string.Format(SPROC_TEMPLATE, "Search_Connection_Select_All");
        //
        public static string Search_Switch_Select_All = string.Format(SPROC_TEMPLATE, "Search_Switch_Select_All");
        //
        public static string Search_DASD_Select_All = string.Format(SPROC_TEMPLATE, "Search_DASD_Select_All");

        public static string Search_DCC_Select_All = string.Format(SPROC_TEMPLATE, "Search_DCC_Select_All");

        #endregion

    }

}
