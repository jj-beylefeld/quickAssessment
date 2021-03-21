using KCSAssesment.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KCSAssesmentTests
{
    public class TaxInfoTest
    {
        [Fact]
        public void roundTest()
        {

            Assert.Equal(3.10, TaxInfo.quarterPointRound(3.075));
            Assert.Equal(3.10, TaxInfo.quarterPointRound(3.076));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.074));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.050));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.026));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.025));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.024));
            Assert.Equal(3.05, TaxInfo.quarterPointRound(3.001));
            Assert.Equal(3.00, TaxInfo.quarterPointRound(2.975));
            Assert.Equal(11.85, TaxInfo.quarterPointRound(11.8125));
        }
    }
}
