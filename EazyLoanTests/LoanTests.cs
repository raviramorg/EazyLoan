using EazyLoanCore.Contracts;
using EazyLoanCore.Models;
using EazyLoanCore.Services;
using Moq;
using System.ComponentModel.DataAnnotations;

namespace EazyLoanTests
{
    public class LoanTests
    {
        [SetUp]
        public void Setup()
        {
            //we could also initialize the mocks here!
        }

        [Test]
        public void IsEligibleForLoanWorks()
        {            
            Mock<IUserService> mockUserService = new();
            Mock<IPersonRepository> mockPersonRepo = new();

            var userId = It.IsAny<string>();            

            mockUserService.Setup(service =>
                service.IsUserValid(userId))
                    .Returns(true);

            var person = new Person()
            {
                Name = It.IsAny<string>(),
                Age = 18,
                CreditScore = 1200
            };

            mockPersonRepo.Setup(repo =>
            repo.Get(It.IsAny<string>()))
                .Returns(person);

            var sut = new LoanService(mockUserService.Object, mockPersonRepo.Object);
            
            Assert.That(sut.IsEligibleForLoan(userId), Is.True);
        }
    }
}