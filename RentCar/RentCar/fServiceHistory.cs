using RentCar.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Newtonsoft.Json;
using System.Runtime.Remoting.Channels;

namespace RentCar
{
    public partial class fServiceHistory : Form
    {
        string carNum;
        string carName;
        public fServiceHistory(string carNum, string carName)
        {
            this.carNum = carNum;
            this.carName = carName;
            InitializeComponent();
            LoadServiceHistory();
        }

        private void LoadServiceHistory()
        {
            this.txbNum.Text = this.carNum;
            this.txbName.Text = this.carName;
            DataTable data1 = ServiceController.Instance.GetHistoryByCarNumber(this.carNum);
            DataTable data2 = ServiceController.Instance.GetHistoryByCarNumber(this.carNum);
            this.dtgHistory.DataSource = data1;
            this.cbFirst.DataSource = data1;
            this.cbFirst.DisplayMember = "ID";
            this.cbSecond.DataSource = data2;
            this.cbSecond.DisplayMember = "ID";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ServiceHistory firstHistory;
            ServiceHistory secondHistory;
            string query1 = string.Format("SELECT * FROM dbo.ServiceHistory WHERE ID = {0}", int.Parse(this.cbFirst.Text));
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            firstHistory = new ServiceHistory(data1.Rows[0]);

            string query2 = string.Format("SELECT * FROM dbo.ServiceHistory WHERE ID = {0}", int.Parse(this.cbSecond.Text));
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            secondHistory = new ServiceHistory(data2.Rows[0]);

            this.txbDistance.Text = (firstHistory - secondHistory).ToString() + " km";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ServiceHistory firstHistory;
            ServiceHistory secondHistory;
            string query1 = string.Format("SELECT * FROM dbo.ServiceHistory WHERE ID = {0}", int.Parse(this.cbFirst.Text));
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            firstHistory = new ServiceHistory(data1.Rows[0]);

            string query2 = string.Format("SELECT * FROM dbo.ServiceHistory WHERE ID = {0}", int.Parse(this.cbSecond.Text));
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            secondHistory = new ServiceHistory(data2.Rows[0]);

            switch (firstHistory > secondHistory)
            {
                case 0:
                    this.txbCompare.Text = "The same";
                    break;
                case 1:
                    this.txbCompare.Text = "After";
                    break;
                case -1:
                    this.txbCompare.Text = "Before";
                    break;
                default:
                    break;
            }
        }

        private void button_Json_Click(object sender, EventArgs e)
        {
            //add json
            List<ServiceHistory> listRecordToJson = new List<ServiceHistory>();
            listRecordToJson = ServiceController.Instance.GetHistoryLisOfThisCartByCarNumber(this.carNum);

            string jsonOutput = JsonConvert.SerializeObject(listRecordToJson);

            System.IO.File.WriteAllText("JsonDocument/service.json", jsonOutput);

            MessageBox.Show("Published a json report");

            // copy file
            string fileName = "service.json";
            string sourcePath = @"C:\Users\lepho\Desktop\not sure what to do yet\code\oop\ass\final\ngay 7 -12\Final Submission\Final Submission\RentCar\RentCar\bin\Debug\JsonDocument";
            string targetPath = @"C:\Users\lepho\Desktop\not sure what to do yet\code\oop\ass\final\ngay 7 -12\Final Submission\Final Submission\RentCar\Json File Store";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, "service" + this.carNum + ".json");


            System.IO.Directory.CreateDirectory(targetPath);


            System.IO.File.Copy(sourceFile, destFile, true);


            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                MessageBox.Show("Error when copy json file to source");
            }
        }
    }
}
