using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//step 1 
using System.Data;
using System.Data.SqlClient;

namespace ado_practice
{
   // DESKTOP-QGETDS4\SQLEXPRESS
    public partial class Form1 : Form
    {

        //step 2 
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;


       // step 3
        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegName_Click(object sender, EventArgs e)
        {

        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible = true;
            pnlDelete.Visible = false;
            pnlProcedure.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            //creating object for another page to load
            showall s = new showall();
            s.Show();
            this.Hide();
        }

        private void txtDelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDelete.Visible =true;
            pnlRegister.Visible = false;
            pnlProcedure.Visible = false;
        }

        private void lnlProcedure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlProcedure.Visible = true;
            pnlDelete.Visible = false;
            pnlRegister.Visible = false;
        }

        private void btnRegSubmit_Click(object sender, EventArgs e)
        {
            //query to insert 
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("insert into register values(@name,@age,@dept,@college,@city)", con);
                cmd.Parameters.AddWithValue("@name", txtRegName.Text);
                cmd.Parameters.AddWithValue("@age", txtRegAge.Text);
                cmd.Parameters.AddWithValue("@dept", txtRegDept.Text);
                cmd.Parameters.AddWithValue("@college", txtRegCollege.Text);
                cmd.Parameters.AddWithValue("@city", cmbRegCity.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                }
                else
                {
                    MessageBox.Show(" Not Inserted ");
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //query to delete particular column
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("delete from register where name=@name",con);
                cmd.Parameters.AddWithValue("@name",txtDelName.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show(" Not Deleted ");
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnProInsert_Click(object sender, EventArgs e)
        {
            //procedure insert 
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;//procedure 
                cmd.Parameters.AddWithValue("@name", txtRegName.Text);
                cmd.Parameters.AddWithValue("@age", txtRegAge.Text);
                cmd.Parameters.AddWithValue("@dept", txtRegDept.Text);
                cmd.Parameters.AddWithValue("@college", txtRegCollege.Text);
                cmd.Parameters.AddWithValue("@city", cmbRegCity.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully using procedure");
                }
                else
                {
                    MessageBox.Show(" Not Inserted  using procedure");
                }

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            //procedure delete

            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtDelName.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Deleted Successfully using procedure");
                }
                else
                {
                    MessageBox.Show(" Not Deleted using procedure");
                }

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            sp_update u = new sp_update();
            u.Show();
            this.Hide();
        }

        private void btnProSelect_Click(object sender, EventArgs e)
        {

            procedure pr = new procedure();
            pr.Show();
            this.Hide();
            
        }

        private void cmbRegCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            procedure p1 = new procedure();
            p1.Show();
            this.Hide();
        }

        private void btnTwoTable_Click(object sender, EventArgs e)
        {
            two_gridviewcs t =  new two_gridviewcs();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tire_architecture t = new tire_architecture();
            t.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            update u = new update();
            u.Show();
            this.Hide();
        }
    }
}
