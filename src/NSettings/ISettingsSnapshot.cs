namespace NSettings
{
    public interface ISettingsSnapshot<out TSettings>
    {
        TSettings Value { get; }
    }
}