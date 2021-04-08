using RentCar.DAO;
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
    public partial class AddContract : Form
    {
        public AddContract()
        {
            InitializeComponent();
            LoadCarNumber();
            LoadCustomerNumber();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpDateStart.Enabled = false;
            this.dtpDateEnd.Enabled = false;
            this.txbCost.Enabled = false;
            this.txbContent.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCost.Enabled = false;
            this.txbContent.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpDateEnd.Enabled = false;
            this.txbCost.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCost.Enabled = true;
            this.dtpDateEnd.Enabled = true;
            this.dtpDateStart.Enabled = true;
            this.txbContent.Enabled = true;
            this.cbCarNum.Enabled = true;
            this.cbCusId.Enabled = true;
            this.txbId.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCost.Enabled = false;
            this.dtpDateEnd.Enabled = false;
            this.dtpDateStart.Enabled = false;
            this.txbContent.Enabled = true;
            this.cbCarNum.Enabled = true;
            this.cbCusId.Enabled = true;
            this.txbId.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCost.Enabled = false;
            this.dtpDateEnd.Enabled = true;
            this.dtpDateStart.Enabled = true;
            this.txbContent.Enabled = true;
            this.cbCarNum.Enabled = true;
            this.cbCusId.Enabled = true;
            this.txbId.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txbCost.Enabled = true;
            this.dtpDateEnd.Enabled = true;
            this.dtpDateStart.Enabled = false;
            this.txbContent.Enabled = true;
            this.cbCarNum.Enabled = true;
            this.cbCusId.Enabled = true;
            this.txbId.Enabled = true;
        }

        private void LoadCarNumber()
        {
            List<Vehicle> listCarNum = CarRentalManagement.Instance.GetListCarAvailable();
            this.cbCarNum.DataSource = listCarNum;
            this.cbCarNum.DisplayMember = "CarNumber";
        }

        private void LoadCustomerNumber()
        {
            List<Customer> listCusNum = CustomerController.Instance.GetListCustomer();
            this.cbCusId.DataSource = listCusNum;
            this.cbCusId.DisplayMember = "ID";
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if (this.rbCon1.Checked)
            {
                string id = this.txbId.Text;
                string carNum = this.cbCarNum.Text;
                int cusId = int.Parse(this.cbCusId.Text);
                string content = this.txbContent.Text;
                DateTime dateEnd = this.dtpDateEnd.Value;
                if(ContractController.Instance.GetAmountContractByID(id) == 0)
                {
                    if (ContractController.Instance.AddNewContractByCon1(id, carNum, cusId, dateEnd, content))
                    {
                        MessageBox.Show("Add new contract successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCarNumber();
                    }
                    else
                    {
                        MessageBox.Show("Error when add new contract", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contract ID is exist");
                }
                
            }
            else if (this.rbCon2.Checked)
            {
                string id = this.txbId.Text;
                string carNum = this.cbCarNum.Text;
                int cusId = int.Parse(this.cbCusId.Text);
                string content = this.txbContent.Text;
                DateTime dateStart = this.dtpDateStart.Value;
                DateTime dateEnd = this.dtpDateEnd.Value;
                if (ContractController.Instance.GetAmountContractByID(id) == 0)
                {
                    if (ContractController.Instance.AddNewContractByCon2(id, carNum, cusId, dateStart, dateEnd, content))
                    {
                        MessageBox.Show("Add new contract successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCarNumber();
                    }
                    else
                    {
                        MessageBox.Show("Error when add new contract", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contract ID is exist");
                }
                
            }
            else if (this.rbCon3.Checked)
            {
                string id = this.txbId.Text;
                string carNum = this.cbCarNum.Text;
                int cusId = int.Parse(this.cbCusId.Text);
                string content = this.txbContent.Text;
                float cost = float.Parse(this.txbCost.Text);
                DateTime dateEnd = this.dtpDateEnd.Value;
                if (ContractController.Instance.GetAmountContractByID(id) == 0)
                {
                    if (ContractController.Instance.AddNewContractByCon3(id, carNum, cusId, cost, dateEnd, content))
                    {
                        MessageBox.Show("Add new contract successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCarNumber();
                    }
                    else
                    {
                        MessageBox.Show("Error when add new contract", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contract ID is exist");
                }
            }
            else if (this.rbCon4.Checked)
            {
                string id = this.txbId.Text;
                string carNum = this.cbCarNum.Text;
                int cusId = int.Parse(this.cbCusId.Text);
                string content = this.txbContent.Text;
                float cost = float.Parse(this.txbCost.Text);
                DateTime dateStart = this.dtpDateStart.Value;
                DateTime dateEnd = this.dtpDateEnd.Value;
                if (ContractController.Instance.GetAmountContractByID(id) == 0)
                {
                    if (ContractController.Instance.AddNewContractByCon4(id, carNum, cusId, cost, dateStart, dateEnd, content))
                    {
                        MessageBox.Show("Add new contract successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCarNumber();
                    }
                    else
                    {
                        MessageBox.Show("Error when add new contract", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contract ID is exist");
                }
            }
            else
            {
                MessageBox.Show("You must select the constructor and enter the data before adding it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txbContent.Clear();
            this.txbCost.Clear();
            this.txbId.Clear();
        }
    }
}
