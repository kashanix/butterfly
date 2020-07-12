using System.Collections.Generic;
using System.Text;

namespace Domain.SeedWork
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }

        protected static void Validate(IRule rule)
        {
            if (rule.IsValid())
            {
                throw new DomainValidationException(rule);
            }
        }
    }
}
