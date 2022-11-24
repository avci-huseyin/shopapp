using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Models;

namespace shopapp.webui.Contollers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService) 
        {
            this._productService = productService;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
            };

            return View(productViewModel);
        }
        
        // API
        public async Task<IActionResult> GetProductsFromRestApi()
        {
            var products = new List<Product>();

            using(var httpClient = new HttpClient())
            {
                using(var response = await httpClient.GetAsync("http://localhost:4200/api/products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse); 
                }
            }

            return View(products);
        }
    }
}





