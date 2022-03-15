namespace DI.Taxonomies
{
    public abstract class TaxonomyId
    {
        public virtual ITaxonomy Taxonomy { get; }

        public abstract object Id { get; }
    }
}
