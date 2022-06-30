using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole4
{
    //13 points
    public class TakeHomeCalculator
    {
        private readonly int percent;

        public TakeHomeCalculator(int percent)
        {
            this.percent = percent;
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies)
            {
                total = total.Plus(next);
            }

            Double amount = total.value * (percent / 100d);
            Money tax = Money.Create(Convert.ToInt32(amount), first.currency); //+2 create method

            //+1 extract method
            //+1 make non static
            return total.Minus(tax);
        }
    }
}