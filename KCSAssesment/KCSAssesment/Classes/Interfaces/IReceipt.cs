using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Interfaces
{
    public interface IReceipt
    {
        public string print(ICart cart);
    }
}
