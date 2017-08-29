namespace NSettings
{
    public interface ISettingsProvider<out TSettings>
    {
        TSettings Get();
    }
}