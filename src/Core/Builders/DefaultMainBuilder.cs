using System;
using System.Collections.Generic;
using System.Text;

using DI.Extensibility;

namespace DI.Builders
{
    public abstract class DefaultMainBuilder
    {
        internal IList<Type> modules = new List<Type>();

        public virtual DefaultMainBuilder Add<TModule>()
            where TModule : IModule
        {
            var type = typeof(TModule);

            if (modules.IndexOf(type) > -1)
                throw new ArgumentException("Module is just registered.");

            modules.Add(type);

            return this;
        }
    }
}
