namespace DI.Builders
{
    public interface IBuilder<TResult>
    {
        TResult Build();
    }
}
