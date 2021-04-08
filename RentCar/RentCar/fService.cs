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
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
        }

        private void btnVinfast_Click(object sender, EventArgs e)
        {
            fVehicleService service = new fVehicleService(1);
            this.Hide();
            service.ShowDialog();
            this.Show();
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            fVehicleService service = new fVehicleService(2);
            this.Hide();
            service.ShowDialog();
            this.Show();
        }

        private void btnCarmudi_Click(object sender, EventArgs e)
        {
            fVehicleService service = new fVehicleService(3);
            this.Hide();
            service.ShowDialog();
            this.Show();
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            fVehicleService service = new fVehicleService(0);
            this.Hide();
            service.ShowDialog();
            this.Show();
        }
    }
}
