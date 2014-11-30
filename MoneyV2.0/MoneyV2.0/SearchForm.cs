using MoneyV2._0.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyV2._0
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using(var db = new MoneyContext())
            {
                
                var query = from a in db.Money
                        where a.Date == dateTimePicker1.Value.Date
                        select a;


                query = from b in query
                                 where b.Category.CategoryName == CategoryTB.Text
                                 select b;

                query = from c in query
                            where c.Aim.AimName == AimTB.Text
                            select c;

                var amount = double.Parse(AmountTB.Text);
                query = from d in query
                             where d.Amount == amount
                             select d;
                var result = query.ToList();
                MessageBox.Show("lel");
            }
        }
    }
}
