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
        public Money(Category category, Aim aim, double amount)
        {
            this.Quantity1 = 0;
            this.Quantity2 = 0;
            this.Quantity5 = 0;
            this.Quantity10 = 0;
            this.Quantity20 = 0;
            this.Quantity50 = 0;
            this.Quantity100 = 0;
            this.Category = category;
            this.Aim = aim;
            this.BanknotiAmount = 0;
            this.Amount = amount;
            this.Owner = Environment.MachineName;
        }
        
        public int MoneyId { get; set; }
        public int Quantity100 { get; set; }
        public int Quantity50 { get; set; }
        public int Quantity20 { get; set; }
        public int Quantity10 { get; set; }
        public int Quantity5 { get; set; }
        public int Quantity2 { get; set; }
        public int Quantity1 { get; set; }
        public int BanknotiAmount { get; set; }
        public double Amount { get; set; }
        //public bool isFromCashDesk { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Owner { get; set; }
        public virtual Category Category { get; set; }
        public virtual Aim Aim { get; set; }
        public virtual Session Session { get; set; }

        //public Money DeepCopy()
        //{
        //    Money other = (Money)this.MemberwiseClone();
        //    other.Quantity1 = Quantity1;
        //    other.Quantity2 = Quantity2;
        //    other.Quantity5 = Quantity5;
        //    other.Quantity10 = Quantity10;
        //    other.Quantity20 = Quantity20;
        //    other.Quantity50 = Quantity50;
        //    other.Quantity100 = Quantity100;
        //    other.Amount = Amount;
        //    other.Date = Date;
        //    other.Note = String.Copy(Note);
        //    other.Owner = String.Copy(Owner);
        //    other.Category = Category;
        //    other.Aim = Aim;
        //    other.Session = Session;

        //    return other;
        //}
      
    }
}
