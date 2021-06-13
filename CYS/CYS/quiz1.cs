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
    public partial class quiz1 : Form
    {
        public quiz1()
        {
            InitializeComponent();
        }

        private void btnCowo_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz2 quiz = new quiz2();
            quiz.Show();
        }

        private void btnCewe_Click(object sender, EventArgs e)
        {
            this.Hide();
            quiz1_1 quiz = new quiz1_1();
            quiz.Show();
        }
    }
}
