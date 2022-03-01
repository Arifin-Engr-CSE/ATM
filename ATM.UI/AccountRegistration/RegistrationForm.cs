using ATM.BLL;
using ATM.MODEL;
using ATM.MODEL.Enum;
using ATM.UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM.UI.AccountRegistration
{
    public partial class RegistrationForm : Form
    {
        BankAccountMananger bankAccountMananger = new BankAccountMananger();
        string _imageLocation = "";
        public RegistrationForm()
        {
            InitializeComponent();
            
            combox_accType.DataSource = Enum.GetValues(typeof(AccTypeEnum));
            combox_branch.DataSource = Enum.GetValues(typeof(BranchEnum));
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SavingAccount savingAccount = new SavingAccount();
            CheckingAccount checkingAccount = new CheckingAccount();
            StudentAccount studentAccount = new StudentAccount();
            int _AccNumber = 101;
            
            Random rnd = new Random();
            _AccNumber = rnd.Next(101, 200);


            FileStream fileStream = new FileStream(_imageLocation,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] _img = binaryReader.ReadBytes((int)fileStream.Length);

            try
            {
                if (combox_accType.SelectedItem.ToString() == "SavingAccount")
                {
                    string _savingAccTile = "SAV";
                    savingAccount.AccountName = txt_accName.Text;
                    savingAccount.AccountNo = _savingAccTile + _AccNumber;
                    savingAccount.AccountType = combox_accType.SelectedItem.ToString();
                    savingAccount.PIN = long.Parse(txt_PIN.Text);

                    if (checkBox_male.Checked == true)
                    {
                        savingAccount.Gender = "Male";
                    }
                    else if (checkBox_female.Checked == true)
                    {
                        savingAccount.Gender = "Female";
                    }
                    savingAccount.OpenDate = dateTimePicker.Value.Date;
                    savingAccount.Address = txt_address.Text;
                    savingAccount.NID = long.Parse(txt_NID.Text);
                    savingAccount.Email = txt_email.Text;
                    savingAccount.PhoneNO = txt_PhonNo.Text;
                    savingAccount.Branch = combox_branch.SelectedItem.ToString();
                    savingAccount.Image = _img;
                    bankAccountMananger.Add(savingAccount);
                    

                }
                else if (combox_accType.SelectedItem.ToString() == "CheckingAccount")
                {
                    string _checkingAccTile = "CHK";
                    checkingAccount.AccountName = txt_accName.Text;
                    checkingAccount.AccountNo = _checkingAccTile + _AccNumber;
                    checkingAccount.AccountType = combox_accType.SelectedItem.ToString();
                    checkingAccount.PIN = Convert.ToInt32(txt_PIN.Text);

                    if (checkBox_male.Checked == true)
                    {
                        checkingAccount.Gender = "Male";
                    }
                    else if (checkBox_female.Checked == true)
                    {
                        checkingAccount.Gender = "Female";
                    }
                    checkingAccount.OpenDate = dateTimePicker.Value.Date;
                    checkingAccount.Address = txt_address.Text;
                    checkingAccount.NID = Convert.ToInt32(txt_NID.Text);
                    checkingAccount.Email = txt_email.Text;
                    checkingAccount.PhoneNO = txt_PhonNo.Text;
                    checkingAccount.Branch = combox_branch.SelectedItem.ToString();
                    checkingAccount.Image = _img;

                    bankAccountMananger.Add(checkingAccount);
                }


              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.Show();





        }

        //choose Picture
        private void btn_choose_Image_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter= "Files|*.jpg;*.jpeg;*.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                _imageLocation = openFileDialog.FileName;
                pictureBox_acccHolder.ImageLocation = _imageLocation;
            }
        }



        

    }
}
