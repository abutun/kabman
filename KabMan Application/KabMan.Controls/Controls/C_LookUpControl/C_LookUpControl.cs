using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using KabMan.Data;
using DevExpress.Utils;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using KabMan.Windows;
using System.Drawing;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Data;

namespace KabMan.Controls
{
    public delegate void AddButtonPressedEventHandler(C_LookUpControl sender, CancelEventArgs e);
    public delegate void RefreshButtonPressedEventHandler(C_LookUpControl sender, CancelEventArgs e);
    public delegate void TriggeringEventHandler(C_LookUpControl sender, CancelEventArgs e);


    [DesignTimeVisible(false)]
    [ToolboxItem(true)]
    [DefaultProperty("NullText")]
    [ToolboxBitmap(typeof(C_LookUpControl), "C_LookUpControl.C_LookUpControl.bmp")]
    public class C_LookUpControl : LookUpEdit
    {

        #region Constructor

        public C_LookUpControl()
        {
            this.Width = 250;
            this.Properties.Columns.Clear();
            this.Properties.Buttons.Clear();
            this.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Redo, "", -1, true, true, false, ImageLocation.MiddleCenter, null, new KeyShortcut(System.Windows.Forms.Keys.None), "", "Refresh"));
            this.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Plus, "", -1, false, true, false, ImageLocation.MiddleCenter, null, new KeyShortcut(System.Windows.Forms.Keys.None), "", "Add"));

            this.Properties.ButtonPressed += new ButtonPressedEventHandler(Properties_ButtonPressed);
        }

        #endregion

        #region Declarations

        #region Event Declarations
        public event AddButtonPressedEventHandler AddButtonPressed;
        public event RefreshButtonPressedEventHandler RefreshButtonPressed;
        public event TriggeringEventHandler Triggering;

        #endregion

        #region Property Declarations

        private string _StoredProcedureName;
        private string _DisplayMember = "Name";
        private string _ValueMember = "ID";
        private Type _FormToShow;
        private List<object> _FormParameters = new List<object>();
        private NameValuePair[] _Parameters = new NameValuePair[] { };
        private LookUpEdit _TriggerControl;
        public bool OverrideTrigger = false;

        #endregion

        private NameValuePair[] _bckp = null;

        #endregion

        #region Properties

        /// <summary>
        /// Sets or gets Null Text
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public string NullText
        {
            get
            {
                return this.Properties.NullText;
            }
            set
            {
                this.Properties.NullText = value;
            }
        }

        /// <summary>
        /// Gets or sets enable state for add button
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DefaultValue(false)]

        #endregion
        public bool AddButtonEnabled
        {
            get
            {
                try
                {
                    return this.Properties.Buttons[2].Enabled;
                }
                catch (System.Exception ex)
                {
                    return false;
                }

            }
            set
            {
                try
                {
                    this.Properties.Buttons[2].Enabled = value;
                }
                catch (System.Exception ex)
                {

                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public string StoredProcedure
        {
            get
            {
                return this._StoredProcedureName;
            }
            set
            {
                this._StoredProcedureName = value;
                this.TryLoadDataSource();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DefaultValue("Name")]

        #endregion
        public string DisplayMember
        {
            get
            {
                return this._DisplayMember;
            }
            set
            {
                this._DisplayMember = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DefaultValue("ID")]

        #endregion
        public string ValueMember
        {
            get
            {
                return this._ValueMember;
            }
            set
            {
                this._ValueMember = value;
            }
        }

        /// <summary>
        /// Form to show.
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DefaultValue(null)]

        #endregion
        public Type FormToShow
        {
            get
            {
                return this._FormToShow;
            }
            set
            {
                this._FormToShow = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public List<object> FormParameters
        {
            get
            {
                return this._FormParameters;
            }
            set
            {
                this._FormParameters = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]
        [DefaultValue(null)]

        #endregion
        public NameValuePair[] Parameters
        {
            get
            {
                return this._Parameters;
            }
            set
            {
                if (value == null)
                {
                    Array.Clear(this.Parameters, 0, this.Parameters.Length);
                }
                else
                {
                    NameValuePair[] pairs = value;
                    foreach (NameValuePair pair in pairs)
                    {
                        if (!pair.Name.StartsWith("@"))
                        {
                            pair.Name = pair.Name.Insert(0, "@");
                        }
                    }
                    this._Parameters = pairs;
                }
            }
        }

        #region Properties

        [Category("KabMan")]
        [DefaultValue(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        #endregion
        public bool AddButtonVisible
        {
            get
            {
                return this.Properties.Buttons[2].Visible;
            }
            set
            {
                this.Properties.Buttons[2].Visible = value;
            }
        }

        #region Properties

        [Category("KabMan")]

        #endregion
        public bool RefreshButtonVisible
        {
            get
            {
                return this.Properties.Buttons[1].Visible;
            }
            set
            {
                this.Properties.Buttons[1].Visible = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public LookUpEdit TriggerControl
        {
            get
            {
                return this._TriggerControl;
            }
            set
            {
                this._TriggerControl = value;
                if (value != null)
                {
                    _TriggerControl.EditValueChanged += new EventHandler(_TriggerControl_EditValueChanged);
                }
            }
        }

        #region Properties

        [Category("KabMan")]

        #endregion
        public bool HasParameter
        {
            get
            {
                return this.Parameters.Length > 0 ? true : false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        #region Properties

        [Category("KabMan")]

        #endregion
        public LookUpColumnInfoCollection Columns
        {
            get
            {
                return this.Properties.Columns;
            }
            set
            {
                List<LookUpColumnInfo> tmp = new List<LookUpColumnInfo>();
                foreach (LookUpColumnInfo col in value)
                {
                    tmp.Add(col);
                }
                this.Properties.Columns.AddRange(tmp.ToArray());
            }
        }

        #endregion

        #region Methods

        #region Event Methods

        protected virtual void OnAddButtonPressed(CancelEventArgs e)
        {
            AddButtonPressedEventHandler handler = AddButtonPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnRefreshButtonPressed(CancelEventArgs e)
        {
            RefreshButtonPressedEventHandler handler = RefreshButtonPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnTriggered(CancelEventArgs e)
        {
            TriggeringEventHandler handler = Triggering;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion

        #region Override Methods

        protected override void OnLoaded()
        {
            TryLoadDataSource();
            base.OnLoaded();
        }

        #endregion

        #region Event Triggered Methods

        protected virtual void Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                switch (e.Button.Tag.ToString())
                {
                    case "Add":
                        CancelEventArgs ee = new CancelEventArgs();
                        OnAddButtonPressed(ee);
                        if (!ee.Cancel)
                        {

                            if (this.FormToShow != null)
                            {
                                DlgResultArgs resultArgs;
                                if (this.FormParameters != null)
                                {
                                    resultArgs = WindowAssistant.RunAsDialog(this.FormToShow, this.FormParameters.ToArray());
                                }
                                else
                                {
                                    resultArgs = WindowAssistant.RunAsDialog(this.FormToShow);
                                }                                
                                this.LoadDataSource(this.StoredProcedure, this.ParametersToArray(), this.DisplayMember, this.ValueMember);
                            }
                        }
                        break;
                    case "Refresh":
                        CancelEventArgs eee = new CancelEventArgs();
                        OnRefreshButtonPressed(eee);
                        if (!eee.Cancel)
                        {
                            if (!this.HasParameter)
                            {
                                this.LoadDataSource(this.StoredProcedure, this.DisplayMember, this.ValueMember);

                            }
                            else
                            {
                                this.LoadDataSource(this.StoredProcedure, this.ParametersToArray(), this.DisplayMember, this.ValueMember);
                            }
                        }

                        break;
                }
            }
            catch (System.Exception ex)
            {

            }
        }

        public virtual void _TriggerControl_EditValueChanged(object sender, EventArgs e)
        {
            CancelEventArgs ee = new CancelEventArgs();
            OnTriggered(ee);
            if (!ee.Cancel)
            {
                bool hasButton = false;
                foreach (EditorButton ebtn in this.Properties.Buttons)
                {
                    if (ebtn.Tag == "Add")
                    {
                        hasButton = true;
                    }
                }
                if (hasButton)
                {
                    this.Properties.Buttons[2].Enabled = !string.IsNullOrEmpty(this._TriggerControl.EditValue.ToString());
                }
                this.AddOrSetParameterValues(new string[] { this._TriggerControl.EditValue.ToString() });
                this.LoadDataSource(this.StoredProcedure, this.ParametersToArray(), this.DisplayMember, this.ValueMember);
            }
        }

        #endregion

        private void TryLoadDataSource()
        {
            if (this._TriggerControl == null)
            {
                if (this.StoredProcedure != null)
                {
                    if (!this.HasParameter)
                    {
                        this.LoadDataSource(this.StoredProcedure, this.DisplayMember, this.ValueMember);
                    }
                    else
                    {
                        this.LoadDataSource(this.StoredProcedure, this.ParametersToArray(), this.DisplayMember, this.ValueMember);
                    }
                }
            }
        }

        private void AddOrSetParameterValues(string[] argValues)
        {
            if (_bckp == null)
            {
                _bckp = this.CopyPairs(this.Parameters);
            }
            int ind = 0;
            this.Parameters = this.CopyPairs(_bckp);
            foreach (NameValuePair pair in this.Parameters)
            {
                if (string.IsNullOrEmpty(pair.Value))
                {
                    pair.Value = argValues[ind];
                    ind++;
                }
            }
        }

        public NameValuePair[] CopyPairs(NameValuePair[] argSource)
        {
            List<NameValuePair> tmp = new List<NameValuePair>();
            foreach (NameValuePair pair in argSource)
            {
                tmp.Add(new NameValuePair(pair.Name, pair.Value));
            };

            return tmp.ToArray();
        }

        public object[] ParametersToArray()
        {
            List<object> retValue = new List<object>();
            foreach (NameValuePair pair in this.Parameters)
            {
                retValue.AddRange(pair.ToArray());
            }
            return retValue.ToArray();
        }

        #region AddColumn

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argFieldName"></param>
        /// <param name="argColumnName"></param>
        public void AddColumn(string argFieldName, string argColumnName)
        {
            this.Properties.Columns.Add(new LookUpColumnInfo(argFieldName, argColumnName, 20));
        }

        /// <summary>
        /// Field name and column title is equal
        /// </summary>
        /// <param name="argFieldName"></param>
        public void AddColumn(string argFieldName)
        {
            this.AddColumn(argFieldName, argFieldName);
        }

        #endregion

        #region LoadDataSource

        public void LoadDataSource()
        {
            LoadDataSource(this.ParametersToArray());
        }

        public void LoadDataSource(object[] argParameters)
        {
            LoadDataSource(this.StoredProcedure, argParameters, this.DisplayMember, this.ValueMember);
        }

        public void LoadDataSource(string argProcedureName, string argDisplayMember, string argValueMember)
        {
            LoadDataSource(argProcedureName, null, argDisplayMember, argValueMember);
        }

        public void LoadDataSource(string argProcedureName, object[] argParameters, string argDisplayMember, string argValueMember)
        {
            if (!this.DesignMode)
            {
                //this.Properties.Columns.Clear();
                this.Properties.DataSource = DBAssistant.ExecProcedure(argProcedureName, argParameters).Tables[0];
                this.Properties.DisplayMember = argDisplayMember;
                this.Properties.ValueMember = argValueMember;
            }
        }
        
        public void LoadDataSource(string argProcedureName, object[] argParameters, string argDisplayMember, string argValueMember, object[] argNonList)
        {
            if (!this.DesignMode)
            {
                this.Properties.Columns.Clear();
                DataTable dt = DBAssistant.ExecProcedure(argProcedureName, argParameters).Tables[0];
                List<DataRow> removeRowArray = new List<DataRow>();
                for (int i = 0; i < argNonList.Length; i++)
                {
                    DataRow[] rowArray = dt.Select("ID = "+argNonList[i]);
                    if (rowArray != null)
                    {
                        if (rowArray.Length > 0)
                        {
                            removeRowArray.AddRange(rowArray);
                        }
                    }
                }
                for (int i = 0; i < removeRowArray.Count; i++)
                {
                    dt.Rows.Remove(removeRowArray[i]);
                }
                this.Properties.DataSource = dt;
                this.Properties.DisplayMember = argDisplayMember;
                this.Properties.ValueMember = argValueMember;
            }
        }        
        #endregion

        #endregion

    }

    public class NameValuePair
    {
        public NameValuePair()
        {

        }

        public NameValuePair(string argName)
        {
            this._Name = argName;
            this._Value = "";
        }
        public NameValuePair(string argName, string argValue)
        {
            this._Name = argName;
            this._Value = argValue;
        }

        public NameValuePair(string[] argPair)
        {

            this._Name = argPair[0];
            this._Value = argPair[1];

        }
        private string _Name;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

        private string _Value;
        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this._Value = value;
            }
        }

        public string[] ToArray()
        {
            return new string[] { this._Name, this._Value };
        }

    }

}
