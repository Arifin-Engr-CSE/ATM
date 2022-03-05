using ATM.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL
{
    public interface IBankAccountMananger
    {
        public void Add(SavingAccount savingAccount);
       
        public long checkBalance(string accNo, long pin);
        public void deposit(long amount, long pin, string accNo);
        public void login(long pin, string accNo);
        public void findAccount(string accNumber);
        public void Add(CheckingAccount checkingAccount);
    }
}
