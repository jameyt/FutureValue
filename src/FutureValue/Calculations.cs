using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue
{
    public class Calculations
    {
        public double CalculateCompoundInterest(double principal, double rate, double years, double compounds)
        {
            return Math.Round(principal * Math.Pow((1 + rate / compounds), years * compounds), 2);
        }
    }
}
