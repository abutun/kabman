using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using KabMan.Extensions;
using KabMan.Text;
using userSettings = KabMan.Properties.Settings;

namespace KabMan.Import
{
    public class GridViewCellValidator
    {

        #region Constructors

        #endregion

        #region Constants


        #endregion

        #region Fields



        #endregion

        #region Properties



        #endregion

        #region Methods

        public static void ValidateSwitchCells(ref object sender, ref RowCellStyleEventArgs e)
        {
            object columnValue = ((GridView)sender).GetRowCellValue(e.RowHandle, e.Column);
            Dictionary<string, string> columns = userSettings.Default.ImportSwitchPageColumns.ToDictionary();
            if (columns["LcUrm"].Equals(e.Column.FieldName))
            {
                SetGridCellErrorAppearance(ref e, columnValue, regex.JumperCableAcronym);
            }
            else if (columns["Blech"].Equals(e.Column.FieldName))
            {
                SetGridCellErrorAppearance(ref e, columnValue, regex.BlechAcronym);
            }
            else if (columns["Trunk"].Equals(e.Column.FieldName))
            {
                SetGridCellErrorAppearance(ref e, columnValue, regex.TrunkCableAcronym);
            }
            else if (columns["VtPort"].Equals(e.Column.FieldName))
            {
                SetGridCellErrorAppearance(ref e, columnValue, regex.VtPortAcronym);
            }
            else if (columns["UrmUrm"].Equals(e.Column.FieldName))
            {
                SetGridCellErrorAppearance(ref e, columnValue, regex.JumperCableAcronym);
            }
        }

        public static GridCellValueErrorStates SetGridCellErrorAppearance(ref RowCellStyleEventArgs e, object argColumnValue, string argRegex)
        {
            if (string.IsNullOrEmpty(argColumnValue.ToString()))
            {
                e.Appearance.BackColor = Color.Orange;
                return GridCellValueErrorStates.Warning;
            }
            else if (!RegexAssistant.RegexMatched(argRegex, argColumnValue.ToString()))
            {
                e.Appearance.BackColor = Color.Red;
                return GridCellValueErrorStates.Error;
            }
            return GridCellValueErrorStates.None;
        }

        #endregion

    }
}
