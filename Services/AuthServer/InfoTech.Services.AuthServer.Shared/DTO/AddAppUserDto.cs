using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTech.Services.AuthServer.Shared.DTO
{
    public class AddAppUserDto
    {
        
        public string Username{ get; set; }
        public string Password{ get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}