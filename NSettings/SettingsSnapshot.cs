namespace NSettings
{
    internal class SettingsSnapshot<TSettings> : ISettingsSnapshot<TSettings>
    {
        protected readonly ISettingsProvider<TSettings> Provider;

        public SettingsSnapshot(ISettingsProvider<TSettings> provider)
        {
            Provider = provider;

            Value = Provider.Get();
        }

        public TSettings Value { get; protected set; }
    }
}