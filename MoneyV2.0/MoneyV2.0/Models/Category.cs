using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyV2._0.Models
{
    public class Category
    {
        public Category()
        {
            this.Money = new List<Money>();
            this.Aims = new List<Aim>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool isIncome { get; set; }
        public bool isForBank { get; set; }
        public virtual ICollection<Money> Money { get; set; }
        public virtual ICollection<Aim> Aims { get; set; }
    }
}
