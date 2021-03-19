using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCSAssesment.Classes.Implementations
{
    public class Book : ExemptItem, IItem
    {
        public Book(string itemName) : base(itemName)
        {
        }
    }
}
