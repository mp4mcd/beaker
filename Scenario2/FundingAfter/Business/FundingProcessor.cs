using FundingAfter.Database;
using System.Collections.Generic;
using System.Linq;

namespace FundingAfter.Business
{
    public class FundingProcessor
    {
        #region refactor for repository

        FundingRepository _repository;

        public FundingProcessor(FundingRepository repository)
        {
            _repository = repository;
        }
        
        #endregion

        public FundingSummary AcceptFunding(int targetProgramId, string kind, decimal fundingAmount)
        {
            EntityFramework entities = new EntityFramework();

            // save funding amount
            entities.InsertFunding(targetProgramId, kind, fundingAmount);                       

            // get ytd amounts from repository
            List<FundingAmount> ytdAmounts = _repository.GetFundingAmounts(targetProgramId);

            decimal totalFunding = ytdAmounts.Sum(f => f.Amount);
            decimal federalFunding = ytdAmounts.Where(f => f.FundingType == "Federal").Sum(f => f.Amount);
            decimal federalPortion = federalFunding / totalFunding;
            //bool fedApprovalRequired = federalPortion == .5m;
            bool fedApprovalRequired = federalPortion >= .5m;

            return new FundingSummary
            {
                ProgramId = targetProgramId,
                YtdFundingAmount = totalFunding,
                FederalApprovalRequired = fedApprovalRequired
            };
        }
    }
}
#region corrected line here
//bool fedApprovalRequired = federalPortion >= .5m;
#endregion