using System.IO;
using userSettings = KabMan.Properties.Settings;

namespace KabMan.Import
{

    public class ImportFilesPathValidator
    {

        #region Constructors

        public ImportFilesPathValidator()
        {

        }

        public ImportFilesPathValidator(string argDirectory)
        {
            this.Directory = argDirectory;
        }

        #endregion

        #region Constants



        #endregion

        #region Fields

        private string _Directory;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public bool ContainsAllFiles
        {
            get
            {
                return this.ContainsSwitchFile && this.ContainsServerFile && this.ContainsDasdFile && this.ContainsDCCFile;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ContainsServerFile
        {
            get
            {
                return this.FileExists(userSettings.Default.ImportServerFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ContainsSwitchFile
        {
            get
            {
                return this.FileExists(userSettings.Default.ImportSwitchFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ContainsDasdFile
        {
            get
            {
                return this.FileExists(userSettings.Default.ImportDasdFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ContainsDCCFile
        {
            get
            {
                return this.FileExists(userSettings.Default.ImportDccFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Directory
        {
            get
            {
                if (!string.IsNullOrEmpty(this._Directory))
                {
                    return this._Directory;
                }
                else
                {
                    throw new DirectoryNotDefinedException();
                }
            }
            set
            {
                this._Directory = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ServerFilePath
        {
            get
            {
                return this.CombinePath(userSettings.Default.ImportServerFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SwitchFilePath
        {
            get
            {
                return this.CombinePath(userSettings.Default.ImportSwitchFileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DasdFilePath
        {
            get
            {
                return this.CombinePath(userSettings.Default.ImportDasdFileName);
            }
        }

        public string DCCFilePath
        {
            get
            {
                return this.CombinePath(userSettings.Default.ImportDccFileName);
            }
        }

        #endregion

        #region Methods

        private bool FileExists(string argFileName)
        {
            return File.Exists(this.CombinePath(argFileName));
        }

        private string CombinePath(string argFileName)
        {
            return Path.Combine(this.Directory, argFileName);
        }

        #endregion

    }

}
