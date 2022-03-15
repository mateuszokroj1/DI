namespace DI.Taxonomies
{
    public interface ITaxonomyId<out TId, out TTaxonomy>
        where TTaxonomy : ITaxonomy
    {
        TTaxonomy Taxonomy { get; }

        TId Id { get; }
    }
}
