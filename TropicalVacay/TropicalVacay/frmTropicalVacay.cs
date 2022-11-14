using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TropicalVacay
{

    public partial class frmTropicalVacay : Form
    {
        public double price = 0.0;
        public const double atlBase = 500.00;
        public const double dallasBase = 450.00;
        public const double chicBase = 600.00;
        public const double losBase = 395.00;
        public const double miamiBase = 475.00;
        public const double nyBase = 550.00;
        public const double queen = 100.00;
        public const double king = 150.00;
        public const double suite = 225.00;
        public const double breakfast = 30.00;
        public const double threeMeals = 75.00;

        public frmTropicalVacay()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cblCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblCity.SelectedIndex == 0)
                price += atlBase;
            if (cblCity.SelectedIndex == 1)
                price += chicBase;
            if (cblCity.SelectedIndex == 2)
                price += dallasBase;
            if (cblCity.SelectedIndex == 3)
                price += losBase;
            if (cblCity.SelectedIndex == 4)
                price += miamiBase;
            if (cblCity.SelectedIndex == 5)
                price += nyBase;

        }

        private void cblRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblRoomType.SelectedIndex == 0)
                price += queen;
            if (cblRoomType.SelectedIndex == 1)
                price += king;
            if (cblRoomType.SelectedIndex == 2)
                price += suite;
        }

        private void cblMealPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblMealPlan.SelectedIndex == 0)
                price += 0;
            if (cblMealPlan.SelectedIndex == 1)
                price += breakfast;
            if (cblMealPlan.SelectedIndex == 2)
                price += threeMeals;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lblVacayTotal.Text = "Total: $" + price.ToString();
        }
    }
}
