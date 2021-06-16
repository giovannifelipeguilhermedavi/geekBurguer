using System.Linq;
using System.Threading.Tasks;
using Users.Interfaces;
using Users.Model;

namespace Users.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersDbContext usersDbContext;

        public UsersRepository(UsersDbContext usersDbContext)
        {
            this.usersDbContext = usersDbContext;
        }

        public bool ExisteUserId(int userId)
        {
            var user = usersDbContext.Users.Where(r => r.UserId.Equals(userId)).FirstOrDefault();
            if (user.UserId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public User GetUserByUserId(int userId)
        {
            var user = usersDbContext.Users
            .Single(b => b.UserId == userId);
             return user;
        }
    }
}
