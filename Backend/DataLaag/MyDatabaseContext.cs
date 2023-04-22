using Microsoft.EntityFrameworkCore;


namespace DataLaag
{
    public class MyDatabaseContext : DbContext
    {

        public MyDatabaseContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
