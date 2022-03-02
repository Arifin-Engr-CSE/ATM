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
        public static long balance = 00;
        public static long pin;
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
        public long checkBalance(string accNo,long pin)
        {
            long _balance=00;
            if (pin > 0 && accNo != "")
            {
                DataTable dt = new DataTable();

               dt= accountRepository.checkBalance( accNo,pin);
                foreach (DataRow dr in dt.Rows)
                {
                    _balance = long.Parse(dr["Balance"].ToString());
                }
            }
            return _balance;
        }
        public void deposit(long amount, long pin, string accNo)
        {
            
            if (amount>0 && pin > 0 && accNo != "")
            {
                accountRepository.deposit(amount, pin, accNo);
                throw new Exception("Depsited Successfully...");
            }
            else
            {
                throw new Exception("operation filed..try again");
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
                        //SAV179                                                                                              
                        accName = dr["AccName"].ToString();
                        accNo = dr["AccNo"].ToString();
                        pin = long.Parse(dr["PIN"].ToString());
                        balance =long.Parse(dr["Balance"].ToString());
                        pin =long.Parse(dr["PIN"].ToString());
                        
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
