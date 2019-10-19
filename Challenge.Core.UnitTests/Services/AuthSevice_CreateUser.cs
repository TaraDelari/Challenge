using System;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Challenge.Core.Options;
using Challenge.Core.Services;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace Challenge.Core.UnitTests.Services
{
    public class AuthSevice_CreateUser
    {

        [Fact]
        public void UnusedEmail_NewUserCreated()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            unitOfWorkMock.Setup(x => x.UserRepository.Get(It.IsAny<int>())).Returns(() => null);
            unitOfWorkMock.Setup(x => x.RoleRepository.Get(It.IsAny<string>())).Returns(() => null);
            IOptions<JwtOptions> jwtOptionsMock = Microsoft.Extensions.Options.Options.Create(new JwtOptions());
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, jwtOptionsMock, accountOptionsMock);

            //
            sut.CreateUser("email", "passwordHash");

            //assert
            unitOfWorkMock.Verify(x => x.UserRepository.Insert(It.IsAny<User>()), Times.Once);
        }

    }
}
