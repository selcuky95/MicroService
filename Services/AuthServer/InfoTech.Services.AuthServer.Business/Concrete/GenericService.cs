using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTech.Services.AuthServer.Business.Abstract;
using Microsoft.Identity.Client;

namespace InfoTech.Services.AuthServer.Business.Concrete
{
    public class GenericService<TEntity,TDto>: IGenericService<TEntity,TDto> 
        where TEntity : class
        where TDto : class 
    {
        
    }
}