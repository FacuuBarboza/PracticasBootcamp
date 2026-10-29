using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIGestionProductos.Services;
using APIGestionProductos.DTOs;

namespace APIGestionProductos.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(int id)
        {
            var product = _productService.GetById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<ProductDto> AddProduct(CreateProductDto dto)
        {
            var newProduct = _productService.AddProduct(dto);
            return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct (int id, [FromBody] CreateProductDto dto)
        {
            var updated = _productService.UpdateProduct(id, dto);
            if (!updated) return NotFound();
            return NoContent(); //Acá devuelve 204 para actualizaciones exitosas
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var deleted = _productService.DeleteProduct(id);
            if (!deleted) return NotFound();
            return NoContent(); //Acá devuelve 204 para eliminaciones exitosas
        }

    }
}
