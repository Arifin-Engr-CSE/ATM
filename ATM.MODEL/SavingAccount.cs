using ATM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.MODEL
{
  public  class SavingAccount:BankAccount
    {
        public SavingAccount()
        {
            this.InterestAmont = 0;
        }
        public double InterestAmont { get; set; }

        
    }
}
