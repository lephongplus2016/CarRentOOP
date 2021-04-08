using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.DTO
{
    internal class Carmudi:Vehicle
    {
        public Carmudi(DataRow row)
        {
            this.CarCategory = row["CarCategory"].ToString();
            this.CarName = row["CarName"].ToString();
            this.CarNumber = row["CarNumber"].ToString();
            this.CarOrigin = row["CarOrigin"].ToString();
            this.CarPriceBuy = double.Parse(row["CarPriceBy"].ToString());
            this.CarStatus = (string)row["CarStatus"];
            this.Mileage = float.Parse(row["CarMileage"].ToString());
            this.CarPriceRent = double.Parse(row["CarPriceRent"].ToString());
        }

        public Carmudi(string carNumber, string carName, double carPriceBuy)
        {
            this.CarNumber = carNumber;
            this.CarName = carName;
            this.CarPriceBuy = carPriceBuy;
            this.CarOrigin = "";
            this.CarPriceRent = 0;
            this.Mileage = 1500;
        }

        public Carmudi(string carNumber, string carName, double carPriceBuy, string carOrigin)
        {
            this.CarNumber = carNumber;
            this.CarName = carName;
            this.CarPriceBuy = carPriceBuy;
            this.CarOrigin = carOrigin;
            this.CarPriceRent = 0;
            this.Mileage = 1500;
        }

        public Carmudi(string carNumber, string carName, double carPriceBuy, string carOrigin, double carPriceRent)
        {
            this.CarNumber = carNumber;
            this.CarName = carName;
            this.CarPriceBuy = carPriceBuy;
            this.CarOrigin = carOrigin;
            this.CarPriceRent = carPriceRent;
            this.Mileage = 1500;
        }
    }
}
