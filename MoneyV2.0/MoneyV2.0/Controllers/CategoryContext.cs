using MoneyV2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyV2._0.Controllers
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public CategoryContext()
            : base("MoneyDb")
        {
        }
    }
}