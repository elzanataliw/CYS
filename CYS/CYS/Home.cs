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
        Tips tip = new Tips();

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
            quiz.Activate();
            Close();
        }

        private void btTips_Click(object sender, EventArgs e)
        {
            tip.();
            Close();
            this.Home_Load(null, EventArgs.Empty);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            //condition for login stats
            if (LoginHandler.loginstatus)
            {
                btSignin.Text = "log out";                      
                label2.Text = "Hello " + LoginHandler.username + "!";
                btTakequiz.Enabled = true;
                MessageBox.Show(LoginHandler.username);
            }
            else
            {
                btSignin.Text = "sign in";
                label2.Text = "Hello Guest!";
                btTakequiz.Enabled = false;
                MessageBox.Show(LoginHandler.username);
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
                LoginHandler.loginstatus = false;
            }

            //refresh form to load recent changes at login info
            this.Home_Load(null, EventArgs.Empty);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}