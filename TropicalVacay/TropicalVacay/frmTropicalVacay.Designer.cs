namespace TropicalVacay
{
    partial class frmTropicalVacay
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
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblDepature = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblMealPlan = new System.Windows.Forms.Label();
            this.lblVacayTotal = new System.Windows.Forms.Label();
            this.cblCity = new System.Windows.Forms.CheckedListBox();
            this.cblRoomType = new System.Windows.Forms.CheckedListBox();
            this.cblMealPlan = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.White;
            this.txtInstructions.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.ForeColor = System.Drawing.Color.Cyan;
            this.txtInstructions.Location = new System.Drawing.Point(57, 29);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(574, 65);
            this.txtInstructions.TabIndex = 0;
            this.txtInstructions.Text = "Make a selection from each box then click the button to see your vacay total!\r\n";
            this.txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.White;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(293, 377);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(96, 41);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblDepature
            // 
            this.lblDepature.AutoSize = true;
            this.lblDepature.BackColor = System.Drawing.Color.White;
            this.lblDepature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepature.Location = new System.Drawing.Point(40, 152);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(142, 24);
            this.lblDepature.TabIndex = 3;
            this.lblDepature.Text = "Departure City";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.White;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(221, 152);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(118, 24);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.Text = "Room Type";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMealPlan
            // 
            this.lblMealPlan.AutoSize = true;
            this.lblMealPlan.BackColor = System.Drawing.Color.White;
            this.lblMealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPlan.Location = new System.Drawing.Point(400, 152);
            this.lblMealPlan.Name = "lblMealPlan";
            this.lblMealPlan.Size = new System.Drawing.Size(102, 24);
            this.lblMealPlan.TabIndex = 7;
            this.lblMealPlan.Text = "Meal Plan";
            this.lblMealPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVacayTotal
            // 
            this.lblVacayTotal.AutoSize = true;
            this.lblVacayTotal.BackColor = System.Drawing.Color.White;
            this.lblVacayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacayTotal.Location = new System.Drawing.Point(274, 455);
            this.lblVacayTotal.Name = "lblVacayTotal";
            this.lblVacayTotal.Size = new System.Drawing.Size(134, 20);
            this.lblVacayTotal.TabIndex = 8;
            this.lblVacayTotal.Text = "Total: $0000.00";
            // 
            // cblCity
            // 
            this.cblCity.CheckOnClick = true;
            this.cblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblCity.ForeColor = System.Drawing.Color.Cyan;
            this.cblCity.FormattingEnabled = true;
            this.cblCity.Items.AddRange(new object[] {
            "Atlanta",
            "Chicago",
            "Dallas",
            "Los Angeles",
            "Miami",
            "New York"});
            this.cblCity.Location = new System.Drawing.Point(44, 208);
            this.cblCity.Name = "cblCity";
            this.cblCity.Size = new System.Drawing.Size(125, 130);
            this.cblCity.TabIndex = 9;
            this.cblCity.SelectedIndexChanged += new System.EventHandler(this.cblCity_SelectedIndexChanged);
            // 
            // cblRoomType
            // 
            this.cblRoomType.CheckOnClick = true;
            this.cblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblRoomType.ForeColor = System.Drawing.Color.Cyan;
            this.cblRoomType.FormattingEnabled = true;
            this.cblRoomType.Items.AddRange(new object[] {
            "Queen",
            "King",
            "Suite"});
            this.cblRoomType.Location = new System.Drawing.Point(225, 208);
            this.cblRoomType.Name = "cblRoomType";
            this.cblRoomType.Size = new System.Drawing.Size(125, 130);
            this.cblRoomType.TabIndex = 10;
            this.cblRoomType.SelectedIndexChanged += new System.EventHandler(this.cblRoomType_SelectedIndexChanged);
            // 
            // cblMealPlan
            // 
            this.cblMealPlan.CheckOnClick = true;
            this.cblMealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblMealPlan.ForeColor = System.Drawing.Color.Cyan;
            this.cblMealPlan.FormattingEnabled = true;
            this.cblMealPlan.Items.AddRange(new object[] {
            "No Meals",
            "Breakfast",
            "Three Meals"});
            this.cblMealPlan.Location = new System.Drawing.Point(404, 208);
            this.cblMealPlan.Name = "cblMealPlan";
            this.cblMealPlan.Size = new System.Drawing.Size(125, 130);
            this.cblMealPlan.TabIndex = 11;
            this.cblMealPlan.SelectedIndexChanged += new System.EventHandler(this.cblMealPlan_SelectedIndexChanged);
            // 
            // frmTropicalVacay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(682, 515);
            this.Controls.Add(this.cblMealPlan);
            this.Controls.Add(this.cblRoomType);
            this.Controls.Add(this.cblCity);
            this.Controls.Add(this.lblVacayTotal);
            this.Controls.Add(this.lblMealPlan);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblDepature);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtInstructions);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "frmTropicalVacay";
            this.Text = "Tropical Vacay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblMealPlan;
        private System.Windows.Forms.Label lblVacayTotal;
        private System.Windows.Forms.CheckedListBox cblCity;
        private System.Windows.Forms.CheckedListBox cblRoomType;
        private System.Windows.Forms.CheckedListBox cblMealPlan;
    }
}

