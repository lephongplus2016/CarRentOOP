using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.DTO;

namespace RentCar.DAO
{
    public class CustomerController
    {
        private static CustomerController instance;

        public static CustomerController Instance
        {
            get { if (instance == null) instance = new CustomerController(); return CustomerController.instance; }
            private set { CustomerController.instance = value; }
        }

        private CustomerController() { }

        public bool AddNewCustomerByCon1(int id, string name, int age)
        {
            string query = String.Format("INSERT dbo.Customer( CustomerId ,CustomerName ,CustomerAge) VALUES  ( {0} , N'{1}' , {2} )", id, name, age);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool AddNewCustomerByCon2(int id, string name, int age, string address)
        {
            string query = String.Format("INSERT dbo.Customer( CustomerId ,CustomerName ,CustomerAge, CustomerAddress) VALUES  ( {0} , N'{1}' , {2}, N'{3}' )", id, name, age, address);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool AddNewCustomerByCon3(int id, string name, int age, string address, string credit, string license, double deposit)
        {
            string query = String.Format("INSERT dbo.Customer( CustomerId ,CustomerName ,CustomerAge, CustomerAddress, CustomerCreditCard, CustomerCarLicense, CustomerDeposit) VALUES  ( {0} , N'{1}' , {2}, N'{3}' , '{4}', '{5}', {6} )", id, name, age, address, credit, license, deposit );
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool AddNewCustomerByCon4(int id, string name, int age, double deposit)
        {
            string query = String.Format("INSERT dbo.Customer( CustomerId ,CustomerName ,CustomerAge, CustomerDeposit) VALUES  ( {0} , N'{1}' , {2}, {3} )", id, name, age, deposit);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();

            string query = "SELECT * FROM dbo.Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

        public bool UpdateCustomer(string address, int age, string carLicense, string creditCard, float deposit, int id, string name)
        {
            string query = string.Format("UPDATE dbo.Customer SET CustomerName = N'{0}', CustomerAge = {1}, CustomerAddress = N'{2}', CustomerCreditCard = '{3}', CustomerCarLicense = '{4}', CustomerDeposit = {5} WHERE CustomerId = {6}", name, age, address, creditCard, carLicense, deposit, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable SearchCustomerByName(string name)
        {

            string query = string.Format("SELECT C.CustomerName AS 'Name', C.CustomerId AS 'ID', C.CustomerAge as 'Age', C.CustomerAddress AS 'Address', C.CustomerCreditCard AS 'CreditCard', C.CustomerCarLicense AS 'CarLicense', C.CustomerDeposit AS 'Deposit'  FROM dbo.Customer AS C WHERE dbo.fuConvertToUnsign1(C.CustomerName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteCustomer(int customerId)
        {
            int amountContract = ContractController.Instance.GetAmountContractByCustomerId(customerId);
            if (amountContract > 0)
            {
                return false;
            }
            string query = string.Format("DELETE dbo.Customer WHERE CustomerId = {0}", customerId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }

        public int GetAmountCustomerByID(int id)
        {
            string query = String.Format("SELECT count(*) FROM dbo.Customer WHERE CustomerId = {0}", id);
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }
    }
}
