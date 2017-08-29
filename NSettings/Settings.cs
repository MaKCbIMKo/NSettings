namespace NSettings
{
    internal class Settings<TSettings> : SettingsSnapshot<TSettings>, ISettings<TSettings>
    {
        public Settings(ISettingsProvider<TSettings> provider) : base(provider)
        {
        }

        public void Reload()
        {
            Value = Provider.Get();
        }
    }
}