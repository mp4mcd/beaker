using FundingAfter.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundingAfter.Test
{
    [TestClass]
    public class FundingProcessorTester
    {
        [TestMethod]
        public void FedApprovalRequiredIssue()
        {
            // test using database
            FundingProcessor processor = new FundingProcessor();
            FundingSummary summary = processor.AcceptFunding(409, "Federal", 500m);
            Assert.IsTrue(summary.FederalApprovalRequired);
        }
    }
}
