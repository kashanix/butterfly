using System;

namespace Domain.SeedWork
{
    public class DomainValidationException : Exception
    {
        public string Details { get; }

        public DomainValidationException(string message) : base(message)
        {

        }

        public DomainValidationException(IRule rule) : base(rule.Message)
        {

        }

        public DomainValidationException(string message, string details) : base(message)
        {
            this.Details = details;
        }
    }
}
