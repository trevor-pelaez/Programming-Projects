﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class frmDailySpecial : Form
    {
        public frmDailySpecial()
        {
            InitializeComponent();
        }
        enum Day
        { 
            SUNDAY = 1, MONDAY = 2, TUESDAY = 3, WEDNESDAY = 4, THURSDAY = 5, FRIDAY = 6, SATURDAY = 7,
        }
        private void specialButton_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dayBox.Text);
            string special;
            switch ((Day)day)
            {
                case Day.SUNDAY:
                    special = "fried chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - closed";
                    break;
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                    special = "meat loaf";
                    break;
                case Day.FRIDAY:
                    special = "fish fry";
                    break;
                case Day.SATURDAY:
                    special = "liver and onions";
                    break;
                default:
                    special = "Invalid day";
                    break;

            }
            outputLabel.Text = "Today's special is " + special;
        }
    }
}
