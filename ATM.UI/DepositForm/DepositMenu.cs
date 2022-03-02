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

namespace ATM.UI.DepositForm
{
    public partial class DepositMenu : Form
    {
        BankAccountMananger bankAccountMananger = new BankAccountMananger();
        public DepositMenu()
        {
            InitializeComponent();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            long _amount =long.Parse( txt_amount.Text);
            long _pin = BankAccountMananger.pin;
            string _accNo = BankAccountMananger.accNo;
            try
            {
                bankAccountMananger.deposit(_amount, _pin, _accNo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cancel();


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }
        void cancel()
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }
    }
}
