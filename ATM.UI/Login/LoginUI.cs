using ATM.BLL;
using ATM.UI.AccountRegistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.UI.Login
{
    public partial class LoginUI : Form
    {
        BankAccountMananger bankAccountMananger = new BankAccountMananger();
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string _accNumber = tct_accNum.Text;
            bankAccountMananger.findAccount(_accNumber);
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void btn_clickNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
