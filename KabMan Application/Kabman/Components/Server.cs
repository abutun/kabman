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
 
    public class Server : IAcronymComponent
    {

        #region Constructors

        public Server()
        {

        }

        #endregion

        #region Fields
        private int _PortCount;
        private string _OperatingSystem = "";
        private string _LcUrm = "";
        private string _UrmUrm = "";
        private string _BlechFullName = "";
        private string _VtPortFullName = "";
        private string _TrunkFullName = "";

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
        public string Coordinate { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OperatingSystem
        {
           get
           {
               return _OperatingSystem;
           }
            set
            {
                if (String.IsNullOrEmpty(value))
                    value = "";

                _OperatingSystem = value.Trim();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public int PortCount
        {
            get
            {
                return this._PortCount;
            }
            set
            {
                this._PortCount = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPortFullName
        {
            get { return _VtPortFullName; }
            set { _VtPortFullName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPortName
        {
            get
            {
                string _vtPortName = "";
                if (_VtPortFullName.Trim() != "")
                {
                    _vtPortName = _VtPortFullName.Split(new string[] { "." }, StringSplitOptions.None)[0];
                }

                return _vtPortName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPortClass1
        {
            get
            {
                string _vtPortClass1 = "";
                if (_VtPortFullName.Trim() != "")
                {
                    _vtPortClass1 = _VtPortFullName.Split(new string[] { "." }, StringSplitOptions.None)[1];
                }

                return _vtPortClass1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPortNo
        {
            get
            {
                string _vtPortNo = "";
                if (_VtPortFullName.Trim() != "")
                {
                    _vtPortNo = _VtPortFullName.Split(new string[] { "." }, StringSplitOptions.None)[2];
                }

                return _vtPortNo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VtPortClass2
        {
            get
            {
                string _vtPortClass2 = "";
                if (_VtPortFullName.Trim() != "")
                {
                    _vtPortClass2 = _VtPortFullName.Split(new string[] { "." }, StringSplitOptions.None)[3];
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
        public string BlechName
        {
            get
            {
                string _blechName = "";
                if (_BlechFullName.Trim() != "")
                {
                    _blechName = _BlechFullName.Split(new string[] { "." }, StringSplitOptions.None)[0];
                }
                return _blechName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BlechFullName
        {
            get
            {
                return _BlechFullName;
            }
            set
            {
                _BlechFullName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BlechClass1
        {
            get
            {
                string _blechClass = "";
                if (_BlechFullName.Trim() != "")
                {
                    _blechClass = _BlechFullName.Split(new string[] { "." }, StringSplitOptions.None)[1];
                }

                return _blechClass;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BlechNo
        {
            get
            {
                string _blechNo = "";
                if (_BlechFullName.Trim() != "")
                {
                    _blechNo = _BlechFullName.Split(new string[] { "." }, StringSplitOptions.None)[2];
                }

                return _blechNo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BlechClass2
        {
            get
            {
                string _blechClass2 = "";
                if (_BlechFullName.Trim() != "")
                {
                    _blechClass2 = _BlechFullName.Split(new string[] { "." }, StringSplitOptions.None)[3];
                }

                return _blechClass2;
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
            this.Coordinate = argAcronym.Substring(endLocation, strLength - endLocation);


        }

        public void Clear()
        {
        }

        public bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.ServerAcronym, argAcronym);
        }
        #endregion
    }
}
