using System;
using System.Data;
using KabMan.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace KabMan.Forms
{
    public partial class CableManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public CableManagerForm()
        {
            InitializeComponent();

            CableCategoryLookUp.FormToShow = typeof(CableCategoryManagerForm);
            CableModelLookUp.FormToShow = typeof(CableModelManagerForm);

        }

        private int VAR_LastNo = 1;
        DataTable VAR_PropTable = new DataTable();

        private void CableManager_Load(object sender, EventArgs e)
        {
        }

        private void CableCategoryLookUp_EditValueChanged(object sender, EventArgs e)
        {
            CableModelLookUp.EditValue = null;
            DataSet LVAR_CableDataSet;
            LVAR_CableDataSet = DBAssistant.ExecProcedure(sproc.Cable_Select_ByCategoryID, new object[] { "@CategoryID", CableCategoryLookUp.EditValue });
            CablesGridControl.DataSource = LVAR_CableDataSet.Tables[0];
            CableModelLookUp.Properties.DataSource = DBAssistant.ExecProcedure(sproc.CableModel_Select_ByCategoryID, new object[] { "@CategoryID", CableCategoryLookUp.EditValue }).Tables[0];
            CableModelLookUp.Properties.DisplayMember = "Model";
            CableModelLookUp.Properties.ValueMember = "ID";
            //Common.FillLookUpEdit(CableModelLookUp, "[sproc].[CableModel_Select_ByCategoryID]", , "Model", "ID");
            //spnStartNo.Properties.MinValue = 1;
            SetLastNumbersToSpinEdit();
            CableModelLookUp.FormParameters = new object[] { CableCategoryLookUp.EditValue };
        }

        private void CableModelLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (CableModelLookUp.EditValue != null)
            {
                DataSet LVAR_CableDataSet;
                LVAR_CableDataSet = DBAssistant.ExecProcedure("[sproc].[Cable_Select_ByCableModelID]", new object[] { "@CableModelID", CableModelLookUp.EditValue });
                CablesGridControl.DataSource = LVAR_CableDataSet.Tables[0];

                DataSet LVAR_DataSet = DBAssistant.ExecProcedure("[sproc].[CableProperties_Select_ByCableModelID]", new object[] { "@CableModelID", CableModelLookUp.EditValue });
                VAR_PropTable = LVAR_DataSet.Tables[0];
                CablePropertiesGridControl.DataSource = VAR_PropTable;

                DataSet LVAR_ClassDataSet;
                LVAR_ClassDataSet = DBAssistant.ExecProcedure("[sproc].[CableModel_Get_ClassCount]", new object[] { "@CableModelID", CableModelLookUp.EditValue });
                int LVAR_ClassCount = Convert.ToInt32(LVAR_ClassDataSet.Tables[0].Rows[0]["retValue"]);
                if (LVAR_ClassCount > 0)
                {
                    CountSpinEdit.Enabled = false;
                    CountSpinEdit.Value = LVAR_ClassCount;
                }
                else
                {
                    CountSpinEdit.Enabled = true;
                    CountSpinEdit.Value = 1;
                }

                if (CableModelLookUp.EditValue != null)
                {
                    btnAddCables.Enabled = !string.IsNullOrEmpty(CableModelLookUp.EditValue.ToString());
                }
            }


        }

        private void SetLastNumbersToSpinEdit()
        {
            DataSet LVAR_DataSet;

            LVAR_DataSet = DBAssistant.ExecProcedure("[sproc].[Cable_Select_MaxNumber_ByCategoryID]", new object[] { "@CategoryID", CableCategoryLookUp.EditValue });
            object LVAR_MaxNo = LVAR_DataSet.Tables[0].Rows[0]["retValue"];

            this.VAR_LastNo = 1;
            if (!string.IsNullOrEmpty(LVAR_MaxNo.ToString()))
            {
                this.VAR_LastNo = Convert.ToInt32(LVAR_MaxNo) + 1;
            }

            StartNoSpinEdit.Properties.MinValue = this.VAR_LastNo;
            StartNoSpinEdit.Value = this.VAR_LastNo;
        }

        private void btnAddCables_Click(object sender, EventArgs e)
        {
            /*AHMET BUTUN*/
            if (this.CableTypeGroup.SelectedIndex == 1)
            {
                //Multiple
                DBAssistant.ExecProcedure("[sproc].[Cable_Insert]", new object[] { "@CableModelID", CableModelLookUp.EditValue, "@Count", CountSpinEdit.EditValue, "@CableSymbol", SymbolSpinEdit.EditValue });
            }
            else
            {
                //Single
                DataSet LVAR_ClassDataSet;
                LVAR_ClassDataSet = DBAssistant.ExecProcedure("[sproc].[CableModel_Get_ClassCount]", new object[] { "@CableModelID", CableModelLookUp.EditValue });
                int LVAR_ClassCount = Convert.ToInt32(LVAR_ClassDataSet.Tables[0].Rows[0]["retValue"]);
                if (LVAR_ClassCount <= 0)
                    LVAR_ClassCount = 1;

                DataSet returnVal = DBAssistant.ExecProcedure("[sproc].[Cable_Insert_Specific]", new object[] { "@CableModelID", CableModelLookUp.EditValue, "@CableSymbol", SymbolSpinEdit.EditValue, "@CableNumber", CableNumberEdit.Text, "@Count", LVAR_ClassCount });

                if (returnVal != null)
                {
                    if (returnVal.Tables.Count == 1)
                    {
                        if (returnVal.Tables[0].Rows.Count > 0)
                        {
                            if(returnVal.Tables[0].Rows[0][0].ToString()=="-1")
                                XtraMessageBox.Show("Cable already exists!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            XtraMessageBox.Show("No rows effected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show("No rows effected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("Error occured!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataSet LVAR_CableDataSet;
            LVAR_CableDataSet = DBAssistant.ExecProcedure("[sproc].[Cable_Select_ByCableModelID2]", new object[] { "@CableModelID", CableModelLookUp.EditValue });
            CablesGridControl.DataSource = LVAR_CableDataSet.Tables[0];

            SetLastNumbersToSpinEdit();
        }

        private void CableModelLookUp_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void CableCategoryLookUp_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void CableTypeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CableTypeGroup.SelectedIndex == 0)
            {
                //Single
                this.layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                this.layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                this.btnAddCables.Text = "Add Cable";
            }
            else
            {
                //Multiple
                this.layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                this.layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                this.btnAddCables.Text = "Add Cables";
            }
        }

    }
}