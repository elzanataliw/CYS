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
    public partial class quiz1_1 : Form
    {
        public quiz1_1()
        {
            InitializeComponent();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsPregnant = true;

            this.Hide();
            quiz2 quiz = new quiz2();
            quiz.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz2 quiz = new quiz2();
            quiz.Show();
        }
    }
}
