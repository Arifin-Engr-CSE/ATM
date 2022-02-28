using ATM.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
  public  interface IAccountRepository
    {
        public void ExecuteQuery(string query);
        public void Add(SavingAccount savingAccount);
        public DataTable getAll(string query);
        public void Add(CheckingAccount checkingAccount);

    }
}
