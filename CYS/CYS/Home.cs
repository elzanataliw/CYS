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
    public partial class Home : Form
    {

        Login login = new Login();

        public Home()
        {
            InitializeComponent();
            
        }


        private void btIngredient_Click(object sender, EventArgs e)
        {

        }

        private void btTakequiz_Click(object sender, EventArgs e)
        {
            Skinquiz quiz = new Skinquiz();
            quiz.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //condition for login stats
            if (login.loginStatus)
            {
                btSignin.Text = "log out";                      
                label2.Text = "Hello " + login.UserID + "!";
                btTakequiz.Enabled = true;
            }else
            {
                btSignin.Text = "sign in";
                label2.Text = "Hello Guest!";
                btTakequiz.Enabled = false;
            }
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            
        }

        private void btSignin_Click(object sender, EventArgs e)
        {
            if (btSignin.Text.ToString()== "sign in")
            {
                login.ShowDialog();
            }else if (btSignin.Text.ToString()== "log out")
            {
                login.loginStatus = false;
            }

            //refresh form to load recent changes at login info
            this.Home_Load(null, EventArgs.Empty);

        }
    }
}
