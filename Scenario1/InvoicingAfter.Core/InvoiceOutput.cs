namespace InvoicingAfter.Core
{
    public class InvoiceOutput
    {
        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public decimal GrandTotal { get; set; }
    }
}
