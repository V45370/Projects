using MoneyV2._0.Controllers;
using MoneyV2._0.Models;
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
    public partial class AdditiveOutcomeForm : Form
    {
        private bool existingAimValue = false;
        private bool existingCategoryValue = false;
        public AdditiveOutcomeForm(MoneyForm _parent)
        {
            InitializeComponent();
            ReloadData();
            ComboboxesAdjustements();
            var parent = _parent;
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
                var button = (Button)sender;
                if(button.Name == MoneyFormSaveBtn.Name)
                {
                    SaveChangesAndClose();
                }
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }
        private void SaveChangesAndClose()
        {
            using(var db = new DatabaseContext())
            {
                var selectedCategory = db.Categories.SingleOrDefault(x => x.CategoryName.Equals(this.CategoryComboBox.Text));
                var selectedAim = db.Aims.SingleOrDefault(x=>x.AimName.Equals(this.AimComboBox.Text));
                double amount = double.Parse(this.AmountTB.Text);
                var outcome = new Money(selectedCategory, selectedAim, amount);
            }
            
            this.Close();
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
        private void ComboboxesAdjustements()
        {

            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CategoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.CategoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.AimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.AimComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AimComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void MoneyFormSaveBtn_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Моля въведете валидна категория");  
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
                    MessageBox.Show("Моля въведете валидна цел");
                }
            }
        }
    }
}
