using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace InvoicingAfter.Core.Test
{
    [TestClass]
    public class InvoiceTester
    {
        [TestMethod]
        public void InvalidTotal()
        {
            Dictionary<string, decimal> items = new Dictionary<string, decimal>();
            items.Add("This", 25);
            items.Add("That", 60);
            items.Add("Other", 15);

            Invoice invoice = new Invoice(items);
            InvoiceOutput output = invoice.CalculateOutput();
                        Assert.AreEqual(100m, output.SubTotal);
            Assert.AreEqual(5, output.Discount);
            Assert.AreEqual(7.60m, output.Tax);
            Assert.AreEqual(102.60m, output.GrandTotal);

          

        }
    }
}

#region more test assertions are here

#endregion