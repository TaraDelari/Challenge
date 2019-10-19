using Challenge.Core.Constants;
using Challenge.Core.Contracts;
using Challenge.Core.Models;
using Challenge.Core.Options;
using Challenge.Core.Services;
using Microsoft.Extensions.Options;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Challenge.Core.UnitTests.Services
{
    public class AuthService_Login
    {
        [Fact]
        public void UnknownUser_ErrorResult()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(() => Enumerable.Empty<User>().AsQueryable());
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<LoginResult> loginResult = sut.Login("email", "passwordHash");

            //assert
            Assert.False(loginResult.Succeeded);
            Assert.Equal(ErrorMessages.INVALID_CREDENTIALS, loginResult.Error);
            Assert.Null(loginResult.Data);
        }

        [Fact]
        public void BadPassword_ErrorResult()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            User user = new User("email", "password");
            IQueryable<User> userRepoData = new List<User> { user }.AsQueryable();
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(userRepoData);
            hasherMock.Setup(x => x.Verify(It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<LoginResult> loginResult = sut.Login("email", "passwordHash");

            //assert
            Assert.False(loginResult.Succeeded);
            Assert.Equal(ErrorMessages.INVALID_CREDENTIALS, loginResult.Error);
            Assert.Null(loginResult.Data);
        }

        [Fact]
        public void ValidUser_UserAndTokenReturned()
        {
            //arrange
            Mock<IUnitOfWork> unitOfWorkMock = new Mock<IUnitOfWork>();
            Mock<IHasher> hasherMock = new Mock<IHasher>();
            Mock<ITokenGenerator> tokenGeneratorMock = new Mock<ITokenGenerator>();
            IOptions<AccountOptions> accountOptionsMock = Microsoft.Extensions.Options.Options.Create(new AccountOptions());
            User user = new User("email", "password");
            IQueryable<User> userRepoData = new List<User> { user }.AsQueryable();
            unitOfWorkMock.Setup(x => x.UserRepository.Get()).Returns(userRepoData);
            hasherMock.Setup(x => x.Verify(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            string generatedToken = "generatedToken";
            tokenGeneratorMock.Setup(x => x.Generate(It.IsAny<User>())).Returns(generatedToken);
            AuthService sut = new AuthService(unitOfWorkMock.Object, hasherMock.Object, tokenGeneratorMock.Object, accountOptionsMock);

            //act
            Result<LoginResult> loginResult = sut.Login("email", "passwordHash");

            //assert
            Assert.True(loginResult.Succeeded);
            Assert.Same(user, loginResult.Data.User);
            Assert.Equal(generatedToken, loginResult.Data.Token);
        }
    }
}