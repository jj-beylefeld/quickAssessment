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
        public int quantity { get; set; }
        public double finalPrice 
        { 
            get { return purchasePrice + getTotalTax(); }
        }

        public ExemptItem(string itemName)
        {
            this.itemName = itemName;
        }

        public ExemptItem(string itemName, double purchasePrice, int quantity = 1, bool isImported = false)
        {
            this.itemName = itemName;
            this.purchasePrice = purchasePrice;
            this.quantity = quantity;
            this.isImported = isImported;
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
            return (isImported ? purchasePrice * TaxInfo.ImportDutyTaxRate : 0).quarterPointRound();
        }
        public double getTotalTax()
        {
            return getSalesTax() + getImportTax();
        }
    }
}
