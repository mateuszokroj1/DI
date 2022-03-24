using System;

using DI.Builders;

namespace DI.Core.Tests.Fixtures
{
    public class ExampleDefaultMainBuilder : DefaultMainBuilder<ExampleDefaultBuilder>
    {
        public DefaultMainBuilder<ExampleDefaultBuilder> InvokeRegisterDependencies(Action<DependenciesRegister<ExampleDefaultBuilder>> register)
            => RegisterDependencies(register);
    }
}
