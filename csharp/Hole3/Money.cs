using System;

namespace Hole3
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

        //+1 move method to another file
        //+1 make non static
        //+1 rename parameter
        public Money Plus(Money other) //+1 extract method
        {
            // +2 Remove "Money total = this;"
            if (!other.currency.Equals(currency))
            {
                throw new Incalculable();
            }

            //+1 inline
            return new Money(value + other.value, other.currency);
        }
    }
}