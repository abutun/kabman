using System;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class NewCableCategoryForm : DevExpress.XtraEditors.XtraForm
    {
        public NewCableCategoryForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DBAssistant.ExecProcedure("[sproc].[CableCategory_Insert]", new object[] { "@Name", CategoryNameTextBox.Text, "@HasClass", HasClassCheckBox.EditValue, "@MustUnique", MustUniqueCheckBox.EditValue });
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

    }
}