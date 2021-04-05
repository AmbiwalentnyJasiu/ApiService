using Microsoft.EntityFrameworkCore;

namespace ApiService.Models
{
    public class DBaseContext : DbContext
    {
        public DBaseContext(DbContextOptions<DBaseContext> options)
            : base(options)
        {
        }

        public DbSet<ItemModel> Items { get; set; }
    }
}
