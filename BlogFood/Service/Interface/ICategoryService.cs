namespace Service.Interface
{
    public interface ICategoryService
    {
        public void CreateCategoryService(string category);
        public string ReadCategoryService(string category);
        public void UpdateCategoryService(string category);
        public void DeleteCategoryService(string category);
    }
}
