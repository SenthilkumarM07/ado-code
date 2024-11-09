using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_practice
{
    public partial class tire_architecture : Form
    {
        methods objmethod;
        details objdetails;
        public tire_architecture()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tire_architecture_Load(object sender, EventArgs e)
        {
            //to show in grid view
            objmethod = new methods();
            dgvTire.DataSource = objmethod.showall();

            //to display id in combo box
            objmethod = new methods();
            ArrayList li = new ArrayList();
            li = objmethod.loadpage_Update();
            foreach(var o in li )
            {
                cmbTireUpdateId.Items.Add(o.ToString());
            }
        }

        private void btnTireSubmit_Click(object sender, EventArgs e)
        {
            objdetails = new details();
            objmethod = new methods();
            objdetails.username = txtTireUserName.Text;
            objdetails.mailid = txtTireMailId.Text;
            objdetails.password = txtTirePassword.Text;
            int res = objmethod.insert_method(objdetails);
            if (res >= 1)
            {
                MessageBox.Show("inserted successfully");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            objdetails = new details();
            objmethod = new methods();
            objdetails.username = txtTireDelUserName.Text;
            int res = objmethod.delete_method(objdetails);
            if (res >= 1)
            {
                MessageBox.Show("deleted successfully");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objdetails = new details();
            objmethod = new methods();
            objdetails.id= txtTireID.Text;
            dgvTire.DataSource=objmethod.search(objdetails);

        }

        private void dgvTire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTireUpdateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            objmethod= new methods();
            objdetails=new details();
            objdetails.id=cmbTireUpdateId.Text;
            objdetails = objmethod.combobox_binding(objdetails);
            txtTireUpdateName.Text=objdetails.username;
            txtTireUpdateMailId.Text = objdetails.mailid;
            txtTireUpdatePassword.Text = objdetails.password;
            //objdetails.username = txtTireUserName.Text;
        }

        private void pnlTire_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTirePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTireMailId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTireUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTireDelUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTiredelUsername_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTireID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            objdetails = new details();
            objmethod = new methods();
            objdetails.id = cmbTireUpdateId.Text;
            objdetails.username = txtTireUpdateName.Text;
            objdetails.mailid = txtTireUpdateMailId.Text;
            objdetails.password = txtTireUpdatePassword.Text;
            int res = objmethod.update_method(objdetails);
                 if (res >= 1)
            {
                MessageBox.Show("updated successfully");
            }
            else
            {
                MessageBox.Show("Not updated");
            }
        



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
