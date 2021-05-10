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
    public partial class Register : Form
    {
        LoginCredential newRegister;

        public Register()
        {
            InitializeComponent();
        }

        private void TambahData()
        {
            if (tbName.Text != "" && tbUsername.Text != "" & tbPassword.Text != "")
            {
                using (var dB = new ModelDB())
                {
                    newRegister = new LoginCredential
                    {
                        Username = tbUsername.Text,
                        Password = tbPassword.Text,
                        Nama = tbName.Text,
                    };
                    dB.LoginCredentials.Add(newRegister);
                    dB.SaveChanges();
                    MessageBox.Show("Login Ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nama, Username, dan Password harus diisi");
            }
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            TambahData();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
