using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyV2._0.Models
{
    public class Aim
    {
        public Aim()
        {
            this.Categories = new List<Category>();
            this.Money = new List<Money>();
        }
        public int AimId { get; set; }
        public string AimName { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Money> Money { get; set; }
    }
}
