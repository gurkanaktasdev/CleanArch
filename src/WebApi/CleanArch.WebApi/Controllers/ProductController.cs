using CleanArch.Application.Features.Command;
using CleanArch.Application.Features.Querys;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediatr;

        public ProductController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }

        [HttpGet]
        public IActionResult GetProductById(Guid id)
        {
            var query = new ProductGetByIdQuery(id);            
            return Ok(mediatr.Send(query));
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductCreateCommand command)
        {
            return Ok(mediatr.Send(command));
        }

    }
}
