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
        public bool isNewMoneyCategoryIncome = false; // used in CategoryForm when picking
        private bool isCategorySelectedIncome = false;
        private bool existingCategoryValue = false;
        private bool existingAimValue = false;
        public MoneyForm()
        {
            InitializeComponent();
            
        }

        private void OpenCategoryForm()
        {
            var CategoryForm = new CategoryForm(this);
            CategoryForm.ShowDialog();
            
        }

        private void SumAllBanknotiOnTextChanged()
        {
            this.AmountTB.Text = (int.Parse(Qty100TB.Text) * 100
                + int.Parse(Qty50TB.Text) * 50
                + int.Parse(Qty20TB.Text) * 20
                + int.Parse(Qty10TB.Text) * 10
                + int.Parse(Qty5TB.Text) * 5
                + int.Parse(Qty2TB.Text) * 2
                + int.Parse(Qty1TB.Text) * 1).ToString();
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
                        using (var db = new DatabaseContext())
                        {
                            var newCategory = new Category();
                            newCategory.CategoryName = currentSelectedCategory;
                            if (isNewMoneyCategoryIncome == false)
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
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Enter)
            {               
                ValidateCategoryCombobox();
                ValidateAimCombobox();
                this.SelectNextControl((Control)sender, true, true, true, true);
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
            using (var db = new DatabaseContext())
            {
                var categoryList = new List<string>();
                var categories = db.Categories;
                foreach (var category in categories)
                {
                    categoryList.Add(category.CategoryName);
                }
                this.CategoryComboBox.DataSource = categoryList;
            }
            ReloadData();
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(CategoryComboBox.SelectedValue.ToString());
            using (var db = new DatabaseContext())
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

        private void MoneyFormSaveBtn_Click(object sender, EventArgs e)
        {
            using(var db = new DatabaseContext())
            {
                var money = new Money();
                money.Amount = double.Parse(this.AmountTB.Text);
                money.Date = dateTimePicker.Value.Date;
                money.Note = NoteTextBox.Text;
                money.Quantity1 = int.Parse(Qty1TB.Text);
                money.Quantity2 = int.Parse(Qty2TB.Text);
                money.Quantity5 = int.Parse(Qty5TB.Text);
                money.Quantity10 = int.Parse(Qty10TB.Text);
                money.Quantity20 = int.Parse(Qty20TB.Text);
                money.Quantity50 = int.Parse(Qty50TB.Text);
                money.Quantity100 = int.Parse(Qty100TB.Text);
                var foundCategoryInDb = db.Categories
                    .SingleOrDefault(x => x.CategoryName.Equals(this.CategoryComboBox.Text));
                money.Category = foundCategoryInDb;

                var foundAimInDb = db.Aims
                    .SingleOrDefault(x => x.AimName.Equals(this.AimComboBox.Text));
                money.Aim = foundAimInDb;
                
                db.Money.Add(money);
                db.SaveChanges();
            }
            this.Close();
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            double a;
            if (!double.TryParse(textBox.Text, out a))
            {
                textBox.Text = "0";
                MessageBox.Show("Моля въведете валидно число.");
            }
            else
            {
                SumAllBanknotiOnTextChanged();
            }
        }
    }
}
