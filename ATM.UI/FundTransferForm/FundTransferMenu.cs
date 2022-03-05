using ATM.BLL;
using ATM.MODEL.Enum;
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

namespace ATM.UI.FundTransferForm
{
    
    public partial class FundTransferMenu : Form
    {
        BankAccountMananger bankAccountMananger = new BankAccountMananger();
        public FundTransferMenu()
        {
            InitializeComponent();
            comboBox_Brance.DataSource=Enum.GetValues(typeof( BranchEnum));
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

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            //from

            string _fromAccNo = BankAccountMananger.accNo;
            string _fromAccName = BankAccountMananger.accName;
            string _fromBranch = BankAccountMananger.branch;
            long _pin = BankAccountMananger.pin;
            //To
            string _toAccNo = txt_accNo.Text;
            string _toAccName=txt_accName.Text;
            string _toBranch=comboBox_Brance.SelectedItem.ToString();
            long _amount=long.Parse(txt_amount.Text);


            try
            {
                bankAccountMananger.fundTransfer(_toAccName, _toAccNo, _toBranch, _amount, _fromAccNo, _fromAccName, _fromBranch, _pin);
                clear();

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
            this.Hide();
            BalanceMenu balanceMenu=new BalanceMenu();
            balanceMenu.Show();


        }
        void clear()
        {
            txt_accName.Clear();
            txt_accNo.Clear();
            txt_amount.Clear();
        }
    }
}
