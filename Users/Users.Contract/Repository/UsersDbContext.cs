using Microsoft.EntityFrameworkCore;
using Users.Contract.Model;

namespace Users.Contract.Repository
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
