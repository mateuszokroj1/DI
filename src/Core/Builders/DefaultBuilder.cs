using System;

using DI.Options;
using DI.Taxonomies;

namespace DI.Builders
{
    public abstract class DefaultBuilder
    {
        protected virtual DefaultBuilder Export<TExport>(Action<ExportOptions<TExport>> options)
            where TExport : class
        {
            var actionArgument = new ExportOptions<TExport>();
            options(actionArgument);



            return this;
        }

        protected virtual DefaultBuilder For<TTaxonomy>(TaxonomyId id, Action<DefaultSectionBuilder<TTaxonomy>> register)
            where TTaxonomy : ITaxonomy
        {


            return this;
        }
    }
}
