using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Interfaces
{
    public interface IReceipt
    {
        public void print(ICart cart);
    }
}
