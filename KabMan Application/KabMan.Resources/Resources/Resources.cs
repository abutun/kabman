using System.Drawing;
using System.Reflection;
using System.IO;

namespace KabMan
{
    public static class Resources
    {
        private static Assembly VAR_Assembly;

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
            VAR_Assembly = Assembly.GetExecutingAssembly();
            retValue = VAR_Assembly.GetManifestResourceStream(TryGetFullResourceNameByKey(argKey));
            return retValue;
        }

        private static string TryGetFullResourceNameByKey(string argKey)
        {
            string retValue = "KabMan.Resources.Images.Error16.png"
;
            foreach (string resource in VAR_Assembly.GetManifestResourceNames())
            {
                string[] nameParts = resource.Split('.');
                if (nameParts[nameParts.Length - 2].ToLower() == argKey.ToLower())
                {
                    retValue = resource;
                }
            }
            return retValue;
        }
    }
}
