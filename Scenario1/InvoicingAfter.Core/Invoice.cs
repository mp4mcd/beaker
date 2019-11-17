using System.Collections.Generic;
using System.Linq;

namespace InvoicingAfter.Core
{
    public class Invoice
    {
        const decimal TAX_RATE = .08m;

        public Invoice(Dictionary<string, decimal> items)
        {
            Items = items;
        }

        public Dictionary<string, decimal> Items { get; }

        public InvoiceOutput CalculateOutput()
        {
            //decimal subTotalAmount = Items.Sum(i => i.Value);
            //decimal discountAmount = subTotalAmount * .05m;
            //decimal taxAmount = subTotalAmount * TAX_RATE;
            //decimal grandTotalAmount = subTotalAmount - discountAmount + taxAmount;

            decimal subTotalAmount = Items.Sum(i => i.Value);
            decimal discountAmount = (subTotalAmount) * .05m;
            decimal taxAmount = (subTotalAmount - discountAmount) * TAX_RATE;
            decimal grandTotalAmount = subTotalAmount - discountAmount + taxAmount;

            return new InvoiceOutput
            {
                SubTotal = subTotalAmount,
                Tax = taxAmount,
                Discount = discountAmount,
                GrandTotal = grandTotalAmount
            };
        }
    }
}

#region correct logic is here
//decimal subTotalAmount = Items.Sum(i => i.Value);
//decimal discountAmount = (subTotalAmount) * .05m;
//decimal taxAmount = (subTotalAmount - discountAmount) * TAX_RATE;
//decimal grandTotalAmount = subTotalAmount - discountAmount + taxAmount;
#endregion