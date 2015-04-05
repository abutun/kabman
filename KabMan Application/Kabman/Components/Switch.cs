
using KabMan.Text;
using System.Windows.Forms;
using System;
namespace KabMan.Components
{
    public class Switch:IAcronymComponent
    {

        #region Constructors

        public Switch()
        {

        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        private string _Name;
        private string _Model;
        private string _Port;
        private int _PortCount;
        private string _Location;
        private string _DataCenter;
        private string _San;
        private string _CoreSwitchName;
        private int _SwitchType;
        private string _LcUrm = "";
        private string _UrmUrm = "";
        private string _BlechFullName = "";
        private string _VtPortFullName = "";
        private string _TrunkFullName = "";
        private string _ConnectionName = "";

        #endregion

        #region Properties
        
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Model
        {
            get
            {
                return this._Model;
            }
            set
            {
                this._Model = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
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
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DataCenter
        {
            get { return _DataCenter; }
            set { _DataCenter = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string San
        {
            get { return _San; }
            set { _San = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CoreSwitchName
        {
            get { return _CoreSwitchName; }
            set { _CoreSwitchName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int SwitchType
        {
            get
            {
                return _SwitchType;
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
                if(_BlechFullName.Trim() != "")
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

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionName
        {
            get { return _ConnectionName; }
            set { _ConnectionName = value; }
        }

        #endregion

        #region Methods

        #endregion

        public void Parse(string argAcronym)
        {
            this.Clear();

            // Deletes spaces at the beginning and at the end
            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (argAcronym.Length > 0)
            {
                if (!IsAcronymValid(argAcronym))
                {
                    MessageBox.Show("Switch Acronym could not parsed!");
                    return;
                }
                else
                {
                    if (argAcronym.Contains("-") || argAcronym.Contains("_"))
                    {
                        //Edge switch
                        this._CoreSwitchName = argAcronym.Split(new string[] { "-", "_" }, StringSplitOptions.None)[0];
                        this._SwitchType = 1;
                        this._Location = this._CoreSwitchName.Substring(2, 2);
                        this._San = this._CoreSwitchName.Substring(this._CoreSwitchName.Length - 1, 1);

                    }
                    else
                    {
                        //Core switch
                        this._CoreSwitchName = "";
                        this._SwitchType = 0;
                        this._Location = argAcronym.Substring(2, 2);
                        this._San = argAcronym.Substring(argAcronym.Length - 1, 1);
                    }
                }
            }
        }

        public void Clear()
        {
        }

        public bool IsAcronymValid(string argAcronym)
        {
            bool swValid = RegexAssistant.RegexMatched(regex.SwitchName, argAcronym);
            bool edgeSwValid = RegexAssistant.RegexMatched(regex.EdgeSwitchName, argAcronym);
            
            return swValid || edgeSwValid;
        }

    }
}
