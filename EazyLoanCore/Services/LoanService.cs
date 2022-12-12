using EazyLoanCore.Contracts;
using EazyLoanCore.Models;

namespace EazyLoanCore.Services
{
    public class LoanService : ILoanService
    {
        readonly IUserService _userService;
        readonly IPersonRepository _personRepository;
        public LoanService(IUserService userService, IPersonRepository personRepository)
        {
             _userService = userService;
            _personRepository = personRepository;
        }
        
        public bool IsEligibleForLoan(string userId)
        {
            var isUserValid = _userService.IsUserValid(userId);
            
            if(isUserValid is false) return false;

            var person = _personRepository.Get(userId);

            if (person is null) return false;

            if (person.Age < 18 || person.CreditScore < 500)
                return false;

            return true;
        }
    }
}
