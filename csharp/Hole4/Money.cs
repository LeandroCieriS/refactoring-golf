using System;

namespace Hole4
{
    public class Money
    {
        public readonly int value;
        public readonly String currency;

        public Money(int value, String currency)
        {
            this.value = value;
            this.currency = currency;
        }

        //+2 implement method
        public static Money Create(int value, string currency)
        {
            return new Money(value, currency);
        }

        public Money Plus(Money other)
        {
            if (!other.currency.Equals(currency))
            {
                throw new Incalculable();
            }
            //+2 use Create method instead of new
            return Create(value + other.value, other.currency);
        }

        //+1 rename tax
        public Money Minus(Money other)
        {
            //+2 remove first
            if (!currency.Equals(other.currency))
            {
                throw new Incalculable();
            }

            //+2 use Create method instead of new
            return Create(value - other.value, currency);
        }
    }
}