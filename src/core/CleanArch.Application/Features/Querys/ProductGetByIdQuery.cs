using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.EntityDTO;
using CleanArch.Application.Mapping;
using CleanArch.Application.Repository;
using CleanArch.Domain.Entitys;
using MediatR;

namespace CleanArch.Application.Features.Querys
{
    public class ProductGetByIdQuery : IRequest<ProductDTO>
    {
        public Guid Id { get; set; }

        public ProductGetByIdQuery(Guid id)
        {
            Id = id;
        }

        public class ProductGetByIdHandler : IRequestHandler<ProductGetByIdQuery, ProductDTO>
        {
            private readonly IProductRepository _repository;
            private readonly IMapper _mapper;  
            public ProductGetByIdHandler(IProductRepository productRepo, IMapper mapper)
            {
                _mapper = mapper;
                _repository = productRepo;   
            }
            public async Task<ProductDTO> Handle(ProductGetByIdQuery request, CancellationToken cancellationToken)
            {
                var nesne =_repository.GetById(request.Id);
                
                var Dto = _mapper.Map<ProductDTO>(nesne);

                return Dto;
            }
        }
    }
}
