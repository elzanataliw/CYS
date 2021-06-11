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
        public bool loginStatus { get; set; }
        public string UserID { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void GetLoginStatus(string LoginName, string LoginPass)
        {
            using (var db = new ModelDB())
            {

                //get query for matching txtbox text and database
                var query = from LoginCredential in db.LoginCredentials where LoginCredential.Username == LoginName && LoginCredential.Password==LoginPass select LoginCredential;
                if (query.Any())
                {
                    loginStatus = true;
                    UserID = LoginName;
                }
                else
                    loginStatus = false;
            }
        } 

        private void btSignin_Click(object sender, EventArgs e)
        {

            GetLoginStatus(tbUsername.Text.ToString(), tbPassword.Text.ToString());

            if (loginStatus)
            {
                MessageBox.Show("Login Berhasil!");
                LoginHandler.username = tbUsername.Text.ToString();
                LoginHandler.loginstatus = true;
                Close();
            }
            else
            {
                MessageBox.Show("Username atau password Anda salah");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regist = new Register();
            regist.ShowDialog();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
