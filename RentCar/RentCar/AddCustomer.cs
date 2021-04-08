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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (this.rbCon1.Checked)
            {
                int id;
                int age;
                string name = this.txb_name.Text;
                if (!(int.TryParse(this.txb_id.Text, out id)))
                {
                    MessageBox.Show("Customer ID must be integer");
                }
                
                else if(!(int.TryParse(this.txb_age.Text, out age)))
                {
                    MessageBox.Show("Customer Age must be integer");
                }
                else
                {
                    if(CustomerController.Instance.GetAmountCustomerByID(id) == 0)
                    {
                        if (CustomerController.Instance.AddNewCustomerByCon1(id, name, age))
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer ID is exist");
                    }

                    
                }
            }
            else if (this.rbCon2.Checked)
            {
                string address = this.txb_address.Text;
                int id;
                string name = this.txb_name.Text;
                int age;
                if (!(int.TryParse(this.txb_id.Text, out id)))
                {
                    MessageBox.Show("Customer ID must be integer");
                }
                
                else if (!(int.TryParse(this.txb_age.Text, out age)))
                {
                    MessageBox.Show("Customer Age must be integer");
                }
                else
                {
                    if (CustomerController.Instance.GetAmountCustomerByID(id) == 0)
                    {
                        if (CustomerController.Instance.AddNewCustomerByCon2(id, name, age, address))
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer ID is exist");
                    }
                    
                }
            }
            else if (this.rbCon3.Checked)
            {
                int id;
                string name = this.txb_name.Text;
                int age;
                string address = this.txb_address.Text;
                string credit = this.txb_card.Text;
                string license = this.txb_license.Text;
                double deposit;
                if (!(int.TryParse(this.txb_id.Text, out id)))
                {
                    MessageBox.Show("Customer ID must be integer");
                }
                
                else if (!(int.TryParse(this.txb_age.Text, out age)))
                {
                    MessageBox.Show("Customer Age must be integer");
                }
                
                else if (!(double.TryParse(this.txb_deposit.Text, out deposit)))
                {
                    MessageBox.Show("Customer Deposit must be double");
                }
                else
                {
                    if (CustomerController.Instance.GetAmountCustomerByID(id) == 0)
                    {
                        if (CustomerController.Instance.AddNewCustomerByCon3(id, name, age, address, credit, license, deposit))
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer ID is exist");
                    }
                    
                }
                
            }
            else if (this.rbCon4.Checked)
            {
                int id;
                string name = this.txb_name.Text;
                int age;
                double deposit;
                if (!(int.TryParse(this.txb_id.Text, out id)))
                {
                    MessageBox.Show("Customer ID must be integer");
                }
                
                else if (!(int.TryParse(this.txb_age.Text, out age)))
                {
                    MessageBox.Show("Customer Age must be integer");
                }
                
                else if (!(double.TryParse(this.txb_deposit.Text, out deposit)))
                {
                    MessageBox.Show("Customer Deposit must be double");
                }
                else
                {
                    if (CustomerController.Instance.GetAmountCustomerByID(id) == 0)
                    {
                        if (CustomerController.Instance.AddNewCustomerByCon4(id, name, age, deposit))
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Add new customer successful", "YEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer ID is exist");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("You must select the constructor and enter the data before adding it", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txb_address.Clear();
            this.txb_age.Clear();
            this.txb_card.Clear();
            this.txb_deposit.Clear();
            this.txb_id.Clear();
            this.txb_license.Clear();
            this.txb_name.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txb_address.Enabled = false;
            this.txb_age.Enabled = true;
            this.txb_card.Enabled = false;
            this.txb_deposit.Enabled = false;
            this.txb_id.Enabled = true;
            this.txb_license.Enabled = false;
            this.txb_name.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txb_address.Enabled = true;
            this.txb_age.Enabled = true;
            this.txb_card.Enabled = false;
            this.txb_deposit.Enabled = false;
            this.txb_id.Enabled = true;
            this.txb_license.Enabled = false;
            this.txb_name.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txb_address.Enabled = true;
            this.txb_age.Enabled = true;
            this.txb_card.Enabled = true;
            this.txb_deposit.Enabled = true;
            this.txb_id.Enabled = true;
            this.txb_license.Enabled = true;
            this.txb_name.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.txb_address.Enabled = false;
            this.txb_age.Enabled = true;
            this.txb_card.Enabled = false;
            this.txb_deposit.Enabled = true;
            this.txb_id.Enabled = true;
            this.txb_license.Enabled = false;
            this.txb_name.Enabled = true;
        }
    }
}
