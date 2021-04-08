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
    public partial class fCustomer : Form
    {
        BindingSource customerList = new BindingSource();
        public fCustomer()
        {
            InitializeComponent();
            LoadListCustomer();
            AddCustomerBinding();
        }
        void LoadListCustomer()
        {
            this.dtgvCustomerList.DataSource = customerList;
            customerList.DataSource = CustomerController.Instance.GetListCustomer();
        }

        void AddCustomerBinding()
        {
            txbName.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbAge.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "Age", true, DataSourceUpdateMode.Never));
            txbAddress.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbCredit.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "CreditCard", true, DataSourceUpdateMode.Never));
            txbDeposit.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "Deposit", true, DataSourceUpdateMode.Never));
            txbId.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbLicense.DataBindings.Add(new Binding("Text", this.dtgvCustomerList.DataSource, "CarLicense", true, DataSourceUpdateMode.Never));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string address = this.txbAddress.Text;
            int age = int.Parse(this.txbAge.Text);
            string carLicense = this.txbLicense.Text;
            string creditCard = this.txbCredit.Text;
            float deposit = float.Parse(this.txbDeposit.Text);
            int id = int.Parse(this.txbId.Text);
            string name = this.txbName.Text;

            if (CustomerController.Instance.UpdateCustomer(address, age, carLicense, creditCard, deposit, id, name))
            {
                MessageBox.Show("Update customer successfull");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Error when update customer information");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.customerList.DataSource = CustomerController.Instance.SearchCustomerByName(this.txbSearch.Text);
            this.dtgvCustomerList.DataSource = customerList;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (CustomerController.Instance.DeleteCustomer(int.Parse(this.txbId.Text)))
            {
                MessageBox.Show("Delete customer successfull");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Cann't delete customer because exist contract of this customer");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
