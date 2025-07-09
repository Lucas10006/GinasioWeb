using Microsoft.EntityFrameworkCore;

namespace Ginasio.Models
{
    public class GinDbContext : DbContext
    {
        public GinDbContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            
            
        
    }
}
