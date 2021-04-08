using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    public class ServiceHistory
    {
        private int iD;
        private int serviceID;
        private string carID;
        private DateTime dateService;
        private float mileage;
        private string content;

        public int ID { get => iD; set => iD = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string CarID { get => carID; set => carID = value; }
        public DateTime DateService { get => dateService; set => dateService = value; }
        public string Content { get => content; set => content = value; }
        public float Mileage { get => mileage; set => mileage = value; }

        public ServiceHistory(DataRow row)
        {
            this.CarID = row["CarID"].ToString();
            this.ServiceID = int.Parse(row["ServiceID"].ToString());
            this.ID = int.Parse(row["ID"].ToString());
            this.DateService = DateTime.Parse(row["DateService"].ToString());
            this.content = row["Content"].ToString();
            this.Mileage = float.Parse(row["Mileage"].ToString());
        }
        public static float operator -(ServiceHistory firstService, ServiceHistory secondService)
        {
            return secondService.Mileage - firstService.Mileage;
        }

        public static int operator <(ServiceHistory firstService, ServiceHistory secondService)
        {
            if(firstService.DateService < secondService.DateService)
            {
                return 1;
            }
            else if (firstService.DateService > secondService.DateService)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static int operator >(ServiceHistory firstService, ServiceHistory secondService)
        {
            if (firstService.DateService < secondService.DateService)
            {
                return -1;
            }
            else if (firstService.DateService > secondService.DateService)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
