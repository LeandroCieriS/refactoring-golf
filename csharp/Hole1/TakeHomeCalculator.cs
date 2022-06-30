using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole1
{
    // 4 points
    public class TakeHomeCalculator
    {
        private readonly int percent;

        public TakeHomeCalculator(int percent)
        {
            this.percent = percent;
        }

        public Pair<int, String> NetAmount(Pair<int, String> first, params Pair<int, String>[] rest)
        {
            List<Pair<int, String>> pairs = rest.ToList();

            Pair<int, String> total = first;

            foreach (Pair<int, String> next in pairs)
            {
                if (!string.Equals(next.second, total.second)) // +1 Equals
                {
                    throw new Incalculable();
                }
            }

            foreach (Pair<int, String> next in pairs)
            {
                total = new Pair<int, String>(total.first + next.first, next.second);
            }

            Double amount = total.first * (percent / 100d);
            Pair<int, String> tax = new Pair<int, String>(Convert.ToInt32(amount), first.second);

            if (!string.Equals(total.second, tax.second)) // +1 invert if, +1 Equals
            {
                throw new Incalculable();
            }
            // +1 remove else
            return new Pair<int, String>(total.first - tax.first, first.second);
        }
    }
}