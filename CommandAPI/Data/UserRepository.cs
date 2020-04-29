using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    using CommandAPI.Contracts;
    using CommandAPI.Model;

    public class UserRepository : IUserRepository
    {
        public async Task<AddUserResponse> AddUser(User user)
        {
            //Add user to database
            var userResponse = new AddUserResponse(201);
            return userResponse;

        }


    }
}
