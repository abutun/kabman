using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace KabMan.KabMan.Data
{
    public static class SProcs
    {


        /// <summary>
        /// Checks URM number in URM table in database
        /// </summary>
        /// <param name="argUrmNo">URM number to check</param>
        /// <returns></returns>
        public static bool HasUrm(string argUrmNo)
        {
            // Clears the spaces
            argUrmNo = argUrmNo.Trim();
            //
            Regex lv_RegexURM = new Regex(@"^\w\d{5}");
            //
            argUrmNo = lv_RegexURM.Match(argUrmNo).Value.Remove(0, 1);
            //
            bool retValue = false;
            //
            if (argUrmNo.Length > 0 && argUrmNo.Length <= 5)
            {
                // Finds argument length
                int lv_ArgLength = argUrmNo.Trim().Length;
                // Fills the URM number with zeros if length below 5
                for (int i = 0; i < 5 - lv_ArgLength; i++)
                {
                    argUrmNo = "0" + argUrmNo;
                }

                // Creates parameter array from arguments
                object[] lv_ArgArray = new object[] 
            { 
                "@StartNo", argUrmNo
            };

                // New DataSet for return table from procedure
                DataSet lv_OutDataSet;
                lv_OutDataSet = ExecProcedure(SPROC.URM_CHECK, lv_ArgArray);

                retValue = lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString() == "1" ? true : false;
            }

            // Casts returned cell value as bool and returns
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argUrmId"></param>
        /// <returns></returns>
        public static Dictionary<string, string> IsUrmUrmInSwitch(int argUrmId)
        {
            //
            Dictionary<string, string> retValue = new Dictionary<string, string>();

            if (argUrmId > 0)
            {

                // New DataSet for return table from procedure
                DataSet lv_OutDataSet;
                lv_OutDataSet = ExecProcedure(SPROC.URM_CHECK_IN_SWITCH, new object[] { "@UrmId", argUrmId });

                // Adds ID to the dictionary
                retValue.Add("ID", lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["Id"].ToString());
                // Adds Target to the dictionary
                retValue.Add("Target", lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["Target"].ToString());
            }
            return retValue;
        }

        /// <summary>
        /// Gets URM Id from URM number
        /// </summary>
        /// <param name="argUrmNo">URM number to check</param>
        /// <returns></returns>
        public static int GetUrmIdFromUrmNo(string argUrmNo)
        {
            // Clears the spaces
            argUrmNo = argUrmNo.Trim();
            //
            Regex lv_RegexURM = new Regex(@"^\w\d{5}");
            //
            argUrmNo = lv_RegexURM.Match(argUrmNo).Value.Remove(0, 1);
            //
            int retValue = 0;
            //
            if (argUrmNo.Length > 0 && argUrmNo.Length <= 5)
            {
                // Finds argument length
                int lv_ArgLength = argUrmNo.Trim().Length;
                // Fills the URM number with zeros if length below 5
                for (int i = 0; i < 5 - lv_ArgLength; i++)
                {
                    argUrmNo = "0" + argUrmNo;
                }

                // New DataSet for return table from procedure
                DataSet lv_OutDataSet;
                lv_OutDataSet = ExecProcedure(SPROC.GET_URM_ID_FROM_URM_NAME, new object[] { "@StartNo", argUrmNo });

                retValue = Convert.ToInt32(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"]);
            }

            // Casts returned cell value as bool and returns
            return retValue;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argSanID"></param>
        /// <param name="argSwitchType"></param>
        /// <returns></returns>
        public static bool HasSwitch(object argLocationID, object argRoomID, object argSanID, object argSwitchType, object argName)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@LocationId", argLocationID, 
                "@RoomId", argRoomID, 
                "@SanId", argSanID, 
                "@SwType", argSwitchType,
                "@Name",argName
            };

            //
            bool retValue = false;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            lv_OutDataSet = ExecProcedure(SPROC.SWITCH_CHECK, lv_ArgArray);

            retValue = lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString() == "1" ? true : false;

            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argRoomID"></param>
        /// <param name="argSanID"></param>
        /// <returns></returns>
        public static long HasBlech(object argRoomID, object argSanID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@RoomId", argRoomID, 
                "@SanId", argSanID
            };

            //
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            lv_OutDataSet = ExecProcedure(SPROC.BLECH_CHECK, lv_ArgArray);

            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());

            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argSanID"></param>
        /// <param name="argTypeID"></param>
        /// <param name="argObjectID"></param>
        /// <returns></returns>
        public static long InsertBlech(object argLocationID, object argRoomID, object argSanID, object argTypeID, object argObjectName)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@LocationId", argLocationID, 
                "@RoomId", argRoomID,
                "@SanId", argSanID, 
                "@TypeId", argTypeID,
                "@ObjectName", argObjectName
            };

            //
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            lv_OutDataSet = ExecProcedure(SPROC.BLECH_INSERT, lv_ArgArray);

            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());

            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argRoomID"></param>
        /// <param name="argSanID"></param>
        /// <returns></returns>
        public static long HasVtPort(object argRoomID, object argSanID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@RoomId", argRoomID, 
                "@SanId", argSanID
            };

            //
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            lv_OutDataSet = ExecProcedure(SPROC.VTPORT_CHECK, lv_ArgArray);

            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());

            return retValue;
        }

        /// <summary>
        /// Inserts a new VTPort
        /// </summary>
        /// <param name="argLocationID">ID of Location</param>
        /// <param name="argRoomID">ID of Room</param>
        /// <param name="argSanID">ID of SAN</param>
        /// <returns>ID of inserted VTPort</returns>
        public static long InsertVtPort(object argLocationID, object argRoomID, object argSanID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@LocationId", argLocationID, 
                "@RoomId", argRoomID,
                "@SanId", argSanID
            };

            //
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            lv_OutDataSet = ExecProcedure(SPROC.VTPORT_INSERT, lv_ArgArray);

            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());

            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argID"></param>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argSanID"></param>
        /// <param name="argTypeID"></param>
        /// <param name="argModelID"></param>
        /// <param name="argBlechID"></param>
        /// <param name="argVTPortID"></param>
        /// <param name="argSerialNo"></param>
        /// <param name="argIpNo"></param>
        /// <param name="argConnSwitchID"></param>
        /// <returns></returns>
        public static long OnlyInsertSwitch(object argID, object argLocationID, object argRoomID, object argSanID, object argTypeID, object argModelID, object argBlechID, object argVTPortID, object argSerialNo, object argIpNo, object argConnSwitchID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@Id", argID, 
                "@LocationId", argLocationID,
                "@RoomId", argRoomID, 
                "@SanId", argSanID,
                "@TypeId", argTypeID,
                "@ModelId", argModelID, 
                "@BlechId", argBlechID,
                "@VTPortId", argVTPortID, 
                "@SerialNo", argSerialNo,
                "@IpNo", argIpNo,
                "@ConnSwitchId",argConnSwitchID
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.SWITCH_INSERT_ONLY, lv_ArgArray);
            //
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            //
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argBlechId"></param>
        /// <param name="argClass"></param>
        /// <param name="argNo"></param>
        /// <param name="argClass2"></param>
        /// <returns></returns>
        public static long GetBlechDetailId(object argBlechId, object argClass, object argNo, object argClass2)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@BlechId", argBlechId, 
                "@Class", argClass,
                "@No", argNo,
                "@Class2", argClass2
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.BLECH_GET_DETAIL_ID, lv_ArgArray);
            // Converts 
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returnes value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argTrunkSymbol"></param>
        /// <param name="argTrunkNo"></param>
        /// <param name="argTrunkClass"></param>
        /// <param name="argTrunkRmId"></param>
        /// <param name="argTrunkSanId"></param>
        /// <returns></returns>
        public static long InsertTrunkForImport(object argTrunkSymbol, object argTrunkNo, object argTrunkClass, object argTrunkRmId, object argTrunkSanId)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@TrunkSymbol", argTrunkSymbol, 
                "@TrunkNo", argTrunkNo,
                "@TrunkClass", argTrunkClass, 
                "@forTrunkRmId", argTrunkRmId,
                "@forTrunkSanId", argTrunkSanId
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.TRUNK_INSERT_FOR_IMPORT, lv_ArgArray);
            //
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returns value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argVtPortID"></param>
        /// <param name="argClass"></param>
        /// <param name="argNo"></param>
        /// <param name="argClass2"></param>
        /// <param name="argType"></param>
        /// <returns></returns>
        public static long GetVtPortDetailId(object argVtPortID, object argClass, object argNo, object argClass2, object argType)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@VTPortId", argVtPortID, 
                "@Class", argClass,
                "@No", argNo,
                "@Class2", argClass2,
                "@Type", argType
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.VTPORT_GET_DETAIL_ID, lv_ArgArray);
            // Converts 
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returnes value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argSymbol"></param>
        /// <param name="argUrmNo"></param>
        /// <param name="argTypeID"></param>
        /// <returns></returns>
        public static long InsertUrmForImport(object argSymbol, object argUrmNo, object argTypeID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@Symbol", argSymbol, 
                "@UrmNo", argUrmNo,
                "@TypeId", argTypeID
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.URM_INSERT_FOR_IMPORT, lv_ArgArray);
            //
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returns value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argRackID"></param>
        /// <param name="argSan"></param>
        /// <param name="argLcUrmID"></param>
        /// <param name="argBlechDetailID"></param>
        /// <param name="argTrunkDetailID"></param>
        /// <param name="argVtPortDetailID"></param>
        /// <param name="argUrmUrmID"></param>
        /// <returns></returns>
        public static long OnlyInsertRackDetail(object argRackID, object argSan, object argLcUrmID, object argBlechDetailID, object argTrunkDetailID, object argVtPortDetailID, object argUrmUrmID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@RackId", argRackID, 
                "@forSan", argSan,
                "@LcUrmId", argLcUrmID, 
                "@BlechDetailId", argBlechDetailID,
                "@TrunkDetailId", argTrunkDetailID,
                "@VTPortDetailId", argVtPortDetailID, 
                "@UrmUrmId", argUrmUrmID
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.RACK_DETAIL_INSERT_ONLY, lv_ArgArray);
            //
            retValue = 1;
            //
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argID"></param>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argObjID"></param>
        /// <param name="argConnObjID"></param>
        /// <param name="argConnName"></param>
        /// <param name="argProjectName"></param>
        /// <param name="argCustomer"></param>
        /// <returns></returns>
        public static long InsertConnection(object argID, object argLocationID, object argRoomID, object argObjID, object argConnObjID, object argConnName, object argProjectName, object argCustomer)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@Id", argID, 
                "@LocationId", argLocationID,
                "@RoomId", argRoomID, 
                "@ObjId", argObjID,
                "@ConnObjId", argConnObjID,
                "@ConnName", argConnName, 
                "@ProjectName", argProjectName,
                "@Customer", argCustomer
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.CONNECTION_INSERT, lv_ArgArray);
            //
            retValue = 1;
            //
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argID"></param>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argObjID"></param>
        /// <param name="argConnObjID"></param>
        /// <param name="argUrmUrmId"></param>
        /// <param name="argSanID"></param>
        /// <param name="argConnName"></param>
        /// <param name="argProjectName"></param>
        /// <param name="argCustomer"></param>
        /// <returns></returns>
        public static long InsertConnectionForImport(object argID, object argLocationID, object argRoomID, object argObjID, object argConnObjID, object argUrmUrmID, object argSanID, object argConnName, object argProjectName, object argCustomer)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@Id", argID, 
                "@LocationId", argLocationID,
                "@RoomId", argRoomID, 
                "@ObjId", argObjID,
                "@ConnObjId", argConnObjID,
                "@UrmUrmId", argUrmUrmID,
                "@SanId",argSanID,
                "@ConnName", argConnName, 
                "@ProjectName", argProjectName,
                "@Customer", argCustomer
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.CONNECTION_INSERT_FOR_IMPORT, lv_ArgArray);
            //
            retValue = 1;
            //
            return retValue;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="argID"></param>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argCoordinateID"></param>
        /// <param name="argSan1VtPortID"></param>
        /// <param name="argSan2VtPortID"></param>
        /// <param name="argBlechID"></param>
        /// <param name="argTrunkTypeID"></param>
        /// <param name="argConnValue"></param>
        /// <returns></returns>
        public static long OnlyInsertRack(object argID, object argLocationID, object argRoomID, object argCoordinateID, object argSan1VtPortID, object argSan2VtPortID, object argBlechID, object argTrunkTypeID, object argConnValue)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@Id", argID, 
                "@LocationId", argLocationID,
                "@RoomId", argRoomID, 
                "@CoordinateId", argCoordinateID,
                "@San1VTPortId", argSan1VtPortID,
                "@San2VTPortId", argSan2VtPortID, 
                "@BlechId", argBlechID,
                "@TrunkTypeId", argTrunkTypeID, 
                "@ConnValue", argConnValue
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.RACK_INSERT_ONLY, lv_ArgArray);
            //
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returns value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argSwitchID"></param>
        /// <param name="argPort"></param>
        /// <param name="argLcUrmID"></param>
        /// <param name="argBlechDetailID"></param>
        /// <param name="argTrunkDetailID"></param>
        /// <param name="argVtPortDetailID"></param>
        /// <param name="argUrmUrmID"></param>
        /// <param name="argTarget"></param>
        /// <returns></returns>
        public static long OnlyInsertSwitchDetail(object argSwitchID, object argPort, object argLcUrmID, object argBlechDetailID, object argTrunkDetailID, object argVtPortDetailID, object argUrmUrmID, object argTarget)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@SwId", argSwitchID, 
                "@Port", argPort,
                "@LcUrmId", argLcUrmID, 
                "@BlechDetailId", argBlechDetailID,
                "@TrunkDetailId", argTrunkDetailID,
                "@VTPortDetaild", argVtPortDetailID, 
                "@UrmUrmId", argUrmUrmID,
                "@Target", argTarget
            };

            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.SWITCH_DETAIL_INSERT_ONLY, lv_ArgArray);
            //
            retValue = 1;
            //
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <returns></returns>
        public static Dictionary<string, long> GetVtPortsForRackImport(object argLocationID, object argRoomID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@LcId", argLocationID, 
                "@RmId", argRoomID
            };
            // Return value variable
            Dictionary<string, long> retValue = new Dictionary<string, long>();
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.VTPORT_CHECK_IN_LOCATION, lv_ArgArray);
            // Adds San1 to the dictionary
            retValue.Add("San1", Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["VT1"].ToString()));
            // Adds San2 to the dictionary
            retValue.Add("San2", Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["VT2"].ToString()));

            // Returns value
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argLocationID"></param>
        /// <param name="argRoomID"></param>
        /// <param name="argCoordinateID"></param>
        /// <returns></returns>
        public static long BlechIdForRackImport(object argLocationID, object argRoomID, object argCoordinateID)
        {
            // Creates parameter array from arguments
            object[] lv_ArgArray = new object[] 
            { 
                "@LcId", argLocationID, 
                "@RmId", argRoomID,
                "@CrdId", argCoordinateID
            };
            // Return value variable
            long retValue;
            // New DataSet for return table from procedure
            DataSet lv_OutDataSet;
            //
            lv_OutDataSet = ExecProcedure(SPROC.BLECH_CHECK_IN_LOCATION, lv_ArgArray);
            // 
            retValue = Convert.ToInt64(lv_OutDataSet.Tables[lv_OutDataSet.Tables.Count - 1].Rows[0]["retValue"].ToString());
            // Returns value
            return retValue;
        }
    }
}
