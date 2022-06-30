using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole5
{
    //14 points
    public class TakeHomeCalculator
    {
        //+1 extract class
        private readonly TaxRate taxRate;

        public TakeHomeCalculator(TaxRate taxRate) //+2 use class instead of int
        {
            this.taxRate = taxRate;
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies)
            {
                total = total.Plus(next);
            }

            //+1 extract method
            //+1 remove parameter
            var tax = taxRate.Apply(total);
            return total.Minus(tax);
        }
    }
}