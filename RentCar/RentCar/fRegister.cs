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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (this.textBox_User_Name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập");
            }
            else if (this.textBox_Display_Name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hiển thị");
            }
            else if (this.textBox_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else if (this.textBox_ReEnter.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
            }
            else if (this.textBox_Password.Text != this.textBox_ReEnter.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
            }
            else if (AccountDAO.Instance.GetAccountExist(this.textBox_User_Name.Text) != 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
            else
            {
                if (AccountDAO.Instance.InsertNewAccount(this.textBox_User_Name.Text, this.textBox_Password.Text, this.textBox_Display_Name.Text, this.txbAddress.Text, this.txbPhone.Text))
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.textBox_User_Name.Text = "";
                    this.textBox_Display_Name.Text = "";
                    this.textBox_Password.Text = "";
                    this.textBox_ReEnter.Text = "";
                    this.txbPhone.Text = "";
                    this.txbAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản không thành công");
                }
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            this.textBox_User_Name.Text = "";
            this.textBox_Display_Name.Text = "";
            this.textBox_Password.Text = "";
            this.textBox_ReEnter.Text = "";
            this.txbAddress.Text = "";
            this.txbPhone.Text = "";
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_User_Name_Enter(object sender, EventArgs e)
        {
            this.textBox_User_Name.Text = "";
            this.textBox_User_Name.ForeColor = Color.Black;
        }

        private void textBox_Display_Name_Enter(object sender, EventArgs e)
        {
            this.textBox_Display_Name.Text = "";
            this.textBox_Display_Name.ForeColor = Color.Black;
        }

        private void txbAddress_Enter(object sender, EventArgs e)
        {
            this.txbAddress.Text = "";
            this.txbAddress.ForeColor = Color.Black;
        }

        private void txbPhone_Enter(object sender, EventArgs e)
        {
            this.txbPhone.Text = "";
            this.txbPhone.ForeColor = Color.Black;
        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            this.textBox_Password.Text = "";
            this.textBox_Password.ForeColor = Color.Black;
        }

        private void textBox_ReEnter_Enter(object sender, EventArgs e)
        {
            this.textBox_ReEnter.Text = "";
            this.textBox_ReEnter.ForeColor = Color.Black;
        }
    }
}
