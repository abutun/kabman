using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class NewCableModelForm : XtraForm
    {
        public NewCableModelForm(long argCategoryID)
        {
            this._categoryID = argCategoryID;
            InitializeComponent();
        }

        private long _categoryID;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string LVAR_ProcedureName = string.Format(sproc.SPROC_TEMPLATE, "GetNextID");
            object[] LVAR_Parameters = {
                                          "@TableName", "Cable.CableModel" 
                                       };
            DataSet LVAR_DataSet = DBAssistant.ExecProcedure(LVAR_ProcedureName, LVAR_Parameters);

            object LVAR_NextID = LVAR_DataSet.Tables[0].Rows[0]["retValue"];


            LVAR_ProcedureName = string.Format(sproc.SPROC_TEMPLATE, "CableModel_Insert");
            LVAR_Parameters = new object[] {
                                               "@Model", CableModelTextBox.Text,
                                               "@Length", LenghtSpinEdit.Text,
                                               "@CategoryID", this._categoryID,
                                               "@CableCount", CableCountSpinEdit.Text,
                                               "@LineCount", LineCountSpinEdit.Text
                                           };
            DBAssistant.ExecProcedure(LVAR_ProcedureName, LVAR_Parameters);


            for (int i = 0; i < VAR_PropertyTable.Rows.Count; i++)
            {

                LVAR_ProcedureName = string.Format(sproc.SPROC_TEMPLATE, "CableProperties_Insert");
                LVAR_Parameters = new object[] {
	                                                "@Name", VAR_PropertyTable.Rows[i]["Name"],
	                                                "@Value", VAR_PropertyTable.Rows[i]["Value"],
                                                    "@CableModelID",LVAR_NextID
	                                            };
                DBAssistant.ExecProcedure(LVAR_ProcedureName, LVAR_Parameters);
            }
            this.DialogResult = DialogResult.OK;
        }

        DataTable VAR_PropertyTable = new DataTable();

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyValidator.Validate())
            {
                DataRow LVAR_DataRow = VAR_PropertyTable.NewRow();
                LVAR_DataRow.ItemArray = new object[] { PropertyNameTextBox.Text, PropertyValueTextBox.Text };
                VAR_PropertyTable.Rows.Add(LVAR_DataRow);

                PropertiesGridControl.RefreshDataSource();
                PropertyNameTextBox.Text = PropertyValueTextBox.Text = "";
            }
            
        }

        private void CableModel_Load(object sender, EventArgs e)
        {

            VAR_PropertyTable.Columns.Add("Name");
            VAR_PropertyTable.Columns.Add("Value");
            PropertiesGridControl.DataSource = VAR_PropertyTable;
        }

        private void SymbolTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}