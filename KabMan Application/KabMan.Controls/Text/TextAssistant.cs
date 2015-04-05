using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Text
{
    public static class TextAssistant
    {
        public static string TryConvertToString(object argObject)
        {
            try
            {
                return argObject.ToString();
            }
            catch (System.Exception ex)
            {

            }
            return string.Empty;
        }

    }
}
