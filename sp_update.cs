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
    public partial class sp_update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;



        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";

        public sp_update()
        {
            InitializeComponent();
        }

        private void lnkSpUpdateBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void cmbSpUpdateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select * from register where id=@id",con);
                cmd.Parameters.AddWithValue("@id",cmbSpUpdateId.Text);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    txtSpUpdateName.Text = dr[1].ToString();
                    txtSpUpdateAge.Text = dr[2].ToString();
                    txtSpUpdateDept.Text = dr[3].ToString();
                    txtSpUpdateCollege.Text = dr[4].ToString();
                    cmbSpUpdateCity.Text = dr[5].ToString();

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

        private void btnSpUpdateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cmbSpUpdateId.Text);
                cmd.Parameters.AddWithValue("@name",txtSpUpdateName.Text);
                cmd.Parameters.AddWithValue("@age", txtSpUpdateAge.Text);
                cmd.Parameters.AddWithValue("@dept", txtSpUpdateDept.Text);
                cmd.Parameters.AddWithValue("@college", txtSpUpdateCollege.Text);
                cmd.Parameters.AddWithValue("@City", cmbSpUpdateCity.Text);
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

        private void sp_update_Load(object sender, EventArgs e)
        {
            display();
        }
        void display()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select id from register", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbSpUpdateId.Items.Add(dr["id"].ToString());
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
