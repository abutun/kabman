using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using KabMan.Data;
using DevExpress.Utils;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using KabMan.Windows;

namespace KabMan.Controls
{
    [DesignTimeVisible(false), ToolboxItem(false)]
    public class C_LookUpBase : LookUpEdit
    {
        public C_LookUpBase()
        {            
            this.Properties.Columns.Clear();
            this.Properties.SearchMode = SearchMode.AutoFilter;
            this.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Redo, "", -1, true, true, false, ImageLocation.MiddleCenter, null, new KeyShortcut(System.Windows.Forms.Keys.None), "", "Refresh"));
            this.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Plus, "", -1, false, true, false, ImageLocation.MiddleCenter, null, new KeyShortcut(System.Windows.Forms.Keys.None), "", "Add"));

            this.Properties.ButtonPressed += new ButtonPressedEventHandler(Properties_ButtonPressed);
        }

        protected virtual void Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                switch (e.Button.Tag.ToString())
                {
                    case "Add":
                        if (this.FormToShow != null)
                        {
                            DlgResultArgs resultArgs;
                            if (this.FormParameters != null)
                            {
                                resultArgs = WindowAssistant.RunAsDialog(this.FormToShow, this.FormParameters);
                            }
                            else
                            {
                                resultArgs = WindowAssistant.RunAsDialog(this.FormToShow);
                            }

                            this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
                        }
                        break;
                    case "Refresh":
                        if (this._HasParameter)
                        {
                            if (this.StoredProcedureParameters != null)
                            {
                                this.LoadDataSource(this.StoredProcedureName, this.StoredProcedureParameters, this.DisplayMember, this.ValueMember);
                            }
                        }
                        else
                        {
                            this.LoadDataSource(this.StoredProcedureName, this.DisplayMember, this.ValueMember);
                        }

                        break;
                }
            }
            catch (System.Exception ex)
            {

            }
        }

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

        public void LoadDataSource(string argProcedureName, string argDisplayMember, string argValueMember)
        {
            LoadDataSource(argProcedureName, null, argDisplayMember, argValueMember);
        }

        public void LoadDataSource(string argProcedureName, object[] argParameters, string argDisplayMember, string argValueMember)
        {
            if (!this.DesignMode)
            {
                this.Properties.DataSource = DBAssistant.ExecProcedure(argProcedureName, argParameters).Tables[0];
                this.Properties.DisplayMember = argDisplayMember;
                this.Properties.ValueMember = argValueMember;
            }

        }


        #region Properties

        /// <summary>
        /// Sets or gets Null Text
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        [DefaultValue(false)]
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

        private string _StoredProcedureName;
        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StoredProcedureName
        {
            get
            {
                return this._StoredProcedureName;
            }
            set
            {
                this._StoredProcedureName = value;
            }
        }

        private string _DisplayMember;
        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        private string _ValueMember;
        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        private Type _FormToShow;
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        private object[] _FormParameters;
        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object[] FormParameters
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

        private object[] _StoredProcedureParameters;
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object[] StoredProcedureParameters
        {
            get
            {
                return this._StoredProcedureParameters;
            }
            set
            {
                this._StoredProcedureParameters = value;
            }
        }

        private bool _HasParameter;
        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HasParameter
        {
            get
            {
                return this._HasParameter;
            }
            set
            {
                this._HasParameter = value;
            }
        }

        [DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        #endregion

    }
}
