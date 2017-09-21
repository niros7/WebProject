using System.Data.Entity;
using test.Models;

namespace test.DAL
{
    public class ShauliContext : DbContext
    {
        public ShauliContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ShauliContext>());
        }

        public DbSet<Fan> Fans { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}