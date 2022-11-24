using System.Collections.Generic;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(Category entity)
        {
            if(Validation(entity))
            {
                _unitOfWork.Categories.Create(entity);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public async Task<Category> CreateAsync(Category entity)
        {
            await _unitOfWork.Categories.CreateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public void Delete(Category entity)
        {
            _unitOfWork.Categories.Delete(entity);
            _unitOfWork.Save();
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _unitOfWork.Categories.DeleteFromCategory(productId, categoryId);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitOfWork.Categories.GetAll();
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitOfWork.Categories.GetById(id);
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            return _unitOfWork.Categories.GetByIdWithProducts(categoryId);
        }

        public void Update(Category entity)
        {
            _unitOfWork.Categories.Update(entity);
            _unitOfWork.Save();
        }

        public string ErrorMessage { get; set; }

        public bool Validation(Category entity)
        {
            var IsValid = true;

            if(string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "kategori ismi girmelisiniz.\n";
                IsValid = false;
            }

            if(string.IsNullOrEmpty(entity.Url))
            {   
                ErrorMessage += "kategori URL'i girmelisiniz.\n";
                IsValid = false;
            }

            return IsValid;
        }
    }
}