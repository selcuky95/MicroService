using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTech.Services.AuthServer.Data.Abstract;

namespace InfoTech.Services.AuthServer.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        async Task IUnitOfWork.CommitAsync()
        {
            await _appDbContext.ConfigureAwait(false);
        }
    }
}