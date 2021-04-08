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
    public partial class fContract : Form
    {
        BindingSource contractList = new BindingSource();
        public fContract()
        {
            InitializeComponent();
            LoadListContract();
            AddContractBinding();
        }

        void LoadListContract()
        {
            this.dtgContract.DataSource = contractList;
            contractList.DataSource = ContractController.Instance.GetListContract();
        }

        void AddContractBinding()
        {
            this.txbCarNum.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "CarNumber", true, DataSourceUpdateMode.Never));
            this.txbContent.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "Content", true, DataSourceUpdateMode.Never));
            this.txbContractID.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "Id", true, DataSourceUpdateMode.Never));
            this.txbCost.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "Cost", true, DataSourceUpdateMode.Never));
            this.txbCusID.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "CustomerId", true, DataSourceUpdateMode.Never));
            this.dtpStart.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "DateStart", true, DataSourceUpdateMode.Never));
            this.dtpEnd.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "DateEnd", true, DataSourceUpdateMode.Never));
            this.txbStatus.DataBindings.Add(new Binding("Text", this.dtgContract.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListContract();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ContractController.Instance.DeleteContract(this.txbContractID.Text);
            MessageBox.Show("Delete contract successfull");
            LoadListContract();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            addContract.ShowDialog();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string id = this.txbContractID.Text;
            string carNum = this.txbCarNum.Text;
            if (ContractController.Instance.CompleteContract(id, carNum))
            {
                MessageBox.Show("Contract with id = " + id + " is completed");
                LoadListContract();
            }
            else
            {
                MessageBox.Show("Cannot complete contract, please review your problem");
            }
        }
    }
}
