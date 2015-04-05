using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KabMan.Client
{
    public class tBlech : tDeviceBase
    {

        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        public tBlech()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argBlechNo"></param>
        public tBlech(string argBlechNo)
        {
            this.Parse(argBlechNo);
        }

        #endregion

        #region PROPERTIES

        private string _SerialNo;
        /// <summary>
        /// 
        /// </summary>
        public string SerialNo
        {
            get
            {
                return this._SerialNo;
            }
            set
            {
                this._SerialNo = value;
            }
        }

        private bool _InUse;
        /// <summary>
        /// 
        /// </summary>
        public bool InUse
        {
            get
            {
                return this._InUse;
            }
            set
            {
                this._InUse = value;
            }
        }

        private tDevices _DeviceType;
        /// <summary>
        /// 
        /// </summary>
        public tDevices DeviceType
        {
            get
            {
                return this._DeviceType;
            }
            set
            {
                this._DeviceType = value;
            }
        }

        private tBlechTypes _Type;
        /// <summary>
        /// 
        /// </summary>
        public tBlechTypes Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }

        private string _Room;
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

        private string _San;
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
                this._San = value;
            }
        }

        private List<tBlechPosition> _Positions;
        /// <summary>
        /// 
        /// </summary>
        public List<tBlechPosition> Positions
        {
            get
            {
                return this._Positions;
            }
            set
            {
                this._Positions = value;
            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argValue"></param>
        public override void Parse(string argValue)
        {
            Regex LVAR_CheckBlech = new Regex(REGEX.BLECH_NO);
            if (LVAR_CheckBlech.IsMatch(argValue))
            {
                Dictionary<string, string> LVAR_Parsed = tParser.ParseBlechNo(argValue);
                //this._Symbol = LVAR_Parsed["Symbol"];
                this.Room = LVAR_Parsed["Room"];
                this._San = LVAR_Parsed["San"];
                //this._Coordinate = LVAR_Parsed["Coordinate"];
                //this._Class1 = LVAR_Parsed["Class1"];
                //this._Number = LVAR_Parsed["Number"];
               // this._Class2 = LVAR_Parsed["Class2"];
            }
            else
            {
                throw new tInvalidBlechNoException(string.Format("Blech No is invalid [{0}]", argValue));
            }

        }

        #endregion

    }
}
