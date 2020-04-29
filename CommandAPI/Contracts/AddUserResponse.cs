using CommandAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Contracts
{
    public class AddUserResponse : IResponse
    {
        public int Code { get ; set; }

        public AddUserResponse(int code)
        {
            Code = code;
        }
    }
}
