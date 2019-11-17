using PayrollBefore;

namespace PayrollAfter.Test
{
    public class PaycheckSubclass : Paycheck
    {
        public PaycheckSubclass(decimal grossPay) : base(grossPay)
        {
        }

        public decimal GetDentalForTesting()
        {
            return base.GetDental();
        }
    }
}
