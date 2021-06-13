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
    public partial class quiz4_2 : Form
    {
        public quiz4_2()
        {
            InitializeComponent();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            IngredientsAnswer.IsUsingBHAetc = true;

            quiz5 quiz5 = new quiz5();
            quiz5.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            quiz5 quiz5 = new quiz5();
            quiz5.Show();
            this.Hide();
        }
    }
}
