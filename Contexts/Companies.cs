using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Contexts
{
    public class Companies : DbContext
    {
        public Companies(DbContextOptions<Companies> options)
            : base(options)
        {
        }

        public DbSet<Models.Company> companies { get; set; }
        public DbSet<Models.Owner> owners { get; set; }
    }
}