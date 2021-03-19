using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Implementations
{
    public class Medical : ExemptItem, IItem
    {
        public Medical(string itemName) : base(itemName)
        {
        }

    }
}
