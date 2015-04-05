using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void BackUp()
        {
            try
            {
                //Backup
                DateTime d = DateTime.Now;

                string filename = Data.Settings.DatabaseName + "_" + d.Day.ToString().PadLeft(2, '0') + d.Month.ToString().PadLeft(2, '0') + d.Year.ToString() +
                                  "_" + d.Hour.ToString().PadLeft(2, '0') + d.Minute.ToString().PadLeft(2, '0') + d.Second.ToString().PadLeft(2, '0') +
                                  d.Millisecond.ToString().PadLeft(4, '0') + ".bak";

                Server server = new Server(new ServerConnection(new System.Data.SqlClient.SqlConnection(Data.Settings.ConnectionString)));

                // Create a new backup operation
                Backup bkpDatabase = new Backup();

                // Set the backup type to a database backup
                bkpDatabase.Action = BackupActionType.Database;

                // Set the database that we want to perform a backup on
                bkpDatabase.Database = Data.Settings.DatabaseName;

                // Set the backup device to a file
                BackupDeviceItem bkpDevice = new BackupDeviceItem(filename, DeviceType.File);

                // Add the backup device to the backup
                bkpDatabase.Devices.Add(bkpDevice);

                // Perform the backup
                bkpDatabase.SqlBackup(server);

                //this.progressBarControl1.Position = 0;
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportToDB()
        {
            //progressBarControl1
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Properties.Maximum = listLocation.Count + listDataCenter.Count + listDataCenter1.Count + listDataCenter2.Count +
                listCoordinate.Count + listTrunkGrouped.Count + listLcUrmJumperGrouped.Count + listUrmUrmJumperGrouped.Count + listBlechGrouped.Count +
                listVtPort1Grouped.Count + listVtPort2Grouped.Count + listServerGrouped.Count + listServerAll.Count + listDasdGrouped.Count +
                listDasdAll.Count + listSwitchGrouped.Count + listSwitchAll.Count + listDccGrouped.Count + listDccAll.Count + 30;
            progressBarControl1.Properties.Step = 1;
            //progressBarControl1

            MakeProgress(10);

            //Backup current DB
            BackUp();
            MakeProgress(10);

            //Delete current DB data
            DBAssistant.ExecProcedure(sproc.Full_Delete);
            MakeProgress(10);

            int total = listLocation.Count;
            int i = 0;
            Debug.Write("-----Location");
            Debug.Write(Environment.NewLine);
            foreach (var item in listLocation)
            {
                i++;
                Debug.Write("-----Location-----" + item.Name + " (" + i.ToString() + " / " + total.ToString() + ")");
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.Location_Insert, new object[] { "@Prefix", item.Prefix, "@Name", item.Name });
                MakeProgress(1);
            }

            total = listDataCenter.Count;
            i = 0;
            Debug.Write("-----DataCenter");
            Debug.Write(Environment.NewLine);
            foreach (var item in listDataCenter)
            {
                i++;
                Debug.Write("-----DataCenter-----" + item.Name + " (" + i.ToString() + " / " + total.ToString() + ")");
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.DataCenter_Insert_WithLocationName, new object[] { "@LocationName", String.IsNullOrEmpty(item.Location) ? "04" : item.Location, "@Name", item.Name });
                MakeProgress(1);
            }

            foreach (var item in listDataCenter1)
            {
                i++;
                Debug.Write("-----DataCenter1-----" + item.Name + " (" + i.ToString() + " / " + total.ToString() + ")");
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.DataCenter_Insert_WithLocationName, new object[] { "@LocationName", String.IsNullOrEmpty(item.Location) ? "04" : item.Location, "@Name", item.Name });
                MakeProgress(1);
            }

            foreach (var item in listDataCenter2)
            {
                i++;
                Debug.Write("-----DataCenter2-----" + item.Name + " (" + i.ToString() + " / " + total.ToString() + ")");
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.DataCenter_Insert_WithLocationName, new object[] { "@LocationName", String.IsNullOrEmpty(item.Location) ? "04" : item.Location, "@Name", item.Name });
                MakeProgress(1);
            }

            total = listCoordinate.Count;
            i = 0;
            Debug.Write("-----Coordinate");
            Debug.Write(Environment.NewLine);
            foreach (var item in listCoordinate)
            {
                i++;
                Debug.Write("-----Coordinate-----" + item.Name + " (" + i.ToString() + " / " + total.ToString() + ")");
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.Coordinate_Insert_WithDataCenterName, new object[] { "@DataCenterName", item.DataCenter, "@Name", item.Name });
                MakeProgress(1);
            }

            //foreach (var item in listOS)
            //{
            //    DBAssistant.ExecProcedure(sproc.OS_Insert, new object[] { "@Name", item.Name });
            //}

            //foreach (var item in listSwitchModel)
            //{
            //    DBAssistant.ExecProcedure(sproc.SwitchModel_Insert, new object[] { "@Name", item.Name, "@PortCount", item.PortCount });
            //}

            foreach (var item in listTrunkGrouped)
            {
                DBAssistant.ExecProcedure(sproc.Cable_Insert_Specific, new object[] { "@CableModelID", 0, "@CableSymbol", item.Symbol, "@CableNumber", item.Number, "@Count", item.Count });
                MakeProgress(1);
            }

            foreach (var item in listLcUrmJumperGrouped)
            {
                DBAssistant.ExecProcedure(sproc.Cable_Insert_Specific, new object[] { "@CableModelID", 14, "@CableSymbol", item.Symbol, "@CableNumber", item.Number, "@Count", item.Count });
                MakeProgress(1);
            }

            foreach (var item in listUrmUrmJumperGrouped)
            {
                DBAssistant.ExecProcedure(sproc.Cable_Insert_Specific, new object[] { "@CableModelID", 15, "@CableSymbol", item.Symbol, "@CableNumber", item.Number, "@Count", item.Count });
                MakeProgress(1);
            }

            foreach (var item in listBlechGrouped)
            {
                DBAssistant.ExecProcedure(sproc.Blech_Insert_forImport, new object[] { "@DataCenterName", item.Room, "@CoordinateName", item.Coordinate, "@DeviceName", item.BlechType.ToString(), "@SanName", (item.San == String.Empty ? "" : (item.San == "01" ? "SAN 1" : "SAN 2")) });
                MakeProgress(1);
            }

            foreach (var item in listVtPortGrouped)
            {
                DBAssistant.ExecProcedure(sproc.VTPort_Insert_forImport, new object[] { "@DataCenterName", item.Room, "@SanName", (item.San == "02" ? "SAN 1" : (item.San == "12" ? "SAN 2" : (item.San == "03" ? "SAN 3" : "SAN 4"))) });
                MakeProgress(1);
            }

            foreach (var item in listVtPort1Grouped)
            {
                DBAssistant.ExecProcedure(sproc.VTPort_Insert_forImport, new object[] { "@DataCenterName", item.Room, "@SanName", (item.San == "02" ? "SAN 1" : (item.San == "12" ? "SAN 2" : (item.San == "03" ? "SAN 3" : "SAN 4"))) });
                MakeProgress(1);
            }

            foreach (var item in listVtPort2Grouped)
            {
                DBAssistant.ExecProcedure(sproc.VTPort_Insert_forImport, new object[] { "@DataCenterName", item.Room, "@SanName", (item.San == "02" ? "SAN 1" : (item.San == "12" ? "SAN 2" : (item.San == "03" ? "SAN 3" : "SAN 4"))) });
                MakeProgress(1);
            }

            foreach (var item in listServerGrouped)
            {
                Debug.Write(item.BlechName);
                Debug.Write(Environment.NewLine);
                if (!string.IsNullOrEmpty(item.BlechName))
                    DBAssistant.ExecProcedure(sproc.Server_Insert_forImport, new object[] { "@BlechName", item.BlechName, "@PortCount", item.PortCount, "@OsName", item.OperatingSystem });
                else
                    DBAssistant.ExecProcedure(sproc.Server_Insert_forImport, new object[] { "@BlechName", item.Name, "@PortCount", item.PortCount, "@OsName", item.OperatingSystem });
                MakeProgress(1);
            }

            foreach (var item in listServerAll)
            {
                DBAssistant.ExecProcedure(sproc.ServerDetail_Insert_forImport, new object[] { "@Name", item.Name,
              "@LcUrmSymbol", item.LcUrmSymbol, "@LcUrmNo", item.LcUrmNo, "@BlechClass1", item.BlechClass1, "@BlechNo", item.BlechNo,
              "@BlechClass2", item.BlechClass2, "@TrunkSymbol", item.TrunkSymbol, "@TrunkNo", item.TrunkNo, "@TrunkClass", item.TrunkClass,
              "@VtPortName", item.VtPortName,"@VTPortClass1", item.VtPortClass1, "@VTPortNo", item.VtPortNo, "@VTPortClass2", item.VtPortClass2, "@UrmUrmSymbol", item.UrmUrmSymbol,
              "@UrmUrmNo", item.UrmUrmNo});
                MakeProgress(1);
            }
            foreach (var item in listDasdGrouped)
            {
                DBAssistant.ExecProcedure(sproc.DASD_Insert_forImport, new object[] { "@BlechName", item.BlechName, "CuType", item.Model });
                MakeProgress(1);
            }

            foreach (var item in listDasdAll)
            {
                DBAssistant.ExecProcedure(sproc.DASDDetail_Insert_forImport, new object[] { "@Name", item.Name, "@Port", item.Port,
              "@LcUrmSymbol", item.LcUrmSymbol, "@LcUrmNo", item.LcUrmNo, "@BlechClass1", item.BlechClass1, "@BlechNo", item.BlechNo,
              "@BlechClass2", item.BlechClass2, "@TrunkSymbol", item.TrunkSymbol, "@TrunkNo", item.TrunkNo, "@TrunkClass", item.TrunkClass,
              "@VtPortName", item.VtPortName, "@VTPortClass1", item.VtPortClass1, "@VTPortNo", item.VtPortNo, "@VTPortClass2", item.VtPortClass2, "@UrmUrmSymbol", item.UrmUrmSymbol,
              "@UrmUrmNo", item.UrmUrmNo});
                MakeProgress(1);
            }

            foreach (var item in listSwitchGrouped)
            {
                if (item.CoreSwitchName != null)
                {
                    DBAssistant.ExecProcedure(sproc.Switch_Insert_forImport, new object[] { 
                    "@VTPortName", item.VtPortName, 
                    "@BlechName", item.BlechName, 
                    "@SwitchTypeValue", item.SwitchType, 
                    "@SwitchModelName", item.Model, 
                    "@CoreSwitchName", item.CoreSwitchName });
                }
                else
                {
                    DBAssistant.ExecProcedure(sproc.Switch_Insert_forImport, new object[] { 
                    "@VTPortName", item.VtPortName, 
                    "@BlechName", item.BlechName, 
                    "@SwitchTypeValue", item.SwitchType, 
                    "@SwitchModelName", item.Model, 
                    "@CoreSwitchName", "" });
                }
                MakeProgress(1);
            }

            foreach (var item in listSwitchAll)
            {
                DBAssistant.ExecProcedure(sproc.SwitchDetail_Insert_forImport, new object[] { "@Name", item.Name, "@Port", item.Port, 
                               "@LcUrmSymbol", item.LcUrmSymbol, "@LcUrmNo", item.LcUrmNo, "@BlechClass1", item.BlechClass1, "@BlechNo", item.BlechNo,
                               "@BlechClass2", item.BlechClass2, "@TrunkSymbol", item.TrunkSymbol, "@TrunkNo", item.TrunkNo, "@TrunkClass", item.TrunkClass,
                               "@VTPortClass1", item.VtPortClass1, "@VTPortNo", item.VtPortNo, "@VTPortClass2", item.VtPortClass2, "@UrmUrmSymbol", item.UrmUrmSymbol,
                               "@UrmUrmNo", item.UrmUrmNo, "@Target", item.ConnectionName});
                MakeProgress(1);
            }

            foreach (var item in listDccGrouped)
            {
                Debug.Write(item.Name);
                Debug.Write(Environment.NewLine);
                DBAssistant.ExecProcedure(sproc.Dcc_Insert_forImport, new object[] { "@Name", item.Name, "@VTPort1Name", item.VTPort1Name, "@VTPort2Name", item.VTPort2Name, "@PortCount", item.PortCount });
                MakeProgress(1);
            }

            foreach (var item in listDccAll)
            {
                DBAssistant.ExecProcedure(sproc.DccDetail_Insert_forImport, new object[] { "@Name", item.Name,
              "@LcUrmSymbol", item.LcUrmSymbol, "@LcUrmNo", item.LcUrmNo, "@TrunkSymbol", item.TrunkSymbol, "@TrunkNo", item.TrunkNo,
              "@TrunkClass", item.TrunkClass, "@VTPort1Class1", item.VtPort1Class1, "@VTPort1No", item.VtPort1No, "@VTPort1Class2", item.VtPort1Class2,
              "@VTPort2Class1", item.VtPort2Class1,"@VTPort2No", item.VtPort2No, "@VTPort2Class2", item.VtPort2Class2, "@UrmUrmSymbol", item.UrmUrmSymbol, 
              "@UrmUrmNo", item.UrmUrmNo, "@VTPort1Name", item.VtPort1Name, "@VTPort2Name", item.VtPort2Name});
                MakeProgress(1);
            }

            progressBarControl1.Position = 0;

            XtraMessageBox.Show("Import finished...Application will be restarted!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Restart();
        }
    }
}
