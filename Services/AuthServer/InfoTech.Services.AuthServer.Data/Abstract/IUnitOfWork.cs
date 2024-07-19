using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTech.Services.AuthServer.Data.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        void CommitAsync();
    }
}