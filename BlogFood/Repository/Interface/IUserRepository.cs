namespace Repository.Interface
{
    public interface IUserRepository
    {
        public void CreateUserRepository(string username, string password, string email);
        public string ReadUserRepository(string username, string password);
        public void UpdateUserRepository(int id, string username, string password, string email);
        public void DeleteUserRepository(int id);
        public void LoginUserRepository(string username, string password); 
    }
}
