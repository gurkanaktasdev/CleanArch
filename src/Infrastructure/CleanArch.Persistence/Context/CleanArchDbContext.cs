using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Persistence.Context
{
    public class CleanArchDbContext: DbContext
    {
        public CleanArchDbContext(DbContextOptions<CleanArchDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }
    }
}
