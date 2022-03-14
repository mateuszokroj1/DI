using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Builders
{
    public abstract class DefaultBuilder
    {
        protected virtual DefaultBuilder Export<TExport>()
            where TExport : class
        {

            return this;
        }
    }
}
