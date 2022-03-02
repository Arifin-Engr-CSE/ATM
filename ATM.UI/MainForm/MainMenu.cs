using ATM.UI.BalanceForm;
using ATM.UI.DepositForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.UI.MainForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_checkBalance_Click(object sender, EventArgs e)
        {
            BalanceMenu balanceMenu = new BalanceMenu();
            this.Hide();
            balanceMenu.Show();
        }

        private void btn_cashDeposit_Click(object sender, EventArgs e)
        {
            DepositMenu depositMenu = new DepositMenu();
            this.Hide();
            depositMenu.Show();
        }
    }
}
