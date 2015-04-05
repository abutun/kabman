using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace KabMan
{
    public class RegistryHelper
    {
        private static string FormRegKey(string sSect)
        {
            return sSect;
        }

        public static void SaveSetting(string Section, string Key, string Setting)
        {
            string text1 = FormRegKey(Section);
            RegistryKey key1 = Application.UserAppDataRegistry.CreateSubKey(text1);
            if (key1 == null)
            {
                return;
            }
            try
            {
                key1.SetValue(Key, Setting);
            }
            catch
            {
                return;
            }
            finally
            {
                key1.Close();
            }

        }

        public static string GetSetting(string Section, string Key, string Default /* = "" */)
        {
            if (Default == null)
            {
                Default = "";
            }
            string text2 = FormRegKey(Section);
            RegistryKey key1 = Application.UserAppDataRegistry.OpenSubKey(text2);
            if (key1 != null)
            {
                object obj1 = key1.GetValue(Key, Default);
                key1.Close();
                if (obj1 != null)
                {
                    if (!(obj1 is string))
                    {
                        return null;
                    }
                    return (string)obj1;
                }
                return null;
            }
            return Default;
        }
    }
}