using EazyLoanCore.Contracts;
using EazyLoanCore.Models;

namespace EazyLoanCore.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public PersonRepository()
        {
            //data context injected here
        }

        public Person Get(string userName)
        {
            var person = new Person();
            //loads of logic here to het this gus using the data context
            return person;
        }
    }
}
