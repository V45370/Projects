using System;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Interfaces;
using MoneyV2._0.Models;
using MoneyV2._0.Controllers;

namespace MoneyV2._0
{
    public partial class Menu : Form
    {
        public Session session = new Session();
        private bool doesSessionExists = false;
        public Money money = new Money();
        public string CategorySelected;
        public string AimSelected;
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            //Check if Session exists in database
            using (var db = new DatabaseContext())
            {
                var checkSessionExists =  db.Sessions.SingleOrDefault(s => s.Date.Equals(today));
                if (checkSessionExists.Date == today)
                {
                    doesSessionExists = true;
                }
                else
                {
                    doesSessionExists = false;
                }

            }

            ListViewAdjustments();
            ReloadData();
        }

        private void OpenHistoryForm_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void OpenMoneyFormBtn_Click(object sender, EventArgs e)
        {
            var moneyForm = new MoneyForm(this);
            moneyForm.ShowDialog();
            ReloadData();
            using (var db = new DatabaseContext())
            {
                //var proba =  db.Sessions.SingleOrDefault(s => s.Date.Equals(today));
                //MessageBox.Show(proba.Date.ToString());
                db.Sessions.Add(session);
                db.SaveChanges();

            }
        }
        public void ReloadData()
        {
            if (CashDeskListView.Items.Count>0)
            {
                CashDeskListView.Items.RemoveAt(0);
            }
            using (var db = new MoneyContext())
            {
                var moneys = db.Money.ToList();
                double tresor = 0;
                int qty1 = 0;
                int qty2 = 0;
                int qty5 = 0;
                int qty10 = 0;
                int qty20 = 0;
                int qty50 = 0;
                int qty100 = 0;

                foreach (var money in moneys)
                {

                    if (money.Category.isIncome == true)
                    {
                        qty1 += money.Quantity1;
                        qty2 += money.Quantity2;
                        qty5 += money.Quantity5;
                        qty10 += money.Quantity10;
                        qty20 += money.Quantity20;
                        qty50 += money.Quantity50;
                        qty100 += money.Quantity100;
                        tresor += money.Amount;
                    }
                    else
                    {
                        qty1 -= money.Quantity1;
                        qty2 -= money.Quantity2;
                        qty5 -= money.Quantity5;
                        qty10 -= money.Quantity10;
                        qty20 -= money.Quantity20;
                        qty50 -= money.Quantity50;
                        qty100 -= money.Quantity100;
                        tresor -= money.Amount;
                    }
                }

                string[] itemValues = new string[] 
                {
                    qty1.ToString(),
                    qty2.ToString(),
                    qty5.ToString(),
                    qty10.ToString(),
                    qty20.ToString(),
                    qty50.ToString(),
                    qty100.ToString(),
                    tresor.ToString()
                };
                this.CashDeskListView.Items.Add(new ListViewItem(itemValues));
            }
        }
        
        private void ListViewAdjustments()
        {
            //nastroivane na listview
            ColumnHeader headerQty1 = new ColumnHeader();
            ColumnHeader headerQty2 = new ColumnHeader();
            ColumnHeader headerQty5 = new ColumnHeader();
            ColumnHeader headerQty10 = new ColumnHeader();
            ColumnHeader headerQty20 = new ColumnHeader();
            ColumnHeader headerQty50 = new ColumnHeader();
            ColumnHeader headerQty100 = new ColumnHeader();
            ColumnHeader headerCashDesk = new ColumnHeader();

            headerQty1.Text = "x 1";
            headerQty1.Width = 80;
            headerQty1.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty1);

            headerQty2.Text = "x 2";
            headerQty2.Width = 80;
            headerQty2.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty2);

            headerQty5.Text = "x 5";
            headerQty5.Width = 80;
            headerQty5.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty5);

            headerQty10.Text = "x 10";
            headerQty10.Width = 80;
            headerQty10.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty10);

            headerQty20.Text = "x 20";
            headerQty20.Width = 80;
            headerQty20.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty20);

            headerQty50.Text = "x 50";
            headerQty50.Width = 80;
            headerQty50.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty50);

            headerQty100.Text = "x 100";
            headerQty100.Width = 80;
            headerQty100.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerQty100);

            headerCashDesk.Text = "Каса";
            headerCashDesk.Width = 100;
            headerCashDesk.TextAlign = HorizontalAlignment.Center;
            this.CashDeskListView.Columns.Add(headerCashDesk);
        }
    }
}
