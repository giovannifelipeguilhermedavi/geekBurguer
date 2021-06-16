using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Model;
using Users.Repository;

namespace Users.Extension
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
