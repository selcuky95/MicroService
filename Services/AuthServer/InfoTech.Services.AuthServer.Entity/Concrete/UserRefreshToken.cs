using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTech.Services.AuthServer.Entity.Concrete
{
    public class UserRefreshToken
    {
        public string UserId { get; set; }
        public string Code { get; set;}
        public DateTime ExpirationDate { get; set; }

        // üretilen refresh token rastgele üretilen kod
        // token sona ereceği tarih 
    }
}