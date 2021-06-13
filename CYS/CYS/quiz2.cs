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
    public partial class quiz2 : Form
    {
        public quiz2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var checkedButton = panelRB.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                IngredientsAnswer.TargetCondition = checkedButton.Text.ToString();

                quiz3 quiz = new quiz3();
                quiz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Harap pilih pilihan diatas");
            }
            
        }
    }
}
