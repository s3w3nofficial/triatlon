using Microsoft.EntityFrameworkCore;
using triatlon.Data;

namespace triatlon.Services 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Time> Times { get;set; }
    }
}