using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace mvc
{
    public class MvcMembersContext : DbContext
    {
        public MvcMembersContext() 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=database.db;");
        }

        public DbSet<mvc.Models.Member> members { get; set; }
    }
}