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
    public partial class quiz4_1 : Form
    {
        public quiz4_1()
        {
            InitializeComponent();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsUsingRetinol = true;

            quiz4_2 quiz = new quiz4_2();
            quiz.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            quiz4_2 quiz = new quiz4_2();
            quiz.Show();
            this.Hide();
        }
    }
}
