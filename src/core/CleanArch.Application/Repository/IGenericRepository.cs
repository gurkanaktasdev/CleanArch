using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Application.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetAll();

        T GetById(Guid id);

        T Create(T entity); 
    }
}
