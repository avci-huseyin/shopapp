using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webapi.DTO;

namespace shopapp.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();

            var productsDTO = new List<ProductDTO>();
            
            foreach (var p in products)
            {
                productsDTO.Add(ProductToDTO(p));
            }

            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var p = await _productService.GetById(id);
            if(p == null)
            {
                return NotFound(); // 404
            }

            return Ok(ProductToDTO(p)); 
        }

        // ReferenceLoopHandling
        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetProductWithCategories(int id)
        // {
        //     var p = await _productService.GetByIdWithCategoriesAsync(id);

        //     if(p == null)
        //     {
        //         return NotFound(); // 404
        //     }

        //     string output = JsonConvert.SerializeObject(p.ProductCategories.Select(i => i.Category).ToList());

        //     return Ok(output);
        // }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);

            // 201
            return CreatedAtAction(nameof(GetProduct), new {id = entity.ProductId}, ProductToDTO(entity));

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product entity)
        {
            if(id != entity.ProductId)
            {
                // 400's
                return BadRequest();
            }

            var product = await _productService.GetById(id);

            if(product == null)
            {
                // 404
                return NotFound();
            }

            await _productService.UpdateAsync(product, entity);

            // 200's
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetById(id);

            if(product == null)
            {
                // 404
                return NotFound();
            }

            await _productService.DeleteAsync(product);

            // 200's
            return NoContent();
        }

        private static ProductDTO ProductToDTO(Product p)
        {
            return new ProductDTO{
                ProductId = p.ProductId,
                Name = p.Name,
                Url = p.Url,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            };
        }
    }
}