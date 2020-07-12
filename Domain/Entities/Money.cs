using Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Money : ValueObject
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }

        public Money(string currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Currency;
            yield return Amount;
        }
    }
}
