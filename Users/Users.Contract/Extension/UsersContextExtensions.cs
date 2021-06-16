using System.Collections.Generic;
using Users.Contract.Model;
using Users.Contract.Repository;

namespace Users.Contract.Extension
{
    public static class UsersContextExtensions
    {
        public static void Seed(this UsersDbContext context)
        {
            context.Users.RemoveRange(context.Users);            
            context.SaveChanges();

            context.Users.AddRange(
             new List<User> {
            new User { UserId = 1111 },            
            });

            context.SaveChanges();
        }
    }
}
