using System.Windows.Forms;
using KabMan.Text;
using DevExpress.XtraEditors;

namespace KabMan.Components
{
    public class JumperCable : CableBase, IAcronymComponent
    {

        #region Constructors

        public JumperCable()
        {

        }

        public JumperCable(string argAcronym)
        {
            this.Parse(argAcronym);
        }

        #endregion

        #region Constants


        #endregion

        #region Fields



        #endregion

        #region Properties



        #endregion

        #region Methods

        public virtual void Parse(string argAcronym)
        {
            this.Clear();

            // Deletes spaces at the beginning and at the end
            argAcronym = argAcronym.Trim().Replace(" ", "");

            if (argAcronym.Length > 0)
            {
                if (!IsAcronymValid(argAcronym))
                {
                    XtraMessageBox.Show("Jumper Cable Acronym could not parsed!", "KabMan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // <example>[X]xxxxx</example>
                    this.Symbol = argAcronym.Substring(0, 1);
                    // <example>X[xxxxx]</example>          
                    this.Number = argAcronym.Substring(1, argAcronym.Length - 1);
                }
            }
        }

        public virtual void Clear()
        {
            this.Symbol =
            this.Number = string.Empty;
        }

        public virtual bool IsAcronymValid(string argAcronym)
        {
            return RegexAssistant.RegexMatched(regex.JumperCableAcronym, argAcronym);
        }

        #endregion
    }
}
