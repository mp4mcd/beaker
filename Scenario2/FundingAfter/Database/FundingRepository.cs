using FundingAfter.Business;
using System.Collections.Generic;

namespace FundingAfter.Database
{
    public abstract class FundingRepository
    {
        public abstract List<FundingAmount> GetFundingAmounts(int targetProgramId);
    }
}
