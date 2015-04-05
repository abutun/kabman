using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KabMan.Text
{

    public static class tParser
    {
        /// <summary>
        /// Parses Blech number parts
        /// </summary>
        /// <param name="argBlechNo">Blech number to parse</param>
        /// <returns>
        /// Keys and values of blech no in a dictionary according to type of the Blech number
        /// </returns>
        public static Dictionary<string, string> ParseBlechNo(string argBlechNo)
        {
            // Deletes spaces at the beginning and at the end
            argBlechNo = argBlechNo.Trim();
            // Deleted all spaces
            argBlechNo = argBlechNo.Replace(" ", "");
            // Return value variable
            Dictionary<string, string> retVal = new Dictionary<string, string>();
            // Splits Blech number
            string[] parts = argBlechNo.Split('.');
            // First part of the Blech number
            string lv_FirstPart = parts[0];
            //
            Regex lv_RegexBlechType;
            // Regex to determine Rack Blech type
            lv_RegexBlechType = new Regex(REGEX.BLECH_TYPE_RACK);
            // Variable to hold Blech type
            string lv_BlechType = null;
            // Checks whether the first part matches
            if (lv_RegexBlechType.IsMatch(lv_FirstPart))
            {
                lv_BlechType = "Rack";
            }
            // Regex to determine Switch Blech type
            lv_RegexBlechType = new Regex(REGEX.BLECH_TYPE_SWITCH);
            // Checks whether the first part matches
            if (lv_RegexBlechType.IsMatch(lv_FirstPart))
            {
                lv_BlechType = "Switch";
            }
            //
            if (lv_BlechType != null)
            {

                // Adds BlechNo to the dictionary
                // <example name="Rack">[X]xxxXxx.X.xx.X</example>
                // <example name="Switch">[X]xxxxx.X.xx.X</example>
                retVal.Add("Symbol", lv_FirstPart.Substring(0, 1));
                // Adds BlechNo to the dictionary
                // <example name="Rack">X[xxx]Xxx.X.xx.X</example>
                // <example name="Switch">X[xxx]xx.X.xx.X</example>
                retVal.Add("Room", lv_FirstPart.Substring(1, 3));
                //
                switch (lv_BlechType)
                {
                    case "Rack":
                        // Checks whether Coordinate length is 2 or 3
                        if (lv_FirstPart.Length == 6)
                        {
                            // Inserts a zero if Coordinate length is 2
                            lv_FirstPart = lv_FirstPart.Insert(5, "0");
                        }
                        // Adds BlechNo to the dictionary
                        // <example name="Rack">Xxxx[Xxx].X.xx.X</example>
                        retVal.Add("Coordinate", lv_FirstPart.Substring(4, 3));
                        retVal.Add("San", "");
                        break;
                    case "Switch":
                        // Checks whether San length is 1 or 2
                        if (lv_FirstPart.Length == 5)
                        {
                            // Inserts a zero if San length is 1
                            lv_FirstPart = lv_FirstPart.Insert(4, "0");
                        }
                        // Adds BlechNo to the dictionary
                        // <example name="Switch">Xxxx[xx].X.xx.X</example>
                        retVal.Add("San", lv_FirstPart.Substring(4, 2));
                        retVal.Add("Coordinate", "");
                        break;
                }
                // Adds Class1 to the dictionary
                // <example name="Switch">Xxxxxx.[X].xx.X</example>
                // <example name="Rack">XxxxXxx.[X].xx.X</example>
                retVal.Add("Class1", parts[1]);
                // Adds BlechNo to the dictionary
                // <example name="Switch">Xxxxxx.X.[xx].X</example>
                // <example name="Rack">XxxxXxx.X.[xx].X</example>
                // Checks whether BlechNo length is 1 or 2
                if (parts[2].Length == 1)
                {
                    // Inserts a zero if San length is 1
                    parts[2] = parts[2].Insert(0, "0");
                }
                retVal.Add("Number", parts[2]);
                // Adds Class2 to the dictionary
                // <example name="Switch">Xxxxxx.X.xx.[X]</example>
                // <example name="Rack">XxxxXxx.X.xx.[X]</example>
                retVal.Add("Class2", parts[3]);
            }
            // Returns value
            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argVtPortNo"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseVtPortNo(string argVtPortNo)
        {
            // Return value variable
            Dictionary<string, string> retVal = new Dictionary<string, string>();
            //
            retVal = ParseBlechNo(argVtPortNo);
            /*
            // Checks whether dictionary contains BlechNo key
            if (retVal.ContainsKey("BlechNo"))
            {
                // Recovers BlechNo value
                string tmp = retVal["BlechNo"];
                // Removes BlechNo key and value from dictionary
                retVal.Remove("BlechNo");
                // Adds new VtPortNo and recovered value
                retVal.Add("VtPortNo", tmp);
            }
            */
            // Returns value
            return retVal;
        }
    }
}
