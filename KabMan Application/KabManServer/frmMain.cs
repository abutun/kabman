using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using SNMPDll;
using System.Diagnostics;

namespace KabMan.Server
{
    public partial class frmMain : Form
    {
        private DataSet ds;
        private bool stop;

        private SNMPAgent a;

        public frmMain()
        {
            Icon = KabManSrv.Properties.Resources.clients;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            itemStop.Enabled = false;

            Width = Convert.ToInt32(RegistryHelper.GetSetting("Layout", "Width", "800"));
            Height = Convert.ToInt32(RegistryHelper.GetSetting("Layout", "Height", "500"));
            Top = Convert.ToInt32(RegistryHelper.GetSetting("Layout", "Top", "100"));
            Left = Convert.ToInt32(RegistryHelper.GetSetting("Layout", "Left", "100"));

            tmAutoStartControl.Enabled = true;
        }

        private void InitData()
        {
            GetInnerTextBox(memConsole).AppendText("Loading switches...\r\n");

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT s.ID, s.[Name], ISNULL(st.[SwitchType_ID],1) AS SwitchType_ID, Ip_No, PortCount, sm.MibId, o.*  FROM [Switch].[Switch] s ");
            sb.Append(" LEFT JOIN [Switch].[SwitchDetail] sd ON sd.ID = s.ID ");
            sb.Append(" LEFT JOIN [Switch].[SwitchModel] sm ON sm.ID = s.SwitchModel_ID ");
            sb.Append(" LEFT JOIN tblOIDTable o ON o.MibId = sm.MibId ");
            sb.Append(" LEFT JOIN [Switch].[SwitchTypes] st ON s.ID = st.SwitchID ");
            sb.Append(" WHERE s.[_Deleted] = 0 ");

            using (DatabaseLib data = new DatabaseLib())
            {
                data.RunSqlQuery(sb.ToString(), out ds);
            }
        }

        private static TextBox GetInnerTextBox(DevExpress.XtraEditors.TextEdit editor)
        {
            if (editor != null)
                Thread.Sleep(600);
            Application.DoEvents();
            foreach (Control control in editor.Controls)
                if (control is TextBox)
                    return (TextBox)control;
            return null;
        }

        private void itemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }

        private void itemConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmConfig f = new frmConfig(this);
            f.ShowDialog();
            f.Dispose();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryHelper.SaveSetting("Layout", "Width", Width.ToString());
            RegistryHelper.SaveSetting("Layout", "Height", Height.ToString());
            RegistryHelper.SaveSetting("Layout", "Top", Top.ToString());
            RegistryHelper.SaveSetting("Layout", "Left", Left.ToString());
        }

        private void itemStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            memConsole.Text = null;
            stop = false;

            itemStart.Enabled = false;
            itemStop.Enabled = true;

            InitData();

            CheckSwitches();
        }

        private string TypeOID(int row)
        {
            try
            {
                SNMPObject myRequest = new SNMPObject(ds.Tables[0].Rows[row]["Type_OID"].ToString());
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string SwitchName(int row)
        {
            try
            {
                SNMPObject myRequest = new SNMPObject(ds.Tables[0].Rows[row]["SwitchName_OID"].ToString());
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string Firmware(int row)
        {
            try
            {
                SNMPObject myRequest = new SNMPObject(ds.Tables[0].Rows[row]["Firmware_OID"].ToString());
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string SerialNumber(int row)
        {
            try
            {
                SNMPObject myRequest = new SNMPObject(ds.Tables[0].Rows[row]["SerialNumber_OID"].ToString());
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string Location()
        {
            try
            {
                SNMPObject myRequest = new SNMPObject("1.3.6.1.2.1.1.6.0");
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string Contact()
        {
            try
            {
                SNMPObject myRequest = new SNMPObject("1.3.6.1.2.1.1.4.0");
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetWWNNo(int row, int portNo)
        {
            SNMPObject myRequest = new SNMPObject(string.Format("{0}.{1}", ds.Tables[0].Rows[row]["Port_OID"].ToString(), portNo));

            string b = myRequest.getSimpleValue(a);
            return ToHexString(StrToByteArray(b));
        }

        public static byte[] StrToByteArray(string str)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        static char[] hexDigits = {
                                      '0', '1', '2', '3', '4', '5', '6', '7',
                                      '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
                                  };

        public static string ToHexString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length * 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }
            return new string(chars);
        }

        private string GetState(int row, int portNo)
        {
            try
            {
                SNMPObject myRequest = new SNMPObject(string.Format("{0}.{1}", ds.Tables[0].Rows[row]["State_OID"].ToString(), portNo));
                //SNMPObject myRequest = new SNMPObject("1.3.6.1.2.1.1.4.0");    
                Debug.WriteLine(string.Format("{0}.{1}", ds.Tables[0].Rows[row]["State_OID"].ToString(), portNo));
                return myRequest.getSimpleValue(a);
            }
            catch (Exception)
            {
                return "0";
            }
        }

        private void CheckSwitches()
        {
            GetInnerTextBox(memConsole).AppendText("Checkin Switches...\r\n");

            int i = 0;
            timer.Enabled = false;

            timer.Interval = Convert.ToInt32(RegistryHelper.GetSetting("Config", "Minute", "10")) * 60000;

            while (i < ds.Tables[0].DefaultView.Count)
            {
                Application.DoEvents();

                if (stop) return;

                if (!string.IsNullOrEmpty(ds.Tables[0].Rows[i]["Ip_No"].ToString()))
                {
                    //connection snmp
                    a = new SNMPAgent(ds.Tables[0].Rows[i]["Ip_No"].ToString(), "public", "public");

                    //string[] arr = GetSwitchInfo(i);

                    GetInnerTextBox(memConsole).AppendText("=================================================================================================\r\n");
                    GetInnerTextBox(memConsole).AppendText(String.Format("KabMan Switch Name:{0} Type:{1} Return Switch Name:{2} Firmware:{3} SerialNumber:{4} Location:{5} Contact:{6}   \r\n", ds.Tables[0].Rows[i]["Name"], TypeOID(i), SwitchName(i), Firmware(i), SerialNumber(i), Location(), Contact()));
                    using (DatabaseLib data = new DatabaseLib())
                    {
                        data.RunSqlQuery(string.Format("UPDATE Switch.Switch SET Type='{0}', ReturnSwitchName='{1}', Firmware='{2}', SerialNo='{3}', Location='{4}', Contact='{5}'  WHERE ID={6}", TypeOID(i), SwitchName(i), Firmware(i), SerialNumber(i), Location(), Contact(), ds.Tables[0].Rows[i]["ID"]));
                    }

                    using (DatabaseLib dataPort = new DatabaseLib())
                    {
                        DataSet dsPort;
                        dataPort.RunSqlQuery(string.Format("SELECT ID, PortNo FROM Switch.SwitchDetail WHERE Switch_ID = {0}  AND [_Deleted] = 0 ORDER BY CONVERT(INT, PortNo) asc", ds.Tables[0].Rows[i]["ID"]), out dsPort);

                        int j = 0;
                        while (j < dsPort.Tables[0].DefaultView.Count)
                        {
                            Application.DoEvents();

                            if (stop) return;

                            string wwn = GetWWNNo(i, Convert.ToInt32(dsPort.Tables[0].Rows[j]["PortNo"]) + 1);
                            string state = GetState(i, Convert.ToInt32(dsPort.Tables[0].Rows[j]["PortNo"]) + 1);

                            //write to console
                            GetInnerTextBox(memConsole).AppendText(String.Format("Switch: {0} Port No: {1} WWN: {2} State: {3}\r\n", ds.Tables[0].Rows[i]["Name"], (Convert.ToInt32(dsPort.Tables[0].Rows[j]["PortNo"]) + 1).ToString(), wwn, GetPortStateTitle(int.Parse(ds.Tables[0].Rows[i]["SwitchType_ID"].ToString()), int.Parse(state))));

                            //update to database
                            using (DatabaseLib data = new DatabaseLib())
                            {
                                data.RunSqlQuery(string.Format("UPDATE Switch.SwitchDetail SET pWWN='{0}', PortState='{1}' WHERE ID={2}", wwn, state, dsPort.Tables[0].Rows[j]["ID"]));
                            }

                            Thread.Sleep(300);

                            j++;
                        }
                        GetInnerTextBox(memConsole).AppendText("=================================================================================================\r\n");
                    }
                }
                else
                {
                    GetInnerTextBox(memConsole).AppendText(String.Format("{0}: Switch does not have IP\r\n", ds.Tables[0].Rows[i]["Name"]));
                }

                i++;
            }

            timer.Enabled = true;
        }

        private string GetPortStateTitle(int type, int state)
        {
            string res = "";

            DataSet dsState = new DataSet();

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("	 SELECT * FROM dbo.tblPortState WHERE TypId = " + type.ToString() + " AND PortStateId = " + state.ToString() + "");

                using (DatabaseLib data = new DatabaseLib())
                {
                    data.RunSqlQuery(sb.ToString(), out dsState);
                }

                if (dsState != null)
                {
                    if (dsState.Tables.Count > 0)
                    {
                        if (dsState.Tables[0].Rows.Count > 0)
                            res = dsState.Tables[0].Rows[0]["PortStateTitle"].ToString();
                        else
                            res = "State Title Not Found!";
                    }
                }
            }
            catch
            {
                res = "Unknown State";
            }

            return res;
        }

        private void itemStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stop = true;

            itemStart.Enabled = true;
            itemStop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            itemStart_ItemClick(sender, null);
        }

        private void tmAutoStartControl_Tick(object sender, EventArgs e)
        {
            tmAutoStartControl.Enabled = false;

            if (!string.IsNullOrEmpty(RegistryHelper.GetSetting("Config", "AutoStart", null)))
            {
                Thread.Sleep(2000);
                if (Convert.ToBoolean(RegistryHelper.GetSetting("Config", "AutoStart", null)))
                    itemStart_ItemClick(sender, null);
            }
        }
    }
}
