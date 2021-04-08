using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public int GetAccountExist(string userName)
        {
            return int.Parse(DataProvider.Instance.ExecuteScalar("Select count(*) from Account where UserName = '" + userName + "'").ToString());
        }

        public bool InsertNewAccount(string name, string passWord, string personName, string address, string phoneNumber)
        {
            string query = string.Format("INSERT dbo.Account( UserName ,PassWord ,PersonName ,Address ,PhoneNumber) VALUES  ( N'{0}' , '{1}' , N'{2}' , N'{3}' , '{4}'  )", name, passWord, personName, address, phoneNumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Login(string userName, string passWord)
        {
            string query = String.Format("SELECT count(*) FROM dbo.Account WHERE UserName = N'{0}' AND PassWord = '{1}'", userName, passWord);

            int result = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            return result > 0;
        }

        public string GetDisplayNameByUserName(string userName)
        {
            string query = String.Format("SELECT PersonName FROM dbo.Account WHERE UserName = N'{0}'", userName);

            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
    }
}
