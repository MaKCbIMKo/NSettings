namespace NSettings
{
    public interface ISettings<out TSettings> : ISettingsSnapshot<TSettings>
    {
        void Reload();
    }
}