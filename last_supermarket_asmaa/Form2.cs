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
    public partial class Form2 : Form
    {
        public string usernameright { get; set; }
        public Form2()
        {
            InitializeComponent();

           
        }
        Form1 frm = new Form1();

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "welcome : " + usernameright;
        }
    }
}
