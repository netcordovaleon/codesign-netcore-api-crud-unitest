using CRUD.App.Services;
using CRUD.App.Services.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD.App.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("", Name = "GetAll")]
        public async Task<IActionResult> GetAllProducts() {
            var result = await _productService.GetAllProductsAsync();
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("", Name = "Save")]
        public async Task<IActionResult> SaveProduct(ProductDTO product)
        {
            var result = await _productService.SaveProductAsync(product);
            return Ok(result);
        }

    }
}
