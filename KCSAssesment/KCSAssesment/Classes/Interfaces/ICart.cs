using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Interfaces
{
    public interface ICart
    {
        public List<IItem> items {get;}
        public void addItem(IItem item);
        public void removeItem(IItem item);

        public double getTotalCost();
        public double getTotalSalesTax();

    }
}
