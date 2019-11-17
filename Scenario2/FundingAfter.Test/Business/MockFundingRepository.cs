using FundingAfter.Business;
using FundingAfter.Database;
using System.Collections.Generic;

namespace FundingAfter.Test.Business
{
    public class MockFundingRepository : FundingRepository
    {
        public override List<FundingAmount> GetFundingAmounts(int targetProgramId)
        {
            return new List<FundingAmount>
            {
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Federal",
                    Amount = 20
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "State",
                    Amount = 3
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Local",
                    Amount = 4
                }
            };
        }
    }
}
