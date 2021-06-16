using Microsoft.EntityFrameworkCore;
using Users.Model;

namespace Users.Repository
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
