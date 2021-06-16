using System.Threading.Tasks;
using Users.Model;

namespace Users.Interfaces
{
    public interface IUsersRepository
    {
        User GetUserByUserId(int userId);
    }
}
