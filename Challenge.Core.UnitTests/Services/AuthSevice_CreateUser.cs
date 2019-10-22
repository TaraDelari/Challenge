using System;
using System.Collections.Generic;
using System.Linq;
using Challenge.Core.Constants;
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
            string email = "test@example.com";
            string displayName = "display_name";
            string password = "testPassword";
            string passwordHash = "testPasswordHash";
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(() => Enumerable.Empty<User>().AsQueryable());
            unitOfWorkMock.Setup(x => x.RoleRepository.Get(accountOptionsMock.Value.DefaultRole)).Returns(() => new Role(accountOptionsMock.Value.DefaultRole));
            hasherMock.Setup(x => x.Hash(It.IsAny<string>())).Returns(passwordHash);
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<User> registrationResult = sut.CreateUser(email, displayName, password);

            //assert
            unitOfWorkMock.Verify(x => x.UserRepository.Insert(It.IsAny<User>()), Times.Once);
            Assert.True(registrationResult.Succeeded);
            Assert.Equal(email, registrationResult.Data.Email);
            Assert.Equal(passwordHash, registrationResult.Data.PasswordHash);
        }

        [Fact]
        public void UnusedEmail_AppropriateRoleAsssigned()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(() => Enumerable.Empty<User>().AsQueryable());
            unitOfWorkMock.Setup(x => x.RoleRepository.Get(accountOptionsMock.Value.DefaultRole)).Returns(() => new Role(accountOptionsMock.Value.DefaultRole));
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<User> registrationResult = sut.CreateUser("email", "display_name", "passwordHash");

            //assert
            Assert.Collection(registrationResult.Data.Roles, x => { Assert.Equal(accountOptionsMock.Value.DefaultRole, x.Name); });
        }

        [Fact]
        public void UsedEmail_ErrorResult()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            User user = User.CreateNew("email", "display_name", "password");
            IQueryable<User> userRepoData = new List<User> { user }.AsQueryable();
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(userRepoData);
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<User> userResult =  sut.CreateUser("email", "display_name", "passwordHash");

            //assert
            Assert.False(userResult.Succeeded);
            Assert.Equal(ErrorMessages.EMAIL_USED, userResult.Error);
            Assert.Null(userResult.Data);
        }
    }
}