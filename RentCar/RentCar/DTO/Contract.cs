using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.DTO
{
    public class Contract
    {
        private string _id;
        private string _carNumber;
        private int _customerId;
        private DateTime dateStart;
        private DateTime dateEnd;
        private string content;
        private double _cost;
        private string status;

        internal Contract(string id, string carNumber, int customerId, DateTime dateEnd, string content)
        {
            this.Id = id;
            this.CarNumber = carNumber;
            this.CustomerId = customerId;
            this.Cost = 0;
            this.DateEnd = dateEnd;
            this.Content = content;
        }

        internal Contract(string id, string carNumber, int customerId, DateTime dateStart, DateTime dateEnd, string content)
        {
            this.Id = id;
            this.CarNumber = carNumber;
            this.CustomerId = customerId;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.Cost = 0;
            this.Content = content;
        }

        internal Contract(string id, string carNumber, int customerId, double cost, DateTime dateEnd, string content)
        {
            this.Id = id;
            this.CarNumber = carNumber;
            this.CustomerId = customerId;
            this.Cost = cost;
            this.DateEnd = dateEnd;
            this.Content = content;
        }

        internal Contract(string id, string carNumber, int customerId, double cost, DateTime dateStart, DateTime dateEnd, string content)
        {
            this.Id = id;
            this.CarNumber = carNumber;
            this.CustomerId = customerId;
            this.Cost = cost;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.Content = content;
        }

        internal Contract(DataRow row)
        {
            this.Id = row["ContractId"].ToString();
            this.CarNumber = row["CarNumber"].ToString();
            this.CustomerId = int.Parse(row["CustomerId"].ToString());
            this.Cost = float.Parse(row["ContractCost"].ToString());
            this.DateStart = DateTime.Parse(row["DateStart"].ToString());
            this.DateEnd = DateTime.Parse(row["DateEnd"].ToString());
            this.Content = row["ContractContent"].ToString();
            this.Status = row["ContractStatus"].ToString();
        }


        public double Cost { get => _cost; set => _cost = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        public string Id { get => _id; set => _id = value; }
        public string CarNumber { get => _carNumber; set => _carNumber = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string Content { get => content; set => content = value; }
        public string Status { get => status; set => status = value; }
    }
}
