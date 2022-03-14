using System;
using System.Collections.Generic;
using System.Text;

using DI.Extensibility;

namespace DI.Builders
{
    public abstract class DefaultMainBuilder<TModuleBuilder> : IMainBuilder<TModuleBuilder>
        where TModuleBuilder : DefaultBuilder
    {
        internal IList<Type> modules = new List<Type>();

        public virtual DefaultMainBuilder<TModuleBuilder> Add<TModule>()
            where TModule : IModule<TModuleBuilder>, new()
        {
            var type = typeof(TModule);

            if (modules.IndexOf(type) > -1)
                throw new ArgumentException("Module is just registered.");

            modules.Add(type);

            return this;
        }
    }
}
