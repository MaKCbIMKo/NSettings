using Ninject.Modules;

namespace NSettings.Ninject
{
    public class SettingsModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ISettings<>)).To(typeof(Settings<>));
            Bind(typeof(ISettingsSnapshot<>)).To(typeof(SettingsSnapshot<>));
        }
    }
}