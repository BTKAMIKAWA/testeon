using Microsoft.EntityFrameworkCore;

namespace eonreality.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User {get;set;}
    }
}