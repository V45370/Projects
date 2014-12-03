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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            ComboboxesAdjustements();
        }

        private void ClearSearchListView()
        {
            SearchListView.Items.Clear();
        }
        private void PopulateSearchListView(List<Money> data)
        {
            string[] stringItem;
            foreach (var item in data)
            {
                stringItem = new string[]
                {
                    item.MoneyId.ToString(),
                    item.Date.ToShortDateString(),
                    item.Category.CategoryName,
                    item.Aim.AimName,
                    item.Amount.ToString(),
                    item.Owner,
                    item.Note
                };
                SearchListView.Items.Add(new ListViewItem(stringItem));
            }
        }
        private void Search()
        {
            using (var db = new MoneyContext())
            {

                var query = from a in db.Money
                            select a;
                if (DateCheckBox.Checked)
                {
                    query = from a in query
                            where a.Date >= FromDateTimePicker.Value.Date && a.Date <= ToDateTimePicker.Value.Date
                            select a;
                }
                if (CategoryCheckBox.Checked)
                {
                    query = from b in query
                            where b.Category.CategoryName == CategoryCB.Text
                            select b;
                }
                if (AimCheckBox.Checked)
                {
                    query = from c in query
                            where c.Aim.AimName == AimCB.Text
                            select c;
                }
                var fromAmount = double.Parse(FromAmountTB.Text);
                var toAmount = double.Parse(ToAmountTB.Text);
                if (AmountCheckBox.Checked)
                {
                    query = from d in query
                            where d.Amount >= fromAmount && d.Amount <=toAmount 
                            select d;
                }
                var result = query.ToList();
                PopulateSearchListView(result);
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchListView.Items.Count != 0)
            {
                ClearSearchListView();
            }
            Search();
        }
        public void LoadComboBoxes()
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
                this.CategoryCB.DataSource = categoryList;

                //Reload Aim ComboBox
                var aims = from a in db.Categories
                           from b in a.Aims
                           where a.CategoryName == CategoryCB.Text
                           select b.AimName;

                var aimslist = aims.ToList<string>();
                AimCB.DataSource = aimslist;
            }
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DateCheckBox.Checked)
            {
                FromDateTimePicker.Enabled = true;
                ToDateTimePicker.Enabled = true;
            }
            else
            {
                FromDateTimePicker.Enabled = false;
                ToDateTimePicker.Enabled = false;
            }
        }

        private void CategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoryCheckBox.Checked)
            {
                CategoryCB.Enabled = true;
            }
            else
            {
                CategoryCB.Enabled = false;
            }
        }

        private void AimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AimCheckBox.Checked)
            {
                AimCB.Enabled = true;
            }
            else
            {
                AimCB.Enabled = false;  
            }
        }

        private void AmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AmountCheckBox.Checked)
            {
                FromAmountTB.Enabled = true;
                ToAmountTB.Enabled = true;
            }
            else
            {
                FromAmountTB.Enabled = false;
                ToAmountTB.Enabled = false;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }
        private void ComboboxesAdjustements()
        {

            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CategoryCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.CategoryCB.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.AimCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.AimCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AimCB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void ValidateCategoryCombobox()
        {
            var existingCategoryValue = false;
            //if selected control is CategoryComboBox
            if (this.ActiveControl.Name == this.CategoryCB.Name)
            {
                //Search if entered value exists in combobox
                foreach (var category in CategoryCB.Items)
                {
                    if (category.ToString().Equals(CategoryCB.Text))
                    {
                        existingCategoryValue = true;
                    }
                }
                if (existingCategoryValue == false)
                {
                    MessageBox.Show("Моля въведете валидна категория");
                    CategoryCB.Text = String.Empty;
                }
            }
        }
        private void ValidateAimCombobox()
        {
            var existingAimValue = false;
            //if selected control is AimComboBox
            if (this.ActiveControl.Name == this.AimCB.Name)
            {
                foreach (var aim in AimCB.Items)
                {
                    if (aim.ToString().Equals(AimCB.Text))
                    {
                        existingAimValue = true;
                    }
                }
                if (existingAimValue == false)
                {
                    MessageBox.Show("Моля въведете валидна цел");
                    AimCB.Text = String.Empty;
                }
            }
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new DatabaseContext())
            {
                var aims = from a in db.Categories
                           from b in a.Aims
                           where a.CategoryName == CategoryCB.Text
                           select b.AimName;

                var aimslist = aims.ToList<string>();
                AimCB.DataSource = aimslist;
            }
        }
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateCategoryCombobox();
                ValidateAimCombobox();
                this.SelectNextControl((Control)sender, true, true, true, true);
                if (this.ActiveControl.Name == SearchBtn.Name)
                {
                    if (SearchListView.Items.Count != 0)
                    {
                        ClearSearchListView();
                    }
                    Search();
                }
            }

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
        }
    }
}
