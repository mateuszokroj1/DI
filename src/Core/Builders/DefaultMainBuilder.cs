using System;
using System.Collections.Generic;

namespace DI.Builders
{
    public abstract class DefaultMainBuilder<TModuleBuilder> : DefaultBuilder
        where TModuleBuilder : DefaultBuilder
    {
        internal IList<Type> modules = new List<Type>();

        protected virtual DefaultMainBuilder<TModuleBuilder> RegisterDependencies(Action<DependenciesRegister<TModuleBuilder>> register)
        {
            var actionArgument = new DependenciesRegister<TModuleBuilder>(modules);
            register(actionArgument);

            return this;
        }
    }
}
