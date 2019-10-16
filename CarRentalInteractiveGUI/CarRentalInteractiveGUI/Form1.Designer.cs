namespace CarRentalInteractiveGUI {
    partial class frmCarRentalInteractiveGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblRent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(30, 24);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(94, 20);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(30, 55);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "Miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(94, 51);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(75, 122);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblRent
            // 
            this.lblRent.Location = new System.Drawing.Point(62, 96);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(100, 23);
            this.lblRent.TabIndex = 5;
            this.lblRent.Text = "$XXXX.XX";
            this.lblRent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCarRentalInteractiveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 167);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Name = "frmCarRentalInteractiveGUI";
            this.Text = "Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblRent;
    }
}

