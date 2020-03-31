using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    using CommandAPI.Model;

    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
