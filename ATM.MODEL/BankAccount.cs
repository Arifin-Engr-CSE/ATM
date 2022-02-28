using ATM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.MODEL
{
   public class BankAccount: IBankAccount
    {
        public BankAccount(string accName,string acc_No, string accType,long pin,string gender,long nid,string address,string email,string phoneNo,string branch,DateTime date,byte[] image)
        {
            this.AccountName = accName;
            this.AccountName = acc_No;
            this.AccountType = accType;
            this.PIN = pin;
            this.Gender = gender;
            this.NID = nid;
            this.Email = email;
            this.PhoneNO = phoneNo;
            this.Address = address;
            this.Branch = branch;
            this.OpenDate = date;
            this.Image = image;
        }
        public BankAccount()
        {
            this.Balance = 0.00;
        }
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public long PIN { get; set; }
        public string Gender { get; set; }
        public long NID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNO { get; set; }
        public string Branch { get; set; }
        public string AccountType { get; set; }
        public DateTime OpenDate { get; set; }
        public byte[] Image { get; set; }
        public double Balance { get; set; }

        public double deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public double withdrawal(double amount)
        {
            throw new NotImplementedException();
        }

        
    }

}
