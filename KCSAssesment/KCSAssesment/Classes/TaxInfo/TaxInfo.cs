using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes
{
    public static class TaxInfo
    {
        public static double BasicTaxRate = 0.1;
        public static double ImportDutyTaxRate = 0.05;

        public static double quarterPointRound(this double value)
        {
            //3.075
            var  test = (value*10 % 1) / 0.25;

            if (test == 0)
                return value;
            if (test >= 3)
                return (double)((int)(value*10) + 1)/10;
            if (test >= 0)
                return (double)((int)(value*10) + 0.5)/10;
            
            return (int)value;
        }
    }
}
