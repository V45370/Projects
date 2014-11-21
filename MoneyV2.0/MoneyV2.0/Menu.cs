using System;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Interfaces;
using MoneyV2._0.Models;
using MoneyV2._0.Controllers;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace MoneyV2._0
{
    public partial class Menu : Form
    {
        public Session session = new Session();
        private bool onlyThisComputer = false;
        private bool SessionIsEmpty = false;
       // private bool doesSessionExists = false;
        public Money lastMoneyRecord = new Money();
        public string CategorySelected;
        public string AimSelected;
        public string Owner;
        public bool MoneyFormWasSaved = false;
        private DateTime today = DateTime.Today;
        private DateTime pickedDate;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Check if Session exists in database
            using (var db = new DatabaseContext())
            {
                var checkSessionExists =  db.Sessions.SingleOrDefault(s => s.Date.Equals(today));
                if (checkSessionExists==null || !checkSessionExists.Date.Equals(today))
                {
                    db.Sessions.Add(new Session() { Date = today });
                    db.SaveChanges();
                }

            }
            ReloadData();
        }

        private void OpenHistoryForm_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void OpenMoneyFormBtn_Click(object sender, EventArgs e)
        {
            MoneyFormWasSaved = false;
            var moneyForm = new MoneyForm(this);
            moneyForm.ShowDialog();
            if (MoneyFormWasSaved)
            {
                using (var db = new DatabaseContext())
                {
                    var thisSession = db.Sessions.SingleOrDefault(s => s.Date.Equals(today));
                    var foundCategoryInDb = db.Categories
                        .SingleOrDefault(x => x.CategoryName.Equals(CategorySelected));

                    var foundAimInDb = db.Aims
                        .SingleOrDefault(x => x.AimName.Equals(AimSelected));

                    lastMoneyRecord.Aim = foundAimInDb;
                    lastMoneyRecord.Category = foundCategoryInDb;
                    lastMoneyRecord.Owner = Owner;
                    //Workaround EntityFramework. Original Object causes exception!
                    var copy = (Money)lastMoneyRecord.DeepCopy();
                    thisSession.Money.Add(copy);
                    db.SaveChanges();

                }
                ReloadData();
            }
            
        }
        public void ReloadData()
        {

            LoadCashDeskView();
            ReloadSessionView();
        }
        private void ReloadSessionView()
        {
            ClearSessionView();
            LoadSessionView();
        }
        private void ClearSessionView()
        {
            SessionView.Items.Clear();
        }
        private void LoadSessionView()
        {
            using (var db = new DatabaseContext())
            {
                dynamic moneyInCurrentSession;
                if (onlyThisComputer)
                {
                    moneyInCurrentSession = (from a in db.Money
                                                 where a.Owner == Environment.MachineName
                                                 where a.Session.Date == pickedDate                                                 
                                                 select new
                                                 {
                                                     Date = a.Date,
                                                     Category = a.Category.CategoryName,
                                                     Aim = a.Aim.AimName,
                                                     Amount = a.Amount,
                                                     Owner = a.Owner,
                                                     Note = a.Note
                                                 }
                                                 ).ToList();
                }
                else
                {
                    moneyInCurrentSession = (from a in db.Money
                                                 where a.Session.Date == pickedDate
                                                 select new
                                                 {
                                                     Date = a.Date,
                                                     Category = a.Category.CategoryName,
                                                     Aim = a.Aim.AimName,
                                                     Amount = a.Amount,
                                                     Owner = a.Owner,
                                                     Note = a.Note
                                                 }
                                                 ).ToList();
                }
                
                //if currentSession is not empty(populate)
                if(moneyInCurrentSession.Count!=0)
                {
                    List<string[]> itemValues = new List<string[]>();
                    int counter = 1;
                    foreach (var item in moneyInCurrentSession)
                    {
                        itemValues.Add(new string[]{
                            counter.ToString(),
                            item.Date.ToShortDateString(),
                            item.Category.ToString(),
                            item.Aim.ToString(),
                            item.Amount.ToString(),
                            item.Owner,
                            item.Note
                        });
                        counter++;
                    }
                    foreach (var item in itemValues)
                    {
                        this.SessionView.Items.Add(new ListViewItem(item));
                    }
                }


            }
        }
        private void LoadCashDeskView()
        {
            if (CashDeskListView.Items.Count > 0)
            {
                CashDeskListView.Items.RemoveAt(0);
            }
            using (var db = new MoneyContext())
            {
                //extract Sum of all Incomes and Sum of all Outcomes, they are separated in cashDesk[0] and cashDesk[1]
                var cashDesk = (from a in db.Money
                                group a by a.Category into b
                                select new
                                {
                                    Quantity1 = b.Sum(x => x.Quantity1),
                                    Quantity2 = b.Sum(x => x.Quantity2),
                                    Quantity5 = b.Sum(x => x.Quantity5),
                                    Quantity10 = b.Sum(x => x.Quantity10),
                                    Quantity20 = b.Sum(x => x.Quantity20),
                                    Quantity50 = b.Sum(x => x.Quantity50),
                                    Quantity100 = b.Sum(x => x.Quantity100),
                                    Amount = b.Sum(x => x.Amount),
                                }).ToList();
                string[] itemValues = new string[] 
                {
                    (cashDesk[0].Quantity100-cashDesk[1].Quantity100).ToString(),
                    (cashDesk[0].Quantity50-cashDesk[1].Quantity50).ToString(),
                    (cashDesk[0].Quantity20-cashDesk[1].Quantity20).ToString(),
                    (cashDesk[0].Quantity10-cashDesk[1].Quantity10).ToString(),
                    (cashDesk[0].Quantity5-cashDesk[1].Quantity5).ToString(),
                    (cashDesk[0].Quantity2-cashDesk[1].Quantity2).ToString(),
                    (cashDesk[0].Quantity1-cashDesk[1].Quantity1).ToString(),
                    (cashDesk[0].Amount-cashDesk[1].Amount).ToString()
                };
                
                this.CashDeskListView.Items.Add(new ListViewItem(itemValues));

            }
        }

        private void NextDateBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
            pickedDate = dateTimePicker.Value.Date;
            ClearSessionView();
            LoadSessionView();
        }

        private void PreviusDateBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
            pickedDate = dateTimePicker.Value.Date;
            ReloadSessionView();
        }

        private void ThisComputerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ThisComputerCheckBox.Checked)
            {
                onlyThisComputer = true;
            }
            else
            {
                onlyThisComputer = false;
            }
            ReloadSessionView();
        }
    }
}
