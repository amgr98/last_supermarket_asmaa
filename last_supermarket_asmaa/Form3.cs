﻿using last_supermarket_asmaa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_supermarket_asmaa
{
    public partial class Form3 : Form
    {
        PointOfSalyEntities db = new PointOfSalyEntities();
        public Form3()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            db.USERS.Add(user);
            db.SaveChanges();
            MessageBox.Show("Your password is :"+txtPassword.Text +"\n"+"your Username is :"+txtUsername.Text+"\n"+"please do not forget them!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {;
            this.Hide();

            frm.ShowDialog();
        }
    }
}
