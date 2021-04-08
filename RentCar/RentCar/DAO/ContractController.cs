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
    public class ContractController
    {
        private static ContractController instance;

        public static ContractController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContractController();
                }
                return instance;
            }
            private set { instance = value; }
        }

        internal bool AddNewContractByCon1(string id, string carNumber, int customerId, DateTime dateEnd, string content)
        {
            string query = String.Format("INSERT dbo.Contract( ContractId ,CarNumber ,CustomerId ,DateEnd ,ContractContent) VALUES  ( '{0}' , '{1}' , {2} , '{3}' , N'{4}'  )", id, carNumber, customerId, dateEnd, content);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        internal bool AddNewContractByCon2(string id, string carNumber, int customerId, DateTime dateStart, DateTime dateEnd, string content)
        {
            string query = String.Format("INSERT dbo.Contract( ContractId ,CarNumber ,CustomerId ,DateStart ,DateEnd ,ContractContent) VALUES  ( '{0}' , '{1}' , {2} , '{3}' , '{4}' , N'{5}'  )", id, carNumber, customerId, dateStart, dateEnd, content);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        internal bool AddNewContractByCon3(string id, string carNumber, int customerId, double cost, DateTime dateEnd, string content)
        {
            string query = String.Format("INSERT dbo.Contract( ContractId ,CarNumber ,CustomerId ,DateEnd ,ContractCost ,ContractContent) VALUES  ( '{0}' , '{1}' , {2}  , '{3}' , {4} , N'{5}'  )", id, carNumber, customerId, dateEnd, cost, content);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        internal bool AddNewContractByCon4(string id, string carNumber, int customerId, double cost, DateTime dateStart, DateTime dateEnd, string content)
        {
            string query = String.Format("INSERT dbo.Contract( ContractId ,CarNumber ,CustomerId ,DateStart ,DateEnd ,ContractCost ,ContractContent) VALUES  ( '{0}' , '{1}' , {2} , '{3}' , '{4}' , {5} , N'{6}'  )", id, carNumber, customerId, dateStart, dateEnd, cost, content);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }


        public int GetAmountContractByCustomerId(int id)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.Contract WHERE CustomerId = {0}", id);
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public int GetAmountContractByCarNumber(string carNum)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.Contract WHERE CarNumber = '{0}'", carNum);
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public List<Contract> GetListContract()
        {
            List<Contract> list = new List<Contract>();

            string query = "SELECT * FROM dbo.Contract";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Contract customer = new Contract(item);
                list.Add(customer);
            }
            return list;
        }

        public bool DeleteContract(string contractId)
        {
            string query = String.Format(" DELETE dbo.Contract WHERE ContractId = '{0}' ", contractId);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public int GetAmountContractByID(string contractID)
        {
            string query = string.Format("SELECT count(*) FROM dbo.Contract WHERE ContractId = '{0}'", contractID);
            return int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
        }

        public bool CompleteContract(string id, string carNum)
        {
            string query = string.Format("EXEC dbo.CompleteContract @id = '{0}',  @carNum = '{1}' ", id, carNum);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
