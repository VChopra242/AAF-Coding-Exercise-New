using NUnit.Framework;
using LegacyApp;
using LegacyApp.Models.Domain.DTO;
using LegacyApp.Services;
using LegacyApp.Models.Domain;
using LegacyApp.Repository;

namespace LegacyAppUnitTests
{
    [TestFixture]
    public class UserServiceUnitTests 
    {
        private ClientRepository _clientRepository;
        [SetUp]
        public void Setup()
        {
            _clientRepository = new ClientRepository();
        }

        [Test]
        public async Task AddUser_PassUserDetails_UserCreated()
        {
            // Arrange
            UserService userService = new UserService(_clientRepository);
            UserDTO userDTO = GetUserDTO();
            // Act
            User newUser = await userService.AddUser(userDTO);
            // Assert
            Assert.AreEqual(newUser.Firstname, userDTO.FirstName);
            Assert.AreEqual(newUser.Surname, userDTO.Surname);
            Assert.AreEqual(newUser.EmailAddress, userDTO.Email);
            Assert.AreEqual(newUser.DateOfBirth, userDTO.DateOfBirth);
            Assert.AreEqual(newUser.ClientId, userDTO.ClientId);

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