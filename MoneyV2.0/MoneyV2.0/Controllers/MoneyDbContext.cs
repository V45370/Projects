using System.Data.Entity;
using MoneyV2._0.Models;

namespace MoneyV2._0.Controllers
{
    public class MoneyDbContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Money> Money { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Aim> Aims { get; set; }

        public MoneyDbContext()
            : base("MoneyDb")
        {
        }
    }
}