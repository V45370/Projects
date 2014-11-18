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
        private bool isCurrentCategoryIncome = false;
        public bool isNewMoneyCategoryIncome=false; // used in CategoryForm when picking
        private bool isCategorySelectedIncome = false;
        private bool existingCategoryValue = false;
        private bool existingAimValue = false;
        private Menu parent;
        public MoneyForm(Menu _parent)
        {
            InitializeComponent();
            parent = _parent;
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
            ReloadData();
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aim combobox loads items for selected category 
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

            LockTextBoxesAndChangeColor();
        }

        private void LockTextBoxesAndChangeColor()
        {
            if (isCurrentCategoryIncome)
            {
                Qty100TB.ReadOnly = false;
                Qty50TB.ReadOnly = false;
                Qty20TB.ReadOnly = false;
                Qty10TB.ReadOnly = false;
                Qty5TB.ReadOnly = false;
                Qty2TB.ReadOnly = false;
                Qty1TB.ReadOnly = false;
                AmountTB.ReadOnly = true;
                AmountLabel.Text = "Приходна сума";
                CategoryComboBox.BackColor = Color.PaleGreen;
            }
            else
            {
                Qty100TB.ReadOnly = true;
                Qty50TB.ReadOnly = true;
                Qty20TB.ReadOnly = true;
                Qty10TB.ReadOnly = true;
                Qty5TB.ReadOnly = true;
                Qty2TB.ReadOnly = true;
                Qty1TB.ReadOnly = true;
                AmountTB.ReadOnly = false;

                AmountLabel.Text = "Разходна сума";
                CategoryComboBox.BackColor = Color.LightSalmon;
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
            parent.lastMoneyRecord.Amount = double.Parse(this.AmountTB.Text);
            parent.lastMoneyRecord.Date = dateTimePicker.Value.Date;
            parent.lastMoneyRecord.Note = NoteTextBox.Text;
            parent.lastMoneyRecord.Quantity1 = int.Parse(Qty1TB.Text);
            parent.lastMoneyRecord.Quantity2 = int.Parse(Qty2TB.Text);
            parent.lastMoneyRecord.Quantity5 = int.Parse(Qty5TB.Text);
            parent.lastMoneyRecord.Quantity10 = int.Parse(Qty10TB.Text);
            parent.lastMoneyRecord.Quantity20 = int.Parse(Qty20TB.Text);
            parent.lastMoneyRecord.Quantity50 = int.Parse(Qty50TB.Text);
            parent.lastMoneyRecord.Quantity100 = int.Parse(Qty100TB.Text);
            parent.CategorySelected = this.CategoryComboBox.Text;
            parent.AimSelected = this.AimComboBox.Text;
            parent.Owner = Environment.MachineName;

            parent.MoneyFormWasSaved = true;
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

        private void NextDateBtn_Click(object sender, EventArgs e)
        {
           dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        private void PreviusDateBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }

        private void OutcomeAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
