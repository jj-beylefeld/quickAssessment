using KCSAssesment.Classes.Implementations;
using KCSAssesment.Classes.Interfaces;
using System;
using Xunit;

namespace KCSAssesmentTests
{
    public class ItemTests
    {
        [Fact]
        public void BookItemHasNotSalesTax()
        {
            IItem book = new Book("Harry Potter");
            book.purchasePrice = 199.99;

            Assert.Equal(0,book.getSalesTax());
        }

        [Fact]
        public void LocalBookItemHasNoImportTax()
        {
            IItem book = new Book("Harry Potter");
            book.purchasePrice = 199.99;

            Assert.Equal(0, book.getImportTax());
        }

        [Fact]
        public void LocalBookItemHasNoTax()
        {
            IItem book = new Book("Harry Potter");
            book.purchasePrice = 199.99;

            Assert.Equal(0, book.getTotalTax());
        }
        [Fact]
        public void importedBookItemHasImportTax()
        {
            IItem book = new Book("Harry Potter");
            book.purchasePrice = 199.99;
            book.isImported = true;

            Assert.Equal(10, book.getImportTax());
        }
        [Fact]
        public void importedBookItemTotalTaxIsImportTax()
        {
            IItem book = new Book("Harry Potter");
            book.purchasePrice = 199.99;
            book.isImported = true;

            Assert.Equal(10, book.getImportTax());
            Assert.Equal(10, book.getTotalTax());
            Assert.Equal(book.getImportTax(), book.getTotalTax());
        }

    }
}
