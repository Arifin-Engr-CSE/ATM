using ATM.BLL;
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

namespace ATM.UI.BalanceForm
{
    public partial class BalanceMenu : Form
    {
        BankAccountMananger bm = new BankAccountMananger();
        public BalanceMenu()
        {
            InitializeComponent();
            checkBalance();
            
        }
       void checkBalance()
        {
            string _accNo = BankAccountMananger.accNo;
            long _pin = BankAccountMananger.pin;
            long currentBalance= bm.checkBalance(_accNo,_pin);

            lbl_balance.Text = currentBalance + " " + "Tk";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }
    }
}
