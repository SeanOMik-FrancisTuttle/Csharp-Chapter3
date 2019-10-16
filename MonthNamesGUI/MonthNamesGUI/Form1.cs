using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI {
    public partial class frmMonthNames : Form {

        enum Month {
            JANUARY = 1,
            FEBURARY = 2,
            MARCH = 3,
            APRIL = 4,
            MAY = 5,
            JUNE = 6,
            JULY = 7,
            AUGUST = 8,
            SEPTEMBER = 9,
            OCTOBER = 10,
            NOVEMBER = 11,
            DECEMBER = 12
        }

        public frmMonthNames() {
            InitializeComponent();
        }
        private void btnMonth_Click(object sender, EventArgs e) {
            int monthI = Convert.ToInt32(txtMonth.Text);
            Month month = (Month)monthI;
            lblMonth.Text = month.ToString();
        }
    }
}
