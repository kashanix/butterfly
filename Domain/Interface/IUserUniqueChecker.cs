namespace Domain.Checker
{
    public interface IUserUniqueValidation
    {
        bool IsUnique(string email);
    }
}
