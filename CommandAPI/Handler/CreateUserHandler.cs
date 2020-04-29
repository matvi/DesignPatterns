using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Handler
{
    using CommandAPI.Command;
    using CommandAPI.Data;
    using CommandAPI.Model;

    public class CreateUserHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CreateUserHandler()
        {
            
        }

        public async Task<IResponse> HandleAsync(CreateUserCommand command)
        {
            Console.WriteLine("Creating User in database");
            var response = await _userRepository.AddUser(new User());
            return response;
        }
 


    }
}
