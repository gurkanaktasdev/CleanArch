using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.EntityDTO;
using CleanArch.Application.Features.Command;
using CleanArch.Domain.Entitys;

namespace CleanArch.Application.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Product,ProductDTO>().ReverseMap();
            CreateMap<ProductCreateCommand,Product>().ReverseMap();
        }
    }
}
