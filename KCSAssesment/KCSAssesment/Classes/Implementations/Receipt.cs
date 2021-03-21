using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Implementations
{
    public class Receipt : IReceipt
    {
        public string print(ICart cart)
        {
            string result = "";
            foreach (var item in cart.items)
            {
                result += string.Format("{0} {1}{2}: {3:0.00}\n"
                    , item.quantity
                    , item.isImported ? "Imported " : ""
                    , item.itemName
                    , item.finalPrice);
            }
            result += string.Format("Sales Taxes: {0:0.00}\n", cart.getTotalSalesTax());
            result += string.Format("Total: {0:0.00}\n", cart.getTotalCost());

            return result;
        }
    }
}
