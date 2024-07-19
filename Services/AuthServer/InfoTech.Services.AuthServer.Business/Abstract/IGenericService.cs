using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Azure;

namespace InfoTech.Services.AuthServer.Business.Abstract
{
    public interface IGenericService<TEntity,TDto>
        where TEntity : class
        where TDto : class
    {
        Task<ResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity,bool>>predicate);
        Task<ResponseDto<TDto>> AddAsync(TDto dto);
        Task<ResponseDto<NoContent>> RemoveAsync(int id);
        
    }
}