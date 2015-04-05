using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Client
{
    public class tDeviceBase
    {

        #region PROPERTIES

        private string _Name;
        /// <summary>
        /// Name of the device
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

        #endregion

        #region METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argValue"></param>
        public virtual void Parse(string argValue)
        {

        }

        #endregion

    }
}
