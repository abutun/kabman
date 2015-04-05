using KabMan.Components;

namespace KabMan.Import
{
    public class DccImportComponent : ImportComponentBase
    {

        #region Constructors

        public DccImportComponent()
        {

        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        private Dcc _Dcc = new Dcc();

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Dcc Dcc
        {
            get
            {
                return this._Dcc;
            }
            set
            {
                this._Dcc = value;
            }
        }

        #endregion

        #region Methods



        #endregion

    }
}
