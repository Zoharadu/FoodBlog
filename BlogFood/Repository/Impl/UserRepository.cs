using Repository.Interface;


namespace Repository.Impl
{
    public class UserRepository:IUserRepository
    {

        public void CreateUserRepository(string username, string password, string email)
        {
            Console.WriteLine( username,  password,  email);
        }

        public string ReadUserRepository(string username, string password)
        {
            Console.WriteLine( username,  password);
            return username;
        }

        public void UpdateUserRepository(int id, string username, string password, string email)
        {
            Console.WriteLine(username,  password,  email);
        }

        public void DeleteUserRepository(int id)
        {
            Console.WriteLine(id);
        }

        public void LoginUserRepository(string username, string password)
        {
            Console.WriteLine(username);
        }
    }
}
