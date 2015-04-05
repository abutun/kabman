using KabMan.Components;

namespace KabMan.Import
{
    public class ServerImportComponent : ImportComponentBase
    {

        #region Constructors

        public ServerImportComponent()
        {

        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        private Server _Server = new Server();

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Server Server
        {
            get
            {
                return this._Server;
            }
            set
            {
                this._Server = value;
            }
        }

        #endregion

        #region Methods



        #endregion

    }
}
