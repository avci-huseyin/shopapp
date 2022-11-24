using System.Collections.Generic;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Product entity)
        {
            if(Validation(entity))
            {
                _unitOfWork.Products.Create(entity);
                _unitOfWork.Save();
                return true;
            }   
            return false;
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitOfWork.Products.CreateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public void Delete(Product entity)
        {
            _unitOfWork.Products.Delete(entity);
            _unitOfWork.Save();
        }
        public async Task DeleteAsync(Product entity)
        {
            _unitOfWork.Products.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _unitOfWork.Products.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _unitOfWork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitOfWork.Products.GetByIdWithCategories(id);
        }

        public async Task<Product> GetByIdWithCategoriesAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdWithCategoriesAsync(id);
        }

        public int GetCountByCategory(string category)
        {
            return _unitOfWork.Products.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return _unitOfWork.Products.GetHomePageProducts();
        }

        public Product GetProductDetails(string url)
        {
            return _unitOfWork.Products.GetProductDetails(url);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _unitOfWork.Products.GetProductsByCategory(name, page, pageSize);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _unitOfWork.Products.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _unitOfWork.Products.Update(entity);
            _unitOfWork.Save();
        }

        public bool Update(Product entity, int[] categoryIds)
        {
            if(Validation(entity))
            {
                if(categoryIds.Length == 0)
                {
                    ErrorMessage += "urun icin en az bir kategori secmelisiniz.\n";
                    return false;
                }
                _unitOfWork.Products.Update(entity, categoryIds);
                _unitOfWork.Save();
                return true;
            } 
            return false;
        }

        public async Task UpdateAsync(Product entityToUpdate, Product entity)
        {
            entityToUpdate.Name = entity.Name;
            entityToUpdate.Price = entity.Price;
            entityToUpdate.Description = entity.Description;

            // tbc

            await _unitOfWork.SaveAsync();
        }

        public string ErrorMessage { get; set; }

        public bool Validation(Product entity)
        {
            var IsValid = true;

            if(string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "urun ismi girmelisiniz.\n";
                IsValid = false;
            }

            if(entity.Price < 0)
            {   
                ErrorMessage += "urun fiyati negatif olamaz.\n";
                IsValid = false;
            }

            return IsValid;
        }
    }
}