using EazyLoanCore.Contracts;

namespace EazyLoanCore.Services
{
    public class UserService : IUserService
    {
        public bool IsUserValid(string userId)
        {            
            if (userId is null) return false;

            //other checks here            
            //loads of processing here
            //...
            //...
            //...        
            return true;
        }
    }
}
