using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Controllers;
using MoneyV2._0.Interfaces;
using MoneyV2._0.Models;

namespace MoneyV2._0
{
    public partial class MoneyForm : Form
    {
        public bool isNewMoneyCategoryIncome = false;
        private bool isCategorySelectedIncome = false;
        private bool existingCategoryValue = false;
        private bool existingAimValue = false;
        public MoneyForm()
        {
            InitializeComponent();
            
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var CategoryForm = new CategoryForm(this);
            CategoryForm.Show();
            if (!areComboBoxesEmpty)
            {
                ReloadData();
            }
            
        }

        private void SumAllBanknotiOnTextChanged()
        {
            this.OutcomeAmountTB.Text = (int.Parse(Qty100TB.Text) * 100
                + int.Parse(Qty50TB.Text) * 50
                + int.Parse(Qty20TB.Text) * 20
                + int.Parse(Qty10TB.Text) * 10
                + int.Parse(Qty5TB.Text) * 5
                + int.Parse(Qty2TB.Text) * 2
                + int.Parse(Qty1TB.Text) * 1).ToString();
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                //Validating data in Category and Aim comboboxes
                existingCategoryValue = false;
                //if selected control is CategoryComboBox
                if (this.ActiveControl.Name == this.CategoryComboBox.Name)
                {
                    //MessageBox.Show(CategoryComboBox.Text);
                    foreach (var category in CategoryComboBox.Items)
                    {
                        if (category.ToString().Equals(CategoryComboBox.Text))
                        {
                            existingCategoryValue = true;
                        }
                    }
                    //MessageBox.Show(existingCategoryValue.ToString());
                    if (existingCategoryValue == false)
                    {
                        var CategoryForm = new CategoryForm(this);
                        CategoryForm.Show();
                        using (var db = new MoneyDbContext())
                        {
                            var newCategory = new Category();
                            newCategory.CategoryName = CategoryComboBox.Text;
                            if (isCategorySelectedIncome == false)
                            {
                                newCategory.isIncome = false;
                            }
                            else
                            {
                                newCategory.isIncome = true;
                            }
                            db.Categories.Add(newCategory);
                            db.SaveChanges();
                        }
                    }
                }
                existingAimValue = false;
                //if selected control is AimComboBox
                if (this.ActiveControl.Name == this.AimComboBox.Name)
                {
                    //MessageBox.Show(CategoryComboBox.Text);
                    foreach (var aim in AimComboBox.Items)
                    {
                        if (aim.ToString().Equals(AimComboBox.Text))
                        {
                            existingAimValue = true;
                        }
                    }
                    //MessageBox.Show(existingCategoryValue.ToString());
                    if (existingAimValue == false)
                    {
                        using (var db = new MoneyDbContext())
                        {
                            var newAim = new Aim();
                            newAim.AimName = AimComboBox.Text;
                            newAim.Categories.Where(c => c.CategoryName.Equals(CategoryComboBox.SelectedText));
                            db.Aims.Add(newAim);
                            db.SaveChanges();
                        }
                    }
                }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }          
                
        }



        private void OutcomeForm_Load(object sender, EventArgs e)
        {
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CategoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.CategoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.AimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.AimComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AimComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            

            using (var db = new MoneyDbContext())
            {
                var categoryList = new List<string>();
                var categories = db.Categories;
                foreach (var category in categories)
                {
                    categoryList.Add(category.CategoryName);
                }
                this.CategoryComboBox.DataSource = categoryList;
                //isCategorySelectedIncome = from a in db.Categories
                //                           from b in db.Money
                //                           where a.CategoryId=b.
                //                           select a.isIncome;

            }

            if (notFromOfis)
            {
                Qty100TB.ReadOnly = true;
                Qty50TB.ReadOnly = true;
                Qty20TB.ReadOnly = true;
                Qty10TB.ReadOnly = true;
                Qty5TB.ReadOnly = true;
                Qty2TB.ReadOnly = true;
                Qty1TB.ReadOnly = true;
                OutcomeAmountTB.ReadOnly = false;
                dateTimePicker.Enabled = false;
            }
            ReloadData();
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(CategoryComboBox.SelectedValue.ToString());
            using (var db = new MoneyDbContext())
            {
                var aims = from a in db.Categories
                           from b in a.Aims
                           where a.CategoryName == CategoryComboBox.Text
                           select b.AimName;
                
                var aimslist = aims.ToList<string>();
                AimComboBox.DataSource = aimslist;
            }            
            

        }

        public void ReloadData()
        {
            
            using (var db = new MoneyDbContext())
            {
                //Reload Source ComboBox
                //var sourceList = new List<string>();
                //var sources = db.Sources;
                //foreach (var source in sources)
                //{
                //    sourceList.Add(source.SourceName);
                //}
                //this.SourceCB.DataSource = sourceList;
                //Reload Category ComboBox
                var categoryList = new List<string>();
                var categories = db.Categories;
                foreach (var category in categories)
                {
                    categoryList.Add(category.CategoryName);
                }
                this.CategoryComboBox.DataSource = categoryList;

                //Reload Aim ComboBox
                var aims = from a in db.Categories
                           from b in a.Aims
                           where a.CategoryName == CategoryComboBox.Text
                           select b.AimName;

                var aimslist = aims.ToList<string>();
                AimComboBox.DataSource = aimslist;
                //if (aimList.Count == 0 || categoryList.Count == 0)
                //{
                //    areComboBoxesEmpty = true;                    
                //}
            }
        }
        private void AddOutcomeSourceBtn_Click(object sender, EventArgs e)
        {
            var outcomeAimForm = new CategoryForm(this);
            outcomeAimForm.Show();
            if (!areComboBoxesEmpty)
            {
                ReloadData();
            }
        }

        private void OutcomeFormOKBtn_Click(object sender, EventArgs e)
        {
            using(var db = new MoneyDbContext())
            {
                var money = new Money();
                money.Amount = double.Parse(this.OutcomeAmountTB.Text);
                money.Date = dateTimePicker.Value;
                money.Note = NoteTextBox.Text;
                money.Quantity1 = int.Parse(Qty1TB.Text);
                money.Quantity2 = int.Parse(Qty2TB.Text);
                money.Quantity5 = int.Parse(Qty5TB.Text);
                money.Quantity10 = int.Parse(Qty10TB.Text);
                money.Quantity20 = int.Parse(Qty20TB.Text);
                money.Quantity50 = int.Parse(Qty50TB.Text);
                money.Quantity100 = int.Parse(Qty100TB.Text);
                var foundCategoryInDb = db.Categories
                    .SingleOrDefault(x => x.CategoryName.Equals(this.CategoryComboBox.SelectedValue.ToString()));
                money.Category = foundCategoryInDb;

                var foundAimInDb = db.Aims
                    .SingleOrDefault(x => x.AimName.Equals(this.AimComboBox.SelectedValue.ToString()));
                money.Aim = foundAimInDb;
                
                db.Money.Add(money);
                db.SaveChanges();

                //string[] transfer = new string[2];
                //transfer[0] = this.AimComboBox.SelectedValue.ToString();
                //transfer[1] = this.OutcomeAmountTB.Text;
                //parent.GiveParentOutcomeSaved(transfer);
            }
            this.Close();
        }

        private void OutcomeAmountTB_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(OutcomeAmountTB.Text, out a))
            {
                OutcomeAmountTB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
        }

        private void Qty100TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty100TB.Text, out a))
            {
                Qty100TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty50TB_TextChanged(object sender, EventArgs e)
        {
            int a;            
            if (!int.TryParse(Qty50TB.Text, out a))
            {
                Qty50TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty20TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty20TB.Text, out a))
            {
                Qty20TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty10TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty10TB.Text, out a))
            {
                Qty10TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty5TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty5TB.Text, out a))
            {
                Qty5TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty2TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty2TB.Text, out a))
            {
                Qty2TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }

        private void Qty1TB_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(Qty1TB.Text, out a))
            {
                Qty1TB.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }
    }
}
