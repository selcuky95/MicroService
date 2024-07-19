using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTech.Services.AuthServer.Shared.DTO
{
    public class AppUserDto
    {
        public string Id { get; set; }
        public string Username{ get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}