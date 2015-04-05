using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KabMan.Extensions;
using KabMan.Components;
using KabMan.Windows;
using System.Windows.Forms;
using KabMan.Text;
using DevExpress.XtraEditors;


namespace KabMan.Import
{
 
    public class Dcc : IAcronymComponent
    {

        #region Constructors

        public Dcc()
        {

        }

        #endregion

        #region Fields
        private string _LcUrm = "";
        private string _UrmUrm = "";
        private string _VtPort1FullName = "";
        private string _TrunkFullName = "";
        private string _VtPort2FullName = "";

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
           get;set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort1FullName
        {
            get { return _VtPort1FullName; }
            set { _VtPort1FullName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort2FullName
        {
            get { return _VtPort2FullName; }
            set { _VtPort2FullName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort1Name
        {
            get
            {
                string _vtPortName = "";
                if (_VtPort1FullName.Trim() != "")
                {
                    _vtPortName = _VtPort1FullName.Split(new string[] { "." }, StringSplitOptions.None)[0];
                }

                return _vtPortName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort2Name
        {
            get
            {
                string _vtPortName = "";
                if (_VtPort2FullName.Trim() != "")
                {
                    _vtPortName = _VtPort2FullName.Split(new string[] { "." }, StringSplitOptions.None)[0];
                }

                return _vtPortName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort1Class1
        {
            get
            {
                string _vtPortClass1 = "";
                if (_VtPort1FullName.Trim() != "")
                {
                    _vtPortClass1 = _VtPort1FullName.Split(new string[] { "." }, StringSplitOptions.None)[1];
                }

                return _vtPortClass1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort2Class1
        {
            get
            {
                string _vtPortClass1 = "";
                if (_VtPort2FullName.Trim() != "")
                {
                    _vtPortClass1 = _VtPort1FullName.Split(new string[] { "." }, StringSplitOptions.None)[1];
                }

                return _vtPortClass1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort1No
        {
            get
            {
                string _vtPortNo = "";
                if (_VtPort1FullName.Trim() != "")
                {
                    _vtPortNo = _VtPort1FullName.Split(new string[] { "." }, StringSplitOptions.None)[2];
                }

                return _vtPortNo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort2No
        {
            get
            {
                string _vtPortNo = "";
                if (_VtPort2FullName.Trim() != "")
                {
                    _vtPortNo = _VtPort2FullName.Split(new string[] { "." }, StringSplitOptions.None)[2];
                }

                return _vtPortNo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort1Class2
        {
            get
            {
                string _vtPortClass2 = "";
                if (_VtPort1FullName.Trim() != "")
                {
                    _vtPortClass2 = _VtPort1FullName.Split(new string[] { "." }, StringSplitOptions.None)[3];
                }

                return _vtPortClass2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPort2Class2
        {
            get
            {
                string _vtPortClass2 = "";
                if (_VtPort2FullName.Trim() != "")
                {
                    _vtPortClass2 = _VtPort2FullName.Split(new string[] { "." }, StringSplitOptions.None)[3];
                }

                return _vtPortClass2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LcUrm
        {
            get
            {
                return _LcUrm;
            }
            set
            {
                _LcUrm = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LcUrmSymbol
        {
            get
            {
                string _symbol = "";
                if (_LcUrm.Length > 0)
                    _symbol = _LcUrm.Substring(0, 1);

                return _symbol;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LcUrmNo
        {
            get
            {
                string _no = "";
                if (_LcUrm.Length > 5)
                    _no = _LcUrm.Substring(1, 5);

                return _no;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UrmUrm
        {
            get
            {
                return _UrmUrm;
            }
            set
            {
                _UrmUrm = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UrmUrmSymbol
        {
            get
            {
                string _symbol = "";
                if (_UrmUrm.Length > 0)
                    _symbol = _UrmUrm.Substring(0, 1);

                return _symbol;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UrmUrmNo
        {
            get
            {
                string _no = "";
                if (_UrmUrm.Length > 5)
                    _no = _UrmUrm.Substring(1, 5);

                return _no;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TrunkFullName
        {
            get { return _TrunkFullName; }
            set { _TrunkFullName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TrunkSymbol
        {
            get
            {
                string _symbol = "";
                if (_TrunkFullName.Length > 0)
                    _symbol = _TrunkFullName.Substring(0, 1);

                return _symbol;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TrunkNo
        {
            get
            {
                string _no = "";
                if (_TrunkFullName.Length > 5)
                    _no = _TrunkFullName.Substring(1, 5);

                return _no;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TrunkClass
        {
            get
            {
                string _class = "";
                if (_TrunkFullName.Length > 5)
                    if (_TrunkFullName.Contains("."))
                        _class = _TrunkFullName.Split(new string[] { "." }, StringSplitOptions.None)[1];

                return _class;
            }
        }

        #endregion

        #region Methods

        public void Parse(string argAcronym)
        {
            this.Clear();

            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (!IsAcronymValid(argAcronym))
            {
                XtraMessageBox.Show(String.Format("Server acronym {0} could not be parsed!", argAcronym), "KabMan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int endLocation = 2;
            if (char.IsNumber(argAcronym[3]))
            {
                endLocation = 3;
            }

            int startLocation = 1;
            int strLength = argAcronym.Length;

            this.Name = argAcronym.Substring(startLocation, endLocation);
            
            endLocation++;
        }

        public void Clear()
        {
        }

        public bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.DccAcronym, argAcronym);
        }
        #endregion
    }
}
