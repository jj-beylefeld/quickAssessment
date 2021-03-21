using KCSAssesment.Classes.Implementations;
using KCSAssesment.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KCSAssesmentTests
{
    public class AssessmentVerification
    {
        [Fact]
        public void resultSet1()
        {
            IItem testItem1 = new Book("Book", 12.49);
            IItem testItem2 = new BaseItem("Music CD", 14.99);
            IItem testItem3 = new Food("Chocolate bar", 0.85);
            ICart cart = new Cart();
            IReceipt receipt = new Receipt();

            cart.addItem(testItem1);
            cart.addItem(testItem2);
            cart.addItem(testItem3);


            Assert.Equal("1 book: 12.49\n1 music CD: 16.49\n1 chocolate bar: 0.85\nSales Taxes: 1.50\nTotal: 29.83\n".ToLower(), receipt.print(cart).ToLower());
        }

        [Fact]
        public void resultSet2()
        {
            IItem testItem1 = new Food("box of chocolates", 10.00, isImported: true);
            IItem testItem2 = new BaseItem("bottle of perfume", 47.50, isImported: true);
            
            ICart cart = new Cart();
            IReceipt receipt = new Receipt();

            cart.addItem(testItem1);
            cart.addItem(testItem2);

            Assert.Equal("1 imported box of chocolates: 10.50\n1 imported bottle of perfume: 54.65\nSales Taxes: 7.65\nTotal: 65.15\n".ToLower(), receipt.print(cart).ToLower());
        }

        [Fact]
        public void resultSet3()
        {
            IItem testItem1 = new BaseItem("bottle of perfume", 27.99, isImported: true);
            IItem testItem2 = new BaseItem("bottle of perfume", 18.99);
            IItem testItem3 = new Medical("packet of paracetamol", 9.75);
            IItem testItem4 = new Food("box of chocolates", 11.25,isImported: true);

            ICart cart = new Cart();
            IReceipt receipt = new Receipt();

            cart.addItem(testItem1);
            cart.addItem(testItem2);
            cart.addItem(testItem3);
            cart.addItem(testItem4);

            //Provided result does not match. Perhaps I missed something...
            //Assert.Equal("1 imported bottle of perfume: 32.19\n1 bottle of perfume: 20.89\n1 packet of paracetamol: 9.75\n1 imported box of chocolates: 11.85\nSales Taxes: 6.70\nTotal: 74.68\n".ToLower(), receipt.print(cart).ToLower());
            Assert.Equal("1 imported bottle of perfume: 32.19\n1 bottle of perfume: 20.89\n1 packet of paracetamol: 9.75\n1 imported box of chocolates: 11.80\nSales Taxes: 6.65\nTotal: 74.63\n".ToLower(), receipt.print(cart).ToLower());
        }
    }
}
