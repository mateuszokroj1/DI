using System;
using System.Collections.Generic;

namespace DI.Builders
{
    public abstract class DefaultMainBuilder<TModuleBuilder> : DefaultBuilder
        where TModuleBuilder : DefaultBuilder
    {
        internal virtual IList<Type> Modules { get; } = new List<Type>();

        protected virtual DefaultMainBuilder<TModuleBuilder> RegisterDependencies(Action<DependenciesRegister<TModuleBuilder>> register)
        {
            var actionArgument = new DependenciesRegister<TModuleBuilder>(Modules);
            register(actionArgument);

            return this;
        }
    }
}
