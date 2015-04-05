using System.Data;
using KabMan.Import;
using KabMan.Text;
using System.Linq;
using System.Diagnostics;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {

        #region Methods

        private void FillWithWorksheets()
        {
            Stopwatch watcher = Stopwatch.StartNew();
            CSwitchExcelPages.Properties.DataSource = this.GetWorkSheetsTable("Switch", importValidator.SwitchFilePath, regex.SwitchPageName);
            CSwitchExcelPages.Properties.DisplayMember = "DisplayName";
            CSwitchExcelPages.Properties.ValueMember = "PageName";
            CSwitchExcelPages.Properties.View.BestFitColumns();
            switchDataSet = this.GetExcelDataSet(importValidator.SwitchFilePath);
            watcher.Stop();
            Debug.WriteLine(string.Format("Loading Switch file took {0}", watcher.Elapsed));

            watcher = Stopwatch.StartNew();
            CRackExcelPages.Properties.DataSource = this.GetWorkSheetsTable("Server", importValidator.ServerFilePath, regex.ServerPageName);
            CRackExcelPages.Properties.DisplayMember = "DisplayName";
            CRackExcelPages.Properties.ValueMember = "PageName";
            CRackExcelPages.Properties.View.BestFitColumns();
            serverDataSet = this.GetExcelDataSet(importValidator.ServerFilePath);
            watcher.Stop();
            Debug.WriteLine(string.Format("Loading Server file took {0}", watcher.Elapsed));

            watcher = Stopwatch.StartNew();
            CDasdExcelPages.Properties.DataSource = this.GetWorkSheetsTable("Dasd", importValidator.DasdFilePath, regex.DasdPageName);
            CDasdExcelPages.Properties.DisplayMember = "DisplayName";
            CDasdExcelPages.Properties.ValueMember = "PageName";
            CDasdExcelPages.Properties.View.BestFitColumns();
            dasdDataSet = this.GetExcelDataSet(importValidator.DasdFilePath);
            watcher.Stop();
            Debug.WriteLine(string.Format("Loading Dasd file took {0}", watcher.Elapsed));

            watcher = Stopwatch.StartNew();
            CDCCExcelPages.Properties.DataSource = this.GetWorkSheetsTable("DCC", importValidator.DCCFilePath, regex.DccPageName);
            CDCCExcelPages.Properties.DisplayMember = "DisplayName";
            CDCCExcelPages.Properties.ValueMember = "PageName";
            CDCCExcelPages.Properties.View.BestFitColumns();
            dccDataSet = this.GetExcelDataSet(importValidator.DCCFilePath);
            watcher.Stop();
            Debug.WriteLine(string.Format("Loading DCC file took {0}", watcher.Elapsed));
        }

        private DataTable GetWorkSheetsTable(string argCategory, string argFilePath, string argRegex)
        {
            DataTable retValue = new DataTable("_ExcelPages");
            var connector = new ExcelConnector(argFilePath);

            DataTable worksheets = connector.GetWorksheets();

            retValue.Columns.Add("Valid", typeof(bool));
            retValue.Columns.Add("DisplayName", typeof(string));
            retValue.Columns.Add("PageName", typeof(string));

            for (int i = 0; i < worksheets.Rows.Count; i++)
            {
                string pageName = worksheets.Rows[i]["TABLE_NAME"].ToString();

                if (!pageName.Replace(" ", "").Replace("'", "").EndsWith("$"))
                    continue;

                string displayName = pageName.Replace(" ", "").Replace("'", "");

                bool valid = RegexAssistant.RegexMatched(argRegex, displayName);

                if (!valid)
                {
                    this.AddWarning(argCategory, "Page name could not be validated.", pageName, null, null);
                }

                DataRow row = retValue.NewRow();
                row.ItemArray = new object[] { valid, displayName.Replace("$", ""), pageName };
                retValue.Rows.Add(row);

            }
            retValue.DefaultView.Sort = "Valid DESC, DisplayName ASC";
            return retValue;
        }

        private DataSet GetExcelDataSet(string argFilePath)
        {
            DataSet retValue = new DataSet();
            var connector = new ExcelConnector(argFilePath);

            DataTable worksheets = connector.GetWorksheets();

            for (int i = 0; i < worksheets.Rows.Count; i++)
            {
                string pageName = worksheets.Rows[i]["TABLE_NAME"].ToString();

                if (pageName.Replace(" ", "").Replace("'", "").EndsWith("$"))
                {
                    DataTable pageTable = connector.GetDataPage(pageName);
                    pageTable.TableName = pageName;
                    retValue.Tables.Add(pageTable);
                }
            }

            return retValue;
        }

        #endregion
    }
}
