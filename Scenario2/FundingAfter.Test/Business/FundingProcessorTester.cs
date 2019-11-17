using FundingAfter.Business;
using FundingAfter.Test.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundingAfter.Test
{
    [TestClass]
    public class FundingProcessorTester
    {
        [TestMethod]
        public void FedApprovalRequiredIssue()
        {
            // test using mock
            FundingProcessor processor = new FundingProcessor(new MockFundingRepository());
            FundingSummary summary = processor.AcceptFunding(409, "Federal", 500m);
            Assert.IsTrue(summary.FederalApprovalRequired);
        }
    }
}
