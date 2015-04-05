using System.Windows.Forms;
using KabMan.Text;
using System.Diagnostics;

namespace KabMan.Components
{
    public class VtPort : IAcronymComponent
    {

        #region Constructors

        public VtPort()
        {

        }

        public VtPort(string argAcronym)
        {
            this.Parse(argAcronym);
        }

        #endregion

        #region Constants


        #endregion

        #region Fields

        private string _Symbol;
        private string _Room;
        private string _San;
        private string _Class1;
        private string _Number;
        private string _Class2;

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

        #endregion

        #region Methods

        public void Parse(string argAcronym)
        {
            this.Clear();

            // Deletes spaces at the beginning and at the end
            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (argAcronym.Length > 0)
            {

                if (!IsAcronymValid(argAcronym))
                {
                    Debug.WriteLine("VtPort Acronym could not parsed! - " + argAcronym);
                    return;
                }
                else
                {

                    // Splits VtPort acronym
                    string[] parts = argAcronym.Split('.');
                    // First part of the VtPort acronym
                    string firstPart = parts[0];

                    this.Clear();

                    // <example>[X]xxxxx.X.xx.X</example>
                    this.Symbol = firstPart.Substring(0, 1);
                    // <example>X[xxx]xx.X.xx.X</example>
                    this.Room = firstPart.Substring(1, 3);
                    // <example>Xxxx[xx].X.xx.X</example>
                    this.San = firstPart.Substring(4, (firstPart.Length - 4));
                    // <example>Xxxxxx.[X].xx.X</example>
                    this.Class1 = parts[1];
                    // <example>Xxxxxx.X.[xx].X</example>
                    this.Number = parts[2];
                    // <example>Xxxxxx.X.xx.[X]</example>
                    this.Class2 = parts[3];

                }
            }
        }

        public void Clear()
        {
            this._Symbol =
               this._Room =
               this._San =
               this._Class1 =
               this._Number =
               this._Class2 = string.Empty;
        }

        public bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.VtPortAcronym, argAcronym);
        }

        #endregion
    }
}
