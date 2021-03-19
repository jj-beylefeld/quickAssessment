using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Interfaces
{
    public interface IItem
    {
        public string itemName { get; set; }
        public bool isImported { get; set; }
        public double purchasePrice { get; set; }
        
        public double getCostPrice();
        public double getSalesTax();
        public double getImportTax();
        public double getTotalTax();
    }
}
