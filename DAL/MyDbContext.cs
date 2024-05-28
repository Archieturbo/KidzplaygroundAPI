using Microsoft.EntityFrameworkCore;
using KidzplaygroundAPI.Models;
namespace KidzplaygroundAPI.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
