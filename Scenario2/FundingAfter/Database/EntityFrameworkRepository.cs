using FundingAfter.Business;
using System.Collections.Generic;

namespace FundingAfter.Database
{
    public class EntityFrameworkRepository : FundingRepository
    {
        public override List<FundingAmount> GetFundingAmounts(int targetProgramId)
        {
            // Pretend this is really going to the database.
            List<FundingAmount> amounts = new List<FundingAmount>
            {
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Federal",
                    Amount = 2000
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Federal",
                    Amount = 8000
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "State",
                    Amount = 1000
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Local",
                    Amount = 1000m
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Local",
                    Amount = 600m
                },
                new FundingAmount {
                    ProgramId = targetProgramId ,
                    FundingType = "Local",
                    Amount = 400m
                }

            };

            return amounts;
        }
    }
}
