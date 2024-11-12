using System;
using System.Threading.Tasks;
using LegacyApp.Models.Domain;
using LegacyApp.Models.Domain.DTO;
using LegacyApp.Repository;

namespace LegacyApp.Services
{
    public class UserService : IUserService
    {
        private ClientRepository _clientRepository;
        private Client _client;
        private User _user;


        public UserService(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<User> AddUser(UserDTO userDto)
        {
            UserServiceHelpers.CheckUserName(userDto);
            UserServiceHelpers.CheckEmail(userDto);
            UserServiceHelpers.CheckUserAge(userDto);
            await CreateClient(userDto);
            UserServiceHelpers.VerifyClient(_client, _user);
            UserServiceHelpers.CheckCreditLimit(_user);
            UserDataAccess.AddUser(_user);
            return _user;
        }

        private async Task CreateClient(UserDTO userDto)
        {
            _client = await _clientRepository.GetByIdAsync(userDto.ClientId);
            _user = new User
            {
                Client = _client,
                DateOfBirth = userDto.DateOfBirth,
                EmailAddress = userDto.Email,
                Firstname = userDto.FirstName,
                Surname = userDto.Surname
            };
        }
    }
}
