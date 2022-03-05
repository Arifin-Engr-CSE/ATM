using ATM.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class AccountRepository : IAccountRepository
    {
        public static string connectionString = "data source=.;database=Test_DB_01;integrated security=true";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        public void Add(SavingAccount savingAccount)
        {
            try
            {
                
                string query = "sp_CreateAccount";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accName", SqlDbType.NVarChar).Value = savingAccount.AccountName;
                sqlCommand.Parameters.AddWithValue("@accNo", SqlDbType.NVarChar).Value = savingAccount.AccountNo;
                sqlCommand.Parameters.AddWithValue("@accType", SqlDbType.NVarChar).Value = savingAccount.AccountType;
                sqlCommand.Parameters.AddWithValue("@PIN", SqlDbType.BigInt).Value = savingAccount.PIN;
                sqlCommand.Parameters.AddWithValue("@gender", SqlDbType.NVarChar).Value = savingAccount.Gender;
                sqlCommand.Parameters.AddWithValue("@date", SqlDbType.Date).Value = savingAccount.OpenDate;
                sqlCommand.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = savingAccount.Address;
                sqlCommand.Parameters.AddWithValue("@nid", SqlDbType.BigInt).Value = savingAccount.NID;
                sqlCommand.Parameters.AddWithValue("@phoneNo", SqlDbType.NVarChar).Value = savingAccount.PhoneNO;
                sqlCommand.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = savingAccount.Email;
                sqlCommand.Parameters.AddWithValue("@branch", SqlDbType.NVarChar).Value = savingAccount.Branch;
                sqlCommand.Parameters.AddWithValue("@image", SqlDbType.Image).Value = savingAccount.Image;
                sqlConnection.Open();
                bool row = sqlCommand.ExecuteNonQuery() > 0;
                
                if (row==true)
                {
                    throw new Exception("Successfully Submited.... " + "AccNo: " + savingAccount.AccountNo + " PIN: " + savingAccount.PIN);
                }
                else
                {
                    throw new Exception("Failed");
                }
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void fundTransfer(string toAccName, string toAccNo, string toBranch, long amount, string fromAccNo, string fromAccName, string fromBranch, long pin)
        {
            string query = "sp_fundTransfer";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@amount", SqlDbType.BigInt).Value = amount;

            sqlCommand.Parameters.AddWithValue("@fromAccNo", SqlDbType.NVarChar).Value = fromAccNo;
            sqlCommand.Parameters.AddWithValue("@fromAccName", SqlDbType.NVarChar).Value = fromAccName;
            sqlCommand.Parameters.AddWithValue("@fromBranch", SqlDbType.NVarChar).Value = fromBranch;
            sqlCommand.Parameters.AddWithValue("@fromPin", SqlDbType.BigInt).Value = pin;

            sqlCommand.Parameters.AddWithValue("@toAccNo", SqlDbType.NVarChar).Value = toAccNo;
            sqlCommand.Parameters.AddWithValue("@toAccName", SqlDbType.NVarChar).Value = toAccName;
            sqlCommand.Parameters.AddWithValue("@toBranch", SqlDbType.NVarChar).Value = toBranch;
            

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable checkBalance(string accNo, long pin)
        {
            string query = "sp_checkBalance";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNumber", SqlDbType.NVarChar).Value = accNo;
            cmd.Parameters.AddWithValue("@pin", SqlDbType.BigInt).Value = pin;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void deposit(long amount,long pin,string accNo)
        {
            string query = "sp_deposit";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@amount", SqlDbType.BigInt).Value = amount;
            sqlCommand.Parameters.AddWithValue("@pin", SqlDbType.BigInt).Value = pin;
            sqlCommand.Parameters.AddWithValue("@accNo", SqlDbType.NVarChar).Value = accNo;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable login(long pin,string accNo)
        {
            string query = "sp_login";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pin", SqlDbType.BigInt).Value = pin;
            cmd.Parameters.AddWithValue("@accNo", SqlDbType.NVarChar).Value = accNo;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

            
        }

        public DataTable findAccount(string accNumber)
        {
            
                string query = "sp_findAccount";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNumber", SqlDbType.NVarChar).Value = accNumber;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                 return dt;
        }
       
        public void Add(CheckingAccount checkingAccount)
        {
            try
            {

                string query = "sp_CreateAccount";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@accName", SqlDbType.NVarChar).Value = checkingAccount.AccountName;
                sqlCommand.Parameters.AddWithValue("@accNo", SqlDbType.NVarChar).Value = checkingAccount.AccountNo;
                sqlCommand.Parameters.AddWithValue("@accType", SqlDbType.NVarChar).Value = checkingAccount.AccountType;
                sqlCommand.Parameters.AddWithValue("@PIN", SqlDbType.BigInt).Value = checkingAccount.PIN;
                sqlCommand.Parameters.AddWithValue("@gender", SqlDbType.NVarChar).Value = checkingAccount.Gender;
                sqlCommand.Parameters.AddWithValue("@date", SqlDbType.Date).Value = checkingAccount.OpenDate;
                sqlCommand.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = checkingAccount.Address;
                sqlCommand.Parameters.AddWithValue("@nid", SqlDbType.BigInt).Value = checkingAccount.NID;
                sqlCommand.Parameters.AddWithValue("@phoneNo", SqlDbType.NVarChar).Value = checkingAccount.PhoneNO;
                sqlCommand.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = checkingAccount.Email;
                sqlCommand.Parameters.AddWithValue("@branch", SqlDbType.NVarChar).Value = checkingAccount.Branch;
                sqlCommand.Parameters.AddWithValue("@image", SqlDbType.Image).Value = checkingAccount.Image;
                sqlConnection.Open();
                bool row = sqlCommand.ExecuteNonQuery() > 0;

                if (row == true)
                {
                    throw new Exception("Successfully Submited.... " + "AccNo: " + checkingAccount.AccountNo + " PIN: " + checkingAccount.PIN);
                }
                else
                {
                    throw new Exception("Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void withdraw(long amount, long pin, string accNo)
        {
            string query = "sp_withdraw";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@amount", SqlDbType.BigInt).Value = amount;
            sqlCommand.Parameters.AddWithValue("@pin", SqlDbType.BigInt).Value = pin;
            sqlCommand.Parameters.AddWithValue("@accNo", SqlDbType.NVarChar).Value = accNo;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
