using Microsoft.EntityFrameworkCore;

namespace MyFirstMVCApp.Data
{
    public class MyFirstMVCAppContext : DbContext
    {
        public MyFirstMVCAppContext(DbContextOptions<MyFirstMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMVCApp.Models.Movie> Movie { get; set; } = default!;
    }
}
