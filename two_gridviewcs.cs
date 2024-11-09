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
    public partial class two_gridviewcs : Form
    {
        //step 2 
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;


        // step 3
        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";

        public two_gridviewcs()
        {
            InitializeComponent();
        }

        private void two_gridviewcs_Load(object sender, EventArgs e)
        {
            show();
        }
        void show()
        {
            try
            {
                con =  new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from register",con);
                da1 = new SqlDataAdapter("select * from register1",con);
                ds = new DataSet();
                da.Fill(ds,"tb1");
                da1.Fill(ds,"tb2");
                dgvTableRegister.DataSource=ds.Tables[0];
                dgvTableRegister1.DataSource = ds.Tables[1];
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

        private void lnkHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
