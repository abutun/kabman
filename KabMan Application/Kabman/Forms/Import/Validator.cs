using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using KabMan.Extensions;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;

namespace KabMan.Forms
{
    partial class ExcelImportForm
    {

        #region Fields

        ImportFilesPathValidator importValidator;

        #endregion

        #region Fired Events

        private void CSwitchView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridViewCellValidator.ValidateSwitchCells(ref sender, ref e);
        }

        #endregion

        #region Methods

        private void ValidatePageColumns()
        {
            ValidatePageColumns("Switch", userSettings.Default.ImportSwitchPageColumns.ToDictionary(), ref switchDataSet);
            ValidatePageColumns("Server", userSettings.Default.ImportServerPageColumns.ToDictionary(), ref serverDataSet);
            ValidatePageColumns("Dasd", userSettings.Default.ImportDasdPageColumns.ToDictionary(), ref dasdDataSet);
            ValidatePageColumns("Dcc", userSettings.Default.ImportDccPageColumns.ToDictionary(), ref dccDataSet);
        }

        private void ValidatePageColumns(string argCategory, Dictionary<string, string> argColumnList, ref DataSet argDataSet)
        {
            for (int i = 0; i < argDataSet.Tables.Count; i++)
            {
                if (!argDataSet.Tables[i].Columns.ContainsAll(argColumnList.Values.ToArray()))
                {
                    AddError(argCategory, "Excel page does not contain all necessary columns " + argColumnList.Values.ToStringList(), argDataSet.Tables[i].TableName);
                }
            }
        }

        #endregion

    }
}
