using Repository.Interface;

namespace Repository.Impl
{
    public class CategoryRepository: ICategoryRepository
    {
        public void CreateCategoryRepository(string category)
        {
            Console.WriteLine(category);
        }
        public string ReadCategoryRepository(string category)
        {
            Console.WriteLine(category);
            return "fff";
        }
        public void UpdateCategoryRepository(string category)
        {
            Console.WriteLine(category);
        }
        public void DeleteCategoryRepository(string category)
        {
            Console.WriteLine(category);
        }
    }
}
