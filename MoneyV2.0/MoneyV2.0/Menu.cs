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
        public bool MoneyFormWasSaved = false;
        public DateTime today = DateTime.Today;
        private DateTime pickedDate;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pickedDate = dateTimePicker.Value.Date;
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
            LoadData();
        }

        private void OpenHistoryForm_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void OpenMoneyFormBtn_Click(object sender, EventArgs e)
        {
            MoneyFormWasSaved = false;
            var moneyForm = new MoneyForm(this);
            moneyForm.ShowDialog();
            if (MoneyFormWasSaved)
            {
                ReloadData();
            }
            
        }
        public void LoadData()
        {
            LoadCashDeskView();
            LoadSessionView(today);
        }
        public void ReloadData()
        {
            ReloadCashDeskView();
            ReloadSessionView();
        }
        private void ReloadCashDeskView() 
        {
            CashDeskListView.Items.Clear();
            LoadCashDeskView();
        }

        private void ReloadSessionView()
        {
            SessionView.Items.Clear();
            LoadSessionView(pickedDate);
        }
        private void LoadSessionView(DateTime date)
        {
            using (var db = new DatabaseContext())
            {
                dynamic moneyInCurrentSession;
                if (onlyThisComputer)
                {
                    moneyInCurrentSession = (from a in db.Money
                                                 where a.Owner == Environment.MachineName
                                                 where a.Session.Date == date                                                 
                                                 select new
                                                 {
                                                     Id = a.MoneyId,
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
                                                 where a.Session.Date == date
                                                 select new
                                                 {
                                                     Id = a.MoneyId,
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
                    foreach (var item in moneyInCurrentSession)
                    {
                        itemValues.Add(new string[]{
                            item.Id.ToString(),
                            item.Date.ToShortDateString(),
                            item.Category.ToString(),
                            item.Aim.ToString(),
                            item.Amount.ToString(),
                            item.Owner,
                            item.Note
                        });
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
            using (var db = new MoneyContext())
            {
                //extract Sum of all Incomes and Sum of all Outcomes, they are separated in cashDesk[0] and cashDesk[1]
                var cashDesk = (from a in db.Money
                                group a by a.Category.isIncome into b
                                select new
                                {
                                    Quantity1 = b.Sum(x => x.Quantity1),
                                    Quantity2 = b.Sum(x => x.Quantity2),
                                    Quantity5 = b.Sum(x => x.Quantity5),
                                    Quantity10 = b.Sum(x => x.Quantity10),
                                    Quantity20 = b.Sum(x => x.Quantity20),
                                    Quantity50 = b.Sum(x => x.Quantity50),
                                    Quantity100 = b.Sum(x => x.Quantity100),
                                    BanknotiAmount = b.Sum(x => x.BanknotiAmount),
                                }).ToList();
                //throws exception if there isn't cashdesk money
                //Count needs to be 2 because cashdesk[1] is incomes and cashdesk[0] is outcomes
                if (cashDesk.Count == 2)
                {
                    string[] itemValues = new string[] 
                                        {
                                            (cashDesk[1].Quantity100-cashDesk[0].Quantity100).ToString(),
                                            (cashDesk[1].Quantity50-cashDesk[0].Quantity50).ToString(),
                                            (cashDesk[1].Quantity20-cashDesk[0].Quantity20).ToString(),
                                            (cashDesk[1].Quantity10-cashDesk[0].Quantity10).ToString(),
                                            (cashDesk[1].Quantity5-cashDesk[0].Quantity5).ToString(),
                                            (cashDesk[1].Quantity2-cashDesk[0].Quantity2).ToString(),
                                            (cashDesk[1].Quantity1-cashDesk[0].Quantity1).ToString(),
                                            (cashDesk[1].BanknotiAmount-cashDesk[0].BanknotiAmount).ToString()
                                        };                    
                   
                    this.CashDeskListView.Items.Add(new ListViewItem(itemValues));
                }
            }
        }

        private void NextDateBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
            pickedDate = dateTimePicker.Value.Date;
            ReloadSessionView();
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
