
namespace KabMan.Components
{
    public class CableBase
    {

        #region Fields

        private string _Symbol;
        private string _Number;

        #endregion

        #region Properties

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

        #endregion

    }
}
