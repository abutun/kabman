using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using Microsoft.Win32;
using DevExpress.XtraEditors;

namespace KabMan.Windows
{
    public class WindowAssistant
    {
        #region Constants

        private const string REGISTRY_PATH = "Software\\KabMan\\";

        #endregion

        private const int maxx = 640;
        private const int maxy = 480;

        public enum FormShowType
        {
            ShowNormal,
            ShowDialog
        }

        public static Form RunAsMDI(Type argFormType, IntPtr argParentHandle)
        {
            return RunAsMDI(argFormType, argParentHandle, null);
        }

        public static Form RunAsMDI(Type argFormType, IntPtr argParentHandle, params object[] argParameters)
        {
            Cursor.Current = Cursors.WaitCursor;

            Form retValue = new Form();
            object newForm = Activator.CreateInstance(argFormType, argParameters);

            retValue = ((Form)newForm);
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == retValue.Name)
                {
                    openForm.BringToFront();
                    return retValue;
                }
            }

            retValue.MdiParent = (Form)Form.FromHandle(argParentHandle);
            retValue.Show();

            Cursor.Current = Cursors.Default;

            return retValue;
        }

        public static Form RunAsMultiMDI(Type argFormType, IntPtr argParentHandle, params object[] argParameters)
        {
            Form retValue = new Form();
            object newForm = Activator.CreateInstance(argFormType, argParameters);

            retValue = ((Form)newForm);
            //foreach (Form openForm in Application.OpenForms)
           // {
            //    if (openForm.Name == retValue.Name)
             //   {
              //      openForm.BringToFront();
              //      return retValue;
              //  }
            //}            
            retValue.MdiParent = (Form)Form.FromHandle(argParentHandle);
            retValue.Show();

            return retValue;
        }

    
        public static Form RunNewForm(Type argFormType)
        {
            return RunNewForm(argFormType, FormShowType.ShowNormal);
        }

        public static Form RunNewForm(Type argFormType, FormShowType argShowAs)
        {
            return RunNewForm(argFormType, argShowAs, null);
        }

        public static Form RunNewForm(Type argFormType, FormShowType argShowAs, params object[] argParameters)
        {
            Form retValue = new Form();
            object newForm = Activator.CreateInstance(argFormType, argParameters);
            if (argShowAs == FormShowType.ShowDialog)
            {
                ((Form)newForm).ShowDialog();
            }
            else
            {
                ((Form)newForm).Show();
            }
            return (Form)newForm;
        }

        public static DlgResultArgs RunAsDialog(Type argFormType)
        {
            return RunAsDialog(argFormType, null);
        }        
        public static DlgResultArgs RunAsDialog(Type argFormType, params object[] argParameters)
        {
            Cursor.Current = Cursors.WaitCursor;

            object newForm = Activator.CreateInstance(argFormType, argParameters);                                    
            DlgResultArgs dialogResult = new DlgResultArgs();           
            dialogResult.FormResult = ((Form)newForm).ShowDialog();
            dialogResult.ReturnForm = ((Form)newForm);
            
            Cursor.Current = Cursors.Default;
            
            return dialogResult;
        }
    }

    public class DlgResultArgs
    {

        private Form _ReturnForm;
        /// <summary>
        /// 
        /// </summary>
        public Form ReturnForm
        {
            get
            {
                return this._ReturnForm;
            }
            set
            {
                this._ReturnForm = value;
            }
        }

        private DialogResult _FormResult;
        /// <summary>
        /// 
        /// </summary>
        public DialogResult FormResult
        {
            get
            {
                return this._FormResult;
            }
            set
            {
                this._FormResult = value;
            }
        }




    }

}
