using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_practice
{
    public partial class showall : Form
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
        public showall()
        {
            InitializeComponent();
        }

        private void btnShowSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from register where id=@id ",con);
                da.SelectCommand.Parameters.AddWithValue("@id",txtShowId.Text);
                dt = new DataTable();
                da.Fill(dt);
                dgvShowAll.DataSource = dt;
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

        private void showall_Load(object sender, EventArgs e)
        {
            // to select all data  
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from register",con);
                dt = new DataTable();
                da.Fill(dt);
                dgvShowAll.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }
    }
}

