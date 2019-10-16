using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            Console.Write("Enter your name: ");
            String name = txtName.Text;

            Console.Write("Social Security number: ");
            String ssn = txtSSN.Text;

            Console.Write("Hourly pay rate: ");
            double payRate = Convert.ToDouble(txtHourPay.Text);

            Console.Write("Hours Worked: ");
            int hours = Convert.ToInt32(txtHoursWorked.Text);

            double grossPay = payRate * hours;
            double federalHolding = payRate * 0.15;
            double stateHolding = payRate * 0.05;

            double netPay = grossPay - federalHolding - stateHolding;

            lblText.Text = "Gross pay:                 " + grossPay.ToString("C")       + "\n" +
                           "Federal withholding:       " + federalHolding.ToString("C") + "\n" +
                           "State withholding:         " + stateHolding.ToString("C")   + "\n" +
                           "----------------------------------------------------"       + "\n" +
                           "Net pay:                   " + netPay.ToString("C");
        }
    }
}
