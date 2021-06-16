using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Users.Interfaces.Contract;
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

        [HttpGet("User/{userId:int}")]        
        public new ActionResult<UserGet> User(int userId)
        {
            try
            {
                var existe = usersRepository.ExisteUserId(userId);
                if (existe)
                {
                    var user = this.mapper.Map<UserGet>(usersRepository.GetUserByUserId(userId));
                    return this.Ok(user);
                }
                else
                {
                    return this.NotFound();
                }                
            }
            catch
            {
                return StatusCode(500);
            }
        }        
    }
}
