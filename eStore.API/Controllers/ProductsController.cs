using eStore.Core.Entities;
using eStore.Core.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace eStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductByID(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            if (product is not null) return Ok(product);

            else return NotFound();

        }




    }
}
