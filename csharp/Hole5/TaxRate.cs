using System;

namespace Hole5
{

    //+1 move to own file
    public class TaxRate
    {
        private readonly int percent;

        private TaxRate(int percent)
        {
            this.percent = percent;
        }

        //+1 create factory method
        //+1 rename factory method
        public static TaxRate Of(int percent)
        {
            return new TaxRate(percent);
        }

        //+1 move method
        //+2 remove first parameter
        public Money Apply(Money total)
        {
            //+1 remove redundant this
            Double amount = total.value * (percent / 100d);
            //+1 inline variable
            return Money.Create(Convert.ToInt32(amount), total.currency);
        }
    }
}