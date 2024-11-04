using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUserService(string username, string password, string email)
        {
            _userRepository.CreateUserRepository(username, password, email);
        }

        public string ReadUserService(string username, string password)
        {
            return _userRepository.ReadUserRepository(username, password);
        }

        public void UpdateUserService(int id, string username, string password, string email)
        {
            _userRepository.UpdateUserRepository(id, username, password, email);
        }

        public void DeleteUserService(int id)
        {
            _userRepository?.DeleteUserRepository(id);
        }

        public void LoginUserService(string username, string password)
        {
            _userRepository?.LoginUserRepository(username, password);
        }
    }
}
