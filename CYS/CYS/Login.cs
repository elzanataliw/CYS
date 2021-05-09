using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CYS.Models;

namespace CYS
{
    public partial class Login : Form
    {
        LoginCredential newLogin;
        
        public Login()
        {
            InitializeComponent();
            bool loginStatus;
        }

        private string GetUserPassword(string LoginName)
        {
            using (var db = new ModelDB())
            {
                var user = db.LoginCredentials.Where(o => o.Username.ToLower().Equals(LoginName));
                if (user.Any())
                    return user.FirstOrDefault().Password;
                else
                    return string.Empty;
            }
        }

        public void LogIn()
        {
           
        }

        private void btSignin_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regist = new Register();
            regist.Show();
            this.Hide();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
