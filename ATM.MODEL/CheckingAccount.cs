using ATM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.MODEL
{
   public class CheckingAccount: BankAccount
    {
        public double ServiceCharge { get; set; }

      
    }
}
