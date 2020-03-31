using System;
using System.Collections.Generic;
using System.Text;

namespace ICommandYou.Handler
{
    using System.Threading.Tasks;

    using ICommandYou.Command;

    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;
        public async Task HandlerAsync(CreateUser command)
        {
            await _userService.RegisterAsync(
                command.UserId,
                command.Email,
                command.Password,
                command.Nickname,
                command.Culture);
        }
    }
}
