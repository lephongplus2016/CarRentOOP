using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DAO
{
    public class ServiceController
    {
        private static ServiceController instance;

        public static ServiceController Instance
        {
            get { if (instance == null) instance = new ServiceController(); return ServiceController.instance; }
            private set { ServiceController.instance = value; }
        }

        private ServiceController() { }

        public bool ServiceEngine(int category, string carNum, float mileage)
        {
            switch (category)
            {
                case 1:
                    string queryGetMileage1 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage1 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage1).ToString());
                    string queryGetAmount1 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 1", carNum);
                    int amount1 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount1).ToString());
                    if ((int)mileage1 / 1000 <= amount1)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  1 ,  '{0}', {1}  , N'Vinfast Car - Repairing and replacing some engines'  )", carNum, mileage1 );
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 2:
                    string queryGetMileage2 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage2 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage2).ToString());
                    string queryGetAmount2 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 1", carNum);
                    int amount2 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount2).ToString());
                    if ((int)mileage2 / 1200 <= amount2)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  1 ,  '{0}', {1}  , N'Ford Car - Repairing and replacing some engines'  )", carNum, mileage2);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 3:
                    string queryGetMileage3 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage3 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage3).ToString());
                    string queryGetAmount3 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 1", carNum);
                    int amount3 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount3).ToString());
                    if ((int)mileage3 / 1400 <= amount3)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  1 ,  '{0}', {1}  , N'Carmudi Car - Repairing and replacing some engines'  )", carNum, mileage3);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 0:
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool ServiceTransmission(int category, string carNum, float mileage)
        {
            switch (category)
            {
                case 1:
                    string queryGetMileage1 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage1 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage1).ToString());
                    string queryGetAmount1 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 2", carNum);
                    int amount1 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount1).ToString());
                    if ((int)mileage1 / 2000 <= amount1)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  2 ,  '{0}', {1}  , N'Vinfast Car - Repair and upgrade gearbox'  )", carNum, mileage1);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 2:
                    string queryGetMileage2 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage2 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage2).ToString());
                    string queryGetAmount2 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 2", carNum);
                    int amount2 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount2).ToString());
                    if ((int)mileage2 / 2200 <= amount2)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  2 ,  '{0}', {1}  , N'Ford Car - Repair and upgrade gearbox'  )", carNum, mileage2);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 3:
                    string queryGetMileage3 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage3 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage3).ToString());
                    string queryGetAmount3 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 2", carNum);
                    int amount3 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount3).ToString());
                    if ((int)mileage3 / 2400 <= amount3)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  2 ,  '{0}', {1}  , N'Carmudi Car - Repair and upgrade gearbox'  )", carNum, mileage3);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 0:
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool ServiceTires(int category, string carNum, float mileage)
        {
            switch (category)
            {
                case 1:
                    string queryGetMileage1 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage1 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage1).ToString());
                    string queryGetAmount1 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 3", carNum);
                    int amount1 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount1).ToString());
                    if ((int)mileage1 / 3000 <= amount1)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  3 ,  '{0}', {1}  , N'Vinfast Car - Tire repair and upgrade'  )", carNum, mileage1);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 2:
                    string queryGetMileage2 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage2 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage2).ToString());
                    string queryGetAmount2 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 3", carNum);
                    int amount2 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount2).ToString());
                    if ((int)mileage2 / 3200 <= amount2)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  3 ,  '{0}', {1}  , N'Ford Car - Tire repair and upgrade'  )", carNum, mileage2);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 3:
                    string queryGetMileage3 = string.Format("SELECT CarMileage FROM dbo.Vehicle WHERE CarNumber = '{0}'", carNum);
                    float mileage3 = float.Parse(DataProvider.Instance.ExecuteScalar(queryGetMileage3).ToString());
                    string queryGetAmount3 = string.Format("SELECT COUNT(*) FROM dbo.ServiceHistory WHERE CarID = '{0}' and ServiceID = 3", carNum);
                    int amount3 = int.Parse(DataProvider.Instance.ExecuteScalar(queryGetAmount3).ToString());
                    if ((int)mileage3 / 3400 <= amount3)
                    {
                        return false;
                    }
                    else
                    {
                        string query = String.Format("INSERT dbo.ServiceHistory( ServiceID ,CarID, Mileage ,Content) VALUES  (  3 ,  '{0}', {1}  , N'Carmudi Car - Tire repair and upgrade'  )", carNum, mileage3);
                        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
                    }
                case 0:
                    break;
                default:
                    break;
            }
            return true;
        }

        public DataTable GetHistoryByCarNumber(string carNum)
        {
            string query = string.Format("SELECT SH.ID AS 'ID', S.ServiceCategory AS 'Service Category', SH.DateService AS 'Service Date', SH.Mileage as 'Mileage', SH.Content AS 'Content' FROM dbo.ServiceHistory AS SH, dbo.Service AS S WHERE SH.ServiceID = S.ServiceID AND SH.CarID = '{0}' ", carNum);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // return list history
        public List<ServiceHistory> GetHistoryLisOfThisCartByCarNumber(string carNum)
        {
            List<ServiceHistory> listRecordToJson = new List<ServiceHistory>();
            string query = string.Format("SELECT * FROM DBO.ServiceHistory WHERE CarID = '{0}'", carNum);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ServiceHistory servicehistory1 = new ServiceHistory(item);
                listRecordToJson.Add(servicehistory1);
            }
            return listRecordToJson;
        }
        //return just one json report
        public ServiceHistory GetServiceHistorToJsonShowMess()
        {
            ServiceHistory sh1;
            string query = string.Format("SELECT TOP 1 * FROM DBO.ServiceHistory ORDER BY ID DESC");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            sh1 = new ServiceHistory(data.Rows[0]);
            return sh1;

        }

    }
}
