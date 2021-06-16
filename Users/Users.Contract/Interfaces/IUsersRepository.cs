using Users.Contract.Model;

namespace Users.Interfaces.Contract
{
    public interface IUsersRepository
    {
        User GetUserByUserId(int userId);
        bool ExisteUserId(int userId);
    }
}
