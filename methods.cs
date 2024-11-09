using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;//to coll arraylist

namespace ado_practice
{
    class methods
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog=ado;integrated security=true";


        public int insert_method(details objdetails)
        {
            int res = 0;
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("insert into login values (@username,@mailid,@password)",con);
                cmd.Parameters.AddWithValue("@username", objdetails.username);
                cmd.Parameters.AddWithValue("@mailid", objdetails.mailid);
                cmd.Parameters.AddWithValue("@password", objdetails.password);
                res = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               
            }
            finally
            {

                con.Close();
            }
            return res;

        }

        public DataTable showall()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select *from login",con);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public int delete_method(details objdetails)
        {
            int res = 0;
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da= new SqlDataAdapter ("delete from login where username=@name", con);
                da.SelectCommand.Parameters.AddWithValue("@name",objdetails.username);
                dt = new DataTable();
                da.Fill(dt);
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return res;
        }

        public DataTable search(details objdetails)
        {
            
            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter("select * from login where id=@id",con);
                da.SelectCommand.Parameters.AddWithValue("@id",objdetails.id);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
            return dt;
        }


        public int update_method(details objdetails)
        {
            int res = 0;
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("update login set username=@name,mailid=@mailid,password=@password where id=@id",con);
                cmd.Parameters.AddWithValue("@id", objdetails.id);
                cmd.Parameters.AddWithValue("@name", objdetails.username);
                cmd.Parameters.AddWithValue("@mailid",objdetails.mailid);
                cmd.Parameters.AddWithValue("@password",objdetails.password);
                res = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        public details combobox_binding(details objdetails)
        {
            
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select * from login where id=@id",con);
                cmd.Parameters.AddWithValue("@id",objdetails.id);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    objdetails.username = dr[1].ToString();
                    objdetails.mailid=dr[2].ToString();
                    objdetails.password = dr[3].ToString();
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return objdetails;
        }

        ArrayList al = new ArrayList();
        public ArrayList loadpage_Update()
        {
            try{

                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("select id from login", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    al.Add(dr[0]).ToString();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return al;
        }
    }
}
