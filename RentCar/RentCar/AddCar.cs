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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btAddCar_Click(object sender, EventArgs e)
        {
            if (!(this.cbCarmudi.Checked || this.cbFord.Checked || this.cbVinfast.Checked)){
                MessageBox.Show("You must select category of the vehicle", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.rbCon1.Checked)
            {
                string carNum = this.txbCarNum.Text;
                string carName = this.txbCarName.Text;
                double carPriceBuy = double.Parse(this.txbCarPrice.Text);
                string carCategory = "";
                if (this.cbVinfast.Checked)
                {
                    carCategory = cbVinfast.Text;
                }
                if (this.cbCarmudi.Checked)
                {
                    carCategory = cbCarmudi.Text;
                }
                if (this.cbFord.Checked)
                {
                    carCategory = cbFord.Text;
                }
                if(CarRentalManagement.Instance.GetAmountVehicleByNumber(carNum) == 0)
                {
                    if (CarRentalManagement.Instance.AddNewCarByCon1(carNum, carName, carPriceBuy, carCategory))
                    {
                        MessageBox.Show("Add new car successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error when add new car", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Car number is exist", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (this.rbCon2.Checked)
            {
                string carNum = this.txbCarNum.Text;
                string carName = this.txbCarName.Text;
                double carPriceBuy = double.Parse(this.txbCarPrice.Text);
                string carCategory = "";
                string carOrigin = this.txbCarOrigin.Text;
                if (this.cbVinfast.Checked)
                {
                    carCategory = cbVinfast.Text;
                }
                if (this.cbCarmudi.Checked)
                {
                    carCategory = cbCarmudi.Text;
                }
                if (this.cbFord.Checked)
                {
                    carCategory = cbFord.Text;
                }
                if (CarRentalManagement.Instance.GetAmountVehicleByNumber(carNum) == 0)
                {
                    if (CarRentalManagement.Instance.AddNewCarByCon2(carNum, carName, carPriceBuy, carOrigin, carCategory))
                    {
                        MessageBox.Show("Add new car successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error when add new car", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Car number is exist", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.rbCon4.Checked)
            {
                string carNum = this.txbCarNum.Text;
                string carName = this.txbCarName.Text;
                double carPriceBuy = double.Parse(this.txbCarPrice.Text);
                string carCategory = "";
                string carOrigin = this.txbCarOrigin.Text;
                double carRentPrice = double.Parse(this.txbCarRentPrice.Text);
                if (this.cbVinfast.Checked)
                {
                    carCategory = cbVinfast.Text;
                }
                if (this.cbCarmudi.Checked)
                {
                    carCategory = cbCarmudi.Text;
                }
                if (this.cbFord.Checked)
                {
                    carCategory = cbFord.Text;
                }
                if (CarRentalManagement.Instance.GetAmountVehicleByNumber(carNum) == 0)
                {
                    if (CarRentalManagement.Instance.AddNewCarByCon3(carNum, carName, carPriceBuy, carRentPrice, carOrigin, carCategory))
                    {
                        MessageBox.Show("Add new car successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error when add new car", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Car number is exist", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You must select the constructor and enter the data before adding it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txbCarName.Clear();
            this.txbCarNum.Clear();
            this.txbCarOrigin.Clear();
            this.txbCarPrice.Clear();
            this.txbCarRentPrice.Clear();
            this.cbCarmudi.Checked = false;
            this.cbFord.Checked = false;
            this.cbVinfast.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCarRentPrice.Enabled = false;
            this.txbCarOrigin.Enabled = true;
            this.txbCarName.Enabled = true;
            this.txbCarNum.Enabled = true;
            this.txbCarPrice.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCarOrigin.Enabled = false;
            this.txbCarRentPrice.Enabled = false;
            this.txbCarName.Enabled = true;
            this.txbCarNum.Enabled = true;
            this.txbCarPrice.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCarRentPrice.Enabled = false;
            this.txbCarOrigin.Enabled = true;
            this.txbCarName.Enabled = true;
            this.txbCarNum.Enabled = true;
            this.txbCarPrice.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCarRentPrice.Enabled = true;
            this.txbCarOrigin.Enabled = true;
            this.txbCarName.Enabled = true;
            this.txbCarNum.Enabled = true;
            this.txbCarPrice.Enabled = true;
        }
    }
}
