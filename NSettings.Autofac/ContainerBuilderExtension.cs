using Autofac.Builder;
using NSettings;

namespace Autofac
{
    public static class ContainerBuilderExtension
    {
        public static IRegistrationBuilder<TSettingsProvider, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterSettingsProvider<TSettingsProvider, TSettings>(this ContainerBuilder builder) where TSettingsProvider : ISettingsProvider<TSettings>
        {
            return builder.RegisterType<TSettingsProvider>().As<ISettingsProvider<TSettings>>();
        }
    }
}