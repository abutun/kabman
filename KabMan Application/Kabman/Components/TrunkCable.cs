using System.Windows.Forms;
using KabMan.Text;
using System.Diagnostics;
using System;

namespace KabMan.Components
{
    public class TrunkCable : JumperCable
    {

        #region Constructors

        public TrunkCable()
        {

        }

        public TrunkCable(string argAcronym)
        {
            this.Parse(argAcronym);
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> Index { get; set; }

        #endregion

        #region Methods

        public override void Parse(string argAcronym)
        {
            this.Clear();

            // Deletes spaces at the beginning and at the end
            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (argAcronym.Length > 0)
            {

                if (!IsAcronymValid(argAcronym))
                {
                    Debug.WriteLine(string.Format("Trunk Cable Acronym could not parsed! [{0}]", argAcronym));
                    return;
                }
                else
                {
                    var hasClass = true;
                    // Splits VtPort acronym
                    string[] parts = argAcronym.Split('.');
                    hasClass = parts.Length > 1;
                    // First part of the VtPort acronym
                    string firstPart = parts[0];

                    this.Clear();

                    // <example>[X]xxxxx.xx</example>
                    this.Symbol = firstPart.Substring(0, 1);
                    // <example>X[xxxxx].xx</example>
                    this.Number = firstPart.Substring(1, firstPart.Length - 1);
                    // <example>Xxxxxx.[xx]</example>
                    this.Class = hasClass ? parts[1] : "";
                }
            }
        }

        public override void Clear()
        {
            this.Class = string.Empty;
            this.Index = null;
            base.Clear();
        }

        public override bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.TrunkCableAcronym, argAcronym);
        }

        #endregion

    }
}
