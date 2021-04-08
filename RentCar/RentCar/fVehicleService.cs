using RentCar.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RentCar
{
    public partial class fVehicleService : Form
    {
        int category;
        public fVehicleService(int category)
        {
            this.category = category;
            InitializeComponent();
            LoadListVehicleByCategory();
        }

        public void ShowJsonReport()
        {
            ServiceHistory sh1 = ServiceController.Instance.GetServiceHistorToJsonShowMess();
            string Json = JsonConvert.SerializeObject(sh1);
            MessageBox.Show(Json, "Json Document!");
        }

        public void LoadListVehicleByCategory()
        {
            if(this.category == 0)
            {
                this.dtgVehicle.DataSource = CarRentalManagement.Instance.GetListCar();
            }
            else
            {
                this.dtgVehicle.DataSource = CarRentalManagement.Instance.GetListCarByCategory(this.category);
            }
        }

        private void btnEngine_Click(object sender, EventArgs e)
        {
            string carNum;
            float mileage;
            if (this.dtgVehicle.SelectedCells.Count > 0)
            {
                carNum = (string)dtgVehicle.SelectedCells[0].OwningRow.Cells["CarNumber"].Value;
                mileage = (float)dtgVehicle.SelectedCells[0].OwningRow.Cells["Mileage"].Value;
                switch (this.category)
                {
                    case 0:
                        foreach (DataGridViewRow item in this.dtgVehicle.Rows)
                        {
                            string carNum_ = item.Cells["CarNumber"].Value.ToString();
                            float mileage_ = float.Parse(item.Cells["Mileage"].Value.ToString());
                            switch (item.Cells["CarCategory"].Value.ToString())
                            {
                                case "Vinfast":
                                    ServiceController.Instance.ServiceEngine(1, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Ford":
                                    ServiceController.Instance.ServiceEngine(2, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Carmudi":
                                    ServiceController.Instance.ServiceEngine(3, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                default:
                                    break;
                            }
                        }
                        for (int i = 0; i < 1000; i++)
                        {
                            this.prgBar.Value = i;
                            Thread.Sleep(10);
                        }
                        MessageBox.Show("Service engine process for your team car is complete");
                        break;
                    case 1:
                        if (ServiceController.Instance.ServiceEngine(1, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service engine of car with car number is " + carNum +   " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 1000 km to use service engine");
                        }
                            break;
                    case 2:
                        if (ServiceController.Instance.ServiceEngine(2, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service engine of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 1200 km to use service engine");
                        }
                        break;
                    case 3:
                        if (ServiceController.Instance.ServiceEngine(3, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service engine of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 1400 km to use service engine");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must select vehicle before process service engine");
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            string carNum;
            float mileage;
            if (this.dtgVehicle.SelectedCells.Count > 0)
            {
                carNum = (string)dtgVehicle.SelectedCells[0].OwningRow.Cells["CarNumber"].Value;
                mileage = (float)dtgVehicle.SelectedCells[0].OwningRow.Cells["Mileage"].Value;
                switch (this.category)
                {
                    case 0:
                        foreach (DataGridViewRow item in this.dtgVehicle.Rows)
                        {
                            string carNum_ = item.Cells["CarNumber"].Value.ToString();
                            float mileage_ = float.Parse(item.Cells["Mileage"].Value.ToString());
                            switch (item.Cells["CarCategory"].Value.ToString())
                            {
                                case "Vinfast":
                                    ServiceController.Instance.ServiceTransmission(1, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Ford":
                                    ServiceController.Instance.ServiceTransmission(2, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Carmudi":
                                    ServiceController.Instance.ServiceTransmission(3, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                default:
                                    break;
                            }
                        }
                        for (int i = 0; i < 1000; i++)
                        {
                            this.prgBar.Value = i;
                            Thread.Sleep(10);
                        }
                        MessageBox.Show("Service transmission process for your team car is complete");
                        break;
                    case 1:
                        if (ServiceController.Instance.ServiceTransmission(1, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service transmission of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 2000 km to use service transmission");
                        }
                        break;
                    case 2:
                        if (ServiceController.Instance.ServiceTransmission(2, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service transmission of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 2200 km to use service transmission");
                        }
                        break;
                    case 3:
                        if (ServiceController.Instance.ServiceTransmission(3, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service transmission of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 2400 km to use service transmission");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must select vehicle before process service transmission");
            }
        }

        private void btnTires_Click(object sender, EventArgs e)
        {
            string carNum;
            float mileage;
            if (this.dtgVehicle.SelectedCells.Count > 0)
            {
                carNum = (string)dtgVehicle.SelectedCells[0].OwningRow.Cells["CarNumber"].Value;
                mileage = (float)dtgVehicle.SelectedCells[0].OwningRow.Cells["Mileage"].Value;
                switch (this.category)
                {
                    case 0:
                        foreach (DataGridViewRow item in this.dtgVehicle.Rows)
                        {
                            string carNum_ = item.Cells["CarNumber"].Value.ToString();
                            float mileage_ = float.Parse(item.Cells["Mileage"].Value.ToString());
                            switch (item.Cells["CarCategory"].Value.ToString())
                            {
                                case "Vinfast":
                                    ServiceController.Instance.ServiceTires(1, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Ford":
                                    ServiceController.Instance.ServiceTires(2, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                case "Carmudi":
                                    ServiceController.Instance.ServiceTires(3, carNum_, mileage_);
                                    ShowJsonReport();
                                    break;
                                default:
                                    break;
                            }
                        }
                        for (int i = 0; i < 1000; i++)
                        {
                            this.prgBar.Value = i;
                            Thread.Sleep(10);
                        }
                        MessageBox.Show("Service tires process for your team car is complete");
                        break;
                    case 1:
                        if (ServiceController.Instance.ServiceTires(1, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service tires of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 3000 km to use service tires");
                        }
                        break;
                    case 2:
                        if (ServiceController.Instance.ServiceTires(2, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service tires of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 3200 km to use service tires");
                        }
                        break;
                    case 3:
                        if (ServiceController.Instance.ServiceTires(3, carNum, mileage))
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                this.prgBar.Value = i;
                                Thread.Sleep(10);
                            }
                            MessageBox.Show("Process service tires of car with car number is " + carNum + " complete");
                            ShowJsonReport();
                        }
                        else
                        {
                            MessageBox.Show("Your vehicle must drive further 3400 km to use service tires");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must select vehicle before process service tires");
            }
        }
    }
}
