namespace DI
{
    public interface ITaxonomy
    {
        string Name { get; }

        ITaxonomy Parent { get; }
    }
}
