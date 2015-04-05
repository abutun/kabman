using System.Text.RegularExpressions;

namespace KabMan.Text
{
    public static class RegexAssistant
    {
        public static bool RegexMatched(string argRegex, string argString)
        {
            if (string.IsNullOrEmpty(argString) || string.IsNullOrEmpty(argRegex))
            {
                return false;
            }
            Regex matchRegex = new Regex(argRegex);
            return matchRegex.IsMatch(argString);
        }
    }
}
