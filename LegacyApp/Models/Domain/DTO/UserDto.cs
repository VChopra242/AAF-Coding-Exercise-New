using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp.Models.Domain.DTO
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClientId { get; set; }

    }
}
