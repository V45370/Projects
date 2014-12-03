using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Controllers;
using MoneyV2._0.Interfaces;
using MoneyV2._0.Models;
using System.Drawing;

namespace MoneyV2._0
{
    public partial class MoneyForm : Form
    {
        public List<string[]> additiveItems = new List<string[]>();
        private bool isCurrentCategoryIncome = false;
        public bool isNewMoneyCategoryIncome=false; // used in CategoryForm when picking
        private bool isCategorySelectedIncome = false;
        private bool existingCategoryValue = false;
        private bool existingAimValue = false;
        private Menu parent;
        public bool isNewCategorySaved = false;
        public bool isNewCategoryForBank = false;
        public MoneyForm(Menu _parent)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            parent = _parent;
        }

        private void OpenCategoryForm()
        {
            isNewCategorySaved = false;
            var CategoryForm = new CategoryForm(this);
            CategoryForm.ShowDialog();
            
        }

        private void ChangeAmountsOnTextChanged()
        {
            this.BanknotiAmountTB.Text = (int.Parse(Qty100TB.Text) * 100
                + int.Parse(Qty50TB.Text) * 50
                + int.Parse(Qty20TB.Text) * 20
                + int.Parse(Qty10TB.Text) * 10
                + int.Parse(Qty5TB.Text) * 5
                + int.Parse(Qty2TB.Text) * 2
                + int.Parse(Qty1TB.Text) * 1).ToString();
            this.TotalTB.Text = (double.Parse(BanknotiAmountTB.Text) + double.Parse(AdditiveAmountTB.Text)).ToString();
        }

        private void ValidateCategoryCombobox()
        {            
            existingCategoryValue = false;
            //if selected control is CategoryComboBox
            if (this.ActiveControl.Name == this.CategoryComboBox.Name)
            {
                //Search if entered value exists in combobox
                foreach (var category in CategoryComboBox.Items)
                {
                    if (category.ToString().Equals(CategoryComboBox.Text))
                    {
                        existingCategoryValue = true;
                    }
                }
                //If entered value isn't in the combobox, we add it in database
                if (existingCategoryValue == false)
                {
                    var currentSelectedCategory = CategoryComboBox.Text;
                    if (String.IsNullOrEmpty(currentSelectedCategory))
                    {
                        MessageBox.Show("Моля въведете валидна категория");
                    }
                    else
                    {
                        OpenCategoryForm();
                        if(isNewCategorySaved==true)
                        {
                            using (var db = new DatabaseContext())
                            {
                                var newCategory = new Category();
                                newCategory.CategoryName = currentSelectedCategory;
                                if (isNewMoneyCategoryIncome == false)
                                {
                                    if (isNewCategoryForBank == true)
                                    {
                                        newCategory.isForBank = true;
                                    }
                                    else
                                    {
                                        newCategory.isForBank = false;
                                    }
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
                        
                        ReloadData();
                        CategoryComboBox.Text = currentSelectedCategory;                        
                    }

                }
            }
        }
        private void ValidateAimCombobox()
        {
            existingAimValue = false;
            //if selected control is AimComboBox
            if (this.ActiveControl.Name == this.AimComboBox.Name)
            {
                foreach (var aim in AimComboBox.Items)
                {
                    if (aim.ToString().Equals(AimComboBox.Text))
                    {
                        existingAimValue = true;
                    }
                }
                if (existingAimValue == false)
                {
                    var currentSelectedAim = AimComboBox.Text;
                    var currentSelectedCategory = CategoryComboBox.Text;
                    if (String.IsNullOrEmpty(currentSelectedAim))
                    {
                        MessageBox.Show("Моля въведете валидна цел");
                    }
                    else
                    {
                        using (var db = new DatabaseContext())
                        {
                            var newAim = new Aim();
                            newAim.AimName = AimComboBox.Text;
                            db.Aims.Add(newAim);
                            db.SaveChanges();
                            var selectedCategory = db.Categories
                             .SingleOrDefault(x => x.CategoryName.Equals(this.CategoryComboBox.SelectedValue.ToString()));
                            selectedCategory.Aims.Add(newAim);
                            db.SaveChanges();
                        }
                        ReloadData();
                        //return current selected items after reload
                        CategoryComboBox.Text = currentSelectedCategory;
                        AimComboBox.Text = currentSelectedAim;
                    }
                    
                }
            }
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                ValidateCategoryCombobox();
                ValidateAimCombobox();
                this.SelectNextControl((Control)sender, true, true, true, true);
                if (this.ActiveControl.Name == this.MoneyFormSaveBtn.Name)
                {
                    AddMoneyToSession();
                    this.Close();
                }
            }          
                
        }

        private void ComboboxesAdjustements()
        {

            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CategoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.CategoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.AimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.AimComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AimComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }

        private void MoneyForm_Load(object sender, EventArgs e)
        {
            ComboboxesAdjustements();
            LoadData();
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aim combobox loads items when selected category 
            using (var db = new DatabaseContext())
            {
                var selectedCat = db.Categories.SingleOrDefault(c => c.CategoryName.Equals(CategoryComboBox.Text));
                isCurrentCategoryIncome = selectedCat.isIncome;

                var aims = from a in db.Categories
                           from b in a.Aims
                           where a.CategoryName == CategoryComboBox.Text
                           select b.AimName;
                
                var aimslist = aims.ToList<string>();
                AimComboBox.DataSource = aimslist;
            }

            TextBoxesChangeColorAndLockAdditiveBtn();
        }

        private void TextBoxesChangeColorAndLockAdditiveBtn()
        {
            if (isCurrentCategoryIncome)
            {
                CategoryComboBox.BackColor = Color.PaleGreen;
                this.AdditiveOutcomeBtn.Enabled = true;
                this.AdditiveListView.Enabled = true;
            }
            else
            {
                CategoryComboBox.BackColor = Color.LightSalmon;
                this.AdditiveOutcomeBtn.Enabled = false;
                this.AdditiveListView.Enabled = false;
                this.additiveItems.Clear();
                this.AdditiveListView.Items.Clear();
                this.AdditiveAmountTB.Text = "0";
            }
                
        }
        public void LoadData()
        {
            
            using (var db = new DatabaseContext())
            {
                
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
            }
        }

        public void ReloadData()
        {           
            LoadData();            
        }
        private void AddMoneyToSession()
        
        {
            using (var db = new DatabaseContext())
            {
                var moneyRecord = new Money();
                var thisSession = db.Sessions.SingleOrDefault(x => x.Date.Equals(parent.today));
                moneyRecord.Amount = double.Parse(this.TotalTB.Text);
                moneyRecord.Date = dateTimePicker.Value.Date;
                moneyRecord.Note = NoteTextBox.Text;
                moneyRecord.Quantity1 = int.Parse(Qty1TB.Text);
                moneyRecord.Quantity2 = int.Parse(Qty2TB.Text);
                moneyRecord.Quantity5 = int.Parse(Qty5TB.Text);
                moneyRecord.Quantity10 = int.Parse(Qty10TB.Text);
                moneyRecord.Quantity20 = int.Parse(Qty20TB.Text);
                moneyRecord.Quantity50 = int.Parse(Qty50TB.Text);
                moneyRecord.Quantity100 = int.Parse(Qty100TB.Text);
                moneyRecord.BanknotiAmount = int.Parse(BanknotiAmountTB.Text);
                Category foundCategory = db.Categories.SingleOrDefault(x => x.CategoryName.Equals(this.CategoryComboBox.Text));
                moneyRecord.Category = foundCategory;
                Aim foundAim = (from a in db.Categories
                                from b in a.Aims
                                where b.AimName == AimComboBox.Text
                                select b).FirstOrDefault();
                moneyRecord.Aim = foundAim;
                moneyRecord.Owner = Environment.MachineName;
                //Workaround EntityFramework. Original Object causes exception!
                //var deepCopy = (Money)moneyRecord.DeepCopy();
                thisSession.Moneys.Add(moneyRecord);

                if(additiveItems.Count!=0)
                {
                    Money outcome;
                    foreach (var item in additiveItems)
                    {
                        string categoryName = item[0];
                        string aimName = item[1];
                        double amount = double.Parse(item[2]);
                        Category category = db.Categories.SingleOrDefault(x => x.CategoryName.Equals(categoryName));
                        Aim aim = (from a in db.Categories
                                   from b in a.Aims
                                   where b.AimName == aimName
                                   select b).FirstOrDefault();
                        outcome = new Money(category, aim, amount);
                        outcome.Date = dateTimePicker.Value.Date;
                        outcome.Note = "Допълнителна сума";
                        thisSession.Moneys.Add(outcome);
                    }
                }                
                db.SaveChanges();

                parent.MoneyFormWasSaved = true;
            }
        }
        private void MoneyFormSaveBtn_Click(object sender, EventArgs e)
        {
            AddMoneyToSession();
            this.Close();
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int a;
            if (!int.TryParse(textBox.Text, out a))
            {
                textBox.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                ChangeAmountsOnTextChanged();
                
            }
        }

        private void NextDateBtn_Click(object sender, EventArgs e)
        {
           this.dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        private void PreviusDateBtn_Click(object sender, EventArgs e)
        {
           this. dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }
        private void OpenAdditiveOutcomeForm()
        {
            var additiveOutcomeForm = new AdditiveOutcomeForm(this);
            additiveOutcomeForm.ShowDialog(this);
            ReloadAdditiveListViewAndAdditiveAmount();
        }

        private void AdditiveOutcomeBtn_Click(object sender, EventArgs e)
        {
            OpenAdditiveOutcomeForm();

        }
        private void ReloadAdditiveListViewAndAdditiveAmount()
        {
            AdditiveListView.Items.Clear();
            double additiveamount=0;
            foreach (var item in additiveItems)
            {
                AdditiveListView.Items.Add(new ListViewItem(item));
                additiveamount +=double.Parse(item[2]);
            }
            AdditiveAmountTB.Text = additiveamount.ToString();
        }

        private void AdditiveAmountTB_TextChanged(object sender, EventArgs e)
        {
            ChangeAmountsOnTextChanged();
        }

        private void MoneyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && isCurrentCategoryIncome==true)
            {
                OpenAdditiveOutcomeForm();
            }
        }
    }
}
