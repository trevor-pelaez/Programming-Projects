using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class frmEggsInteractiveGUI : Form
    {
        public frmEggsInteractiveGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int DOZEN = 12;
            int chicken1, chicken2, chicken3, chicken4, chicken5;
            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);
            chicken5 = Convert.ToInt32(txtChicken5.Text);  
            int total = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            int dozen = total / DOZEN;
            int leftOver = total % DOZEN;
            lblCalculation.Text = total + " eggs is " + dozen + " dozen and " + leftOver;
        }
    }
}
