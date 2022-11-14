namespace EggsInteractiveGUI
{
    partial class frmEggsInteractiveGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblChicken1 = new System.Windows.Forms.Label();
            this.lblChicken2 = new System.Windows.Forms.Label();
            this.lblChicken4 = new System.Windows.Forms.Label();
            this.lblChicken5 = new System.Windows.Forms.Label();
            this.lblChicken3 = new System.Windows.Forms.Label();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(123, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(358, 20);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter the number of eggs laid by each chicken.";
            // 
            // lblChicken1
            // 
            this.lblChicken1.AutoSize = true;
            this.lblChicken1.Location = new System.Drawing.Point(37, 76);
            this.lblChicken1.Name = "lblChicken1";
            this.lblChicken1.Size = new System.Drawing.Size(83, 16);
            this.lblChicken1.TabIndex = 1;
            this.lblChicken1.Text = "Chicken One";
            // 
            // lblChicken2
            // 
            this.lblChicken2.AutoSize = true;
            this.lblChicken2.Location = new System.Drawing.Point(221, 76);
            this.lblChicken2.Name = "lblChicken2";
            this.lblChicken2.Size = new System.Drawing.Size(84, 16);
            this.lblChicken2.TabIndex = 2;
            this.lblChicken2.Text = "Chicken Two";
            // 
            // lblChicken4
            // 
            this.lblChicken4.AutoSize = true;
            this.lblChicken4.Location = new System.Drawing.Point(36, 151);
            this.lblChicken4.Name = "lblChicken4";
            this.lblChicken4.Size = new System.Drawing.Size(85, 16);
            this.lblChicken4.TabIndex = 3;
            this.lblChicken4.Text = "Chicken Four";
            // 
            // lblChicken5
            // 
            this.lblChicken5.AutoSize = true;
            this.lblChicken5.Location = new System.Drawing.Point(221, 151);
            this.lblChicken5.Name = "lblChicken5";
            this.lblChicken5.Size = new System.Drawing.Size(84, 16);
            this.lblChicken5.TabIndex = 4;
            this.lblChicken5.Text = "Chicken Five";
            // 
            // lblChicken3
            // 
            this.lblChicken3.AutoSize = true;
            this.lblChicken3.Location = new System.Drawing.Point(415, 76);
            this.lblChicken3.Name = "lblChicken3";
            this.lblChicken3.Size = new System.Drawing.Size(94, 16);
            this.lblChicken3.TabIndex = 5;
            this.lblChicken3.Text = "Chicken Three";
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(146, 73);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(34, 22);
            this.txtChicken1.TabIndex = 6;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(146, 148);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(34, 22);
            this.txtChicken4.TabIndex = 7;
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(329, 148);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(34, 22);
            this.txtChicken5.TabIndex = 8;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(525, 73);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(34, 22);
            this.txtChicken3.TabIndex = 9;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(329, 73);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(34, 22);
            this.txtChicken2.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(249, 256);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.Location = new System.Drawing.Point(83, 366);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(439, 20);
            this.lblCalculation.TabIndex = 12;
            this.lblCalculation.Text = "This is the final sum of eggs with dozens and remainders.";
            // 
            // frmEggsInteractiveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 514);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.lblChicken3);
            this.Controls.Add(this.lblChicken5);
            this.Controls.Add(this.lblChicken4);
            this.Controls.Add(this.lblChicken2);
            this.Controls.Add(this.lblChicken1);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmEggsInteractiveGUI";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblChicken1;
        private System.Windows.Forms.Label lblChicken2;
        private System.Windows.Forms.Label lblChicken4;
        private System.Windows.Forms.Label lblChicken5;
        private System.Windows.Forms.Label lblChicken3;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalculation;
    }
}

