using System;
using System.Data;
using System.Windows.Forms;
using KabMan.Data;

namespace KabMan.Forms
{
    public partial class UserManagerDetailForm : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private UserManagerForm f;

        public UserManagerDetailForm(UserManagerForm f, int id)
        {
            this.f = f;
            this.id = id;

            Icon = Resources.GetIcon("KabManIcon");

            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                Cursor.Current = Cursors.WaitCursor;

                DBAssistant.ExecProcedure
                    (
                        sproc.LoginUserInsert, new object[] 
	                    { 
	                        "@Id", id,
	                        "@UserName", txtUsername.EditValue,
	                        "@Password", txtPassword.EditValue,
	                        "@FirstName", txtFirstName.EditValue,
                            "@LastName", txtLastName.EditValue,
                            "@Technician", chkPermission.Checked
	                    }
                    );

                Cursor.Current = Cursors.Default;

                f.InitData(true);

                Close();
            }
        }

        private void UserManagerDetailForm_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DataSet ds;
                ds = DBAssistant.ExecProcedure(sproc.LoginUserDetail,new object[] { "@Id", id} );
                txtUsername.EditValue = ds.Tables[0].Rows[0]["UserName"].ToString();
                txtPassword.EditValue = ds.Tables[0].Rows[0]["Password"].ToString();
                txtFirstName.EditValue = ds.Tables[0].Rows[0]["FirstName"].ToString();
                txtLastName.EditValue = ds.Tables[0].Rows[0]["LastName"].ToString();
                chkPermission.Checked = (bool)ds.Tables[0].Rows[0]["Technician"];
            }
        }

        private void UserManagerDetailForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
    }
}