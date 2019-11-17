using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollBefore;

namespace PayrollAfter.Test
{

    [TestClass]
    public class PaycheckTester
    {
        [TestMethod]
        public void VerifyDental()
        {
            #region test that wouldn't work because GetDental is private

            //Paycheck paycheck = new Paycheck(1000m);
            //decimal dental = paycheck.GetDental();
            //Assert.AreEqual(1m, dental);

            #endregion

            #region use subclass instead

            PaycheckSubclass paycheck = new PaycheckSubclass(1000m);
            decimal dental = paycheck.GetDentalForTesting();
            Assert.AreEqual(1m, dental);

            #endregion


        }
    }
}
