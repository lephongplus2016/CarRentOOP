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

namespace RentCar
{
    public partial class Main : Form
    {
        public Main(string userName)
        {
            InitializeComponent();
            this.txbDisplayName.Text = AccountDAO.Instance.GetDisplayNameByUserName(userName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fCustomer fCustomer = new fCustomer();
            this.Hide();
            fCustomer.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fVehicle fVehicle = new fVehicle();
            this.Hide();
            fVehicle.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fContract fContract = new fContract();
            this.Hide();
            fContract.ShowDialog();
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fCustomerView view = new fCustomerView();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }
    }
}
