using System;
using KabMan.Data;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using KabMan.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace KabMan.Forms
{
    public partial class SwitchDetailManagerForm : DevExpress.XtraEditors.XtraForm
    {

        #region Properties

        private object _SwitchID = null;
        /// <summary>
        /// Gets Rack ID which associated to this form
        /// </summary>
        public long SwitchID
        {
            get
            {
                if (_SwitchID != null)
                {
                    return Convert.ToInt64(this._SwitchID);
                }
                return 0;
            }
        }



        #endregion

        #region Constructor

        public SwitchDetailManagerForm()
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            InitializeComponent();
            this._SwitchID = 14;
        }

        public SwitchDetailManagerForm(object argSwitchID)
        {
            this.Icon = Resources.GetIcon("KabManIcon");
            this._SwitchID = argSwitchID;            
            InitializeComponent();
        }

        public SwitchDetailManagerForm(object argSwitchID, string text)
        {
            this._SwitchID = argSwitchID;
            InitializeComponent();
            this.Text = text;
        }

       
        #endregion

        private void SwitchDetailManagerForm_Load(object sender, EventArgs e)
        {
            if (this.SwitchID > 0)
            {
                CSwitchGrid.DataSource = DBAssistant.ExecProcedure(sproc.SwitchDetail_Select_BySwitchID, new object[] { "@SwitchID", this.SwitchID }).Tables[0];
                setLcUrmRepositoryDataSource();
            }

            GridHelper.LoadViewCols(CSwitchView, "SwitchDetail");
        }

        private void setLcUrmRepositoryDataSource()
        {
            DataSet ds = DBAssistant.ExecProcedure(sproc.Cable_Select_Available_LcUrm_For_Switch, new object[] { "@SwitchID", this.SwitchID });
            repLcUrm.DataSource = ds.Tables[0];

        }
        List<DevExpress.XtraGrid.Columns.GridColumn> columnList = new List<DevExpress.XtraGrid.Columns.GridColumn>();
       // int rowHandle = -1;
        private void CSwitchView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gridColumn3)
            {
                DBAssistant.ExecProcedure(sproc.SwitchDetail_Update_LcUrm, new object[] { "@LcUrmID", e.Value, "@ID", CSwitchView.GetRowCellValue(e.RowHandle, "ID") });
                repLcUrm.DataSource = DBAssistant.ExecProcedure(sproc.Cable_Select_Available_LcUrm_For_Switch, new object[] { "@SwitchID", this.SwitchID}).Tables[0].DefaultView;
            }
            
            /*  if(RegexAssistant.RegexMatched(regex.JumperCableAcronym, e.Value.ToString()))
            {
                columnList.Add(e.Column);                  
            }
            */
        }

        private void CSwitchView_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
          /*  if (columnList.Count>0)
            {                                          
               
                string sql = "update Switch.SwitchDetail set " ;
                string set = string.Empty;
                for (int i = 0; i < columnList.Count; i++)
                {
                    set += columnList[i].FieldName + "='" + CSwitchView.GetRowCellValue(e.RowHandle, columnList[i]).ToString() + "' , ";
                }
                int lastindexof = set.LastIndexOf(",");
                set = set.Substring(0, lastindexof);
                Int64 rowID = Convert.ToInt64(CSwitchView.GetRowCellValue(e.RowHandle, "ID"));
                string where = " where ID = '"+rowID.ToString()+"'";
                sql += set + where;
                DBAssistant.Update(sql, new object[] { }, new object[] { });
                columnList.Clear();
            }*/
        }

        private void CSwitchView_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            GridHelper.SaveViewCols(CSwitchView, "SwitchDetail");
        }

        private void repLcUrm_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

            DataView dv = ((DataTable)repLcUrm.DataSource).DefaultView;
            dv.RowFilter = "";

        }

        private void repLcUrm_Popup(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)repLcUrm.DataSource).DefaultView;
            dv.RowFilter = "Connected = 'False'";
        }

        private void CSwitchView_ShownEditor(object sender, EventArgs e)
        {

        }
    }
}