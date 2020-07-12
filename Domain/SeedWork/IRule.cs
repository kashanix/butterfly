namespace Domain.SeedWork
{
    public interface IRule
    {
        bool IsValid();

        string Message { get; }
    }
}
