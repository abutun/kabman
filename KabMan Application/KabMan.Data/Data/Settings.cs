using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Data
{
    public static class Settings
    {
        private static string _DatabaseName = "KabMan";

        private static string _Version = "1.1.0";

        private static string _ConnectionString = @"Data Source=ORION\SQL2008; Initial Catalog=KabMan; Integrated Security=True";
        /// <summary>
        /// 
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }


        public static string DatabaseName
        {
            get
            {
                return _DatabaseName;
            }
        }

        public static string Version
        {
            get
            {
                return _Version;
            }
        }

    }
}
