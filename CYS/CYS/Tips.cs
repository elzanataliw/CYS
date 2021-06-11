﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYS
{
    public partial class Tips : Form
    {
        

        public Tips()
        {
            InitializeComponent();
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            label2.Text = "You have the freedom to test products you want to try, " +
                "but don't try too many at once. " +
                "Stick with a few staples and " +
                "keep your routine persistent — results take time.";
        }

        private void btDry_Click(object sender, EventArgs e)
        {
            label2.Text = "Avoid overwashing your skin, " +
                "you have to choose a moisturizer with a thick consistency.";
        }

        private void btOily_Click(object sender, EventArgs e)
        {
            label2.Text = "If you have oily skin, consider double-cleansing. " +
                "Double cleansing can help remove the makeup or dirt on " +
                "your skin at the end of the day without leaving anything behind. " +
                "To double-cleanse, start with an oil-based cleanser and " +
                "follow up with a water-based cleanser or micellar water. "
        }

        private void btCombi_Click(object sender, EventArgs e)
        {
            
        }

        private void btSensi_Click(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {

            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void Tips_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
