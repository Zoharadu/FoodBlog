namespace Repository.Interface
{
    public interface ICategoryRepository
    {
        public void CreateCategoryRepository(string category);
        public string ReadCategoryRepository(string category);
        public void UpdateCategoryRepository(string category);
        public void DeleteCategoryRepository(string category);
    }
}
