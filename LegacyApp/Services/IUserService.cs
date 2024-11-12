using LegacyApp.Models.Domain.DTO;
using LegacyApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp.Services
{
    public interface IUserService
    {
        Task<User> AddUser(UserDTO userDto);
    }
}
