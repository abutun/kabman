using KabMan.Components;

namespace KabMan.Import
{
    public class ImportComponentBase
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public JumperCable LcUrmCable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Blech Blech { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TrunkCable TrunkCable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public VtPort VtPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public JumperCable UrmUrmCable { get; set; }

        #endregion

    }
}
