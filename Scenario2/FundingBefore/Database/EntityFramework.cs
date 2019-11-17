using FundingAfter.Business;
using System.Collections.Generic;

namespace FundingAfter.Database
{
    public class EntityFramework
    {
        public void InsertFunding(int targetProgram, string fundingType, decimal fundingAmount)
        {
            // pretend we insert data here.
        }

        public List<FundingAmount> GetFundingAmounts(int programId)
        {
            List<FundingAmount> amounts = new List<FundingAmount>
            {
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "Federal",
                    Amount = 2000
                },
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "Federal",
                    Amount = 8000
                },
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "State",
                    Amount = 1000
                },
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "Local",
                    Amount = 1000m
                },
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "Local",
                    Amount = 600m
                },
                new FundingAmount {
                    ProgramId = programId ,
                    FundingType = "Local",
                    Amount = 400m
                }

            };

            return amounts;
        }

    }
}
