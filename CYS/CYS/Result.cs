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
    public partial class Result : Form
    {
        List<string> Nama= new List<string>();
        List<string> Desc = new List<string>();
        int counter = 0;

        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            using (var db = new ModelDb())
            {
                var query = from IngredientsLogic in db.IngredientsLogics select IngredientsLogic;


                foreach (var item in query)
                {

                    if (item.isPregnant == null)
                    {
                        item.isPregnant = IngredientsAnswer.IsPregnant;
                    }
                    if (item.isUsingBHAetc == null)
                    {
                        item.isUsingBHAetc = IngredientsAnswer.IsUsingBHAetc;
                    }
                    if (item.isUsingRetinol == null)
                    {
                        item.isUsingRetinol = IngredientsAnswer.IsUsingRetinol;
                    }

                    bool status =
                        item.isPregnant == IngredientsAnswer.IsPregnant &&
                        item.isUsingBHAetc == IngredientsAnswer.IsUsingBHAetc &&
                        item.isUsingRetinol == IngredientsAnswer.IsUsingRetinol &&
                        item.targetCondition.Contains(IngredientsAnswer.TargetCondition) &&
                        item.skinWishCondition.Contains(IngredientsAnswer.SkinWishCondition1) &&
                        item.skinWishCondition.Contains(IngredientsAnswer.SkinWishCondition2);

                    if (status)
                    {
                        int itemId = item.ingredientsId;

                        var q = from ingridient in db.ingridients where ingridient.Id == itemId select ingridient;
                        foreach (var i in q)
                        {
                            Nama.Add(i.NamaBahan);
                            Desc.Add(i.DeskripsiBahan);
                        }
                    }
                }
            }

            if (!IngredientsAnswer.IsSPF)
            {
                Desc.RemoveAt(Nama.IndexOf("SPF"));
                Nama.Remove("SPF");
            }

            if (Nama.Any())
            {
                lblName.Text = Nama[counter];
                lblDesc.Text = Desc[counter];
            }

            

            if (counter-1 > 0)
            {
                btnSebelumnya.Enabled = true;
            }
            else
            {
                btnSebelumnya.Enabled = false;
            }
            if (counter + 1 >= Nama.Count)
            {
                btnSelanjutnya.Enabled = false;
            }
            else
            {
                btnSelanjutnya.Enabled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnSebelumnya_Click(object sender, EventArgs e)
        {

            counter--;
            lblName.Text = Nama[counter];
            lblDesc.Text = Desc[counter];

            if (counter - 1 >= 0)
            {
                btnSebelumnya.Enabled = true;
            }
            else
            {
                btnSebelumnya.Enabled = false;
            }

            if (counter + 1 >= Nama.Count)
            {
                btnSelanjutnya.Enabled = false;
            }
            else
            {
                btnSelanjutnya.Enabled = true;
            }

        }

        private void btnSelanjutnya_Click(object sender, EventArgs e)
        {
            

            counter++;
            lblName.Text = Nama[counter];
            lblDesc.Text = Desc[counter];

            if (counter - 1 >= 0)
            {
                btnSebelumnya.Enabled = true;
            }
            else
            {
                btnSebelumnya.Enabled = false;
            }
            if (counter + 1 >= Nama.Count)
            {
                btnSelanjutnya.Enabled = false;
            }
            else
            {
                btnSelanjutnya.Enabled = true;
            }
        }
        
    }
}
