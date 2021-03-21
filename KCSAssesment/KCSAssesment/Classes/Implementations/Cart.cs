using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Implementations
{
    public class Cart : ICart
    {
        public List<IItem> items { get; }

        public Cart()
        {
            items = new List<IItem>();
        }

        public void addItem(IItem item)
        {
            if (items.Where(x => x.itemName == item.itemName && x.purchasePrice == item.purchasePrice).Any())
                throw new InvalidOperationException("Should we be adding duplicates or increasing the count??");
            items.Add(item);

        }

        public void removeItem(IItem item)
        {
            if (items.Contains(item))
                items.Remove(item);
        }

        public double getTotalCost()
        {
            double sum = 0;
            foreach( var item in items)
            {
                sum += item.finalPrice;
            }
            return sum;
        }

        public double getTotalSalesTax()
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item.getTotalTax();
            }
            return sum;
        }
    }
}
