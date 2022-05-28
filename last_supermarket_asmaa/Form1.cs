using last_supermarket_asmaa.Data;
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
    public partial class Form1 : Form
    {
        PointOfSalyEntities db = new PointOfSalyEntities();

        private List<User> _users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            User user1 = new User("ad0425", "12340");
            User user2 = new User("ad0424", "12341");
            _users.Add(user1);
            _users.Add(user2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            foreach (var user in _users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    Form2 frm = new Form2();
                    frm.usernameright = txtUsername.Text;
                    frm.ShowDialog();
                }
              //طريقة اخرى ل تسجيل الدخول عن طريق حفظ المعلومات في  الداتا بيس علما بأن الطريقتان تعملان معا في نفس الوقت

                    if (db.USERS.Where(x => x.UserName == username).Any() && db.USERS.Where(x => x.Password == password).Any())
                    {
                        Form2 frm = new Form2();
                        frm.usernameright = txtUsername.Text;
                        frm.ShowDialog();
                    }
                else
                {

                    {
                        MessageBox.Show("Try Agin");
                    }
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
