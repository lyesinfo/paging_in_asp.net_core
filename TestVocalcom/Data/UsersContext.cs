using Microsoft.EntityFrameworkCore;
using TestVocalcom.Models;

    public class UsersContext : DbContext
    {
        public UsersContext (DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
