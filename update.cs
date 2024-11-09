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
    public partial class update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;


        
        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";

        public update()
        {
            InitializeComponent();
        }

        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("update  register set name=@name,age=@age,dept=@dept,college=@college,city=@city where id=@id ", con);
                cmd.Parameters.AddWithValue("@id", cmbUpdateId.Text);
                cmd.Parameters.AddWithValue("@name",txtUpdateName.Text);
                cmd.Parameters.AddWithValue("@age", txtUpdateAge.Text);
                cmd.Parameters.AddWithValue("@dept", txtUpdateDept.Text);
                cmd.Parameters.AddWithValue("@college", txtUpdateCollege.Text);
                cmd.Parameters.AddWithValue("@City", cmbUpdateCity.Text);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    MessageBox.Show("UPDATED  SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show(" NOT UPDATED ");

                }


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

        private void update_Load(object sender, EventArgs e)
        {
            displayId();
        }
        void displayId()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select id from register", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbUpdateId.Items.Add(dr["id"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }   
        }

        private void cmbUpdateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select * from register where id=@id",con);
                cmd.Parameters.AddWithValue("@id",cmbUpdateId.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtUpdateName.Text=dr["name"].ToString();
                    txtUpdateAge.Text = dr["age"].ToString();
                    txtUpdateDept.Text = dr["dept"].ToString();
                    txtUpdateCollege.Text = dr["college"].ToString();
                    cmbUpdateCity.Text = dr["city"].ToString();
                }
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
    }
}
