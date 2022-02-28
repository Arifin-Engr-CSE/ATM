using ATM.DAL;
using ATM.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM.BLL
{
    public class BankAccountMananger
    {
        AccountRepository accountRepository = new AccountRepository();
        public static string accName;
        //SavingAccount
        public void Add(SavingAccount savingAccount)
        {
            if (savingAccount !=null)
            {
                if (savingAccount.Image !=null && savingAccount.AccountNo !=null && savingAccount.AccountName!=null)
                {
                    accountRepository.Add(savingAccount);
                    throw new Exception("Successfully Submited.. "+"AccNo: " + savingAccount.AccountNo + " PIN: " + savingAccount.PIN);
                }
                else
                {
                    throw new Exception("Some filed empty....");
                }
            }
            else
            {
                throw new Exception("invalid input");
            }
            
        }

        public void findAccount(string accNumber)
        {
           
            if (accNumber!=null)
            {
             accName=   accountRepository.findAccount(accNumber);
            }
            
        }

        //checking Account
        public void Add(CheckingAccount checkingAccount)
        {
            throw new NotImplementedException();
        }
    }
}
