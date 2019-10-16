using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI {
    public partial class frmCarRentalInteractiveGUI : Form {
        public frmCarRentalInteractiveGUI() {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            double miles = Convert.ToInt32(txtMiles.Text);
            double days = Convert.ToInt32(txtDays.Text);

            double rent = days * 20 + miles * 0.25;
            lblRent.Text = rent.ToString("C");
        }
    }
}
