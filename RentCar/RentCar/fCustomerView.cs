using RentCar.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class fCustomerView : Form
    {
        public fCustomerView()
        {
            InitializeComponent();
            List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar();
            LoadVehicle(vehicleList);
            this.cbCategory.DataSource = CarRentalManagement.Instance.GetCategory();
            this.cbCategory.DisplayMember = "CarCategory";
        }

        private void cbCate_CheckedChanged(object sender, EventArgs e)
        {
            this.cbCategory.Enabled = true;
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            this.txbMin.Enabled = true;
            this.txbMax.Enabled = true;
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            this.txbSearch.Enabled = true;
        }

        void LoadVehicle(List<Vehicle> vehicleList)
        {
            this.flCar.Controls.Clear();

            foreach (Vehicle item in vehicleList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                switch (item.CarCategory)
                {
                    case "Vinfast":
                        btn.BackgroundImage = Properties.Resources.xe1;
                        break;
                    case "Ford":
                        btn.BackgroundImage = Properties.Resources.xe2;
                        break;
                    case "Carmudi":
                        btn.BackgroundImage = Properties.Resources.xe3;
                        break;
                    default:
                        break;
                }
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Tag = item;
                btn.Click += Btn_Click;
                this.flCar.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Vehicle btnVehicle = btn.Tag as Vehicle;
            this.txbCategory.Text = btnVehicle.CarCategory;
            this.txbMileage.Text = btnVehicle.Mileage.ToString();
            this.txbName.Text = btnVehicle.CarName;
            this.txbNum.Text = btnVehicle.CarNumber;
            this.txbOrigin.Text = btnVehicle.CarOrigin;
            this.txbPrice.Text = btnVehicle.CarPriceBuy.ToString();
            this.txbRentPrice.Text = btnVehicle.CarPriceRent.ToString();
            this.txbStatus.Text = btnVehicle.CarStatus.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.cbCate.Checked == true && this.cbPrice.Checked == false && this.cbName.Checked == false)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(this.cbCategory.Text);
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == false && this.cbPrice.Checked == true && this.cbName.Checked == false)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(float.Parse(this.txbMin.Text), float.Parse(this.txbMax.Text));
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == false && this.cbPrice.Checked == false && this.cbName.Checked == true)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCarName(this.txbSearch.Text);
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == true && this.cbPrice.Checked == true && this.cbName.Checked == false)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(this.cbCategory.Text, float.Parse(this.txbMin.Text), float.Parse(this.txbMax.Text));
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == false && this.cbPrice.Checked == true && this.cbName.Checked == true)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(float.Parse(this.txbMin.Text), float.Parse(this.txbMax.Text), this.txbSearch.Text);
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == true && this.cbPrice.Checked == false && this.cbName.Checked == true)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(this.cbCategory.Text, this.txbSearch.Text);
                LoadVehicle(vehicleList);
            }
            else if (this.cbCate.Checked == true && this.cbPrice.Checked == true && this.cbName.Checked == true)
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar(this.cbCategory.Text, float.Parse(this.txbMin.Text), float.Parse(this.txbMax.Text), this.txbSearch.Text);
                LoadVehicle(vehicleList);
            }
            else
            {
                List<Vehicle> vehicleList = CarRentalManagement.Instance.GetListCar();
                LoadVehicle(vehicleList);
            }
        }
    }
}
