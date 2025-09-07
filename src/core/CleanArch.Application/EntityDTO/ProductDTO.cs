using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.EntityDTO
{
    public class ProductDTO
    {
        public int Quantity { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
