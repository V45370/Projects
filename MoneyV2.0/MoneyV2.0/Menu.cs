using System;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Interfaces;
using MoneyV2._0.Models;
using MoneyV2._0.Controllers;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Drawing;

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
        private void CheckIfSessionExists()
        {
            using (var db = new DatabaseContext())
            {
                var checkSessionExists = db.Sessions.SingleOrDefault(s => s.Date.Equals(today));
                if (checkSessionExists == null || !checkSessionExists.Date.Equals(today))
                {
                    db.Sessions.Add(new Session() { Date = today });
                    db.SaveChanges();
                }

            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            pickedDate = dateTimePicker.Value.Date;
            CheckIfSessionExists();
            LoadData();
        }

        private void OpenSearchForm_Click(object sender, EventArgs e)
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
            using (var db = new DatabaseContext())
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

                //query all money in todays session
                var session = (from a in db.Sessions
                                  from b in a.Moneys
                                  where a.Date == today
                                  select b).ToList();
                //query all money on this computer
                var machineName = Environment.MachineName;
                var currentSession = (from a in db.Sessions
                               from b in a.Moneys
                               where a.Date == today && b.Owner==machineName
                               select b).ToList();
                //throws exception if there isn't cashdesk money
                //Count needs to be 2 because cashdesk[1] is incomes and cashdesk[0] is outcomes
                if (cashDesk.Count == 2)
                {
                    //Cashdesk
                    int cashDeskQty100 = cashDesk[1].Quantity100 - cashDesk[0].Quantity100;
                    int cashDeskQty50 = cashDesk[1].Quantity50-cashDesk[0].Quantity50;
                    int cashDeskQty20 = cashDesk[1].Quantity20-cashDesk[0].Quantity20;
                    int cashDeskQty10 = cashDesk[1].Quantity10-cashDesk[0].Quantity10;
                    int cashDeskQty5 = cashDesk[1].Quantity5-cashDesk[0].Quantity5;
                    int cashDeskQty2 = cashDesk[1].Quantity2-cashDesk[0].Quantity2;
                    int cashDeskQty1 = cashDesk[1].Quantity1-cashDesk[0].Quantity1;
                    int cashDeskBanknotiAmount = cashDesk[1].BanknotiAmount-cashDesk[0].BanknotiAmount;
                    string[] cashDeskValues = new string[] 
                                        {
                                            (cashDeskQty100).ToString(),
                                            (cashDeskQty50).ToString(),
                                            (cashDeskQty20).ToString(),
                                            (cashDeskQty10).ToString(),
                                            (cashDeskQty5).ToString(),
                                            (cashDeskQty2).ToString(),
                                            (cashDeskQty1).ToString(),
                                            (cashDeskBanknotiAmount).ToString()
                                        };
                    //Today's Session
                    int sessionDeskQty100 = 0;
                    int sessionDeskQty50 = 0;
                    int sessionDeskQty20 = 0;
                    int sessionDeskQty10 = 0;
                    int sessionDeskQty5 = 0;
                    int sessionDeskQty2 = 0;
                    int sessionDeskQty1 = 0;
                    int sessionDeskBanknotiAmount = 0;
                    foreach (var money in session)
                    {
                        if(money.Category.isIncome)
                        {
                            sessionDeskQty100 += money.Quantity100;
                            sessionDeskQty50 += money.Quantity50;
                            sessionDeskQty20 += money.Quantity20;
                            sessionDeskQty10 += money.Quantity10;
                            sessionDeskQty5 += money.Quantity5;
                            sessionDeskQty2 += money.Quantity2;
                            sessionDeskQty1 += money.Quantity1;
                            sessionDeskBanknotiAmount += money.BanknotiAmount;
                        }
                        else
                        {
                            sessionDeskQty100 -= money.Quantity100;
                            sessionDeskQty50 -= money.Quantity50;
                            sessionDeskQty20 -= money.Quantity20;
                            sessionDeskQty10 -= money.Quantity10;
                            sessionDeskQty5 -= money.Quantity5;
                            sessionDeskQty2 -= money.Quantity2;
                            sessionDeskQty1 -= money.Quantity1;
                            sessionDeskBanknotiAmount -= money.BanknotiAmount;
                        }
                        

                    }
                    string[] sessionDeskValues = new string[]
                                        {
                                            sessionDeskQty100.ToString(),
                                            sessionDeskQty50.ToString(),
                                            sessionDeskQty20.ToString(),
                                            sessionDeskQty10.ToString(),
                                            sessionDeskQty5.ToString(),
                                            sessionDeskQty2.ToString(),
                                            sessionDeskQty1.ToString(),
                                            sessionDeskBanknotiAmount.ToString()
                                        };
                    //Today's session on this computer
                    int currentSessionDeskQty100 = 0;
                    int currentSessionDeskQty50 = 0;
                    int currentSessionDeskQty20 = 0;
                    int currentSessionDeskQty10 = 0;
                    int currentSessionDeskQty5 = 0;
                    int currentSessionDeskQty2 = 0;
                    int currentSessionDeskQty1 = 0;
                    int currentSessionDeskBanknotiAmount = 0;
                    foreach (var money in currentSession)
                    {
                       if(money.Category.isIncome)
                        {
                            currentSessionDeskQty100 += money.Quantity100;
                            currentSessionDeskQty50 += money.Quantity50;
                            currentSessionDeskQty20 += money.Quantity20;
                            currentSessionDeskQty10 += money.Quantity10;
                            currentSessionDeskQty5 += money.Quantity5;
                            currentSessionDeskQty2 += money.Quantity2;
                            currentSessionDeskQty1 += money.Quantity1;
                            currentSessionDeskBanknotiAmount += money.BanknotiAmount;
                        }
                        else
                        {
                            currentSessionDeskQty100 -= money.Quantity100;
                            currentSessionDeskQty50 -= money.Quantity50;
                            currentSessionDeskQty20 -= money.Quantity20;
                            currentSessionDeskQty10 -= money.Quantity10;
                            currentSessionDeskQty5 -= money.Quantity5;
                            currentSessionDeskQty2 -= money.Quantity2;
                            currentSessionDeskQty1 -= money.Quantity1;
                            currentSessionDeskBanknotiAmount -= money.BanknotiAmount;
                        } 
                    }
                    string[] currentSessionDeskValues = new string[]
                                        {
                                            (currentSessionDeskQty100).ToString(),
                                            (currentSessionDeskQty50).ToString(),
                                            (currentSessionDeskQty20).ToString(),
                                            (currentSessionDeskQty10).ToString(),
                                            (currentSessionDeskQty5).ToString(),
                                            (currentSessionDeskQty2).ToString(),
                                            (currentSessionDeskQty1).ToString(),
                                            (currentSessionDeskBanknotiAmount).ToString()
                                        };
                    var cashdeskItem = new ListViewItem(cashDeskValues);
                    cashdeskItem.ForeColor = Color.Red;
                    var sessionDeskItem = new ListViewItem(sessionDeskValues);
                    sessionDeskItem.ForeColor = Color.SteelBlue;
                    var currentSessiondeskItem = new ListViewItem(currentSessionDeskValues);
                    currentSessiondeskItem.ForeColor = Color.Green;

                    this.CashDeskListView.Items.Add(cashdeskItem);
                    this.CashDeskListView.Items.Add(sessionDeskItem);
                    this.CashDeskListView.Items.Add(currentSessiondeskItem);
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
