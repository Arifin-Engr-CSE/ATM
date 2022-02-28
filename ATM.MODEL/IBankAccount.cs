using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL
{
   public interface IBankAccount
    {
        public double deposit(double amount);
        public double withdrawal(double amount);
    }
}
