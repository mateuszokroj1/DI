using System;
using System.Collections.Generic;

using DI.Extensibility;

namespace DI.Builders
{
    public class DependenciesRegister<TModuleBuilder>
        where TModuleBuilder : DefaultBuilder
    {
        public DependenciesRegister(IList<Type> list) =>
            this.list = list;

        private readonly IList<Type> list;

        public DependenciesRegister<TModuleBuilder> Add<TModule>()
            where TModule : IModule<TModuleBuilder>, new()
        {
            var type = typeof(TModule);

            if (list.IndexOf(type) > -1)
                throw new ArgumentException("Module is just registered.");

            list.Add(type);

            return this;
        }
    }
}
