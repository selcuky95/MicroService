using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InfoTech.Services.AuthServer.Entity.Concrete
{
    public class AppUser:IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set;}
        public string City { get; set;}
    }
}