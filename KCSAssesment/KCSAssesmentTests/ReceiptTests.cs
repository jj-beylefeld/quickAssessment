using KCSAssesment.Classes.Implementations;
using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KCSAssesmentTests
{
    public class ReceiptTests
    {
        [Fact]
        public void testPrinter()
        {
            IItem testItem = new BaseItem("Box of chocolates",200.00);
            ICart cart = new Cart();
            IReceipt receipt = new Receipt();

            cart.addItem(testItem);


            Assert.Equal("1 Box of chocolates: 220.00\nSales Taxes: 20.00\nTotal: 220.00\n", receipt.print(cart));

        }
    }
}
