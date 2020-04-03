using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.DAO;
using Kouvee_Pet_Shop.Control;
using Kouvee_Pet_Shop.UC;

namespace Kouvee_Pet_Shop.Boundary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Login LC = new Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (LC.Valid(txtUser.Text, txtPass.Text) == true)
            //{
                this.Hide();
                FormUtama fu = new FormUtama();
                // fu.setlabel(txtUser.Text);
                fu.ShowDialog();
                this.Close();
            //}
            //else
            //{
                MessageBox.Show("Username atau Password Salah");
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void lupapassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormForgotPassword fp = new FormForgotPassword();
            fp.ShowDialog();
            this.Close();
        }
    }
}
