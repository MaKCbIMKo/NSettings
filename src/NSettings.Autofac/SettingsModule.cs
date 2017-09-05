using Autofac;

namespace NSettings.Autofac
{
    public class SettingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Settings<>)).As(typeof(ISettings<>));
            builder.RegisterGeneric(typeof(SettingsSnapshot<>)).As(typeof(ISettingsSnapshot<>));
        }
    }
}