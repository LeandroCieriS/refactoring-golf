using System.Linq;

namespace Hole6
{
    // 7 points
    public class TakeHomeCalculator
    {
        private readonly TaxRate taxRate;

        public TakeHomeCalculator(TaxRate taxRate)
        {
            this.taxRate = taxRate;
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            //+1 to linq
            //+1 rename first
            //+1 rename x
            //+1 inline
            //+2 remove toList
            //+1 remove unused usings
            Money total = rest.Aggregate(first, (money, x) => money.Plus(x));
            Money tax = taxRate.Apply(total);
            return total.Minus(tax);
        }
    }
}