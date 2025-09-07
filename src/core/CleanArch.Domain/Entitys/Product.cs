using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Common;

namespace CleanArch.Domain.Entitys
{
    public sealed class Product:BaseEntity
    {
        public Product():base(DateTime.Now)
        {
            
        }

        public int Quantity { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
