using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace KabMan
{
    public static class Resources
    {
        private static Assembly VAR_Assembly;

        private static string _AssemblyPath;
        /// <summary>
        /// 
        /// </summary>
        public static string AssemblyPath
        {
            get
            {
                string defaultPath = Application.StartupPath + "\\Kabman.Resources.dll";
                
                try
                {
                    if (File.Exists(defaultPath))
                    {
                        return defaultPath;
                    }
                    else
                    {
                        return "C:\\Documents and Settings\\3xplor3r\\My Documents\\Visual Studio 2008\\Projects\\CSharp\\KabManApplication\\Kabman\\bin\\Debug\\KabMan.Resources.dll";
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                return string.Empty;
            }
            set
            {
                _AssemblyPath = value;
            }
        }

        public static Image GetImage(string argKey)
        {
            Image retValue;
            retValue = Image.FromStream(GetObject(argKey));
            return retValue;
        }

        public static Icon GetIcon(string argKey)
        {
            Icon retValue;
            retValue = new Icon(GetObject(argKey));
            return retValue;
        }

        private static Stream GetObject(string argKey)
        {
            Stream retValue = Stream.Null;
            try
            {
                LoadAssembly();
                retValue = VAR_Assembly.GetManifestResourceStream(TryGetFullResourceNameByKey(argKey));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        private static void LoadAssembly()
        {
            VAR_Assembly = Assembly.LoadFile(AssemblyPath);
        }

        private static string TryGetFullResourceNameByKey(string argKey)
        {
            string retValue = string.Empty;
            foreach (string resource in VAR_Assembly.GetManifestResourceNames())
            {
                string[] nameParts = resource.Split('.');
                if (nameParts[nameParts.Length - 2].ToLower() == argKey.ToLower())
                {
                    return resource;
                }
            }
            return retValue;
        }
    }
}
