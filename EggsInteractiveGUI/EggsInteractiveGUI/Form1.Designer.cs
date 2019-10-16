namespace EggsInteractiveGUI {
    partial class frmEggsInteractive {
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
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEggs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(44, 59);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(44, 20);
            this.txtChicken1.TabIndex = 1;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(113, 59);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(44, 20);
            this.txtChicken2.TabIndex = 2;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(179, 59);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(44, 20);
            this.txtChicken3.TabIndex = 3;
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(44, 98);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(44, 20);
            this.txtChicken5.TabIndex = 4;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(113, 98);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(44, 20);
            this.txtChicken4.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(96, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEggs
            // 
            this.lblEggs.Location = new System.Drawing.Point(11, 173);
            this.lblEggs.Name = "lblEggs";
            this.lblEggs.Size = new System.Drawing.Size(245, 23);
            this.lblEggs.TabIndex = 7;
            this.lblEggs.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.lblEggs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEggsInteractive
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 209);
            this.Controls.Add(this.lblEggs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.label1);
            this.Name = "frmEggsInteractive";
            this.Text = "Eggs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEggs;
    }
}

