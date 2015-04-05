using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Client
{
    public static class REGEX
    {
        //
        public static string BLECH_NO = @"^[a-zA-Z]\d{3}[a-zA-Z]?\d{1,2}\.[a-zA-Z]\.\d{1,2}\.[a-zA-Z]";
        //
        public static string BLECH_TYPE_SWITCH = @"^[a-zA-Z]\d{4,5}";
        //
        public static string BLECH_TYPE_RACK = @"^[a-zA-Z]\d{3}[a-zA-Z]";
    }
}
