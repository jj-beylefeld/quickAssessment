using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Implementations
{
    public class ExemptItem : IItem
    {
        public string itemName { get; set; }
        public bool isImported { get; set; }
        public double purchasePrice { get; set; }
        public ExemptItem(string itemName)
        {
            this.itemName = itemName;
        }

        public double getCostPrice()
        {
            return purchasePrice - getSalesTax();
        }
        public double getSalesTax()
        {
            return 0;
        }

        public double getImportTax()
        {
            return Math.Round((isImported ? purchasePrice * 0.05 : 0),6);
        }
        public double getTotalTax()
        {
            return getSalesTax() + getImportTax();
        }
    }
}
