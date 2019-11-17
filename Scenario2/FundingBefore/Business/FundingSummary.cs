namespace FundingAfter.Business
{
    public class FundingSummary
    {
        public int ProgramId { get; set; }

        public decimal YtdFundingAmount { get; set; }

        public bool FederalApprovalRequired { get; set; }
    }
}
