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
    public partial class fVehicle : Form
    {
        BindingSource vehicleList = new BindingSource();
        public fVehicle()
        {
            InitializeComponent();
            LoadListVehicle();
            AddVehicleBinding();
        }

        void LoadListVehicle()
        {
            this.dtgVehicle.DataSource = vehicleList;
            vehicleList.DataSource = CarRentalManagement.Instance.GetListCar();
        }

        void AddVehicleBinding()
        {
            this.txbName.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarName", true, DataSourceUpdateMode.Never));
            this.txbNum.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarNumber", true, DataSourceUpdateMode.Never));
            this.txbOrigin.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarOrigin", true, DataSourceUpdateMode.Never));
            this.txbMileage.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "Mileage", true, DataSourceUpdateMode.Never));
            this.txbPrice.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarPriceBuy", true, DataSourceUpdateMode.Never));
            this.txbRentPrice.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarPriceRent", true, DataSourceUpdateMode.Never));
            this.txbCategory.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarCategory", true, DataSourceUpdateMode.Never));
            this.txbStatus.DataBindings.Add(new Binding("Text", this.dtgVehicle.DataSource, "CarStatus", true, DataSourceUpdateMode.Never));
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListVehicle();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = this.txbName.Text;
            string num = this.txbNum.Text;
            string origin = this.txbOrigin.Text;
            float price = float.Parse(this.txbPrice.Text);
            float rentPrice = float.Parse(this.txbRentPrice.Text);
            string status = this.txbStatus.Text;
            float mileage = float.Parse(this.txbMileage.Text);
            string category = this.txbCategory.Text;


            if (CarRentalManagement.Instance.UpdateVehicle(num, name, origin, price, status, rentPrice, mileage, category))
            {
                MessageBox.Show("Update vehicle successfull");
                LoadListVehicle();
            }
            else
            {
                MessageBox.Show("Error when update vehicle information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CarRentalManagement.Instance.DeleteVehicle(this.txbNum.Text))
            {
                MessageBox.Show("Delete vehicle successfull");
                LoadListVehicle();
            }
            else
            {
                MessageBox.Show("Cann't delete vehicle because exist contract of this vehicle");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.vehicleList.DataSource = CarRentalManagement.Instance.SearchVehicleByName(this.txbSearch.Text);
            this.dtgVehicle.DataSource = vehicleList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fService service = new fService();
            this.Hide();
            service.ShowDialog();
            this.Show();
        }

        private void btnCarService_Click(object sender, EventArgs e)
        {
            fServiceHistory history = new fServiceHistory(this.txbNum.Text, this.txbName.Text);
            history.ShowDialog();
            
        }
    }
}
