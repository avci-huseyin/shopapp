using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context) : base(context)
        {
            
        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }

        public Product GetByIdWithCategories(int id)
        {
            return ShopContext.Products
                .Where(i => i.ProductId == id)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefault();
        }

        public async Task<Product> GetByIdWithCategoriesAsync(int id)
        {
            return await ShopContext.Products
                .Where(i => i.ProductId == id)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefaultAsync();
        }

        public int GetCountByCategory(string category)
        {
            var products = ShopContext.Products.Where(i => i.IsApproved).AsQueryable();

            if(!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.Url == category.ToLower()));
            }

            return products.Count();
        }

        public List<Product> GetHomePageProducts()
        {
            return ShopContext.Products
                .Where(i => i.IsApproved && i.IsHome).ToList();
        }

        public Product GetProductDetails(string url)
        {
            return ShopContext.Products
                .Where(i => i.Url == url)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefault(); 
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            var products = ShopContext
                .Products
                .Where(i => i.IsApproved)
                .AsQueryable();

            if(!string.IsNullOrEmpty(name))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.Url == name.ToLower()));
            }

            return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Product> GetSearchResult(string searchString)
        {
            var products = ShopContext
                .Products
                .Where(i => i.IsApproved && (i.Name.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower())))
                .AsQueryable();

            return products.ToList();
        }

        public void Update(Product entity, int[] categoryIds)
        {
            var product = ShopContext.Products
                .Include(i => i.ProductCategories)
                .FirstOrDefault(i => i.ProductId == entity.ProductId);

            if(product != null)
            {
                product.Name = entity.Name;
                product.Price = entity.Price;
                product.Url = entity.Url;
                product.ImageUrl = entity.ImageUrl;
                product.Description = entity.Description;
                product.IsApproved = entity.IsApproved;
                product.IsHome = entity.IsHome;

                product.ProductCategories = categoryIds.Select(cId => new ProductCategory()
                {
                    ProductId = entity.ProductId,
                    CategoryId = cId
                }).ToList();
            }
        }
    }
}