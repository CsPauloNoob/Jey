using Jey.Domain.Models;

namespace Jey.Domain.Services
{
    public class UserService
    {

        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }


        public string Message()
        {
            return "Foi!!!";
        }

        //TODO: passar user para registro e verificar se ele existe
        /*public Task<bool> Register()
        {
            if(_userRepository.GetById()
        }*/

    }
}