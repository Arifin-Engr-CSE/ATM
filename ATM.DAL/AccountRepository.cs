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
        public static string connectionString = "data source=.;database=Test_DB_26;integrated security=true";
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
                    throw new Exception("Successfully Submited.. " + "AccNo: " + savingAccount.AccountNo + " PIN: " + savingAccount.PIN);
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
            throw new NotImplementedException();
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
