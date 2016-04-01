using System.Data.Entity;

namespace EntityFrameworkTest
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EntityFrameworkConnectionString")
        {
        }

        public DbSet<User> User { get; set; }
    }
}
