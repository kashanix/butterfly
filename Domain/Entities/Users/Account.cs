using Domain.SeedWork;

namespace Domain.Entities
{
    public class Account : BaseEntity
    {
        public decimal Credit { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
