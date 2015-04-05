using System;
using System.Collections.Generic;
using System.Data;
using KabMan.Extensions;
using userSettings = KabMan.Properties.Settings;

namespace KabMan.Forms
{

    public partial class ExcelImportForm
    {

        #region Fields

        private DataTable errorDataTable;

        private DataRow focusedErrorRow = null;

        #endregion

        #region Fields

        private void ReCreateErrorTable()
        {

            errorDataTable = new DataTable();
            errorDataTable.Columns.Clear();

            errorDataTable.Columns.Add("ErrorType", typeof(string));
            errorDataTable.Columns.Add("No", typeof(int));
            errorDataTable.Columns.Add("Category", typeof(string));
            errorDataTable.Columns.Add("Description", typeof(string));
            errorDataTable.Columns.Add("Object", typeof(string));
            errorDataTable.Columns.Add("Line", typeof(string));
            errorDataTable.Columns.Add("Column", typeof(string));
        }

        #endregion

        #region Fired Events

        private void CErrorListView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            focusedErrorRow = CErrorListView.GetDataRow(e.FocusedRowHandle);
        }

        private void CErrorListView_DoubleClick(object sender, EventArgs e)
        {
            if (focusedErrorRow != null)
            {
                if (!string.IsNullOrEmpty(focusedErrorRow["Object"].ToString()))
                {
                    switch (focusedErrorRow["Category"].ToString())
                    {
                        case "Switch":
                            CTabControl.SelectedTabPageIndex = 0;
                            CSwitchExcelPages.EditValue = focusedErrorRow["Object"];
                            break;
                        case "Server":
                            CTabControl.SelectedTabPageIndex = 1;
                            CRackExcelPages.EditValue = focusedErrorRow["Object"];
                            break;
                        case "Dasd":
                            CTabControl.SelectedTabPageIndex = 2;
                            CDasdExcelPages.EditValue = focusedErrorRow["Object"];
                            break;
                        case "Dcc":
                            CTabControl.SelectedTabPageIndex = 3;
                            CDCCExcelPages.EditValue = focusedErrorRow["Object"];
                            break;
                    }
                }
            }
            focusedErrorRow = null;
        }

        #endregion

        #region Methods

        #region AddError

        private void AddError(string argCategory, string argDescription)
        {
            AddError(argCategory, argDescription, null);
        }

        private void AddError(string argCategory, string argDescription, string argObject)
        {
            AddError(argCategory, argDescription, argObject, null, null);
        }

        private void AddError(string argCategory, string argDescription, string argObject, string argLine, string argColumn)
        {
            if (errorDataTable == null)
            {
                ReCreateErrorTable();
            }
            DataRow row = errorDataTable.NewRow();

            row.ItemArray = new object[] { "Error", errorDataTable.Rows.Count + 1, argCategory, argDescription, argObject, argLine, argColumn };
            errorDataTable.Rows.Add(row);
            CToggleErrors.Text = string.Format("{0} Errors", errorDataTable.Select("ErrorType = 'Error'").Length.ToString());
        }

        #endregion

        #region AddWarning

        private void AddWarning(string argCategory, string argDescription)
        {
            AddWarning(argCategory, argDescription, null);
        }

        private void AddWarning(string argCategory, string argDescription, string argObject)
        {
            AddWarning(argCategory, argDescription, argObject, null, null);
        }

        private void AddWarning(string argCategory, string argDescription, string argObject, string argLine, string argColumn)
        {
            if (errorDataTable == null)
            {
                ReCreateErrorTable();
            }
            DataRow row = errorDataTable.NewRow();

            row.ItemArray = new object[] { "Warning", errorDataTable.Rows.Count + 1, argCategory, argDescription, argObject, argLine, argColumn };
            errorDataTable.Rows.Add(row);
            CToggleWarnings.Text = string.Format("{0} Warnings", errorDataTable.Select("ErrorType = 'Warning'").Length.ToString());
        }

        #endregion

        #region AddMessage

        private void AddMessage(string argCategory, string argDescription)
        {
            AddMessage(argCategory, argDescription, null);
        }

        private void AddMessage(string argCategory, string argDescription, string argObject)
        {
            AddMessage(argCategory, argDescription, argObject, null, null);
        }

        private void AddMessage(string argCategory, string argDescription, string argObject, string argLine, string argColumn)
        {
            if (errorDataTable == null)
            {
                ReCreateErrorTable();
            }
            DataRow row = errorDataTable.NewRow();

            row.ItemArray = new object[] { "Message", errorDataTable.Rows.Count + 1, argCategory, argDescription, argObject, argLine, argColumn };
            errorDataTable.Rows.Add(row);
            CToggleMessages.Text = string.Format("{0} Messages", errorDataTable.Select("ErrorType = 'Message'").Length.ToString());
        }

        #endregion


        private void CToggleErrors_CheckedChanged(object sender, EventArgs e)
        {
            FilterErrorList();
        }

        private void FilterErrorList()
        {
            if (errorDataTable == null)
            {
                ReCreateErrorTable();
            }
            string filterTemplate = "ErrorType = '{0}' OR ";
            string filter = "";
            if (CToggleErrors.Checked)
            {
                filter += string.Format(filterTemplate, "Error");
            }
            if (CToggleWarnings.Checked)
            {
                filter += string.Format(filterTemplate, "Warning");
            }
            if (CToggleMessages.Checked)
            {
                filter += string.Format(filterTemplate, "Message");
            }
            if (string.IsNullOrEmpty(filter))
            {
                filter = string.Format(filterTemplate, "NULL");
            }
            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.Remove(filter.LastIndexOf(" OR "), 4);
            }

            errorDataTable.DefaultView.RowFilter = filter;

        }

        private void AddImportPathError()
        {
            List<string> fileNames = new List<string>
                    (
                        new string[]
                        {
                            userSettings.Default.ImportSwitchFileName,
                            userSettings.Default.ImportServerFileName,
                            userSettings.Default.ImportDasdFileName,
                            userSettings.Default.ImportDccFileName
                        }
                    );


            AddError("Import Path", "Selected path does not contains all files. Be sure directory contains all files or file names are correct. " + importValidator.Directory + ". " + fileNames.ToStringList());
        }

        #endregion




    }
}
