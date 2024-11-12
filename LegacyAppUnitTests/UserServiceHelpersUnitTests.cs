using NUnit.Framework;
using LegacyApp;
using LegacyApp.Models.Domain.DTO;
using LegacyApp.Services;
using LegacyApp.Models.Domain;
using LegacyApp.Repository;

namespace LegacyAppUnitTests
{
    [TestFixture]
    public class UserServiceHelpersUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CheckUserName_PassFirstNameAndSurname_NoException()
        {
            // Arrange
            UserDTO userDTO = GetUserDTO();
            // Act and Assert
            Assert.DoesNotThrow(() => UserServiceHelpers.CheckUserName(userDTO));
        }
        private UserDTO GetUserDTO()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.FirstName = "Tim";
            userDTO.Surname = "Smith";
            userDTO.Email = "TestEmail@Gmail.com";
            userDTO.DateOfBirth = new DateTime(1977, 11, 12);
            userDTO.ClientId = 47;
            return userDTO;

        }
    }
}
