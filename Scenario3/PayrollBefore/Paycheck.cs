namespace PayrollBefore
{
    public class Paycheck
    {
        decimal _grossPay;

        public Paycheck(decimal grossPay)
        { _grossPay = grossPay; }

        public decimal GetNetPay()
        {
            decimal _netPay = _grossPay;

            _netPay -= GetFederalTax();
            _netPay -= GetMedical();
            _netPay -= GetDental();

            return 0m;
        }

        private decimal GetFederalTax()
        {
            return _grossPay * .1m;
        }

        private decimal GetMedical()
        {
            return _grossPay * .15m;
        }

        // Here's the method we're interested in but can't see during unit testing.
        private decimal GetDental()
        {
            return _grossPay * .001m;
        }


    }
}
