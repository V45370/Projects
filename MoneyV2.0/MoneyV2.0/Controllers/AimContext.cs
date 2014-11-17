using MoneyV2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyV2._0.Controllers
{
    public class AimContext : DbContext
    {
        public DbSet<Aim> Aims { get; set; }

        public AimContext()
            : base("MoneyDb")
        {
        }
    }
}