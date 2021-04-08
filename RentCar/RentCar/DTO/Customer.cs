using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.DTO
{
    public class Customer
    {
        private int _iD;
        private string _name;
        private int _age;
        private string _address;
        private string _creditcard;
        private string _carLicense;
        private float _deposit;
        private List<Contract> _listContractOfThisCustomer = new List<Contract>();
        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Address { get => _address; set => _address = value; }
        public string Creditcard { get => _creditcard; set => _creditcard = value; }
        public string CarLicense { get => _carLicense; set => _carLicense = value; }
        public float Deposit { get => _deposit; set => _deposit = value; }
        public List<Contract> ListContractOfThisCustomer { get => _listContractOfThisCustomer; set => _listContractOfThisCustomer = value; }

        public Customer(DataRow row)
        {
            this.Address = row["CustomerAddress"].ToString();
            this.Age = (int)row["CustomerAge"];
            this.CarLicense = row["CustomerCarLicense"].ToString();
            this.Creditcard = row["CustomerCreditcard"].ToString();
            this.Deposit = float.Parse(row["CustomerDeposit"].ToString());
            this.ID = (int)row["CustomerId"];
            this.Name = row["CustomerName"].ToString();
        }
        public Customer(int _iD1, string _name1, int _age1)
        {
            this.ID = _iD1;
            this.Name = _name1;
            this.Age = _age1;
            this.Address = "Unknown";
            this.Creditcard = "Unknown";
            this.CarLicense = "Unknown";
            this.Deposit = 0;
        }

        public Customer(int _iD1, string _name1, int _age1, string _address1)
        {
            this.ID = _iD1;
            this.Name = _name1;
            this.Age = _age1;
            this.Address = _address1;
            this.Creditcard = "Unknown";
            this.CarLicense = "Unknown";
            this.Deposit = 0;
        }

        public Customer(int _iD1, string _name1, int _age1, string _address1, string _peridentification1, string _carLicense1, float _deposit1)
        {
            this.ID = _iD1;
            this.Name = _name1;
            this.Age = _age1;
            this.Address = _address1;
            this.Creditcard = _peridentification1;
            this.CarLicense = _carLicense1;
            this.Deposit = _deposit1;

        }

        public Customer(int _iD1, string _name1, int _age1, float _deposit1)
        {
            this.ID = _iD1;
            this.Name = _name1;
            this.Age = _age1;
            this.Address = "Unknown";
            this.Creditcard = "Unknown";
            this.CarLicense = "Unknown";
            this.Deposit = _deposit1;

        }
    }
}
