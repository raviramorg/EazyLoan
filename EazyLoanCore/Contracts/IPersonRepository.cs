using EazyLoanCore.Models;

namespace EazyLoanCore.Contracts
{
    public interface IPersonRepository
    {
        public Person Get(string userName);
        //Other behaviours here...
    }
}
