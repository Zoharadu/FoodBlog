namespace Service.Interface
{
    public interface IUserService
    {
        public void CreateUserService (string username, string password, string email);
        public string ReadUserService (string username, string password);
        public void UpdateUserService (int id, string username, string password, string email);
        public void DeleteUserService (int id);
        public void LoginUserService(string username, string password);
    }
}
