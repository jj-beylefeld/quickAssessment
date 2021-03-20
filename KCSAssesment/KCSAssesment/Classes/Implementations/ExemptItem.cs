using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KCSAssesment.Classes;

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

        public ExemptItem(string itemName, bool isImported, double purchasePrice)
        {
            this.itemName = itemName;
            this.isImported = isImported;
            this.purchasePrice = purchasePrice;
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
            return Math.Round((isImported ? purchasePrice * TaxInfo.ImportDutyTaxRate : 0),2);
        }
        public double getTotalTax()
        {
            return getSalesTax() + getImportTax();
        }
    }
}
