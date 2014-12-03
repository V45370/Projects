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

        private bool existingCategoryValue = false;
        private bool existingAimValue = false;
        private bool existingAmountValue = false;
        private MoneyForm parent;
        public AdditiveOutcomeForm(MoneyForm _parent)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            ReloadData();
            ComboboxesAdjustements();
            parent = _parent;
        }
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl.Name == AdditiveOutcomeSaveBtn.Name
                                            && existingAimValue
                                            && existingCategoryValue
                                            && existingAmountValue)
                {
                    SaveChangesAndClose();
                }
                if(this.ActiveControl.Name == CategoryComboBox.Name)
                {
                    if(existingCategoryValue)
                    {
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                    ValidateCategoryCombobox();
                    existingAimValue = false;
                    
                }
                if (this.ActiveControl.Name == AimComboBox.Name)
                {
                    if (existingAimValue)
                    {
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                    ValidateAimCombobox();
                    existingAmountValue = false;
                }
                if (this.ActiveControl.Name == AmountTB.Name)
                {
                    if (existingAmountValue)
                    {
                        this.SelectNextControl((Control)sender, true, true, true, true);
                    }
                    ValidateAmountTB();
                }
                
                
            }

        }
        private void SaveChangesAndClose()
        {
            ValidateAimCombobox();
            ValidateCategoryCombobox();
            ValidateAmountTB();
            var item = new string[] { 
                        CategoryComboBox.Text,
                        AimComboBox.Text,
                        AmountTB.Text 
                        };
            parent.additiveItems.Add(item);
            
            this.Close();
        }

        public void LoadCategoryComboBox()
        {
            using (var db = new DatabaseContext())
            {

                //Reload Category ComboBox
                var categoryList = new List<string>();
                var categories = db.Categories;
                foreach (var category in categories)
                {
                    //Load only Outcomes
                    if (!category.isIncome 
                        && !category.isForBank)
                    {
                        categoryList.Add(category.CategoryName);
                    }
                }
                this.CategoryComboBox.DataSource = categoryList;
            }
        }
        public void LoadAimComboBox()
        {
            
            using (var db = new DatabaseContext())
            {
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
            LoadCategoryComboBox();
            LoadAimComboBox();                
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
            if(existingCategoryValue
               && existingAimValue
               && existingAmountValue)
            {
                SaveChangesAndClose();
            }
            else
            {
                ValidateAmountTB();
                ValidateCategoryCombobox();
                ValidateAimCombobox();
            }
           
        }
        private void ValidateAmountTB()
        {
            if (String.IsNullOrEmpty(AmountTB.Text) || double.Parse(AmountTB.Text) == 0)
            {
                MessageBox.Show("Въведете сума");
                existingAmountValue = false;
                ActiveControl = AmountTB;
            }
            else
            {
                existingAmountValue = true;
            }
        }

        private void ValidateCategoryCombobox()
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
                ActiveControl = CategoryComboBox;
            }
        }        
        private void ValidateAimCombobox()
        {
            //if selected control is AimComboBox
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
                ActiveControl = AimComboBox;
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

        private void CategoryComboBox_Leave(object sender, EventArgs e)
        {
            ValidateCategoryCombobox();
            LoadAimComboBox();
        }

        private void AimComboBox_Leave(object sender, EventArgs e)
        {
            ValidateAimCombobox();
        }

        private void AmountTB_TextChanged(object sender, EventArgs e)
        {
            ValidateAmountTB();
        }

        private void AmountTB_Leave(object sender, EventArgs e)
        {
            ValidateAmountTB();
        }

        private void AdditiveOutcomeForm_Load(object sender, EventArgs e)
        {
            existingCategoryValue = false;
            existingAimValue = false;
            existingAmountValue = false;
        }

    }
}
