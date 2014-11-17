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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            PasswordTB.PasswordChar = '*';
        }

        private void EnterMoneyMenuBtn_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenMenu();
            }

        }
        private void OpenMenu()
        {
            if (PasswordTB.Text == "sh4488")
            {
                var menuForm = new Menu();
                WindowState = FormWindowState.Minimized;
                menuForm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Грешен вход");
            }
        }
    }
}
