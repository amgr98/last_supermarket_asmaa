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
        prodcuct model=new prodcuct();
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
            Cler();
            pdgv();
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
                Cler();

                MessageBox.Show("Please complete the information");
            }
            else
            {
                 
                model.Name = txtProuductName.Text;
                model.Price= decimal.Parse(txtPrice.Text);
                model.Code=txtBarcode.Text;
                model.Notes=txtNots.Text;
                model.Quantity=int.Parse(txtQuantity.Text);



                    db.prodcucts.Add(model);
                db.SaveChanges();
                
                Cler();
                pdgv();

                MessageBox.Show("The product has been saved correctly");



            }
        }
        void pdgv()
        {
            
            
                dataGridView1.DataSource = db.prodcucts.ToList<prodcuct>();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cler();
        }
        void Cler()
        {
            txtBarcode.Text = txtBarcode.Text = txtNots.Text = txtProuductName.Text = txtQuantity.Text =txtPrice.Text ="";
            btnSave.Text = "save";
            btnDelet.Enabled=false;
            model.id=0;
        }
    }
}
