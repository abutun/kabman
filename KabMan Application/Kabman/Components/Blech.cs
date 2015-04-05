using System.Windows.Forms;
using KabMan.Text;
using DevExpress.XtraEditors;

namespace KabMan.Components
{
    public class Blech : IAcronymComponent
    {

        #region Contructors

        public Blech()
        {

        }

        public Blech(string argAcronym)
        {
            this.Parse(argAcronym);
        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        #region _

        private string _Symbol;
        private string _Room;
        private string _Coordinate;
        private string _San;
        private string _Class1;
        private string _Number;
        private string _Class2;

        #endregion

        private BlechTypes _BlechType;

        #endregion

        #region Properties

        #region _

        /// <summary>
        /// 
        /// </summary>
        public string Symbol
        {
            get
            {
                return this._Symbol;
            }
            set
            {
                this._Symbol = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Room
        {
            get
            {
                return this._Room;
            }
            set
            {
                this._Room = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Coordinate
        {
            get
            {
                return this._Coordinate;
            }
            set
            {
                this._Coordinate = value;
                if (value.Length == 2)
                {
                    this._Coordinate = value.Insert(1, "0");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string San
        {
            get
            {
                return this._San;
            }
            set
            {
                this._San = string.IsNullOrEmpty(value) ? value : value.PadLeft(2, '0');
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Class1
        {
            get
            {
                return this._Class1;
            }
            set
            {
                this._Class1 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this._Number = string.IsNullOrEmpty(value) ? value : value.PadLeft(2, '0');
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Class2
        {
            get
            {
                return this._Class2;
            }
            set
            {
                this._Class2 = value;
            }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public BlechTypes BlechType
        {
            get
            {
                return this._BlechType;
            }
            set
            {
                this._BlechType = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses Blech acronym
        /// </summary>
        /// <param name="argAcronym"></param>
        public void Parse(string argAcronym)
        {
            this.Clear();

            // Deletes spaces at the beginning and at the end
            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (argAcronym.Length > 0)
            {
                if (!IsAcronymValid(argAcronym))
                {
                    XtraMessageBox.Show("Blech Acronym could not parsed!", "KabMan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Splits Blech number
                    string[] parts = argAcronym.Split('.');
                    // First part of the Blech number
                    string firstPart = parts[0];

                    if (RegexAssistant.RegexMatched(regex.ServerBlechAcronym, firstPart))
                    {
                        this._BlechType = BlechTypes.Server;
                    }

                    if (RegexAssistant.RegexMatched(regex.SwitchBlechAcronym, firstPart))
                    {
                        this.BlechType = BlechTypes.Switch;
                    }

                    if (this.BlechType != BlechTypes.Undefined)
                    {
                        // <example name="Rack">[X]xxxXxx.X.xx.X</example>
                        // <example name="Switch">[X]xxxxx.X.xx.X</example>
                        this.Symbol = firstPart.Substring(0, 1);
                        // <example name="Rack">X[xxx]Xxx.X.xx.X</example>
                        // <example name="Switch">X[xxx]xx.X.xx.X</example>
                        this.Room = firstPart.Substring(1, 3);
                        //
                        switch (this.BlechType)
                        {
                            //case BlechTypes.Dasd:
                            //    goto Server;

                            case BlechTypes.Server:
                                // <example name="Rack">Xxxx[Xxx].X.xx.X</example>
                                this.Coordinate = firstPart.Substring(4, (firstPart.Length - 4));
                                this.San = string.Empty;
                                break;
                            case BlechTypes.Switch:
                                // <example name="Switch">Xxxx[xx].X.xx.X</example>
                                this.San = firstPart.Substring(4, (firstPart.Length - 4));
                                this.Coordinate = string.Empty;
                                break;
                        }
                        // <example name="Switch">Xxxxxx.[X].xx.X</example>
                        // <example name="Rack">XxxxXxx.[X].xx.X</example>
                        this.Class1 = parts[1];
                        // <example name="Switch">Xxxxxx.X.[xx].X</example>
                        // <example name="Rack">XxxxXxx.X.[xx].X</example>
                        this.Number = parts[2];
                        // <example name="Switch">Xxxxxx.X.xx.[X]</example>
                        // <example name="Rack">XxxxXxx.X.xx.[X]</example>
                        this.Class2 = parts[3];
                    }
                }
            }
        }

        public void Clear()
        {
            this._Symbol =
                this._Room =
                this._Coordinate =
                this._San =
                this._Class1 =
                this._Number =
                this._Class2 = string.Empty;
            this._BlechType = BlechTypes.Undefined;
        }

        /// <summary>
        /// Checks Acronym validity
        /// </summary>
        /// <param name="argAcronym"></param>
        /// <returns>Boolean value</returns>
        public bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.BlechAcronym, argAcronym);
        }



        #endregion

    }
}
