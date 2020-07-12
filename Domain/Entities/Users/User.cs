using Application.SeedWork.Interfaces;
using Domain.Checker;
using Domain.Entities.Users;
using Domain.SeedWork;

namespace Domain.Entities
{
    public class User : BaseEntity, IAggregateRoot
    {
        public static User Create(
            string email,
            string name,
            decimal monthlySalary,
            decimal monthlyExpense,
            IUserUniqueValidation userUniqueChecker)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new DomainValidationException("email can not be empty");
            }

            Validate(new UserExpenseMustBeZeroRule(monthlyExpense));
            Validate(new UserSalaryMustBeZeroRule(monthlyExpense));
            Validate(new UserEmailMustBeUniqueRule(userUniqueChecker, email));

            return new User(email, name, monthlySalary, monthlyExpense);
        }

        private User(string email, string name, decimal monthlySalary, decimal monthlyExpense)
        {
            Email = email;
            Name = name;
            MonthlyExpense = monthlyExpense;
            MonthlySalary = monthlySalary;
        }

        public string Email { get; private set; }

        public string Name { get; private set; }

        public decimal MonthlySalary { get; private set; }
        public decimal MonthlyExpense { get; private set; }

        // user can have one Account, backfield
        public Account Account { get; set; }

        // we can check concurrency 
        //[Timestamp]
        //public byte[] RowVersion { get; set; }

        // we can use valueObject 
        //public Money MonthlySalary { get; set; }
        //public Money MonthlyExpense { get; set; }
    }


}
