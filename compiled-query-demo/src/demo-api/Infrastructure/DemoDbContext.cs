//Create database context called demoDbContext  which is inherited from DbContext class and it will be used to perform CRUD operations on database.     
using Microsoft.EntityFrameworkCore;

namespace demo_api.Infrastructure
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<demo> demo { get; set; }
    }
}