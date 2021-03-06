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
    public partial class quiz3 : Form
    {
        private int checkCounter;

        public quiz3()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkCounter == 2)
            {
                List<string> selectedValues = panelCB.Controls.Cast<CheckBox>()
                .Where(li => li.Checked)
                .Select(li => li.Text)
                .ToList();

                IngredientsAnswer.SkinWishCondition1 = selectedValues[0];
                IngredientsAnswer.SkinWishCondition2 = selectedValues[1];

                quiz4_1 quiz = new quiz4_1();
                this.Hide();
                quiz.Show();
            }
            else
            {
                MessageBox.Show("Harap pilih 2 pilihan diatas!");
            }
            
        }
         

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            // Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;

            // prevent checking
            if (checkCounter > 2)
            {
                MessageBox.Show("Pilihan Tidak Boleh Lebih Dari 2!");
                lblWarning.Visible = true;
                box.Checked = false;
            }

        }

        private void cbLembab_CheckedChanged_1(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void cbNoAcne_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void cbAntiAging_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void cbToneBalace_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }

        private void cbDaily_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged(sender, e);
        }
    }
        
}

