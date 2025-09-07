using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.EntityDTO;
using CleanArch.Application.Repository;
using CleanArch.Domain.Entitys;
using MediatR;

namespace CleanArch.Application.Features.Command
{
    public class ProductCreateCommand: IRequest<ProductDTO>
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, ProductDTO>
        {
            private readonly IProductRepository productrepository;
            private readonly IMapper _mapper;

            public ProductCreateCommandHandler(IProductRepository prd,IMapper mapper)
            {
                _mapper = mapper;
                productrepository = prd;
            }

            public Task<ProductDTO> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
            {
                
                var product = _mapper.Map<Product>(request);
                productrepository.Create(product);
    
                var productDto = _mapper.Map<ProductDTO>(product);

                return Task.FromResult(productDto);    
            }
        }
    }
}
