using System.ComponentModel;

namespace KabMan.Components
{
    /// <summary>
    /// Represents types of blech
    /// </summary>
    [DefaultValue(BlechTypes.Undefined)]
    public enum BlechTypes
    {
        Undefined,
        Server,
        Switch,
        Dasd
    }
}
