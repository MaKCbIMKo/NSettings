using Ninject.Syntax;
using NSettings;

namespace Ninject
{
    public static class BindingRootExtension
    {
        public static IBindingWhenInNamedWithOrOnSyntax<TSettingsProvider> RegisterSettingsProvider<TSettingsProvider, TSettings>(this BindingRoot root) where TSettingsProvider : ISettingsProvider<TSettings>
        {
            return root.Bind<ISettingsProvider<TSettings>>().To<TSettingsProvider>();
        }
    }
}