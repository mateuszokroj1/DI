using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Builders
{
    public abstract class DefaultSectionBuilder<TTaxonomy> : DefaultBuilder
        where TTaxonomy : ITaxonomy
    {
        public virtual Type TaxonomyType => typeof(TTaxonomy);
    }
}
