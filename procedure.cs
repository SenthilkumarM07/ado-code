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
    public partial class procedure : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";

        public procedure()
        {
            InitializeComponent();
        }

        private void lnkProcedureback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void procedure_Load(object sender, EventArgs e)
        {
            gridshow();
            gridparticularcolumnshow();
        }

        void gridparticularcolumnshow()
        {
            try
            {

                con = new SqlConnection(s);
                da = new SqlDataAdapter("sp_select_col", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvSpShowCol.DataSource = dt;
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

        void gridshow()
        {
            try
            {

                con = new SqlConnection(s);
                da = new SqlDataAdapter("sp_select", con);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da.Fill(dt);
                dgvSpShow.DataSource = dt;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
