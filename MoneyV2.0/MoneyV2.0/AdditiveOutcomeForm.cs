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
        private MoneyForm parent;
        public AdditiveOutcomeForm(MoneyForm _parent)
        {
            InitializeComponent();
            ReloadData();
            ComboboxesAdjustements();
            parent = _parent;
        }
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateCategoryCombobox();
                ValidateAimCombobox();
                this.SelectNextControl((Control)sender, true, true, true, true);
                if (this.ActiveControl.Name == AdditiveOutcomeSaveBtn.Name)
                {
                    SaveChangesAndClose();
                }
            }

        }
        private void SaveChangesAndClose()
        {
            var item = new string[] { 
                        CategoryComboBox.Text,
                        AimComboBox.Text,
                        AmountTB.Text 
                        };
            parent.additiveItems.Add(item);
            
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
                    //Load only Outcomes
                    if (!category.isIncome && !category.isForBank)
                    {
                        categoryList.Add(category.CategoryName);
                    }
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

        private void AdditiveOutcomeSaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AmountTB.Text) || double.Parse(AmountTB.Text)==0) 
            {
                MessageBox.Show("Въведете сума");
            }
            else
            {
                SaveChangesAndClose();
            }
           
        }

        private void ValidateCategoryCombobox()
        {
            var existingCategoryValue = false;
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
                if (existingCategoryValue == false)
                {                    
                    MessageBox.Show("Моля въведете валидна категория");
                    CategoryComboBox.Text = String.Empty;
                }
            }
        }
        private void ValidateAimCombobox()
        {
            var existingAimValue = false;
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
                    CategoryComboBox.Text = String.Empty;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

    }
}
