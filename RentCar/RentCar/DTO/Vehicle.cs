using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DTO
{
    public abstract class Vehicle
    {
        private string _carNumber;
        private string _carName;
        private string _carOrigin;
        private double _carPriceBuy;
        private string _carStatus;
        private double _carPriceRent;
        private string carCategory;
        private float mileage;
        private string num;
        public string CarNumber { get => _carNumber; set => _carNumber = value; }
        public string CarName { get => _carName; set => _carName = value; }
        public string CarOrigin { get => _carOrigin; set => _carOrigin = value; }
        public double CarPriceBuy { get => _carPriceBuy; set => _carPriceBuy = value; }
        public string CarStatus { get => _carStatus; set => _carStatus = value; }
        public double CarPriceRent { get => _carPriceRent; set => _carPriceRent = value; }
        public float Mileage { get => mileage; set => mileage = value; }
        public string CarCategory { get => carCategory; set => carCategory = value; }
        public string Num { get => num; set => num = value; }
    }
}
