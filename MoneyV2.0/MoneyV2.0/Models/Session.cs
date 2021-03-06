﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyV2._0.Models
{
    public class Session
    {
        public Session()
        {
            this.Moneys = new List<Money>();
        }

        public int SessionId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Money> Moneys { get; set; }
    }
}
