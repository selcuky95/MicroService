using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTech.Services.AuthServer.Shared.DTO;

namespace InfoTech.Services.AuthServer.Business.Abstract
{
    public interface IUserService
    {
        // yeni kullanıcı oluşturma
        Task<ResponseDto<AppUserDto>> CreateUserAsync(AddAppUserDto addAppUserDto);
        Task<ResponseDto<AppUserDto>> GetUserByNameAsync(string userName);
    }
}