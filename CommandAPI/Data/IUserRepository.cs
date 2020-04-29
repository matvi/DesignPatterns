using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    using CommandAPI.Contracts;
    using CommandAPI.Model;

    public interface IUserRepository
    {
        Task<AddUserResponse> AddUser(User user);
    }
}
