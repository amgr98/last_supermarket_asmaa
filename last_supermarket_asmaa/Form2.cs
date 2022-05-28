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
    public partial class Form2 : Form
    {
        PointOfSalyEntities db = new PointOfSalyEntities();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtProuductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || txtPrice.Text == "" || txtProuductName.Text == "")
            {
                MessageBox.Show("Please complete the information");
            }
            else
            {
                prodcuct x = new prodcuct();
                x.Name = txtProuductName.Text;
                x.Price= decimal.Parse(txtPrice.Text);
                x.Code=txtBarcode.Text;
                x.Notes=txtNots.Text;
                x.Quantity=int.Parse(txtQuantity.Text);
                db.prodcucts.Add(x);
                db.SaveChanges();

                MessageBox.Show("The product has been saved correctly");



            }
        }
    }
}
