using System;
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
    public partial class quiz5 : Form
    {
        quiz6 quiz6 = new quiz6();
        public quiz5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz6.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsSPF = true;
            this.Hide();
            quiz6.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsSPF = true;
            this.Hide();
            quiz6.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsSPF = true;
            this.Hide();
            quiz6.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsSPF = true;
            this.Hide();
            quiz6.Show();
        }
    }
}
