using DI.Extensibility;

namespace DI.Builders
{
    public interface IMainBuilder<TModuleBuilder>
        where TModuleBuilder : DefaultBuilder
    {
        DefaultMainBuilder<TModuleBuilder> Add<TModule>()
            where TModule : IModule<TModuleBuilder>, new();
    }
}