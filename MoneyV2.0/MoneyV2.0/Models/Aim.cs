using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyV2._0.Models
{
    public class Aim
    {
        public Aim()
        {
            this.Moneys = new List<Money>();
        }
        public int AimId { get; set; }
        public string AimName { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Money> Moneys { get; set; }
    }
}
