﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BLL
{
   public interface IBankAccount
    {
        public double deposit(decimal amount);
        public double withdrawal(double amount);
    }
}
