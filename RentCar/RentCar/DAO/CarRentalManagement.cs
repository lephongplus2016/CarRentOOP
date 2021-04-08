using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.DAO;
using RentCar.DTO;

namespace RentCar
{
    public class CarRentalManagement
    {
        private List<Vehicle> _listCar = new List<Vehicle>();
        private List<Vehicle> _listRentCar = new List<Vehicle>();
        private static CarRentalManagement instance;

        public static CarRentalManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarRentalManagement();
                }
                return instance;
            }
            private set { instance = value; }
        }

        internal List<Vehicle> ListCar { get => _listCar; set => _listCar = value; }

        private CarRentalManagement() { }

        public bool AddNewCarByCon1(string carNum, string carName, double carPriceBuy, string carCategory)
        {
            string query = String.Format("INSERT dbo.Vehicle( CarNumber ,CarName ,CarPriceBy ,CarCategory) VALUES  ( '{0}' ,  '{1}' , {2} , '{3}'  )", carNum, carName, carPriceBuy, carCategory);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool AddNewCarByCon2(string carNum, string carName, double carPriceBuy, string carOrigin, string carCategory)
        {
            string query = String.Format("INSERT dbo.Vehicle( CarNumber ,CarName ,CarOrigin ,CarPriceBy ,CarCategory) VALUES  ( '{0}' ,  '{1}' ,  N'{2}' , {3} , '{4}'  )", carNum, carName, carOrigin, carPriceBuy, carCategory);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool AddNewCarByCon3(string carNum, string carName, double carPriceBuy, double carRentPrice,string carOrigin, string carCategory)
        {
            string query = String.Format("INSERT dbo.Vehicle( CarNumber ,CarName ,CarOrigin ,CarPriceBy ,CarPriceRent ,CarCategory) VALUES  ( '{0}' ,  '{1}' ,  N'{2}' , {3} , {4} , '{5}'  )", carNum, carName, carOrigin, carPriceBuy, carRentPrice ,carCategory);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<Vehicle> GetListCar()
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = "SELECT * FROM dbo.Vehicle";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if(item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCarAvailable()
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = "SELECT * FROM dbo.Vehicle where CarStatus = 'Available'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(string category)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle where CarCategory = '{0}'", category);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(string category, float min, float max)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE CarCategory = '{0}' and CarPriceRent > {1} AND CarPriceRent < {2}", category, min, max);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(string category, float min, float max, string name)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE CarCategory = '{0}' and CarPriceRent > {1} AND CarPriceRent < {2} and dbo.fuConvertToUnsign1(CarName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{3}') + '%'", category, min, max, name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(string category, string name)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE CarCategory = '{0}' and dbo.fuConvertToUnsign1(CarName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%'", category, name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(float min, float max, string name)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE CarPriceRent > {0} AND CarPriceRent < {1} and dbo.fuConvertToUnsign1(CarName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{2}') + '%'", min, max, name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCarName(string name)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE dbo.fuConvertToUnsign1(CarName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public List<Vehicle> GetListCar(float min, float max)
        {
            List<Vehicle> list = new List<Vehicle>();

            string query = String.Format("SELECT * FROM dbo.Vehicle WHERE CarPriceRent > {0} AND CarPriceRent < {1} ",  min, max);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public bool UpdateVehicle(string num, string name, string origin, float price, string status, float rentPrice, float mileage, string category)
        {
            string query = string.Format("UPDATE dbo.Vehicle SET CarName = '{0}', CarOrigin = '{1}', CarPriceBy = {2}, CarStatus = '{3}', CarPriceRent = {4}, CarMileage = {5}, CarCategory = '{6}' WHERE CarNumber = '{7}'", name, origin, price, status, rentPrice, mileage, category, num);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteVehicle(string carNum)
        {
            int amountContract = ContractController.Instance.GetAmountContractByCarNumber(carNum);
            if (amountContract > 0)
            {
                return false;
            }
            string query = string.Format("DELETE dbo.Vehicle WHERE CarNumber = '{0}' ", carNum);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }

        public DataTable SearchVehicleByName(string name)
        {

            string query = string.Format("SELECT V.CarNumber AS 'CarNumber', V.CarName AS 'CarName', V.CarOrigin as 'CarOrigin', V.CarPriceBy AS 'CarPriceBuy', V.CarStatus AS 'CarStatus', V.CarPriceRent AS 'CarPriceRent', V.CarMileage AS 'Mileage', V.CarCategory AS 'CarCategory'  FROM dbo.Vehicle AS V WHERE dbo.fuConvertToUnsign1(V.CarName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Vehicle> GetListCarByCategory(int category)
        {
            List<Vehicle> list = new List<Vehicle>();

            string categoryStr = "";
            switch (category)
            {
                case 1:
                    categoryStr = "Vinfast";
                    break;
                case 2:
                    categoryStr = "Ford";
                    break;
                case 3:
                    categoryStr = "Carmudi";
                    break;
                default:
                    break;
            }

            string query = "SELECT * FROM dbo.Vehicle where CarCategory = '" + categoryStr + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                if (item["CarCategory"].ToString() == "Carmudi")
                {
                    Carmudi carmudi = new Carmudi(item);
                    list.Add(carmudi);
                }
                if (item["CarCategory"].ToString() == "Vinfast")
                {
                    Vinfast vinfast = new Vinfast(item);
                    list.Add(vinfast);
                }
                if (item["CarCategory"].ToString() == "Ford")
                {
                    Ford ford = new Ford(item);
                    list.Add(ford);
                }
            }
            return list;
        }

        public int GetAmountVehicleByNumber(string carNum)
        {
            string query = String.Format("SELECT COUNT(*) FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public DataTable GetCategory()
        {
            string query = "SELECT DISTINCT CarCategory FROM dbo.Vehicle";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
