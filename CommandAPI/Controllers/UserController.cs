using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    using CommandAPI.Command;
    using CommandAPI.Data;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public UserController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUser user)
        {
            await _commandDispatcher.DispatchAsync(user);
            return Ok();
        }
    }
}