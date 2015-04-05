
namespace KabMan
{
    public static class regex
    {
        //
        public static string BlechAcronym = @"^[a-zA-Z]\d{3}[a-zA-Z]?\d{1,2}\.[a-zA-Z]\.\d{1,2}\.[a-zA-Z]$";
        //
        public static string SwitchBlechAcronym = @"^[a-zA-Z]\d{4,5}";
        //
        public static string ServerBlechAcronym = @"^[a-zA-Z]\d{3}[a-zA-Z]";
        //
        public static string VtPortAcronym = @"^[a-zA-Z]\d{5}\.[a-zA-Z]\.\d{1,2}\.[a-zA-Z]$";
        //
        public static string TrunkCableAcronym = @"^[a-zA-Z]\d{5}(\.\d{1,2})?$";
        //
        public static string JumperCableAcronym = @"^[a-zA-Z]\d{5}$";
        //
        public static string SwitchPageName = @"^SW\d{3}([_]\d{1,2})?\$$";
        //
        public static string CoreSwitchPageName = @"^SW\d{3}\$$";
        //
        public static string EdgeSwitchPageName = @"^SW\d{3}([_]\d{1,2})\$$";
        //
        public static string ServerPageName = @"^S\d{2}\[a-zA-Z]\d{2}?\\$$";
        //
        public static string DasdPageName = @"^D\d{2,3}\ ?[a-zA-Z]\d{1,2}([_]\d{1,2})?\$$";

        public static string DccPageName = @"^S\d{2,3}-S\d{2,3}";
        //
        public static string SwitchName = @"^SW\d{3}([_-]\d{1,2})?$";
        //
        public static string CoreSwitchName = @"^SW\d{3}$";
        //
        public static string EdgeSwitchName = @"^SW\d{3}([_-]\d{1,2})$";
        //
        public static string LocationAcronym = @"^KWA\d{2}$";
        //
        public static string ServerAcronym = @"^S\d{2,3}([a-zA-Z]\d{1,2})";

        public static string DasdAcronym = @"^D\d{3}([a-zA-Z]\d{2})";

        public static string DccAcronym = @"^S\d{2,3}-S\d{2,3}";

        public static string DccName = @"^S\d{2,3}-S\d{2,3}";

    }
}
