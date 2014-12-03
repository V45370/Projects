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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                if(IsBankCB.Checked == true)
                {
                    parent.isNewCategoryForBank = true;
                }
                parent.isNewMoneyCategoryIncome = false;
            }
            parent.isNewCategorySaved = true;
            this.Close();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            SaveChangesAndClose();
        }

        private void IsBankCB_CheckedChanged(object sender, EventArgs e)
        {
            if (IsBankCB.Checked==true)
            {
                OutcomeRB.Checked = true;
            }
        }

        private void IncomeRB_CheckedChanged(object sender, EventArgs e)
        {
            //Bank checkbox is only for outcomes
            if(IncomeRB.Checked == true)
            {
                IsBankCB.Enabled = false;
                if (IsBankCB.Checked)
                {
                    IsBankCB.Checked = false;
                }
            }
            
        }

        private void OutcomeRB_CheckedChanged(object sender, EventArgs e)
        {    
             IsBankCB.Enabled = true;
        }
    }
}
