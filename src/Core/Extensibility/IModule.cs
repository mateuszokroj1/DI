using DI.Builders;

namespace DI.Extensibility
{
    public interface IModule<TBuilder>
        where TBuilder : DefaultBuilder
    {
        void Configure(TBuilder options);
    }
}