using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Client
{
    public class tBlechPosition
    {

        #region PROPERTIES

        private string _Symbol;
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

        private string _Class1;
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

        private string _Number;
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
                this._Number = value;
            }
        }

        private string _Class2;
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

        private bool _IsConnected;
        /// <summary>
        /// 
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return this._IsConnected;
            }
            set
            {
                this._IsConnected = value;
            }
        }


        #endregion
    }
}
