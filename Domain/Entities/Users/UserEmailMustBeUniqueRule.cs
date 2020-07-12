using Domain.Checker;
using Domain.SeedWork;

namespace Domain.Entities.Users
{
    public class UserSalaryMustBeZeroRule : IRule
    {
        private readonly decimal _monthlySalary;

        public UserSalaryMustBeZeroRule(decimal monthlySalary)
        {
            _monthlySalary = monthlySalary;
        }

        public string Message => "monthlySalary should be greater than 0";

        public bool IsValid()
        {
            return _monthlySalary < 0;
        }
    }

    public class UserExpenseMustBeZeroRule : IRule
    {
        private readonly decimal _monthlyExpense;

        public UserExpenseMustBeZeroRule(decimal MonthlyExpense)
        {
            _monthlyExpense = MonthlyExpense;
        }
        public string Message => "MonthlyExpense should be greater than 0";

        public bool IsValid()
        {
            return _monthlyExpense < 0;
        }
    }
    
    public class UserEmailMustBeUniqueRule : IRule
    {
        private readonly IUserUniqueValidation _userUniquenessChecker;

        private readonly string _email;

        public UserEmailMustBeUniqueRule(IUserUniqueValidation userUniquenessChecker, string email)
        {
            _userUniquenessChecker = userUniquenessChecker;
            _email = email;
        }

        public bool IsValid() => !_userUniquenessChecker.IsUnique(_email);

        public string Message => "email already exists.";
    }
}
