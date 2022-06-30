using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole2
{
    //12 points
    public class TakeHomeCalculator
    {
        private readonly int percent;

        public TakeHomeCalculator(int percent)
        {
            this.percent = percent;
        }
        // +1  Rename
        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();   // +1  Rename

            Money total = first;

            foreach (Money next in monies)
            {
                if (!next.currency.Equals(total.currency))
                {
                    throw new Incalculable();
                }
            }

            foreach (Money next in monies)
            {
                total = new Money(total.value + next.value, next.currency);
            }

            Double amount = total.value * (percent / 100d);
            Money tax = new Money(Convert.ToInt32(amount), first.currency);

            if (!total.currency.Equals(tax.currency))
            {
                throw new Incalculable();
            }

            return new Money(total.value - tax.value, first.currency);
        }
    }
}