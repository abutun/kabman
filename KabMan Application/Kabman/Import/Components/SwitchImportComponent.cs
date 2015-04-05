using KabMan.Components;

namespace KabMan.Import
{
    public class SwitchImportComponent : ImportComponentBase
    {

        #region Constructors

        public SwitchImportComponent()
        {

        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        private Switch _Switch = new Switch();

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Switch Switch
        {
            get
            {
                return this._Switch;
            }
            set
            {
                this._Switch = value;
            }
        }

        #endregion

        #region Methods



        #endregion

    }
}
