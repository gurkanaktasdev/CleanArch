using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Application.Repository;
using CleanArch.Domain.Common;
using CleanArch.Persistence.Context;

namespace CleanArch.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public CleanArchDbContext CleanArchContext { get; }
        public GenericRepository(CleanArchDbContext Context)
        { 
            CleanArchContext = Context;
        }

        public T Create(T entity)
        {
            CleanArchContext.Set<T>().Add(entity);
            CleanArchContext.SaveChanges();
            return entity;
        }

        public List<T> GetAll()
        {
            var list = CleanArchContext.Set<T>().ToList();
            return list;
        }

        public T GetById(Guid id)
        {
            var nesne = CleanArchContext.Set<T>().Find(id);
            return nesne;
        }
    }
}
