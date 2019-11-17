using FundingAfter.Database;
using System.Collections.Generic;
using System.Linq;

namespace FundingAfter.Business
{
    public class FundingProcessor
    {
        public FundingSummary AcceptFunding(int targetProgramId, string kind, decimal fundingAmount)
        {
            EntityFramework entities = new EntityFramework();

            // save funding amount
            entities.InsertFunding(targetProgramId, kind, fundingAmount);

            // get ytd amounts using Entity Framework
            List<FundingAmount> ytdAmounts = entities.GetFundingAmounts(targetProgramId);

            decimal totalFunding = ytdAmounts.Sum(f => f.Amount);
            decimal federalFunding = ytdAmounts.Where(f => f.FundingType == "Federal").Sum(f => f.Amount);
            decimal federalPortion = federalFunding / totalFunding;
            bool fedApprovalRequired = federalPortion == .5m;

            return new FundingSummary
            {
                ProgramId = targetProgramId,
                YtdFundingAmount = totalFunding,
                FederalApprovalRequired = fedApprovalRequired
            };
        }
    }
}
