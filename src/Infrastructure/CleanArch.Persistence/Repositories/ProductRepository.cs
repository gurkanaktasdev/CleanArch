using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Application.Repository;
using CleanArch.Domain.Entitys;
using CleanArch.Persistence.Context;

namespace CleanArch.Persistence.Repositories
{
    internal class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(CleanArchDbContext context):base(context)
        {
            
        }
    }
}
