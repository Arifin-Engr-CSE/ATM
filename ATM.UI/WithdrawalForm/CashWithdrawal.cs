using ATM.BLL;
using ATM.MODEL;
using ATM.UI.BalanceForm;
using ATM.UI.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.UI.WithdrawalForm
{
    public partial class CashWithdrawal : Form
    {
        BankAccount bankAccount=new BankAccount();
        BankAccountMananger bankAccountMananger=new BankAccountMananger();
        public CashWithdrawal()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }
       void cancel()
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btn_withdrawal_Click(object sender, EventArgs e)
        {
            long _amount =long.Parse( txt_amount.Text);
            long _pin = BankAccountMananger.pin;
            string _accNo = BankAccountMananger.accNo;
            string _accType=BankAccountMananger.accType;
            try
            {
                bankAccountMananger.withdraw(_amount, _pin, _accNo, _accType);
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            txt_amount.Clear();
            this.Hide();
            BalanceMenu balanceMenu = new BalanceMenu();
            balanceMenu.Show();
        }
    }
}
