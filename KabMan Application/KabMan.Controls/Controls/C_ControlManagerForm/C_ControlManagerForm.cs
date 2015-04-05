using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using KabMan.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using KabMan.Designer;
using DevExpress.XtraGrid.Columns;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), Designer(typeof(ManagerFormDesigner)), Category("KabMan Controls"), ToolboxBitmap(typeof(C_ControlManagerForm), "C_ControlManagerForm.C_ControlManagerForm.bmp")]
    public partial class C_ControlManagerForm : UserControl
    {

        #region  Constructor

        public C_ControlManagerForm()
        {
            InitializeComponent();

            newButton.Glyph = Resources.GetImage("ManagerAdd");
            editButton.Glyph = Resources.GetImage("ManagerEdit");
            deleteButton.Glyph = Resources.GetImage("ManagerDelete");
            saveButton.Glyph = Resources.GetImage("ManagerSave");
            cancelButton.Glyph = Resources.GetImage("ManagerCancel");
            exitButton.Glyph = Resources.GetImage("ManagerExit");
        }

        #endregion

        #region Fields

        private long currentID;

        #endregion

        #region Methods

        #region SetToolbarEnabledStates

        /// <summary>
        /// Sets Enabled states for toolbar buttons
        /// </summary>
        /// <param name="argNewButton"></param>
        /// <param name="argEditButton"></param>
        /// <param name="argDeleteButton"></param>
        /// <param name="argSaveButton"></param>
        /// <param name="argExitButton"></param>
        public void SetToolbarButtonEnabledStates(bool argNewButton, bool argEditButton, bool argDeleteButton, bool argSaveButton, bool argCancelButton, bool argExitButton)
        {
            newButton.Enabled = argNewButton;
            editButton.Enabled = argEditButton;
            deleteButton.Enabled = argDeleteButton;
            saveButton.Enabled = argSaveButton;
            cancelButton.Enabled = argCancelButton;
            exitButton.Enabled = argExitButton;
        }

        #endregion

        #region Database Operations

        public void dbSelect(object[] argParameters)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.SelectParameters = argParameters;
            DataTable managerTable = new DataTable();
            if (this.SelectRequiresParameter)
            {
                if (this._SelectParameters != null)
                {
                    managerTable = DBAssistant.ExecProcedure(this.SelectProcedure, this.SelectParameters).Tables[0];
                }
                else
                {

                }
            }
            else
            {
                managerTable = DBAssistant.ExecProcedure(this.SelectProcedure, null).Tables[0];
            }
           
            managerGridControl.DataSource = managerTable;
            statustextCount.Caption = string.Format("Records: {0}", managerTable.Rows.Count.ToString());

            managerTable.Dispose();

            Cursor.Current = Cursors.Default;
        }

        public void dbUpdate(object[] argParameters)
        {
            DBAssistant.ExecProcedure(this.UpdateProcedure, argParameters);
            this.dbSelect(this.SelectParameters);
        }

        public void dbInsert(object[] argParameters)
        {
            DBAssistant.ExecProcedure(this.InsertProcedure, argParameters);
            this.dbSelect(this.SelectParameters);
        }

        public void dbDelete(object[] argParameters)
        {
            DBAssistant.ExecProcedure(this.DeleteProcedure, argParameters);
            this.dbSelect(this.SelectParameters);
        }

        #endregion

        public DialogResult AskForDelete()
        {
            DialogResult delResult;
            delResult = XtraMessageBox.Show(
                  "Are you sure you want to delete this record?",
                  Text,
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return delResult;
        }

        #endregion

        #region Properties

        private bool _IsEdit;
        public bool IsEdit
        {
            get
            {
                return this._IsEdit;
            }
            set
            {
                this._IsEdit = value;
                if (value)
                {
                    this._IsNew = false;
                }
                this.SetToolbarButtonEnabledStates(false, false, true, true, true, true);
            }
        }

        private bool _IsNew;
        public bool IsNew
        {
            get
            {
                return this._IsNew;
            }
            set
            {
                this._IsNew = value;
                if (value)
                {
                    this._IsEdit = false;
                }
                SetToolbarButtonEnabledStates(false, false, false, true, true, true);
            }
        }

        private bool _IsCancel;
        public bool IsCancel
        {
            get
            {
                return this._IsCancel;
            }
            set
            {
                this._IsCancel = value;
                this.IsNew = true;
                this.SetToolbarButtonEnabledStates(true, true, false, true, false, true);
            }
        }

        private string _SelectProcedure;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        #endregion
        public string SelectProcedure
        {
            get
            {
                return this._SelectProcedure;
            }
            set
            {
                this._SelectProcedure = value;
            }
        }

        private string _UpdateProcedure;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public string UpdateProcedure
        {
            get
            {
                return this._UpdateProcedure;
            }
            set
            {
                this._UpdateProcedure = value;
            }
        }

        private string _DeleteProcedure;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public string DeleteProcedure
        {
            get
            {
                return this._DeleteProcedure;
            }
            set
            {
                this._DeleteProcedure = value;
            }
        }

        private string _InsertProcedure;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public string InsertProcedure
        {
            get
            {
                return this._InsertProcedure;
            }
            set
            {
                this._InsertProcedure = value;
            }
        }

        /// <summary>
        /// GridControl on the ManagerForm
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public GridControl ManagerGridControl
        {
            get
            {
                return this.managerGridControl;
            }
            set
            {
                this.managerGridControl = value;
            }
        }

        /// <summary>
        /// GridView on the ManagerForm
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public GridView ManagerGridView
        {
            get
            {
                return this.managerGridView;
            }
            set
            {
                this.managerGridView = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem NewButton
        {
            get
            {
                return this.newButton;
            }
            set
            {
                this.newButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem EditButton
        {
            get
            {
                return this.editButton;
            }
            set
            {
                this.editButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem DeleteButton
        {
            get
            {
                return this.deleteButton;
            }
            set
            {
                this.deleteButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem SaveButton
        {
            get
            {
                return this.saveButton;
            }
            set
            {
                this.saveButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem CancelButton
        {
            get
            {
                return this.cancelButton;
            }
            set
            {
                this.cancelButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public BarButtonItem ExitButton
        {
            get
            {
                return this.exitButton;
            }
            set
            {
                this.exitButton = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        #endregion

        public Panel LayoutPanel
        {
            get
            {
                return this.layoutControlPanel;
            }
            set
            {
                this.layoutControlPanel = value;
            }
        }

        /// <summary>
        /// Returnes selected row values
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public Dictionary<string, object> SelectedRowValues
        {
            get
            {
                Dictionary<string, object> retValue = new Dictionary<string, object>();

                DataTable dataTable = (DataTable)managerGridControl.DataSource;
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    string columnName = dataTable.Columns[i].ColumnName;
                    retValue.Add(columnName, managerGridView.GetFocusedRowCellValue(columnName));
                }

                return retValue;
            }
        }

        private object[] _SelectParameters = null;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public object[] SelectParameters
        {
            get
            {
                return this._SelectParameters;
            }
            set
            {
                this._SelectParameters = value;
            }
        }

        private bool _SelectRequiresParameter;
        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [DefaultValue(false)]
        [Category("KabMan")]

        #endregion
        public bool SelectRequiresParameter
        {
            get
            {
                return this._SelectRequiresParameter;
            }
            set
            {
                this._SelectRequiresParameter = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public GridColumnCollection Columns
        {
            get
            {
                return this.managerGridView.Columns;
            }
            set
            {
                List<GridColumn> tmp = new List<GridColumn>();
                foreach (GridColumn col in value)
                {
                    tmp.Add(col);
                }
                this.managerGridView.Columns.AddRange(tmp.ToArray());
            }
        }


        #endregion

        #region Events

        private void C_ControlManagerForm_Load(object sender, EventArgs e)
        {
            this.IsCancel = true;
            if (!string.IsNullOrEmpty(this.SelectProcedure))
            {
                this.dbSelect(this.SelectParameters);
            }
        }

        public virtual void newButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsNew = true;
        }

        private void editButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsEdit = true;
        }

        private void deleteButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void saveButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cancelButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.IsCancel = true;
        }

        private void exitButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ParentForm.Close();
        }

        private void rootPanel_Resize(object sender, EventArgs e)
        {
            int lw = layoutControlPanel.Width;
            int gw = managerGridControl.Width;

            int rw = rootPanel.Width;

            if (lw != rw | gw != rw)
            {
                layoutControlPanel.Width = (rw);
                managerGridControl.Width = rw;
            }
        }

        private void layoutControlPanel_Resize(object sender, EventArgs e)
        {
            int lh = layoutControlPanel.Height;
            int lt = layoutControlPanel.Top;

            int rh = rootPanel.Height;

            int gt = (lt + lh);
            managerGridControl.Top = gt;
            managerGridControl.Height = (rh - (gt - 6));

        }

        private void layoutControlPanel_Move(object sender, EventArgs e)
        {
            if (layoutControlPanel.Location.X != 0 | layoutControlPanel.Location.Y != 0)
            {
                layoutControlPanel.Location = new Point(0, 0);
            }
        }

        private void managerGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GridControl grid = sender as GridControl;
                BaseView view = grid.FocusedView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location) as GridHitInfo;

                if (hitInfo.InRow)
                {

                }
            }
        }
        #endregion
    }

}
