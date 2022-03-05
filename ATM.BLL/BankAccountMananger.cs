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
    public class BankAccountMananger: BankAccount,IBankAccountMananger
    {
        
        AccountRepository accountRepository = new AccountRepository();
        public static string accName;
        public static string accNo;
        public static long balance = 00;
        public static long pin;
        public static string accType;
        public static string branch;


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

        public void fundTransfer(string toAccName,string toAccNo, string toBranch,long amount,string fromAccNo,string fromAccName,string fromBranch,long pin)
        {
            if (toAccName !="" && toAccNo!="" && toBranch!=""&& amount>0)
            {
                long _balance = checkBalance(accNo, pin);
                if (_balance>amount)
                {
                    accountRepository.fundTransfer(toAccName, toAccNo, toBranch, amount, fromAccNo, fromAccName, fromBranch, pin);
                    throw new Exception("Successfully Transfered");
                }
                else
                {
                    throw new Exception("Amount too large than Balance..");
                }
               
            }
            else
            {
                throw new Exception("invalid input..");
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

            if (amount > 0 && pin > 0 && accNo != "")
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
                        accType = dr["AccType"].ToString();
                        accNo = dr["AccNo"].ToString();
                        pin = long.Parse(dr["PIN"].ToString());
                        balance =long.Parse(dr["Balance"].ToString());
                        pin =long.Parse(dr["PIN"].ToString());
                        branch =dr["Branch"].ToString();


                        
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
            if (checkingAccount != null)
            {
                if (checkingAccount.Image != null && checkingAccount.AccountNo != null && checkingAccount.AccountName != null)
                {
                    accountRepository.Add(checkingAccount);
                    throw new Exception("Successfully Submited.. " + "AccNo: " + checkingAccount.AccountNo + " PIN: " + checkingAccount.PIN);
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

        public virtual void withdraw(long amount, long pin, string accNo,string accType)
        {
            long _balance = checkBalance(accNo, pin);
            string _accType = "CheckingAccount";
            if (amount > 0 && pin > 0 && accNo != "")
            {
                if (accType.TrimEnd()== "CheckingAccount")
                {
                   
                    accountRepository.withdraw(amount, pin, accNo);
                    throw new Exception("Successfully withrawn...");
                }
                else
                {
                    if (_balance - amount>0)
                    {
                        accountRepository.withdraw(amount, pin, accNo);
                        throw new Exception("Successfully withrawn...");
                    }
                    else
                    {
                        throw new Exception("! Insufficient Balance...");
                    }
                }
            }
            else
            {
                throw new Exception("amount invalid..");
            }
        }
       
    }
}
