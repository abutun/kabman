
namespace KabMan.Components
{
    public interface IAcronymComponent
    {
        void Parse(string argAcronym);
        void Clear();
        bool IsAcronymValid(string argAcronym);
    }
}
