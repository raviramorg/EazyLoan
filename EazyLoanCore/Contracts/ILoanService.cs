namespace EazyLoanCore.Contracts
{
    public interface ILoanService
    {
        bool IsEligibleForLoan(string userId);
    }
}
