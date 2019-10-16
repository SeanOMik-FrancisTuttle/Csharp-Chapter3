using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI {
    public partial class frmEggsInteractive : Form {
        public frmEggsInteractive() {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e) {
            int egg1 = Convert.ToInt32(txtChicken1.Text);
            int egg2 = Convert.ToInt32(txtChicken2.Text);
            int egg3 = Convert.ToInt32(txtChicken3.Text);
            int egg4 = Convert.ToInt32(txtChicken4.Text);
            int egg5 = Convert.ToInt32(txtChicken5.Text);

            int eggs = egg1 + egg2 + egg3 + egg4 + egg5;

            String eggString = eggs + " eggs is ";
            if (eggs >= 12) {
                int eggDozen = eggs / 12;
                int egg = eggs % 12;

                if (egg > 0) {
                    eggString += eggDozen + " dozen and " + egg + " eggs left over.";
                }
                else {
                    eggString += eggDozen + " dozen.";
                }
            }

            lblEggs.Text = eggString;
        }
    }
}
