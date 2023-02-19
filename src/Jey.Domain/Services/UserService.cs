using Jey.Domain.Interfaces;
using Jey.Domain.Models;
using System.Linq;

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
        public Task<bool> Register(ulong id, string userName)
        {
            if(_userRepository.GetById(id).Result == null)
            {
                _userRepository.Create(new User(id, userName));

                return Task.FromResult(true);
            }

            else 
                return Task.FromResult(false);
        }
    }
}