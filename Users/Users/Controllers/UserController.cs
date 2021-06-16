using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Interfaces;
using Users.ModelView;

namespace Users.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public UserController(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }

        [HttpPost("User")]        
        public IActionResult User([FromBody] string face)
        {
            try
            {
                var user = this.mapper.Map<UserGet>(usersRepository.GetUserByUserId(1111));
                return this.Ok(user);
            }
            catch
            {
                return StatusCode(500);
            }
        }        
    }
}
