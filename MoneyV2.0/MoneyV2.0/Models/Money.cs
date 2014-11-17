using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyV2._0.Models
{
    public class Money
    {
        public Money()
        {
        }
        
        public int MoneyId { get; set; }
        public int Quantity100 { get; set; }
        public int Quantity50 { get; set; }
        public int Quantity20 { get; set; }
        public int Quantity10 { get; set; }
        public int Quantity5 { get; set; }
        public int Quantity2 { get; set; }
        public int Quantity1 { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public virtual Category Category { get; set; }
        public virtual Aim Aim { get; set; }
        public virtual Session Session { get; set; }
      
    }
}
