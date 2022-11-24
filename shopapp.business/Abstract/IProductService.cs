using System.Collections.Generic;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        int GetCountByCategory(string category);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        Product GetProductDetails(string url);
        Task<Product> GetById(int id);
        Product GetByIdWithCategories(int id);
        Task<Product> GetByIdWithCategoriesAsync(int id);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        Task<List<Product>> GetAll();
        bool Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        void Update(Product entity);
        bool Update(Product entity, int[] categoryIds);
        Task UpdateAsync(Product entityToUpdate, Product entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity);
        
    }
}