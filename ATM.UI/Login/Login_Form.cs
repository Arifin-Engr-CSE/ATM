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

namespace ATM.UI.Login
{
    public partial class Login_Form : Form
    {
        BankAccountMananger bankAccountMananger = new BankAccountMananger();
        public Login_Form()
        {
            InitializeComponent();
            lbl_accName.Text = BankAccountMananger.accName;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
