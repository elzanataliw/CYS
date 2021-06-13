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
    public partial class IngredientsShow : Form
    {
        public IngredientsShow()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void IngredientsShow_Load(object sender, EventArgs e)
        {
            using (var db = new ModelDb())
            {
                var query = from ingridient in db.ingridients select ingridient;
                foreach (var item in query)
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = item.NamaBahan.ToString();
                    items.SubItems.Add(item.DeskripsiBahan.ToString());

                    lstViewBahan.Items.Add(items);
                }
            }
        }
    }
}
