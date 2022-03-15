using System;
using System.Collections.Generic;

namespace DI.Options
{
    public class ExportOptions<TExport>
    {
        public bool IsLazyLoadingEnabled { get; private set; } = false;

        public List<Type> Groups { get; } = new List<Type>();

        public ExportOptions<TExport> EnableLazyLoading()
        {
            IsLazyLoadingEnabled = true;

            return this;
        }
    }
}
