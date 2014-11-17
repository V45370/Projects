using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoneyV2._0.Controllers;
using MoneyV2._0.Models;

namespace MoneyV2._0
{
    public partial class CategoryForm : Form
    {
        public CategoryForm(MoneyForm parent)
        {
            
            InitializeComponent();
            
            this.parent = parent;
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveChangesAndClose();
            }

        }

        private void SaveChangesAndClose()
        {
            if (IncomeRB.Checked)
	        {
		        parent.isNewMoneyCategoryIncome=true;
	        }
            else
            {
                parent.isNewMoneyCategoryIncome = false;
            }            
            this.Close();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            SaveChangesAndClose();
        }
    }
}
