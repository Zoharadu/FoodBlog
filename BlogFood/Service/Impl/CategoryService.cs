using Repository.Interface;
using Service.Interface;

namespace Service.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryService;

        public CategoryService(ICategoryRepository categoryService)
        {
            _categoryService = categoryService;
        }
        public void CreateCategoryService(string category)
        {
            _categoryService.CreateCategoryRepository(category);
        }
        public string ReadCategoryService(string category)
        {
            return _categoryService.ReadCategoryRepository(category);
        }
        public void UpdateCategoryService(string category)
        {
            _categoryService.UpdateCategoryRepository(category);
        }
        public void DeleteCategoryService(string category)
        {
            _categoryService?.DeleteCategoryRepository(category);
        }
    }
}
