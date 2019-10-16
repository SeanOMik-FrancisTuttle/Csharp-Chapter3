namespace MonthNamesGUI {
    partial class frmMonthNames {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMonth = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a month date (January = 1, etc.)";
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(72, 63);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "Get Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(59, 35);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(60, 95);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(98, 23);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "XXXXXXXXX";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMonthNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 126);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.label1);
            this.Name = "frmMonthNames";
            this.Text = "Month Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonth;
    }
}

