using ATM.DAL;
using ATM.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM.BLL
{
    public class BankAccountMananger
    {
        AccountRepository accountRepository = new AccountRepository();
        public static string accName;
        public static string accNo;
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

        public void login(long pin,string accNo)
        {
            if (pin>0 && accNo!="")
            {
                DataTable dataTable = new DataTable();
                dataTable= accountRepository.login(pin,accNo);

                if (dataTable.Rows.Count==1)
                {
                    return;
                }
                else
                {
                    throw new Exception("PIN is incorrect");
                }
            }
            else
            {
                throw new Exception("Emty Input");
            }

        }

        public void findAccount(string accNumber)
        {
            DataTable data = new DataTable();
                if (accNumber != "")
                {
                 data = accountRepository.findAccount(accNumber);
                if (data.Rows.Count!=0)
                {
                    foreach (DataRow dr in data.Rows)
                    {
                        accName = dr["AccName"].ToString();
                        accNo = dr["AccNo"].ToString();
                    }
                }
                else
                {
                    throw new Exception("Account Not Found");
                }
                }
            else
            {
                throw new Exception("Emty Input");
            }
            
            
           
            
        }

        //checking Account
        public void Add(CheckingAccount checkingAccount)
        {
            throw new NotImplementedException();
        }
    }
}
